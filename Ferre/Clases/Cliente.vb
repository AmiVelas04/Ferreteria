Imports MySql.Data.MySqlClient

Public Class Cliente
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

    Private Function idcliente() As Integer

        Dim datos As New DataTable
        Dim val As Integer
        Dim consulta As String = "select max(id_cli) from clientes"
        datos = buscar(consulta)
        If (IsDBNull(datos.Rows(0)(0))) Then
            val = 0
        Else
            val = Int32.Parse(datos.Rows(0)(0).ToString)
        End If
        Return val

    End Function
    Public Function listacli()
        Dim consulta As String

        consulta = "SELECT id_cli, nombre, nit FROM clientes"
        Return buscar(consulta)

    End Function

    Public Function ingresarcliven(ByVal datos() As String) As Integer
        Dim consulta As String
        Dim codigo As Integer
        codigo = idcliente() + 1
        consulta = "insert into clientes (id_cli,nombre, direccion,nit,dpi,telefono) " &
                   "values (" & codigo & ",'" & datos(0) & "','" & datos(1) & "','" & datos(2) & "','" & datos(3) & "','" & datos(4) & "')"
        If (consulta_gen(consulta)) Then
            Return codigo
        Else
            Return 0
        End If
    End Function

    Public Function ingresarcli(ByVal datos() As String) As Boolean
        Dim consulta As String
        Dim codigo As Integer
        codigo = idcliente() + 1
        consulta = "insert into clientes(id_cli,nombre, nit, direccion,dpi,telefono) " &
                   "values (" & codigo & ",'" & datos(0) & "','" & datos(1) & "','" & datos(2) & "','" & datos(3) & "','" & datos(4) & "')"
        Return consulta_gen(consulta)
    End Function

    Public Function editarcli(ByVal datos() As String) As Boolean
        Dim consulta As String
        consulta = "update clientes set Nombre='" & datos(1) & "', Direccion='" & datos(2) & "', Nit='" & datos(3) & "', Dpi='" & datos(4) & "', telefono='" & datos(5) & "' where id_cli=" & datos(0)
        Return consulta_gen(consulta)
    End Function

    Public Function buscacli(ByVal nom As String) As DataTable
        Dim consulta As String
        consulta = "select id_cli as Codigo, Nombre, Direccion,NIT,DPI,Telefono from clientes where nombre like '%" & nom & "%'"
        Return buscar(consulta)

    End Function

    Public Function datoscli(ByVal cod As String) As DataTable
        Dim consulta As String
        consulta = "Select Nombre,Direccion,Nit from clientes where id_cli=" & cod
        Return buscar(consulta)
    End Function

End Class
