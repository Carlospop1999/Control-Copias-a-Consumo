<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALMACÉN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALMACÉN))
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Label2 = New Label()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Button1.Image = My.Resources.alta_icono2
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(18, 107)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(234, 87)
        Button1.TabIndex = 0
        Button1.Text = "Altas"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Button2.Image = My.Resources.baja_icono
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(18, 214)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(234, 87)
        Button2.TabIndex = 1
        Button2.Text = "Bajas"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(514, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 25)
        Label1.TabIndex = 4
        Label1.Text = "Busqueda en Inventario:"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Button3.Image = My.Resources.reloj_icono
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(18, 320)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(234, 102)
        Button3.TabIndex = 5
        Button3.Text = "Registros previos"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 36F, FontStyle.Bold)
        Label2.Location = New Point(18, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 65)
        Label2.TabIndex = 6
        Label2.Text = "Almacén"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(892, 28)
        Panel1.TabIndex = 7
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(822, 8)
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
        btnCerrar.Location = New Point(859, 8)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(22, 19)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 4
        btnCerrar.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(429, 98)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(414, 16)
        TextBox1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(290, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 25)
        Label3.TabIndex = 9
        Label3.Text = "No. de Pieza:"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Button4.Location = New Point(421, 129)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(422, 22)
        Button4.TabIndex = 10
        Button4.Text = "Buscar"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(290, 166)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(554, 330)
        DataGridView1.TabIndex = 11
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button5.FlatAppearance.BorderSize = 2
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Button5.Image = My.Resources.baja_icono
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(18, 445)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(234, 87)
        Button5.TabIndex = 12
        Button5.Text = "Editar"
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button6.Cursor = Cursors.Hand
        Button6.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button6.FlatAppearance.BorderSize = 2
        Button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Button6.Image = My.Resources.alta_icono2
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(301, 510)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(303, 45)
        Button6.TabIndex = 13
        Button6.Text = "Actualizar Cantidad"
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button7.Cursor = Cursors.Hand
        Button7.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button7.FlatAppearance.BorderSize = 2
        Button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button7.Image = My.Resources.alta_icono2
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(613, 511)
        Button7.Margin = New Padding(3, 2, 3, 2)
        Button7.Name = "Button7"
        Button7.Size = New Size(228, 45)
        Button7.TabIndex = 14
        Button7.Text = "Exportar a Excel"
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = False
        ' 
        ' ALMACÉN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        BackgroundImage = My.Resources.fondo_forms1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(892, 566)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ALMACÉN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ALMACÉN"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
