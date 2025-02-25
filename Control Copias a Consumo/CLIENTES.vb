Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient

Public Class CLIENTES
    ' Tu cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"
    ' Variable para verificar si se ha realizado una búsqueda exitosa
    Private busquedaExitosa As Boolean = False

    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub CLIENTES_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bloquear los TextBox 2, 3, 4, 5, 6 y 7 al iniciar el formulario
        SetTextBoxesReadOnly(True)
        ' Deshabilitar el botón Button1 al cargar el formulario
        Button1.Enabled = False
    End Sub

    Private Sub SetTextBoxesReadOnly(ByVal [readOnly] As Boolean)
        NombreConCL.ReadOnly = [readOnly]
        DireccionConCL.ReadOnly = [readOnly]
        Tel1ConCL.ReadOnly = [readOnly]
        CorreoConCL.ReadOnly = [readOnly]
        ContactoConCL.ReadOnly = [readOnly]
        Tel2ConCL.ReadOnly = [readOnly]
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        ' Verificar si TextBox1 está vacío y mostrar un mensaje en consecuencia
        If String.IsNullOrWhiteSpace(BusquedaConCL.Text) Then
            MessageBox.Show("Escribe un nombre de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Realizar la búsqueda en la base de datos
            Dim query As String = "SELECT id_Nombre, Direccion, Telefono, Telefono_sec, Correo, Nombre_Contacto FROM Clientes WHERE id_Nombre = @NombreBusqueda"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    ' Establecer el parámetro para la búsqueda
                    command.Parameters.AddWithValue("@NombreBusqueda", BusquedaConCL.Text)

                    Try
                        connection.Open()
                        Using reader As SqlDataReader = command.ExecuteReader()
                            ' Verificar si se encontraron resultados
                            If reader.Read() Then
                                ' Mostrar los valores en los TextBox respectivos
                                NombreConCL.Text = reader("id_Nombre").ToString()
                                DireccionConCL.Text = reader("Direccion").ToString()
                                Tel1ConCL.Text = reader("Telefono").ToString()
                                Tel2ConCL.Text = reader("Telefono_sec").ToString()
                                CorreoConCL.Text = reader("Correo").ToString()
                                ContactoConCL.Text = reader("Nombre_Contacto").ToString()

                                ' Bloquear los TextBox después de la búsqueda
                                SetTextBoxesReadOnly(True)
                                ' Establecer que la búsqueda fue exitosa
                                busquedaExitosa = True
                                ' Habilitar el botón Button1 después de una búsqueda exitosa
                                Button1.Enabled = True
                            Else
                                MessageBox.Show("No se encontró ningún registro para el cliente especificado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ' Bloquear los TextBox si no se encuentra ningún registro
                                SetTextBoxesReadOnly(True)
                                ' Establecer que la búsqueda no fue exitosa
                                busquedaExitosa = False
                                ' Deshabilitar el botón Button1 si no hay resultados de búsqueda
                                Button1.Enabled = False
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error al buscar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verificar si se ha realizado una búsqueda exitosa antes de intentar editar
        If Not busquedaExitosa Then
            MessageBox.Show("Realice una búsqueda exitosa para poder editar un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Mostrar un mensaje emergente para confirmar si se desea editar el cliente de la búsqueda actual
        Dim result As DialogResult = MessageBox.Show("¿Desea editar el cliente de la búsqueda actual?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Habilitar la edición de los TextBox 2, 3, 4, 5, 6 y 7
            SetTextBoxesReadOnly(False)

            ' Específicamente, asegurarse de que NombreConCL se pueda editar
            NombreConCL.ReadOnly = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Verificar si el correo electrónico tiene un formato válido
        If Not CorreoValido(CorreoConCL.Text) Then
            MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Formato de Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validar que Tel1ConCL tenga datos
        If String.IsNullOrWhiteSpace(Tel1ConCL.Text) Then
            MessageBox.Show("Asegúrese de llenar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Detener el proceso si la validación falla
        End If

        ' Mostrar un mensaje emergente para confirmar si se desean guardar los cambios del cliente
        Dim result As DialogResult = MessageBox.Show("¿Desea guardar los cambios del cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Actualizar los datos del cliente en la base de datos
            Dim query As String = "UPDATE Clientes SET Direccion = @Direccion, Telefono = @Telefono, Telefono_sec = @TelefonoSec, Correo = @Correo, Nombre_Contacto = @NombreContacto WHERE id_Nombre = @Nombre"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    ' Establecer parámetros para la actualización en la tabla
                    command.Parameters.AddWithValue("@Direccion", DireccionConCL.Text)
                    command.Parameters.AddWithValue("@Telefono", Tel1ConCL.Text)
                    command.Parameters.AddWithValue("@TelefonoSec", Tel2ConCL.Text)
                    command.Parameters.AddWithValue("@Correo", CorreoConCL.Text)
                    command.Parameters.AddWithValue("@NombreContacto", ContactoConCL.Text)
                    command.Parameters.AddWithValue("@Nombre", NombreConCL.Text)

                    Try
                        connection.Open()
                        ' Ejecutar la consulta de actualización
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Datos actualizados correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Limpiar los TextBox después de la actualización
                            LimpiarTextBoxes()
                        Else
                            MessageBox.Show("No se pudo actualizar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al actualizar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

            ' Bloquear los TextBox después de la actualización
            SetTextBoxesReadOnly(True)
        End If
    End Sub

    Private Sub LimpiarTextBoxes()
        BusquedaConCL.Text = ""
        NombreConCL.Text = ""
        DireccionConCL.Text = ""
        Tel1ConCL.Text = ""
        Tel2ConCL.Text = ""
        CorreoConCL.Text = ""
        ContactoConCL.Text = ""

        ' Deshabilitar el botón Button1 después de limpiar los TextBox
        Button1.Enabled = False
    End Sub

    ' Validación de correo electrónico
    Private Function CorreoValido(correo As String) As Boolean
        ' Expresión regular para validar correos electrónicos según el estándar RFC 5322
        Dim expresionRegular As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Validar el correo electrónico utilizando la expresión regular
        Dim coincide As Boolean = Regex.IsMatch(correo, expresionRegular)

        Return coincide
    End Function

    ' Validación de números de teléfono'

    Private Sub Tel1ConCL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tel1ConCL.KeyPress
        ' Verificar si la tecla presionada es un número o la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Mostrar mensaje de error
            MessageBox.Show("Ingresa solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Cancelar la entrada de la tecla
            e.Handled = True
        End If
    End Sub

    Private Sub Tel2ConCL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tel2ConCL.KeyPress
        ' Verificar si la tecla presionada es un número o la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Mostrar mensaje de error
            MessageBox.Show("Ingresa solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Cancelar la entrada de la tecla
            e.Handled = True
        End If
    End Sub

    Private Sub BusquedaConCL_TextChanged(sender As Object, e As EventArgs) Handles BusquedaConCL.TextChanged

    End Sub

    Private Sub NombreConCL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreConCL.KeyPress
        ' Mostrar mensaje de advertencia
        MessageBox.Show("No se puede editar el Nombre del Cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ' Cancelar la entrada de la tecla presionada
        e.Handled = True
    End Sub


    Private Sub DireccionConCL_TextChanged(sender As Object, e As EventArgs) Handles DireccionConCL.TextChanged

    End Sub

    Private Sub Tel1ConCL_TextChanged(sender As Object, e As EventArgs) Handles Tel1ConCL.TextChanged

    End Sub

    Private Sub CorreoConCL_TextChanged(sender As Object, e As EventArgs) Handles CorreoConCL.TextChanged

    End Sub

    Private Sub ContactoConCL_TextChanged(sender As Object, e As EventArgs) Handles ContactoConCL.TextChanged

    End Sub

    Private Sub Tel2ConCL_TextChanged(sender As Object, e As EventArgs) Handles Tel2ConCL.TextChanged

    End Sub
End Class
