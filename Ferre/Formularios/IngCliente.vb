Imports MySql.Data.MySqlClient

Public Class IngCliente
    Dim cli As New Cliente
    Private Sub BtnAg_Click(sender As Object, e As EventArgs) Handles BtnAg.Click
        If Lblcod.Text = "0" Then
            guardar()
        Else
            editar()
        End If



    End Sub
    Private Sub limpiar()

        TxtDir.Clear()
        TxtNIT.Clear()
        TxtNom.Clear()
        TxtTel.Clear()
        TxtDpi.Clear()
        BtnAg.Text = "Guardar"
        Lblcod.Text = "0"

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BtnLimp_Click(sender As Object, e As EventArgs) Handles BtnLimp.Click
        limpiar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim nombrecli As String
        nombrecli = TxtNomcli.Text
        Dim datos As New DataTable
        datos = cli.buscacli(nombrecli)
        DgvCli.DataSource = datos
        DgvCli.Columns(0).Visible = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DgvCli.RowCount > 0 Then
            Dim fila As Integer
            fila = DgvCli.CurrentRow.Index

            Lblcod.Text = DgvCli.Rows(fila).Cells(0).Value.ToString
            TxtNom.Text = DgvCli.Rows(fila).Cells(1).Value.ToString
            TxtDir.Text = DgvCli.Rows(fila).Cells(2).Value.ToString
            TxtNIT.Text = DgvCli.Rows(fila).Cells(3).Value.ToString
            TxtDpi.Text = DgvCli.Rows(fila).Cells(4).Value.ToString
            TxtTel.Text = DgvCli.Rows(fila).Cells(5).Value.ToString
            BtnAg.Text = "Actualizar"
        End If

    End Sub

    Private Sub guardar()
        Dim datos(5) As String

        datos(0) = TxtNom.Text
        datos(1) = TxtDir.Text
        datos(2) = TxtNIT.Text
        datos(3) = TxtDpi.Text
        datos(4) = TxtTel.Text

        If (cli.ingresarcli(datos)) Then
            MessageBox.Show("Cliente agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Else
            MessageBox.Show("Error al agregar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub editar()
        Dim datos(5) As String

        datos(0) = Lblcod.Text
        datos(1) = TxtNom.Text
        datos(2) = TxtDir.Text
        datos(3) = TxtNIT.Text
        datos(4) = TxtDpi.Text
        datos(5) = TxtTel.Text

        If (cli.editarcli(datos)) Then
            MessageBox.Show("Cliente editado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Else
            MessageBox.Show("Error al editar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class