Imports System.Data.SqlClient
Public Class ClientBankReferences
    Inherits MasterRepository

#Region "fields and propierties"

    Public Shared myInstance As ClientBankReferences

    Private _Id As Integer
    Private ClientID As Integer
    Private _Bank As String
    Private _BranchOffice As String
    Private _Account As String
    Private _Telephone As String
    Private _Extension As String
    Private _CellPhone As String
    Private _Contact As String
    Private _job As String
    Private _RazonSocial As String
    Private _street As String
    Private _NumInterior As String
    Private _NumExterior As String
    Private _Cologne As String
    Private _PostalCode As String
    Private _Country As Integer
    Private _State As Integer
    Private _Municipality As Integer

    Public WriteOnly Property Id As Integer
        Set(value As Integer)

            _Id = value

        End Set
    End Property
    Public WriteOnly Property bank As String
        Set(value As String)

            _Bank = Trim(value)

        End Set
    End Property

    Public WriteOnly Property BranchOffice As String
        Set(value As String)

            _BranchOffice = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Accout As String
        Set(value As String)

            _Account = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Telephone As String
        Set(value As String)

            _Telephone = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Extension As String
        Set(value As String)

            _Extension = Trim(value)

        End Set
    End Property

    Public WriteOnly Property CellPhone As String
        Set(value As String)

            _CellPhone = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Contact As String
        Set(value As String)

            _Contact = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Job As String
        Set(value As String)

            _job = Trim(value)

        End Set
    End Property

    Public WriteOnly Property RazonSocial As String
        Set(value As String)

            _RazonSocial = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Street As String
        Set(value As String)

            _street = Trim(value)

        End Set
    End Property

    Public WriteOnly Property NumInterior As String
        Set(value As String)

            _NumInterior = Trim(value)

        End Set
    End Property

    Public WriteOnly Property NumExterior As String
        Set(value As String)

            _NumExterior = Trim(value)

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

#End Region

#Region "Builders"

    Private Sub New(connectionsString As String)

        setConnection(connectionsString)

    End Sub

#End Region

#Region "Methods"

    Public Function getBankReferences(clientID As Integer) As DataTable

        Query = "SP_ObtenerReferenciasBancariasCliente"

        parameters = New SqlParameter("@idCliente", clientID)

        Return ExecuteRead(IDbAdapter.typeQuery.StoredProcedure)

    End Function

    Public Function SaveBankReference(clientID As Integer) As Boolean

        Me.ClientID = clientID

        If ValidateData(TypeValidation.InsertQuery) Then

            Query = "SP_GuardarReferenciasBancariasCliente"

            parameters = New SqlParameter("@idCliente", clientID)
            parameters = New SqlParameter("@Banco", _Bank)
            parameters = New SqlParameter("@Sucursal", _BranchOffice)
            parameters = New SqlParameter("@Cuenta", _Account)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Extension", _Extension)
            parameters = New SqlParameter("@Celular", _CellPhone)
            parameters = New SqlParameter("@Contacto", _Contact)
            parameters = New SqlParameter("@Puesto", _job)
            parameters = New SqlParameter("@RazonSocial", _RazonSocial)
            parameters = New SqlParameter("@Calle", _street)
            parameters = New SqlParameter("@NumInterior", _NumInterior)
            parameters = New SqlParameter("@NumExterior", _NumExterior)
            parameters = New SqlParameter("@Colonia", _Cologne)
            parameters = New SqlParameter("@CodigoPostal", _PostalCode)
            parameters = New SqlParameter("@Pais", _Country)
            parameters = New SqlParameter("@Estado", _State)
            parameters = New SqlParameter("@Municipio", _Municipality)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                _Messages = "Referencia registrada correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function ModifyBankReference(ClientID As Integer) As Boolean

        Me.ClientID = ClientID

        If ValidateData(TypeValidation.UpdateQuery) = True Then

            Query = "SP_ModificarReferenciaBancariaCliente"

            parameters = New SqlParameter("@Id", _Id)
            parameters = New SqlParameter("@idCliente", ClientID)
            parameters = New SqlParameter("@Banco", _Bank)
            parameters = New SqlParameter("@Sucursal", _BranchOffice)
            parameters = New SqlParameter("@Cuenta", _Account)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Extension", _Extension)
            parameters = New SqlParameter("@Celular", _CellPhone)
            parameters = New SqlParameter("@Contacto", _Contact)
            parameters = New SqlParameter("@Puesto", _job)
            parameters = New SqlParameter("@RazonSocial", _RazonSocial)
            parameters = New SqlParameter("@Calle", _street)
            parameters = New SqlParameter("@NumInterior", _NumInterior)
            parameters = New SqlParameter("@NumExterior", _NumExterior)
            parameters = New SqlParameter("@Colonia", _Cologne)
            parameters = New SqlParameter("@CodigoPostal", _PostalCode)
            parameters = New SqlParameter("@Pais", _Country)
            parameters = New SqlParameter("@Estado", _State)
            parameters = New SqlParameter("@Municipio", _Municipality)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                _Messages = "Referencia modificada correctamente"
                Return True

            Else

                Return False

            End If

        Else


            Return False

        End If

    End Function

    Public Function DeleteBankReference(clientID As Integer) As Boolean

        Me.ClientID = clientID

        If ValidateData(TypeValidation.DeleteQuery) Then

            Query = "Delete referenciasBancariasClientes where id = @id and idcliente = @idcliente"

            parameters = New SqlParameter("@id", _Id)
            parameters = New SqlParameter("@idcliente", clientID)

            If ExecuteQuery() Then

                _Messages = "Referencia eliminada correctamente"

                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Shared Function getInstance(connectionString As String) As ClientBankReferences

        If myInstance Is Nothing Then

            myInstance = New ClientBankReferences(connectionString)

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
                    _Messages &= "  - ID cliente" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Bank) Then

                    flag = False
                    _Messages &= "  - Banco" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Account) Then

                    flag = False
                    _Messages &= "  - Cuenta" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Contact) Then

                    flag = False
                    _Messages &= "  - Contacto" & vbNewLine

                End If

                If String.IsNullOrEmpty(_CellPhone) Then

                    flag = False
                    _Messages &= "  - Celular" & vbNewLine

                End If

                If _Country = 0 Then

                    flag = False
                    _Messages &= "  - País" & vbNewLine

                End If

                If _State = 0 Then

                    flag = False
                    _Messages &= "  - Estado" & vbNewLine

                End If

                If _Municipality = 0 Then

                    flag = False
                    _Messages &= "  - Municipio" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Cologne) Then

                    flag = False
                    _Messages &= "  - Colonia" & vbNewLine

                End If

                If String.IsNullOrEmpty(_PostalCode) Then

                    flag = False
                    _Messages &= "  - Codigo postal" & vbNewLine

                End If

                If String.IsNullOrEmpty(_street) Then

                    flag = False
                    _Messages &= "  - Calle" & vbNewLine

                End If

            Case TypeValidation.UpdateQuery

                If _Id = 0 Then

                    flag = False
                    _Messages &= "  - Numero de referencia" & vbNewLine

                End If

                If ClientID = 0 Then
                    flag = False
                    _Messages &= "  - ID cliente" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Bank) Then

                    flag = False
                    _Messages &= "  - Banco" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Account) Then

                    flag = False
                    _Messages &= "  - Cuenta" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Contact) Then

                    flag = False
                    _Messages &= "  - Contacto" & vbNewLine

                End If

                If String.IsNullOrEmpty(_CellPhone) Then

                    flag = False
                    _Messages &= "  - Celular" & vbNewLine

                End If

                If _Country = 0 Then

                    flag = False
                    _Messages &= "  - País" & vbNewLine

                End If

                If _State = 0 Then

                    flag = False
                    _Messages &= "  - Estado" & vbNewLine

                End If

                If _Municipality = 0 Then

                    flag = False
                    _Messages &= "  - Municipio" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Cologne) Then

                    flag = False
                    _Messages &= "  - Colonia" & vbNewLine

                End If

                If String.IsNullOrEmpty(_PostalCode) Then

                    flag = False
                    _Messages &= "  - Codigo postal" & vbNewLine

                End If

                If String.IsNullOrEmpty(_street) Then

                    flag = False
                    _Messages &= "  - Calle" & vbNewLine

                End If

            Case TypeValidation.DeleteQuery

                If _Id = 0 Then

                    flag = False
                    _Messages &= "  - Numero de referencia" & vbNewLine

                End If

                If ClientID = 0 Then
                    flag = False
                    _Messages &= "  - ID cliente" & vbNewLine

                End If

        End Select

        _Messages &= "Favor de especificarlos"

        Return flag
    End Function

#End Region

End Class
