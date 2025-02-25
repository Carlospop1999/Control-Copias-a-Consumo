Imports System.Runtime.InteropServices
Imports Microsoft.Data.SqlClient
Imports System.Net.Mail ' Necesario para la validación de correo electrónico y el envío de correos

Public Class RECcontraseña

    ' Declara una variable para la conexión.
    Private conexion As SqlConnection

    Private Sub RECcontraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el evento MouseDown para permitir arrastrar el formulario desde cualquier parte del formulario.
        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        ' Configurar el evento MouseDown para permitir arrastrar el formulario desde el panel.
        AddHandler Panel1.MouseDown, AddressOf Form_MouseDown

        ' Configura la cadena de conexión.
        'Dim cadenaConexion As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
        Dim cadenaConexion As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

        ' Crea la conexión.
        conexion = New SqlConnection(cadenaConexion)

        Try
            ' Abre la conexión.
            conexion.Open()

            ' Carga los nombres de los usuarios en el ComboBox.
            CargarNombresUsuarios()

        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarNombresUsuarios()
        ' Define la consulta SQL para obtener los nombres de usuarios.
        Dim consulta As String = "SELECT Nombre FROM Usuarios"

        ' Crea un comando para ejecutar la consulta.
        Dim comando As New SqlCommand(consulta, conexion)

        ' Crea un lector de datos para leer los resultados de la consulta.
        Dim lector As SqlDataReader = comando.ExecuteReader()

        ' Limpia los elementos existentes en el ComboBox.
        ComboBox1.Items.Clear()

        ' Agrega los nombres de usuarios al ComboBox.
        While lector.Read()
            ComboBox1.Items.Add(lector("Nombre").ToString())
        End While

        ' Cierra el lector de datos.
        lector.Close()
    End Sub

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, &H112&, &HF012&, 0)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validar que se haya seleccionado un nombre en ComboBox1 y que TextBox1 contenga un correo electrónico válido.
        If ComboBox1.SelectedItem IsNot Nothing AndAlso EsCorreoElectronicoValido(TextBox1.Text) Then
            ' Obtener el correo electrónico asociado al nombre seleccionado en ComboBox1.
            Dim correoElectronicoEnBaseDeDatos As String = ObtenerCorreoElectronicoPorNombre(ComboBox1.SelectedItem.ToString())

            ' Verificar que el correo electrónico ingresado coincida con el de la base de datos.
            If TextBox1.Text.ToLower() = correoElectronicoEnBaseDeDatos.ToLower() Then
                ' Aquí puedes enviar el mensaje de recuperación de contraseña al correo electrónico.
                EnviarMensajeRecuperacion(correoElectronicoEnBaseDeDatos)

                ' Mostrar mensaje de éxito.
                MessageBox.Show("Código de recuperación enviado al correo electrónico.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Mostrar formulario VerificacionCodigoForm
            Else
                MessageBox.Show("El correo electrónico ingresado no coincide con el registrado para este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Seleccione un nombre de usuario y/o ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function EsCorreoElectronicoValido(correo As String) As Boolean
        ' Puedes implementar lógica adicional para validar el formato del correo electrónico.
        Try
            Dim mailAddress As New MailAddress(correo)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function ObtenerCorreoElectronicoPorNombre(nombreUsuario As String) As String
        ' Define la consulta SQL para obtener el correo electrónico por nombre de usuario.
        Dim consulta As String = "SELECT CorreoElectronico FROM Usuarios WHERE Nombre = @NombreUsuario"

        ' Crea un comando para ejecutar la consulta.
        Dim comando As New SqlCommand(consulta, conexion)
        comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)

        ' Ejecuta la consulta y devuelve el correo electrónico.
        Return Convert.ToString(comando.ExecuteScalar())
    End Function

    Private Sub EnviarMensajeRecuperacion(correoDestino As String)
        ' Aquí puedes implementar el código para enviar el mensaje de recuperación de contraseña.
        ' Puedes usar la clase SmtpClient de System.Net.Mail para enviar correos electrónicos.
        ' Consulta la documentación de .NET para obtener más detalles sobre el envío de correos electrónicos.
        Try
            ' Generar un código aleatorio
            Dim codigoRecuperacion As String = GenerarCodigoRecuperacion()

            ' Almacenar el código en la base de datos
            AlmacenarCodigoRecuperacion(correoDestino, codigoRecuperacion)

            Dim mensaje As New MailMessage()
            mensaje.From = New MailAddress("carlospop1999@gmail.com", "Copias a Consumo") ' Cambia esto al correo desde el que deseas enviar el mensaje
            mensaje.To.Add(correoDestino)
            mensaje.Subject = "Recuperación de Contraseña"
            mensaje.Body = "Hola, " & ComboBox1.SelectedItem & " este es tu código de recuperación: " & codigoRecuperacion

            Dim clienteSmtp As New SmtpClient("smtp.gmail.com")
            clienteSmtp.Port = 587
            clienteSmtp.Credentials = New System.Net.NetworkCredential("carlospop1999@gmail.com", "nzbn ginm mxeg dlxm") ' Cambia esto al correo y contraseña reales
            clienteSmtp.EnableSsl = True

            clienteSmtp.Send(mensaje)


            ' Limpiar el ComboBox y el TextBox.
            ComboBox1.SelectedIndex = -1
            TextBox1.Clear()

        Catch ex As Exception
            MessageBox.Show("Error al enviar el mensaje de recuperación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GenerarCodigoRecuperacion() As String
        ' Generar un código aleatorio de 6 dígitos
        Dim codigo As String = New Random().Next(100000, 999999).ToString()
        Return codigo
    End Function


    Private Sub AlmacenarCodigoRecuperacion(correoDestino As String, codigoRecuperacion As String)
        ' Almacena el código de recuperación en la base de datos solo para el usuario seleccionado en ComboBox1
        Dim consulta As String = "UPDATE Usuarios SET CodigoRecuperacion = @CodigoRecuperacion WHERE Nombre = @Nombre"

        Using comando As New SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@CodigoRecuperacion", codigoRecuperacion)
            comando.Parameters.AddWithValue("@Nombre", ComboBox1.SelectedItem.ToString())

            comando.ExecuteNonQuery()
        End Using
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

    Private Sub RECcontraseña_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Asegúrate de cerrar la conexión cuando el formulario se cierra.
        If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class