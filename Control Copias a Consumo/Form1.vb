Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports Microsoft.Data.SqlClient
Imports System.Text

Public Class Form1
    ' Tu cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"

    ' Variables globales para almacenar permisos
    Public Shared Property PermisoAlmacen As Boolean = False
    Public Shared Property PermisoEquipos As Boolean = False
    Public Shared Property PermisoClientes As Boolean = False
    Public Shared Property PermisoUsuarios As Boolean = False

    ' Variable global para indicar si se está utilizando la validación con código
    Private isCodigoValidacion As Boolean = False

    Private WithEvents TimerMostrarContraseñaTemporal As New Timer

    ' Variable global para almacenar el nombre de usuario
    Public Shared Property NombreUsuarioLogueado As String = ""

    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, &H112&, &HF012&, 0)
        End If
    End Sub

    Public Sub LlenarComboBox()
        ComboBox1.Items.Clear()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT Nombre FROM Usuarios"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ComboBox1.Items.Add(reader("Nombre").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos en ComboBox1: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedValue As String = ComboBox1.SelectedItem?.ToString()

        If String.IsNullOrEmpty(selectedValue) Then
            MessageBox.Show("Seleccione un Usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Obtener permisos del usuario
            ObtenerPermisosUsuario(selectedValue)

            ' Obtener la contraseña o código ingresado
            Dim credencial As String = TextBox1.Text

            ' Validar las credenciales del usuario, indicando que no es un código de recuperación
            If ValidarCredenciales(selectedValue, credencial, False) Then
                MessageBox.Show("Bienvenido/a: " & selectedValue, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Almacenar el nombre de usuario en la variable global
                NombreUsuarioLogueado = selectedValue

                ' Aquí puedes abrir la siguiente ventana o realizar otras acciones
                Index.Show()
                Me.Hide()

                ' Llenar el ComboBox1 después de una acción exitosa (por ejemplo, después de iniciar sesión)
                LlenarComboBox()
            Else
                ' Si las credenciales no son válidas, intentar con código de recuperación
                If ValidarCredenciales(selectedValue, credencial, True) Then
                    MessageBox.Show("Bienvenido/a: " & selectedValue & " usando código de recuperación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    NombreUsuarioLogueado = selectedValue

                    ' Aquí puedes abrir la siguiente ventana o realizar otras acciones
                    Index.Show()
                    Me.Hide()

                    ' Llenar el ComboBox1 después de una acción exitosa (por ejemplo, después de iniciar sesión)
                    LlenarComboBox()
                Else
                    ' Mostrar mensaje de error si las credenciales y código de recuperación no son válidos
                    MessageBox.Show("Nombre de usuario, contraseña o código de recuperación incorrectos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
    Private Sub ObtenerPermisosUsuario(nombreUsuario As String)
        ' Lógica para obtener permisos desde la base de datos
        ' ...

        ' Ejemplo: Consulta SQL para obtener permisos
        Dim query As String = "SELECT TienePermisoAlmacen, TienePermisoEquipos, TienePermisoClientes, TienePermisoUsuarios FROM Usuarios WHERE Nombre = @Nombre"
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", nombreUsuario)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            PermisoAlmacen = Convert.ToBoolean(reader("TienePermisoAlmacen"))
                            PermisoEquipos = Convert.ToBoolean(reader("TienePermisoEquipos"))
                            PermisoClientes = Convert.ToBoolean(reader("TienePermisoClientes"))
                            PermisoUsuarios = Convert.ToBoolean(reader("TienePermisoUsuarios"))
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener permisos del usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function GenerarNuevaSal() As String
        Return Convert.ToString(Guid.NewGuid())
    End Function

    Private Function ObtenerHashContraseña(contraseña As String, sal As String) As String
        ' Agrega sal para mayor seguridad
        Dim combinedPassword As String = String.Concat(contraseña, sal)

        ' Usa SHA256.Create() en lugar de SHA256Managed
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.Unicode.GetBytes(combinedPassword))
            Return BitConverter.ToString(hashedBytes).Replace("-", "")
        End Using
    End Function

    Private Function ValidarCredenciales(nombreUsuario As String, credencial As String, esCodigoRecuperacion As Boolean) As Boolean
        ' Crear una conexión a la base de datos
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Verificar si es un código de recuperación o una contraseña
                Dim querySal As String
                Dim queryHash As String

                If esCodigoRecuperacion Then
                    ' Si es código de recuperación, buscar el código en lugar de la contraseña hash
                    querySal = "SELECT CodigoRecuperacion FROM Usuarios WHERE Nombre = @Nombre"
                    queryHash = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND CodigoRecuperacion = @Credencial"
                Else
                    ' Si es una contraseña, buscar la sal y la contraseña hash
                    querySal = "SELECT Sal FROM Usuarios WHERE Nombre = @Nombre"
                    queryHash = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND HashContraseña = @Credencial"
                End If

                Using commandSal As New SqlCommand(querySal, connection)
                    commandSal.Parameters.AddWithValue("@Nombre", nombreUsuario)

                    Dim sal As String = Convert.ToString(commandSal.ExecuteScalar())

                    ' Calcular el hash de la contraseña o el código con la sal almacenada en la base de datos
                    Dim hashCredencial As String

                    If esCodigoRecuperacion Then
                        hashCredencial = credencial ' No es necesario combinar con la sal para códigos de recuperación
                    Else
                        hashCredencial = ObtenerHashContraseña(credencial, sal)
                    End If

                    ' Consulta SQL para verificar las credenciales
                    Using command As New SqlCommand(queryHash, connection)
                        ' Agregar parámetros a la consulta
                        command.Parameters.AddWithValue("@Nombre", nombreUsuario)
                        command.Parameters.AddWithValue("@Credencial", hashCredencial)

                        ' Ejecutar la consulta y obtener el resultado
                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                        ' Si count > 0, las credenciales son válidas
                        Return count > 0
                    End Using
                End Using
            Catch ex As Exception
                ' Manejar cualquier error durante la conexión o la consulta
                MessageBox.Show($"Error durante el inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Código para el PictureBox1
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que quieres cerrar Sistema de Control de Copias a Consumo?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9
        ' Llenar el ComboBox1 al cargar el formulario
        LlenarComboBox()
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Button1.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        Button1.Region = New Region(buttonPath)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RECcontraseña.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Código para Panel1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Mostrar la contraseña temporalmente
        TextBox1.PasswordChar = ControlChars.NullChar ' Mostrar la contraseña

        ' Iniciar un temporizador para ocultar la contraseña después de 3 segundos
        TimerMostrarContraseñaTemporal.Interval = 1100
        TimerMostrarContraseñaTemporal.Start()
    End Sub

    Private Sub TimerMostrarContraseñaTemporal_Tick(sender As Object, e As EventArgs) Handles TimerMostrarContraseñaTemporal.Tick
        ' Al terminar el tiempo, ocultar la contraseña
        TextBox1.PasswordChar = "•"c ' Ocultar la contraseña
        TimerMostrarContraseñaTemporal.Stop()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Ayudas.Show()
    End Sub
End Class
