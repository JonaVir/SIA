Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim screem As FrmClients
        Dim userID As String = ""
        Dim Permissions As String = "DES,INS,CAM,ELI,LIS"
        Dim ConnectionsString As String = My.Settings.Server

        screem = New FrmClients(userID, Permissions, ConnectionsString)
        screem.ShowDialog()

    End Sub
End Class
