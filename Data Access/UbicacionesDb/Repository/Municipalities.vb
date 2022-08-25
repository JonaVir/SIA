Imports System.Data.SqlClient

Namespace Municipalities

    Public Class Municipalities
        Inherits Locations

#Region "fields and propierties"

        Public Shared myInstance As Municipalities

        Private _municipalityID As Hashtable
        Private municipalities As DataTable
        Private listOfMunicipalities As DataView

        Private _countryID As Integer
        Private _estateID As Integer
        Private _municipalCode As String

        Public WriteOnly Property CountryID As Integer
            Set(value As Integer)

                _countryID = value

            End Set
        End Property

        Public WriteOnly Property estateID As Integer
            Set(value As Integer)

                _estateID = value

            End Set
        End Property

        Public WriteOnly Property municipalCode As String
            Set(value As String)

                _municipalCode = value

            End Set
        End Property

        Public ReadOnly Property MunicilityID(Name As String) As Integer
            Get

                If _municipalityID.ContainsKey(Name) Then

                    Return _municipalityID(Name)

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
            loadMunicipalities()

            _municipalityID = New Hashtable()
            listOfMunicipalities = New DataView()

            With listOfMunicipalities

                .Table = municipalities
                .AllowDelete = False
                .AllowEdit = False
                .AllowNew = False
                .ApplyDefaultSort = True

            End With

        End Sub
#End Region

#Region "Methods"

        Shared Function getInstance(connectionString As String) As Municipalities

            If myInstance Is Nothing Then

                myInstance = New Municipalities(connectionString)

            End If

            Return myInstance

        End Function

        Private Sub loadMunicipalities()

            Query = "select * from catMunicipios"

            municipalities = ExecuteRead()
            municipalities.TableName = "catMunicipios"
            If listOfMunicipalities IsNot Nothing Then

                listOfMunicipalities.Table = municipalities

            End If

        End Sub

        Public Function getMunicipalities(IdEstate As Integer) As DataTable

            Dim list As DataTable
            listOfMunicipalities.RowFilter = "idEstado =" & IdEstate

            list = listOfMunicipalities.ToTable()

            _municipalityID.Clear()

            For Each row As DataRow In list.Rows

                _municipalityID.Add(row.Item(4), row.Item(0))

            Next

            Return list

        End Function

        Public Function saveMunicipality() As Boolean

            If ValidateData(TypeValidation.InsertQuery) = True Then

                Query = "SP_GuardarMunicipio"

                parameters = New SqlParameter("@IdPais", _countryID)
                parameters = New SqlParameter("@IdEstado", _estateID)
                parameters = New SqlParameter("@clave", _municipalCode)
                parameters = New SqlParameter("@nombre", _Name)


                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "Municipio Registrado correctamente"
                    loadMunicipalities()
                    Return True

                Else

                    Return False

                End If

            Else

                Return False

            End If

        End Function

        Public Function updateMunicipality(municipalCode As Integer) As Boolean

            _Id = municipalCode

            If ValidateData(TypeValidation.UpdateQuery) = True Then

                Query = "SP_ModificarMunicipio"

                parameters = New SqlParameter("@clave", _municipalCode)
                parameters = New SqlParameter("@Nombre", _Name)
                parameters = New SqlParameter("@id", _Id)

                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "Municipio modificado correctamente"
                    loadMunicipalities()
                    Return True

                Else

                    Return False

                End If

            Else

                Return False

            End If

        End Function

        Public Function deleteMunicipality(MunicipalCode As Integer) As Boolean

            _Id = MunicipalCode

            If ValidateData(TypeValidation.DeleteQuery) = True Then

                Query = "SP_EliminarMunicipio"
                parameters = New SqlParameter("@Id", _Id)

                If ExecuteQuery(IDbAdapter.typeQuery.StoredProcedure) > 0 Then

                    _Messages = "Municipio eliminado correctamente"
                    loadMunicipalities()
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

                    If _countryID = 0 Then

                        flag = False
                        _Messages &= "  - Id País" & vbNewLine

                    End If

                    If _estateID = 0 Then

                        flag = False
                        _Messages &= "  - Id Estado" & vbNewLine

                    End If

                    If String.IsNullOrEmpty(_municipalCode) Then

                        flag = False
                        _Messages &= "  - Codigo municipal" & vbNewLine

                    End If

                    If String.IsNullOrEmpty(_Name) Then

                        flag = False
                        _Messages &= "  - Nombre" & vbNewLine

                    End If

                Case TypeValidation.UpdateQuery

                    If String.IsNullOrEmpty(_municipalCode) Then

                        flag = False
                        _Messages &= "  - Codigo municipal" & vbNewLine

                    End If

                    If String.IsNullOrEmpty(_Name) Then

                        flag = False
                        _Messages &= "  - Nombre" & vbNewLine

                    End If

                    If _Id = 0 Then

                        flag = False
                        _Messages &= "  - Id" & vbNewLine

                    End If

                Case TypeValidation.DeleteQuery

                    If _Id = 0 Then

                        flag = False
                        _Messages &= "  - Id" & vbNewLine

                    End If

                    If _estateID = 14 Then

                        flag = False
                        _Messages = "No se puede eliminar este municipio"

                    End If

            End Select

            Return flag

        End Function
#End Region

    End Class

End Namespace

