Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class Principal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ventas.Show()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ingreso.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Principal " & "V. 1.0.19"
    End Sub



    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        salir()

    End Sub
    Private Sub salir()
        Dim res As New DialogResult
        res = MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then
            Portada.Close()

        Else

        End If
    End Sub

    Private Sub Principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim res As New DialogResult
        res = MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then
            Portada.Close()

        Else

            e.Cancel = True
        End If

    End Sub
End Class