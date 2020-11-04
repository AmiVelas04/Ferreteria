<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanIz = New System.Windows.Forms.Panel()
        Me.BtnRespaldo = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.PanSup = New System.Windows.Forms.Panel()
        Me.LblUsu = New System.Windows.Forms.Label()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanCent = New System.Windows.Forms.Panel()
        Me.PanIz.SuspendLayout()
        Me.PanSup.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanIz
        '
        Me.PanIz.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanIz.Controls.Add(Me.BtnRespaldo)
        Me.PanIz.Controls.Add(Me.BtnCliente)
        Me.PanIz.Controls.Add(Me.BtnReportes)
        Me.PanIz.Controls.Add(Me.BtnProducto)
        Me.PanIz.Controls.Add(Me.BtnVentas)
        Me.PanIz.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanIz.Location = New System.Drawing.Point(0, 0)
        Me.PanIz.Name = "PanIz"
        Me.PanIz.Size = New System.Drawing.Size(157, 600)
        Me.PanIz.TabIndex = 0
        '
        'BtnRespaldo
        '
        Me.BtnRespaldo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnRespaldo.FlatAppearance.BorderSize = 0
        Me.BtnRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRespaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRespaldo.ForeColor = System.Drawing.Color.White
        Me.BtnRespaldo.Image = CType(resources.GetObject("BtnRespaldo.Image"), System.Drawing.Image)
        Me.BtnRespaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRespaldo.Location = New System.Drawing.Point(0, 553)
        Me.BtnRespaldo.Name = "BtnRespaldo"
        Me.BtnRespaldo.Size = New System.Drawing.Size(157, 47)
        Me.BtnRespaldo.TabIndex = 4
        Me.BtnRespaldo.Text = "Respaldo"
        Me.BtnRespaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRespaldo.UseVisualStyleBackColor = True
        Me.BtnRespaldo.Visible = False
        '
        'BtnCliente
        '
        Me.BtnCliente.FlatAppearance.BorderSize = 0
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.ForeColor = System.Drawing.Color.White
        Me.BtnCliente.Image = CType(resources.GetObject("BtnCliente.Image"), System.Drawing.Image)
        Me.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCliente.Location = New System.Drawing.Point(0, 225)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(154, 32)
        Me.BtnCliente.TabIndex = 3
        Me.BtnCliente.Text = "Usuario"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCliente.UseVisualStyleBackColor = True
        Me.BtnCliente.Visible = False
        '
        'BtnReportes
        '
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.ForeColor = System.Drawing.Color.White
        Me.BtnReportes.Image = CType(resources.GetObject("BtnReportes.Image"), System.Drawing.Image)
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(0, 276)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(157, 32)
        Me.BtnReportes.TabIndex = 2
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReportes.UseVisualStyleBackColor = True
        Me.BtnReportes.Visible = False
        '
        'BtnProducto
        '
        Me.BtnProducto.FlatAppearance.BorderSize = 0
        Me.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducto.ForeColor = System.Drawing.Color.White
        Me.BtnProducto.Image = CType(resources.GetObject("BtnProducto.Image"), System.Drawing.Image)
        Me.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProducto.Location = New System.Drawing.Point(12, 168)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(142, 32)
        Me.BtnProducto.TabIndex = 1
        Me.BtnProducto.Text = "Producto"
        Me.BtnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProducto.UseVisualStyleBackColor = True
        Me.BtnProducto.Visible = False
        '
        'BtnVentas
        '
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.Color.White
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(0, 110)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(154, 32)
        Me.BtnVentas.TabIndex = 0
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'PanSup
        '
        Me.PanSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.PanSup.Controls.Add(Me.LblUsu)
        Me.PanSup.Controls.Add(Me.BtnMin)
        Me.PanSup.Controls.Add(Me.BtnCerrar)
        Me.PanSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSup.Location = New System.Drawing.Point(157, 0)
        Me.PanSup.Name = "PanSup"
        Me.PanSup.Size = New System.Drawing.Size(843, 57)
        Me.PanSup.TabIndex = 1
        '
        'LblUsu
        '
        Me.LblUsu.AutoSize = True
        Me.LblUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsu.ForeColor = System.Drawing.Color.White
        Me.LblUsu.Location = New System.Drawing.Point(24, 20)
        Me.LblUsu.Name = "LblUsu"
        Me.LblUsu.Size = New System.Drawing.Size(71, 20)
        Me.LblUsu.TabIndex = 2
        Me.LblUsu.Text = "Usuario"
        '
        'BtnMin
        '
        Me.BtnMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.ForeColor = System.Drawing.Color.White
        Me.BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), System.Drawing.Image)
        Me.BtnMin.Location = New System.Drawing.Point(711, 0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(66, 57)
        Me.BtnMin.TabIndex = 1
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(777, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(66, 57)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PanCent
        '
        Me.PanCent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCent.Location = New System.Drawing.Point(157, 57)
        Me.PanCent.Name = "PanCent"
        Me.PanCent.Size = New System.Drawing.Size(843, 543)
        Me.PanCent.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.PanCent)
        Me.Controls.Add(Me.PanSup)
        Me.Controls.Add(Me.PanIz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanIz.ResumeLayout(False)
        Me.PanSup.ResumeLayout(False)
        Me.PanSup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanIz As Panel
    Friend WithEvents BtnProducto As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents PanSup As Panel
    Friend WithEvents PanCent As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents LblUsu As Label
    Friend WithEvents BtnCliente As Button
    Friend WithEvents BtnRespaldo As Button
End Class
