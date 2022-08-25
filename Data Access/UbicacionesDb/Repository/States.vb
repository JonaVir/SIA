Imports System.Data.SqlClient

Namespace States

    Public Class States
        Inherits Locations

#Region "Fields and propierties"

        Public Shared myInstance As States

        Private _StatesID As Hashtable
        Private States As DataTable
        Private listOfStates As DataView

        Private _ISO As String
        Private _IdCountry As Integer

        Public WriteOnly Property ISO As String
            Set(value As String)

                _ISO = Trim(value)

            End Set
        End Property

        Public WriteOnly Property idCountry As Integer
            Set(value As Integer)

                _IdCountry = value

            End Set
        End Property

        Public ReadOnly Property StateID(name As String) As Integer
            Get

                If _StatesID.ContainsKey(name) Then

                    Return _StatesID(name)

                Else

                    Return 0

                End If
            End Get
        End Property

#End Region

#Region "Builders"

        Private Sub New(connectionString As String)

            setConnection(connectionString)
            loadUbicationsDefaults()
            loadStates()

            listOfStates = New DataView()
            _StatesID = New Hashtable()

            With listOfStates

                .Table = States
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .ApplyDefaultSort = True

            End With

        End Sub

#End Region

#Region "Methods"

        Shared Function getInstance(connectionString As String) As States

            If myInstance Is Nothing Then

                myInstance = New States(connectionString)

            End If

            Return myInstance

        End Function

        Private Sub loadStates()

            Query = "select * from CatEstados"
            States = ExecuteRead()
            States.TableName = "CatEstados"

            If listOfStates IsNot Nothing Then

                listOfStates.Table = States

            End If

        End Sub
        Public Function getEstates(countryID As Integer) As DataTable

            listOfStates.RowFilter = "idPais = " & countryID

            Dim list As DataTable = listOfStates.ToTable()

            _StatesID.Clear()

            For Each row As DataRow In list.Rows

                _StatesID.Add(row.Item(3), row.Item(0))

            Next

            Return list

        End Function

        Public Function saveEstate() As Boolean

            If ValidateData(TypeValidation.InsertQuery) = True Then

                Query = "SP_GuardarEstado"

                parameters = New SqlParameter("@idPais", _IdCountry)
                parameters = New SqlParameter("@ISO", _ISO)
                parameters = New SqlParameter("@Nombre", _Name)

                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "Estado registrado correctamente"
                    loadStates()
                    Return True

                Else

                    Return False

                End If

            Else

                Return False

            End If

        End Function

        Public Function updateEstate(stateID As Integer) As Boolean

            _Id = stateID

            If ValidateData(TypeValidation.UpdateQuery) Then

                Query = "SP_ModificarEstado"

                parameters = New SqlParameter("@ISOEstado", _ISO)
                parameters = New SqlParameter("@nombre", _Name)
                parameters = New SqlParameter("@id", _Id)

                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "Estado modificado correctamente"
                    loadStates()
                    Return True

                Else

                    Return False

                End If

            Else

                Return False

            End If

        End Function

        Public Function deleteState(stateID As Integer) As Boolean

            _Id = stateID

            If ValidateData(TypeValidation.DeleteQuery) = True Then

                Query = "SP_EliminarEstado"

                parameters = New SqlParameter("@Id", stateID)

                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "Estado eliminado correctamente"
                    loadStates()
                    Return True

                Else



                    Return False

                End If

            Else

                Return False

            End If

        End Function

        Protected Overrides Function ValidateData(value As TypeValidation, Optional method As String = "") As Boolean

            Dim flag As Boolean = True
            _Messages = "Los siguientes campos son obligatorios" & vbNewLine

            Select Case value

                Case TypeValidation.InsertQuery

                    If _IdCountry = 0 Then

                        flag = False
                        _Messages &= "  - Id país" & vbNewLine

                    End If

                    If String.IsNullOrEmpty(_ISO) Then

                        flag = False
                        _Messages &= "  - ISO Estado" & vbNewLine

                    Else

                        If _ISO.Length > 6 Then

                            flag = False
                            _Messages = "La clave " & _ISO & " no es valida" & vbNewLine
                            Process.Start("https://www.iso.org/obp/ui/#search/code")

                        End If

                    End If

                    If String.IsNullOrEmpty(_Name) Then

                        flag = False
                        _Messages &= "  - Nombre" & vbNewLine

                    End If

                Case TypeValidation.UpdateQuery

                    If String.IsNullOrEmpty(_ISO) Then

                        flag = False
                        _Messages &= "  - ISO Estado" & vbNewLine

                    Else

                        If _ISO.Length > 6 Then

                            flag = False
                            _Messages = "La clave " & _ISO & " no es valida" & vbNewLine
                            Process.Start("https://www.iso.org/obp/ui/#search/code")

                        End If

                    End If

                    If String.IsNullOrEmpty(_Name) Then

                        flag = False
                        _Messages &= "  - Nombre" & vbNewLine

                    End If

                    If _Id = 0 Then

                        flag = False
                        _Messages &= "  - Id Estado" & vbNewLine

                    End If

                Case TypeValidation.DeleteQuery

                    If _Id = 0 Then

                        flag = False
                        _Messages &= "  - Id Estado" & vbNewLine

                    Else

                        If _Id <= 32 Then

                            flag = False
                            _Messages = "No se puede eliminar este estado"

                        End If

                    End If

            End Select

            Return flag

        End Function

#End Region

    End Class

End Namespace

