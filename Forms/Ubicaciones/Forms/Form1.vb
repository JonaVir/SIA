Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Pantalla As FrmCatalogCountries
        Dim conection As String = My.Settings.ServerPruebas

        Pantalla = New FrmCatalogCountries(" ", "DES,INS,CAM,ELI", conection)

        Pantalla.Show()

    End Sub

End Class