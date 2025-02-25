<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        NombresNU = New TextBox()
        ApellidosNU = New TextBox()
        PuestoNU = New TextBox()
        btnRegistrarNU = New Button()
        ContraseñaNU = New TextBox()
        Label6 = New Label()
        CorreoEleNU = New TextBox()
        Label7 = New Label()
        CheckBox4 = New CheckBox()
        Button2 = New Button()
        Button1 = New Button()
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
        Label1.Location = New Point(159, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(361, 28)
        Label1.TabIndex = 0
        Label1.Text = "REGISTRO DE NUEVO USUARIO."
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(682, 27)
        Panel1.TabIndex = 1
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(613, 6)
        btnMinimizar.Margin = New Padding(3, 2, 3, 2)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(22, 19)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 7
        btnMinimizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(650, 6)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(22, 19)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 6
        btnCerrar.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.Location = New Point(56, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 19)
        Label2.TabIndex = 2
        Label2.Text = "Nombre(s)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.Location = New Point(56, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 19)
        Label3.TabIndex = 3
        Label3.Text = "Apellidos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label4.Location = New Point(56, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 19)
        Label4.TabIndex = 4
        Label4.Text = "Cargo/Puesto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label5.Location = New Point(56, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 19)
        Label5.TabIndex = 5
        Label5.Text = "Privilegios: "
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        CheckBox1.Location = New Point(66, 338)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(101, 23)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Almacen"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.BackColor = Color.Transparent
        CheckBox3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        CheckBox3.Location = New Point(332, 338)
        CheckBox3.Margin = New Padding(3, 2, 3, 2)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(88, 23)
        CheckBox3.TabIndex = 7
        CheckBox3.Text = "Clientes"
        CheckBox3.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        CheckBox2.Location = New Point(203, 338)
        CheckBox2.Margin = New Padding(3, 2, 3, 2)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(88, 23)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Equipos"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' NombresNU
        ' 
        NombresNU.BackColor = SystemColors.InactiveCaption
        NombresNU.BorderStyle = BorderStyle.None
        NombresNU.Cursor = Cursors.IBeam
        NombresNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        NombresNU.Location = New Point(192, 98)
        NombresNU.Margin = New Padding(3, 2, 3, 2)
        NombresNU.Name = "NombresNU"
        NombresNU.Size = New Size(309, 20)
        NombresNU.TabIndex = 9
        ' 
        ' ApellidosNU
        ' 
        ApellidosNU.BackColor = SystemColors.InactiveCaption
        ApellidosNU.BorderStyle = BorderStyle.None
        ApellidosNU.Cursor = Cursors.IBeam
        ApellidosNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        ApellidosNU.Location = New Point(192, 135)
        ApellidosNU.Margin = New Padding(3, 2, 3, 2)
        ApellidosNU.Name = "ApellidosNU"
        ApellidosNU.Size = New Size(309, 20)
        ApellidosNU.TabIndex = 10
        ' 
        ' PuestoNU
        ' 
        PuestoNU.BackColor = SystemColors.InactiveCaption
        PuestoNU.BorderStyle = BorderStyle.None
        PuestoNU.Cursor = Cursors.IBeam
        PuestoNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        PuestoNU.Location = New Point(192, 171)
        PuestoNU.Margin = New Padding(3, 2, 3, 2)
        PuestoNU.Name = "PuestoNU"
        PuestoNU.Size = New Size(309, 20)
        PuestoNU.TabIndex = 11
        ' 
        ' btnRegistrarNU
        ' 
        btnRegistrarNU.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRegistrarNU.BackgroundImageLayout = ImageLayout.Zoom
        btnRegistrarNU.Cursor = Cursors.Hand
        btnRegistrarNU.FlatAppearance.BorderSize = 0
        btnRegistrarNU.FlatAppearance.MouseOverBackColor = Color.Silver
        btnRegistrarNU.FlatStyle = FlatStyle.Flat
        btnRegistrarNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnRegistrarNU.Image = CType(resources.GetObject("btnRegistrarNU.Image"), Image)
        btnRegistrarNU.ImageAlign = ContentAlignment.MiddleLeft
        btnRegistrarNU.Location = New Point(244, 394)
        btnRegistrarNU.Margin = New Padding(3, 2, 3, 2)
        btnRegistrarNU.Name = "btnRegistrarNU"
        btnRegistrarNU.Size = New Size(205, 55)
        btnRegistrarNU.TabIndex = 12
        btnRegistrarNU.Text = "Registrar Usuario"
        btnRegistrarNU.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRegistrarNU.UseVisualStyleBackColor = False
        ' 
        ' ContraseñaNU
        ' 
        ContraseñaNU.BackColor = SystemColors.InactiveCaption
        ContraseñaNU.BorderStyle = BorderStyle.None
        ContraseñaNU.Cursor = Cursors.IBeam
        ContraseñaNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        ContraseñaNU.Location = New Point(192, 211)
        ContraseñaNU.Margin = New Padding(3, 2, 3, 2)
        ContraseñaNU.Name = "ContraseñaNU"
        ContraseñaNU.Size = New Size(309, 20)
        ContraseñaNU.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label6.Location = New Point(56, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 19)
        Label6.TabIndex = 13
        Label6.Text = "Contraseña:"
        ' 
        ' CorreoEleNU
        ' 
        CorreoEleNU.BackColor = SystemColors.InactiveCaption
        CorreoEleNU.BorderStyle = BorderStyle.None
        CorreoEleNU.Cursor = Cursors.IBeam
        CorreoEleNU.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        CorreoEleNU.Location = New Point(229, 260)
        CorreoEleNU.Margin = New Padding(3, 2, 3, 2)
        CorreoEleNU.Name = "CorreoEleNU"
        CorreoEleNU.Size = New Size(272, 20)
        CorreoEleNU.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label7.Location = New Point(56, 261)
        Label7.Name = "Label7"
        Label7.Size = New Size(154, 19)
        Label7.TabIndex = 15
        Label7.Text = "Correo Electrónico:"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.BackColor = Color.Transparent
        CheckBox4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        CheckBox4.Location = New Point(467, 338)
        CheckBox4.Margin = New Padding(3, 2, 3, 2)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(90, 23)
        CheckBox4.TabIndex = 17
        CheckBox4.Text = "Usuarios"
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.Silver
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Button2.Image = My.Resources.eliminar_usuario
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(466, 394)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(205, 55)
        Button2.TabIndex = 18
        Button2.Text = "Eliminar Usuario"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.Silver
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Button1.Image = My.Resources.editar_usuario
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(19, 394)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 55)
        Button1.TabIndex = 19
        Button1.Text = "Editar Usuario"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(682, 468)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(CheckBox4)
        Controls.Add(CorreoEleNU)
        Controls.Add(Label7)
        Controls.Add(ContraseñaNU)
        Controls.Add(Label6)
        Controls.Add(btnRegistrarNU)
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
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registro de Usuarios"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents NombresNU As TextBox
    Friend WithEvents ApellidosNU As TextBox
    Friend WithEvents PuestoNU As TextBox
    Friend WithEvents btnRegistrarNU As Button
    Friend WithEvents ContraseñaNU As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CorreoEleNU As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
