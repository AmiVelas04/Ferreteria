Imports MySql.Data.MySqlClient
Public Class Respaldo

    Dim conexo As New Conexion
    Dim carpeta = New FolderBrowserDialog()

    Dim MiFecha As String = DateTime.Now.ToString("dd-MM-yyyy")
    Dim destino As String



    Private Sub BtnCarpeta_Click(sender As Object, e As EventArgs) Handles BtnCarpeta.Click
        carpeta.RootFolder = Environment.SpecialFolder.Desktop
        carpeta.Description = "Seleccione la ruta para realizar el respaldo"
        carpeta.ShowNewFolderButton = False
        Dim miCarpeta As String
        If (carpeta.ShowDialog() = DialogResult.OK) Then
            TxtRuta.Text = carpeta.SelectedPath
            miCarpeta = carpeta.SelectedPath
            destino = miCarpeta.Trim() & "\\RespaldoBd_" & MiFecha & ".sql"
        End If
    End Sub

    Private Sub respaldo()

        Try

            Dim conueva As String = conexo.conn.ConnectionString & "; charset=utf8;convertzerodatetime=true;"
            Dim com As New MySqlCommand()
            Dim conn As New MySqlConnection(conueva)
            com.Connection = conn
            Dim respaldo As New MySqlBackup(com)
            conn.Open()
            respaldo.ExportToFile(destino)
            conn.Close()
            MessageBox.Show("El respaldo se ha realizado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtRuta.Clear()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.ToString())
            TxtRuta.Clear()
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        respaldo()
    End Sub
End Class