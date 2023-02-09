<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerFactu
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DetFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RpvFactura = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DetFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetFacturaBindingSource
        '
        Me.DetFacturaBindingSource.DataMember = "DetFactura"
        '
        'EncFacturaBindingSource
        '
        Me.EncFacturaBindingSource.DataMember = "EncFactura"
        '
        'RpvFactura
        '
        Me.RpvFactura.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Detalle"
        ReportDataSource1.Value = Me.DetFacturaBindingSource
        ReportDataSource2.Name = "TituloFact"
        ReportDataSource2.Value = Me.EncFacturaBindingSource
        Me.RpvFactura.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RpvFactura.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RpvFactura.LocalReport.ReportEmbeddedResource = "Ferre.Factura.rdlc"
        Me.RpvFactura.Location = New System.Drawing.Point(0, 0)
        Me.RpvFactura.Name = "RpvFactura"
        Me.RpvFactura.Size = New System.Drawing.Size(674, 359)
        Me.RpvFactura.TabIndex = 0
        '
        'VerFactu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 359)
        Me.Controls.Add(Me.RpvFactura)
        Me.Name = "VerFactu"
        Me.Text = "VerFactu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DetFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RpvFactura As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DetFacturaBindingSource As BindingSource
    Friend WithEvents EncFacturaBindingSource As BindingSource
End Class
