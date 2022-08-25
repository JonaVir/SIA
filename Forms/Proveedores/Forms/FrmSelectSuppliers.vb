Imports ProveedoresDb
Public Class FrmSelectSuppliers

#Region "Fields and properties"

    Private suppliersRepository As Suppliers
    Private SupplierContactsRepository As SupplierContacts
    Private SupplierBankDetailsRepository As SuppliersBankDetails
    Private Permissions As String

    Private WriteOnly Property listOfSuppliers As DataTable
        Set(value As DataTable)

            If value IsNot Nothing Then

                With dgvSuppliers

                    .DataSource = value
                    .Columns(2).Visible = False
                    .Columns(3).Visible = False
                    .Columns(4).Visible = False
                    .Columns(5).Visible = False
                    .Columns(6).Visible = False
                    .Columns(7).Visible = False
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(10).Visible = False
                    .Columns(11).Visible = False
                    .Columns(12).Visible = False
                    .Columns(13).Visible = False
                    .Columns(14).Visible = False

                End With

            End If

        End Set
    End Property

    Private ReadOnly Property SupplierID As Integer
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(0).Value

            Else

                Return 0

            End If

        End Get
    End Property

    Private ReadOnly Property SupplierName As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return dgvSuppliers.CurrentRow.Cells(1).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Street As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(2).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property InteriorNumber As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(3).Value.ToString

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property OutdoorNumber As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(4).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Colony As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(5).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Municipality As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(6).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property State As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(7).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Country As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(8).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property PostalCode As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(9).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Telephone As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(10).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Web As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(11).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property RFC As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(12).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property CURP As String
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return Me.dgvSuppliers.CurrentRow.Cells(13).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Status As Boolean
        Get

            If Me.dgvSuppliers.CurrentRow IsNot Nothing Then

                Return CBool(Me.dgvSuppliers.CurrentRow.Cells(14).Value)

            Else

                Return False

            End If
        End Get
    End Property

#End Region

#Region "Builders"

    Public Sub New(Repository As Suppliers, Contacts As SupplierContacts, BankDetails As SuppliersBankDetails, permissions As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        suppliersRepository = Repository
        SupplierContactsRepository = Contacts
        SupplierBankDetailsRepository = BankDetails

        Me.Permissions = permissions

    End Sub

#End Region

#Region "Methods"

    Private Sub loadSuppliers()

        listOfSuppliers = suppliersRepository.listOfSuppliers

    End Sub
    Private Sub SelectData()

        With CType(Me.Owner, FrmProveedores)

            .MainPanel.Visible = True
            .PanelContentMenu.Visible = True
            .PanelMenuDataSuppliers.Visible = True
            .SupplierID = SupplierID
            .SupplierName = SupplierName
            .Telephone = Telephone
            .Status = Status
            .Web = Web
            .RFC = RFC
            .CURP = CURP
            .Street = Street
            .InteriorNumber = InteriorNumber
            .outdoorNumber = OutdoorNumber
            .Country = Country
            .State = State
            .Municipality = Municipality
            .Colony = Colony
            .PostalCode = PostalCode
            .ListOfContacts = SupplierContactsRepository.getContacts(SupplierID)
            .ListOfBankDetails = SupplierBankDetailsRepository.getAccounts(SupplierID)
            .UpdatePermission = Permissions.Contains("CAM")
            .DeletePermission = Permissions.Contains("ELI")

        End With

    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click

        SelectData()
        Me.Close()

    End Sub

#End Region

#Region "Methods of events"

    Private Sub FrmSelectSuppliers_Load(sender As Object, e As EventArgs) Handles Me.Load

        loadSuppliers()

    End Sub

    Private Sub cdtFilter_TextChanged(sender As Object, e As EventArgs) Handles cdtFilter.TextChanged

        If cbxFilter.Text <> Nothing Then

            listOfSuppliers = suppliersRepository.Filter(cbxFilter.Text, cdtFilter.Text)

        End If

    End Sub

    Private Sub cbxFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFilter.SelectedIndexChanged

        If cbxFilter.Text = "Activo" Or cbxFilter.Text = "Inactivo" Then

            listOfSuppliers = suppliersRepository.Filter("Activo", cbxFilter.Text)
            cdtFilter.Visible = False

        Else

            cdtFilter.Visible = True

        End If

    End Sub

#End Region

End Class