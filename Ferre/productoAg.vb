Imports MySql.Data.MySqlClient

Public Class productoAg
    Private Sub BtnAgreg_Click(sender As Object, e As EventArgs) Handles BtnAgreg.Click
        Dim boton As DialogResult
        boton = MessageBox.Show("¿Desea agregar este producto?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If boton = DialogResult.Yes Then
            agregar()
        Else
            limpiar()

        End If

    End Sub
    Private Sub limpiar()
        TxtCod.Clear()
        TxtMarca.Clear()
        TxtNom.Clear()
        TxtPre.Clear()
        TxtPreV.Clear()


    End Sub

    Private Sub BtnLimp_Click(sender As Object, e As EventArgs) Handles BtnLimp.Click
        limpiar()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        Ingreso.Focus()

    End Sub
    Private Sub agregar()
        Dim consulta As String
        Dim comando As New MySqlCommand
        Dim codigo As String = TxtCod.Text
        Dim nombre As String = TxtNom.Text
        Dim marca As String = TxtMarca.Text
        Dim precio As Decimal = Convert.ToDecimal(TxtPre.Text)
        Dim prev As Decimal = Convert.ToDecimal(TxtPreV.Text)
        consulta = "insert into producto(id_prod,nombre,precio,preciov,cantidad,marca) values('" & codigo & "','" & nombre & "'," & precio & "," & prev & ",0,'" & marca & "')"
        comando.Connection = conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text

        Try
            conn.Open()
            comando.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Producto agregado!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub productoAg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class