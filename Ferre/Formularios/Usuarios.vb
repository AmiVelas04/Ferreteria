Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboNivel.SelectedIndex = 0
        LblId.Text = 0
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub
    Private Sub Guardar()
        Dim id As String
        Dim nombre As String
        Dim usuario As String
        Dim pass1 As String
        Dim pass2 As String
        Dim nivel As String
        id = LblId.Text
        nombre = TxtNombre.Text
        usuario = TxtUsu.Text
        pass1 = TxtPass1.Text
        pass2 = TxtPass2.Text
        If (CboNivel.SelectedIndex = 0) Then
            nivel = 2
        Else
            nivel = 3
        End If
        If (pass1 <> pass2) Then
            MessageBox.Show("Las contraseñas no coinciden", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPass1.Clear()
            TxtPass2.Clear()
        Else
            Dim datos() As String = {id, nombre, usuario, pass1, nivel}

        End If
    End Sub
End Class