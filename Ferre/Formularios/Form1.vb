Public Class Form1

    Public idUsu As String
    Public nombreusu As String
    Public tipousu As String
    Private Sub abrir_formu(ByVal frmhijo As Object)
        If PanCent.Controls.Count > 0 Then
            PanCent.Controls.RemoveAt(0)
        End If

        Dim frm As Form = TryCast(frmhijo, Form)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        Me.PanCent.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Dim formu As New Ventas
        formu.idven = idUsu
        abrir_formu(formu)

    End Sub

    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click
        Dim formu As New Ingreso
        abrir_formu(formu)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        End
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        Dim formu As New RepoAll
        abrir_formu(formu)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUsu.Text = nombreusu
        If (tipousu = "1" Or tipousu = 2) Then
            mostrar()

        End If
    End Sub
    Private Sub mostrar()
        BtnProducto.Visible = True
        BtnCliente.Visible = True
        BtnReportes.Visible = True
        BtnRespaldo.Visible = True
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        Dim formu As New Usuarios
        abrir_formu(formu)
    End Sub

    Private Sub BtnRespaldo_Click(sender As Object, e As EventArgs) Handles BtnRespaldo.Click
        Dim resp As New Respaldo
        resp.ShowDialog()
    End Sub
End Class
