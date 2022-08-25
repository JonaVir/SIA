Imports System.Data.SqlClient

Namespace Coutries

    Public Class Countries
        Inherits Locations

#Region "fields and propierties"

        Shared myInstance As Countries = Nothing
        Private _ISO As String
        Private _CountriesID As Hashtable
        Private _ListOfCountries As DataTable
        Public WriteOnly Property ISO As String
            Set(value As String)

                _ISO = Trim(value.ToUpper())

            End Set
        End Property

        Public ReadOnly Property IdCountry(name As String) As Integer
            Get

                If _CountriesID.ContainsKey(name) Then

                    Return _CountriesID(name)

                Else

                    Return 0

                End If

            End Get
        End Property

        Public ReadOnly Property listOfCountries As DataTable
            Get

                Return _ListOfCountries

            End Get
        End Property

#End Region

#Region "Builders"

        Private Sub New(ConnectionString As String)

            setConnection(ConnectionString)
            loadUbicationsDefaults()
            _CountriesID = New Hashtable()

            loadCountries()

        End Sub

#End Region

#Region "Methods"

        Shared Function getInstance(connectionString As String)

            If myInstance Is Nothing Then

                myInstance = New Countries(connectionString)

            End If

            Return myInstance

        End Function

        Private Sub loadCountries()

            Dim list As DataTable

            Query = "select * from CatPaises order by nombrePais"

            list = ExecuteRead()

            If list IsNot Nothing Then

                _ListOfCountries = list

                _CountriesID.Clear()

                For Each row As DataRow In list.Rows

                    _CountriesID.Add(row.Item(2), row.Item(0))

                Next

            End If

        End Sub

        Public Function saveCountry() As Boolean

            If ValidateData(TypeValidation.InsertQuery) = True Then

                Query = "SP_GuardarPais"

                parameters = New SqlParameter("@ISO", _ISO)
                parameters = New SqlParameter("@nombre", _Name)

                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "País registrado correctamente"
                    loadCountries()
                    Return True

                Else

                    Return False

                End If

            Else

                Return False

            End If

        End Function

        Public Function updateCountry(countryID As Integer) As Boolean

            _Id = countryID

            If ValidateData(TypeValidation.UpdateQuery) = True Then

                Query = "SP_ModificarPais"

                parameters = New SqlParameter("@ISOPais", _ISO)
                parameters = New SqlParameter("@Nombre", _Name)
                parameters = New SqlParameter("@id", countryID)


                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "País modificado correctamente"
                    loadCountries()
                    Return True

                Else

                    Return False

                End If

            Else

                Return False

            End If

        End Function

        Public Function DeleteCountry(CountryID As Integer) As Boolean

            _Id = CountryID

            If ValidateData(TypeValidation.DeleteQuery) = True Then

                Query = "SP_EliminarPais"

                parameters = New SqlParameter("@Id", CountryID)

                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "Pais eliminado correctamente"
                    loadCountries()
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

                    If String.IsNullOrWhiteSpace(_ISO) = True Then

                        flag = False

                        _Messages &= "   - ISO Pais" & vbNewLine

                    Else

                        If _ISO.Length <> 3 Then

                            flag = False

                            _Messages = "   - La clave " & _ISO & " no es valida" & vbNewLine
                            Process.Start("https://www.iso.org/obp/ui/#search/code")

                        End If

                    End If

                    If String.IsNullOrWhiteSpace(_Name) = True Then

                        flag = False
                        _Messages &= "   - Nombre" & vbNewLine

                    End If

                Case TypeValidation.UpdateQuery

                    If String.IsNullOrWhiteSpace(_ISO) = True Then

                        flag = False

                        _Messages &= "   - ISO Pais" & vbNewLine

                    End If

                    If _ISO.Length <> 3 Then

                        flag = False

                        _Messages &= "   - La clave " & _ISO & " no es valida" & vbNewLine
                        Process.Start("https://www.iso.org/obp/ui/#search/code")

                    End If

                    If String.IsNullOrWhiteSpace(_Name) = True Then

                        flag = False

                        _Messages &= "   - Nombre" & vbNewLine

                    End If

                Case TypeValidation.DeleteQuery

                    If _Id = 1 Then

                        flag = False

                        _Messages = "No se puede eliminar este país"

                    End If

                    If _Id = 2 Then

                        flag = False

                        _Messages = "No se puede eliminar este país"

                    End If

                    If _Id = 0 Then

                        flag = False

                        _Messages &= "  - Id" & vbNewLine

                    End If

            End Select

            Return flag

        End Function

#End Region

    End Class

End Namespace

