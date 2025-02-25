<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ayudas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Ayudas))
        Label1 = New Label()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
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
        Label1.Font = New Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(192, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 44)
        Label1.TabIndex = 7
        Label1.Text = "Ayuda."
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(506, 36)
        Panel1.TabIndex = 8
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(426, 8)
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
        btnCerrar.Location = New Point(469, 8)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 8
        btnCerrar.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.fondo_azul
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Image = My.Resources.Resources.cliente_icon
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(88, 275)
        Button2.Name = "Button2"
        Button2.Size = New Size(330, 95)
        Button2.TabIndex = 10
        Button2.Text = "Contacto"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.fondo_rosa
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(88, 155)
        Button1.Name = "Button1"
        Button1.Size = New Size(330, 95)
        Button1.TabIndex = 9
        Button1.Text = "Manual de Usuario"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Ayudas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(506, 407)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Ayudas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ayudas"
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
