Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Form As FrmProveedores
        Dim conection As String = My.Settings.ServerTest
        Form = New FrmProveedores(conection, "", "DES,INS,CAM,ELI,LIST")

        Form.ShowDialog()

    End Sub
End Class
