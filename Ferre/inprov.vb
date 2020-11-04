Imports MySql.Data.MySqlClient

Public Class inprov
    Private Sub BtnAg_Click(sender As Object, e As EventArgs) Handles BtnAg.Click
        Dim cod As Integer = codprov()
        Dim nom As String = TxtNom.Text
        Dim dir As String = TxtDir.Text
        Dim Tel As String = TxtTel.Text
        Dim comando As New MySqlCommand
        Dim consulta As String
        consulta = "Insert into proveedores (id_prov,nombre,direccion,telefono) values('" & cod & "','" & nom & "','" & dir & "','" & Tel & "')"
        comando.Connection = conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conn.Open()
            comando.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Proveedor agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()

        Catch ex As Exception
            conn.Close()

            MessageBox.Show(ex.ToString)
            MessageBox.Show(consulta)
        End Try
    End Sub

    Private Sub BtnLimp_Click(sender As Object, e As EventArgs) Handles BtnLimp.Click
        limpiar()


    End Sub
    Private Sub limpiar()
        TxtDir.Clear()
        TxtNom.Clear()
        TxtTel.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Function codprov() As Integer
        Dim codigo As Integer
        Dim datos As New DataSet
        Dim consulta As String
        Dim codant As Integer
        consulta = "Select max(id_prov) from proveedores"
        Dim adap As New MySqlDataAdapter(consulta, conn)
        adap.Fill(datos)
        codant = datos.Tables(0).Rows(0)(0).ToString
        codant += 1
        codigo = codant
        Return codigo

    End Function
End Class