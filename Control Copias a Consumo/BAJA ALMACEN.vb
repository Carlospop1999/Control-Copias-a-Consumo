Imports Microsoft.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class BAJA_ALMACEN
    ' Tu cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub BAJA_ALMACEN_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Obtener la fila seleccionada
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Obtener el valor de la columna "No_Pieza" de la fila seleccionada
            Dim noPieza As String = DataGridView1.Rows(rowIndex).Cells("No_Pieza").Value.ToString()

            ' Obtener la cantidad a eliminar del TextBox2
            Dim cantidadAEliminar As Integer

            If Not Integer.TryParse(TextBox2.Text, cantidadAEliminar) Then
                MessageBox.Show("Ingrese una cantidad válida a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Obtener la cantidad actual en la base de datos
            Dim cantidadActual As Integer = Convert.ToInt32(DataGridView1.Rows(rowIndex).Cells("Cantidad").Value)

            ' Verificar si la cantidad a eliminar es menor o igual a la cantidad actual
            If cantidadAEliminar <= cantidadActual Then
                ' Realizar la actualización en la base de datos restando la cantidad a eliminar
                ActualizarCantidad(noPieza, cantidadAEliminar)
            Else
                MessageBox.Show("La cantidad a eliminar es mayor que la cantidad actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Seleccione una fila para realizar la eliminación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ActualizarCantidad(noPieza As String, cantidadAEliminar As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Realizar la actualización en la base de datos restando la cantidad a eliminar
                Dim query As String = "UPDATE Almacen SET Cantidad = Cantidad - @CantidadAEliminar, Movdel = GETDATE() WHERE No_Pieza = @NoPieza"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NoPieza", noPieza)
                    command.Parameters.AddWithValue("@CantidadAEliminar", cantidadAEliminar)

                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show($"Se eliminaron {cantidadAEliminar} piezas del elemento con No_Pieza '{noPieza}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Refrescar el DataGridView después de la eliminación
                        BuscarYMostrarCantidad(noPieza)
                    Else
                        MessageBox.Show($"No se pudo eliminar la cantidad especificada. Verifique la existencia y la cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al realizar la eliminación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBuscarAlmacen_Click(sender As Object, e As EventArgs) Handles btnBuscarAlmacen.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("El campo de búsqueda está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Realiza la búsqueda en la base de datos y muestra los resultados en DataGridView1
            BuscarYMostrarCantidad(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BuscarYMostrarCantidad(noPieza As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM Almacen WHERE No_Pieza = @NoPieza"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NoPieza", noPieza)

                    Using adapter As New SqlDataAdapter(command)
                        Using dataSet As New DataSet()
                            adapter.Fill(dataSet, "Almacen")

                            ' Verificar si el conjunto de datos está vacío
                            If dataSet.Tables("Almacen").Rows.Count > 0 Then
                                ' Asignar el conjunto de datos al DataGridView
                                DataGridView1.DataSource = dataSet.Tables("Almacen")
                            Else
                                ' Mostrar mensaje de advertencia si no se encontraron resultados
                                MessageBox.Show($"No se encontraron resultados para el No_Pieza '{noPieza}'.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ' Limpiar el DataGridView
                                DataGridView1.DataSource = Nothing
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtener la fila seleccionada
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Obtener el valor de la columna "No_Pieza" de la fila seleccionada
            Dim noPieza As String = DataGridView1.Rows(rowIndex).Cells("No_Pieza").Value.ToString()

            ' Preguntar al usuario si realmente desea eliminar la fila
            Dim resultado As DialogResult = MessageBox.Show($"¿Seguro que desea eliminar la fila con No_Pieza '{noPieza}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                ' Llamar a la función EliminarFila
                EliminarFila(noPieza)

                ' Limpiar los TextBox después de eliminar la fila
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
        Else
            MessageBox.Show("Seleccione una fila para realizar la eliminación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub EliminarFila(noPieza As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Realizar la eliminación en la base de datos
                Dim query As String = "DELETE FROM Almacen WHERE No_Pieza = @NoPieza"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NoPieza", noPieza)

                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show($"La fila con No_Pieza '{noPieza}' se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Refrescar el DataGridView después de la eliminación
                        BuscarYMostrarCantidad(noPieza)
                    Else
                        MessageBox.Show($"No se pudo eliminar la fila. Verifique la existencia y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al realizar la eliminación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarDataGridView(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        For Each col As DataGridViewColumn In DataGridView1.Columns

            col.ReadOnly = True ' Bloquear todas las demás columnas

        Next
    End Sub
    Private Sub BAJA_ALMACEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bloquear todas las columnas excepto "Cantidad"
        DataGridView1.AllowUserToAddRows = False ' Evita que se agreguen filas manualmente

        ' Aplicar ReadOnly después de que se carguen los datos
        AddHandler DataGridView1.DataBindingComplete, AddressOf ConfigurarDataGridView
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        ' Verificar si la tecla presionada es un número o la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Mostrar mensaje de error
            MessageBox.Show("Ingresa solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Cancelar la entrada de la tecla
            e.Handled = True
        End If
    End Sub
End Class