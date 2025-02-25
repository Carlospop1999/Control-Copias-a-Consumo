<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Almacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alta_Almacen))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Button4 = New Button()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        btnImagenAA = New Button()
        TextBox6 = New TextBox()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(315, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 17)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(535, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 17)
        Label2.TabIndex = 2
        Label2.Text = "Marca"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(315, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 17)
        Label3.TabIndex = 3
        Label3.Text = "Numero de serie/ pieza"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(318, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 17)
        Label4.TabIndex = 4
        Label4.Text = "Cantidad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(535, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 17)
        Label5.TabIndex = 5
        Label5.Text = "Modelo"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        TextBox1.Location = New Point(315, 117)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(159, 20)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        TextBox2.Location = New Point(535, 117)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(159, 20)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        TextBox3.Location = New Point(315, 176)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(379, 20)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        TextBox4.Location = New Point(318, 241)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(159, 20)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        TextBox5.Location = New Point(535, 241)
        TextBox5.Margin = New Padding(3, 2, 3, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(159, 20)
        TextBox5.TabIndex = 10
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 90)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(260, 213)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label6.Location = New Point(10, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(228, 19)
        Label6.TabIndex = 12
        Label6.Text = "Imagen referente a la pieza:"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(389, 341)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(241, 55)
        Button4.TabIndex = 13
        Button4.Text = "Añadir al Inventario."
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(724, 27)
        Panel1.TabIndex = 14
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(655, 6)
        btnMinimizar.Margin = New Padding(3, 2, 3, 2)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(22, 19)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 5
        btnMinimizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(692, 6)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(22, 19)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 4
        btnCerrar.TabStop = False
        ' 
        ' btnImagenAA
        ' 
        btnImagenAA.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnImagenAA.Cursor = Cursors.Hand
        btnImagenAA.FlatAppearance.BorderSize = 0
        btnImagenAA.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnImagenAA.FlatStyle = FlatStyle.Flat
        btnImagenAA.Location = New Point(19, 309)
        btnImagenAA.Margin = New Padding(3, 2, 3, 2)
        btnImagenAA.Name = "btnImagenAA"
        btnImagenAA.Size = New Size(258, 22)
        btnImagenAA.TabIndex = 15
        btnImagenAA.Text = "AGREGAR IMAGEN."
        btnImagenAA.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        TextBox6.Location = New Point(318, 302)
        TextBox6.Margin = New Padding(3, 2, 3, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(159, 20)
        TextBox6.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label7.Location = New Point(318, 276)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 17)
        Label7.TabIndex = 16
        Label7.Text = "Proveedor"
        ' 
        ' Alta_Almacen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(724, 418)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(btnImagenAA)
        Controls.Add(Panel1)
        Controls.Add(Button4)
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
        Margin = New Padding(3, 2, 3, 2)
        Name = "Alta_Almacen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alta Almacén"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnImagenAA As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
End Class
