Imports ClientDb
Imports LocationsDb.Coutries
Imports LocationsDb.States
Imports LocationsDb.Municipalities

Public Class FrmClients

#Region "fields and propierties"

    Private ConnectionString As String
    Private Permissions As String
    Private UserID As String

    Private ScreenClientsRepository As FrmSelectClient
    Private ScreenNewClient As FrmNewClient
    Private ScreenTaxData As FrmTaxData
    Private ScreenContacts As FrmContacts
    Private ScreenFinancialData As FrmFinancialData
    Private ScreenBankReferences As FrmBankReferences
    Private ScreenExportData As FrmExportData

    Private RepositoryClients As Clients
    Private RepositoryTaxData As ClientTaxData
    Private RepositoryContacts As ClientContact
    Private repositoryFinancialData As ClientFinancialData
    Private repositoryBankReferences As ClientBankReferences

    Private CountriesRepository As Countries
    Private StatesRepository As States
    Private MunicipalitiesRepository As Municipalities

    Private _IdClient As Integer
    Public Property IdClient As Integer
        Get

            Return _IdClient

        End Get
        Set(value As Integer)

            _IdClient = value

        End Set
    End Property

    Public Property NameClient As String
        Get

            Return Trim(cdtNameClient.Text)

        End Get
        Set(value As String)

            cdtNameClient.Text = value

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

    Public Property Web As String
        Get

            Return Trim(cdtWeb.Text)

        End Get
        Set(value As String)

            cdtWeb.Text = value

        End Set
    End Property

    Public Property Street As String
        Get

            Return Trim(cdtStreetClient.Text)

        End Get
        Set(value As String)

            cdtStreetClient.Text = value

        End Set
    End Property

    Public Property NumberExterior As String
        Get

            Return Trim(cdtNumberExterior.Text)

        End Get
        Set(value As String)

            cdtNumberExterior.Text = value

        End Set
    End Property

    Public Property NumberInterior As String
        Get

            Return Trim(cdtNumberInterior.Text)

        End Get
        Set(value As String)

            cdtNumberInterior.Text = value

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

    Public Property ClienteAAA As Boolean
        Get

            Return ckBxClientAAA.Checked

        End Get
        Set(value As Boolean)

            ckBxClientAAA.Checked = value

        End Set
    End Property

    Public Property Blocking As Boolean
        Get

            Return CkBxBloqueo.Checked

        End Get
        Set(value As Boolean)

            CkBxBloqueo.Checked = value

        End Set
    End Property

    Public WriteOnly Property TaxDetail As DataTable
        Set(value As DataTable)

            dgvTaxData.DataSource = value

            If value IsNot Nothing Then

                If value.Rows.Count > 0 Then

                    btnAddTax.Visible = False

                Else

                    btnAddTax.Visible = True

                End If

            End If

        End Set
    End Property

    Public WriteOnly Property contactsDirectory As DataTable
        Set(value As DataTable)

            Me.dgvContactsDetails.DataSource = value

        End Set
    End Property

    Public WriteOnly Property FinancialData As DataTable
        Set(value As DataTable)

            Me.dgvFinancialData.DataSource = value

            Me.dgvFinancialData.Columns(1).Visible = False

            If Me.dgvFinancialData.Rows.Count > 0 Then

                btnAddFinancialData.Visible = False

            Else

                btnAddFinancialData.Visible = True

            End If

        End Set
    End Property

    Public WriteOnly Property BankReferences As DataTable
        Set(value As DataTable)

            Me.dgvBankReferences.DataSource = value

        End Set
    End Property

#End Region

#Region "Builders"

    Public Sub New(UserID As String, Permissions As String, connectionString As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.UserID = UserID
        Me.Permissions = Permissions
        Me.ConnectionString = connectionString

        RepositoryClients = Clients.getInstance(connectionString)
        RepositoryTaxData = ClientTaxData.getInstance(connectionString)
        RepositoryContacts = ClientContact.getInstance(connectionString)
        repositoryFinancialData = ClientFinancialData.getInstance(connectionString)
        repositoryBankReferences = ClientBankReferences.getInstance(connectionString)

        CountriesRepository = Countries.getInstance(connectionString)
        StatesRepository = States.getInstance(connectionString)
        MunicipalitiesRepository = Municipalities.getInstance(connectionString)

        ScreenExportData = New FrmExportData(connectionString)
        Me.AddOwnedForm(ScreenExportData)

        ScreenClientsRepository = New FrmSelectClient(connectionString)
        Me.AddOwnedForm(ScreenClientsRepository)

        ScreenNewClient = New FrmNewClient(connectionString)
        Me.AddOwnedForm(ScreenNewClient)

        ScreenTaxData = New FrmTaxData(connectionString)
        Me.AddOwnedForm(ScreenTaxData)

        ScreenContacts = New FrmContacts(connectionString)
        Me.AddOwnedForm(ScreenContacts)

        ScreenFinancialData = New FrmFinancialData(connectionString)
        Me.AddOwnedForm(ScreenFinancialData)

        ScreenBankReferences = New FrmBankReferences(connectionString)
        Me.AddOwnedForm(ScreenBankReferences)

        LoadCountries()

        Me.ContainTaxData.Dock = DockStyle.Fill

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadCountries()

        Dim table As DataTable = CountriesRepository.listOfCountries

        For Each row As DataRow In table.Rows

            Me.cbxCountry.Items.Add(row.Item(2).ToString())

        Next

    End Sub

    Private Sub loadStates(CountryName As String)

        Dim id As Integer = CountriesRepository.IdCountry(CountryName)

        Dim table As DataTable = StatesRepository.getEstates(id)

        Me.cbxState.Items.Clear()


        If table IsNot Nothing Then

            For Each row As DataRow In table.Rows

                Me.cbxState.Items.Add(row.Item(3).ToString())

            Next

        End If

    End Sub

    Private Sub loadMunicipalities(StateName As String)

        Dim id As Integer = StatesRepository.StateID(StateName)
        Dim table As DataTable = MunicipalitiesRepository.getMunicipalities(id)

        cbxMunicipality.Items.Clear()

        If table IsNot Nothing Then

            For Each row As DataRow In table.Rows

                Me.cbxMunicipality.Items.Add(row.Item(4).ToString())

            Next

        End If

    End Sub

    Private Sub ClearForm()

        cdtNameClient.Text = Nothing
        cdtStreetClient.Text = Nothing
        cdtNumberExterior.Text = Nothing
        cdtNumberInterior.Text = Nothing
        cbxMunicipality.Text = Nothing
        cbxState.Text = Nothing
        cbxCountry.Text = Nothing
        cdtTelephone.Text = Nothing
        cdtWeb.Text = Nothing
        cdtCologne.Text = Nothing
        cdtPostalCode.Text = Nothing
        ckBxClientAAA.Checked = False
        CkBxBloqueo.Checked = False

        btnModifyClient.Visible = False
        btnDeleteClient.Visible = False
        PanelMenuDataClient.Visible = False
        PanelContentMenu.Visible = False

    End Sub

    Public Sub ShowButtons()

        btnModifyClient.Visible = Permissions.Contains("CAM")
        btnDeleteClient.Visible = Permissions.Contains("ELI")

        PanelMenuDataClient.Visible = True
        PanelContentMenu.Visible = True

    End Sub

#End Region

#Region "Methods of events"

    Private Sub FrmClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Permissions.Contains("DES") = False Then

            MsgBox("No tiene permiso de ingresar a este modulo", MsgBoxStyle.Information)
            Me.Close()

        Else

            btnAddClient.Visible = Permissions.Contains("INS")
            btnExportData.Visible = Permissions.Contains("LIS")

            btnAddTax.Visible = Permissions.Contains("INS")
            btnaddContactDetail.Visible = Permissions.Contains("INS")

            BtnModifyTax.Visible = Permissions.Contains("CAM")
            btnModifyContactDetails.Visible = Permissions.Contains("CAM")

            btnDeleteTaxData.Visible = Permissions.Contains("ELI")
            btnDeleteContact.Visible = Permissions.Contains("ELI")

        End If

    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click

        ScreenNewClient.ShowDialog()

    End Sub

    Private Sub btnModifyClient_Click(sender As Object, e As EventArgs) Handles btnModifyClient.Click

        With RepositoryClients

            .name = Me.NameClient
            .Street = Me.Street
            .NumberExterior = Me.NumberExterior
            .NumberInterior = Me.NumberInterior
            .Country = CountriesRepository.IdCountry(Me.Country)
            .State = StatesRepository.StateID(Me.State)
            .Municipality = MunicipalitiesRepository.MunicilityID(Me.Municipality)
            .Cologne = Me.Cologne
            .PostalCode = Me.PostalCode
            .telephone = Me.Telephone
            .Web = Me.Web
            .ClientAAA = Me.ClienteAAA
            .Blocking = Me.Blocking

            If .ModifyClient(IdClient) = True Then

                MsgBox(.messages, MsgBoxStyle.Information)
                PanelMenuDataClient.Visible = True
                PanelContentMenu.Visible = True

            Else

                MsgBox(.messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click

        With RepositoryClients

            If .DeleteClient(IdClient) = True Then

                MsgBox(.messages, MsgBoxStyle.Information)
                ClearForm()

            Else

                MsgBox(.messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub btnSelectClient_Click(sender As Object, e As EventArgs) Handles btnSelectClient.Click

        ScreenClientsRepository.ShowDialog()

    End Sub

    Private Sub btnExportData_Click(sender As Object, e As EventArgs) Handles btnExportData.Click

        ScreenExportData.ShowDialog()

    End Sub

    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged

        loadStates(Me.cbxCountry.Text)

    End Sub

    Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged

        loadMunicipalities(Me.cbxState.Text)

    End Sub

    Private Sub btnTaxData_Click(sender As Object, e As EventArgs) Handles menuItemTaxData.Click

        SelectMenuItem(sender)

    End Sub

    Private Sub btnAddTax_Click(sender As Object, e As EventArgs) Handles btnAddTax.Click

        With ScreenTaxData

            .ClientID = Me.IdClient
            .btnSave.Visible = True
            .btnModify.Visible = False
            .ShowDialog()

        End With

    End Sub

    Private Sub BtnModifyTax_Click(sender As Object, e As EventArgs) Handles BtnModifyTax.Click

        If Me.dgvTaxData.CurrentRow IsNot Nothing Then

            With ScreenTaxData

                .ClientID = Me.IdClient
                .Street = Me.dgvTaxData.CurrentRow.Cells(0).Value.ToString()
                .NumberExterior = Me.dgvTaxData.CurrentRow.Cells(1).Value.ToString()
                .NumberInterior = Me.dgvTaxData.CurrentRow.Cells(2).Value.ToString()
                .Country = Me.dgvTaxData.CurrentRow.Cells(3).Value.ToString()
                .State = Me.dgvTaxData.CurrentRow.Cells(4).Value.ToString()
                .Municipality = Me.dgvTaxData.CurrentRow.Cells(5).Value.ToString()
                .Cologne = Me.dgvTaxData.CurrentRow.Cells(6).Value.ToString()
                .PostalCode = Me.dgvTaxData.CurrentRow.Cells(7).Value.ToString()
                .RFC = Me.dgvTaxData.CurrentRow.Cells(8).Value.ToString()
                .CURP = Me.dgvTaxData.CurrentRow.Cells(9).Value.ToString()
                .btnSave.Visible = False
                .btnModify.Visible = True

                .ShowDialog()
            End With

        End If

    End Sub

    Private Sub btnDeleteTaxData_Click(sender As Object, e As EventArgs) Handles btnDeleteTaxData.Click

        If MsgBox("¿Eliminar Datos?", MsgBoxStyle.Question + vbYesNo) = vbYes Then

            If RepositoryTaxData.DeleteTaxData(IdClient) Then

                MsgBox(RepositoryTaxData.messages, MsgBoxStyle.Information)
                TaxDetail = RepositoryTaxData.getTaxData(IdClient)

            Else

                MsgBox(RepositoryTaxData.messages, MsgBoxStyle.Exclamation)

            End If

        End If

    End Sub

    Private Sub btnContactDetails_Click(sender As Object, e As EventArgs) Handles menuItemContactDetails.Click

        SelectMenuItem(sender)

    End Sub

    Private Sub btnaddContactDetail_Click(sender As Object, e As EventArgs) Handles btnaddContactDetail.Click

        With ScreenContacts

            .clientID = Me.IdClient
            .btnSave.Visible = True
            .btnModify.Visible = False
            .ShowDialog()

        End With

    End Sub

    Private Sub btnModifyContactDetails_Click(sender As Object, e As EventArgs) Handles btnModifyContactDetails.Click

        If Me.dgvContactsDetails.CurrentRow IsNot Nothing Then

            With ScreenContacts

                .clientID = Me.IdClient
                .btnSave.Visible = False
                .btnModify.Visible = True

                .ContactID = Me.dgvContactsDetails.CurrentRow.Cells(0).Value.ToString()
                .ContactName = Me.dgvContactsDetails.CurrentRow.Cells(1).Value.ToString()
                .Telephone = Me.dgvContactsDetails.CurrentRow.Cells(2).Value.ToString()
                .Extension = Me.dgvContactsDetails.CurrentRow.Cells(3).Value.ToString()
                .CellPhone = Me.dgvContactsDetails.CurrentRow.Cells(4).Value.ToString()
                .Email = Me.dgvContactsDetails.CurrentRow.Cells(5).Value.ToString()
                .Job = Me.dgvContactsDetails.CurrentRow.Cells(6).Value.ToString()

                .ShowDialog()

            End With

        End If

    End Sub

    Private Sub btnDeleteContact_Click(sender As Object, e As EventArgs) Handles btnDeleteContact.Click

        If Me.dgvContactsDetails.CurrentRow IsNot Nothing Then

            If MsgBox("¿Eliminar Contacto?", MsgBoxStyle.Question + vbYesNo) = vbYes Then

                RepositoryContacts.ContactID = Me.dgvContactsDetails.CurrentRow.Cells(0).Value

                If RepositoryContacts.DeleteContact(Me.IdClient) Then

                    MsgBox(RepositoryContacts.messages, MsgBoxStyle.Information)
                    contactsDirectory = RepositoryContacts.getContacts(Me.IdClient)

                Else

                    MsgBox(RepositoryContacts.messages, MsgBoxStyle.Exclamation)

                End If

            End If

        End If

    End Sub

    Private Sub menuItemFinancialData_Click(sender As Object, e As EventArgs) Handles menuItemFinancialData.Click

        SelectMenuItem(sender)

    End Sub

    Private Sub btnAddFinancialData_Click(sender As Object, e As EventArgs) Handles btnAddFinancialData.Click

        With ScreenFinancialData

            .ClientID = Me.IdClient
            .btnSave.Visible = True
            .btnModify.Visible = False
            .ShowDialog()

        End With

    End Sub

    Private Sub btnModifyFinancialData_Click(sender As Object, e As EventArgs) Handles btnModifyFinancialData.Click

        If Me.dgvFinancialData.CurrentRow IsNot Nothing Then

            With ScreenFinancialData

                .btnModify.Visible = True
                .btnSave.Visible = False

                .ClientID = Me.IdClient
                .LimitCredit = Me.dgvFinancialData.CurrentRow.Cells(0).Value
                .accountingLock = Me.dgvFinancialData.CurrentRow.Cells(1).Value
                .Moneda = Me.dgvFinancialData.CurrentRow.Cells(2).Value.ToString()

                .ShowDialog()

            End With

        End If

    End Sub

    Private Sub btnDeleteFinancialData_Click(sender As Object, e As EventArgs) Handles btnDeleteFinancialData.Click

        If Me.dgvFinancialData.CurrentRow IsNot Nothing Then

            If MsgBox("¿Eliminar información?", MsgBoxStyle.Question + vbYesNo) = vbYes Then

                If repositoryFinancialData.DeleteFinancialData(IdClient) = True Then

                    MsgBox(repositoryFinancialData.messages, MsgBoxStyle.Information)
                    FinancialData = repositoryFinancialData.getFinancialInformation(IdClient)

                Else

                    MsgBox(repositoryFinancialData.messages, MsgBoxStyle.Exclamation)

                End If

            End If

        End If

    End Sub

    Private Sub menuItemBankReferences_Click(sender As Object, e As EventArgs) Handles menuItemBankReferences.Click

        SelectMenuItem(sender)

    End Sub

    Private Sub btnAddBankReference_Click(sender As Object, e As EventArgs) Handles btnAddBankReference.Click

        With ScreenBankReferences

            .ClientID = Me.IdClient
            .btnSave.Visible = True
            .btnModify.Visible = False
            .ShowDialog()

        End With

    End Sub

    Private Sub btnModifyBankReference_Click(sender As Object, e As EventArgs) Handles btnModifyBankReference.Click

        If Me.dgvBankReferences.CurrentRow IsNot Nothing Then

            With ScreenBankReferences

                .btnSave.Visible = False
                .btnModify.Visible = True

                .ClientID = Me.IdClient
                .Id = Me.dgvBankReferences.CurrentRow.Cells(0).Value
                .BankName = Me.dgvBankReferences.CurrentRow.Cells(1).Value.ToString()
                .RazonSocial = Me.dgvBankReferences.CurrentRow.Cells(2).Value.ToString()
                .BranchOffice = Me.dgvBankReferences.CurrentRow.Cells(3).Value.ToString()
                .account = Me.dgvBankReferences.CurrentRow.Cells(4).Value.ToString()
                .ContactName = Me.dgvBankReferences.CurrentRow.Cells(5).Value.ToString()
                .Job = Me.dgvBankReferences.CurrentRow.Cells(6).Value.ToString()
                .Telephone = Me.dgvBankReferences.CurrentRow.Cells(7).Value.ToString()
                .Extension = Me.dgvBankReferences.CurrentRow.Cells(8).Value.ToString()
                .CellPhone = Me.dgvBankReferences.CurrentRow.Cells(9).Value.ToString()
                .Country = Me.dgvBankReferences.CurrentRow.Cells(10).Value.ToString()
                .State = Me.dgvBankReferences.CurrentRow.Cells(11).Value.ToString
                .Municipality = Me.dgvBankReferences.CurrentRow.Cells(12).Value.ToString()
                .Cologne = Me.dgvBankReferences.CurrentRow.Cells(13).Value.ToString()
                .PostalCode = Me.dgvBankReferences.CurrentRow.Cells(14).Value.ToString()
                .Street = Me.dgvBankReferences.CurrentRow.Cells(15).Value.ToString()
                .NumberExterno = Me.dgvBankReferences.CurrentRow.Cells(16).Value.ToString()
                .NumberInterno = Me.dgvBankReferences.CurrentRow.Cells(17).Value.ToString()
                .ShowDialog()

            End With

        End If

    End Sub

    Private Sub btnDeleteBankReference_Click(sender As Object, e As EventArgs) Handles btnDeleteBankReference.Click

        If Me.dgvBankReferences.CurrentRow IsNot Nothing Then

            If MsgBox("¿Eliminar referencia?", MsgBoxStyle.Question + vbYesNo) = vbYes Then

                repositoryBankReferences.Id = Me.dgvBankReferences.CurrentRow.Cells(0).Value

                If repositoryBankReferences.DeleteBankReference(Me.IdClient) Then

                    MsgBox(repositoryBankReferences.messages, MsgBoxStyle.Information)
                    BankReferences = repositoryBankReferences.getBankReferences(IdClient)

                Else

                    MsgBox(repositoryBankReferences.messages, MsgBoxStyle.Exclamation)

                End If

            End If

        End If

    End Sub

#End Region

#Region "Design"

    Private Sub SelectMenuItem(ByRef sender As Button)

        Dim backColorSelected As Color = Color.SteelBlue

        sender.BackColor = backColorSelected
        sender.ForeColor = Color.White

        For Each control As Control In PanelMenuDataClient.Controls

            If TypeOf control Is Button Then

                If sender IsNot control Then

                    control.BackColor = Color.White
                    control.ForeColor = Color.Black

                End If

            End If

        Next


        For Each control As Control In PanelContentMenu.Controls

            If TypeOf control Is Panel Then

                If sender.Tag = control.Tag Then

                    control.Visible = True
                    control.Dock = DockStyle.Fill

                Else

                    control.Visible = False

                End If

            End If

        Next

    End Sub

#End Region

End Class