Imports System.IO
Imports System.Runtime.InteropServices
Public Class Ayudas
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, &H112&, &HF012&, 0)
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtener la ruta base del sistema "Control Copias a Consumo"
        Dim directorioBase As String = AppDomain.CurrentDomain.BaseDirectory

        ' Buscar el archivo Manual.pdf en cualquier parte de la carpeta del sistema
        Dim rutaPDF As String = BuscarArchivo(directorioBase, "Manual.pdf")

        ' Verificar si se encontró el archivo antes de intentar abrirlo
        If Not String.IsNullOrEmpty(rutaPDF) AndAlso File.Exists(rutaPDF) Then
            Try
                ' Abrir el archivo con la aplicación predeterminada
                Dim psi As New ProcessStartInfo With {
                .FileName = rutaPDF,
                .UseShellExecute = True,
                .Verb = "open"
            }
                Process.Start(psi)
            Catch ex As Exception
                MessageBox.Show("Error al intentar abrir el archivo PDF: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("El archivo Manual.pdf no fue encontrado en la carpeta del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Función para buscar el archivo en todos los subdirectorios
    Private Function BuscarArchivo(directorioBase As String, nombreArchivo As String) As String
        Try
            ' Buscar el archivo en la carpeta y sus subcarpetas
            Dim archivos As String() = Directory.GetFiles(directorioBase, nombreArchivo, SearchOption.AllDirectories)

            ' Si se encuentra el archivo, devolver la primera coincidencia
            If archivos.Length > 0 Then
                Return archivos(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Si no se encontró el archivo, devolver una cadena vacía
        Return String.Empty
    End Function



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Crear un mensaje con información sobre los programadores
        Dim mensaje As String = "Información de creadores:" & Environment.NewLine &
                                "--------------------------------" & Environment.NewLine &
                                "Nombre: Carlos Sánchez Eugenio" & Environment.NewLine &
                                "Email: carlospop1999@gmail.com" & Environment.NewLine &
                                Environment.NewLine &
                                "Nombre: Diego Alberto Torres Ramirez" & Environment.NewLine &
                                "Email: bbo2304@gmail.com" & Environment.NewLine &
                                "--------------------------------" & Environment.NewLine &
                                "Tecnólogico de Estudios Superiores de Cuautitlán Izcalli (TESCI)" & Environment.NewLine &
                                "Ingeniería en Sistemas Computacionales"


        ' Mostrar el mensaje en un cuadro de diálogo informativo
        MessageBox.Show(mensaje, "Información de Programadores", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Ayudas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el evento MouseDown para permitir arrastrar el formulario desde cualquier parte del formulario.
        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        ' Configurar el evento MouseDown para permitir arrastrar el formulario desde el panel.
        AddHandler Panel1.MouseDown, AddressOf Form_MouseDown

    End Sub
End Class