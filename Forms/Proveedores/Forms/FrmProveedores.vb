Imports LocationsDb.Coutries
Imports LocationsDb.States
Imports LocationsDb.Municipalities
Imports ProveedoresDb

Public Class FrmProveedores

#Region "Fields and propierties"

    Private ConnectionString As String
    Private Permissions As String
    Private UserID As String

    Private CountriesRepository As Countries
    Private StateRepository As States
    Private MunicipalitiesRepository As Municipalities
    Private SuppliersRepository As Suppliers
    Private SuppliersContactsRepository As SupplierContacts
    Private SuppliersBankDetailsRepository As SuppliersBankDetails

    Private ScreenSuppliersContacts As FrmSupliersContacts
    Private ScreenSuppliersBankDetails As FrmSuppliersBankDetails
    Private ScreenSelectSuppliers As FrmSelectSuppliers

    Public WriteOnly Property insertPermission As Boolean
        Set(value As Boolean)

            btnAddSupplier.Visible = value
            btnAddContact.Visible = value
            btnaddBankDetail.Visible = value

        End Set
    End Property

    Public WriteOnly Property UpdatePermission As Boolean
        Set(value As Boolean)

            btnModifySupplier.Visible = value
            btnModifyBankDetail.Visible = value
            BtnModifyContact.Visible = value

        End Set
    End Property

    Public WriteOnly Property DeletePermission As Boolean
        Set(value As Boolean)

            btnDeleteSupplier.Visible = value
            btnDeleteContact.Visible = value
            btnDeleteBankDetail.Visible = value

        End Set
    End Property

    Public WriteOnly Property ExportDataPermission As Boolean
        Set(value As Boolean)

            btnExportData.Visible = value

        End Set
    End Property


    Private _SupplierID As Integer

    Public Property SupplierID As Integer
        Get

            Return _SupplierID

        End Get
        Set(value As Integer)

            _SupplierID = value

        End Set
    End Property

    Public Property SupplierName As String
        Get

            Return Trim(cdtSupplierName.Text)

        End Get
        Set(value As String)

            cdtSupplierName.Text = Trim(value)
        End Set
    End Property

    Public Property Telephone As String
        Get

            Return Trim(cdtTelephone.Text)

        End Get
        Set(value As String)

            cdtTelephone.Text = Trim(value)

        End Set
    End Property

    Public Property Status As Boolean
        Get

            Return CkBxActivo.Checked

        End Get
        Set(value As Boolean)

            CkBxActivo.Checked = value

        End Set
    End Property

    Public Property Web As String
        Get

            Return Trim(cdtWeb.Text)

        End Get
        Set(value As String)

            cdtWeb.Text = Trim(value)

        End Set
    End Property

    Public Property RFC As String
        Get

            Return Trim(cdtRFC.Text)

        End Get
        Set(value As String)

            cdtRFC.Text = Trim(value)

        End Set
    End Property

    Public Property CURP As String
        Get

            Return Trim(CdtCURP.Text)

        End Get
        Set(value As String)

            CdtCURP.Text = Trim(value)

        End Set
    End Property

    Public Property Street As String
        Get

            Return Trim(cdtStreet.Text)

        End Get
        Set(value As String)

            cdtStreet.Text = Trim(value)

        End Set
    End Property
    Public Property InteriorNumber As String
        Get

            Return Trim(cdtNumberInterior.Text)

        End Get
        Set(value As String)

            cdtNumberInterior.Text = Trim(value)

        End Set
    End Property

    Public Property outdoorNumber As String
        Get

            Return Trim(cdtNumberExterior.Text)

        End Get
        Set(value As String)

            cdtNumberExterior.Text = Trim(value)

        End Set
    End Property

    Public Property Country As String
        Get

            Return cbxCountry.Text

        End Get
        Set(value As String)

            cbxCountry.Text = value

        End Set
    End Property

    Public Property State As String
        Get

            Return cbxState.Text

        End Get
        Set(value As String)

            cbxState.Text = value

        End Set
    End Property

    Public Property Municipality As String
        Get

            Return cbxMunicipality.Text

        End Get
        Set(value As String)

            cbxMunicipality.Text = value

        End Set
    End Property

    Public Property Colony As String
        Get

            Return cdtColony.Text

        End Get
        Set(value As String)

            cdtColony.Text = value

        End Set
    End Property

    Public Property PostalCode As String
        Get

            Return cdtPostalCode.Text

        End Get
        Set(value As String)

            cdtPostalCode.Text = value

        End Set
    End Property

    Public WriteOnly Property ListOfContacts As DataTable
        Set(value As DataTable)

            If value IsNot Nothing Then

                dgvContacts.DataSource = value

                dgvContacts.Columns(1).Visible = False

            Else

                dgvContacts.DataSource = Nothing

            End If

        End Set
    End Property

    Public WriteOnly Property ListOfBankDetails As DataTable
        Set(value As DataTable)

            dgvBankDetails.DataSource = value

        End Set
    End Property

#End Region

#Region "Builders"

    Public Sub New(ConnectionString As String, UserID As String, Permissions As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.ConnectionString = ConnectionString
        Me.Permissions = Permissions
        Me.UserID = UserID

        CountriesRepository = Countries.getInstance(ConnectionString)
        StateRepository = States.getInstance(ConnectionString)
        MunicipalitiesRepository = Municipalities.getInstance(ConnectionString)
        SuppliersRepository = Suppliers.getInstance(ConnectionString)
        SuppliersContactsRepository = SupplierContacts.getInstance(ConnectionString)
        SuppliersBankDetailsRepository = SuppliersBankDetails.getInstance(ConnectionString)

        ScreenSelectSuppliers = New FrmSelectSuppliers(SuppliersRepository, SuppliersContactsRepository, SuppliersBankDetailsRepository, Permissions)
        Me.AddOwnedForm(ScreenSelectSuppliers)

        ScreenSuppliersContacts = New FrmSupliersContacts(SuppliersContactsRepository)
        Me.AddOwnedForm(ScreenSuppliersContacts)

        ScreenSuppliersBankDetails = New FrmSuppliersBankDetails()
        Me.AddOwnedForm(ScreenSuppliersBankDetails)

        loadCountries()

        Me.ContainContacts.Dock = DockStyle.Fill

    End Sub


#End Region

#Region "Methods"

    Private Sub loadCountries()

        Dim table As DataTable = CountriesRepository.listOfCountries

        For Each row As DataRow In table.Rows

            Me.cbxCountry.Items.Add(row.Item(2).ToString())

        Next

    End Sub

    Private Sub loadStates(CountryName As String)

        Dim id As Integer = CountriesRepository.IdCountry(CountryName)

        Dim table As DataTable = StateRepository.getEstates(id)

        Me.cbxState.Items.Clear()

        If table IsNot Nothing Then

            For Each row As DataRow In table.Rows

                Me.cbxState.Items.Add(row.Item(3).ToString())

            Next

        End If

    End Sub

    Private Sub loadMunicipalities(StateName As String)

        Dim id As Integer = StateRepository.StateID(StateName)
        Dim table As DataTable = MunicipalitiesRepository.getMunicipalities(id)

        cbxMunicipality.Items.Clear()

        If table IsNot Nothing Then

            For Each row As DataRow In table.Rows

                Me.cbxMunicipality.Items.Add(row.Item(4).ToString())

            Next

        End If

    End Sub

    Private Sub SaveSupplier()

        With SuppliersRepository

            .Name = SupplierName
            .Telephone = Telephone
            .state = Status
            .Web = Web
            .RFC = RFC
            .Curp = CURP
            .Street = Street
            .InteriorNumber = InteriorNumber
            .outdoorNumber = outdoorNumber
            .country = CountriesRepository.IdCountry(Country)
            .state = StateRepository.StateID(State)
            .municipality = MunicipalitiesRepository.MunicilityID(Municipality)
            .Colony = Colony
            .postalCode = PostalCode

            If .Save(SupplierID) = True Then

                MsgBox(.Messages, MsgBoxStyle.Information)

                insertPermission = Permissions.Contains("INS")
                UpdatePermission = Permissions.Contains("CAM")
                DeletePermission = Permissions.Contains("ELI")
                ExportDataPermission = Permissions.Contains("LIS")

                btnSelectSupplier.Visible = True
                btnSaveSupplier.Visible = False
                btnCancel.Visible = False
                CkBxActivo.Visible = False
                CkBxActivo.Checked = True

                PanelContentMenu.Visible = True
                PanelMenuDataSuppliers.Visible = True

                dgvBankDetails.DataSource = Nothing
                dgvContacts.DataSource = Nothing

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub ModifySupplier()

        With SuppliersRepository

            .Name = SupplierName
            .Telephone = Telephone
            .Activo = Status
            .Web = Web
            .RFC = RFC
            .Curp = CURP
            .Street = Street
            .InteriorNumber = InteriorNumber
            .outdoorNumber = outdoorNumber
            .country = CountriesRepository.IdCountry(Country)
            .state = StateRepository.StateID(State)
            .municipality = MunicipalitiesRepository.MunicilityID(Municipality)
            .Colony = Colony
            .postalCode = PostalCode

            If .Modify(SupplierID) = True Then

                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub DeleteSupplier()

        With SuppliersRepository

            If .Delete(SupplierID) = True Then

                MsgBox(.Messages, MsgBoxStyle.Information)

                MainPanel.Visible = False
                PanelContentMenu.Visible = False
                PanelMenuDataSuppliers.Visible = False

                btnModifySupplier.Visible = False
                btnDeleteSupplier.Visible = False

                insertPermission = Permissions.Contains("INS")
                ExportDataPermission = Permissions.Contains("LIS")

                ClearForm()

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub ClearForm()

        cdtSupplierName.Text = Nothing
        cdtTelephone.Text = Nothing
        CkBxActivo.Checked = False
        cdtWeb.Text = Nothing
        cdtRFC.Text = Nothing
        CdtCURP.Text = Nothing
        cdtStreet.Text = Nothing
        cdtNumberInterior.Text = Nothing
        cdtNumberExterior.Text = Nothing
        cbxMunicipality.Text = Nothing
        cbxState.Text = Nothing
        cbxCountry.Text = Nothing
        cdtColony.Text = Nothing
        cdtPostalCode.Text = Nothing
        ListOfContacts = Nothing
        ListOfBankDetails = Nothing

    End Sub

#End Region

#Region "Methods of events"

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Permissions.Contains("DES") = False Then

            MsgBox("No tiene permiso de ingresar a este modulo", MsgBoxStyle.Exclamation)
            Me.Close()

        End If

        insertPermission = Permissions.Contains("INS")
        ExportDataPermission = Permissions.Contains("LIS")

    End Sub

    Private Sub btnSelectSupplier_Click(sender As Object, e As EventArgs) Handles btnSelectSupplier.Click

        ScreenSelectSuppliers.ShowDialog()

    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click

        MainPanel.Visible = True
        btnSaveSupplier.Visible = True
        btnCancel.Visible = True

        btnAddSupplier.Visible = False
        btnExportData.Visible = False
        btnSelectSupplier.Visible = False
        btnModifySupplier.Visible = False
        btnDeleteSupplier.Visible = False

        CkBxActivo.Visible = False
        PanelContentMenu.Visible = False
        PanelMenuDataSuppliers.Visible = False

        ClearForm()


    End Sub

    Private Sub btnSaveSupplier_Click(sender As Object, e As EventArgs) Handles btnSaveSupplier.Click

        SaveSupplier()

    End Sub

    Private Sub btnModifySupplier_Click(sender As Object, e As EventArgs) Handles btnModifySupplier.Click

        ModifySupplier()

    End Sub

    Private Sub btnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles btnDeleteSupplier.Click

        If MsgBox("¿Eliminar Proveedor?", MsgBoxStyle.Question + vbYesNo) = vbYes Then

            DeleteSupplier()


        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        MainPanel.Visible = False
        btnSaveSupplier.Visible = False
        btnCancel.Visible = False

        btnAddSupplier.Visible = True
        btnSelectSupplier.Visible = True
        btnExportData.Visible = Permissions.Contains("LIS")

    End Sub

    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged

        loadStates(Country)

    End Sub

    Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged

        loadMunicipalities(State)

    End Sub

    Private Sub menuItemContacts_Click(sender As Object, e As EventArgs) Handles menuItemContacts.Click

        SelectMenuItem(sender)

    End Sub

    Private Sub menuItemBankDetails_Click(sender As Object, e As EventArgs) Handles menuItemBankDetails.Click

        SelectMenuItem(sender)

    End Sub

    Private Sub btnAddContact_Click(sender As Object, e As EventArgs) Handles btnAddContact.Click

        ScreenSuppliersContacts.SupplierID = SupplierID
        ScreenSuppliersContacts.OpenAS = 1
        ScreenSuppliersContacts.ShowDialog()

    End Sub

    Private Sub BtnModifyContact_Click(sender As Object, e As EventArgs) Handles BtnModifyContact.Click

        If Me.dgvContacts.CurrentRow IsNot Nothing Then

            With ScreenSuppliersContacts

                .OpenAS = 2
                .SupplierID = SupplierID
                .ContactID = Me.dgvContacts.CurrentRow.Cells(0).Value.ToString()
                .ContactName = Me.dgvContacts.CurrentRow.Cells(2).Value.ToString()
                .Telephone = Me.dgvContacts.CurrentRow.Cells(3).Value.ToString()
                .Extension = Me.dgvContacts.CurrentRow.Cells(4).Value.ToString()
                .Cellphone = Me.dgvContacts.CurrentRow.Cells(5).Value.ToString()
                .Email = Me.dgvContacts.CurrentRow.Cells(6).Value.ToString()
                .JobPosition = Me.dgvContacts.CurrentRow.Cells(7).Value.ToString()

                ScreenSuppliersContacts.ShowDialog()

            End With


        End If

    End Sub

    Private Sub btnDeleteContact_Click(sender As Object, e As EventArgs) Handles btnDeleteContact.Click

        If Me.dgvContacts.CurrentRow IsNot Nothing AndAlso MsgBox("¿Eliminar Contacto?", MsgBoxStyle.Question + vbYesNo) = vbYes Then

            If SuppliersContactsRepository.delete(SupplierID, Me.dgvContacts.CurrentRow.Cells(0).Value) = True Then

                MsgBox(SuppliersContactsRepository.Messages, MsgBoxStyle.Information)
                ListOfContacts = SuppliersContactsRepository.getContacts(SupplierID)

            Else

                MsgBox(SuppliersContactsRepository.Messages, MsgBoxStyle.Exclamation)

            End If

        End If

    End Sub

#End Region

#Region "Design"

    Private Sub SelectMenuItem(ByRef sender As Button)

        Dim backColorSelected As Color = Color.SteelBlue

        sender.BackColor = backColorSelected
        sender.ForeColor = Color.White

        For Each control As Control In PanelMenuDataSuppliers.Controls

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