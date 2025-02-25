<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RECcontraseña
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RECcontraseña))
        Label1 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(70, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 23)
        Label1.TabIndex = 0
        Label1.Text = "Seleccionar Usuario:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.Silver
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(224, 265)
        Button1.Name = "Button1"
        Button1.Size = New Size(305, 53)
        Button1.TabIndex = 4
        Button1.Text = "Enviar Codigo"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(733, 36)
        Panel1.TabIndex = 5
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(654, 8)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(25, 25)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 9
        btnMinimizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(696, 8)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 8
        btnCerrar.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(215, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(314, 23)
        Label2.TabIndex = 6
        Label2.Text = "Recuperacion de Contraseñas:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(295, 141)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(414, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(21, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(273, 23)
        Label3.TabIndex = 8
        Label3.Text = "Validar correo electrónico:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(295, 205)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(414, 27)
        TextBox1.TabIndex = 9
        ' 
        ' RECcontraseña
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(733, 349)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RECcontraseña"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Recuperar Contraseña"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
