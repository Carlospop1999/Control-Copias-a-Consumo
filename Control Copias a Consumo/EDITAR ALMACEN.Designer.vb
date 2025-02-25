<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDITAR_ALMACEN
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(EDITAR_ALMACEN))
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        TextBox6 = New TextBox()
        Label7 = New Label()
        Button3 = New Button()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button4 = New Button()
        Button2 = New Button()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(923, 36)
        Panel1.TabIndex = 38
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(843, 8)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(25, 25)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 3
        btnMinimizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(886, 8)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 2
        btnCerrar.TabStop = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(374, 509)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(182, 25)
        TextBox6.TabIndex = 33
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(374, 475)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 19)
        Label7.TabIndex = 32
        Label7.Text = "Proveedor"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(605, 577)
        Button3.Name = "Button3"
        Button3.Size = New Size(275, 73)
        Button3.TabIndex = 30
        Button3.Text = "Guardar  Inventario."
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(22, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(288, 23)
        Label6.TabIndex = 29
        Label6.Text = "Imagen referente a la pieza:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 227)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(297, 284)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(621, 427)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(182, 25)
        TextBox5.TabIndex = 27
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(374, 427)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(182, 25)
        TextBox4.TabIndex = 26
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(370, 340)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(433, 25)
        TextBox3.TabIndex = 25
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(621, 261)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 25)
        TextBox2.TabIndex = 24
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(370, 261)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 25)
        TextBox1.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(621, 385)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 19)
        Label5.TabIndex = 22
        Label5.Text = "Modelo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(374, 385)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 19)
        Label4.TabIndex = 21
        Label4.Text = "Cantidad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(370, 304)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 19)
        Label3.TabIndex = 20
        Label3.Text = "Numero de serie/ pieza"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(621, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 19)
        Label2.TabIndex = 19
        Label2.Text = "Marca"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(370, 227)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 19)
        Label1.TabIndex = 18
        Label1.Text = "Nombre"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(313, 577)
        Button4.Name = "Button4"
        Button4.Size = New Size(275, 73)
        Button4.TabIndex = 34
        Button4.Text = "Editar Inventario."
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(374, 173)
        Button2.Name = "Button2"
        Button2.Size = New Size(469, 29)
        Button2.TabIndex = 37
        Button2.Text = "Buscar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(216, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(152, 31)
        Label8.TabIndex = 36
        Label8.Text = "No. de Pieza:"
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.Gainsboro
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Location = New Point(374, 132)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(473, 20)
        TextBox7.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(341, 61)
        Label9.Name = "Label9"
        Label9.Size = New Size(277, 34)
        Label9.TabIndex = 39
        Label9.Text = "Editar en Inventario"
        ' 
        ' EDITAR_ALMACEN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(923, 691)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Label8)
        Controls.Add(TextBox7)
        Controls.Add(Button4)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "EDITAR_ALMACEN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Editar Almacén"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
End Class
