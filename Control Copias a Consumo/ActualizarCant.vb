Imports System.Runtime.InteropServices
Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class ActualizarCant

    ' Declara la conexión a nivel de clase
    Private conexion As SqlConnection
    Private cadenaConexion As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

    Private Sub ActualizarCant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Permitir arrastrar el formulario
        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        AddHandler Panel1.MouseDown, AddressOf Form_MouseDown

        ' Inicializar la conexión
        conexion = New SqlConnection(cadenaConexion)
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Bloquear la edición de los TextBox
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
    End Sub

    ' Permitir mover el formulario
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, &H112&, &HF012&, 0)
        End If
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub ActualizarCant_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Cerrar la conexión al salir
        If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    ' Método para buscar por No_Pieza y mostrar el resultado en TextBox3
    Private Sub BuscarPorNoPieza(noPieza As String)
        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()

                ' Consultar solo la cantidad de la pieza
                Dim query As String = "SELECT Cantidad FROM Almacen WHERE No_Pieza = @NoPieza"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NoPieza", noPieza)

                    Dim resultado As Object = command.ExecuteScalar() ' Obtener un único valor

                    If resultado IsNot Nothing Then
                        TextBox3.Text = resultado.ToString() ' Mostrar la cantidad en TextBox3
                    Else
                        MessageBox.Show($"El elemento con No_Pieza '{noPieza}' no se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox2.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim noPieza As String = TextBox1.Text.Trim()

        If String.IsNullOrWhiteSpace(noPieza) Then
            MessageBox.Show("El campo de búsqueda está vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Realiza la búsqueda en la base de datos
            BuscarPorNoPieza(noPieza)
            TextBox2.Clear()
            TextBox4.Clear()
        End If
    End Sub

    ' Botón para sumar cantidades y actualizar la BD
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Verificar que TextBox3 y TextBox4 tengan valores numéricos
            Dim cantidadActual As Integer
            Dim cantidadNueva As Integer

            If Not Integer.TryParse(TextBox3.Text, cantidadActual) Then
                MessageBox.Show("La cantidad actual no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not Integer.TryParse(TextBox4.Text, cantidadNueva) Then
                MessageBox.Show("Campo Vacío.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Guardar la cantidad actual en TextBox2
            TextBox2.Text = cantidadActual.ToString()

            ' Sumar la nueva cantidad
            Dim nuevaCantidad As Integer = cantidadActual + cantidadNueva

            ' Mostrar el resultado en TextBox3
            TextBox3.Text = nuevaCantidad.ToString()

            ' Actualizar la cantidad en la base de datos
            Dim noPieza As String = TextBox1.Text.Trim()

            If String.IsNullOrWhiteSpace(noPieza) Then
                MessageBox.Show("Debe ingresar un nombre de pieza válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                Exit Sub
            End If

            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()

                Dim query As String = "UPDATE Almacen SET Cantidad = @Cantidad, Movedit = @Movedit  WHERE No_Pieza = @NoPieza"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Cantidad", nuevaCantidad)
                    command.Parameters.AddWithValue("@NoPieza", noPieza)
                    command.Parameters.AddWithValue("@Movedit", DateTime.Now) ' Actualizar a la fecha actual

                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Cantidad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information
                                        )
                    Else
                        MessageBox.Show("No se encontró el nombre de pieza en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox2.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error al realizar la actualización: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' Verificar que TextBox3 y TextBox4 tengan valores numéricos
            Dim cantidadActual As Integer
            Dim cantidadRestar As Integer

            If Not Integer.TryParse(TextBox3.Text, cantidadActual) Then
                MessageBox.Show("La cantidad actual no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not Integer.TryParse(TextBox4.Text, cantidadRestar) Then
                MessageBox.Show("Campo Vacío.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Verificar que la cantidad no sea menor a 0
            If cantidadRestar > cantidadActual Then
                MessageBox.Show("No puedes quitar más de la cantidad actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Guardar la cantidad actual en TextBox2 antes de la actualización
            TextBox2.Text = cantidadActual.ToString()

            ' Restar la cantidad
            Dim nuevaCantidad As Integer = cantidadActual - cantidadRestar

            ' Mostrar el resultado en TextBox3
            TextBox3.Text = nuevaCantidad.ToString()

            ' Obtener el número de pieza
            Dim noPieza As String = TextBox1.Text.Trim()

            If String.IsNullOrWhiteSpace(noPieza) Then
                MessageBox.Show("Debe ingresar un nombre de pieza válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                Exit Sub
            End If

            ' Actualizar la cantidad en la base de datos
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()

                Dim query As String = "UPDATE Almacen SET Cantidad = @Cantidad, Movdel = @Movdel WHERE No_Pieza = @NoPieza"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Cantidad", nuevaCantidad)
                    command.Parameters.AddWithValue("@NoPieza", noPieza)
                    command.Parameters.AddWithValue("@Movdel", DateTime.Now) ' Actualizar a la fecha actual


                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Cantidad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information
                                        )
                    Else
                        MessageBox.Show("No se encontró el nombre de pieza en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox2.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                    End If
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show($"Error al realizar la actualización: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
