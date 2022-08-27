Imports ProveedoresDb
Public Class FrmSuppliersBankDetails

#Region "Fields and properties"

    Private BankDetailsRepository As SuppliersBankDetails
    Private _SupplierID As Integer
    Private _AccountID As Integer

    Public WriteOnly Property openAs As Integer
        Set(value As Integer)

            If value = 1 Then

                btnSave.Visible = True

            Else

                btnModify.Visible = True

            End If

        End Set
    End Property

    Public WriteOnly Property SupplierID As Integer
        Set(value As Integer)

            _SupplierID = value

        End Set
    End Property

    Public WriteOnly Property AccountID As Integer
        Set(value As Integer)

            _AccountID = value

        End Set
    End Property

    Public Property BankName As String
        Get

            Return Trim(cdtName.Text)

        End Get
        Set(value As String)

            cdtName.Text = Trim(value)

        End Set
    End Property

    Public Property Clabe As String
        Get

            Return Trim(cdtClabe.Text)

        End Get
        Set(value As String)

            cdtClabe.Text = Trim(value)

        End Set
    End Property

    Public Property Account As String
        Get

            Return Trim(cdtAccount.Text)

        End Get
        Set(value As String)

            cdtAccount.Text = Trim(value)

        End Set
    End Property

    Public Property BranchOffice As String
        Get

            Return Trim(cdtBranchOffice.Text)

        End Get
        Set(value As String)

            cdtBranchOffice.Text = Trim(value)

        End Set
    End Property

    Public Property Titular As String
        Get

            Return Trim(CdtTitular.Text)

        End Get
        Set(value As String)

            CdtTitular.Text = Trim(value)

        End Set
    End Property

    Public Property AccountDefault As Boolean
        Get

            Return chbxDefault.Checked

        End Get
        Set(value As Boolean)

            chbxDefault.Checked = value

        End Set
    End Property

#End Region

#Region "Builders"

    Public Sub New(BankDetailsRepository As SuppliersBankDetails)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.BankDetailsRepository = BankDetailsRepository

    End Sub
#End Region

#Region "Methods"

    Private Sub ClearForm()

        BankName = Nothing
        Clabe = Nothing
        Account = Nothing
        BranchOffice = Nothing
        Titular = Nothing
        AccountDefault = False

        btnSave.Visible = False
        btnModify.Visible = False

    End Sub
    Private Sub SaveBankDetails()

        With BankDetailsRepository

            .Bank = BankName
            .Clabe = Clabe
            .Account = Account
            .branchOffice = BranchOffice
            .titular = Titular
            .DefaultAccount = AccountDefault

            If .save(_SupplierID) = True Then

                MsgBox(.Messages, MsgBoxStyle.Information)
                CType(Owner, FrmProveedores).ListOfBankDetails = .getAccounts(_SupplierID)
                Me.Close()

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub ModifyBankDetails()

        With BankDetailsRepository

            .Bank = BankName
            .Clabe = Clabe
            .Account = Account
            .branchOffice = BranchOffice
            .titular = Titular
            .DefaultAccount = AccountDefault

            If .modify(_SupplierID, _AccountID) = True Then

                MsgBox(.Messages, MsgBoxStyle.Information)
                CType(Owner, FrmProveedores).ListOfBankDetails = .getAccounts(_SupplierID)
                Me.Close()

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub
#End Region

#Region "Methods of events"

    Private Sub FrmSuppliersBankDetails_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        ClearForm()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SaveBankDetails()

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        ModifyBankDetails()

    End Sub

#End Region
End Class