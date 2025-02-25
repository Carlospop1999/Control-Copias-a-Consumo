Imports Microsoft.Data.SqlClient

Public Class BAJAS_CLIENTES
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    ' Tu cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"
    Private Sub btnBajaCliente_Click(sender As Object, e As EventArgs) Handles btnBajaCliente.Click
        ' Verificar si BusBajaCL está vacío y mostrar un mensaje en consecuencia
        If String.IsNullOrWhiteSpace(BusBajaCL.Text) Then
            MessageBox.Show("Coloque el nombre del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Realizar la búsqueda en la base de datos
        Dim query As String = "SELECT id_Nombre, Direccion, Telefono, Telefono_sec, Correo, Nombre_Contacto FROM Clientes WHERE id_Nombre = @NombreBusqueda"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Establecer el parámetro para la búsqueda
                command.Parameters.AddWithValue("@NombreBusqueda", BusBajaCL.Text)

                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Verificar si se encontraron resultados
                        If reader.Read() Then
                            ' Mostrar los valores en los TextBox respectivos
                            NomBajaCL.Text = reader("id_Nombre").ToString()
                            DirecBajaCL.Text = reader("Direccion").ToString()
                            Tel1BajaCL.Text = reader("Telefono").ToString()
                            Tel2BajaCL.Text = reader("Telefono_sec").ToString()
                            CorreoBajaCL.Text = reader("Correo").ToString()
                            ContactoBajaCL.Text = reader("Nombre_Contacto").ToString()
                        Else
                            MessageBox.Show("No se encontró ningún registro para el cliente especificado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al buscar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        Dim clienteAEliminar As String = NomBajaCL.Text

        If String.IsNullOrWhiteSpace(clienteAEliminar) Then
            MessageBox.Show("No se ha seleccionado ningún cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("¿Estás seguro que deseas eliminar al cliente " & clienteAEliminar & "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Realizar la eliminación del cliente en la base de datos
            Dim query As String = "DELETE FROM Clientes WHERE id_Nombre = @NombreCliente"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NombreCliente", clienteAEliminar)

                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Cliente eliminado de la base de datos.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Limpiar los TextBox después de la eliminación exitosa
                            NomBajaCL.Text = ""
                            DirecBajaCL.Text = ""
                            Tel1BajaCL.Text = ""
                            Tel2BajaCL.Text = ""
                            CorreoBajaCL.Text = ""
                            ContactoBajaCL.Text = ""
                        Else
                            MessageBox.Show("No se encontró ningún registro para el cliente especificado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub BAJAS_CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BAJAS_CLIENTES_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub BAJAS_CLIENTES_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub BAJAS_CLIENTES_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub BusBajaCL_TextChanged(sender As Object, e As EventArgs) Handles BusBajaCL.TextChanged

    End Sub

    Private Sub DirecBajaCL_TextChanged(sender As Object, e As EventArgs) Handles DirecBajaCL.TextChanged

    End Sub

    Private Sub Tel1BajaCL_TextChanged(sender As Object, e As EventArgs) Handles Tel1BajaCL.TextChanged

    End Sub

    Private Sub Tel2BajaCL_TextChanged(sender As Object, e As EventArgs) Handles Tel2BajaCL.TextChanged

    End Sub

    Private Sub ContactoBajaCL_TextChanged(sender As Object, e As EventArgs) Handles ContactoBajaCL.TextChanged

    End Sub

    Private Sub CorreoBajaCL_TextChanged(sender As Object, e As EventArgs) Handles CorreoBajaCL.TextChanged

    End Sub

    Private Sub NomBajaCL_TextChanged(sender As Object, e As EventArgs) Handles NomBajaCL.TextChanged

    End Sub
End Class
