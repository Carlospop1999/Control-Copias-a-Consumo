<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAJAS_CLIENTES
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
        Dim Panel1 As Panel
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BAJAS_CLIENTES))
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Label1 = New Label()
        btnBajaCliente = New Button()
        Label8 = New Label()
        Tel2BajaCL = New TextBox()
        CorreoBajaCL = New TextBox()
        Tel1BajaCL = New TextBox()
        DirecBajaCL = New TextBox()
        NomBajaCL = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label9 = New Label()
        BusBajaCL = New TextBox()
        btnEliminarCliente = New Button()
        ContactoBajaCL = New TextBox()
        Label6 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1002, 36)
        Panel1.TabIndex = 36
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(923, 8)
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
        btnCerrar.Location = New Point(965, 8)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 2
        btnCerrar.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(378, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 37)
        Label1.TabIndex = 0
        Label1.Text = "Baja de Cliente"
        ' 
        ' btnBajaCliente
        ' 
        btnBajaCliente.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        btnBajaCliente.BackgroundImageLayout = ImageLayout.None
        btnBajaCliente.Cursor = Cursors.Hand
        btnBajaCliente.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnBajaCliente.FlatAppearance.BorderSize = 0
        btnBajaCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnBajaCliente.FlatStyle = FlatStyle.Flat
        btnBajaCliente.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBajaCliente.Image = CType(resources.GetObject("btnBajaCliente.Image"), Image)
        btnBajaCliente.ImageAlign = ContentAlignment.MiddleLeft
        btnBajaCliente.Location = New Point(803, 140)
        btnBajaCliente.Name = "btnBajaCliente"
        btnBajaCliente.Size = New Size(155, 72)
        btnBajaCliente.TabIndex = 34
        btnBajaCliente.Text = "Buscar"
        btnBajaCliente.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBajaCliente.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(43, 183)
        Label8.Name = "Label8"
        Label8.Size = New Size(322, 50)
        Label8.TabIndex = 33
        Label8.Text = "Datos del cliente:"
        ' 
        ' Tel2BajaCL
        ' 
        Tel2BajaCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Tel2BajaCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Tel2BajaCL.Location = New Point(537, 385)
        Tel2BajaCL.Name = "Tel2BajaCL"
        Tel2BajaCL.ReadOnly = True
        Tel2BajaCL.Size = New Size(238, 32)
        Tel2BajaCL.TabIndex = 32
        ' 
        ' CorreoBajaCL
        ' 
        CorreoBajaCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        CorreoBajaCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CorreoBajaCL.Location = New Point(442, 445)
        CorreoBajaCL.Name = "CorreoBajaCL"
        CorreoBajaCL.ReadOnly = True
        CorreoBajaCL.Size = New Size(333, 32)
        CorreoBajaCL.TabIndex = 30
        ' 
        ' Tel1BajaCL
        ' 
        Tel1BajaCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Tel1BajaCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Tel1BajaCL.Location = New Point(125, 381)
        Tel1BajaCL.Name = "Tel1BajaCL"
        Tel1BajaCL.ReadOnly = True
        Tel1BajaCL.Size = New Size(219, 32)
        Tel1BajaCL.TabIndex = 29
        ' 
        ' DirecBajaCL
        ' 
        DirecBajaCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        DirecBajaCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DirecBajaCL.Location = New Point(125, 319)
        DirecBajaCL.Name = "DirecBajaCL"
        DirecBajaCL.ReadOnly = True
        DirecBajaCL.Size = New Size(650, 32)
        DirecBajaCL.TabIndex = 28
        ' 
        ' NomBajaCL
        ' 
        NomBajaCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        NomBajaCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NomBajaCL.Location = New Point(125, 261)
        NomBajaCL.Name = "NomBajaCL"
        NomBajaCL.ReadOnly = True
        NomBajaCL.Size = New Size(650, 32)
        NomBajaCL.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(367, 385)
        Label7.Name = "Label7"
        Label7.Size = New Size(164, 18)
        Label7.TabIndex = 26
        Label7.Text = "Telefono Secundario:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(369, 445)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 18)
        Label5.TabIndex = 24
        Label5.Text = "Correo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(43, 385)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 18)
        Label4.TabIndex = 23
        Label4.Text = "Telefono:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(43, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 18)
        Label3.TabIndex = 22
        Label3.Text = "Dirección:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(43, 261)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 18)
        Label2.TabIndex = 21
        Label2.Text = "Cliente:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(43, 117)
        Label9.Name = "Label9"
        Label9.Size = New Size(255, 18)
        Label9.TabIndex = 20
        Label9.Text = "Busqueda de cliente por nombre:"
        ' 
        ' BusBajaCL
        ' 
        BusBajaCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        BusBajaCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BusBajaCL.Location = New Point(43, 140)
        BusBajaCL.Name = "BusBajaCL"
        BusBajaCL.Size = New Size(731, 32)
        BusBajaCL.TabIndex = 19
        ' 
        ' btnEliminarCliente
        ' 
        btnEliminarCliente.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnEliminarCliente.BackgroundImageLayout = ImageLayout.None
        btnEliminarCliente.Cursor = Cursors.Hand
        btnEliminarCliente.FlatAppearance.BorderSize = 0
        btnEliminarCliente.FlatAppearance.MouseOverBackColor = Color.Red
        btnEliminarCliente.FlatStyle = FlatStyle.Flat
        btnEliminarCliente.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnEliminarCliente.Location = New Point(803, 243)
        btnEliminarCliente.Name = "btnEliminarCliente"
        btnEliminarCliente.Size = New Size(155, 57)
        btnEliminarCliente.TabIndex = 35
        btnEliminarCliente.Text = "Eliminar"
        btnEliminarCliente.UseVisualStyleBackColor = False
        ' 
        ' ContactoBajaCL
        ' 
        ContactoBajaCL.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        ContactoBajaCL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ContactoBajaCL.Location = New Point(125, 445)
        ContactoBajaCL.Name = "ContactoBajaCL"
        ContactoBajaCL.ReadOnly = True
        ContactoBajaCL.Size = New Size(219, 32)
        ContactoBajaCL.TabIndex = 31
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(43, 445)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 18)
        Label6.TabIndex = 25
        Label6.Text = "Contacto:"
        ' 
        ' BAJAS_CLIENTES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1002, 515)
        Controls.Add(Panel1)
        Controls.Add(btnEliminarCliente)
        Controls.Add(btnBajaCliente)
        Controls.Add(Label8)
        Controls.Add(Tel2BajaCL)
        Controls.Add(ContactoBajaCL)
        Controls.Add(CorreoBajaCL)
        Controls.Add(Tel1BajaCL)
        Controls.Add(DirecBajaCL)
        Controls.Add(NomBajaCL)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label9)
        Controls.Add(BusBajaCL)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "BAJAS_CLIENTES"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bajas Clientes"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBajaCliente As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Tel2BajaCL As TextBox
    Friend WithEvents CorreoBajaCL As TextBox
    Friend WithEvents Tel1BajaCL As TextBox
    Friend WithEvents DirecBajaCL As TextBox
    Friend WithEvents NomBajaCL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BusBajaCL As TextBox
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents ContactoBajaCL As TextBox
    Friend WithEvents Label6 As Label
End Class
