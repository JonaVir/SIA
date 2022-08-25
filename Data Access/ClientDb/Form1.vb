Friend Class Form1

    Private repository As Clients
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        repository = Clients.getInstance(My.Settings.test)

        Me.DataGridView1.DataSource = repository.listOfClients


    End Sub
End Class