Imports ClientDb
Imports LocationsDb.Coutries
Imports LocationsDb.States
Imports LocationsDb.Municipalities
Public Class FrmTaxData

#Region "fields and propierties"

	Private repository As ClientTaxData
	Private countriesRepository As Countries
	Private statesRepository As States
	Private municipalitiesRepository As Municipalities

	Private _ClientID As Integer

	Public WriteOnly Property ClientID As Integer
		Set(value As Integer)

			_ClientID = value

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

			'loadStates(value)
			cbxCountry.Text = value

		End Set
	End Property

	Public Property State As String
		Get

			Return Trim(cbxState.Text)

		End Get
		Set(value As String)

			'loadMunicipalities(value)
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
	Public Property RFC As String
		Get

			Return Trim(cdtRFC.Text)

		End Get
		Set(value As String)

			cdtRFC.Text = value

		End Set
	End Property

	Public Property CURP As String
		Get

			Return Trim(cdtCURP.Text)

		End Get
		Set(value As String)

			cdtCURP.Text = value

		End Set
	End Property

#End Region

#Region "Builders"

	Public Sub New(ConnectionString As String)

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		repository = ClientTaxData.getInstance(ConnectionString)
		countriesRepository = Countries.getInstance(ConnectionString)
		statesRepository = States.getInstance(ConnectionString)
		municipalitiesRepository = Municipalities.getInstance(ConnectionString)
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

	Private Sub Save()

		With repository

			.RFC = Me.RFC
			.CURP = Me.CURP
			.Country = countriesRepository.IdCountry(Country)
			.State = statesRepository.StateID(State)
			.Municipality = municipalitiesRepository.MunicilityID(Municipality)
			.Cologne = Me.Cologne
			.PostalCode = Me.PostalCode
			.Street = Me.Street
			.NumberExterior = Me.NumberExterior
			.NumberInterior = Me.NumberInterior

			If .SaveTaxData(_ClientID) = True Then

				MsgBox(.Messages, MsgBoxStyle.Information)

				CType(Me.Owner, FrmClients).TaxDetail = repository.getTaxData(_ClientID)
				ClearForm()
				Me.Close()

			Else

				MsgBox(.messages, MsgBoxStyle.Exclamation)

			End If


		End With

	End Sub

	Private Sub Modify()

		With repository

			.RFC = Me.RFC
			.CURP = Me.CURP
			.Country = countriesRepository.IdCountry(Country)
			.State = statesRepository.StateID(State)
			.Municipality = municipalitiesRepository.MunicilityID(Municipality)
			.Cologne = Me.Cologne
			.PostalCode = Me.PostalCode
			.Street = Me.Street
			.NumberExterior = Me.NumberExterior
			.NumberInterior = Me.NumberInterior

			If .ModifyTaxData(_ClientID) = True Then

				MsgBox(.Messages, MsgBoxStyle.Information)
				CType(Me.Owner, FrmClients).TaxDetail = repository.getTaxData(_ClientID)
				ClearForm()
				Me.Close()

			Else

				MsgBox(.Messages, MsgBoxStyle.Exclamation, "Error")

			End If

		End With

	End Sub

	Private Sub ClearForm()

		RFC = Nothing
		CURP = Nothing
		Municipality = Nothing
		State = Nothing
		Country = Nothing
		Cologne = Nothing
		PostalCode = Nothing
		Street = Nothing
		NumberExterior = Nothing
		NumberInterior = Nothing
		CheckBox1.Checked = False

	End Sub

#End Region

#Region "Methods of events"

	Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged

		loadStates(cbxCountry.Text)

	End Sub

	Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged

		loadMunicipalities(cbxState.Text)

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Save()

	End Sub

	Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

		Modify()

	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

		If CheckBox1.Checked = True Then

			With CType(Me.Owner, FrmClients)

				Me.Street = .Street
				Me.NumberExterior = .NumberExterior
				Me.NumberInterior = .NumberInterior
				Me.Country = .Country
				Me.State = .State
				Me.Municipality = .Municipality
				Me.Cologne = .Cologne
				Me.PostalCode = .PostalCode

			End With

		End If

	End Sub

	Private Sub FrmTaxData_Closed(sender As Object, e As EventArgs) Handles Me.Closed

		ClearForm()

	End Sub

#End Region

End Class