Imports MySql.Data.MySqlClient
Public Class Usuario
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

    Private Function idusu() As Integer

        Dim datos As New DataTable
        Dim val As Integer
        Dim consulta As String = "select max(id_usu) from usuario"
        datos = buscar(consulta)
        If (IsDBNull(datos.Rows(0)(0))) Then
            val = 0
        Else
            val = Int32.Parse(datos.Rows(0)(0).ToString)
        End If
        Return val

    End Function

    Public Function ingreusu(ByVal datos As String()) As Boolean
        Dim consulta As String
        Dim cod As Integer = idusu()
        consulta = "insert into usuario(id_usu,Nombre,Usuario,Pass,id_tipo) values(" &
                   cod.ToString & ",'" & datos(1) & "','" & datos(2) & "','" & datos(3) & "'," & datos(4) & ")"
        Return consulta_gen(consulta)
    End Function

    Public Function updusu(ByVal datos As String) As Boolean
        Dim consulta As String
        consulta = "Update set Nombre='" & datos(1) & "', Usuario='" & datos(2) & "', Pass='" & datos(3) & "', " &
                   "id_tipo=" & datos(4) & " where = " & datos(0)
        Return consulta_gen(consulta)
    End Function
End Class
