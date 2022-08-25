Imports System.Data.SqlClient

Public Class ClientTaxData
    Inherits MasterRepository

#Region "fields and propierties"

	Public Shared myInstance As ClientTaxData

	Private ClientID As Integer
	Private _Street As String
	Private _NumberExterior As String
	Private _NumberInterior As String
	Private _Country As Integer
	Private _State As Integer
	Private _Municipality As Integer
	Private _Cologne As String
	Private _PostalCode As String
	Private _RFC As String
	Private _CURP As String

	Public WriteOnly Property Street As String
		Set(value As String)

			_Street = Trim(value)

		End Set
	End Property

	Public WriteOnly Property NumberExterior As String
		Set(value As String)

			_NumberExterior = Trim(value)

		End Set
	End Property

	Public WriteOnly Property NumberInterior As String
		Set(value As String)

			_NumberInterior = Trim(value)

		End Set
	End Property

	Public WriteOnly Property Country As Integer
		Set(value As Integer)

			_Country = value

		End Set
	End Property

	Public WriteOnly Property State As Integer
		Set(value As Integer)

			_State = value

		End Set
	End Property

	Public WriteOnly Property Municipality As Integer
		Set(value As Integer)

			_Municipality = value

		End Set
	End Property

	Public WriteOnly Property Cologne As String
		Set(value As String)

			_Cologne = Trim(value)

		End Set
	End Property

	Public WriteOnly Property PostalCode As String
		Set(value As String)

			_PostalCode = Trim(value)

		End Set
	End Property

	Public WriteOnly Property RFC As String
		Set(value As String)

			If value <> Nothing Then

				_RFC = Trim(value)

			Else

				_RFC = Nothing

			End If

		End Set
	End Property

	Public WriteOnly Property CURP As String
		Set(value As String)

			If value <> Nothing Then

				_CURP = Trim(value)

			Else

				_CURP = Nothing

			End If

		End Set
	End Property

#End Region

#Region "Builders"

	Private Sub New(connectionString As String)

		setConnection(connectionString)

	End Sub

#End Region

#Region "Methods"

	Public Function getTaxData(clientID As Integer) As DataTable

		Query = "SP_ObtenerDatosFiscalesCliente"

		parameters = New SqlParameter("@idCliente", clientID)

		Return ExecuteRead(IDbAdapter.typeQuery.StoredProcedure)

	End Function

	Public Function SaveTaxData(ClientID As Integer) As Boolean

		Me.ClientID = ClientID

		If ValidateData(TypeValidation.InsertQuery) = True Then

			Query = "SP_GuardarDatosFiscalesClientes"

			parameters = New SqlParameter("@id", ClientID)
			parameters = New SqlParameter("@RFC", _RFC)
			parameters = New SqlParameter("@CURP", _CURP)
			parameters = New SqlParameter("@Pais", _Country)
			parameters = New SqlParameter("@Estado", _State)
			parameters = New SqlParameter("@Municipio", _Municipality)
			parameters = New SqlParameter("@Colonia", _Cologne)
			parameters = New SqlParameter("@CodigoPostal", _PostalCode)
			parameters = New SqlParameter("@Calle", _Street)
			parameters = New SqlParameter("@NumInterior", _NumberInterior)
			parameters = New SqlParameter("@NumExterior", _NumberExterior)

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

	Public Function ModifyTaxData(clientID As Integer) As Boolean

		Me.ClientID = clientID

		If ValidateData(TypeValidation.UpdateQuery) Then

			Query = "SP_ModificarDatosFiscalesCliente"

			parameters = New SqlParameter("@id", clientID)
			parameters = New SqlParameter("@RFC", _RFC)
			parameters = New SqlParameter("@CURP", _CURP)
			parameters = New SqlParameter("@Pais", _Country)
			parameters = New SqlParameter("@Estado", _State)
			parameters = New SqlParameter("@Municipio", _Municipality)
			parameters = New SqlParameter("@Colonia", _Cologne)
			parameters = New SqlParameter("@CodigoPostal", _PostalCode)
			parameters = New SqlParameter("@Calle", _Street)
			parameters = New SqlParameter("@NumInterior", _NumberInterior)
			parameters = New SqlParameter("@NumExterior", _NumberExterior)

			If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

				_Messages = "Datos Actualizados correctamente"

				Return True

			Else

				Return False

			End If

		Else

			Return False

		End If

	End Function

	Public Function DeleteTaxData(clientID As Integer) As Boolean

		Me.ClientID = clientID

		If ValidateData(TypeValidation.DeleteQuery) Then

			Query = "Delete DatosFiscalesClientes where idCliente = @id"

			parameters = New SqlParameter("@id", clientID)

			If ExecuteQuery() > 0 Then

				_Messages = "Datos eliminados correctamente"

				Return True

			Else

				_Messages = "Datos NO eliminados"
				Return False

			End If

		Else

			Return False

		End If

	End Function


	Public Shared Function getInstance(connectionString As String) As ClientTaxData

		If myInstance Is Nothing Then

			myInstance = New ClientTaxData(connectionString)

		End If

		Return myInstance

	End Function

	Protected Overrides Function ValidateData(value As TypeValidation, Optional method As String = "") As Boolean
		Dim flag As Boolean = True

		_Messages = "Los siguientes campos son obligatorios" & vbNewLine

		Select Case value
			Case TypeValidation.InsertQuery

				If ClientID = 0 Then

					flag = False
					_Messages &= "	- ID" & vbNewLine

				End If

				If String.IsNullOrEmpty(_RFC) = True Then

					flag = False
					_Messages &= "	- RFC" & vbNewLine

				End If

				If _Country = 0 Then

					flag = False
					_Messages &= "	- Pais" & vbNewLine

				End If

				If _State = 0 Then

					flag = False
					_Messages &= "	- Estado" & vbNewLine

				End If

				If _Municipality = 0 Then

					flag = False
					_Messages &= "	- Municipio" & vbNewLine

				End If

				If String.IsNullOrEmpty(_Cologne) = True Then

					flag = False
					_Messages &= "	- Colonia" & vbNewLine

				End If

				If String.IsNullOrEmpty(_PostalCode) = True Then

					flag = False
					_Messages &= "	- Codigo Postal " & vbNewLine

				End If

				If String.IsNullOrEmpty(_Street) = True Then

					flag = False
					_Messages &= "	- Calle" & vbNewLine

				End If

				If String.IsNullOrEmpty(_NumberExterior) = True Then

					flag = False
					_Messages &= "	- Numero Exterior" & vbNewLine

				End If

			Case TypeValidation.UpdateQuery

				If ClientID = 0 Then

					flag = False
					_Messages &= "	- ID" & vbNewLine

				End If

				If String.IsNullOrEmpty(_RFC) = True Then

					flag = False
					_Messages &= "	- RFC" & vbNewLine

				End If

				If _Country = 0 Then

					flag = False
					_Messages &= "	- Pais" & vbNewLine

				End If

				If _State = 0 Then

					flag = False
					_Messages &= "	- Estado" & vbNewLine

				End If

				If _Municipality = 0 Then

					flag = False
					_Messages &= "	- Municipio" & vbNewLine

				End If

				If String.IsNullOrEmpty(_Cologne) = True Then

					flag = False
					_Messages &= "	- Colonia" & vbNewLine

				End If

				If String.IsNullOrEmpty(_PostalCode) = True Then

					flag = False
					_Messages &= "	- Codigo Postal " & vbNewLine

				End If

				If String.IsNullOrEmpty(_Street) = True Then

					flag = False
					_Messages &= "	- Calle" & vbNewLine

				End If

				If String.IsNullOrEmpty(_NumberExterior) = True Then

					flag = False
					_Messages &= "	- Numero Exterior" & vbNewLine

				End If


			Case TypeValidation.DeleteQuery

				If ClientID = 0 Then

					flag = False
					_Messages &= "	- ID" & vbNewLine

				End If

		End Select

		Return flag

	End Function

#End Region

End Class
