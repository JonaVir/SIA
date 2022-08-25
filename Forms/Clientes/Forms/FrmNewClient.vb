Imports ClientDb
Imports LocationsDb.Coutries
Imports LocationsDb.States
Imports LocationsDb.Municipalities

Public Class FrmNewClient

#Region "fields and propierties"

    Private repository As Clients

    Private countriesRepository As Countries
    Private statesRepository As States
    Private municipalitiesRepository As Municipalities

    Private IdClient As Integer

    Private ReadOnly Property NameClient As String
        Get

            Return Trim(cdtNameClient.Text)

        End Get
    End Property

    Private ReadOnly Property Street As String
        Get

            Return Trim(cdtStreetClient.Text)

        End Get
    End Property

    Private ReadOnly Property NumberExterior As String
        Get

            Return Trim(cdtNumberExterior.Text)

        End Get
    End Property

    Private ReadOnly Property NumberInterior As String
        Get

            Return Trim(cdtNumberInterior.Text)

        End Get
    End Property

    Private ReadOnly Property Country As String
        Get

            Return Trim(cbxCountry.Text)

        End Get
    End Property

    Private ReadOnly Property State As String
        Get

            Return Trim(cbxState.Text)

        End Get
    End Property

    Private ReadOnly Property Municipality As String
        Get

            Return Trim(cbxMunicipality.Text)

        End Get
    End Property

    Private ReadOnly Property Cologne As String
        Get

            Return Trim(cdtCologne.Text)

        End Get
    End Property

    Private ReadOnly Property PostalCode As String
        Get

            Return Trim(cdtPostalCode.Text)

        End Get
    End Property

    Private ReadOnly Property Telephone As String
        Get

            Return Trim(cdtTelephone.Text)

        End Get
    End Property

    Private ReadOnly Property Web As String
        Get

            Return Trim(cdtWeb.Text)

        End Get
    End Property

    Private ReadOnly Property ClienteAAA As Boolean
        Get

            Return ckBxClientAAA.Checked

        End Get
    End Property

    Private ReadOnly Property Blocking As Boolean
        Get

            Return CkBxBloqueo.Checked

        End Get
    End Property

#End Region

#Region "Builders"

    Public Sub New(connectionStirng As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        repository = Clients.getInstance(connectionStirng)

        countriesRepository = Countries.getInstance(connectionStirng)
        statesRepository = States.getInstance(connectionStirng)
        municipalitiesRepository = Municipalities.getInstance(connectionStirng)

        LoadCountries()

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadCountries()

        Dim table As DataTable = countriesRepository.listOfCountries

        For Each row As DataRow In table.Rows

            Me.cbxCountry.Items.Add(row.Item(2).ToString())

        Next

    End Sub

    Private Sub loadStates(nameCountry As String)

        Dim id As Integer = countriesRepository.IdCountry(nameCountry)
        Dim table As DataTable = statesRepository.getEstates(id)

        Me.cbxState.Items.Clear()


        If table IsNot Nothing Then

            For Each row As DataRow In table.Rows

                Me.cbxState.Items.Add(row.Item(3).ToString())

            Next

        End If

    End Sub

    Private Sub loadMunicipalities(nameState As String)

        Dim id As Integer = statesRepository.StateID(nameState)

        Dim table As DataTable = municipalitiesRepository.getMunicipalities(id)

        cbxMunicipality.Items.Clear()

        If table IsNot Nothing Then

            For Each row As DataRow In table.Rows

                Me.cbxMunicipality.Items.Add(row.Item(4).ToString())

            Next

        End If

    End Sub

    Private Sub saveClient()

        With repository

            .name = Me.NameClient
            .Street = Me.Street
            .NumberExterior = Me.NumberExterior
            .NumberInterior = Me.NumberInterior
            .Country = countriesRepository.IdCountry(Me.Country)
            .State = statesRepository.StateID(Me.State)
            .Municipality = municipalitiesRepository.MunicilityID(Me.Municipality)
            .Cologne = Me.Cologne
            .PostalCode = Me.PostalCode
            .telephone = Me.Telephone
            .Web = Me.Web
            .ClientAAA = Me.ClienteAAA
            .Blocking = Me.Blocking

            If .SaveClient(IdClient) = True Then

                MsgBox(.messages, MsgBoxStyle.Information)

                With CType(Me.Owner, FrmClients)

                    .ShowButtons()

                    .IdClient = Me.IdClient
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
                    .ClienteAAA = Me.ClienteAAA
                    .Blocking = Me.Blocking

                End With

                Me.Close()

            Else

                MsgBox(.messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub clearForm()

        cdtNameClient.Text = Nothing
        cdtTelephone.Text = Nothing
        ckBxClientAAA.Checked = False
        CkBxBloqueo.Checked = False
        cdtWeb.Text = Nothing
        cdtStreetClient.Text = Nothing
        cdtNumberExterior.Text = Nothing
        cdtNumberInterior.Text = Nothing
        cbxCountry.Text = Nothing
        cbxState.Text = Nothing
        cbxMunicipality.Text = Nothing
        cdtCologne.Text = Nothing
        cdtPostalCode.Text = Nothing

    End Sub

#End Region

#Region "Methods of events"
    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged

        loadStates(Me.cbxCountry.Text)

    End Sub

    Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged

        loadMunicipalities(Me.cbxState.Text)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        saveClient()

    End Sub

    Private Sub FrmNewClient_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        If IdClient <> 0 Then

            With CType(Me.Owner, FrmClients)

                .TaxDetail = Nothing
                .contactsDirectory = Nothing

            End With

        End If

        clearForm()

    End Sub

#End Region

End Class