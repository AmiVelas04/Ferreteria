<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboProd = New System.Windows.Forms.ComboBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtExis = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.NupCant = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DgvProd = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboCliente = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NupCant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 498)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(862, 398)
        Me.Panel3.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboProd)
        Me.GroupBox2.Controls.Add(Me.BtnSalir)
        Me.GroupBox2.Controls.Add(Me.TxtExis)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BtnVenta)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnAgregar)
        Me.GroupBox2.Controls.Add(Me.NupCant)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtPre)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtMarca)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtCod)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DgvProd)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(862, 398)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'CboProd
        '
        Me.CboProd.FormattingEnabled = True
        Me.CboProd.Location = New System.Drawing.Point(103, 63)
        Me.CboProd.Name = "CboProd"
        Me.CboProd.Size = New System.Drawing.Size(244, 29)
        Me.CboProd.TabIndex = 19
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(907, 98)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(82, 42)
        Me.BtnSalir.TabIndex = 18
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtExis
        '
        Me.TxtExis.Enabled = False
        Me.TxtExis.Location = New System.Drawing.Point(103, 106)
        Me.TxtExis.Name = "TxtExis"
        Me.TxtExis.Size = New System.Drawing.Size(90, 29)
        Me.TxtExis.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 21)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Existencias"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(639, 58)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(165, 54)
        Me.TxtTotal.TabIndex = 15
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(634, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 30)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Total a pagar Q."
        '
        'BtnVenta
        '
        Me.BtnVenta.Location = New System.Drawing.Point(639, 119)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(165, 82)
        Me.BtnVenta.TabIndex = 13
        Me.BtnVenta.Text = "Realizar Venta"
        Me.BtnVenta.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(223, 159)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(183, 42)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(23, 159)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(170, 41)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'NupCant
        '
        Me.NupCant.Location = New System.Drawing.Point(314, 105)
        Me.NupCant.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me.NupCant.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupCant.Name = "NupCant"
        Me.NupCant.Size = New System.Drawing.Size(51, 29)
        Me.NupCant.TabIndex = 10
        Me.NupCant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(236, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Cantidad"
        '
        'TxtPre
        '
        Me.TxtPre.Location = New System.Drawing.Point(412, 63)
        Me.TxtPre.Name = "TxtPre"
        Me.TxtPre.Size = New System.Drawing.Size(93, 29)
        Me.TxtPre.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(353, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Precio"
        '
        'TxtMarca
        '
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Location = New System.Drawing.Point(374, 23)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(131, 29)
        Me.TxtMarca.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Producto"
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(103, 24)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(205, 29)
        Me.TxtCod.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Codigo"
        '
        'DgvProd
        '
        Me.DgvProd.AllowUserToAddRows = False
        Me.DgvProd.AllowUserToDeleteRows = False
        Me.DgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvProd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.DgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvProd.Location = New System.Drawing.Point(4, 206)
        Me.DgvProd.Name = "DgvProd"
        Me.DgvProd.ReadOnly = True
        Me.DgvProd.RowHeadersWidth = 31
        Me.DgvProd.RowTemplate.Height = 30
        Me.DgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProd.Size = New System.Drawing.Size(854, 187)
        Me.DgvProd.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 100)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboCliente)
        Me.GroupBox1.Controls.Add(Me.TxtN)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCli)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(862, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'TxtN
        '
        Me.TxtN.Location = New System.Drawing.Point(90, 53)
        Me.TxtN.Name = "TxtN"
        Me.TxtN.Size = New System.Drawing.Size(110, 29)
        Me.TxtN.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(18, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 21)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "NIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(557, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha"
        '
        'TxtCli
        '
        Me.TxtCli.Enabled = False
        Me.TxtCli.Location = New System.Drawing.Point(206, 52)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(180, 29)
        Me.TxtCli.TabIndex = 3
        Me.TxtCli.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(18, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente"
        '
        'TxtCC
        '
        Me.TxtCC.Enabled = False
        Me.TxtCC.Location = New System.Drawing.Point(735, 30)
        Me.TxtCC.Name = "TxtCC"
        Me.TxtCC.Size = New System.Drawing.Size(90, 29)
        Me.TxtCC.TabIndex = 1
        Me.TxtCC.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(671, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        Me.Label1.Visible = False
        '
        'CboCliente
        '
        Me.CboCliente.FormattingEnabled = True
        Me.CboCliente.Location = New System.Drawing.Point(90, 18)
        Me.CboCliente.Name = "CboCliente"
        Me.CboCliente.Size = New System.Drawing.Size(296, 29)
        Me.CboCliente.TabIndex = 8
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 498)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NupCant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtExis As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnVenta As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents NupCant As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DgvProd As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtN As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CboProd As ComboBox
    Friend WithEvents CboCliente As ComboBox
End Class
