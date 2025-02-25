<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        LinkLabel2 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(121, 321)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(318, 44)
        Button1.TabIndex = 0
        Button1.Text = "Iniciar Sesión"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        ComboBox1.Cursor = Cursors.Hand
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(162, 206)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(240, 27)
        ComboBox1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Cursor = Cursors.Hand
        TextBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(162, 269)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "•"c
        TextBox1.Size = New Size(240, 25)
        TextBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(162, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 19)
        Label1.TabIndex = 3
        Label1.Text = "Contraseña:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(38, 51)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(516, 99)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
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
        Panel1.Size = New Size(590, 30)
        Panel1.TabIndex = 6
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(521, 2)
        btnMinimizar.Margin = New Padding(3, 2, 3, 2)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(22, 19)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 1
        btnMinimizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(557, 2)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(22, 19)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 0
        btnCerrar.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.Location = New Point(18, 391)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(167, 19)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Recuperar Contraseña"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(162, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 19)
        Label2.TabIndex = 8
        Label2.Text = "Selecciona Usuario:"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel2.Location = New Point(407, 275)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(114, 19)
        LinkLabel2.TabIndex = 9
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Ver contraseña"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel3.Location = New Point(512, 391)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(55, 19)
        LinkLabel3.TabIndex = 10
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Ayuda"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(590, 422)
        Controls.Add(LinkLabel3)
        Controls.Add(LinkLabel2)
        Controls.Add(Label2)
        Controls.Add(LinkLabel1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio de Sesión"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
End Class
