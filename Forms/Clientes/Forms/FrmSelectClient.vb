Imports ClientDb
Public Class FrmSelectClient

#Region "fields and propierties"

    Private ClientRepository As Clients
    Private TaxDataRepository As ClientTaxData
    Private ContactsRepository As ClientContact
    Private FinancialDataRepository As ClientFinancialData
    Private BankReferencesRepository As ClientBankReferences

    Private table As DataTable
    Private filterView As DataView

    Private ReadOnly Property Id As Integer
        Get

            If dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(0).Value

            Else

                Return 0

            End If

        End Get
    End Property

    Private ReadOnly Property NameClient As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(1).Value

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Street As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(2).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property NumberExterior As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(3).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property NumberInterior As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(4).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Country As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(5).Value.ToString()

            Else

                Return Nothing

            End If

        End Get
    End Property

    Private ReadOnly Property State As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(6).Value.ToString()

            Else

                Return Nothing

            End If

        End Get
    End Property

    Private ReadOnly Property Municipality As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(7).Value.ToString()

            Else

                Return Nothing

            End If

        End Get
    End Property

    Private ReadOnly Property Cologne As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(8).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property PostalCode As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(9).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Telephone As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(10).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property Web As String
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return dgvClients.CurrentRow.Cells(11).Value.ToString()

            Else

                Return ""

            End If

        End Get
    End Property

    Private ReadOnly Property ClientAAA As Boolean
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return CBool(dgvClients.CurrentRow.Cells(12).Value)

            Else

                Return False

            End If

        End Get
    End Property

    Private ReadOnly Property Blocking As Boolean
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Return CBool(dgvClients.CurrentRow.Cells(13).Value)

            Else

                Return False

            End If

        End Get
    End Property

    Private ReadOnly Property TaxData As DataTable
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Dim table As DataTable = TaxDataRepository.getTaxData(Id)

                If table IsNot Nothing Then

                    Return table

                Else

                    Return Nothing

                End If

            Else

                Return Nothing

            End If

        End Get
    End Property

    Private ReadOnly Property Contacts As DataTable
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Dim table As DataTable = ContactsRepository.getContacts(Id)

                Return table

            Else

                Return Nothing

            End If

        End Get
    End Property

    Private ReadOnly Property FinancialData As DataTable
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Dim table As DataTable = FinancialDataRepository.getFinancialInformation(Id)

                Return table

            Else

                Return table

            End If

        End Get
    End Property

    Private ReadOnly Property BankReferences As DataTable
        Get

            If Me.dgvClients.CurrentRow IsNot Nothing Then

                Dim table = BankReferencesRepository.getBankReferences(Id)
                Return table

            Else

                Return Nothing

            End If

        End Get
    End Property


#End Region

#Region "Builders"

    Public Sub New(connectionString As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.ClientRepository = Clients.getInstance(connectionString)
        Me.TaxDataRepository = ClientTaxData.getInstance(connectionString)
        Me.ContactsRepository = ClientContact.getInstance(connectionString)
        Me.FinancialDataRepository = ClientFinancialData.getInstance(connectionString)
        Me.BankReferencesRepository = ClientBankReferences.getInstance(connectionString)

        filterView = New DataView()

        With filterView

            .AllowDelete = False
            .AllowEdit = False
            .AllowNew = False
            .ApplyDefaultSort = True

        End With

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadClients()

        table = ClientRepository.listOfClients

        If table IsNot Nothing Then

            'Vista para filtrar información
            table.TableName = "Clientes"
            filterView.Table = table

            With dgvClients

                .DataSource = table
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

            End With

            Me.cbxFilter.Items.Clear()
            Me.cbxFilter.Items.Add("")

            For Each columns As DataColumn In table.Columns

                Me.cbxFilter.Items.Add(columns.ColumnName)

            Next

        End If

    End Sub

    Private Sub SelectData()

        With CType(Me.Owner, FrmClients)

            .ShowButtons()
            .PanelContentMenu.Visible = True
            .PanelMenuDataClient.Visible = True

            .IdClient = Me.Id
            .NameClient = Me.NameClient
            .Street = Me.Street
            .NumberExterior = Me.NumberExterior
            .NumberInterior = Me.NumberInterior
            .Country = Me.Country
            .State = Me.State
            .Municipality = Me.Municipality
            .Cologne = Me.Cologne
            .PostalCode = Me.PostalCode
            .Telephone = Me.Telephone
            .Web = Me.Web
            .ClienteAAA = Me.ClientAAA
            .Blocking = Me.Blocking
            .TaxDetail = Me.TaxData
            .contactsDirectory = Me.Contacts
            .FinancialData = Me.FinancialData
            .BankReferences = Me.BankReferences

        End With
    End Sub

#End Region

#Region "Methods of events"

    Private Sub FrmSelectClient_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadClients()

    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click

        If Me.dgvClients.CurrentRow IsNot Nothing Then

            SelectData()
            Me.Close()

        End If



    End Sub

    Private Sub FrmSelectClient_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        cbxFilter.Text = Nothing
        cdtFilter.Text = Nothing

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFilter.SelectedIndexChanged

        If cbxFilter.Text = "ClienteAAA" Then

            cdtFilter.Visible = False

            Me.dgvClients.DataSource = ClientRepository.filter(cbxFilter.Text, True)

        ElseIf cbxFilter.Text = "Bloqueo" Then

            cdtFilter.Visible = False
            Me.dgvClients.DataSource = ClientRepository.filter(cbxFilter.Text, True)


        Else

            If cbxFilter.Text = "" Then

                dgvClients.DataSource = table

            Else

                Me.dgvClients.DataSource = ClientRepository.filter(cbxFilter.Text, "")
                cdtFilter.Visible = True

            End If

        End If

    End Sub

    Private Sub cdtFilter_TextChanged(sender As Object, e As EventArgs) Handles cdtFilter.TextChanged

        If cbxFilter.Text <> "" Then

            Me.dgvClients.DataSource = ClientRepository.filter(cbxFilter.Text, cdtFilter.Text)

        End If

    End Sub

#End Region

End Class