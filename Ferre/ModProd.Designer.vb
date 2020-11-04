<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModProd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMarc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPreC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPreV = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnUpd = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.NudCant = New System.Windows.Forms.NumericUpDown()
        CType(Me.NudCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(147, 19)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(100, 26)
        Me.TxtCod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Producto"
        '
        'TxtProd
        '
        Me.TxtProd.Location = New System.Drawing.Point(147, 65)
        Me.TxtProd.Name = "TxtProd"
        Me.TxtProd.Size = New System.Drawing.Size(172, 26)
        Me.TxtProd.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca"
        '
        'TxtMarc
        '
        Me.TxtMarc.Location = New System.Drawing.Point(147, 118)
        Me.TxtMarc.Name = "TxtMarc"
        Me.TxtMarc.Size = New System.Drawing.Size(130, 26)
        Me.TxtMarc.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio compra"
        '
        'TxtPreC
        '
        Me.TxtPreC.Location = New System.Drawing.Point(147, 163)
        Me.TxtPreC.Name = "TxtPreC"
        Me.TxtPreC.Size = New System.Drawing.Size(77, 26)
        Me.TxtPreC.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio venta"
        '
        'TxtPreV
        '
        Me.TxtPreV.Location = New System.Drawing.Point(147, 221)
        Me.TxtPreV.Name = "TxtPreV"
        Me.TxtPreV.Size = New System.Drawing.Size(77, 26)
        Me.TxtPreV.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cantidad"
        '
        'BtnUpd
        '
        Me.BtnUpd.Location = New System.Drawing.Point(311, 176)
        Me.BtnUpd.Name = "BtnUpd"
        Me.BtnUpd.Size = New System.Drawing.Size(100, 37)
        Me.BtnUpd.TabIndex = 12
        Me.BtnUpd.Text = "Modificar"
        Me.BtnUpd.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(311, 219)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(100, 37)
        Me.BtnLimpiar.TabIndex = 13
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(311, 262)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 37)
        Me.BtnSalir.TabIndex = 14
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'NudCant
        '
        Me.NudCant.Location = New System.Drawing.Point(147, 265)
        Me.NudCant.Maximum = New Decimal(New Integer() {36000, 0, 0, 0})
        Me.NudCant.Name = "NudCant"
        Me.NudCant.Size = New System.Drawing.Size(63, 26)
        Me.NudCant.TabIndex = 15
        Me.NudCant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ModProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(422, 303)
        Me.Controls.Add(Me.NudCant)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnUpd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPreV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPreC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMarc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "ModProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar producto"
        CType(Me.NudCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtProd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMarc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPreC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPreV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnUpd As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents NudCant As NumericUpDown
End Class
