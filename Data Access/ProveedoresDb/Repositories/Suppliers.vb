Imports System.Data.SqlClient
Public Class Suppliers
    Inherits MasterRepository

#Region "fields and propierties"

    Public Shared myInstance As Suppliers

    Private _listOfSuppliers As DataTable
    Private _filter As DataView

    Private supplierID As Integer
    Private _Name As String
    Private _Street As String
    Private _OutdoorNumber As String
    Private _interiorNumber As String
    Private _colony As String
    Private _municipality As Integer
    Private _State As Integer
    Private _Country As Integer
    Private _PostalCode As String
    Private _Telephone As String
    Private _Web As String
    Private _RFC As String
    Private _Curp As String
    Private _Activo As Boolean

    Public WriteOnly Property Name As String
        Set(value As String)

            _Name = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Street As String
        Set(value As String)

            _Street = Trim(value)

        End Set
    End Property

    Public WriteOnly Property outdoorNumber As String
        Set(value As String)

            _OutdoorNumber = Trim(value)

        End Set
    End Property

    Public WriteOnly Property InteriorNumber As String
        Set(value As String)

            _interiorNumber = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Colony As String
        Set(value As String)

            _colony = Trim(value)

        End Set
    End Property

    Public WriteOnly Property municipality As Integer
        Set(value As Integer)

            _municipality = value

        End Set
    End Property

    Public WriteOnly Property state As Integer
        Set(value As Integer)

            _State = value

        End Set
    End Property

    Public WriteOnly Property country As Integer
        Set(value As Integer)

            _Country = value

        End Set
    End Property

    Public WriteOnly Property postalCode As String
        Set(value As String)

            _PostalCode = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Telephone As String
        Set(value As String)

            _Telephone = Trim(value)
        End Set
    End Property

    Public WriteOnly Property Web As String
        Set(value As String)

            _Web = Trim(value)

        End Set
    End Property

    Public WriteOnly Property RFC As String
        Set(value As String)

            _RFC = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Curp As String
        Set(value As String)

            _Curp = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Activo As Boolean
        Set(value As Boolean)

            _Activo = value

        End Set
    End Property

    Public ReadOnly Property listOfSuppliers As DataTable
        Get

            Return _listOfSuppliers

        End Get
    End Property

#End Region

#Region "Builders"

    Private Sub New(connectionString As String)

        setConnection(connectionString)
        loadSuppliers()

        _filter = New DataView()

        With _filter

            .Table = _listOfSuppliers
            .AllowDelete = False
            .AllowEdit = False
            .AllowNew = False
            .ApplyDefaultSort = True

        End With

    End Sub

#End Region

#Region "Methods"

    Private Sub loadSuppliers()

        Query = "select pv.id,pv.Nombre,pv.Calle,pv.NumeroInterior,pv.NumeroExterior,pv.Colonia,m.nombreMunicipio as Municipio,e.nombreEstado as Estado,p.nombrePais as Pais,CodigoPostal,Telefono,web,rfc,CURP,Activo from Proveedores as pv 
                 left join CatPaises as p on pv.Pais = p.id left join CatEstados as E on pv.Estado = e.id left join CatMunicipios as M on pv.Municipio = M.id"

        _listOfSuppliers = ExecuteRead()
        _listOfSuppliers.TableName = "Proveedores"

    End Sub

    Public Function Filter(field As String, value As Object) As DataTable

        If _listOfSuppliers.Columns.Contains(field) Then

            Select Case field
                Case "id"

                    If IsNumeric(value) Then

                        _filter.RowFilter = "id = " & value

                    Else

                        MsgBox("Valor numerico requerido", MsgBoxStyle.Exclamation)

                    End If

                Case "Nombre"

                    _filter.RowFilter = "Nombre like '%" & value & "%'"

                Case "Activo"

                    If value = "Activo" Then

                        _filter.RowFilter = "Activo = 1"
                    Else

                        _filter.RowFilter = "Activo = 0"

                    End If

            End Select

            Return _filter.ToTable()

        Else

            Return _listOfSuppliers

        End If

    End Function

    Public Function Save(ByRef Id As Integer) As Boolean

        If ValidateData(TypeValidation.InsertQuery) Then

            Query = "SP_GuardarProveedor"

            parameters = New SqlParameter("@Nombre", _Name)
            parameters = New SqlParameter("@Calle", _Street)
            parameters = New SqlParameter("@NumeroInterior", _interiorNumber)
            parameters = New SqlParameter("@NumeroExterior", _OutdoorNumber)
            parameters = New SqlParameter("@Colonia ", _colony)
            parameters = New SqlParameter("@Municipio", _municipality)
            parameters = New SqlParameter("@Estado", _State)
            parameters = New SqlParameter("@Pais", _Country)
            parameters = New SqlParameter("@CodigoPostal", _PostalCode)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Web", _Web)
            parameters = New SqlParameter("@RFC", _RFC)
            parameters = New SqlParameter("@CURP", _Curp)

            Id = ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure, IDbAdapter.typeExecuter.ExecuterScalar)

            If Id > 0 Then

                loadSuppliers()
                _Messages = "Proveedor registrado correctamente" & vbNewLine & "Id proveedor: " & Id
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function Modify(SupplierID As Integer) As Boolean

        Me.supplierID = SupplierID

        If ValidateData(TypeValidation.UpdateQuery) Then

            Query = "SP_ModificarProveedor"

            parameters = New SqlParameter("@Id", SupplierID)
            parameters = New SqlParameter("@Nombre", _Name)
            parameters = New SqlParameter("@Calle", _Street)
            parameters = New SqlParameter("@NumeroInterior", _interiorNumber)
            parameters = New SqlParameter("@NumeroExterior", _OutdoorNumber)
            parameters = New SqlParameter("@Colonia ", _colony)
            parameters = New SqlParameter("@Municipio", _municipality)
            parameters = New SqlParameter("@Estado", _State)
            parameters = New SqlParameter("@Pais", _Country)
            parameters = New SqlParameter("@CodigoPostal", _PostalCode)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Web", _Web)
            parameters = New SqlParameter("@RFC", _RFC)
            parameters = New SqlParameter("@CURP", _Curp)
            parameters = New SqlParameter("@activo", _Activo)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                loadSuppliers()
                _Messages = "Proveedor Modificado correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function Delete(supplierID As Integer) As Boolean

        Me.supplierID = supplierID

        If ValidateData(TypeValidation.DeleteQuery) Then

            Query = "SP_EliminarProveedor"

            parameters = New SqlParameter("@id", supplierID)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                loadSuppliers()
                _Messages &= "Proveedor Eliminado correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function
    Public Shared Function getInstance(connectionString As String) As Suppliers

        If myInstance Is Nothing Then

            myInstance = New Suppliers(connectionString)

        End If

        Return myInstance

    End Function

    Protected Overrides Function ValidateData(value As TypeValidation, Optional method As String = "") As Boolean

        Dim flag As Boolean = True
        _Messages = "Los siguientes campos son obligatorios" & vbNewLine

        Select Case value
            Case TypeValidation.InsertQuery

                If String.IsNullOrEmpty(_Name) Then

                    flag = False
                    _Messages &= "  - Nombre" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Street) Then

                    flag = False
                    _Messages &= "  - Calle" & vbNewLine

                End If

                If String.IsNullOrEmpty(_OutdoorNumber) Then

                    flag = False
                    _Messages &= "  -Numero exterior" & vbNewLine

                End If

                If String.IsNullOrEmpty(_colony) Then

                    flag = False
                    _Messages &= "  - Colonia" & vbNewLine

                End If

                If _municipality = 0 Then

                    flag = False
                    _Messages &= "  - Municipio" & vbNewLine

                End If

                If _State = 0 Then

                    flag = False
                    _Messages &= "  - Estado" & vbNewLine

                End If

                If _Country = 0 Then

                    flag = False
                    _Messages &= "  - País" & vbNewLine

                End If

                If String.IsNullOrEmpty(_PostalCode) Then

                    flag = False
                    _Messages &= "  - Codigo Postal" & vbNewLine

                End If

                If String.IsNullOrEmpty(_RFC) Then

                    flag = False
                    _Messages &= "  - RFC" & vbNewLine
                End If

            Case TypeValidation.UpdateQuery

                If supplierID = 0 Then

                    flag = False
                    _Messages &= "  - Id Proveedor" & vbNewLine

                End If


                If String.IsNullOrEmpty(_Name) Then

                    flag = False
                    _Messages &= "  - Nombre" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Street) Then

                    flag = False
                    _Messages &= "  - Calle" & vbNewLine

                End If

                If String.IsNullOrEmpty(_OutdoorNumber) Then

                    flag = False
                    _Messages &= "  -Numero exterior" & vbNewLine

                End If

                If String.IsNullOrEmpty(_colony) Then

                    flag = False
                    _Messages &= "  - Colonia" & vbNewLine

                End If

                If _municipality = 0 Then

                    flag = False
                    _Messages &= "  - Municipio" & vbNewLine

                End If

                If _State = 0 Then

                    flag = False
                    _Messages &= "  - Estado" & vbNewLine

                End If

                If _Country = 0 Then

                    flag = False
                    _Messages &= "  - País" & vbNewLine

                End If

                If String.IsNullOrEmpty(_PostalCode) Then

                    flag = False
                    _Messages &= "  - Codigo Postal" & vbNewLine

                End If

                If String.IsNullOrEmpty(_RFC) Then

                    flag = False
                    _Messages &= "  - RFC" & vbNewLine

                End If

            Case TypeValidation.DeleteQuery

                If supplierID = 0 Then

                    flag = False
                    _Messages &= "  - Id Proveedor" & vbNewLine

                End If

        End Select

        _Messages &= "Favor de especificarlos."

        Return flag

    End Function

#End Region

End Class
