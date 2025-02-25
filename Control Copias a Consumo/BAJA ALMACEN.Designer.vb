<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAJA_ALMACEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BAJA_ALMACEN))
        btnMinimizar = New PictureBox()
        btnCerrar = New PictureBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        btnEliminar = New Button()
        btnBuscarAlmacen = New Button()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.Size = New Size(871, 27)
        Panel1.TabIndex = 4
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(802, 6)
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
        btnCerrar.Location = New Point(838, 6)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(22, 19)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 2
        btnCerrar.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(240, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 26)
        Label1.TabIndex = 0
        Label1.Text = "Bajas de Almacen."
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Century Gothic", 12F)
        TextBox1.Location = New Point(179, 99)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(383, 20)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(10, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 17)
        Label2.TabIndex = 2
        Label2.Text = "Numero de pieza:"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatAppearance.MouseOverBackColor = Color.Red
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        btnEliminar.Location = New Point(664, 164)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(151, 43)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar Cantidad"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscarAlmacen
        ' 
        btnBuscarAlmacen.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        btnBuscarAlmacen.BackgroundImageLayout = ImageLayout.None
        btnBuscarAlmacen.Cursor = Cursors.Hand
        btnBuscarAlmacen.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnBuscarAlmacen.FlatAppearance.BorderSize = 0
        btnBuscarAlmacen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnBuscarAlmacen.FlatStyle = FlatStyle.Flat
        btnBuscarAlmacen.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnBuscarAlmacen.Image = CType(resources.GetObject("btnBuscarAlmacen.Image"), Image)
        btnBuscarAlmacen.ImageAlign = ContentAlignment.MiddleLeft
        btnBuscarAlmacen.Location = New Point(664, 99)
        btnBuscarAlmacen.Margin = New Padding(3, 2, 3, 2)
        btnBuscarAlmacen.Name = "btnBuscarAlmacen"
        btnBuscarAlmacen.Size = New Size(151, 48)
        btnBuscarAlmacen.TabIndex = 5
        btnBuscarAlmacen.Text = "Buscar"
        btnBuscarAlmacen.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBuscarAlmacen.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(181, 125)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(467, 81)
        DataGridView1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(542, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 17)
        Label3.TabIndex = 8
        Label3.Text = "Cantidad."
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(255), CByte(209), CByte(220))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Century Gothic", 12F)
        TextBox2.Location = New Point(568, 99)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(80, 20)
        TextBox2.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold)
        Button1.Location = New Point(24, 164)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 43)
        Button1.TabIndex = 10
        Button1.Text = "Eliminar Fila"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BAJA_ALMACEN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.fondo_forms
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(871, 236)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(btnBuscarAlmacen)
        Controls.Add(Panel1)
        Controls.Add(btnEliminar)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "BAJA_ALMACEN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Baja Almacén"
        Panel1.ResumeLayout(False)
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnBuscarAlmacen As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
