Imports ClientDb
Public Class FrmContacts

#Region "fields and propierties"

    Private repository As ClientContact
    Private _clientID As Integer
    Private _ContactID As Integer

    Public WriteOnly Property ContactID As Integer
        Set(value As Integer)

            _ContactID = value

        End Set
    End Property

    Public WriteOnly Property clientID As Integer
        Set(value As Integer)

            _clientID = value

        End Set
    End Property

    Public Property ContactName As String
        Get

            Return Trim(cdtName.Text)

        End Get
        Set(value As String)

            cdtName.Text = value

        End Set
    End Property

    Public Property Telephone As String
        Get

            Return Trim(cdtTelephone.Text)

        End Get
        Set(value As String)

            cdtTelephone.Text = value

        End Set
    End Property

    Public Property Extension As String
        Get

            Return Trim(cdtExtension.Text)

        End Get
        Set(value As String)

            cdtExtension.Text = value

        End Set
    End Property

    Public Property CellPhone As String
        Get

            Return Trim(cdtCellPhone.Text)

        End Get
        Set(value As String)

            cdtCellPhone.Text = value

        End Set
    End Property

    Public Property Email As String
        Get

            Return Trim(cdtEmail.Text)

        End Get
        Set(value As String)

            cdtEmail.Text = value

        End Set
    End Property

    Public Property Job As String
        Get

            Return Trim(cdtJob.Text)

        End Get
        Set(value As String)


            cdtJob.Text = value

        End Set
    End Property

#End Region

#Region "Builders"

    Public Sub New(ConnectionString As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        repository = ClientContact.getInstance(ConnectionString)

    End Sub

#End Region

#Region "Methods"

    Private Sub Save()

        With repository

            .Name = Me.ContactName
            .Telephone = Me.Telephone
            .Extension = Me.Extension
            .CellPhone = Me.CellPhone
            .Email = Me.Email
            .Job = Me.Job

            If .SaveContact(_clientID) Then

                MsgBox(.messages, MsgBoxStyle.Information)
                CType(Me.Owner, FrmClients).contactsDirectory = repository.getContacts(_clientID)
                Me.Close()

            Else

                MsgBox(.messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub Modify()

        With repository

            .ContactID = _ContactID
            .Name = Me.ContactName
            .Telephone = Me.Telephone
            .Extension = Me.Extension
            .CellPhone = Me.CellPhone
            .Email = Me.Email
            .Job = Me.Job

            If .ModifyContact(_clientID) Then

                MsgBox(.messages, MsgBoxStyle.Information)
                CType(Me.Owner, FrmClients).contactsDirectory = repository.getContacts(_clientID)
                Me.Close()

            Else

                MsgBox(.messages, MsgBoxStyle.Exclamation)

            End If

        End With
    End Sub

    Private Sub ClearForm()

        ContactName = Nothing
        Telephone = Nothing
        Extension = Nothing
        CellPhone = Nothing
        Email = Nothing
        Job = Nothing

    End Sub

#End Region

#Region "Methods of events"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Save()

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        Modify()

    End Sub

    Private Sub FrmContacts_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        ClearForm()

    End Sub

#End Region
End Class