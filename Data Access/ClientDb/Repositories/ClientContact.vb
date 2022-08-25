Imports System.Data.SqlClient

Public Class ClientContact
    Inherits MasterRepository

#Region "fields and propierties"

    Public Shared myInstance As ClientContact

    Private _ContactID As Integer
    Private clientID As Integer
    Private _name As String
    Private _Telephone As String
    Private _Extension As String
    Private _CellPhone As String
    Private _Email As String
    Private _job As String

    Public WriteOnly Property ContactID As Integer
        Set(value As Integer)

            _ContactID = value

        End Set
    End Property

    Public WriteOnly Property Name As String
        Set(value As String)

            _name = Trim(value)

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

    Public WriteOnly Property Email As String
        Set(value As String)

            _Email = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Job As String
        Set(value As String)

            _job = Trim(value)

        End Set
    End Property

#End Region

#Region "Builders"

    Private Sub New(connectionString As String)

        setConnection(connectionString)

    End Sub

#End Region

#Region "Methods"

    Public Function getContacts(ClientID As Integer) As DataTable

        Query = "SP_ObtenerDatosContactoClientes"

        parameters = New SqlParameter("@idcliente", ClientID)

        Return ExecuteRead(IDbAdapter.typeQuery.StoredProcedure)

    End Function

    Public Function SaveContact(clientID As Integer) As Boolean

        Me.clientID = clientID

        If ValidateData(TypeValidation.InsertQuery) Then

            Query = "SP_GuardarContactoCliente"

            parameters = New SqlParameter("@idCliente", clientID)
            parameters = New SqlParameter("@Nombre", _name)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Extension", _Extension)
            parameters = New SqlParameter("@Celular", _CellPhone)
            parameters = New SqlParameter("@Correo", _Email)
            parameters = New SqlParameter("@Puesto", _job)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                _Messages = "Contacto registrado correctamente"
                Return True

            Else

                _Messages = "Contacto NO regitrado"
                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function ModifyContact(clientID As Integer) As Boolean

        Me.clientID = clientID

        If ValidateData(TypeValidation.UpdateQuery) Then

            Query = "SP_ModificarContactoCliente"

            parameters = New SqlParameter("@id", _ContactID)
            parameters = New SqlParameter("@idCliente", clientID)
            parameters = New SqlParameter("@Nombre", _name)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Extension", _Extension)
            parameters = New SqlParameter("@Celular", _CellPhone)
            parameters = New SqlParameter("@Correo", _Email)
            parameters = New SqlParameter("@Puesto", _job)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                _Messages = "Contacto modificado correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function DeleteContact(clientID As Integer) As Boolean

        Me.clientID = clientID

        If ValidateData(TypeValidation.DeleteQuery) Then

            Query = "Delete DatosContactoClientes where idcliente = @idCliente and id = @id"

            parameters = New SqlParameter("@id", _ContactID)
            parameters = New SqlParameter("@idCliente", clientID)

            If ExecuteQuery() > 0 Then

                _Messages = "Contacto eliminado correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Shared Function getInstance(connectionString As String) As ClientContact

        If myInstance Is Nothing Then

            myInstance = New ClientContact(connectionString)

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
                    _Messages &= "  - ID cliente" & vbNewLine

                End If

                If String.IsNullOrEmpty(_name) Then

                    flag = False
                    _Messages &= "  - Nombre" & vbNewLine

                End If

                If String.IsNullOrEmpty(_CellPhone) Then

                    flag = False
                    _Messages &= "  - Celular" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Email) Then

                    flag = False
                    _Messages &= "   - Correo Electronico"

                End If

            Case TypeValidation.UpdateQuery

                If _ContactID = 0 Then

                    flag = False
                    _Messages &= "  - ID contacto" & vbNewLine

                End If

                If clientID = 0 Then

                    flag = False
                    _Messages &= "  - ID cliente" & vbNewLine

                End If

                If String.IsNullOrEmpty(_name) Then

                    flag = False
                    _Messages &= "  - Nombre" & vbNewLine

                End If

                If String.IsNullOrEmpty(_CellPhone) Then

                    flag = False
                    _Messages &= "  - Celular" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Email) Then

                    flag = False
                    _Messages &= "   - Correo Electronico"

                End If

            Case TypeValidation.DeleteQuery

                If clientID = 0 Then

                    flag = False

                    _Messages &= "  - ID Cliente" & vbNewLine

                End If

                If _ContactID = 0 Then

                    flag = False

                    _Messages &= "  - ID Contacto" & vbNewLine

                End If

        End Select

        _Messages &= "Favor de especificarlos"

        Return flag

    End Function

#End Region

End Class
