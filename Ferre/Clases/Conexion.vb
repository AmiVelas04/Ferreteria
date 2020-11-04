Imports MySql.Data.MySqlClient

Public Class Conexion

    Dim servidor As String = "localhost"
    Dim bd As String = "bdferreteria"
    Dim user As String = "ferreteria"
    Dim pass As String = "Sis_ferre_2020"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Friend conn As New MySqlConnection(cadenaconn)

    Public Function probar_conn() As String
        Dim mensaje As String
        Try
            conn.Open()
            conn.Close()
            mensaje = "Conexion Exitosa"
            Return mensaje
        Catch ex As Exception
            conn.Close()
            mensaje = "Error: " & ex.ToString & Chr(13) & cadenaconn
            Return mensaje
        End Try
    End Function
End Class
