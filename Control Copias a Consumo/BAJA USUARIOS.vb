Imports Microsoft.Data.SqlClient

Public Class BAJA_USUARIOS
    ' Tu cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"
    Private mousePresionado As Boolean = False
    Private posicionInicial As Point

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        mousePresionado = True
        posicionInicial = New Point(e.X, e.Y)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove
        If mousePresionado Then
            Dim nuevaPosicion As Point = Me.PointToScreen(New Point(e.X, e.Y))
            nuevaPosicion.Offset(-posicionInicial.X, -posicionInicial.Y)
            Me.Location = nuevaPosicion
        End If
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Panel1.MouseUp
        mousePresionado = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Nombre, Apellido, PuestoRol, TienePermisoAlmacen, TienePermisoEquipos, TienePermisoClientes, TienePermisoUsuarios FROM Usuarios"
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Asignar los datos al DataGridView
                        DataGridView1.DataSource = dataTable
                        MessageBox.Show("Búsqueda exitosa!")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar usuarios: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim result As DialogResult = MessageBox.Show("¿Seguro que quieres eliminar la fila?", "Confirmar eliminación", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim nombre As String = selectedRow.Cells("Nombre").Value.ToString() ' Reemplaza "Nombre" con el nombre de la columna que contiene el nombre

                ' Aquí puedes ejecutar la instrucción SQL para eliminar el usuario de la base de datos
                Try
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()

                        Dim query As String = "DELETE FROM Usuarios WHERE Nombre = @Nombre"
                        Using command As New SqlCommand(query, connection)
                            command.Parameters.AddWithValue("@Nombre", nombre)
                            command.ExecuteNonQuery()
                            MessageBox.Show("Usuario eliminado correctamente.")
                            btnBuscar.PerformClick() ' Actualizar DataGridView después de la eliminación
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar usuario: " & ex.Message)
                End Try
            End If
        ElseIf DataGridView1.SelectedRows.Count > 1 Then
            MessageBox.Show("Solo puedes eliminar una fila a la vez.")
        Else
            MessageBox.Show("Selecciona una fila para eliminar.")
        End If
    End Sub

    Private Sub BAJA_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class