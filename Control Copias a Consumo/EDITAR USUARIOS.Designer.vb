<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDITAR_USUARIOS
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(EDITAR_USUARIOS))
        CheckBox4 = New CheckBox()
        CorreoEleNU = New TextBox()
        Label7 = New Label()
        ContraseñaNU = New TextBox()
        Label6 = New Label()
        Button3 = New Button()
        PuestoNU = New TextBox()
        ApellidosNU = New TextBox()
        NombresNU = New TextBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox7 = New TextBox()
        Label8 = New Label()
        Button2 = New Button()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        LinkLabel2 = New LinkLabel()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.BackColor = Color.Transparent
        CheckBox4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox4.Location = New Point(552, 519)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(112, 27)
        CheckBox4.TabIndex = 36
        CheckBox4.Text = "Usuarios"
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' CorreoEleNU
        ' 
        CorreoEleNU.BackColor = SystemColors.InactiveCaption
        CorreoEleNU.BorderStyle = BorderStyle.None
        CorreoEleNU.Cursor = Cursors.IBeam
        CorreoEleNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CorreoEleNU.Location = New Point(280, 413)
        CorreoEleNU.Name = "CorreoEleNU"
        CorreoEleNU.Size = New Size(311, 25)
        CorreoEleNU.TabIndex = 35
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(82, 416)
        Label7.Name = "Label7"
        Label7.Size = New Size(198, 23)
        Label7.TabIndex = 34
        Label7.Text = "Correo Electrónico:"
        ' 
        ' ContraseñaNU
        ' 
        ContraseñaNU.BackColor = SystemColors.InactiveCaption
        ContraseñaNU.BorderStyle = BorderStyle.None
        ContraseñaNU.Cursor = Cursors.IBeam
        ContraseñaNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ContraseñaNU.Location = New Point(238, 349)
        ContraseñaNU.Name = "ContraseñaNU"
        ContraseñaNU.Size = New Size(353, 25)
        ContraseñaNU.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(82, 351)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 23)
        Label6.TabIndex = 32
        Label6.Text = "Contraseña:"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.Silver
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(238, 575)
        Button3.Name = "Button3"
        Button3.Size = New Size(353, 73)
        Button3.TabIndex = 31
        Button3.Text = "Guardar Cambios"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PuestoNU
        ' 
        PuestoNU.BackColor = SystemColors.InactiveCaption
        PuestoNU.BorderStyle = BorderStyle.None
        PuestoNU.Cursor = Cursors.IBeam
        PuestoNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PuestoNU.Location = New Point(238, 296)
        PuestoNU.Name = "PuestoNU"
        PuestoNU.Size = New Size(353, 25)
        PuestoNU.TabIndex = 30
        ' 
        ' ApellidosNU
        ' 
        ApellidosNU.BackColor = SystemColors.InactiveCaption
        ApellidosNU.BorderStyle = BorderStyle.None
        ApellidosNU.Cursor = Cursors.IBeam
        ApellidosNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ApellidosNU.Location = New Point(238, 248)
        ApellidosNU.Name = "ApellidosNU"
        ApellidosNU.Size = New Size(353, 25)
        ApellidosNU.TabIndex = 29
        ' 
        ' NombresNU
        ' 
        NombresNU.BackColor = SystemColors.InactiveCaption
        NombresNU.BorderStyle = BorderStyle.None
        NombresNU.Cursor = Cursors.IBeam
        NombresNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NombresNU.Location = New Point(238, 199)
        NombresNU.Name = "NombresNU"
        NombresNU.Size = New Size(353, 25)
        NombresNU.TabIndex = 28
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.Location = New Point(250, 519)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(107, 27)
        CheckBox2.TabIndex = 27
        CheckBox2.Text = "Equipos"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.BackColor = Color.Transparent
        CheckBox3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox3.Location = New Point(398, 519)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(111, 27)
        CheckBox3.TabIndex = 26
        CheckBox3.Text = "Clientes"
        CheckBox3.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.Location = New Point(94, 519)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(122, 27)
        CheckBox1.TabIndex = 25
        CheckBox1.Text = "Almacen"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(82, 479)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 23)
        Label5.TabIndex = 24
        Label5.Text = "Privilegios: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(82, 299)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 23)
        Label4.TabIndex = 23
        Label4.Text = "Cargo/Puesto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(82, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 23)
        Label3.TabIndex = 22
        Label3.Text = "Apellidos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(82, 199)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 23)
        Label2.TabIndex = 21
        Label2.Text = "Nombre(s)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(280, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 37)
        Label1.TabIndex = 20
        Label1.Text = "EDITAR  USUARIOS."
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = SystemColors.InactiveCaption
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Cursor = Cursors.IBeam
        TextBox7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(238, 116)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(411, 25)
        TextBox7.TabIndex = 40
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(82, 116)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 23)
        Label8.TabIndex = 39
        Label8.Text = "Busqueda:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(238, 147)
        Button2.Name = "Button2"
        Button2.Size = New Size(411, 29)
        Button2.TabIndex = 41
        Button2.Text = "Buscar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 36)
        Panel1.TabIndex = 42
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(721, 3)
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
        btnCerrar.Location = New Point(763, 3)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 8
        btnCerrar.TabStop = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel2.Location = New Point(598, 349)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(140, 21)
        LinkLabel2.TabIndex = 43
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Ver contraseña"
        ' 
        ' EDITAR_USUARIOS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 699)
        Controls.Add(LinkLabel2)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(TextBox7)
        Controls.Add(Label8)
        Controls.Add(CheckBox4)
        Controls.Add(CorreoEleNU)
        Controls.Add(Label7)
        Controls.Add(ContraseñaNU)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(PuestoNU)
        Controls.Add(ApellidosNU)
        Controls.Add(NombresNU)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "EDITAR_USUARIOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Editar Usuarios"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CorreoEleNU As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ContraseñaNU As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PuestoNU As TextBox
    Friend WithEvents ApellidosNU As TextBox
    Friend WithEvents NombresNU As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
