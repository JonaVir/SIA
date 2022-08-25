Imports System.Data.SqlClient
Public Class SuppliersBankDetails
    Inherits MasterRepository

#Region "Fields and properties"

    Public Shared myInstance As SuppliersBankDetails

    Private listOfAccount As DataTable
    Private filter As DataView

    Private NumRecord As Integer
    Private suppliersID As Integer

    Private _bank As String
    Private _Clabe As String
    Private _Account As String
    Private _branchOffice As String
    Private _titular As String
    Private _DefaultAccount As String

    Public WriteOnly Property Bank As String
        Set(value As String)

            _bank = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Clabe As String
        Set(value As String)

            _Clabe = Trim(value)

        End Set
    End Property

    Public WriteOnly Property Account As String
        Set(value As String)

            _Account = Trim(value)

        End Set
    End Property

    Public WriteOnly Property branchOffice As String
        Set(value As String)

            _branchOffice = Trim(value)

        End Set
    End Property

    Public WriteOnly Property titular As String
        Set(value As String)

            _titular = Trim(value)

        End Set
    End Property

    Public WriteOnly Property DefaultAccount As Boolean
        Set(value As Boolean)

            _DefaultAccount = value

        End Set
    End Property

#End Region

#Region "Builders"

    Private Sub New(connectionString As String)

        setConnection(connectionString)
        loadAccounts()

        filter = New DataView()

        With filter

            .Table = listOfAccount
            .AllowDelete = False
            .AllowEdit = False
            .AllowNew = False
            .ApplyDefaultSort = True

        End With

    End Sub
#End Region

#Region "Methods"

    Private Sub loadAccounts()

        Query = "select * from DatosbancariosProveedor"

        listOfAccount = ExecuteRead()
        listOfAccount.TableName = "DatosBancariosProveedor"

    End Sub

    Public Function getAccounts(supplierID As Integer) As DataTable

        filter.RowFilter = "idProveedor = " & supplierID
        Return filter.ToTable()

    End Function

    Public Function save(supplierID As Integer) As Boolean

        Me.suppliersID = supplierID

        If ValidateData(TypeValidation.InsertQuery) Then

            Query = "SP_GuardarDatosBancariosProveedor"

            parameters = New SqlParameter("@idProveedor", supplierID)
            parameters = New SqlParameter("@Banco", _bank)
            parameters = New SqlParameter("@Clabe", _Clabe)
            parameters = New SqlParameter("@Cuenta", _Account)
            parameters = New SqlParameter("@sucursal", _branchOffice)
            parameters = New SqlParameter("@titular", _titular)
            parameters = New SqlParameter("@predeterminada", _DefaultAccount)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                loadAccounts()
                _Messages = "Datos registrados correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Function modify(supplierID As Integer, id As Integer) As Boolean

        Me.suppliersID = suppliersID
        Me.NumRecord = id

        If ValidateData(TypeValidation.UpdateQuery) Then

            Query = "SP_ModificarDatosBancariosProveedor"

            parameters = New SqlParameter("@id", id)
            parameters = New SqlParameter("@idProveedor", supplierID)
            parameters = New SqlParameter("@Banco", _bank)
            parameters = New SqlParameter("@Clabe", _Clabe)
            parameters = New SqlParameter("@Cuenta", _Account)
            parameters = New SqlParameter("@sucursal", _branchOffice)
            parameters = New SqlParameter("@titular", _titular)
            parameters = New SqlParameter("@predeterminada", _DefaultAccount)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                loadAccounts()
                _Messages = "Datos Modificados correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If
    End Function

    Public Function Delete(supplierID As Integer, id As Integer)

        Me.suppliersID = suppliersID
        Me.NumRecord = id

        If ValidateData(TypeValidation.DeleteQuery) Then

            Query = "SP_EliminarDatosBancariosProveedor"

            parameters = New SqlParameter("@id", id)
            parameters = New SqlParameter("@idProveedor", supplierID)

            If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                loadAccounts()
                _Messages = "Datos eliminados correctamente"
                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Public Shared Function getInstance(connectionString As String) As SuppliersBankDetails

        If myInstance Is Nothing Then

            myInstance = New SuppliersBankDetails(connectionString)

        End If

        Return myInstance

    End Function

    Protected Overrides Function ValidateData(value As TypeValidation, Optional method As String = "") As Boolean

        Dim flag As Boolean = True
        _Messages = "Los siguientes campos son obligatorios" & vbNewLine

        Select Case value
            Case TypeValidation.InsertQuery

                If suppliersID = 0 Then

                    flag = False
                    _Messages = "   - Id Proveedor" & vbNewLine

                End If

                If String.IsNullOrEmpty(_bank) = True Then

                    flag = False
                    _Messages &= "  - Banco" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Clabe) = True Then

                    flag = False
                    _Messages &= "  - Clabe" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Account) Then

                    flag = False
                    _Messages &= "  - Cuenta" & vbNewLine

                End If

                If String.IsNullOrEmpty(_branchOffice) = True Then

                    flag = False
                    _Messages &= "  - Sucursal" & vbNewLine

                End If

                If String.IsNullOrEmpty(_titular) = True Then

                    flag = False
                    _Messages &= "  - Titular" & vbNewLine

                End If

            Case TypeValidation.UpdateQuery

                If NumRecord = 0 Then

                    flag = False
                    _Messages &= "  - Numero registro"

                End If

                If suppliersID = 0 Then

                    flag = False
                    _Messages = "   - Id Proveedor" & vbNewLine

                End If

                If String.IsNullOrEmpty(_bank) = True Then

                    flag = False
                    _Messages &= "  - Banco" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Clabe) = True Then

                    flag = False
                    _Messages &= "  - Clabe" & vbNewLine

                End If

                If String.IsNullOrEmpty(_Account) Then

                    flag = False
                    _Messages &= "  - Cuenta" & vbNewLine

                End If

                If String.IsNullOrEmpty(_branchOffice) = True Then

                    flag = False
                    _Messages &= "  - Sucursal" & vbNewLine

                End If

                If String.IsNullOrEmpty(_titular) = True Then

                    flag = False
                    _Messages &= "  - Titular" & vbNewLine

                End If

            Case TypeValidation.DeleteQuery

                If NumRecord = 0 Then

                    flag = False
                    _Messages &= "  - Numero registro"

                End If

                If suppliersID = 0 Then

                    flag = False
                    _Messages = "   - Id Proveedor" & vbNewLine

                End If

        End Select

        _Messages &= "Favor de especificarlos."

        Return flag

    End Function
#End Region

End Class
