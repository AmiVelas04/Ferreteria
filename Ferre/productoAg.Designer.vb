<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productoAg
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
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPre = New System.Windows.Forms.TextBox()
        Me.BtnAgreg = New System.Windows.Forms.Button()
        Me.BtnLimp = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPreV = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(207, 24)
        Me.TxtCod.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(100, 31)
        Me.TxtCod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(207, 83)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(247, 31)
        Me.TxtNom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(207, 139)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(154, 31)
        Me.TxtMarca.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio Compra Q."
        '
        'TxtPre
        '
        Me.TxtPre.Location = New System.Drawing.Point(207, 207)
        Me.TxtPre.Name = "TxtPre"
        Me.TxtPre.Size = New System.Drawing.Size(100, 31)
        Me.TxtPre.TabIndex = 7
        '
        'BtnAgreg
        '
        Me.BtnAgreg.Location = New System.Drawing.Point(102, 305)
        Me.BtnAgreg.Name = "BtnAgreg"
        Me.BtnAgreg.Size = New System.Drawing.Size(88, 41)
        Me.BtnAgreg.TabIndex = 8
        Me.BtnAgreg.Text = "Agregar"
        Me.BtnAgreg.UseVisualStyleBackColor = True
        '
        'BtnLimp
        '
        Me.BtnLimp.Location = New System.Drawing.Point(196, 305)
        Me.BtnLimp.Name = "BtnLimp"
        Me.BtnLimp.Size = New System.Drawing.Size(92, 41)
        Me.BtnLimp.TabIndex = 9
        Me.BtnLimp.Text = "Limpiar"
        Me.BtnLimp.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(294, 308)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(98, 38)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Salir"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Precio Venta Q."
        '
        'TxtPreV
        '
        Me.TxtPreV.Location = New System.Drawing.Point(207, 259)
        Me.TxtPreV.Name = "TxtPreV"
        Me.TxtPreV.Size = New System.Drawing.Size(100, 31)
        Me.TxtPreV.TabIndex = 12
        '
        'productoAg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(465, 358)
        Me.Controls.Add(Me.TxtPreV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnLimp)
        Me.Controls.Add(Me.BtnAgreg)
        Me.Controls.Add(Me.TxtPre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "productoAg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPre As TextBox
    Friend WithEvents BtnAgreg As Button
    Friend WithEvents BtnLimp As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPreV As TextBox
End Class
