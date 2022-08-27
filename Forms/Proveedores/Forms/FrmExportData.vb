Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmExportData

#Region "Field and properties"

    Private Connection As SqlClient.SqlConnectionStringBuilder
    Private directory As String
    Private DocName As String

    Private Report As SuppliersReport
    Private ConexInfo As ConnectionInfo
    Private ListOfTables As Tables
    Private TableReport As Table
    Private ConnectionTable As TableLogOnInfo
    Private FileDestiny As DiskFileDestinationOptions = Nothing

#End Region

#Region "Builders"

    Public Sub New(ConnectionString As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Connection = New SqlClient.SqlConnectionStringBuilder(ConnectionString)
        Report = New SuppliersReport()
        FileDestiny = New DiskFileDestinationOptions()

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

        ListOfTables = Report.Database.Tables

        For Each tablaReport In ListOfTables

            ConnectionTable = tablaReport.LogOnInfo
            ConnectionTable.ConnectionInfo = ConexInfo
            tablaReport.ApplyLogOnInfo(ConnectionTable)

        Next

        If FileDestiny IsNot Nothing Then

            Report.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            Report.ExportOptions.ExportFormatType = ExportFormatType.Excel
            Report.ExportOptions.ExportDestinationOptions = FileDestiny

        End If

    End Sub

    Private Sub Export(ruta As String, DocName As String)

        Dim myruta As String = ruta & "\" & DocName & ".xls"
        FileDestiny.DiskFileName = myruta
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

#End Region

#Region "Methods of events"

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If cdtName.Text <> Nothing And CdtRuta.Text <> Nothing Then

            Cursor = Cursors.WaitCursor

            Export(Trim(CdtRuta.Text), Trim(cdtName.Text))

            Cursor = Cursors.Default

        End If

    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

            CdtRuta.Text = FolderBrowserDialog1.SelectedPath

        End If

    End Sub

#End Region

End Class