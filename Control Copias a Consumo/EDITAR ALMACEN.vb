Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class EDITAR_ALMACEN

    ' Reemplaza esto con tu cadena de conexión SQL Server
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"
    ' Variable para rastrear si los TextBox están bloqueados
    Private textosBloqueados As Boolean = True

    ' Variable para almacenar la fecha de la última modificación
    Private fechaModificacion As DateTime

    ' Variable para almacenar el valor original de 'No_Pieza'
    Private noPiezaOriginal As String = ""

    ' Variables para el arrastre del formulario
    Private dragging As Boolean
    Private offsetX, offsetY As Integer

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        ' Habilitar el arrastre del formulario al hacer clic en cualquier parte del formulario o del panel
        dragging = True
        offsetX = e.X
        offsetY = e.Y
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove
        ' Arrastrar el formulario mientras se mantiene presionado el botón del mouse
        If dragging Then
            Dim newX As Integer = Me.Left + e.X - offsetX
            Dim newY As Integer = Me.Top + e.Y - offsetY
            Me.Location = New Point(newX, newY)
        End If
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Panel1.MouseUp
        ' Deshabilitar el arrastre al soltar el botón del mouse
        dragging = False
    End Sub


    Private Sub EDITAR_ALMACEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamar a la función para bloquear los TextBox inicialmente
        BloquearTextBox()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Obtener el valor de búsqueda desde TextBox7
        Dim valorBuscado As String = TextBox7.Text.Trim()

        ' Verificar si el valor de búsqueda no está vacío
        If Not String.IsNullOrEmpty(valorBuscado) Then
            ' Establecer la conexión a la base de datos
            Using conexion As SqlConnection = New SqlConnection(connectionString)
                ' Abrir la conexión
                conexion.Open()

                ' Definir la consulta SQL con la condición de búsqueda
                Dim consulta As String = "SELECT Nombre, Marca, No_Pieza, Cantidad, Modelo, Proveedor,Img_Producto, Movedit FROM Almacen WHERE No_Pieza = @NombreBuscado"

                ' Crear un comando SQL
                Using comando As SqlCommand = New SqlCommand(consulta, conexion)
                    ' Agregar parámetros para la condición de búsqueda
                    comando.Parameters.AddWithValue("@NombreBuscado", valorBuscado)

                    ' Ejecutar la consulta y obtener un lector de datos
                    Using lector As SqlDataReader = comando.ExecuteReader()
                        ' Verificar si hay filas
                        If lector.Read() Then
                            ' Almacenar el valor original de 'No_Pieza'
                            noPiezaOriginal = lector("No_Pieza").ToString()

                            ' Mostrar los resultados en los TextBox
                            MostrarDatos(lector)
                        Else
                            MessageBox.Show("No se encontraron resultados para el valor buscado en 'No_Pieza'.")
                        End If
                    End Using
                End Using
            End Using
        Else
            ' Mostrar un mensaje si el valor de búsqueda está vacío
            MessageBox.Show("Por favor, ingrese un valor para buscar.")
        End If
    End Sub



    Private Sub MostrarDatos(lector As SqlDataReader)
        ' Mostrar los resultados en los TextBox
        TextBox1.Text = lector("Nombre").ToString()
        TextBox2.Text = lector("Marca").ToString()
        TextBox3.Text = lector("No_Pieza").ToString()
        TextBox4.Text = lector("Cantidad").ToString()
        TextBox5.Text = lector("Modelo").ToString()
        TextBox6.Text = lector("Proveedor").ToString()


        ' Obtener la fecha de la última modificación
        If Not IsDBNull(lector("Movedit")) Then
            fechaModificacion = DirectCast(lector("Movedit"), DateTime)
        End If

        ' Verificar si el valor de Img_Producto no es DBNull antes de intentar mostrar la imagen
        If Not IsDBNull(lector("Img_Producto")) Then
            ' Obtener los bytes de la imagen desde la base de datos
            Dim imagenBytes As Byte() = DirectCast(lector("Img_Producto"), Byte())

            ' Mostrar la imagen en el PictureBox
            Using stream As New MemoryStream(imagenBytes)
                PictureBox1.Image = Image.FromStream(stream)
            End Using
        Else
            ' Si el valor es DBNull, se puede mostrar un mensaje o dejar el PictureBox vacío
            PictureBox1.Image = Nothing ' Esto dejará el PictureBox vacío
            ' O se puede mostrar un mensaje indicando que no hay imagen disponible para mostrar
            ' MessageBox.Show("No hay imagen disponible para este registro.")
        End If

        ' Desbloquear los TextBox solo después de una búsqueda exitosa
        textosBloqueados = False
        BloquearTextBox()

        ' Mostrar mensaje de búsqueda exitosa
        MessageBox.Show("Búsqueda exitosa. Datos cargados correctamente.")
    End Sub

    Private Sub BloquearTextBox()
        ' Función para bloquear o desbloquear los TextBox según el valor de textosBloqueados
        TextBox1.ReadOnly = textosBloqueados
        TextBox2.ReadOnly = textosBloqueados
        TextBox3.ReadOnly = textosBloqueados
        TextBox4.ReadOnly = textosBloqueados
        TextBox5.ReadOnly = textosBloqueados
        TextBox6.ReadOnly = textosBloqueados
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Al hacer clic en Button4, desbloquear los TextBox solo si la búsqueda fue exitosa
        If Not textosBloqueados Then
            textosBloqueados = False
            BloquearTextBox()
        Else
            MessageBox.Show("Debes realizar una búsqueda exitosa antes de activar la edición.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Verificar si se realizaron cambios en los TextBox
        If Not textosBloqueados Then
            ' Validar que el nuevo valor de 'No_Pieza' sea único
            If Not EsNuevoNoPiezaUnico() Then
                MessageBox.Show("Ya existe un registro con el nuevo valor de 'No_Pieza'. Por favor, ingrese un valor único.")
                Return
            End If

            ' Validar que el valor de TextBox4 sea un número entero
            If Not EsNumeroEntero(TextBox4.Text) Then
                MessageBox.Show("Error: La cantidad debe ser un valor entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Preguntar al usuario si desea guardar los cambios
            Dim resultado As DialogResult = MessageBox.Show("¿Desea guardar los cambios? Seleccione la imagen del producto.", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                ' Establecer la conexión a la base de datos
                Using conexion As SqlConnection = New SqlConnection(connectionString)
                    ' Abrir la conexión
                    conexion.Open()

                    ' Definir la consulta SQL de actualización
                    Dim consulta As String = "UPDATE Almacen SET Nombre = @Nombre, Marca = @Marca, Cantidad = @Cantidad, Modelo = @Modelo, Proveedor = @Proveedor, Movedit = @Movedit, No_Pieza = @NuevoNo_Pieza"

                    ' Agregar la actualización de la imagen solo si ha cambiado
                    Dim imagenActual As Byte() = ObtenerBytesImagenActual()
                    Dim nuevaImagen As Byte() = ObtenerBytesNuevaImagen()

                    If Not SonBytesImagenIguales(nuevaImagen, imagenActual) Then
                        ' Si las imágenes son diferentes, incluir la actualización del campo Img_Producto
                        consulta &= ", Img_Producto = @NuevaImagen"
                    End If

                    ' Agregar el resto de los parámetros para la actualización
                    consulta &= " WHERE No_Pieza = @No_Pieza"

                    ' Crear un comando SQL
                    Using comando As SqlCommand = New SqlCommand(consulta, conexion)
                        ' Agregar parámetros para la actualización
                        comando.Parameters.AddWithValue("@Nombre", TextBox1.Text)
                        comando.Parameters.AddWithValue("@Marca", TextBox2.Text)
                        comando.Parameters.AddWithValue("@Cantidad", TextBox4.Text)
                        comando.Parameters.AddWithValue("@Modelo", TextBox5.Text)
                        comando.Parameters.AddWithValue("@Proveedor", TextBox6.Text)
                        comando.Parameters.AddWithValue("@Movedit", DateTime.Now) ' Actualizar a la fecha actual
                        comando.Parameters.AddWithValue("@NuevoNo_Pieza", TextBox3.Text) ' Nuevo valor de 'No_Pieza'

                        ' Agregar los parámetros de imagen solo si ha cambiado
                        If Not SonBytesImagenIguales(nuevaImagen, imagenActual) Then
                            comando.Parameters.AddWithValue("@NuevaImagen", nuevaImagen)
                        End If

                        comando.Parameters.AddWithValue("@No_Pieza", noPiezaOriginal) ' Utilizar el valor original de 'No_Pieza'

                        ' Ejecutar la actualización
                        Dim filasActualizadas As Integer = comando.ExecuteNonQuery()

                        ' Verificar si se realizaron actualizaciones
                        If filasActualizadas > 0 Then
                            MessageBox.Show("Datos actualizados correctamente.")

                            ' Limpiar los TextBox después de una actualización exitosa
                            LimpiarTextBox()

                            ' Bloquear los TextBox después de una actualización exitosa
                            textosBloqueados = True
                            BloquearTextBox()
                        Else
                            MessageBox.Show("No se realizaron cambios.")
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("No se realizaron cambios.")
            End If
        Else
            MessageBox.Show("No hay cambios para guardar. Realiza una búsqueda y modifica los datos antes de guardar.")
        End If
    End Sub


    Private Function EsNuevoNoPiezaUnico() As Boolean
        ' Validar que el nuevo valor de 'No_Pieza' sea único
        Dim consultaValidacion As String = "SELECT COUNT(*) FROM Almacen WHERE No_Pieza = @NuevoNo_Pieza AND No_Pieza <> @No_PiezaOriginal"

        ' Crear un comando SQL para validar la unicidad del nuevo No_Pieza
        Using conexion As SqlConnection = New SqlConnection(connectionString)
            conexion.Open()

            Using comandoValidacion As SqlCommand = New SqlCommand(consultaValidacion, conexion)
                comandoValidacion.Parameters.AddWithValue("@NuevoNo_Pieza", TextBox3.Text)
                comandoValidacion.Parameters.AddWithValue("@No_PiezaOriginal", noPiezaOriginal)
                Dim count As Integer = CInt(comandoValidacion.ExecuteScalar())

                ' Verificar si ya existe un registro con el nuevo No_Pieza
                Return count = 0
            End Using
        End Using
    End Function

    Private Function EsNumeroEntero(valor As String) As Boolean
        ' Función para validar que un valor es un número entero
        Dim result As Integer
        Return Integer.TryParse(valor, result)
    End Function

    Private Sub LimpiarTextBox()
        ' Función para limpiar el texto de los TextBox
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

        ' Limpiar también el PictureBox
        PictureBox1.Image = Nothing
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress

        ' Verificar si la tecla presionada es un número o la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Mostrar mensaje de error
            MessageBox.Show("Ingresa solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Cancelar la entrada de la tecla
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Function ObtenerBytesImagenActual() As Byte()
        ' Obtener los bytes de la imagen actual desde la base de datos
        ' Este método debe implementarse para obtener los bytes de la imagen actual
        ' Puedes usar la misma lógica que usaste para mostrar la imagen en la carga inicial
        ' Retorna los bytes de la imagen actual
    End Function

    Private Function SonBytesImagenIguales(bytes1 As Byte(), bytes2 As Byte()) As Boolean
        ' Compara dos conjuntos de bytes para verificar si representan la misma imagen
        ' Retorna True si son iguales; de lo contrario, False
        ' Debes implementar la lógica de comparación aquí
    End Function

    Private Sub ActualizarImagenEnBaseDeDatos(nuevaImagen As Byte())
        ' Actualizar la imagen en la base de datos
        ' Este método debe implementarse para actualizar el campo Img_Producto con la nueva imagen
        ' Utiliza la conexión a la base de datos y la consulta UPDATE para actualizar el registro
        ' Asegúrate de usar parámetros para evitar la inyección SQL
    End Sub

    Private Function ObtenerBytesNuevaImagen() As Byte()
        ' Abre el cuadro de diálogo para seleccionar una imagen del sistema
        Dim dialogo As New OpenFileDialog()
        dialogo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        dialogo.Title = "Seleccionar imagen"

        If dialogo.ShowDialog() = DialogResult.OK Then
            Try
                ' Lee la imagen seleccionada como un arreglo de bytes
                Dim imagen As Image = Image.FromFile(dialogo.FileName)
                Dim ms As New MemoryStream()
                imagen.Save(ms, imagen.RawFormat)
                Return ms.ToArray()
            Catch ex As Exception
                MessageBox.Show("Error al cargar la imagen: " & ex.Message)
            End Try
        End If

        Return New Byte() {}
    End Function

End Class