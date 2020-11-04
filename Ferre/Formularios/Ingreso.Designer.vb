<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso
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
        Me.PanDer = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtPreV2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPreV1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtProd = New System.Windows.Forms.TextBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.NudCant = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanSup = New System.Windows.Forms.Panel()
        Me.PanCent = New System.Windows.Forms.Panel()
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        Me.PanDer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NudCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanCent.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanDer
        '
        Me.PanDer.Controls.Add(Me.GroupBox2)
        Me.PanDer.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanDer.Location = New System.Drawing.Point(534, 0)
        Me.PanDer.Name = "PanDer"
        Me.PanDer.Size = New System.Drawing.Size(328, 534)
        Me.PanDer.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtPreV2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtPreV1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtMarca)
        Me.GroupBox2.Controls.Add(Me.TxtProd)
        Me.GroupBox2.Controls.Add(Me.TxtCod)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.BtnAgregar)
        Me.GroupBox2.Controls.Add(Me.NudCant)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 534)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'TxtPreV2
        '
        Me.TxtPreV2.Location = New System.Drawing.Point(103, 336)
        Me.TxtPreV2.Name = "TxtPreV2"
        Me.TxtPreV2.Size = New System.Drawing.Size(91, 29)
        Me.TxtPreV2.TabIndex = 21
        Me.TxtPreV2.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 43)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Precio Venta 2"
        '
        'TxtPreV1
        '
        Me.TxtPreV1.Location = New System.Drawing.Point(103, 278)
        Me.TxtPreV1.Name = "TxtPreV1"
        Me.TxtPreV1.Size = New System.Drawing.Size(91, 29)
        Me.TxtPreV1.TabIndex = 19
        Me.TxtPreV1.Text = "0"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 45)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Precio Venta1"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(103, 215)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(91, 29)
        Me.TxtPrecio.TabIndex = 17
        Me.TxtPrecio.Text = "0"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 47)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Precio Costo"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(103, 112)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(144, 29)
        Me.TxtMarca.TabIndex = 12
        '
        'TxtProd
        '
        Me.TxtProd.Location = New System.Drawing.Point(103, 73)
        Me.TxtProd.Name = "TxtProd"
        Me.TxtProd.Size = New System.Drawing.Size(191, 29)
        Me.TxtProd.TabIndex = 11
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(103, 38)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(191, 29)
        Me.TxtCod.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Codigo"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnAgregar.Location = New System.Drawing.Point(3, 484)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(322, 47)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'NudCant
        '
        Me.NudCant.Location = New System.Drawing.Point(103, 156)
        Me.NudCant.Maximum = New Decimal(New Integer() {36000, 0, 0, 0})
        Me.NudCant.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NudCant.Name = "NudCant"
        Me.NudCant.Size = New System.Drawing.Size(53, 29)
        Me.NudCant.TabIndex = 6
        Me.NudCant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Producto"
        '
        'PanSup
        '
        Me.PanSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSup.Location = New System.Drawing.Point(0, 0)
        Me.PanSup.Name = "PanSup"
        Me.PanSup.Size = New System.Drawing.Size(534, 91)
        Me.PanSup.TabIndex = 1
        '
        'PanCent
        '
        Me.PanCent.Controls.Add(Me.DgvDatos)
        Me.PanCent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCent.Location = New System.Drawing.Point(0, 91)
        Me.PanCent.Name = "PanCent"
        Me.PanCent.Size = New System.Drawing.Size(534, 443)
        Me.PanCent.TabIndex = 2
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDatos.Location = New System.Drawing.Point(0, 0)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(534, 443)
        Me.DgvDatos.TabIndex = 1
        '
        'Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 534)
        Me.Controls.Add(Me.PanCent)
        Me.Controls.Add(Me.PanSup)
        Me.Controls.Add(Me.PanDer)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Ingreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso nueva compra"
        Me.PanDer.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NudCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanCent.ResumeLayout(False)
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanDer As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtPreV2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPreV1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents TxtProd As TextBox
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents NudCant As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanSup As Panel
    Friend WithEvents PanCent As Panel
    Friend WithEvents DgvDatos As DataGridView
End Class
