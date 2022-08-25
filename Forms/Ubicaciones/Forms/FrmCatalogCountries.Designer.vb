<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCatalogCountries
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatalogCountries))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnDelete = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnModify = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.BtnAdd = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.rbtnMunicipality = New CustomControls.ControlesPersonalizados.CustomRadioButton()
        Me.rbtnEstate = New CustomControls.ControlesPersonalizados.CustomRadioButton()
        Me.rbtnCountry = New CustomControls.ControlesPersonalizados.CustomRadioButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cdtClave = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CdtNombre = New CustomControls.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.cdtClave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CdtNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 109)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnModify)
        Me.Panel2.Controls.Add(Me.BtnAdd)
        Me.Panel2.Controls.Add(Me.rbtnMunicipality)
        Me.Panel2.Controls.Add(Me.rbtnEstate)
        Me.Panel2.Controls.Add(Me.rbtnCountry)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5, 3, 8, 3)
        Me.Panel2.Size = New System.Drawing.Size(689, 32)
        Me.Panel2.TabIndex = 12
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Navy
        Me.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.BorderSize = 0
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(361, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 26)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Navy
        Me.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDelete.BorderRadius = 8
        Me.btnDelete.BorderSize = 0
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(441, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 26)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.Navy
        Me.btnModify.BorderColor = System.Drawing.Color.Navy
        Me.btnModify.BorderRadius = 8
        Me.btnModify.BorderSize = 0
        Me.btnModify.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnModify.FlatAppearance.BorderSize = 0
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.ForeColor = System.Drawing.Color.White
        Me.btnModify.Location = New System.Drawing.Point(521, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 26)
        Me.btnModify.TabIndex = 11
        Me.btnModify.Text = "Modificar"
        Me.btnModify.UseVisualStyleBackColor = False
        Me.btnModify.Visible = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Navy
        Me.BtnAdd.BorderColor = System.Drawing.Color.Navy
        Me.BtnAdd.BorderRadius = 8
        Me.BtnAdd.BorderSize = 0
        Me.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(601, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(80, 26)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "Agregar"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'rbtnMunicipality
        '
        Me.rbtnMunicipality.AutoSize = True
        Me.rbtnMunicipality.CheckedColor = System.Drawing.Color.CornflowerBlue
        Me.rbtnMunicipality.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbtnMunicipality.Location = New System.Drawing.Point(149, 3)
        Me.rbtnMunicipality.MinimumSize = New System.Drawing.Size(0, 21)
        Me.rbtnMunicipality.Name = "rbtnMunicipality"
        Me.rbtnMunicipality.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rbtnMunicipality.Size = New System.Drawing.Size(156, 26)
        Me.rbtnMunicipality.TabIndex = 5
        Me.rbtnMunicipality.Text = "Municipio/ciudad"
        Me.rbtnMunicipality.UncheckedColor = System.Drawing.Color.Black
        Me.rbtnMunicipality.UseVisualStyleBackColor = True
        '
        'rbtnEstate
        '
        Me.rbtnEstate.AutoSize = True
        Me.rbtnEstate.CheckedColor = System.Drawing.Color.CornflowerBlue
        Me.rbtnEstate.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbtnEstate.Location = New System.Drawing.Point(68, 3)
        Me.rbtnEstate.MinimumSize = New System.Drawing.Size(0, 21)
        Me.rbtnEstate.Name = "rbtnEstate"
        Me.rbtnEstate.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rbtnEstate.Size = New System.Drawing.Size(81, 26)
        Me.rbtnEstate.TabIndex = 4
        Me.rbtnEstate.Text = "Estado"
        Me.rbtnEstate.UncheckedColor = System.Drawing.Color.Black
        Me.rbtnEstate.UseVisualStyleBackColor = True
        '
        'rbtnCountry
        '
        Me.rbtnCountry.AutoSize = True
        Me.rbtnCountry.CheckedColor = System.Drawing.Color.SteelBlue
        Me.rbtnCountry.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbtnCountry.Location = New System.Drawing.Point(5, 3)
        Me.rbtnCountry.MinimumSize = New System.Drawing.Size(0, 21)
        Me.rbtnCountry.Name = "rbtnCountry"
        Me.rbtnCountry.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rbtnCountry.Size = New System.Drawing.Size(63, 26)
        Me.rbtnCountry.TabIndex = 3
        Me.rbtnCountry.Text = "País"
        Me.rbtnCountry.UncheckedColor = System.Drawing.Color.Black
        Me.rbtnCountry.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(70, 16)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Lista claves"
        '
        'cdtClave
        '
        Me.cdtClave.BackColor = System.Drawing.Color.White
        Me.cdtClave.BorderColor = System.Drawing.Color.Black
        Me.cdtClave.BorderRadius = 0
        Me.cdtClave.BorderSize = 2
        Me.cdtClave.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtClave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtClave.ForeColor = System.Drawing.Color.Black
        Me.cdtClave.Location = New System.Drawing.Point(12, 28)
        Me.cdtClave.MultiLine = False
        Me.cdtClave.Name = "cdtClave"
        Me.cdtClave.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtClave.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtClave.PlaceHolderText = "ISO 3166-1 alfa 3"
        Me.cdtClave.ReadOnly = False
        Me.cdtClave.Size = New System.Drawing.Size(128, 28)
        Me.cdtClave.TabIndex = 1
        Me.cdtClave.UnderLinedStyle = True
        Me.cdtClave.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Clave"
        '
        'CdtNombre
        '
        Me.CdtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CdtNombre.BackColor = System.Drawing.Color.White
        Me.CdtNombre.BorderColor = System.Drawing.Color.Black
        Me.CdtNombre.BorderRadius = 0
        Me.CdtNombre.BorderSize = 2
        Me.CdtNombre.FocusColor = System.Drawing.Color.SteelBlue
        Me.CdtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdtNombre.ForeColor = System.Drawing.Color.Black
        Me.CdtNombre.Location = New System.Drawing.Point(146, 28)
        Me.CdtNombre.MultiLine = False
        Me.CdtNombre.Name = "CdtNombre"
        Me.CdtNombre.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.CdtNombre.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.CdtNombre.PlaceHolderText = ""
        Me.CdtNombre.ReadOnly = False
        Me.CdtNombre.Size = New System.Drawing.Size(531, 28)
        Me.CdtNombre.TabIndex = 2
        Me.CdtNombre.UnderLinedStyle = True
        Me.CdtNombre.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(0, 109)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(689, 352)
        Me.DataGridView1.TabIndex = 9
        '
        'FrmCatalogCountries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(689, 461)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(685, 500)
        Me.Name = "FrmCatalogCountries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo ubicaciones "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rbtnEstate As CustomControls.ControlesPersonalizados.CustomRadioButton
    Friend WithEvents rbtnMunicipality As CustomControls.ControlesPersonalizados.CustomRadioButton
    Friend WithEvents rbtnCountry As CustomControls.ControlesPersonalizados.CustomRadioButton
    Friend WithEvents CdtNombre As CustomControls.CustomTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cdtClave As CustomControls.CustomTextBox
    Friend WithEvents BtnAdd As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnCancel As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnDelete As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnModify As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents Panel2 As Panel
End Class
