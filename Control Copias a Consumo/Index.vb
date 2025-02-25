Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports ClosedXML.Excel
Imports System.IO
Public Class Index

    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Index_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verificar permisos antes de abrir la ventana
        If Form1.PermisoAlmacen Then
            ALMACÉN.Show()
        Else
            MessageBox.Show("No tienes permisos para acceder a Almacén.", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9

        Label1.Text = "Hola, " & Form1.NombreUsuarioLogueado

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ' Verificar permisos antes de abrir la ventana
        If Form1.PermisoEquipos Then
            EQUIPOS.Show()
        Else
            MessageBox.Show("No tienes permisos para acceder a Equipos.", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Verificar permisos antes de abrir la ventana
        If Form1.PermisoClientes Then
            MENU_CLIENTES.Show()
        Else
            MessageBox.Show("No tienes permisos para acceder a Clientes.", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que quieres cerrar la sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim form1 As New Form1()
            form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.Show("Cerrar Sesión.", PictureBox1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Verificar permisos antes de abrir la ventana
        If Form1.PermisoUsuarios Then
            Form4.Show
        Else
            MessageBox.Show("No tienes permisos para acceder a Usuarios.", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ' Definir la cadena de conexión a la base de datos (AJUSTAR SEGÚN TU DB)
            Dim connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

            ' Crear un nuevo libro de Excel
            Dim wb As New XLWorkbook()

            ' Listado de tablas a exportar
            Dim tablas As String() = {"almacen", "equipos", "clientes"}

            ' Abrir conexión a la base de datos
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                For Each tabla As String In tablas
                    ' Leer datos de la tabla actual
                    Dim query As String = "SELECT * FROM " & tabla
                    Using cmd As New SqlCommand(query, conn)
                        Using adapter As New SqlDataAdapter(cmd)
                            Dim dt As New DataTable()
                            adapter.Fill(dt)

                            ' Agregar los datos al archivo Excel como una nueva hoja
                            Dim ws As IXLWorksheet = wb.Worksheets.Add(dt, tabla)
                        End Using
                    End Using
                Next
            End Using

            ' Obtener la fecha y hora actual en formato seguro para nombres de archivo
            Dim fechaHora As String = DateTime.Now.ToString("ddMMyyyy_HHmmss")

            ' Construir la ruta con el nombre del archivo incluyendo la fecha y hora
            Dim rutaArchivo As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ExportadoGeneral_" & fechaHora & ".xlsx")


            ' Guardar el archivo
            wb.SaveAs(rutaArchivo)

            ' Mensaje de éxito
            MessageBox.Show("Las tablas se han exportado correctamente a: " & rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
