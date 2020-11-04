Imports MySql.Data.MySqlClient

Public Class IngCliente
    Private Sub BtnAg_Click(sender As Object, e As EventArgs) Handles BtnAg.Click
        Dim cod As String = TxtCod.Text
        Dim Nit As String = TxtNIT.Text
        Dim nombre As String = TxtNom.Text
        Dim direc As String = TxtDir.Text
        Dim tel As String = TxtTel.Text

        Dim consulta As String
        consulta = "Insert into cliente(id_cli,nombre,nit,direccion,telefono) values('" & cod & "','" & nombre & "'," & Nit & ",'" & direc & "','" & tel & "')"
        Dim comando As New MySqlCommand
        comando.Connection = conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conn.Open()
            comando.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Cliente agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub limpiar()
        TxtCod.Clear()
        TxtDir.Clear()
        TxtNIT.Clear()
        TxtNom.Clear()
        TxtTel.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnLimp_Click(sender As Object, e As EventArgs) Handles BtnLimp.Click
        limpiar()
    End Sub
End Class