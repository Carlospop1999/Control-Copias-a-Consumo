Imports ClosedXML.Excel
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices
Public Class EQUIPOS
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    'Dim connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"
    Private imagePath As String = ""

    Private Sub EQUIPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button5.Enabled = False ' Deshabilitar Button5 al cargar el formulario
        SetTextBoxesReadOnly(True) ' Establecer los TextBoxes en modo de solo lectura al inicio
        AddEventHandlers() ' Agregar manejadores de eventos para permitir el arrastre
    End Sub

    Private Sub SetTextBoxesReadOnly(ByVal [readOnly] As Boolean)
        txtMRE.ReadOnly = [readOnly]
        txtMDE.ReadOnly = [readOnly]
        txtNSE.ReadOnly = [readOnly]
        txtCLE.ReadOnly = [readOnly]
        txtULE.ReadOnly = [readOnly]
    End Sub

    Private Sub AddEventHandlers()
        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        AddHandler Panel1.MouseDown, AddressOf Form_MouseDown
        AddHandler Me.MouseMove, AddressOf Form_MouseMove
        AddHandler Panel1.MouseMove, AddressOf Form_MouseMove
        AddHandler Me.MouseUp, AddressOf Form_MouseUp
        AddHandler Panel1.MouseUp, AddressOf Form_MouseUp
    End Sub

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetTextBoxesReadOnly(False) ' Habilitar la edición de los TextBoxes
        Button5.Enabled = True ' Habilitar Button5 cuando se haga clic en Button2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Comprobar si se ha seleccionado una imagen
        If String.IsNullOrEmpty(imagePath) Then
            MessageBox.Show("Seleccione un QR para el equipo a registrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Mostrar un mensaje emergente para confirmar si se desean guardar o agregar los cambios
        Dim result = MessageBox.Show("¿Desea guardar o agregar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            GuardarDatos
            LimpiarTextBoxes
        End If
        SetTextBoxesReadOnly(True) ' Bloquear los TextBoxes


    End Sub
    Private Sub LimpiarTextBoxes()
        txtMRE.Clear()
        txtMDE.Clear()
        txtNSE.Clear()
        txtCLE.Clear()
        txtULE.Clear()
        PBQR.Image = Nothing
        txtbusquedacl.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Preguntar si se desea eliminar el registro seleccionado
        Dim confirmResult As DialogResult = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Eliminar los datos de la tabla Equipos1 que coincidan con el ID_NSerieEqu proporcionado
                    Dim query As String = "DELETE FROM Equipos WHERE ID_NSerieEQ = @ID_NSerieEqu"
                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@ID_NSerieEqu", txtbusquedacl.Text)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Mensaje de éxito si se eliminaron datos
                            MessageBox.Show("Los datos se han eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LimpiarTextBoxes() ' Limpiar los TextBox después de eliminar los datos
                        Else
                            ' Mensaje si no se encontraron datos para eliminar
                            MessageBox.Show("No se encontraron datos para eliminar con el Numero de serie proporcionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Mensaje de error si no se pudieron eliminar los datos
                MessageBox.Show("Error al realizar la eliminación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Mensaje si se decide no eliminar los datos
            MessageBox.Show("No se borraron los datos.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        SetTextBoxesReadOnly(True) ' Bloquear los TextBoxes
    End Sub


    Private Sub GuardarDatos()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Comprobar si el registro ya existe
                Dim queryCheck As String = "SELECT COUNT(*) FROM Equipos WHERE Id_NSerieEQ = @Id_NSerieEqu"
                Using cmdCheck As New SqlCommand(queryCheck, connection)
                    cmdCheck.Parameters.AddWithValue("@Id_NSerieEqu", txtNSE.Text)
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    ' Verificar si ya existe un registro con el mismo ID_NSerieEqu
                    If count > 0 AndAlso txtNSE.Text <> txtbusquedacl.Text Then
                        MessageBox.Show("Error: Ya existe un registro con el Numero de serie proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return ' Salir de la función si hay un error
                    End If
                End Using

                ' Validar que Ulti_Lectura sea un entero
                Dim ultimaLectura As Integer
                If Not Integer.TryParse(txtULE.Text, ultimaLectura) Then
                    MessageBox.Show("Error: El valor de la Lectura debe ser solo numeros/enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return ' Salir de la función si hay un error
                End If

                ' Definir la consulta SQL para la actualización o inserción
                Dim query As String = If(txtNSE.Text = txtbusquedacl.Text,
                                "UPDATE Equipos SET Marca = @Marca, Modelo = @Modelo, Cliente = @ID_Nombre, Lectura = @Ulti_Lectura, Img_QR = @ImgQR WHERE ID_NSerieEQ = @ID_NSerieEqu",
                                "INSERT INTO Equipos (ID_NSerieEQ, Marca, Modelo, Cliente, Lectura, Img_QR) VALUES (@ID_NSerieEqu, @Marca, @Modelo, @ID_Nombre, @Ulti_Lectura, @ImgQR)")
                ' Obtener la imagen como arreglo de bytes para almacenarla en la base de datos
                Dim imageBytes As Byte() = If(String.IsNullOrEmpty(imagePath), New Byte() {}, File.ReadAllBytes(imagePath))

                ' Ejecutar la consulta de actualización o inserción
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID_NSerieEqu", txtNSE.Text)
                    cmd.Parameters.AddWithValue("@Marca", txtMRE.Text)
                    cmd.Parameters.AddWithValue("@Modelo", txtMDE.Text)
                    cmd.Parameters.AddWithValue("@ID_Nombre", txtCLE.Text)
                    cmd.Parameters.AddWithValue("@Ulti_Lectura", ultimaLectura) ' Usar el valor convertido
                    cmd.Parameters.AddWithValue("@ImgQR", imageBytes)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM Equipos WHERE ID_NSerieEQ = @ID_NSerieEqu"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID_NSerieEqu", txtbusquedacl.Text)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Si se encuentra un resultado, asignar los valores a los TextBox
                            txtMRE.Text = reader("Marca").ToString()
                            txtMDE.Text = reader("Modelo").ToString()
                            txtNSE.Text = reader("ID_NSerieEQ").ToString()
                            txtCLE.Text = reader("Cliente").ToString()
                            txtULE.Text = reader("Lectura").ToString()
                            ' Verificar si hay datos en la columna Img_QR
                            If Not IsDBNull(reader("Img_QR")) Then
                                ' Obtener los datos binarios de la imagen desde la base de datos
                                Dim imageData As Byte() = DirectCast(reader("Img_QR"), Byte())

                                ' Convertir los datos binarios de la imagen a un flujo de memoria
                                Using ms As New System.IO.MemoryStream(imageData)
                                    ' Asignar la imagen desde el flujo de memoria al PictureBox
                                    PBQR.Image = Image.FromStream(ms)
                                End Using
                            Else
                                ' Si no hay datos de imagen en la base de datos, puedes asignar una imagen predeterminada o dejar el PictureBox vacío
                                PBQR.Image = Nothing ' o asignar una imagen predeterminada si lo deseas
                            End If
                        Else
                            ' Si no se encuentra un resultado, mostrar un mensaje
                            MessageBox.Show("No se encontraron resultados para el Numero de serie proporcionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al realizar la búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Abrir un cuadro de diálogo para seleccionar la imagen
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog1.Title = "Seleccionar Imagen"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Obtener la ruta de la imagen seleccionada
            imagePath = openFileDialog1.FileName

            ' Mostrar la imagen en el PictureBox
            PBQR.Image = New System.Drawing.Bitmap(imagePath)
        End If
    End Sub

    Private Sub PBQR_Click(sender As Object, e As EventArgs) Handles PBQR.Click
        ' Verificar si hay una imagen en el PictureBox
        If PBQR.Image IsNot Nothing Then
            ' Crear un nuevo formulario para mostrar la imagen a tamaño completo
            Dim imageForm As New Form()

            ' Establecer el tamaño del formulario según el tamaño de la imagen
            imageForm.ClientSize = PBQR.Image.Size

            ' Crear un PictureBox en el nuevo formulario y mostrar la imagen
            Dim pictureBoxFullScreen As New PictureBox()
            pictureBoxFullScreen.Dock = DockStyle.Fill
            pictureBoxFullScreen.Image = PBQR.Image
            pictureBoxFullScreen.SizeMode = PictureBoxSizeMode.Zoom ' Ajustar la imagen al tamaño del PictureBox

            ' Agregar el PictureBox al formulario
            imageForm.Controls.Add(pictureBoxFullScreen)

            ' Mostrar el formulario con la imagen a tamaño completo
            imageForm.ShowDialog()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            ' Definir la cadena de conexión a la base de datos (AJUSTAR SEGÚN TU DB)
            Dim connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

            ' Crear un nuevo libro de Excel
            Dim wb As New XLWorkbook()

            ' Listado de tablas a exportar
            Dim tablas As String() = {"equipos"}

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
            Dim rutaArchivo As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ExportadoEquipos_" & fechaHora & ".xlsx")


            ' Guardar el archivo
            wb.SaveAs(rutaArchivo)

            ' Mensaje de éxito
            MessageBox.Show("Las tablas se han exportado correctamente a: " & rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
