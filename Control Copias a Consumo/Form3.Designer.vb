<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        NombreCL = New TextBox()
        Tel1CL = New TextBox()
        CorreoCL = New TextBox()
        NomContactoCL = New TextBox()
        DireccionCl = New TextBox()
        Tel2CL = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label1.Location = New Point(263, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 28)
        Label1.TabIndex = 0
        Label1.Text = "Alta de Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label2.Location = New Point(49, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 16)
        Label2.TabIndex = 2
        Label2.Text = "Nombre del Cliente:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label3.Location = New Point(49, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 16)
        Label3.TabIndex = 3
        Label3.Text = "Teléfono:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label4.Location = New Point(49, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 16)
        Label4.TabIndex = 4
        Label4.Text = "Correo Electrónico:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label5.Location = New Point(49, 304)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 16)
        Label5.TabIndex = 5
        Label5.Text = "Nombre del Contacto:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label6.Location = New Point(49, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 16)
        Label6.TabIndex = 6
        Label6.Text = "Dirección:"
        ' 
        ' NombreCL
        ' 
        NombreCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        NombreCL.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        NombreCL.Location = New Point(179, 140)
        NombreCL.Margin = New Padding(3, 2, 3, 2)
        NombreCL.Name = "NombreCL"
        NombreCL.Size = New Size(468, 22)
        NombreCL.TabIndex = 7
        ' 
        ' Tel1CL
        ' 
        Tel1CL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Tel1CL.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Tel1CL.Location = New Point(130, 221)
        Tel1CL.Margin = New Padding(3, 2, 3, 2)
        Tel1CL.Name = "Tel1CL"
        Tel1CL.Size = New Size(136, 22)
        Tel1CL.TabIndex = 8
        ' 
        ' CorreoCL
        ' 
        CorreoCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        CorreoCL.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        CorreoCL.Location = New Point(187, 260)
        CorreoCL.Margin = New Padding(3, 2, 3, 2)
        CorreoCL.Name = "CorreoCL"
        CorreoCL.Size = New Size(460, 22)
        CorreoCL.TabIndex = 9
        ' 
        ' NomContactoCL
        ' 
        NomContactoCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        NomContactoCL.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        NomContactoCL.Location = New Point(206, 298)
        NomContactoCL.Margin = New Padding(3, 2, 3, 2)
        NomContactoCL.Name = "NomContactoCL"
        NomContactoCL.Size = New Size(442, 22)
        NomContactoCL.TabIndex = 10
        ' 
        ' DireccionCl
        ' 
        DireccionCl.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        DireccionCl.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        DireccionCl.Location = New Point(130, 180)
        DireccionCl.Margin = New Padding(3, 2, 3, 2)
        DireccionCl.Name = "DireccionCl"
        DireccionCl.Size = New Size(517, 22)
        DireccionCl.TabIndex = 11
        ' 
        ' Tel2CL
        ' 
        Tel2CL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Tel2CL.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Tel2CL.Location = New Point(494, 221)
        Tel2CL.Margin = New Padding(3, 2, 3, 2)
        Tel2CL.Name = "Tel2CL"
        Tel2CL.Size = New Size(154, 22)
        Tel2CL.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label7.Location = New Point(271, 224)
        Label7.Name = "Label7"
        Label7.Size = New Size(198, 16)
        Label7.TabIndex = 12
        Label7.Text = "Teléfono secundario (Opcional):"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(271, 334)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 55)
        Button1.TabIndex = 1
        Button1.Text = "Registrar"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(700, 30)
        Panel1.TabIndex = 14
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(623, 9)
        btnMinimizar.Margin = New Padding(3, 2, 3, 2)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(22, 19)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 3
        btnMinimizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(660, 9)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(22, 19)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 2
        btnCerrar.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Gothic", 6.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(63, 156)
        Label8.Name = "Label8"
        Label8.Size = New Size(95, 12)
        Label8.TabIndex = 15
        Label8.Text = "(No repetir cliente)"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(700, 450)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Controls.Add(Tel2CL)
        Controls.Add(Label7)
        Controls.Add(DireccionCl)
        Controls.Add(NomContactoCL)
        Controls.Add(CorreoCL)
        Controls.Add(Tel1CL)
        Controls.Add(NombreCL)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alta Cliente"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NombreCL As TextBox
    Friend WithEvents Tel1CL As TextBox
    Friend WithEvents CorreoCL As TextBox
    Friend WithEvents NomContactoCL As TextBox
    Friend WithEvents DireccionCl As TextBox
    Friend WithEvents Tel2CL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Label8 As Label
End Class
