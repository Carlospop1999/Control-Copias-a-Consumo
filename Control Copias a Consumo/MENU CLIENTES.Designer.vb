<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_CLIENTES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU_CLIENTES))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Button4 = New Button()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
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
        Button1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Button1.Image = My.Resources.alta_icono2
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(80, 109)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(310, 87)
        Button1.TabIndex = 0
        Button1.Text = "Alta Cliente"
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
        Button2.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Button2.Image = My.Resources.baja_icono
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(80, 205)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(310, 87)
        Button2.TabIndex = 1
        Button2.Text = "Baja Cliente"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Button3.Image = My.Resources.buscar
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(80, 303)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(310, 112)
        Button3.TabIndex = 2
        Button3.Text = "Buscar"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        Label1.Location = New Point(128, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 65)
        Label1.TabIndex = 3
        Label1.Text = "Clientes"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(472, 27)
        Panel1.TabIndex = 4
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(402, 6)
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
        btnCerrar.Location = New Point(439, 6)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(22, 19)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 6
        btnCerrar.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        Button4.Image = My.Resources.alta_icono2
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(80, 426)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(310, 87)
        Button4.TabIndex = 5
        Button4.Text = "Exportar a Excel"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' MENU_CLIENTES
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        BackgroundImage = My.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(472, 524)
        Controls.Add(Button4)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "MENU_CLIENTES"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menú Clientes"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Button4 As Button
End Class
