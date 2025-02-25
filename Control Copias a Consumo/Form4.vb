Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form4
    ' Tu cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

    ' Propiedad para referenciar el ComboBox1 desde otros formularios
    Public Property ComboUsuarios As ComboBox

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.9
        ' Configurar el evento MouseDown para permitir arrastrar el formulario desde cualquier parte del formulario.
        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        ' Configurar el evento MouseDown para permitir arrastrar el formulario desde el panel.
        AddHandler Panel1.MouseDown, AddressOf Form_MouseDown
    End Sub

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnRegistrarNU.Click
        ' Verificar si los campos están vacíos antes de realizar la inserción
        If String.IsNullOrWhiteSpace(NombresNU.Text) OrElse String.IsNullOrWhiteSpace(ApellidosNU.Text) OrElse String.IsNullOrWhiteSpace(PuestoNU.Text) OrElse String.IsNullOrWhiteSpace(ContraseñaNU.Text) OrElse String.IsNullOrWhiteSpace(CorreoEleNU.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Verificar si el correo electrónico tiene un formato válido
        If Not EsCorreoElectronicoValido(CorreoEleNU.Text) Then
            MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Formato de Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Verificar si el correo electrónico ya está registrado
        If CorreoElectronicoExiste(CorreoEleNU.Text) Then
            MessageBox.Show("El correo electrónico ya está registrado con otro usuario. Por favor, utilice otro correo electrónico.", "Correo Electrónico Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Verificar si el nombre de usuario ya existe
        If NombreUsuarioExiste(NombresNU.Text) Then
            MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro nombre.", "Nombre de Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Resto del código para la inserción en la base de datos
        ' Generar nueva sal
        Dim nuevaSal As String = GenerarNuevaSal()

        ' Obtener la contraseña
        Dim contraseña As String = ContraseñaNU.Text

        ' Calcular el hash de la contraseña con la nueva sal
        Dim hashContraseña As String = ObtenerHashContraseña(contraseña, nuevaSal)

        ' Realizar la inserción en la base de datos
        Dim query As String = "INSERT INTO Usuarios (Nombre, Apellido, PuestoRol, CorreoElectronico, Sal, HashContraseña, TienePermisoAlmacen, TienePermisoEquipos, TienePermisoClientes, TienePermisoUsuarios) " &
                              "VALUES (@Nombre, @Apellido, @PuestoRol, @CorreoElectronico, @Sal, @HashContraseña, @TienePermisoAlmacen, @TienePermisoEquipos, @TienePermisoClientes, @TienePermisoUsuarios)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Establecer los parámetros para la inserción
                command.Parameters.AddWithValue("@Nombre", NombresNU.Text)
                command.Parameters.AddWithValue("@Apellido", ApellidosNU.Text)
                command.Parameters.AddWithValue("@PuestoRol", PuestoNU.Text)
                command.Parameters.AddWithValue("@CorreoElectronico", CorreoEleNU.Text)
                command.Parameters.AddWithValue("@Sal", nuevaSal)
                command.Parameters.AddWithValue("@HashContraseña", hashContraseña)
                ' Establecer los parámetros para los permisos
                command.Parameters.AddWithValue("@TienePermisoAlmacen", CheckBox1.Checked)
                command.Parameters.AddWithValue("@TienePermisoEquipos", CheckBox2.Checked)
                command.Parameters.AddWithValue("@TienePermisoClientes", CheckBox3.Checked)
                command.Parameters.AddWithValue("@TienePermisoUsuarios", CheckBox4.Checked)

                Try
                    connection.Open()
                    ' Ejecutar la consulta de inserción
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Limpiar los TextBox después de la inserción
                        LimpiarTextBoxes()

                        ' Actualizar ComboBox1 en Form1
                        If ComboUsuarios IsNot Nothing Then
                            ComboUsuarios.Items.Clear()
                            ComboUsuarios.Items.AddRange(ObtenerNombresUsuarios())
                        End If
                    Else
                        MessageBox.Show("No se pudo registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al registrar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Function GenerarNuevaSal() As String
        Return Convert.ToString(Guid.NewGuid())
    End Function

    Private Function ObtenerHashContraseña(contraseña As String, sal As String) As String
        ' Agregar sal para mayor seguridad
        Dim combinedPassword As String = String.Concat(contraseña, sal)

        ' Hash de la contraseña con sal
        Dim hashedPassword As String = BitConverter.ToString(
            New SHA256Managed().ComputeHash(Encoding.Unicode.GetBytes(combinedPassword))
        ).Replace("-", "")

        Return hashedPassword
    End Function

    Private Function EsCorreoElectronicoValido(correo As String) As Boolean
        ' Expresión regular para validar correos electrónicos según el estándar RFC 5322
        Dim expresionRegular As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Validar el correo electrónico utilizando la expresión regular
        Dim coincide As Boolean = Regex.IsMatch(correo, expresionRegular)

        Return coincide
    End Function

    Private Function CorreoElectronicoExiste(correo As String) As Boolean
        ' Verificar si el correo electrónico ya existe en la base de datos
        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE CorreoElectronico = @CorreoElectronico"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CorreoElectronico", correo)

                Try
                    connection.Open()
                    Dim count As Integer = CInt(command.ExecuteScalar())

                    ' Si count es mayor que cero, significa que el correo electrónico ya existe
                    Return count > 0
                Catch ex As Exception
                    MessageBox.Show("Error al verificar si el correo electrónico existe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Function NombreUsuarioExiste(nombreUsuario As String) As Boolean
        ' Verificar si el nombre de usuario ya existe en la base de datos
        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", nombreUsuario)

                Try
                    connection.Open()
                    Dim count As Integer = CInt(command.ExecuteScalar())

                    ' Si count es mayor que cero, significa que el nombre de usuario ya existe
                    Return count > 0
                Catch ex As Exception
                    MessageBox.Show("Error al verificar si el nombre de usuario existe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Function ObtenerNombresUsuarios() As String()
        Dim nombres As New List(Of String)()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT Nombre FROM Usuarios"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            nombres.Add(reader("Nombre").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener los nombres de usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return nombres.ToArray()
    End Function

    Private Sub LimpiarTextBoxes()
        NombresNU.Text = ""
        ApellidosNU.Text = ""
        PuestoNU.Text = ""
        ContraseñaNU.Text = ""
        CorreoEleNU.Text = ""
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub NombresNU_TextChanged(sender As Object, e As EventArgs) Handles NombresNU.TextChanged

    End Sub

    Private Sub ApellidosNU_TextChanged(sender As Object, e As EventArgs) Handles ApellidosNU.TextChanged

    End Sub

    Private Sub PuestoNU_TextChanged(sender As Object, e As EventArgs) Handles PuestoNU.TextChanged

    End Sub

    Private Sub ContraseñaNU_TextChanged(sender As Object, e As EventArgs) Handles ContraseñaNU.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EDITAR_USUARIOS.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BAJA_USUARIOS.Show()
    End Sub

    Private Sub CorreoEleNU_TextChanged(sender As Object, e As EventArgs) Handles CorreoEleNU.TextChanged

    End Sub
End Class
