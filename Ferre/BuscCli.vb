Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class BuscCli
    Private Sub BtnBusc_Click(sender As Object, e As EventArgs) Handles BtnBusc.Click
        Dim nom As String
        nom = TxtNom.Text
        Dim consulta As String
        consulta = "Select * from cliente where nombre like '%" & nom & "%'"
        Dim adap As New MySqlDataAdapter(consulta, conn)
        Dim datos As New DataSet
        adap.Fill(datos)
        DGV1.DataSource = datos.Tables(0)

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If DGV1.RowCount = 0 Then
        Else
            Dim cod As String = DGV1.CurrentRow.Cells(0).Value
            Dim nom As String = DGV1.CurrentRow.Cells(2).Value
            Dim nit As String = DGV1.CurrentRow.Cells(1).Value
            Dim dir As String = DGV1.CurrentRow.Cells(3).Value
            Dim tel As String = DGV1.CurrentRow.Cells(4).Value
            Ventas.TxtCC.Text = cod
            Ventas.TxtCli.Text = nom
            Ventas.TxtN.Text = nit
            MessageBox.Show("Cliente seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If
    End Sub

    Private Sub BuscCli_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Ventas.Focus()
    End Sub


End Class