Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmExportData

#Region "Fields and properties"
    Private Connection As SqlClient.SqlConnectionStringBuilder
    Private Dierctory As String
    Private DocName As String

    Private Report As customerReport
    Private ConexInfo As ConnectionInfo
    Private ListaTablas As Tables
    Private tablaReport As Table
    Private TablaConexion As TableLogOnInfo
    Private ArchivoDestino As DiskFileDestinationOptions = Nothing

#End Region

#Region "Builders"

    Public Sub New(ConnectionString As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Connection = New SqlClient.SqlConnectionStringBuilder(ConnectionString)
        Report = New customerReport()
        ArchivoDestino = New DiskFileDestinationOptions()

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadReport()

        ConexInfo = New ConnectionInfo()

        Report.Refresh()
        'Pasamos los valores de conexion al objeto ConnectionInfo
        With ConexInfo

            .ServerName = Connection.DataSource
            .DatabaseName = Connection.InitialCatalog
            .UserID = Connection.UserID
            .IntegratedSecurity = True

        End With

        ListaTablas = Report.Database.Tables

        For Each tablaReport In ListaTablas

            TablaConexion = tablaReport.LogOnInfo
            TablaConexion.ConnectionInfo = ConexInfo
            tablaReport.ApplyLogOnInfo(TablaConexion)

        Next

        If ArchivoDestino IsNot Nothing Then

            Report.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            Report.ExportOptions.ExportFormatType = ExportFormatType.Excel
            Report.ExportOptions.ExportDestinationOptions = ArchivoDestino

        End If

    End Sub

    Private Sub Export(ruta As String, DocName As String)

        Dim myruta As String = ruta & "\" & DocName & ".xls"
        ArchivoDestino.DiskFileName = myruta
        LoadReport()
        Report.Export()

        If File.Exists(myruta) Then

            MsgBox("Exportación finalizada correctamente", MsgBoxStyle.OkOnly)
            Process.Start(myruta)
            Me.Close()

        Else

            MsgBox("No se pudo exportar el documento", MsgBoxStyle.Exclamation)

        End If

    End Sub

    Private Function pruebas() As Byte()

        Dim archivo As Byte()
        Dim myStream As Stream = OpenFileDialog1.OpenFile()
        Dim obj As MemoryStream = New MemoryStream()

        myStream.CopyTo(obj)
        archivo = obj.ToArray()

        Return archivo

    End Function

#End Region

#Region "Methods of events"

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If cdtName.Text <> Nothing And CdtRuta.Text <> Nothing Then

            Export(Trim(CdtRuta.Text), Trim(cdtName.Text))

        End If

    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

            CdtRuta.Text = FolderBrowserDialog1.SelectedPath

        End If

    End Sub

#End Region
End Class