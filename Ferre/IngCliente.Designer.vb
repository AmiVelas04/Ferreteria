<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngCliente
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
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNIT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.BtnAg = New System.Windows.Forms.Button()
        Me.BtnLimp = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(149, 34)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(100, 26)
        Me.TxtCod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(149, 82)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(191, 26)
        Me.TxtNom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NIT"
        '
        'TxtNIT
        '
        Me.TxtNIT.Location = New System.Drawing.Point(149, 134)
        Me.TxtNIT.Name = "TxtNIT"
        Me.TxtNIT.Size = New System.Drawing.Size(100, 26)
        Me.TxtNIT.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Direccion"
        '
        'TxtDir
        '
        Me.TxtDir.Location = New System.Drawing.Point(149, 185)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(191, 26)
        Me.TxtDir.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefono"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(149, 244)
        Me.TxtTel.MaxLength = 8
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(115, 26)
        Me.TxtTel.TabIndex = 9
        '
        'BtnAg
        '
        Me.BtnAg.Location = New System.Drawing.Point(38, 340)
        Me.BtnAg.Name = "BtnAg"
        Me.BtnAg.Size = New System.Drawing.Size(89, 40)
        Me.BtnAg.TabIndex = 10
        Me.BtnAg.Text = "Agregar"
        Me.BtnAg.UseVisualStyleBackColor = True
        '
        'BtnLimp
        '
        Me.BtnLimp.Location = New System.Drawing.Point(133, 340)
        Me.BtnLimp.Name = "BtnLimp"
        Me.BtnLimp.Size = New System.Drawing.Size(89, 40)
        Me.BtnLimp.TabIndex = 11
        Me.BtnLimp.Text = "Limpiar"
        Me.BtnLimp.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(228, 340)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(89, 40)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'IngCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(360, 402)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimp)
        Me.Controls.Add(Me.BtnAg)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNIT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "IngCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNIT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDir As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents BtnAg As Button
    Friend WithEvents BtnLimp As Button
    Friend WithEvents BtnSalir As Button
End Class
