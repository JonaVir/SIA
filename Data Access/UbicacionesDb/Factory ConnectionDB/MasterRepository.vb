Imports System.Data.SqlClient

Public MustInherit Class MasterRepository

#Region "fields and propierties"

    Private _parameters As List(Of SqlParameter)
    Private _query As String
    Private Database As IDbAdapter
    Private result As Object

    Protected _Messages As String

    Public ReadOnly Property Messages
        Get

            Return _Messages

        End Get
    End Property

    Protected Property Query As String
        Get

            Return _query

        End Get
        Set(value As String)

            _query = value

        End Set
    End Property

    Protected WriteOnly Property parameters As SqlParameter
        Set(value As SqlParameter)

            _parameters.Add(value)

        End Set
    End Property

#End Region

#Region "Builders"

    Public Sub New()

        If _parameters Is Nothing Then

            _parameters = New List(Of SqlParameter)

        End If

    End Sub

#End Region

#Region "Methods"

    Protected MustOverride Function ValidateData(value As TypeValidation, Optional method As String = "") As Boolean

    Protected Sub setConnection(conectionString As String)

        Database = DbSIA.getInstance(conectionString)

    End Sub

    Protected Function ExecuteQuery(Optional typeQuery As IDbAdapter.typeQuery = IDbAdapter.typeQuery.TransactSQL, Optional executer As IDbAdapter.TypeExecuter = IDbAdapter.TypeExecuter.ExecuterNonQuery) As Object

        If _parameters.Count = 0 Then

            result = Database.ExecuteQuery(Query, typeQuery, executer)

        Else

            result = Database.ExecuteQuery(Query, _parameters, typeQuery, executer)

        End If

        _Messages = Database.ErrorMessage

        Return result

    End Function

    Protected Function ExecuteRead(Optional typeQuery As IDbAdapter.typeQuery = IDbAdapter.typeQuery.TransactSQL) As DataTable

        If _parameters.Count = 0 Then

            result = Database.ExecuteRead(Query, typeQuery)

        Else

            result = Database.ExecuteRead(Query, _parameters, typeQuery)

        End If

        _Messages = Database.ErrorMessage

        Return result

    End Function

#End Region

#Region "Enums"

    Protected Enum TypeValidation

        SelectQuery
        InsertQuery
        UpdateQuery
        DeleteQuery

    End Enum

#End Region

End Class
