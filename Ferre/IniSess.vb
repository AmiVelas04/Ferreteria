Imports MySql.Data.MySqlClient

Module IniSess
    Public factura As Integer

    Friend Function login(ByVal u As String, ByVal p As String) As Boolean
        Dim consulta As String
        consulta = "Select nombre,usu,contra from usuario where usu='" & u & "' and contra='" & p & "'"
        Dim adap As New MySqlDataAdapter(consulta, Conex.conn)
        Dim datos As New DataTable
        adap.Fill(datos)
        Dim total As Integer = datos.Rows.Count
        If total <= 0 Then
            Return False
        Else
            Return True
        End If

    End Function
End Module
