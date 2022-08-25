Public MustInherit Class Locations
    Inherits MasterRepository

#Region "fields and propierties"

    Protected _Id As Integer
    Protected _Name As String

    Public WriteOnly Property Id As Integer
        Set(value As Integer)

            _Id = value

        End Set
    End Property

    Public WriteOnly Property Name As String
        Set(value As String)

            _Name = Trim(value)

        End Set
    End Property

#End Region

#Region "Methods"

    Protected Sub loadUbicationsDefaults()

        Query = "SP_UbicacionesPredeterminadas"

        ExecuteQuery()

    End Sub

#End Region

End Class
