Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Alta_Almacen
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

    Private Sub btnImagenAA_Click(sender As Object, e As EventArgs) Handles btnImagenAA.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog1.Title = "Seleccionar imagen"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nombre As String = TextBox1.Text.Trim()
        Dim marca As String = TextBox2.Text.Trim()
        Dim No_Pieza As String = TextBox3.Text.Trim()
        Dim modelo As String = TextBox5.Text.Trim()
        Dim proveedor As String = TextBox6.Text.Trim()
        Dim cantidad As Integer

        If Not Integer.TryParse(TextBox4.Text, cantidad) Then
            MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(marca) OrElse
           String.IsNullOrWhiteSpace(No_Pieza) OrElse String.IsNullOrWhiteSpace(modelo) OrElse
           String.IsNullOrWhiteSpace(proveedor) Then
            MessageBox.Show("Todos los campos deben completarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim imagenBytes As Byte() = Nothing
        If PictureBox1.Image IsNot Nothing Then
            Using stream As New MemoryStream()
                PictureBox1.Image.Save(stream, PictureBox1.Image.RawFormat)
                imagenBytes = stream.ToArray()
            End Using
        End If

        InsertarDatosAlmacen(nombre, marca, No_Pieza, cantidad, modelo, proveedor, imagenBytes)
    End Sub

    Private Sub InsertarDatosAlmacen(nombre As String, marca As String, No_Pieza As String, cantidad As Integer, modelo As String, proveedor As String, Img_Producto As Byte())
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim queryVerificar As String = "SELECT COUNT(*) FROM Almacen WHERE No_Pieza = @No_Pieza"
                Using commandVerificar As New SqlCommand(queryVerificar, connection)
                    commandVerificar.Parameters.AddWithValue("@No_Pieza", No_Pieza)
                    If CInt(commandVerificar.ExecuteScalar()) > 0 Then
                        MessageBox.Show($"Ya existe un registro con No_Pieza '{No_Pieza}'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                Using transaction As SqlTransaction = connection.BeginTransaction()
                    Try
                        Dim queryInsert As String = "INSERT INTO Almacen (Nombre, Marca, No_Pieza, Cantidad, Modelo, Proveedor, Img_Producto) " &
                                                   "OUTPUT INSERTED.ID_NSerieAlm VALUES (@Nombre, @Marca, @No_Pieza, @Cantidad, @Modelo, @Proveedor, @Img_Producto)"
                        Using commandInsert As New SqlCommand(queryInsert, connection, transaction)
                            commandInsert.Parameters.AddWithValue("@Nombre", nombre)
                            commandInsert.Parameters.AddWithValue("@Marca", marca)
                            commandInsert.Parameters.AddWithValue("@No_Pieza", No_Pieza)
                            commandInsert.Parameters.AddWithValue("@Cantidad", cantidad)
                            commandInsert.Parameters.AddWithValue("@Modelo", modelo)
                            commandInsert.Parameters.AddWithValue("@Proveedor", proveedor)
                            commandInsert.Parameters.Add("@Img_Producto", SqlDbType.VarBinary).Value = If(Img_Producto Is Nothing, DBNull.Value, Img_Producto)

                            Dim insertedID As Integer = CInt(commandInsert.ExecuteScalar())

                            Dim queryUpdate As String = "UPDATE Almacen SET Movnew = GETDATE() WHERE ID_NSerieAlm = @ID_NSerieAlm"
                            Using commandUpdate As New SqlCommand(queryUpdate, connection, transaction)
                                commandUpdate.Parameters.AddWithValue("@ID_NSerieAlm", insertedID)
                                commandUpdate.ExecuteNonQuery()
                            End Using
                        End Using

                        transaction.Commit()
                        MessageBox.Show("La pieza se añadió correctamente al inventario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show($"Error al insertar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show($"Error SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LimpiarTextBoxes()
    End Sub

    Private Sub LimpiarTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        PictureBox1.Image = Nothing
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub alta_almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class
