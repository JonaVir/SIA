Imports System.ComponentModel
Imports ProveedoresDb
Public Class FrmSupliersContacts

#Region "Fields and properties"

    Private ContactsRepository As SupplierContacts

    Private _SupplierID As Integer
    Private _ContactID As Integer

    Public WriteOnly Property SupplierID As Integer
        Set(value As Integer)

            _SupplierID = value

        End Set
    End Property

    Public WriteOnly Property OpenAS As Integer
        Set(value As Integer)

            If value = 1 Then

                btnSave.Visible = True

            Else

                btnModify.Visible = True

            End If

        End Set
    End Property
    Public Property ContactID As Integer
        Get

            Return _ContactID

        End Get
        Set(value As Integer)

            _ContactID = value

        End Set
    End Property

    Public Property ContactName As String
        Get

            Return Trim(cdtName.Text)

        End Get
        Set(value As String)

            cdtName.Text = Trim(value)

        End Set
    End Property

    Public Property Telephone As String
        Get

            Return Trim(cdtTelephone.Text)

        End Get
        Set(value As String)

            cdtTelephone.Text = Trim(value)

        End Set
    End Property

    Public Property Extension As String
        Get

            Return Trim(cdtExtension.Text)

        End Get
        Set(value As String)

            cdtExtension.Text = Trim(value)

        End Set
    End Property

    Public Property Cellphone As String
        Get

            Return Trim(cdtCellphone.Text)

        End Get
        Set(value As String)

            cdtCellphone.Text = Trim(value)

        End Set
    End Property

    Public Property Email As String
        Get

            Return Trim(cdtEmail.Text)

        End Get
        Set(value As String)

            cdtEmail.Text = Trim(value)

        End Set
    End Property

    Public Property JobPosition As String
        Get

            Return Trim(cdtJobPosition.Text)

        End Get
        Set(value As String)

            cdtJobPosition.Text = Trim(value)

        End Set
    End Property

#End Region

#Region "Builders"

    Public Sub New(ContactsRepository As SupplierContacts)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ContactsRepository = ContactsRepository

    End Sub

#End Region

#Region "Methods"

    Private Sub SaveContact()

        With ContactsRepository

            .Fullname = ContactName
            .Telephone = Telephone
            .Extension = Extension
            .Cellphone = Cellphone
            .Email = Email
            .JobPosition = JobPosition

            If .save(_SupplierID) = True Then

                MsgBox(.Messages, MsgBoxStyle.Information)
                CType(Me.Owner, FrmProveedores).ListOfContacts = .getContacts(_SupplierID)
                Me.Close()

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With
    End Sub

    Private Sub ModifyContact()

        With ContactsRepository

            .Fullname = ContactName
            .Telephone = Telephone
            .Extension = Extension
            .Cellphone = Cellphone
            .Email = Email
            .JobPosition = JobPosition

            If .modify(_SupplierID, ContactID) = True Then

                MsgBox(.Messages, MsgBoxStyle.Information)
                CType(Me.Owner, FrmProveedores).ListOfContacts = .getContacts(_SupplierID)
                Me.Close()

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub ClearForm()

        ContactName = Nothing
        Telephone = Nothing
        Extension = Nothing
        Cellphone = Nothing
        Email = Nothing
        JobPosition = Nothing

        btnModify.Visible = False
        btnSave.Visible = False

    End Sub

#End Region

#Region "Methods of events"

    Private Sub FrmSupliersContacts_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        ClearForm()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SaveContact()

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        ModifyContact()

    End Sub

#End Region

End Class