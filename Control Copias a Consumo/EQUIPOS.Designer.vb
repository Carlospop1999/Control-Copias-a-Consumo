<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EQUIPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EQUIPOS))
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtMRE = New TextBox()
        txtMDE = New TextBox()
        txtNSE = New TextBox()
        txtCLE = New TextBox()
        txtULE = New TextBox()
        txtbusquedacl = New TextBox()
        PBQR = New PictureBox()
        Panel1 = New Panel()
        Button5 = New Button()
        Button6 = New Button()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBQR, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(664, 8)
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
        btnCerrar.Location = New Point(701, 8)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(22, 19)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 2
        btnCerrar.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button1.Cursor = Cursors.Help
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(10, 52)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(208, 35)
        Button1.TabIndex = 0
        Button1.Text = "Buscar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.Location = New Point(10, 104)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(208, 35)
        Button2.TabIndex = 1
        Button2.Text = "Editar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button3.Location = New Point(10, 248)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(241, 62)
        Button3.TabIndex = 2
        Button3.Text = "Agregar/Actualizar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button4.Location = New Point(10, 154)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(208, 35)
        Button4.TabIndex = 3
        Button4.Text = "Eliminar"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(267, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 21)
        Label1.TabIndex = 4
        Label1.Text = "Marca"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(385, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 21)
        Label2.TabIndex = 5
        Label2.Text = "Modelo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(478, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 21)
        Label3.TabIndex = 6
        Label3.Text = "Numero de serie"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(249, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 21)
        Label4.TabIndex = 7
        Label4.Text = "Cliente"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(349, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 21)
        Label5.TabIndex = 8
        Label5.Text = "Ultima lectura"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.Location = New Point(564, 133)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 21)
        Label6.TabIndex = 9
        Label6.Text = "QR"
        ' 
        ' txtMRE
        ' 
        txtMRE.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtMRE.BorderStyle = BorderStyle.None
        txtMRE.Cursor = Cursors.IBeam
        txtMRE.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        txtMRE.Location = New Point(234, 104)
        txtMRE.Margin = New Padding(3, 2, 3, 2)
        txtMRE.Name = "txtMRE"
        txtMRE.Size = New Size(109, 17)
        txtMRE.TabIndex = 10
        ' 
        ' txtMDE
        ' 
        txtMDE.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtMDE.BorderStyle = BorderStyle.None
        txtMDE.Cursor = Cursors.IBeam
        txtMDE.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        txtMDE.Location = New Point(363, 104)
        txtMDE.Margin = New Padding(3, 2, 3, 2)
        txtMDE.Name = "txtMDE"
        txtMDE.Size = New Size(109, 17)
        txtMDE.TabIndex = 11
        ' 
        ' txtNSE
        ' 
        txtNSE.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNSE.BorderStyle = BorderStyle.None
        txtNSE.Cursor = Cursors.IBeam
        txtNSE.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        txtNSE.Location = New Point(483, 104)
        txtNSE.Margin = New Padding(3, 2, 3, 2)
        txtNSE.Name = "txtNSE"
        txtNSE.Size = New Size(181, 17)
        txtNSE.TabIndex = 12
        ' 
        ' txtCLE
        ' 
        txtCLE.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtCLE.BorderStyle = BorderStyle.None
        txtCLE.Cursor = Cursors.IBeam
        txtCLE.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        txtCLE.Location = New Point(234, 200)
        txtCLE.Margin = New Padding(3, 2, 3, 2)
        txtCLE.Name = "txtCLE"
        txtCLE.Size = New Size(109, 17)
        txtCLE.TabIndex = 13
        ' 
        ' txtULE
        ' 
        txtULE.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtULE.BorderStyle = BorderStyle.None
        txtULE.Cursor = Cursors.IBeam
        txtULE.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        txtULE.Location = New Point(363, 200)
        txtULE.Margin = New Padding(3, 2, 3, 2)
        txtULE.Name = "txtULE"
        txtULE.Size = New Size(109, 17)
        txtULE.TabIndex = 14
        ' 
        ' txtbusquedacl
        ' 
        txtbusquedacl.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtbusquedacl.BorderStyle = BorderStyle.None
        txtbusquedacl.Cursor = Cursors.IBeam
        txtbusquedacl.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        txtbusquedacl.Location = New Point(233, 47)
        txtbusquedacl.Margin = New Padding(3, 2, 3, 2)
        txtbusquedacl.Name = "txtbusquedacl"
        txtbusquedacl.Size = New Size(431, 17)
        txtbusquedacl.TabIndex = 16
        ' 
        ' PBQR
        ' 
        PBQR.Location = New Point(483, 156)
        PBQR.Margin = New Padding(3, 2, 3, 2)
        PBQR.Name = "PBQR"
        PBQR.Size = New Size(193, 136)
        PBQR.TabIndex = 38
        PBQR.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel1.Controls.Add(btnCerrar)
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(733, 28)
        Panel1.TabIndex = 39
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Button5.Location = New Point(483, 297)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(193, 22)
        Button5.TabIndex = 40
        Button5.Text = "Agregar QR"
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
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button6.Location = New Point(257, 253)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(220, 52)
        Button6.TabIndex = 41
        Button6.Text = "Exportar a Excel"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' EQUIPOS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.fondo_forms2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(733, 336)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        Controls.Add(PBQR)
        Controls.Add(txtbusquedacl)
        Controls.Add(txtULE)
        Controls.Add(txtCLE)
        Controls.Add(txtNSE)
        Controls.Add(txtMDE)
        Controls.Add(txtMRE)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "EQUIPOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EQUIPOS"
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(PBQR, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMRE As TextBox
    Friend WithEvents txtMDE As TextBox
    Friend WithEvents txtNSE As TextBox
    Friend WithEvents txtCLE As TextBox
    Friend WithEvents txtULE As TextBox
    Friend WithEvents txtbusquedacl As TextBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PBQR As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
