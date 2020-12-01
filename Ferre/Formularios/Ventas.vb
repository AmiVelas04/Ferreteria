Imports MySql.Data.MySqlClient

Public Class Ventas
    Public Vtotal As Decimal
    Public idven As String

    Dim prod As New producto
    Dim fact As New Factura
    Dim cli As New Cliente
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Label3.Text & " " & DateAndTime.DateString

        Me.Text = "Ventas " & "V. 1.0.19"
        TxtCod.Select()
        listarprod()
        listacli()

    End Sub
    Private Sub listarprod()
        Dim datos As New DataTable
        datos = prod.buscarprodnom()
        CboProd.DataSource = datos
        CboProd.DisplayMember = "Nombre"
        CboProd.ValueMember = "id_prod"
        Dim produ As New AutoCompleteStringCollection
        For Each fila As DataRow In datos.Rows
            produ.Add(fila("Nombre").ToString)

        Next
        CboProd.AutoCompleteCustomSource = produ
        CboProd.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CboProd.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub listacli()
        Dim datos As New DataTable
        datos = cli.listacli()
        CboCliente.DataSource = datos
        CboCliente.DisplayMember = "nombre"
        CboCliente.ValueMember = "id_cli"
        Dim clien As New AutoCompleteStringCollection
        For Each fila As DataRow In datos.Rows
            clien.add(fila("nombre").ToString)
        Next
        CboCliente.AutoCompleteCustomSource = clien
        CboCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CboCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub listarcli()
        TxtCC.Text = "1"
        TxtCli.Text = "Consumidor Final"
        TxtN.Text = "C/F"
    End Sub

    Private Sub TxtCod_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCod.KeyDown
        If e.KeyValue = Keys.Return Then
            buscarprod(TxtCod.Text)
            TxtCod.SelectionStart = 0
            TxtCod.SelectionLength = TxtCod.Text.Length
            TxtCod.Select()
        ElseIf e.KeyValue = Keys.F5 Then
            'Buscprod.Show()
        End If

    End Sub
    'Procedimientos
    'Buscar el cliente 
    Private Sub Buscarcli(ByRef cod As String)
        Dim consulcli As String
        consulcli = "Select nombre, direccion,nit from cliente where id_cli='" & cod & "'"
        Dim adap As New MySqlDataAdapter(consulcli, Conex.conn)
        Dim datos As New DataSet
        adap.Fill(datos)
        If (datos.Tables(0).Rows.Count) <= 0 Then
            MessageBox.Show("el codigo de cliente no existe", "No cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            TxtCli.Text = datos.Tables(0).Rows(0)(0).ToString
            TxtN.Text = datos.Tables(0).Rows(0)(2).ToString
        End If

    End Sub

    'Buscar el producto

    Private Sub buscarprod(ByVal cod As String)
        Dim datos As New DataTable
        datos = prod.buscarprod(cod)
        If datos.Rows.Count > 0 Then
            TxtCod.Tag = cod
            ' TxtProd.Text = datos.Rows(0)(0).ToString
            TxtMarca.Text = datos.Rows(0)(1).ToString
            TxtPre.Text = datos.Rows(0)(4).ToString
            TxtExis.Text = datos.Rows(0)(5).ToString
        Else
            MessageBox.Show("No se encontro el producto. intente de nuevo", "Sin producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Vtoptal As Decimal = 0

        Dim SubT As Decimal, precio As Decimal, costo As Decimal
        Dim nom As String, marca As String
        Dim cant As Integer, existe As Integer
        Dim datos As New DataTable
        datos = prod.buscarprod(TxtCod.Tag)
        If (datos.Rows.Count <= 0) Then

            Return
        End If
        nom = datos.Rows(0)(0).ToString
        marca = datos.Rows(0)(1).ToString
        costo = Decimal.Parse(datos.Rows(0)(2).ToString)
        precio = Decimal.Parse(TxtPre.Text)
        existe = Integer.Parse(datos.Rows(0)(5).ToString)
        cant = NupCant.Value
        SubT = precio * cant
        If existe < cant Then
            MessageBox.Show("No hay suficientes existencias del producto", "Insuficnete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (precio <= (costo)) Then
            MessageBox.Show("El precio de venta es demasiado bajo!", "Precio menor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If DgvProd.Rows.Count > 0 Then
            Else
                DgvProd.Columns.Add("cod", "Codigo")
                DgvProd.Columns.Add("Nom", "Nombre de producto")
                DgvProd.Columns.Add("Marca", "Marca")
                DgvProd.Columns.Add("cantidad", "Cantidad")
                DgvProd.Columns.Add("Precio", "Precio")
                DgvProd.Columns.Add("Sub", "Sub-Total")
            End If
            'agregar producto 
            DgvProd.Rows.Add(TxtCod.Tag, nom, marca, cant.ToString, precio.ToString, SubT.ToString)
            Vtotal = Vtotal + (CDec(TxtPre.Text) * NupCant.Value)
            TxtTotal.Text = Vtotal

            TxtCod.SelectionStart = 0
            TxtCod.SelectionLength = TxtCod.Text.Length
            TxtCod.Select()
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim indice As Integer

        Try

            If DgvProd.Rows.Count <= 0 Then
                MsgBox("No hay productos!")
            Else

                indice = DgvProd.CurrentRow.Index
                borrarp(indice)
                If DgvProd.Rows.Count <= 0 Then
                    Do Until DgvProd.Columns.Count = 0
                        DgvProd.Columns.RemoveAt(0)
                    Loop
                End If
            End If
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    'Borrar producto
    Private Sub borrarp(ByVal ind As Integer)
        Dim precio As Decimal = DgvProd.CurrentRow.Cells(3).Value
        Dim cant As Integer = DgvProd.CurrentRow.Cells(4).Value
        Dim total As Decimal
        total = TxtTotal.Text
        total = total - precio * cant
        Vtotal = total
        TxtTotal.Text = Vtotal
        DgvProd.Rows.RemoveAt(ind)
    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles BtnVenta.Click
        If DgvProd.RowCount = 0 Then
            MessageBox.Show("No existen productos agregados a la venta!", "Sin productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            enlistarprod()

        End If


    End Sub

    'Factura
    Private Sub enlistarprod()

        Dim idcli As Integer
        If (CboCliente.SelectedValue = Nothing) Then
            Dim valores(5) As String
            valores(0) = CboCliente.Text
            valores(1) = ""
            valores(2) = TxtN.Text
            valores(3) = ""
            valores(4) = ""
            idcli = cli.ingresarcliven(valores)
        Else
            idcli = Integer.Parse(CboCliente.SelectedValue.ToString)
        End If

        Dim datos As New DataTable
        Dim cant As Integer = DgvProd.Rows.Count
        Dim cont As Integer
        datos.Columns.Add(New DataColumn("Codigo", GetType(String)))
        datos.Columns.Add(New DataColumn("nombre", GetType(String)))
        datos.Columns.Add(New DataColumn("marca", GetType(String)))
        datos.Columns.Add(New DataColumn("cantidad", GetType(String)))
        datos.Columns.Add(New DataColumn("precio", GetType(String)))
        datos.Columns.Add(New DataColumn("subtotal", GetType(String)))
        Dim datar As DataRow
        For cont = 0 To cant - 1
            datar = datos.NewRow()
            datar("Codigo") = DgvProd.Rows(cont).Cells(0).Value.ToString
            datar("nombre") = DgvProd.Rows(cont).Cells(1).Value.ToString
            datar("marca") = DgvProd.Rows(cont).Cells(2).Value.ToString
            datar("cantidad") = DgvProd.Rows(cont).Cells(3).Value.ToString
            datar("precio") = DgvProd.Rows(cont).Cells(4).Value.ToString
            datar("subtotal") = DgvProd.Rows(cont).Cells(5).Value.ToString
            datos.Rows.Add(datar)
        Next

        If fact.generarv(datos, idcli.ToString, idven) Then
            MessageBox.Show("Venta realizada correctamente", "Venta Hecha", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se pudo realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
        Principal.Focus()

    End Sub

    Private Sub Ventas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim buscap As New Buscprod
            buscap.Show()
        End If

    End Sub

    Public Sub limpiar()
        Do While DgvProd.Rows.Count > 0
            DgvProd.Rows.RemoveAt(0)
        Loop
        Do While DgvProd.ColumnCount > 0
            DgvProd.Columns.RemoveAt(0)
        Loop
        TxtCod.Clear()
        '  TxtProd.Clear()
        TxtExis.Clear()
        TxtMarca.Clear()
        TxtPre.Clear()
        NupCant.Value = 0
        TxtTotal.Text = 0
    End Sub

    Private Sub CboProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboProd.SelectedIndexChanged
        If (CboProd.SelectedValue.ToString() <> "System.Data.DataRowView") Then
            TxtCod.Text = CboProd.SelectedValue.ToString
            buscarprod(TxtCod.Text)
        End If
    End Sub
End Class