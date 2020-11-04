Imports MySql.Data.MySqlClient

Public Class Buscprod



    Private Sub BtnSelec_Click(sender As Object, e As EventArgs) Handles BtnSelec.Click
        Dim cod As String
        Dim nom As String
        Dim mar As String
        Dim cant As Integer
        Dim precio As Decimal
        If DGV1.RowCount = 0 Then
        Else
            cod = DGV1.CurrentRow.Cells(0).Value
            nom = DGV1.CurrentRow.Cells(1).Value
            mar = DGV1.CurrentRow.Cells(2).Value
            cant = DGV1.CurrentRow.Cells(3).Value
            precio = DGV1.CurrentRow.Cells(4).Value
            MessageBox.Show("Producto seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)



            Ventas.TxtCod.Text = cod
            ' Ventas.TxtProd.Text = nom
            Ventas.TxtMarca.Text = mar
            Ventas.TxtExis.Text = cant
            Ventas.TxtPre.Text = precio
            Ventas.Focus()

            Me.Close()

        End If
    End Sub

    Private Sub BtnBusc_Click(sender As Object, e As EventArgs) Handles BtnBusc.Click

    End Sub
End Class