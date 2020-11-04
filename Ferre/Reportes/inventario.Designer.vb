<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventario
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
        Me.RdvPpod = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncProdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncProdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RdvPpod
        '
        Me.RdvPpod.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Prods"
        ReportDataSource1.Value = Me.ProductosBindingSource
        ReportDataSource2.Name = "Totalp"
        ReportDataSource2.Value = Me.EncProdBindingSource
        Me.RdvPpod.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RdvPpod.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RdvPpod.LocalReport.ReportEmbeddedResource = "Ferre.Inventariorep.rdlc"
        Me.RdvPpod.Location = New System.Drawing.Point(0, 0)
        Me.RdvPpod.Name = "RdvPpod"
        Me.RdvPpod.Size = New System.Drawing.Size(800, 450)
        Me.RdvPpod.TabIndex = 0
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        '
        'EncProdBindingSource
        '
        Me.EncProdBindingSource.DataMember = "EncProd"
        '
        'inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RdvPpod)
        Me.Name = "inventario"
        Me.Text = "inventario"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncProdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RdvPpod As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents EncProdBindingSource As BindingSource
End Class
