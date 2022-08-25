Imports System.Data.SqlClient
Public Class ClientFinancialData
    Inherits MasterRepository

#Region "fields and properties"

	Public Shared myInstance As ClientFinancialData

	Private clientID As Integer
	Private _LimitCredit As Double
	Private _accountingLock As Boolean
	Private _currency As String

	Public WriteOnly Property LimitCredit As Double
		Set(value As Double)

			_LimitCredit = value

		End Set
	End Property

	Public WriteOnly Property AccountingLock As Boolean
		Set(value As Boolean)

			_accountingLock = value

		End Set
	End Property

	Public WriteOnly Property Currency As String
		Set(value As String)

			_currency = value

		End Set
	End Property

#End Region

#Region "Builders"

	Private Sub New(ConnectionString As String)

		setConnection(ConnectionString)

	End Sub

#End Region

#Region "Methods"

	Public Function getFinancialInformation(clientID As Integer) As DataTable

		Query = "SP_ObtenerDatosFinancierosCliente"

		parameters = New SqlParameter("@idCliente", clientID)

		Return ExecuteRead(IDbAdapter.typeQuery.StoredProcedure)

	End Function

	Public Function SaveFinancialData(clientID As Integer) As Boolean

		Me.clientID = clientID

		If ValidateData(TypeValidation.InsertQuery) Then

			Query = "SP_GuardarDatosFinancierosCliente"


			parameters = New SqlParameter("@idCliente", clientID)
			parameters = New SqlParameter("@LimiteCredito", _LimitCredit)
			parameters = New SqlParameter("@moneda", _currency)
			parameters = New SqlParameter("@Bloqueo", _accountingLock)

			If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

				_Messages = "Datos registrados correctamente"
				Return True

			Else

				Return False

			End If

		Else

			Return False

		End If

	End Function

	Public Function ModifyFinancialData(clientID As Integer) As Boolean

		Me.clientID = clientID
		If ValidateData(TypeValidation.UpdateQuery) = True Then

			Query = "SP_ModificarDatosFinancierosCliente"

			parameters = New SqlParameter("@idCliente", clientID)
			parameters = New SqlParameter("@LimiteCredito", _LimitCredit)
			parameters = New SqlParameter("@moneda", _currency)
			parameters = New SqlParameter("@Bloqueo", _accountingLock)

			If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

				_Messages = "Datos Modificados correctamente"
				Return True

			Else

				Return False

			End If

		Else

			Return False

		End If

	End Function

	Public Function DeleteFinancialData(clientID As Integer) As Boolean

		Me.clientID = clientID

		If ValidateData(TypeValidation.DeleteQuery) Then

			Query = "Delete DatosFinacierosClientes where idcliente = @id"
			parameters = New SqlParameter("@id", clientID)

			If ExecuteQuery() > 0 Then

				_Messages = "Datos eliminados correctamente"
				Return True

			Else

				Return False

			End If

		Else

			Return False

		End If

	End Function

	Public Shared Function getInstance(connectionString) As ClientFinancialData

		If myInstance Is Nothing Then

			myInstance = New ClientFinancialData(connectionString)

		End If

		Return myInstance

	End Function

	Protected Overrides Function ValidateData(value As TypeValidation, Optional method As String = "") As Boolean
		Dim flag As Boolean = True
		_Messages = "Los siguientes campos son obligatorios" & vbNewLine

		Select Case value

			Case TypeValidation.InsertQuery

				If clientID = 0 Then

					flag = False
					_Messages &= "	- ID Cliente" & vbNewLine

				End If

				If _LimitCredit = 0 Then

					flag = False
					_Messages &= "	- Limite de credito" & vbNewLine

				End If

				If _currency = Nothing Then

					flag = False
					_Messages &= "	- Moneda" & vbNewLine

				End If

			Case TypeValidation.UpdateQuery

				If clientID = 0 Then

					flag = False
					_Messages &= "	- ID Cliente" & vbNewLine

				End If

				If _LimitCredit = 0 Then

					flag = False
					_Messages &= "	- Limite de credito" & vbNewLine

				End If

				If _currency = Nothing Then

					flag = False
					_Messages &= "	- Moneda" & vbNewLine

				End If

			Case TypeValidation.DeleteQuery

				If clientID = 0 Then

					flag = False
					_Messages &= "	- ID Cliente" & vbNewLine

				End If

		End Select

		_Messages &= "Favor de especificarlos"

		Return flag
	End Function

#End Region

End Class
