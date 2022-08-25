Imports System.Data.SqlClient
Public Class DbSIA
    Inherits Repository
    Implements IDbAdapter

#Region "Fields and propierties"

    Shared myInstance As DbSIA

    Private connection As SqlConnection = Nothing
    Private connectionString As String

    Private command As SqlCommand
    Private adapter As SqlDataAdapter

    Private _ErrorMessage As String

    Public ReadOnly Property ErrorMessage As String Implements IDbAdapter.ErrorMessage
        Get
            Return _ErrorMessage
        End Get
    End Property

#End Region

#Region "Builders"

    Private Sub New(connectionString As String)

        Me.connectionString = connectionString
        connection = New SqlConnection(Me.connectionString)

        command = New SqlCommand()
        adapter = New SqlDataAdapter()
        command.CommandTimeout = 180
        command.Connection = connection

    End Sub
#End Region

#Region "Methods"

    Shared Function getInstance(connectionString As String) As DbSIA

        If myInstance Is Nothing Then

            myInstance = New DbSIA(connectionString)

        End If

        Return myInstance

    End Function
    Protected Overrides Sub Connect()
        Try

            If connection.State = ConnectionState.Closed Then

                connection.Open()

            End If

        Catch SQLex As SqlException

            _ErrorMessage = SQLex.Message

        End Try
    End Sub

    Protected Overrides Sub Disconnect()
        Try

            If connection.State = ConnectionState.Open Then

                connection.Close()

            End If

        Catch SQLex As SqlException

            _ErrorMessage = SQLex.Message

        End Try
    End Sub

    Public Function ExecuteQuery(query As String, Optional typeQuery As IDbAdapter.typeQuery = IDbAdapter.typeQuery.TransactSQL, Optional executer As IDbAdapter.typeExecuter = IDbAdapter.typeExecuter.ExecuterNonQuery) As Object Implements IDbAdapter.ExecuteQuery
        'Función para ejecutar consultas del tipo insert,update y delete sin parametros
        Try

            command.CommandText = query

            If typeQuery = IDbAdapter.typeQuery.TransactSQL Then
                command.CommandType = CommandType.Text
            Else
                command.CommandType = CommandType.StoredProcedure
            End If

            Connect()

            If executer = IDbAdapter.typeExecuter.ExecuterNonQuery Then

                Return command.ExecuteNonQuery()

            Else

                Return command.ExecuteScalar()

            End If

        Catch ex As Exception

            If ex.Message.Contains("FK") Then

                _ErrorMessage = "No se puede eliminar este dato porqué esta siendo referenciado en otras tablas"

            Else

                _ErrorMessage = ex.Message

            End If


            Return Nothing

        Finally

            Disconnect()
            command.CommandText = Nothing

        End Try

    End Function

    Public Function ExecuteQuery(query As String, ByRef parameters As List(Of SqlParameter), Optional typeQuery As IDbAdapter.typeQuery = IDbAdapter.typeQuery.TransactSQL, Optional executer As IDbAdapter.typeExecuter = IDbAdapter.typeExecuter.ExecuterNonQuery) As Object Implements IDbAdapter.ExecuteQuery
        'Función para ejecutar consultas del tipo insert,update y delete con parametros
        Try

            command.CommandText = query

            If typeQuery = IDbAdapter.typeQuery.TransactSQL Then
                command.CommandType = CommandType.Text
            Else
                command.CommandType = CommandType.StoredProcedure
            End If

            For Each parameter As SqlParameter In parameters

                command.Parameters.Add(parameter)

            Next

            Connect()

            If executer = IDbAdapter.typeExecuter.ExecuterNonQuery Then

                Return command.ExecuteNonQuery()

            Else

                Return command.ExecuteScalar()

            End If

        Catch ex As Exception

            If ex.Message.Contains("FK") Then

                _ErrorMessage = "No se puede eliminar este dato porqué esta siendo referenciado en otras tablas"

            Else

                _ErrorMessage = ex.Message

            End If


            Return Nothing

        Finally

            Disconnect()
            command.CommandText = Nothing
            command.Parameters.Clear()
            parameters.Clear()

        End Try

    End Function

    Public Function ExecuteRead(query As String, Optional typeQuery As IDbAdapter.typeQuery = IDbAdapter.typeQuery.TransactSQL) As DataTable Implements IDbAdapter.ExecuteRead
        'Función para ejecutar consultas del tipo select sin parametros
        Try
            Dim result As New DataTable

            command.CommandText = query

            If typeQuery = IDbAdapter.typeQuery.TransactSQL Then

                command.CommandType = CommandType.Text

            Else

                command.CommandType = CommandType.StoredProcedure

            End If

            Connect()

            adapter.SelectCommand = command
            adapter.Fill(result)

            Return result

        Catch ex As Exception

            _ErrorMessage = ex.Message
            Return Nothing

        Finally

            Disconnect()
            command.CommandText = Nothing
            adapter.SelectCommand = Nothing

        End Try

    End Function

    Public Function ExecuteRead(query As String, ByRef parameters As List(Of SqlParameter), Optional typeQuery As IDbAdapter.typeQuery = IDbAdapter.typeQuery.TransactSQL) As DataTable Implements IDbAdapter.ExecuteRead

        'Función para ejecutar consultas del tipo select con parametros
        Try
            Dim result As New DataTable

            command.CommandText = query

            If typeQuery = IDbAdapter.typeQuery.TransactSQL Then

                command.CommandType = CommandType.Text

            Else

                command.CommandType = CommandType.StoredProcedure

            End If

            For Each parameter As SqlParameter In parameters

                command.Parameters.Add(parameter)

            Next

            Connect()

            adapter.SelectCommand = command
            adapter.Fill(result)

            Return result

        Catch ex As sqlException

            If ex.Message.Contains("FK") Then

                _ErrorMessage = "No se puede eliminar este dato porqué esta siendo referenciado en otras tablas"

            Else

                _ErrorMessage = ex.Message

            End If


            Return Nothing

        Finally

            Disconnect()
            command.CommandText = Nothing
            command.Parameters.Clear()
            adapter.SelectCommand = Nothing
            parameters.Clear()

        End Try

    End Function

#End Region

End Class
