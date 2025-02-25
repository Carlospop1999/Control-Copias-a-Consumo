Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient
Public Class Form3
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    ' Tu cadena de conexión
    'Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumo;Integrated Security=True"
    Private connectionString As String = "Data Source=(local)\SQLCopias;Initial Catalog=CopiasaConsumoComplet;Integrated Security=True; TrustServerCertificate=True"
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verificar si los campos obligatorios están vacíos, excluyendo Tel2CL
        If String.IsNullOrWhiteSpace(NombreCL.Text) OrElse
       String.IsNullOrWhiteSpace(DireccionCl.Text) OrElse
       String.IsNullOrWhiteSpace(Tel1CL.Text) OrElse
       String.IsNullOrWhiteSpace(CorreoCL.Text) OrElse
       String.IsNullOrWhiteSpace(NomContactoCL.Text) Then

            ' Mostrar mensaje si algún campo obligatorio está vacío
            MessageBox.Show("Debe llenar los datos del cliente antes.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Obtener los valores de los TextBox
            Dim nombre As String = NombreCL.Text
            Dim direccion As String = DireccionCl.Text
            Dim tel1 As String = Tel1CL.Text
            Dim tel2 As String = Tel2CL.Text
            Dim correo As String = CorreoCL.Text
            Dim contacto As String = NomContactoCL.Text



            ' Verificar si el correo electrónico tiene un formato válido
            If Not CorreoValido(CorreoCL.Text) Then
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Formato de Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            ' Consulta SQL para la inserción en la tabla Clientes
            Dim query As String = "INSERT INTO Clientes (id_Nombre, Direccion, Telefono, Telefono_sec, Correo, Nombre_Contacto) 
                        VALUES (@Nombre, @Direccion, @Telefono, @TelefonoSec, @Correo, @Contacto)"

            ' Usar un objeto SqlCommand para ejecutar la consulta
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    ' Agregar parámetros para evitar la inyección de SQL y establecer los valores
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@Direccion", direccion)
                    command.Parameters.AddWithValue("@Telefono", tel1)

                    ' Si el campo Tel2 está vacío, insertar NULL en la base de datos
                    If String.IsNullOrWhiteSpace(tel2) Then
                        command.Parameters.AddWithValue("@TelefonoSec", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@TelefonoSec", tel2)
                    End If

                    command.Parameters.AddWithValue("@Correo", correo)
                    command.Parameters.AddWithValue("@Contacto", contacto)

                    Try
                        connection.Open()
                        ' Ejecutar la consulta
                        command.ExecuteNonQuery()

                        ' Mostrar mensaje de éxito
                        MessageBox.Show("Se ha registrado al cliente correctamente", "Registrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Limpiar los TextBox después del registro exitoso
                        NombreCL.Text = ""
                        DireccionCl.Text = ""
                        Tel1CL.Text = ""
                        Tel2CL.Text = ""
                        CorreoCL.Text = ""
                        NomContactoCL.Text = ""

                    Catch ex As Exception
                        ' Manejar cualquier error que pueda ocurrir durante la inserción
                        MessageBox.Show("El cliente: " & NombreCL.Text & " se encuentra duplicado, intenté cambiar el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub


    Private Function CorreoValido(correo As String) As Boolean
        ' Expresión regular para validar correos electrónicos según el estándar RFC 5322
        Dim expresionRegular As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Validar el correo electrónico utilizando la expresión regular
        Dim coincide As Boolean = Regex.IsMatch(correo, expresionRegular)

        Return coincide
    End Function


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        MENU_CLIENTES.Show()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form3_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form3_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form3_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Panel1.MouseUp
        drag = False
    End Sub



    Private Sub NombreCL_TextChanged(sender As Object, e As EventArgs) Handles NombreCL.TextChanged

    End Sub

    Private Sub DireccionCl_TextChanged(sender As Object, e As EventArgs) Handles DireccionCl.TextChanged

    End Sub

    Private Sub Tel1CL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tel1CL.KeyPress

        ' Verificar si la tecla presionada es un número o la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Mostrar mensaje de error
            MessageBox.Show("Ingresa solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Cancelar la entrada de la tecla
            e.Handled = True
        End If
    End Sub

    Private Sub Tel2CL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tel2CL.KeyPress

        ' Verificar si la tecla presionada es un número o la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Mostrar mensaje de error
            MessageBox.Show("Ingresa solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Cancelar la entrada de la tecla
            e.Handled = True
        End If
    End Sub

    Private Sub CorreoCL_TextChanged(sender As Object, e As EventArgs) Handles CorreoCL.TextChanged

    End Sub

    Private Sub NomContactoCL_TextChanged(sender As Object, e As EventArgs) Handles NomContactoCL.TextChanged

    End Sub

End Class
