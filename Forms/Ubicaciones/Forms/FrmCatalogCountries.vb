Imports LocationsDb.Coutries
Imports LocationsDb.States
Imports LocationsDb.Municipalities
Public Class FrmCatalogCountries

#Region "fields and propierties"

    Private _User As String
    Private _permissions As String
    Private _ConectionString As String
    Private country As Countries
    Private states As States
    Private municipality As Municipalities

    Private ISOCountry As Integer
    Private ISOEstate As Integer
    Private keycode As Integer

    Private WriteOnly Property user As String
        Set(value As String)

            _User = Trim(value)

        End Set
    End Property

    Public WriteOnly Property permissions As String
        Set(value As String)

            _permissions = Trim(value)

        End Set
    End Property

    Public WriteOnly Property ConectionString As String
        Set(value As String)

            _ConectionString = Trim(value)

        End Set
    End Property

    Private Property ISOCode As String
        Get

            Return cdtClave.Text

        End Get
        Set(value As String)

            cdtClave.Text = value

        End Set
    End Property

    Private Property nameLocation As String
        Get

            Return CdtNombre.Text

        End Get
        Set(value As String)

            CdtNombre.Text = value

        End Set
    End Property

#End Region

#Region "Builders"

    Public Sub New(user As String, permissions As String, conectionString As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.user = user
        Me.permissions = permissions
        Me.ConectionString = conectionString

        BtnAdd.Visible = permissions.Contains("INS")

        country = Countries.getInstance(conectionString)
        states = states.getInstance(conectionString)
        municipality = Municipalities.getInstance(conectionString)

        rbtnCountry.Checked = True

    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        country = Countries.getInstance(_ConectionString)
        states = states.getInstance(_ConectionString)
        municipality = Municipalities.getInstance(_ConectionString)

        rbtnCountry.Checked = True

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadContries()

        Dim table As DataTable

        table = country.listOfCountries

        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Column1", "ID")
        Me.DataGridView1.Columns.Add("Column2", "Clave ISO")
        Me.DataGridView1.Columns.Add("Column3", "Nombre Pais")
        Me.DataGridView1.Columns(0).Visible = False

        For f = 0 To table.Rows.Count - 1

            Me.DataGridView1.Rows.Add(table.Rows(f).Item(0), table.Rows(f).Item(1), table.Rows(f).Item(2))
            Me.DataGridView1.Columns(1).Width = Me.DataGridView1.Columns(1).GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, False)

        Next

    End Sub

    Private Sub LoadEstaties()

        Dim table As DataTable

        table = states.getEstates(ISOCountry)

        Me.DataGridView1.Columns.Clear()

        Me.DataGridView1.Columns.Add("Column1", "ID")
        Me.DataGridView1.Columns.Add("Column2", "ISO Pais")
        Me.DataGridView1.Columns.Add("Column3", "ISO Estado")
        Me.DataGridView1.Columns.Add("Column4", "Nombre estado")

        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(1).Visible = False

        For f = 0 To table.Rows.Count - 1

            Me.DataGridView1.Rows.Add(table.Rows(f).Item(0), table.Rows(f).Item(1), table.Rows(f).Item(2), table.Rows(f).Item(3))
            Me.DataGridView1.Columns(2).Width = Me.DataGridView1.Columns(2).GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, False)

        Next

    End Sub

    Private Sub LoadMunicipalities()

        Dim table As DataTable

        table = municipality.getMunicipalities(ISOEstate)

        Me.DataGridView1.Columns.Clear()

        With Me.DataGridView1

            .Columns.Add("Column1", "Id")
            .Columns.Add("Column2", "ISO Pais")
            .Columns.Add("Column3", "ISO Estado")
            .Columns.Add("Column4", "Clave")
            .Columns.Add("Column5", "Nombre municipio")
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = False

        End With

        For f = 0 To table.Rows.Count - 1

            Me.DataGridView1.Rows.Add(table.Rows(f).Item(0), table.Rows(f).Item(1), table.Rows(f).Item(2), table.Rows(f).Item(3), table.Rows(f).Item(4))
            Me.DataGridView1.Columns(3).Width = Me.DataGridView1.Columns(3).GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, False)

        Next

    End Sub

    Private Sub SaveCountry()

        With country

            .ISO = Me.ISOCode
            .name = Me.nameLocation

            If .saveCountry() = True Then

                LoadContries()
                ClearForm()

                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub ModifyCountry()

        With country

            .ISO = Me.ISOCode
            .name = Me.nameLocation

            If .updateCountry(keycode) = True Then

                LoadContries()
                ClearForm()

                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub DeleteCountry()

        With country

            If .DeleteCountry(keycode) = True Then

                LoadContries()
                ClearForm()
                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With
    End Sub

    Private Sub saveEstate()

        With states

            .idCountry = Me.ISOCountry
            .ISO = Me.ISOCode
            .name = Me.nameLocation

            If .saveEstate() = True Then

                LoadEstaties()
                ClearForm()

                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub modifyEstate()

        With states

            .ISO = Me.ISOCode
            .name = Me.nameLocation

            If .updateEstate(keycode) = True Then

                LoadEstaties()
                ClearForm()

                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub deleteState()

        With states

            If .deleteState(keycode) = True Then

                LoadEstaties()
                ClearForm()

                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub
    Private Sub SaveMunicipality()

        With municipality

            .CountryID = Me.ISOCountry
            .estateID = Me.ISOEstate
            .municipalCode = ISOCode
            .name = Me.nameLocation

            If .saveMunicipality() = True Then

                LoadMunicipalities()
                ClearForm()

                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub modifyMunicipality()

        With municipality

            .municipalCode = Me.ISOCode
            .name = Me.nameLocation

            If .updateMunicipality(keycode) = True Then

                LoadMunicipalities()
                ClearForm()

                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub

    Private Sub DeleteMunicipality()

        With municipality

            .estateID = ISOEstate

            If .deleteMunicipality(keycode) = True Then

                LoadMunicipalities()
                ClearForm()
                MsgBox(.Messages, MsgBoxStyle.Information)

            Else

                MsgBox(.Messages, MsgBoxStyle.Exclamation)

            End If

        End With

    End Sub
    Private Sub ClearForm()

        btnModify.Visible = False
        btnDelete.Visible = False
        btnCancel.Visible = False
        BtnAdd.Visible = _permissions.Contains("INS")

        nameLocation = Nothing
        ISOCode = Nothing

    End Sub

    Private Sub selectData()

        If rbtnCountry.Checked = True Then

            keycode = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString()
            ISOCode = Me.DataGridView1.CurrentRow.Cells(1).Value.ToString()
            nameLocation = Me.DataGridView1.CurrentRow.Cells(2).Value.ToString()

        ElseIf rbtnEstate.Checked = True Then

            keycode = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString()
            ISOCode = Me.DataGridView1.CurrentRow.Cells(2).Value.ToString()
            nameLocation = Me.DataGridView1.CurrentRow.Cells(3).Value.ToString()

        Else

            keycode = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString()
            ISOCode = Me.DataGridView1.CurrentRow.Cells(3).Value.ToString()
            nameLocation = Me.DataGridView1.CurrentRow.Cells(4).Value.ToString()

        End If

        btnModify.Visible = _permissions.Contains("CAM")
        btnDelete.Visible = _permissions.Contains("ELI")
        btnCancel.Visible = True
        BtnAdd.Visible = False

    End Sub

#End Region

#Region "Methods of events"

    Private Sub rbtnCountry_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCountry.CheckedChanged

        If Me.rbtnCountry.Checked = True Then

            cdtClave.PlaceHolderText = "ISO 3166-1 alfa 3"
            CdtNombre.PlaceHolderText = "Nombre país"
            LoadContries()

            ClearForm()

        End If

    End Sub

    Private Sub rbtnEstate_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnEstate.CheckedChanged

        If Me.rbtnEstate.Checked = True Then

            cdtClave.PlaceHolderText = "ISO 3166-2"
            CdtNombre.PlaceHolderText = "Nombre Estado"
            LoadEstaties()

            ClearForm()

        End If

    End Sub

    Private Sub rbtnMunicipality_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMunicipality.CheckedChanged

        If Me.rbtnMunicipality.Checked = True Then

            cdtClave.PlaceHolderText = "Clave"
            CdtNombre.PlaceHolderText = "Nombre Municipio"
            LoadMunicipalities()

            ClearForm()

        End If

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        selectData()

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

        If rbtnCountry.Checked = True Then

            ISOCountry = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString()

        ElseIf rbtnEstate.Checked Then

            ISOEstate = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString()

        End If

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If rbtnCountry.Checked = True Then

            ISOCountry = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString()

        ElseIf rbtnEstate.Checked Then

            ISOEstate = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString()

        End If

    End Sub

    Private Sub BtnAddUpdate_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If rbtnCountry.Checked = True Then

            SaveCountry()

        ElseIf rbtnEstate.Checked = True Then

            saveEstate()

        Else

            SaveMunicipality()

        End If

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        If rbtnCountry.Checked = True Then

            ModifyCountry()

        ElseIf rbtnEstate.Checked = True Then

            modifyEstate()

        Else

            modifyMunicipality()

        End If

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If rbtnCountry.Checked = True Then

            DeleteCountry()

        ElseIf rbtnEstate.Checked = True Then

            deleteState()

        Else

            DeleteMunicipality()

        End If

    End Sub

    Private Sub btnCancel_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseClick

        ClearForm()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Process.Start("https://www.iso.org/obp/ui/#search/code")

        If rbtnMunicipality.Checked = True Then

            Process.Start("https://cuentame.inegi.org.mx/monografias/default.aspx?tema=me")

        End If

    End Sub

    Private Sub FrmCatalogCountries_Load(sender As Object, e As EventArgs) Handles Me.Load

        If _permissions.Contains("DES") = False Then

            MsgBox("No tiene permiso de ingresar a este modulo", MsgBoxStyle.Information)
            Me.Close()

        End If

    End Sub

#End Region

End Class
