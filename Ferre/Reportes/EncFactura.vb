Public Class EncFactura
    Public Property factura As Integer
    Public Property Cliente As String
    Public Property fecha As String
    Public Property total As Decimal
    Public detalle As New List(Of DetFactura)
End Class
