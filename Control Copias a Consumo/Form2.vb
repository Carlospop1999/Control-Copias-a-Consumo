Imports ClosedXML.Excel
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class ALMACÉN

    ' Tu cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

    Private Sub ConfigurarDataGridView(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        For Each col As DataGridViewColumn In DataGridView1.Columns

            col.ReadOnly = True ' Bloquear todas las demás columnas

        Next
    End Sub

    Private Sub ALMACÉN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el evento MouseDown para permitir arrastrar el formulario desde cualquier parte del formulario.
        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        ' Configurar el evento MouseDown para permitir arrastrar el formulario desde el panel.
        AddHandler Panel1.MouseDown, AddressOf Form_MouseDown

        ' Bloquear todas las columnas excepto "Cantidad"
        DataGridView1.AllowUserToAddRows = False ' Evita que se agreguen filas manualmente

        ' Aplicar ReadOnly después de que se carguen los datos
        AddHandler DataGridView1.DataBindingComplete, AddressOf ConfigurarDataGridView
    End Sub

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, &H112&, &HF012&, 0)
        End If
    End Sub


    'consultar imagen del datagrid
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Verificar si la celda seleccionada corresponde a la columna de la imagen (cambia "Img_Producto" por el nombre de tu columna)
        If e.ColumnIndex = DataGridView1.Columns("Img_Producto").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener los datos binarios de la celda seleccionada
            Dim imageData As Byte() = CType(DataGridView1.Rows(e.RowIndex).Cells("Img_Producto").Value, Byte())

            If imageData IsNot Nothing Then
                ' Mostrar la imagen en un nuevo formulario
                Dim imageForm As New Form()

                ' Crear una imagen desde los datos binarios
                Using ms As New MemoryStream(imageData)
                    Dim img As Image = Image.FromStream(ms)
                    Dim pictureBox As New PictureBox With {
                        .Image = img,
                        .SizeMode = PictureBoxSizeMode.Zoom,
                        .Dock = DockStyle.Fill
                    }

                    imageForm.Controls.Add(pictureBox)
                End Using

                ' Centrar el formulario en la pantalla
                imageForm.StartPosition = FormStartPosition.CenterParent
                imageForm.ShowDialog()
            End If
        End If
    End Sub


    'termina consulta de imagen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Alta_Almacen.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BAJA_ALMACEN.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CONSULTA_ALMACEN.Show()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim noPieza As String = TextBox1.Text.Trim()

        If String.IsNullOrWhiteSpace(noPieza) Then
            MessageBox.Show("El campo de búsqueda está vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Realiza la búsqueda en la base de datos y muestra los resultados en el DataGridView
            BuscarPorNoPieza(noPieza)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BuscarPorNoPieza(noPieza As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM Almacen WHERE No_Pieza = @NoPieza"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NoPieza", noPieza)

                    Using adapter As New SqlDataAdapter(command)
                        Using dataSet As New DataSet()
                            adapter.Fill(dataSet, "Almacen")

                            If dataSet.Tables("Almacen").Rows.Count > 0 Then
                                ' Si se encontraron resultados, asigna el conjunto de datos al DataGridView
                                DataGridView1.DataSource = dataSet.Tables("Almacen")
                            Else
                                ' Si no se encontraron resultados, muestra un mensaje de error
                                MessageBox.Show($"El elemento con No_Pieza '{noPieza}' no se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EDITAR_ALMACEN.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ActualizarCant.Show()
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            ' Definir la cadena de conexión a la base de datos (AJUSTAR SEGÚN TU DB)
            Dim connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

            ' Crear un nuevo libro de Excel
            Dim wb As New XLWorkbook()

            ' Listado de tablas a exportar
            Dim tablas As String() = {"almacen"}

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
            Dim rutaArchivo As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ExportadoAlmacen_" & fechaHora & ".xlsx")


            ' Guardar el archivo
            wb.SaveAs(rutaArchivo)

            ' Mensaje de éxito
            MessageBox.Show("Las tablas se han exportado correctamente a: " & rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
