<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Respaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Respaldo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCarpeta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruta"
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Location = New System.Drawing.Point(43, 52)
        Me.TxtRuta.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(443, 35)
        Me.TxtRuta.TabIndex = 1
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.Location = New System.Drawing.Point(43, 101)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(133, 73)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCarpeta
        '
        Me.BtnCarpeta.Image = CType(resources.GetObject("BtnCarpeta.Image"), System.Drawing.Image)
        Me.BtnCarpeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCarpeta.Location = New System.Drawing.Point(327, 101)
        Me.BtnCarpeta.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnCarpeta.Name = "BtnCarpeta"
        Me.BtnCarpeta.Size = New System.Drawing.Size(159, 73)
        Me.BtnCarpeta.TabIndex = 3
        Me.BtnCarpeta.Text = "Seleccionar Carpeta"
        Me.BtnCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCarpeta.UseVisualStyleBackColor = True
        '
        'Respaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 183)
        Me.Controls.Add(Me.BtnCarpeta)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Respaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Respaldo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRuta As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCarpeta As Button
End Class
