Imports MySql.Data.MySqlClient
Public Class Factura

    Private conect As New Conexion
    Private prod As New producto
    Dim cli As New Cliente

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

    Private Function idventa() As Integer

        Dim datos As New DataTable
        Dim val As Integer
        Dim consulta As String = "select max(id_venta) from venta"
        datos = buscar(consulta)
        If (IsDBNull(datos.Rows(0)(0))) Then
            val = 0
        Else
            val = Int32.Parse(datos.Rows(0)(0).ToString)
        End If
        Return val

    End Function
    Private Function idetalle() As Integer

        Dim datos As New DataTable
        Dim val As Integer
        Dim consulta As String = "select max(id_detalle) from detalle"
        datos = buscar(consulta)
        If (IsDBNull(datos.Rows(0)(0))) Then
            val = 0
        Else
            val = Int32.Parse(datos.Rows(0)(0).ToString)
        End If
        Return val

        End Function


    Public Function generarv(ByVal datos As DataTable, ByVal cliente As String, ByVal cajero As String) As Boolean
        Dim codv As Integer = idventa() + 1
        Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Dim consulta As String
        consulta = "insert into  venta(id_venta,id_cli,id_usu,Fecha_H) " &
                      "values (" & codv & "," & cliente & ",'" & cajero & "','" & fecha & "')"
        'falta agregar cajero
        If (consulta_gen(consulta)) Then

            Return generardet(datos, codv, cajero, cliente, fecha)
        Else
            Return False
        End If

    End Function

    Private Function generardet(ByVal datos As DataTable, ByVal venta As Integer, cajero As String, ByVal idcli As String, ByVal fecha As String) As Decimal

        Dim cant As Integer = datos.Rows.Count
        Dim cont As Integer
        Dim total As Decimal = 0
        For cont = 0 To cant - 1

            Dim id As Integer = idetalle() + 1
            Dim consulta As String
            Dim idprod As String, precio As String, canti As String, subT As String
            idprod = datos.Rows(cont)(0).ToString()
            precio = datos.Rows(cont)(4).ToString()
            canti = datos.Rows(cont)(3).ToString()
            subT = datos.Rows(cont)(5).ToString()
            consulta = "Insert into detalle(id_detalle,id_prod,id_venta, cantidad, precio, total) " &
                      "values (" & id & ",'" & idprod & "'," & venta & "," & canti & "," & precio & "," & subT & ")"

            If (consulta_gen(consulta) = False Or prod.descontarProd(idprod, canti) = False) Then
                Return False
            End If
            total += Decimal.Parse(subT)
        Next
        'total -= Decimal.Parse(descu)
        'Dim atendio As String
        'Dim usur As New DataTable
        'usur = usu.buscusu(cajero)
        'atendio = usur.Rows[0][0].ToString()
        'Dim opera() As String = {"Ingreso", "Venta No " + venta + ",Operado por " + atendio, total.ToString(), DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"), "Activa"};
        ' caj.ingreope(opera);
        'If (MessageBox.Show("¿Desea imprimir comprobante de venta?", "¿Imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
        'PrintTicket(venta, datos, efect, descu)
        'Else

        'End If
        imprimirFact(datos, venta, idcli, fecha)

        Return True
    End Function

    Public Function VentasPeriod(ByVal Fechai As String, ByVal FechaF As String) As DataTable
        Dim consulta As String
        Fechai = Fechai & " 00:00:00"
        FechaF = FechaF & " 23:59:59"
        consulta = "SELECT v.ID_VENTA, u.nombre, c.nombre,v.FECHA_H, SUM(vd.total) FROM venta v " &
                   "inner JOIN usuario u ON u.ID_USU=v.ID_USU " &
                   "INNER JOIN clientes c ON c.ID_CLI= v.ID_CLI " &
                   "INNER JOIN detalle vd ON vd.ID_VENTA=v.ID_VENTA " &
                   "WHERE v.FECHA_H>='" & Fechai & "' AND v.FECHA_H<='" & FechaF & "' " &
                   "GROUP BY v.ID_VENTA"
        Return buscar(consulta)

    End Function
    Public Function VentasDi(ByVal fecha As String)
        Dim Fechai As String, FechaF As String, consulta As String
        Fechai = fecha & " 00:00:00"
        FechaF = fecha & " 23:59:59"
        consulta = "SELECT v.ID_VENTA, Date_format(v.FECHA_H,'%d/%m/%Y'),vd.ID_PROD,CONCAT(p.Nombre, ' ', p.Marca) AS prod ,vd.CANTIDAD,vd.PRECIO,vd.TOTAL " &
                   "FROM venta v " &
                   "inner JOIN usuario u ON u.ID_USU=v.ID_USU " &
                   "INNER JOIN clientes c ON c.ID_CLI= v.ID_CLI " &
                   "INNER JOIN detalle vd ON vd.ID_VENTA=v.ID_VENTA " &
                   "INNER JOIN producto p ON p.ID_PROD= vd.ID_PROD " &
                   "WHERE v.FECHA_H>='" & Fechai & "' AND v.FECHA_H<='" & FechaF & "' " &
                   "GROUP BY vd.ID_DETALLE"
        Return buscar(consulta)
    End Function

    Private Sub imprimirFact(ByVal datos As DataTable, ByVal compro As Integer, ByVal idcli As String, ByVal fecha As String)
        Dim enca As New EncFactura
        enca.factura = compro
        Dim datoscli As New DataTable
        datoscli = cli.datoscli(idcli)
        If datoscli.Rows.Count > 0 Then
            enca.Cliente = datoscli.Rows(0)(0).ToString
        End If
        enca.fecha = fecha
        Dim cant As Integer, cont As Integer
        cant = datos.Rows.Count
        For cont = 0 To cant - 1
            Dim deta As New DetFactura
            deta.codigo = datos.Rows(cont)(0).ToString
            deta.producto = datos.Rows(cont)(1).ToString
            deta.Marca = datos.Rows(cont)(2).ToString
            deta.cantidad = Int32.Parse(datos.Rows(cont)(3).ToString)
            deta.precio = Decimal.Parse(datos.Rows(cont)(4).ToString)
            deta.total = Decimal.Parse(datos.Rows(cont)(5).ToString)
            enca.detalle.Add(deta)
        Next
        Dim factu As New VerFactu
        factu.Detalle = enca.detalle
        factu.encabezado.Add(enca)
        factu.Show()

    End Sub

End Class
