<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAJA_USUARIOS
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BAJA_USUARIOS))
        DataGridView1 = New DataGridView()
        btnBuscar = New Button()
        btnEliminar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(27, 141)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(562, 335)
        DataGridView1.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        btnBuscar.BackgroundImageLayout = ImageLayout.None
        btnBuscar.Cursor = Cursors.Hand
        btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.ImageAlign = ContentAlignment.MiddleLeft
        btnBuscar.Location = New Point(614, 219)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(174, 72)
        btnBuscar.TabIndex = 19
        btnBuscar.Text = "Buscar"
        btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnEliminar.BackgroundImageLayout = ImageLayout.Zoom
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatAppearance.MouseOverBackColor = Color.Silver
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEliminar.Image = My.Resources.Resources.eliminar_usuario
        btnEliminar.ImageAlign = ContentAlignment.MiddleLeft
        btnEliminar.Location = New Point(614, 325)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(174, 73)
        btnEliminar.TabIndex = 20
        btnEliminar.Text = "Eliminar Usuario"
        btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(350, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(279, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(311, 37)
        Label2.TabIndex = 22
        Label2.Text = "BAJAS DE USUARIOS."
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(758, 3)
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
        btnCerrar.Location = New Point(800, 3)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(25, 25)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 8
        btnCerrar.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(837, 36)
        Panel1.TabIndex = 43
        ' 
        ' BAJA_USUARIOS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(837, 519)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnEliminar)
        Controls.Add(btnBuscar)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "BAJA_USUARIOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Baja Usuarios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
