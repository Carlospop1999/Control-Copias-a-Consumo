<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Index
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Index))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button4 = New Button()
        Button5 = New Button()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.fondo_rosa
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Button1.Image = My.Resources.almacenB
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(29, 218)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(516, 92)
        Button1.TabIndex = 0
        Button1.Text = "Almacén"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.fonfo_amarillo_boton
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseDownBackColor = Color.Black
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Image = My.Resources.impresora_icon
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(29, 346)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(516, 92)
        Button2.TabIndex = 1
        Button2.Text = "Equipos"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.fondo_azul
        Button3.BackgroundImageLayout = ImageLayout.Center
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderColor = Color.Black
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Button3.Image = My.Resources.cliente_icon
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(29, 470)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(516, 92)
        Button3.TabIndex = 2
        Button3.Text = "Clientes"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        Label1.Location = New Point(163, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 65)
        Label1.TabIndex = 4
        Label1.Text = "CONTROL"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(576, 27)
        Panel1.TabIndex = 5
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(543, 2)
        btnMinimizar.Margin = New Padding(3, 2, 3, 2)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(22, 19)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 7
        btnMinimizar.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 595)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(106, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(29, 38)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(516, 99)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(410, 574)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(135, 55)
        Button4.TabIndex = 8
        Button4.Text = "Nuevo Usuario"
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button5.BackgroundImageLayout = ImageLayout.Zoom
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 2
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(254, 574)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(135, 55)
        Button5.TabIndex = 9
        Button5.Text = "Exportar a Excel"
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Index
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(576, 624)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Index"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menú Principal"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
