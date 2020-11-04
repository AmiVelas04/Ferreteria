Imports MySql.Data.MySqlClient


Public Class ModProd
    Private Sub TxtCod_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCod.KeyDown
        If e.KeyValue = Keys.Return And TxtCod.Text <> "" Then
            Busc()
        Else

        End If
    End Sub
    Private Sub Busc()
        Dim cadena As String
        Dim datos As New DataSet
        cadena = "Select nombre,marca,precio,preciov,cantidad from producto where id_prod='" & TxtCod.Text & "'"
        Dim adap As New MySqlDataAdapter(cadena, conn)
        adap.Fill(datos)
        If datos.Tables(0).Rows.Count <= 0 Then

            MessageBox.Show("Codigo de producto no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            TxtProd.Text = datos.Tables(0).Rows(0)(0).ToString
            TxtMarc.Text = datos.Tables(0).Rows(0)(1).ToString
            TxtPreC.Text = datos.Tables(0).Rows(0)(2).ToString
            TxtPreV.Text = datos.Tables(0).Rows(0)(3).ToString
            NudCant.Value = Convert.ToInt32(datos.Tables(0).Rows(0)(4).ToString)

        End If
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()

    End Sub
    Private Sub limpiar()
        TxtCod.Clear()
        TxtMarc.Clear()
        TxtPreC.Clear()
        TxtPreV.Clear()
        TxtProd.Clear()


    End Sub

    Private Sub BtnUpd_Click(sender As Object, e As EventArgs) Handles BtnUpd.Click
        modifi()
    End Sub
    Private Sub modifi()
        Dim prod As String
        Dim marca As String
        Dim precioc As Decimal
        Dim preciov As Decimal
        Dim cant As Integer
        Dim cod As String = TxtCod.Text

        prod = TxtProd.Text
        marca = TxtMarc.Text
        precioc = TxtPreC.Text
        preciov = TxtPreV.Text
        cant = NudCant.Value

        Dim consulta As String
        Dim com As New MySqlCommand
        consulta = "Update producto set nombre='" & prod & "', marca='" & marca & "', precio=" & precioc & ", preciov=" & preciov & ", cantidad=" & cant & " where id_prod='" & cod & "'"
        com.Connection = conn
        com.CommandText = consulta
        com.CommandType = CommandType.Text
        Try
            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Producto modificado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            limpiar()


        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
        Ingreso.Focus()

    End Sub

    Private Sub TxtCod_TextChanged(sender As Object, e As EventArgs) Handles TxtCod.TextChanged

    End Sub
End Class