Imports System.Data.SqlClient
Public Class SupplierContacts
    Inherits MasterRepository

#Region "Fields and properties"

    Public Shared myInstance As SupplierContacts

    Private listOfContacts As DataTable
    Private filter As DataView

    Private NumRecord As Integer
    Private SupplierID As Integer
    Private _FullName As String
    Private _Telephone As String
    Private _Extension As String
    Private _Cellphone As String
    Private _Email As String
    Private _JobPosition As String

    Public WriteOnly Property Fullname As String
        Set(value As String)

            _FullName = Trim(value)

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

    Public WriteOnly Property Cellphone As String
        Set(value As String)

            _Cellphone = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Email As String
        Set(value As String)

            _Email = Trim(value)

        End Set
    End Property

    Public WriteOnly Property JobPosition As String
        Set(value As String)

            _JobPosition = Trim(value)
        End Set
    End Property

#End Region

#Region "Builders"

    Private Sub New(connectionString As String)

        setConnection(connectionString)
        loadContacts()

    End Sub
#End Region

#Region "Methods"
    Private Sub loadContacts()

        Query = "select * from ContactosProveedores"

        listOfContacts = ExecuteRead()
        listOfContacts.TableName = "ContactosProveedores"

        If filter Is Nothing Then

            filter = New DataView()

            With filter

                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .ApplyDefaultSort = True

            End With

        End If

        filter.Table = listOfContacts

    End Sub

    Public Function getContacts(supplierID As Integer) As DataTable

        filter.RowFilter = "idProveedor = " & supplierID

        Return filter.ToTable()

    End Function

    Public Function save(supplierID As Integer) As Boolean

        Me.SupplierID = supplierID

        If ValidateData(TypeValidation.InsertQuery) Then

            Query = "SP_GuardarContactoProveedor"

            parameters = New SqlParameter("@idProveedor", supplierID)
            parameters = New SqlParameter("@NombreCompleto", _FullName)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Extension", _Extension)
            parameters = New SqlParameter("@Celular", _Cellphone)
            parameters = New SqlParameter("@Correo", _Email)
            parameters = New SqlParameter("@puesto", _JobPosition)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                loadContacts()
                _Messages = "Contacto registrado correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function modify(supplierID As Integer, id As Integer) As Boolean

        Me.SupplierID = supplierID
        Me.NumRecord = id

        If ValidateData(TypeValidation.UpdateQuery) Then

            Query = "SP_ModificarContactoProveedor"

            parameters = New SqlParameter("@id", id)
            parameters = New SqlParameter("@idProveedor", supplierID)
            parameters = New SqlParameter("@NombreCompleto", _FullName)
            parameters = New SqlParameter("@Telefono", _Telephone)
            parameters = New SqlParameter("@Extension", _Extension)
            parameters = New SqlParameter("@Celular", _Cellphone)
            parameters = New SqlParameter("@Correo", _Email)
            parameters = New SqlParameter("@puesto", _JobPosition)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                loadContacts()
                _Messages = "Contacto modificado correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function delete(supplierID As Integer, ContactID As Integer) As Boolean

        Me.SupplierID = supplierID
        Me.NumRecord = ContactID

        If ValidateData(TypeValidation.DeleteQuery) Then

            Query = "SP_EliminarContactoProveedor"

            parameters = New SqlParameter("@id", ContactID)
            parameters = New SqlParameter("@idProveedor", supplierID)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) Then

                loadContacts()
                _Messages = "Contacto eliminado correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Shared Function getInstance(connectionString As String) As SupplierContacts

        If myInstance Is Nothing Then

            myInstance = New SupplierContacts(connectionString)

        End If

        Return myInstance

    End Function

    Protected Overrides Function ValidateData(value As TypeValidation, Optional method As String = "") As Boolean

        Dim flag As Boolean = True

        _Messages = "Los siguientes campos son obligatorios" & vbNewLine

        Select Case value
            Case TypeValidation.InsertQuery

                If SupplierID = 0 Then

                    flag = False
                    _Messages &= "  - Id Proveedor" & vbNewLine

                End If

                If String.IsNullOrEmpty(_FullName) Then

                    flag = False
                    _Messages &= "  - Nombre Completo contacto" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Cellphone) Then

                    flag = False
                    _Messages &= "  - Celular" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Email) Then

                    flag = False
                    _Messages &= "  - Correo Electronico" & vbNewLine

                End If

            Case TypeValidation.UpdateQuery

                If NumRecord = 0 Then

                    flag = False
                    _Messages &= "  - Id Contacto" & vbNewLine

                End If

                If SupplierID = 0 Then

                    flag = False
                    _Messages &= "  - Id Proveedor" & vbNewLine

                End If

                If String.IsNullOrEmpty(_FullName) Then

                    flag = False
                    _Messages &= "  - Nombre Completo contacto" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Cellphone) Then

                    flag = False
                    _Messages &= "  - Celular" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Email) Then

                    flag = False
                    _Messages &= "  - Correo Electronico" & vbNewLine

                End If

            Case TypeValidation.DeleteQuery

                If SupplierID = 0 Then

                    flag = False
                    _Messages &= "  - Id Proveedor" & vbNewLine

                End If

        End Select

        _Messages &= "Favor de especificarlos."

        Return flag

    End Function

#End Region

End Class
