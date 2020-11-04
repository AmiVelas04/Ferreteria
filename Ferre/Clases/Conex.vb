Imports MySql.Data.MySqlClient

Module Conex

    Dim servidor As String = "localhost"
    Dim bd As String = "ferreteria"
    Dim user As String = "admini"
    Dim pass As String = "P&C2018"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Friend conn As New MySqlConnection(cadenaconn)


End Module
