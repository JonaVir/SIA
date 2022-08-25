﻿Imports System.Data.SqlClient
Public Interface IDbAdapter

    ReadOnly Property ErrorMessage As String

    Overloads Function ExecuteQuery(query As String, Optional typeQuery As typeQuery = typeQuery.TransactSQL, Optional executer As typeExecuter = typeExecuter.ExecuterNonQuery) As Object
    Overloads Function ExecuteQuery(query As String, ByRef parameters As List(Of SqlParameter), Optional typeQuery As typeQuery = typeQuery.TransactSQL, Optional executer As typeExecuter = typeExecuter.ExecuterNonQuery) As Object
    Overloads Function ExecuteRead(query As String, Optional typeQuery As typeQuery = typeQuery.TransactSQL) As DataTable
    Overloads Function ExecuteRead(query As String, ByRef parameters As List(Of SqlParameter), Optional typeQuery As typeQuery = typeQuery.TransactSQL) As DataTable

    Enum typeQuery

        TransactSQL
        StoredProcedure

    End Enum

    Enum typeExecuter

        ExecuterNonQuery
        ExecuterScalar

    End Enum

End Interface
