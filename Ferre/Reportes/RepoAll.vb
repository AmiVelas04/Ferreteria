Imports Microsoft.Reporting.WinForms
Public Class RepoAll
    Dim prod As New producto
    Dim vent As New Factura
    Dim detalleInv As New List(Of Productos)
    Dim encabezadoInv As New List(Of EncProd)
    Dim DetallePeri As New List(Of DetVentasPeri)
    Dim EncabezadoPeri As New List(Of EncVentasPeri)
    Dim DetalleDia As New List(Of VentaDet)
    Dim EncabezadoDia As New List(Of VentaEnc)

    Private Sub RepoAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RpvReporte.RefreshReport()
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        RpvReporte.LocalReport.DataSources.Clear()
        RpvReporte.Visible = True
        Dim titulo As New EncProd
        Dim datos As New DataTable
        Dim totaltodo As Decimal = 0
        datos = prod.inventario
        Dim cant As Integer, cont As Integer
        cant = datos.Rows.Count


        For cont = 0 To cant - 1
            Dim detprod As New Productos
            detprod.codigo = datos.Rows(cont)(0).ToString
            detprod.Nombre = datos.Rows(cont)(1).ToString
            detprod.marca = datos.Rows(cont)(2).ToString
            detprod.cantidad = datos.Rows(cont)(3).ToString
            detprod.precio = datos.Rows(cont)(4).ToString
            detprod.preciov = datos.Rows(cont)(5).ToString
            totaltodo += Decimal.Parse(datos.Rows(cont)(3).ToString) * Decimal.Parse(datos.Rows(cont)(4).ToString)

            titulo.detalle.Add(detprod)
        Next
        titulo.Totalp = 0
        titulo.Totalp = totaltodo
        encabezadoInv.Add(titulo)
        detalleInv = titulo.detalle
        RpvReporte.LocalReport.ReportPath = Application.StartupPath & "\..\..\Reportes\Inventariorep.rdlc"
        RpvReporte.LocalReport.DataSources.Add(New ReportDataSource("Prods", detalleInv))
        RpvReporte.LocalReport.DataSources.Add(New ReportDataSource("Totalp", encabezadoInv))
        RpvReporte.RefreshReport()
    End Sub

    Private Sub BtnVentasP_Click(sender As Object, e As EventArgs) Handles BtnVentasP.Click
        RpvReporte.Visible = True
        Dim titulo As New EncVentasPeri
        Dim Fechai As String, Fechaf As String
        Dim datos As New DataTable
        Fechai = DtpPinI.Value.ToString("yyyy/MM/dd")
        Fechaf = DtpPeriF.Value.ToString("yyyy/MM/dd")
        datos = vent.VentasPeriod(Fechai, Fechaf)
        titulo.titulo = "Reporte de ventas por periodo"
        titulo.Fechaf = Fechaf
        titulo.Fechai = Fechai
        Dim cant As Integer, cont As Integer
        cant = datos.Rows.Count
        For cont = 0 To cant - 1
            Dim detprod As New DetVentasPeri
            detprod.venta = Integer.Parse(datos.Rows(cont)(0).ToString)
            detprod.atendio = datos.Rows(cont)(1).ToString
            detprod.cliente = datos.Rows(cont)(2).ToString
            detprod.fecha = datos.Rows(cont)(3).ToString
            detprod.total = Decimal.Parse(datos.Rows(cont)(4).ToString)
            titulo.detalle.Add(detprod)
        Next
        EncabezadoPeri.Add(titulo)
        DetallePeri = titulo.detalle
        RpvReporte.LocalReport.DataSources.Clear()
        RpvReporte.LocalReport.ReportPath = Application.StartupPath & "\..\..\Reportes\VentasPeri.rdlc"
        RpvReporte.LocalReport.DataSources.Add(New ReportDataSource("Detalle", DetallePeri))
        RpvReporte.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", EncabezadoPeri))
        RpvReporte.RefreshReport()
    End Sub

    Private Sub BtnVentaD_Click(sender As Object, e As EventArgs) Handles BtnVentaD.Click
        RpvReporte.Visible = True
        Dim titulo As New VentaEnc
        Dim Fecha As String
        Dim datos As New DataTable
        Fecha = DtpVentaD.Value.ToString("yyyy/MM/dd")
        datos = vent.VentasDi(Fecha)
        Dim cant As Integer, cont As Integer
        cant = datos.Rows.Count
        titulo.fecha = Fecha
        For cont = 0 To cant - 1
            Dim detprod As New VentaDet
            detprod.venta = datos.Rows(cont)(0).ToString
            detprod.fecha = datos.Rows(cont)(1).ToString
            detprod.codigo = datos.Rows(cont)(2).ToString
            detprod.producto = datos.Rows(cont)(3).ToString
            detprod.cantidad = datos.Rows(cont)(4).ToString
            detprod.precio = datos.Rows(cont)(5).ToString
            detprod.total = datos.Rows(cont)(6).ToString
            titulo.detalle.Add(detprod)
        Next
        EncabezadoDia.Add(titulo)
        DetalleDia = titulo.detalle
        RpvReporte.LocalReport.DataSources.Clear()
        RpvReporte.LocalReport.ReportPath = Application.StartupPath & "\..\..\Reportes\VentasD.rdlc"
        RpvReporte.LocalReport.DataSources.Add(New ReportDataSource("Detalle", DetalleDia))
        RpvReporte.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", EncabezadoDia))
        RpvReporte.RefreshReport()
    End Sub
End Class