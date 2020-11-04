Imports MySql.Data.MySqlClient
Public Class producto
    Private conect As New Conexion
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


    Public Function buscarprod(ByVal cod As String) As DataTable
        Dim datos As New DataTable
        Dim consul As String
        consul = "Select nombre,marca,precio_c,precio_v1,precio_v2,cantidad  from producto where id_prod='" & cod & "'"
        Return buscar(consul)
    End Function

    Public Function ingresoprod(ByVal datos() As String) As Boolean
        Dim consulta As String
        consulta = "insert into producto (id_prod, nombre,marca,precio_c, precio_v1, precio_v2, cantidad) " &
             "Values ('" & datos(0) & "', '" & datos(1) & "', '" & datos(2) & "', " & datos(3) & ", " & datos(4) & ", " & datos(5) & ", " & datos(6) & ")"
        Return consulta_gen(consulta)
    End Function

    Public Function updprod(ByVal datos() As String) As Boolean
        Dim consulta As String
        consulta = "Update producto set  nombre='" & datos(1) & "',marca='" & datos(2) & "',precio_c=" & datos(3) & ", precio_v1=" & datos(4) & ", precio_v2=" & datos(5) & ", cantidad=" & datos(6) & " " &
             "where id_prod='" & datos(0) & "'"
        Return consulta_gen(consulta)
    End Function

    Public Function existprod(ByVal id As String) As Boolean
        Dim consulta As String
        consulta = "select count(*) from producto where id_prod='" & id & "'"
        Dim datos As New DataTable
        datos = buscar(consulta)
        If (datos.Rows(0)(0).ToString = "0") Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function descontarProd(ByVal idprod As String, ByVal cant As String) As Boolean
        Dim consultap As String, consultac As String
        Dim cantAnt As Integer
        consultap = "select cantidad from producto where id_prod='" & idprod & "'"
        cantAnt = Int32.Parse(buscar(consultap).Rows(0)(0).ToString)
        cantAnt -= Int32.Parse(cant)
        consultac = "update producto set cantidad=" & cantAnt & " where id_prod='" & idprod & "'"
        Return consulta_gen(consultac)
    End Function

    Public Function buscarprodnom() As DataTable
        Dim consulta As String
        consulta = "Select id_prod,Nombre from producto"
        Return buscar(consulta)

    End Function

    Public Function inventario() As DataTable
        Dim consulta As String
        consulta = "Select id_prod, nombre, marca,cantidad, precio_c as Costo,CONCAT('PrevioVenta1: Q.' ,(precio_v1), '\nPrecioVenta2: Q.',precio_v2) AS PVenta
FROM producto"
        Return buscar(consulta)
    End Function


End Class
