<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepoAll
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
        Me.PanSup = New System.Windows.Forms.Panel()
        Me.PanScent = New System.Windows.Forms.Panel()
        Me.BtnVentasP = New System.Windows.Forms.Button()
        Me.DtpPeriF = New System.Windows.Forms.DateTimePicker()
        Me.DtpPinI = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PanSder = New System.Windows.Forms.Panel()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.PanSiz = New System.Windows.Forms.Panel()
        Me.BtnVentaD = New System.Windows.Forms.Button()
        Me.DtpVentaD = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanCent = New System.Windows.Forms.Panel()
        Me.RpvReporte = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PanSup.SuspendLayout()
        Me.PanScent.SuspendLayout()
        Me.PanSder.SuspendLayout()
        Me.PanSiz.SuspendLayout()
        Me.PanCent.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanSup
        '
        Me.PanSup.Controls.Add(Me.PanScent)
        Me.PanSup.Controls.Add(Me.PanSder)
        Me.PanSup.Controls.Add(Me.PanSiz)
        Me.PanSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSup.Location = New System.Drawing.Point(0, 0)
        Me.PanSup.Name = "PanSup"
        Me.PanSup.Size = New System.Drawing.Size(878, 105)
        Me.PanSup.TabIndex = 0
        '
        'PanScent
        '
        Me.PanScent.Controls.Add(Me.BtnVentasP)
        Me.PanScent.Controls.Add(Me.DtpPeriF)
        Me.PanScent.Controls.Add(Me.DtpPinI)
        Me.PanScent.Controls.Add(Me.Label4)
        Me.PanScent.Controls.Add(Me.Label3)
        Me.PanScent.Controls.Add(Me.Label2)
        Me.PanScent.Controls.Add(Me.ShapeContainer1)
        Me.PanScent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanScent.Location = New System.Drawing.Point(236, 0)
        Me.PanScent.Name = "PanScent"
        Me.PanScent.Size = New System.Drawing.Size(478, 105)
        Me.PanScent.TabIndex = 2
        '
        'BtnVentasP
        '
        Me.BtnVentasP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnVentasP.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnVentasP.FlatAppearance.BorderSize = 0
        Me.BtnVentasP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentasP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasP.ForeColor = System.Drawing.Color.White
        Me.BtnVentasP.Location = New System.Drawing.Point(358, 21)
        Me.BtnVentasP.Name = "BtnVentasP"
        Me.BtnVentasP.Size = New System.Drawing.Size(101, 69)
        Me.BtnVentasP.TabIndex = 5
        Me.BtnVentasP.Text = "Ver Ventas"
        Me.BtnVentasP.UseVisualStyleBackColor = False
        '
        'DtpPeriF
        '
        Me.DtpPeriF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpPeriF.Location = New System.Drawing.Point(110, 70)
        Me.DtpPeriF.Name = "DtpPeriF"
        Me.DtpPeriF.Size = New System.Drawing.Size(216, 20)
        Me.DtpPeriF.TabIndex = 4
        '
        'DtpPinI
        '
        Me.DtpPinI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpPinI.Location = New System.Drawing.Point(110, 26)
        Me.DtpPinI.Name = "DtpPinI"
        Me.DtpPinI.Size = New System.Drawing.Size(216, 20)
        Me.DtpPinI.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 44)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ventas por periodo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(478, 105)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 6
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 470
        Me.LineShape2.X2 = 470
        Me.LineShape2.Y1 = 2
        Me.LineShape2.Y2 = 107
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 6
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 4
        Me.LineShape1.X2 = 4
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 104
        '
        'PanSder
        '
        Me.PanSder.Controls.Add(Me.BtnInventario)
        Me.PanSder.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanSder.Location = New System.Drawing.Point(714, 0)
        Me.PanSder.Name = "PanSder"
        Me.PanSder.Size = New System.Drawing.Size(164, 105)
        Me.PanSder.TabIndex = 1
        '
        'BtnInventario
        '
        Me.BtnInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnInventario.FlatAppearance.BorderSize = 0
        Me.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.ForeColor = System.Drawing.Color.White
        Me.BtnInventario.Location = New System.Drawing.Point(6, 33)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(146, 44)
        Me.BtnInventario.TabIndex = 0
        Me.BtnInventario.Text = "Ver Inventario"
        Me.BtnInventario.UseVisualStyleBackColor = False
        '
        'PanSiz
        '
        Me.PanSiz.Controls.Add(Me.BtnVentaD)
        Me.PanSiz.Controls.Add(Me.DtpVentaD)
        Me.PanSiz.Controls.Add(Me.Label1)
        Me.PanSiz.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanSiz.Location = New System.Drawing.Point(0, 0)
        Me.PanSiz.Name = "PanSiz"
        Me.PanSiz.Size = New System.Drawing.Size(236, 105)
        Me.PanSiz.TabIndex = 0
        '
        'BtnVentaD
        '
        Me.BtnVentaD.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnVentaD.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnVentaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentaD.ForeColor = System.Drawing.Color.White
        Me.BtnVentaD.Location = New System.Drawing.Point(0, 73)
        Me.BtnVentaD.Name = "BtnVentaD"
        Me.BtnVentaD.Size = New System.Drawing.Size(236, 32)
        Me.BtnVentaD.TabIndex = 2
        Me.BtnVentaD.Text = "Ver Ventas"
        Me.BtnVentaD.UseVisualStyleBackColor = False
        '
        'DtpVentaD
        '
        Me.DtpVentaD.Location = New System.Drawing.Point(12, 29)
        Me.DtpVentaD.Name = "DtpVentaD"
        Me.DtpVentaD.Size = New System.Drawing.Size(200, 20)
        Me.DtpVentaD.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ver ventas diarias"
        '
        'PanCent
        '
        Me.PanCent.Controls.Add(Me.RpvReporte)
        Me.PanCent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCent.Location = New System.Drawing.Point(0, 105)
        Me.PanCent.Name = "PanCent"
        Me.PanCent.Size = New System.Drawing.Size(878, 432)
        Me.PanCent.TabIndex = 1
        '
        'RpvReporte
        '
        Me.RpvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RpvReporte.Location = New System.Drawing.Point(0, 0)
        Me.RpvReporte.Name = "RpvReporte"
        Me.RpvReporte.Size = New System.Drawing.Size(878, 432)
        Me.RpvReporte.TabIndex = 0
        Me.RpvReporte.Visible = False
        '
        'RepoAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(878, 537)
        Me.Controls.Add(Me.PanCent)
        Me.Controls.Add(Me.PanSup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RepoAll"
        Me.Text = "RepoAll"
        Me.PanSup.ResumeLayout(False)
        Me.PanScent.ResumeLayout(False)
        Me.PanScent.PerformLayout()
        Me.PanSder.ResumeLayout(False)
        Me.PanSiz.ResumeLayout(False)
        Me.PanSiz.PerformLayout()
        Me.PanCent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSup As Panel
    Friend WithEvents PanCent As Panel
    Friend WithEvents RpvReporte As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PanScent As Panel
    Friend WithEvents PanSder As Panel
    Friend WithEvents BtnInventario As Button
    Friend WithEvents PanSiz As Panel
    Friend WithEvents BtnVentaD As Button
    Friend WithEvents DtpVentaD As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnVentasP As Button
    Friend WithEvents DtpPeriF As DateTimePicker
    Friend WithEvents DtpPinI As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
