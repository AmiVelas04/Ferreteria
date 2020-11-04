Imports MySql.Data.MySqlClient
Public Class Reporte
    Dim prod As New producto
    Dim conect As New Conexion
    Private Function buscar(ByVal consulta As String) As DataTable
        Dim datos As New DataTable
        Try
            Dim adap As New MySqlDataAdapter(consulta, conect.conn)
            adap.Fill(datos)

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            MessageBox.Show(consulta)
        End Try
        Return datos

    End Function
    Private Function consulta_gen(ByVal consulta As String) As Boolean


        Dim com1 As New MySqlCommand
        com1.Connection = conect.conn
        com1.CommandText = consulta
        com1.CommandType = CommandType.Text
        Try

            conect.conn.Open()
            com1.ExecuteNonQuery()
            conect.conn.Close()
        Catch ex As Exception
            conect.conn.Close()
            MessageBox.Show(ex.ToString())
            MessageBox.Show(consulta)
            Return False
        End Try
        Return True
    End Function

    Public Sub imprimirfact(ByVal datos As DataTable, ByVal idv As String)
        Dim cant As Integer, cont As Integer
        Dim enca As New EncFactura
        cant = datos.Rows.Count

        For cont = 0 To cant - 1
            Dim detalle As New DetFactura()
            detalle.codigo = datos.Rows(cont)(0).ToString
            detalle.producto = datos.Rows(cont)(1).ToString
            detalle.Marca = datos.Rows(cont)(2).ToString
            detalle.cantidad = datos.Rows(cont)(3).ToString
            detalle.precio = datos.Rows(cont)(4).ToString
            detalle.total = datos.Rows(cont)(5).ToString
            enca.detalle.Add(detalle)

        Next
        'Dim frm As New Factura
        'frm.encabezado.add(enca)
        'frm.Detalle = enca.detalle
        'frm.show



    End Sub

End Class
