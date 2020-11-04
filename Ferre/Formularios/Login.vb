Public Class Login
    Dim logi As New Loguearse
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        End
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim usu As String, pass As String
        usu = TxtUsu.Text
        pass = TxtPass.Text
        Dim datos As New DataTable
        datos = logi.logueo(usu, pass)
        If (datos.Rows.Count < 1) Then
            MessageBox.Show("Usuario o contraseña incorrecta", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPass.Clear()
            TxtUsu.Clear()
        ElseIf (datos.Rows(0)(3).ToString = usu And datos.Rows(0)(2) = pass) Then
            MessageBox.Show("Ingreso concedido", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim princi As New Form1
            princi.idUsu = datos.Rows(0)(0).ToString
            princi.nombreusu = datos.Rows(0)(1).ToString
            princi.tipousu = datos.Rows(0)(4).ToString
            Me.Hide()
            princi.Show()
        Else
            MessageBox.Show("Usuario o contraseña incorrecta", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtUsu.Clear()
            TxtPass.Clear()
        End If

    End Sub
End Class