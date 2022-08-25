Imports System.Data.SqlClient

Public Class Clients
    Inherits MasterRepository

#Region "fields and propierties"

    Public Shared myInstance As Clients = Nothing

    Private _listOfClients As DataTable
    Private _filter As DataView

    Private ClientID As Integer
    Private _name As String
    Private _Telephone As String
    Private _Web As String
    Private _street As String
    Private _numInterior As String
    Private _numExterior As String
    Private _country As Integer
    Private _state As Integer
    Private _municipality As Integer
    Private _Cologne As String
    Private _PostalCode As String
    Private _ClienteAAA As Boolean
    Private _Blocking As Boolean

    Public WriteOnly Property name As String
        Set(value As String)

            _name = Trim(value)

        End Set
    End Property

    Public WriteOnly Property telephone As String
        Set(value As String)

            _Telephone = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Web As String
        Set(value As String)

            _Web = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Street As String
        Set(value As String)

            _street = Trim(value)

        End Set
    End Property

    Public WriteOnly Property NumberInterior As String
        Set(value As String)

            _numInterior = value

        End Set
    End Property

    Public WriteOnly Property NumberExterior As String
        Set(value As String)

            _numExterior = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Country As Integer
        Set(value As Integer)

            _country = value

        End Set
    End Property

    Public WriteOnly Property State As Integer
        Set(value As Integer)

            _state = value

        End Set
    End Property

    Public WriteOnly Property Municipality As Integer
        Set(value As Integer)

            _municipality = value

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

    Public WriteOnly Property ClientAAA As Boolean
        Set(value As Boolean)

            _ClienteAAA = value

        End Set
    End Property

    Public WriteOnly Property Blocking As Boolean
        Set(value As Boolean)

            _Blocking = value

        End Set
    End Property

    Public ReadOnly Property listOfClients As DataTable
        Get

            Return _listOfClients

        End Get
    End Property

#End Region

#Region "Builders"

    Private Sub New(connectionString As String)

        setConnection(connectionString)
        loadClients()

        _filter = New DataView()

        With _filter

            .Table = _listOfClients
            .AllowDelete = False
            .AllowEdit = False
            .AllowNew = False
            .ApplyDefaultSort = True

        End With

    End Sub

#End Region

#Region "Methods"

    Private Sub loadClients()

        Query = "SP_ObtenerClientes"

        _listOfClients = ExecuteRead(IDbAdapter.typeQuery.StoredProcedure)
        _listOfClients.TableName = "Clientes"

    End Sub

    Public Function filter(field As String, value As Object) As DataTable

        If _listOfClients.Columns.Contains(field) And value <> Nothing Then

            Select Case field
                Case "id"

                    If IsNumeric(value) Then

                        _filter.RowFilter = "id = " & value

                    Else

                        MsgBox("Valor numerico requerido", MsgBoxStyle.Exclamation)

                    End If

                Case "Nombre"

                    _filter.RowFilter = "Nombre like '%" & value & "%'"

                Case "Calle"

                    _filter.RowFilter = "Calle like'%" & value & "%'"

                Case "NumExterior"

                    _filter.RowFilter = "NumExterior like '%" & value & "%'"

                Case "NumInterior"

                    _filter.RowFilter = "NumInterior like '%" & value & "%'"

                Case "Pais"

                    _filter.RowFilter = "pais like'%" & value & "%'"

                Case "Estado"

                    _filter.RowFilter = "Estado like '%" & value & "%'"

                Case "Municipio"

                    _filter.RowFilter = "Municipio like '%" & value & "%'"

                Case "Colonia"

                    _filter.RowFilter = "Colonia like '%" & value & "%'"

                Case "CodigoPostal"

                    _filter.RowFilter = "CodigoPostal like '%" & value & "%'"

                Case "Telefono"

                    _filter.RowFilter = "Telefono like '%" & value & "%'"

                Case "PaginaWeb"

                    _filter.RowFilter = "PaginaWeb like '%" & value & "%'"

                Case "ClienteAAA"

                    _filter.RowFilter = "ClienteAAA = 1"

                Case "Bloqueo"

                    _filter.RowFilter = "Bloqueo = 1"

            End Select

            Return _filter.ToTable()

        Else

            Return _listOfClients

        End If

    End Function

    Public Function SaveClient(ByRef Id As Integer) As Boolean

        If ValidateData(TypeValidation.InsertQuery) Then

            Query = "SP_GuardarCliente"

            parameters = New SqlParameter("@nombre", _name)
            parameters = New SqlParameter("@calle", _street)
            parameters = New SqlParameter("@NumExterior", _numExterior)
            parameters = New SqlParameter("@NumInterior", _numInterior)
            parameters = New SqlParameter("@Pais", _country)
            parameters = New SqlParameter("@Estado", _state)
            parameters = New SqlParameter("@Municipio", _municipality)
            parameters = New SqlParameter("@Colonia", _Cologne)
            parameters = New SqlParameter("@CodigoPostal", _PostalCode)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Web", _Web)
            parameters = New SqlParameter("@ClienteAAA ", _ClienteAAA)
            parameters = New SqlParameter("@Bloqueo", _Blocking)


            Id = ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure, IDbAdapter.typeExecuter.ExecuterScalar)

            If Id > 0 Then

                loadClients()
                _Messages = "Cliente registrado correctamente" & vbNewLine & "ID Cliente: " & Id

                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function ModifyClient(clientID As Integer) As Boolean

        Me.ClientID = clientID

        If ValidateData(TypeValidation.UpdateQuery) = True Then

            Query = "SP_ModificarCliente"

            parameters = New SqlParameter("@id", clientID)
            parameters = New SqlParameter("@nombre", _name)
            parameters = New SqlParameter("@calle", _street)
            parameters = New SqlParameter("@NumExterior", _numExterior)
            parameters = New SqlParameter("@NumInterior", _numInterior)
            parameters = New SqlParameter("@Pais", _country)
            parameters = New SqlParameter("@Estado", _state)
            parameters = New SqlParameter("@Municipio", _municipality)
            parameters = New SqlParameter("@Colonia", _Cologne)
            parameters = New SqlParameter("@CodigoPostal", _PostalCode)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Web", _Web)
            parameters = New SqlParameter("@ClienteAAA ", _ClienteAAA)
            parameters = New SqlParameter("@Bloqueo", _Blocking)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                loadClients()
                _Messages = "Cliente modificado correctamente"

                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function DeleteClient(clientID As Integer) As Boolean

        Me.ClientID = clientID

        If ValidateData(TypeValidation.DeleteQuery) = True Then

            Query = "Delete Clientes where id = @id"
            parameters = New SqlParameter("@id", clientID)

            If ExecuteQuery() > 0 Then

                loadClients()
                _Messages = "Cliente Eliminado Correctamente"

                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Shared Function getInstance(connectionString As String) As Clients

        If myInstance Is Nothing Then

            myInstance = New Clients(connectionString)

        End If

        Return myInstance

    End Function

    Protected Overrides Function ValidateData(value As TypeValidation, Optional method As String = "") As Boolean

        Dim flag As Boolean = True
        _Messages = "Los siguientes campos son obligatorios" & vbNewLine

        Select Case value
            Case TypeValidation.InsertQuery

                If String.IsNullOrEmpty(_name) = True Then

                    flag = False
                    _Messages &= "  - Nombre Cliente" & vbNewLine

                End If

                If String.IsNullOrEmpty(_street) = True Then

                    flag = False
                    _Messages &= "  - Calle" & vbNewLine

                End If

                If _country = 0 Then

                    flag = False
                    _Messages &= "  - Pais" & vbNewLine

                End If

                If _state = 0 Then

                    flag = False
                    _Messages &= "  - Estado" & vbNewLine

                End If

                If _municipality = 0 Then

                    flag = False
                    _Messages &= "  - Municipio" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Cologne) = True Then

                    flag = False
                    _Messages &= "  - Colonia" & vbNewLine

                End If

                If String.IsNullOrEmpty(_PostalCode) = True Then

                    flag = False
                    _Messages &= "  - Codigo Postal" & vbNewLine

                End If

            Case TypeValidation.UpdateQuery

                If ClientID = 0 Then

                    flag = False
                    _Messages &= "  - ID Cliente" & vbNewLine

                End If

                If String.IsNullOrEmpty(_name) = True Then

                    flag = False
                    _Messages &= "  - Nombre Cliente" & vbNewLine

                End If

                If String.IsNullOrEmpty(_street) = True Then

                    flag = False
                    _Messages &= "  - Calle" & vbNewLine

                End If

                If _country = 0 Then

                    flag = False
                    _Messages &= "  - Pais" & vbNewLine

                End If

                If _state = 0 Then

                    flag = False
                    _Messages &= "  - Estado" & vbNewLine

                End If

                If _municipality = 0 Then

                    flag = False
                    _Messages &= "  - Municipio" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Cologne) = True Then

                    flag = False
                    _Messages &= "  - Colonia" & vbNewLine

                End If

                If String.IsNullOrEmpty(_PostalCode) = True Then

                    flag = False
                    _Messages &= "  - Codigo Postal" & vbNewLine

                End If

            Case TypeValidation.DeleteQuery

                If ClientID = 0 Then

                    flag = False

                    _Messages &= "  - ID" & vbNewLine

                End If

        End Select

        _Messages &= "Favor de especificarlos"

        Return flag

    End Function

#End Region

End Class
