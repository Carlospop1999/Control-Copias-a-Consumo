<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENTES
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CLIENTES))
        BusquedaConCL = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        NombreConCL = New TextBox()
        DireccionConCL = New TextBox()
        Tel1ConCL = New TextBox()
        CorreoConCL = New TextBox()
        ContactoConCL = New TextBox()
        Label8 = New Label()
        btnBuscarCliente = New Button()
        Panel1 = New Panel()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Label9 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Tel2ConCL = New TextBox()
        Label7 = New Label()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BusquedaConCL
        ' 
        BusquedaConCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        BusquedaConCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BusquedaConCL.Location = New Point(24, 155)
        BusquedaConCL.Name = "BusquedaConCL"
        BusquedaConCL.Size = New Size(749, 32)
        BusquedaConCL.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 19)
        Label1.TabIndex = 4
        Label1.Text = "Busqueda de cliente por nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(24, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 19)
        Label2.TabIndex = 5
        Label2.Text = "Cliente:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(24, 337)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 19)
        Label3.TabIndex = 6
        Label3.Text = "Dirección:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(24, 400)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 19)
        Label4.TabIndex = 7
        Label4.Text = "Telefono:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(22, 451)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 19)
        Label5.TabIndex = 8
        Label5.Text = "Correo:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(367, 451)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 19)
        Label6.TabIndex = 9
        Label6.Text = "Nombre de Contacto:"
        ' 
        ' NombreConCL
        ' 
        NombreConCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        NombreConCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NombreConCL.Location = New Point(123, 276)
        NombreConCL.Name = "NombreConCL"
        NombreConCL.Size = New Size(650, 32)
        NombreConCL.TabIndex = 11
        ' 
        ' DireccionConCL
        ' 
        DireccionConCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        DireccionConCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DireccionConCL.Location = New Point(123, 331)
        DireccionConCL.Name = "DireccionConCL"
        DireccionConCL.Size = New Size(650, 32)
        DireccionConCL.TabIndex = 12
        ' 
        ' Tel1ConCL
        ' 
        Tel1ConCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Tel1ConCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Tel1ConCL.Location = New Point(105, 397)
        Tel1ConCL.Name = "Tel1ConCL"
        Tel1ConCL.Size = New Size(219, 32)
        Tel1ConCL.TabIndex = 13
        ' 
        ' CorreoConCL
        ' 
        CorreoConCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        CorreoConCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CorreoConCL.Location = New Point(95, 451)
        CorreoConCL.Name = "CorreoConCL"
        CorreoConCL.Size = New Size(266, 32)
        CorreoConCL.TabIndex = 14
        ' 
        ' ContactoConCL
        ' 
        ContactoConCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        ContactoConCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ContactoConCL.Location = New Point(554, 451)
        ContactoConCL.Name = "ContactoConCL"
        ContactoConCL.Size = New Size(219, 32)
        ContactoConCL.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(24, 197)
        Label8.Name = "Label8"
        Label8.Size = New Size(322, 50)
        Label8.TabIndex = 17
        Label8.Text = "Datos del cliente:"
        ' 
        ' btnBuscarCliente
        ' 
        btnBuscarCliente.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        btnBuscarCliente.BackgroundImageLayout = ImageLayout.None
        btnBuscarCliente.Cursor = Cursors.Hand
        btnBuscarCliente.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnBuscarCliente.FlatAppearance.BorderSize = 0
        btnBuscarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnBuscarCliente.FlatStyle = FlatStyle.Flat
        btnBuscarCliente.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), Image)
        btnBuscarCliente.ImageAlign = ContentAlignment.MiddleLeft
        btnBuscarCliente.Location = New Point(783, 155)
        btnBuscarCliente.Name = "btnBuscarCliente"
        btnBuscarCliente.Size = New Size(155, 72)
        btnBuscarCliente.TabIndex = 18
        btnBuscarCliente.Text = "Buscar"
        btnBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBuscarCliente.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(998, 36)
        Panel1.TabIndex = 19
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(919, 3)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(25, 25)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 5
        btnMinimizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(961, 3)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 4
        btnCerrar.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(343, 64)
        Label9.Name = "Label9"
        Label9.Size = New Size(291, 34)
        Label9.TabIndex = 20
        Label9.Text = "Consulta de clientes"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(301, 528)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 51)
        Button1.TabIndex = 21
        Button1.Text = "Editar"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(538, 528)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 51)
        Button2.TabIndex = 22
        Button2.Text = "Guardar"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Tel2ConCL
        ' 
        Tel2ConCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Tel2ConCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Tel2ConCL.Location = New Point(554, 395)
        Tel2ConCL.Name = "Tel2ConCL"
        Tel2ConCL.Size = New Size(219, 32)
        Tel2ConCL.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(343, 397)
        Label7.Name = "Label7"
        Label7.Size = New Size(205, 19)
        Label7.TabIndex = 23
        Label7.Text = "Telefono sec. Opcional:"
        ' 
        ' CLIENTES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(998, 601)
        Controls.Add(Tel2ConCL)
        Controls.Add(Label7)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(btnBuscarCliente)
        Controls.Add(Label8)
        Controls.Add(ContactoConCL)
        Controls.Add(CorreoConCL)
        Controls.Add(Tel1ConCL)
        Controls.Add(DireccionConCL)
        Controls.Add(NombreConCL)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BusquedaConCL)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "CLIENTES"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Busqueda Clientes"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BusquedaConCL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NombreConCL As TextBox
    Friend WithEvents DireccionConCL As TextBox
    Friend WithEvents Tel1ConCL As TextBox
    Friend WithEvents CorreoConCL As TextBox
    Friend WithEvents ContactoConCL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Tel2ConCL As TextBox
    Friend WithEvents Label7 As Label
End Class
