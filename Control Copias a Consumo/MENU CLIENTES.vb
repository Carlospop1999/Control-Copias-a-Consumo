Imports ClosedXML.Excel
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class MENU_CLIENTES
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BAJAS_CLIENTES.Show()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub MENU_CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.9
    End Sub

    Private Sub Control_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Control_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Control_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CLIENTES.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Definir la cadena de conexión a la base de datos (AJUSTAR SEGÚN TU DB)
            Dim connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

            ' Crear un nuevo libro de Excel
            Dim wb As New XLWorkbook()

            ' Listado de tablas a exportar
            Dim tablas As String() = {"clientes"}

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
            Dim rutaArchivo As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ExportadoClientes_" & fechaHora & ".xlsx")


            ' Guardar el archivo
            wb.SaveAs(rutaArchivo)

            ' Mensaje de éxito
            MessageBox.Show("Las tablas se han exportado correctamente a: " & rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class



