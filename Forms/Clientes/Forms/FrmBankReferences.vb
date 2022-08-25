Imports ClientDb
Imports LocationsDb.Coutries
Imports LocationsDb.States
Imports LocationsDb.Municipalities
Public Class FrmBankReferences

#Region "fields and propierties"

    Private repository As ClientBankReferences

    Private countriesRepository As Countries
    Private statesRepository As States
    Private municipalitiesRepository As Municipalities

    Private _ClientID As Integer
    Private _id As Integer

    Public WriteOnly Property Id As Integer
        Set(value As Integer)

            _id = value

        End Set
    End Property

    Public WriteOnly Property ClientID As Integer
        Set(value As Integer)

            _ClientID = value

        End Set
    End Property

    Public Property BankName As String
        Get

            Return Trim(cdtBankName.Text)

        End Get
        Set(value As String)

            cdtBankName.Text = value

        End Set
    End Property

    Public Property RazonSocial As String
        Get

            Return Trim(cdtRazonSocial.Text)

        End Get
        Set(value As String)

            cdtRazonSocial.Text = value

        End Set
    End Property

    Public Property BranchOffice As String
        Get

            Return Trim(cdtBranchOffice.Text)

        End Get
        Set(value As String)

            cdtBranchOffice.Text = value

        End Set
    End Property

    Public Property account As String
        Get

            Return Trim(cdtAccount.Text)

        End Get
        Set(value As String)

            cdtAccount.Text = value

        End Set
    End Property

    Public Property ContactName As String
        Get

            Return Trim(cdtContactName.Text)

        End Get
        Set(value As String)

            cdtContactName.Text = value

        End Set
    End Property

    Public Property Job As String
        Get

            Return Trim(cdtJob.Text)

        End Get
        Set(value As String)

            cdtJob.Text = value

        End Set
    End Property

    Public Property Telephone As String
        Get

            Return Trim(cdtTelephone.Text)

        End Get
        Set(value As String)

            cdtTelephone.Text = value

        End Set
    End Property

    Public Property Extension As String
        Get

            Return Trim(cdtExtension.Text)

        End Get
        Set(value As String)

            cdtExtension.Text = value

        End Set
    End Property

    Public Property CellPhone As String
        Get

            Return Trim(cdtCellPhone.Text)

        End Get
        Set(value As String)

            cdtCellPhone.Text = value

        End Set
    End Property

    Public Property Country As String
        Get

            Return Trim(cbxCountry.Text)

        End Get
        Set(value As String)

            cbxCountry.Text = value

        End Set
    End Property

    Public Property State As String
        Get

            Return Trim(cbxState.Text)

        End Get
        Set(value As String)

            cbxState.Text = value

        End Set
    End Property

    Public Property Municipality As String
        Get

            Return Trim(cbxMunicipality.Text)

        End Get
        Set(value As String)

            cbxMunicipality.Text = value

        End Set
    End Property

    Public Property Cologne As String
        Get

            Return Trim(cdtCologne.Text)

        End Get
        Set(value As String)

            cdtCologne.Text = value

        End Set
    End Property

    Public Property PostalCode As String
        Get

            Return Trim(cdtPostalCode.Text)

        End Get
        Set(value As String)

            cdtPostalCode.Text = value

        End Set
    End Property

    Public Property Street As String
        Get

            Return Trim(cdtStreet.Text)

        End Get
        Set(value As String)

            cdtStreet.Text = value

        End Set
    End Property

    Public Property NumberExterno As String
        Get

            Return Trim(cdtNumberExterior.Text)

        End Get
        Set(value As String)

            cdtNumberExterior.Text = value

        End Set
    End Property

    Public Property NumberInterno As String
        Get

            Return Trim(cdtNumberInterior.Text)

        End Get
        Set(value As String)

            cdtNumberInterior.Text = value

        End Set
    End Property

#End Region

#Region "Builders"

    Public Sub New(connectionString As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        repository = ClientBankReferences.getInstance(connectionString)
        countriesRepository = Countries.getInstance(connectionString)
        statesRepository = States.getInstance(connectionString)
        municipalitiesRepository = Municipalities.getInstance(connectionString)

        loadCountries()

    End Sub

#End Region

#Region "Methods"

    Private Sub loadCountries()

        Dim table As DataTable = countriesRepository.listOfCountries

        For Each row As DataRow In table.Rows

            cbxCountry.Items.Add(row.Item(2).ToString())

        Next

    End Sub

    Private Sub loadState(Country As String)

        Dim id As Integer = countriesRepository.IdCountry(Country)
        Dim table As DataTable = statesRepository.getEstates(id)

        If table IsNot Nothing Then

            For Each row As DataRow In table.Rows

                cbxState.Items.Add(row.Item(3).ToString())

            Next

        End If

    End Sub

    Private Sub loadMunicipality(State As String)

        Dim id As Integer = statesRepository.StateID(State)
        Dim table As DataTable = municipalitiesRepository.getMunicipalities(id)

        If table IsNot Nothing Then

            For Each row As DataRow In table.Rows

                cbxMunicipality.Items.Add(row.Item(4).ToString())

            Next

        End If

    End Sub

    Private Sub save()

        With repository

            .bank = Me.BankName
            .RazonSocial = Me.RazonSocial
            .BranchOffice = Me.BranchOffice
            .Accout = Me.account
            .Contact = Me.ContactName
            .Job = Me.Job
            .Telephone = Me.Telephone
            .Extension = Me.Extension
            .CellPhone = Me.CellPhone
            .Country = countriesRepository.IdCountry(Me.Country)
            .State = statesRepository.StateID(Me.State)
            .Municipality = municipalitiesRepository.MunicilityID(Me.Municipality)
            .Cologne = Me.Cologne
            .PostalCode = Me.PostalCode
            .Street = Me.Street
            .NumExterior = Me.NumberExterno
            .NumInterior = Me.NumberInterno

            If .SaveBankReference(_ClientID) = True Then

                MsgBox(.messages, MsgBoxStyle.Information)
                CType(Me.Owner, FrmClients).BankReferences = .getBankReferences(_ClientID)
                Me.Close()
            Else

                MsgBox(.messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub modify()

        With repository

            .Id = Me._id
            .bank = Me.BankName
            .RazonSocial = Me.RazonSocial
            .BranchOffice = Me.BranchOffice
            .Accout = Me.account
            .Contact = Me.ContactName
            .Job = Me.Job
            .Telephone = Me.Telephone
            .Extension = Me.Extension
            .CellPhone = Me.CellPhone
            .Country = countriesRepository.IdCountry(Me.Country)
            .State = statesRepository.StateID(Me.State)
            .Municipality = municipalitiesRepository.MunicilityID(Me.Municipality)
            .Cologne = Me.Cologne
            .PostalCode = Me.PostalCode
            .Street = Me.Street
            .NumExterior = Me.NumberExterno
            .NumInterior = Me.NumberInterno

            If .ModifyBankReference(_ClientID) = True Then

                MsgBox(.Messages, MsgBoxStyle.Information)

                CType(Me.Owner, FrmClients).BankReferences = .getBankReferences(_ClientID)
                Me.Close()

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation, "error")

            End If

        End With

    End Sub

    Private Sub ClearForm()

        BankName = Nothing
        RazonSocial = Nothing
        BranchOffice = Nothing
        account = Nothing
        ContactName = Nothing
        Job = Nothing
        Telephone = Nothing
        Extension = Nothing
        CellPhone = Nothing
        Country = Nothing
        State = Nothing
        Municipality = Nothing
        Cologne = Nothing
        PostalCode = Nothing
        Street = Nothing
        NumberExterno = Nothing
        NumberInterno = Nothing

    End Sub
#End Region

#Region "Methods of events"

    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged

        loadState(cbxCountry.Text)

    End Sub

    Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged

        loadMunicipality(cbxState.Text)

    End Sub

    Private Sub FrmBankReferences_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        ClearForm()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        save()

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        modify()

    End Sub

#End Region

End Class