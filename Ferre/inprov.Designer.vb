<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inprov
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
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.BtnAg = New System.Windows.Forms.Button()
        Me.BtnLimp = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(110, 12)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(174, 27)
        Me.TxtNom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Direccion"
        '
        'TxtDir
        '
        Me.TxtDir.Location = New System.Drawing.Point(110, 54)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(174, 27)
        Me.TxtDir.TabIndex = 3
        '
        'BtnAg
        '
        Me.BtnAg.Location = New System.Drawing.Point(354, 12)
        Me.BtnAg.Name = "BtnAg"
        Me.BtnAg.Size = New System.Drawing.Size(78, 27)
        Me.BtnAg.TabIndex = 4
        Me.BtnAg.Text = "Agregar"
        Me.BtnAg.UseVisualStyleBackColor = True
        '
        'BtnLimp
        '
        Me.BtnLimp.Location = New System.Drawing.Point(354, 48)
        Me.BtnLimp.Name = "BtnLimp"
        Me.BtnLimp.Size = New System.Drawing.Size(78, 33)
        Me.BtnLimp.TabIndex = 5
        Me.BtnLimp.Text = "Limpiar"
        Me.BtnLimp.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(354, 89)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(78, 30)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Teléfono"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(110, 97)
        Me.TxtTel.MaxLength = 8
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(131, 27)
        Me.TxtTel.TabIndex = 8
        '
        'inprov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(473, 154)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimp)
        Me.Controls.Add(Me.BtnAg)
        Me.Controls.Add(Me.TxtDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Museo Sans For Dell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "inprov"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inprov"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDir As TextBox
    Friend WithEvents BtnAg As Button
    Friend WithEvents BtnLimp As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTel As TextBox
End Class
