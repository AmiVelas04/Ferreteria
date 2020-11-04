Imports Microsoft.Reporting.WinForms
Public Class VerFactu
    Public encabezado As New List(Of EncFactura)
    Public Detalle As New List(Of DetFactura)
    Private Sub VerFactu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RpvFactura.LocalReport.DataSources.Clear()
        RpvFactura.LocalReport.DataSources.Add(New ReportDataSource("TituloFact", encabezado))
        RpvFactura.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detalle))
        Me.RpvFactura.RefreshReport()
    End Sub
End Class