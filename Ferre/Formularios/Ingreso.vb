Imports MySql.Data.MySqlClient

Public Class Ingreso
    Dim prod As New producto
    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Text = "Compras " & "V. 1.0.19"
    End Sub








    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If prod.existprod(TxtCod.Text) Then
            actualprod()
        Else
            agregaprod()

        End If
        limpiarform()
        TxtCod.Select()


    End Sub

    Private Sub agregaprod()
        Dim datos() As String = {TxtCod.Text, TxtProd.Text, TxtMarca.Text, TxtPrecio.Text, TxtPreV1.Text, TxtPreV2.Text, NudCant.Value.ToString}
        If prod.ingresoprod(datos) Then
            MessageBox.Show("Producto ingresado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error a  ingresar ´producto, revise los datos e intente de nuevo", "No Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub actualprod()
        Dim datos() As String = {TxtCod.Text, TxtProd.Text, TxtMarca.Text, TxtPrecio.Text, TxtPreV1.Text, TxtPreV2.Text, NudCant.Value.ToString}
        If prod.updprod(datos) Then
            MessageBox.Show("Producto Actualizado correctamente", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error a  ingresar actualizar producto, revise los datos e intente de nuevo", "No Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub TxtCod_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtCod_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCod.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim cod As String
            cod = TxtCod.Text
            TxtCod.SelectionStart = 0
            TxtCod.SelectionLength = TxtCod.Text.Length
            TxtCod.Select()
            buscaprod(cod)

        End If
    End Sub
    Private Sub buscaprod(ByVal cod As String)
        Dim datos As New DataTable
        datos = prod.buscarprod(cod)
        If datos.Rows.Count <= 0 Then

            TxtProd.Clear()
            TxtMarca.Clear()
            TxtPrecio.Text = 0
            TxtPreV1.Text = 0
            TxtPreV2.Text = 0
            NudCant.Value = 0
        Else
            TxtProd.Text = datos.Rows(0)(0).ToString
            TxtMarca.Text = datos.Rows(0)(1).ToString
            TxtPrecio.Text = datos.Rows(0)(2).ToString
            TxtPreV1.Text = datos.Rows(0)(3).ToString
            TxtPreV2.Text = datos.Rows(0)(4).ToString
            NudCant.Value = Int32.Parse(datos.Rows(0)(5).ToString)
            MessageBox.Show("Producto existente!", "Existe", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub NudCant_ValueChanged(sender As Object, e As EventArgs)
        If TxtCod.Text <> "" And TxtProd.Text <> "" Then

        End If
    End Sub



    Private Sub borrarpro(ByVal ind As Integer)
        DgvDatos.Rows.RemoveAt(ind)
    End Sub




    Private Sub limpiarform()
        TxtPreV1.Clear()
        TxtCod.Clear()
        TxtMarca.Clear()
        TxtPrecio.Clear()
        TxtProd.Clear()
        TxtPreV2.Clear()
        DgvDatos.Rows.Clear()

    End Sub



    Private Function ob_precio(ByVal cod As String) As Decimal
        Dim datos As New DataSet
        Dim consulta As String
        consulta = "Select precio from producto where id_prod='" & cod & "'"
        Dim adap As New MySqlDataAdapter(consulta, conn)
        adap.Fill(datos)
        Dim precio As Decimal
        Try
            precio = datos.Tables(0).Rows(0)(0).ToString
            Return precio
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return 0
        End Try


    End Function


    Private Sub AddProd_Click(sender As Object, e As EventArgs)
        Dim inprod As New productoAg
        inprod.Show()

    End Sub

    Private Sub AddProv_Click(sender As Object, e As EventArgs)
        Dim ingre As New inprov
        ingre.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Btnmod_Click(sender As Object, e As EventArgs)
        ModProd.Show()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub


End Class