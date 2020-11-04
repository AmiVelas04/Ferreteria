Imports MySql.Data.MySqlClient
Public Class Loguearse
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

    Public Function logueo(ByVal nombre As String, ByVal pass As String) As DataTable
        Dim consulta As String
        consulta = "Select id_usu, Nombre,pass,Usuario,id_tipo from usuario where usuario= '" & nombre &
            "' and pass='" & pass & "'"
        Return buscar(consulta)

    End Function




End Class
