<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.PanIz = New System.Windows.Forms.Panel()
        Me.LblId = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.CboNivel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPass2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPass1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUsu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanInf = New System.Windows.Forms.Panel()
        Me.PanCentr = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanIz.SuspendLayout()
        Me.PanCentr.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanIz
        '
        Me.PanIz.Controls.Add(Me.LblId)
        Me.PanIz.Controls.Add(Me.BtnGuardar)
        Me.PanIz.Controls.Add(Me.CboNivel)
        Me.PanIz.Controls.Add(Me.Label5)
        Me.PanIz.Controls.Add(Me.TxtPass2)
        Me.PanIz.Controls.Add(Me.Label4)
        Me.PanIz.Controls.Add(Me.TxtPass1)
        Me.PanIz.Controls.Add(Me.Label3)
        Me.PanIz.Controls.Add(Me.TxtUsu)
        Me.PanIz.Controls.Add(Me.Label2)
        Me.PanIz.Controls.Add(Me.TxtNombre)
        Me.PanIz.Controls.Add(Me.Label1)
        Me.PanIz.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanIz.Location = New System.Drawing.Point(0, 0)
        Me.PanIz.Margin = New System.Windows.Forms.Padding(4)
        Me.PanIz.Name = "PanIz"
        Me.PanIz.Size = New System.Drawing.Size(216, 504)
        Me.PanIz.TabIndex = 0
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(63, 416)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(75, 16)
        Me.LblId.TabIndex = 11
        Me.LblId.Text = "Codigo id"
        Me.LblId.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGuardar.Location = New System.Drawing.Point(0, 465)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(216, 39)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'CboNivel
        '
        Me.CboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNivel.FormattingEnabled = True
        Me.CboNivel.Items.AddRange(New Object() {"Admininstrador", "Vendedor"})
        Me.CboNivel.Location = New System.Drawing.Point(13, 341)
        Me.CboNivel.Name = "CboNivel"
        Me.CboNivel.Size = New System.Drawing.Size(194, 24)
        Me.CboNivel.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nivel"
        '
        'TxtPass2
        '
        Me.TxtPass2.Location = New System.Drawing.Point(14, 263)
        Me.TxtPass2.Name = "TxtPass2"
        Me.TxtPass2.Size = New System.Drawing.Size(195, 22)
        Me.TxtPass2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Repetir Contraseña"
        '
        'TxtPass1
        '
        Me.TxtPass1.Location = New System.Drawing.Point(13, 193)
        Me.TxtPass1.Name = "TxtPass1"
        Me.TxtPass1.Size = New System.Drawing.Size(195, 22)
        Me.TxtPass1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'TxtUsu
        '
        Me.TxtUsu.Location = New System.Drawing.Point(13, 116)
        Me.TxtUsu.Name = "TxtUsu"
        Me.TxtUsu.Size = New System.Drawing.Size(195, 22)
        Me.TxtUsu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(13, 48)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(195, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de usuario"
        '
        'PanInf
        '
        Me.PanInf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanInf.Location = New System.Drawing.Point(216, 416)
        Me.PanInf.Margin = New System.Windows.Forms.Padding(4)
        Me.PanInf.Name = "PanInf"
        Me.PanInf.Size = New System.Drawing.Size(611, 88)
        Me.PanInf.TabIndex = 1
        '
        'PanCentr
        '
        Me.PanCentr.Controls.Add(Me.DataGridView1)
        Me.PanCentr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCentr.Location = New System.Drawing.Point(216, 0)
        Me.PanCentr.Margin = New System.Windows.Forms.Padding(4)
        Me.PanCentr.Name = "PanCentr"
        Me.PanCentr.Size = New System.Drawing.Size(611, 416)
        Me.PanCentr.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(611, 416)
        Me.DataGridView1.TabIndex = 0
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 504)
        Me.Controls.Add(Me.PanCentr)
        Me.Controls.Add(Me.PanInf)
        Me.Controls.Add(Me.PanIz)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.PanIz.ResumeLayout(False)
        Me.PanIz.PerformLayout()
        Me.PanCentr.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanIz As Panel
    Friend WithEvents PanInf As Panel
    Friend WithEvents PanCentr As Panel
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtUsu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents CboNivel As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPass2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPass1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblId As Label
End Class
