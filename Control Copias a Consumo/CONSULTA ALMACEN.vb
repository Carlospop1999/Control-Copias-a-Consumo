Imports System.Runtime.InteropServices
Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class CONSULTA_ALMACEN

    ' cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

    Private Sub ConfigurarDataGridView(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        For Each col As DataGridViewColumn In DataGridView1.Columns

            col.ReadOnly = True ' Bloquear todas las demás columnas

        Next
    End Sub
    Private Sub CONSULTA_ALMACEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.9
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtener el año y mes actuales
        Dim añoActual As Integer = DateTime.Now.Year
        Dim mesActual As Integer = DateTime.Now.Month

        ' Validar que se hayan seleccionado ambos ComboBox
        If String.IsNullOrEmpty(ComboBox1.Text) Or String.IsNullOrEmpty(ComboBox2.Text) Then
            MessageBox.Show("Seleccione una fecha correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Obtener el número de mes y año seleccionados
            Dim mesSeleccionado As Integer = ComboBox1.SelectedIndex + 1 ' Los índices comienzan desde 0, por eso sumamos 1
            Dim añoSeleccionado As Integer = Convert.ToInt32(ComboBox2.Text)

            ' Validar que el año y mes seleccionados sean válidos (año actual o anterior, mes actual o anterior)
            If añoSeleccionado > añoActual OrElse (añoSeleccionado = añoActual And mesSeleccionado > mesActual) Then
                MessageBox.Show("Seleccione un año y mes que estén en curso o anterior", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' Construir la consulta SQL
                Dim consulta As String = "SELECT * FROM Almacen WHERE 
                                        (YEAR(Movnew) = @AñoSeleccionado AND MONTH(Movnew) = @MesSeleccionado) 
                                        OR (YEAR(Movedit) = @AñoSeleccionado AND MONTH(Movedit) = @MesSeleccionado) 
                                        OR (YEAR(Movdel) = @AñoSeleccionado AND MONTH(Movdel) = @MesSeleccionado)"

                ' Establecer la conexión y crear el comando con la consulta SQL
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(consulta, connection)
                        ' Establecer los parámetros para el año y mes seleccionados
                        command.Parameters.AddWithValue("@AñoSeleccionado", añoSeleccionado)
                        command.Parameters.AddWithValue("@MesSeleccionado", mesSeleccionado)

                        Try
                            ' Abrir la conexión y ejecutar la consulta
                            connection.Open()

                            ' Crear un adaptador y un conjunto de datos para llenar el DataGridView
                            Dim adapter As New SqlDataAdapter(command)
                            Dim dataset As New DataSet()
                            adapter.Fill(dataset, "Almacen")

                            ' Mostrar los resultados en el DataGridView
                            DataGridView1.DataSource = dataset.Tables("Almacen")
                        Catch ex As Exception
                            MessageBox.Show("Error al consultar la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                End Using
            End If
        End If
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Verificar si se hizo clic en la columna de Img_Producto
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
                imageForm.StartPosition = FormStartPosition.CenterScreen
                imageForm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


End Class
