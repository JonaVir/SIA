Imports ClientDb
Public Class FrmFinancialData

#Region "fields and propierties"

    Private repository As ClientFinancialData

    Private _ClientID As String

    Public WriteOnly Property ClientID As String
        Set(value As String)

            _ClientID = value

        End Set
    End Property

    Public Property LimitCredit As Double
        Get

            If IsNumeric(cdtCreditLimit.Text) Then

                Return CDbl(cdtCreditLimit.Text)

            Else

                Return 0

            End If

        End Get
        Set(value As Double)

            cdtCreditLimit.Text = value

        End Set
    End Property

    Public Property Moneda As String
        Get

            Return Trim(cbxCurrency.Text)

        End Get
        Set(value As String)

            cbxCurrency.Text = value

        End Set
    End Property

    Public Property accountingLock As Boolean
        Get

            Return ckbxLocked.Checked

        End Get
        Set(value As Boolean)

            ckbxLocked.Checked = value

        End Set
    End Property

#End Region

#Region "builders"

    Public Sub New(connectionString As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        repository = ClientFinancialData.getInstance(connectionString)

    End Sub

#End Region

#Region "Methods"

    Private Sub Save()

        With repository

            .LimitCredit = Me.LimitCredit
            .Currency = Me.Moneda
            .AccountingLock = Me.accountingLock

            If .SaveFinancialData(_ClientID) = True Then

                MsgBox(.messages, MsgBoxStyle.Information)
                CType(Me.Owner, FrmClients).FinancialData = .getFinancialInformation(_ClientID)
                Me.Close()

            Else

                MsgBox(.messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub Modify()

        With repository

            .LimitCredit = Me.LimitCredit
            .Currency = Me.Moneda
            .AccountingLock = Me.accountingLock

            If .ModifyFinancialData(_ClientID) = True Then

                MsgBox(.messages, MsgBoxStyle.Information)
                CType(Me.Owner, FrmClients).FinancialData = .getFinancialInformation(_ClientID)
                Me.Close()

            Else

                MsgBox(.messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub ClearForm()

        LimitCredit = Nothing
        Moneda = Nothing
        accountingLock = False

    End Sub

#End Region

#Region "Methods of events"

    Private Sub FrmFinancialData_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        ClearForm()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Save()

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        Modify()

    End Sub

#End Region

End Class