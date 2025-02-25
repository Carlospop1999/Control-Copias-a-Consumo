Imports Microsoft.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions

Public Class EDITAR_USUARIOS
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"
    Dim busquedaExitosa As Boolean = False
    Dim contraseñaOriginal As String = String.Empty
    Dim mostrarContraseñaTimer As New Timer()
    Private WithEvents TimerMostrarContraseñaTemporal As New Timer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valorBusqueda As String = TextBox7.Text.Trim()

        If String.IsNullOrEmpty(valorBusqueda) Then
            MessageBox.Show("Por favor, ingresa un valor para realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "SELECT * FROM Usuarios WHERE Nombre = @ValorBusqueda OR Apellido = @ValorBusqueda OR PuestoRol = @ValorBusqueda"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@ValorBusqueda", valorBusqueda)

                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.HasRows Then
                                MessageBox.Show("Búsqueda exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                reader.Read()
                                NombresNU.Text = reader("Nombre").ToString()
                                ApellidosNU.Text = reader("Apellido").ToString()
                                PuestoNU.Text = reader("PuestoRol").ToString()
                                ContraseñaNU.Text = reader("HashContraseña").ToString()
                                CorreoEleNU.Text = reader("CorreoElectronico").ToString() ' Agregar la lógica para mostrar el correo electrónico
                                CheckBox1.Checked = Convert.ToBoolean(reader("TienePermisoAlmacen"))
                                CheckBox2.Checked = Convert.ToBoolean(reader("TienePermisoEquipos"))
                                CheckBox3.Checked = Convert.ToBoolean(reader("TienePermisoClientes"))
                                CheckBox4.Checked = Convert.ToBoolean(reader("TienePermisoUsuarios"))
                                contraseñaOriginal = reader("HashContraseña").ToString()
                                mostrarContraseñaTimer.Interval = 5000
                                AddHandler mostrarContraseñaTimer.Tick, AddressOf OcultarContraseñaTemporalmente
                                mostrarContraseñaTimer.Start()
                                HabilitarEdicion()
                                busquedaExitosa = True
                            Else
                                MessageBox.Show("No hay valores en la tabla con el valor de búsqueda proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al realizar la búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub OcultarContraseñaTemporalmente(sender As Object, e As EventArgs)
        ' Al terminar el tiempo, ocultar la contraseña
        ContraseñaNU.PasswordChar = "•"c ' Ocultar la contraseña
        TimerMostrarContraseñaTemporal.Stop()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not busquedaExitosa Then
            MessageBox.Show("Solo puedes guardar después de hacer una búsqueda exitosa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If ValidarCampos() Then
                    ' Validar que el nuevo nombre no exista ya en la tabla, excluyendo el nombre de búsqueda actual
                    If Not NombreExistenteExcluyendo(NombresNU.Text.Trim(), TextBox7.Text.Trim()) Then
                        ' Validar que el nuevo correo electrónico no exista ya en la tabla, excluyendo el correo de búsqueda actual
                        If Not CorreoElectronicoExistenteExcluyendo(CorreoEleNU.Text.Trim(), TextBox7.Text.Trim(), CorreoEleNU.Text.Trim()) Then
                            ' Verificar si la contraseña ha sido modificada
                            If ContraseñaModificada() Then
                                ' Si la contraseña ha sido modificada, proceder con la actualización
                                ActualizarContraseña()
                            Else
                                ' Si la contraseña no ha sido modificada, mostrar un mensaje de error
                                MessageBox.Show("Es necesario actualizar la contraseña para guardar los cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            GuardarCambios()
                            LimpiarCampos()
                            NombresNU.ReadOnly = True
                            ApellidosNU.ReadOnly = True
                            PuestoNU.ReadOnly = True
                            ContraseñaNU.ReadOnly = True
                            CorreoEleNU.ReadOnly = True
                            busquedaExitosa = False
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function ContraseñaModificada() As Boolean
        ' Verificar si la contraseña ha sido modificada comparándola con la original
        Return ContraseñaNU.Text <> contraseñaOriginal
    End Function

    ' Método para verificar si el nombre ya existe en la tabla, excluyendo un nombre específico
    Private Function NombreExistenteExcluyendo(nombre As String, nombreExcluido As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Nombre <> @NombreExcluido"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@NombreExcluido", nombreExcluido)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Ya existe un usuario con el mismo nombre. Por favor, elija un nombre diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar si el nombre existe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Método para verificar si el correo electrónico ya existe en la tabla, excluyendo un correo electrónico específico
    Private Function CorreoElectronicoExistenteExcluyendo(nuevoCorreo As String, correoActual As String, correoExcluido As String) As Boolean
        Try
            ' Expresión regular para validar correos electrónicos según el estándar RFC 5322
            Dim expresionRegular As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

            ' Validar el nuevo correo electrónico utilizando la expresión regular
            Dim esCorreoValido As Boolean = Regex.IsMatch(nuevoCorreo, expresionRegular)

            ' Si el correo no tiene un formato válido, mostrar un mensaje de advertencia
            If Not esCorreoValido Then
                MessageBox.Show("El formato del correo electrónico no es válido. Por favor, ingrese un correo electrónico válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            End If

            ' Permitir la validación si realmente se ha cambiado el correo electrónico
            If Not nuevoCorreo.Equals(correoActual, StringComparison.OrdinalIgnoreCase) Then
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Utilizar el correo de la búsqueda actual en lugar del TextBox7.Text
                    Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE CorreoElectronico = @CorreoElectronico AND (CorreoElectronico <> @CorreoExcluido OR @CorreoExcluido IS NULL)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@CorreoElectronico", nuevoCorreo)
                        command.Parameters.AddWithValue("@CorreoExcluido", If(String.IsNullOrWhiteSpace(correoExcluido), DBNull.Value, DirectCast(correoExcluido, Object)))

                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If count > 0 Then
                            MessageBox.Show("Ya existe un usuario con el mismo correo electrónico. Por favor, elija un correo electrónico diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        Return count > 0
                    End Using
                End Using
            End If

            Return False
        Catch ex As Exception
            MessageBox.Show("Error al verificar si el correo electrónico existe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



    Private Sub HabilitarEdicion()
        NombresNU.ReadOnly = False
        ApellidosNU.ReadOnly = False
        PuestoNU.ReadOnly = False
        ContraseñaNU.ReadOnly = False
        CorreoEleNU.ReadOnly = False
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
    End Sub

    Private Sub LimpiarCampos()
        NombresNU.Clear()
        ApellidosNU.Clear()
        PuestoNU.Clear()
        ContraseñaNU.Clear()
        CorreoEleNU.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub GuardarCambios()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                If Not EsCorreoElectronicoValido(CorreoEleNU.Text) Then
                    MessageBox.Show("El formato del correo electrónico no es válido. Por favor, ingrese un correo electrónico válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim nuevaSal As String = Convert.ToString(Guid.NewGuid())
                Dim nuevaContraseñaHash As String
                Using sha256 As New System.Security.Cryptography.SHA256Managed
                    Dim bytes As Byte() = Encoding.Unicode.GetBytes(ContraseñaNU.Text & nuevaSal)
                    Dim hash As Byte() = sha256.ComputeHash(bytes)
                    nuevaContraseñaHash = BitConverter.ToString(hash).Replace("-", "").ToLower()
                End Using

                Dim query As String = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, PuestoRol = @PuestoRol, Sal = @Sal, HashContraseña = @HashContraseña, TienePermisoAlmacen = @TienePermisoAlmacen, TienePermisoEquipos = @TienePermisoEquipos, TienePermisoClientes = @TienePermisoClientes, TienePermisoUsuarios = @TienePermisoUsuarios, CorreoElectronico = @CorreoElectronico WHERE Nombre = @ValorBusqueda OR Apellido = @ValorBusqueda OR PuestoRol = @ValorBusqueda"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", NombresNU.Text)
                    command.Parameters.AddWithValue("@Apellido", ApellidosNU.Text)
                    command.Parameters.AddWithValue("@PuestoRol", PuestoNU.Text)
                    command.Parameters.AddWithValue("@Sal", nuevaSal)
                    command.Parameters.AddWithValue("@HashContraseña", nuevaContraseñaHash)
                    command.Parameters.AddWithValue("@TienePermisoAlmacen", CheckBox1.Checked)
                    command.Parameters.AddWithValue("@TienePermisoEquipos", CheckBox2.Checked)
                    command.Parameters.AddWithValue("@TienePermisoClientes", CheckBox3.Checked)
                    command.Parameters.AddWithValue("@TienePermisoUsuarios", CheckBox4.Checked)
                    command.Parameters.AddWithValue("@CorreoElectronico", CorreoEleNU.Text)
                    command.Parameters.AddWithValue("@ValorBusqueda", TextBox7.Text.Trim())

                    command.ExecuteNonQuery()

                    MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar cambios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        Return Not String.IsNullOrEmpty(NombresNU.Text) AndAlso
               Not String.IsNullOrEmpty(ApellidosNU.Text) AndAlso
               Not String.IsNullOrEmpty(PuestoNU.Text) AndAlso
               Not String.IsNullOrEmpty(ContraseñaNU.Text) AndAlso
               EsCorreoElectronicoValido(CorreoEleNU.Text)
    End Function

    Private Function NombreExistente(nombre As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", nombre)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar si el nombre existe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function EsCorreoElectronicoValido(correo As String) As Boolean
        Dim expresionRegular As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim coincide As Boolean = Regex.IsMatch(correo, expresionRegular)
        Return coincide
    End Function

    Private Sub ActualizarContraseña()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim nuevaSal As String = Convert.ToString(Guid.NewGuid())
                Dim nuevaContraseñaHash As String
                Using sha256 As New System.Security.Cryptography.SHA256Managed
                    Dim bytes As Byte() = Encoding.Unicode.GetBytes(ContraseñaNU.Text & nuevaSal)
                    Dim hash As Byte() = sha256.ComputeHash(bytes)
                    nuevaContraseñaHash = BitConverter.ToString(hash).Replace("-", "").ToLower()
                End Using

                Dim query As String = "UPDATE Usuarios SET Sal = @NuevaSal, HashContraseña = @NuevaContraseñaHash WHERE Nombre = @ValorBusqueda OR Apellido = @ValorBusqueda OR PuestoRol = @ValorBusqueda"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NuevaSal", nuevaSal)
                    command.Parameters.AddWithValue("@NuevaContraseñaHash", nuevaContraseñaHash)
                    command.Parameters.AddWithValue("@ValorBusqueda", TextBox7.Text.Trim())

                    command.ExecuteNonQuery()

                    MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la contraseña: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBoxes_TextChanged(sender As Object, e As EventArgs) Handles NombresNU.TextChanged, ApellidosNU.TextChanged, PuestoNU.TextChanged, ContraseñaNU.TextChanged
        If busquedaExitosa Then
            NombresNU.ReadOnly = False
            ApellidosNU.ReadOnly = False
            PuestoNU.ReadOnly = False
            ContraseñaNU.ReadOnly = False
            CorreoEleNU.ReadOnly = False ' Habilitar la edición del correo electrónico
        Else
            NombresNU.ReadOnly = True
            ApellidosNU.ReadOnly = True
            PuestoNU.ReadOnly = True
            ContraseñaNU.ReadOnly = True
            CorreoEleNU.ReadOnly = True ' Deshabilitar la edición del correo electrónico
        End If

    End Sub

    'arrastrar formulario 
    Private mousePresionado As Boolean = False
    Private posicionInicial As Point

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        mousePresionado = True
        posicionInicial = New Point(e.X, e.Y)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove
        If mousePresionado Then
            Dim nuevaPosicion As Point = Me.PointToScreen(New Point(e.X, e.Y))
            nuevaPosicion.Offset(-posicionInicial.X, -posicionInicial.Y)
            Me.Location = nuevaPosicion
        End If
    End Sub
    'termina arrastrar formularios
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Panel1.MouseUp
        mousePresionado = False
    End Sub
    Private Sub EDITAR_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
    End Sub

    Private Sub CorreoEleNU_TextChanged(sender As Object, e As EventArgs) Handles CorreoEleNU.TextChanged
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Mostrar la contraseña temporalmente
        ContraseñaNU.PasswordChar = ControlChars.NullChar ' Mostrar la contraseña

        ' Iniciar un temporizador para ocultar la contraseña después de 3 segundos
        TimerMostrarContraseñaTemporal.Interval = 1100
        TimerMostrarContraseñaTemporal.Start()
    End Sub

    Private Sub TimerMostrarContraseñaTemporal_Tick(sender As Object, e As EventArgs) Handles TimerMostrarContraseñaTemporal.Tick
        ' Al terminar el tiempo, ocultar la contraseña
        ContraseñaNU.PasswordChar = "•"c ' Ocultar la contraseña
        TimerMostrarContraseñaTemporal.Stop()
    End Sub
End Class