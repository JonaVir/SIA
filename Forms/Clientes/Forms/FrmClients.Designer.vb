<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClients
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClients))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CkBxBloqueo = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cdtWeb = New CustomControls.CustomTextBox()
        Me.ckBxClientAAA = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cdtTelephone = New CustomControls.CustomTextBox()
        Me.cdtPostalCode = New CustomControls.CustomTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cdtCologne = New CustomControls.CustomTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxMunicipality = New System.Windows.Forms.ComboBox()
        Me.cbxState = New System.Windows.Forms.ComboBox()
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cdtNumberExterior = New CustomControls.CustomTextBox()
        Me.cdtNumberInterior = New CustomControls.CustomTextBox()
        Me.cdtStreetClient = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdtNameClient = New CustomControls.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenuDataClient = New System.Windows.Forms.Panel()
        Me.menuItemBankReferences = New System.Windows.Forms.Button()
        Me.menuItemFinancialData = New System.Windows.Forms.Button()
        Me.menuItemContactDetails = New System.Windows.Forms.Button()
        Me.menuItemTaxData = New System.Windows.Forms.Button()
        Me.PanelContentMenu = New System.Windows.Forms.Panel()
        Me.ContainFinancialData = New System.Windows.Forms.Panel()
        Me.dgvFinancialData = New System.Windows.Forms.DataGridView()
        Me.CustomPanel4 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnDeleteFinancialData = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnModifyFinancialData = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnAddFinancialData = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.containBankReferences = New System.Windows.Forms.Panel()
        Me.dgvBankReferences = New System.Windows.Forms.DataGridView()
        Me.CustomPanel5 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnDeleteBankReference = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnModifyBankReference = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnAddBankReference = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.ContainTaxData = New System.Windows.Forms.Panel()
        Me.dgvTaxData = New System.Windows.Forms.DataGridView()
        Me.CustomPanel2 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnDeleteTaxData = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.BtnModifyTax = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnAddTax = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.ContainContactDetails = New System.Windows.Forms.Panel()
        Me.dgvContactsDetails = New System.Windows.Forms.DataGridView()
        Me.CustomPanel3 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnDeleteContact = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnModifyContactDetails = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnaddContactDetail = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.CustomPanel1 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnExportData = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSelectClient = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnAddClient = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDeleteClient = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnModifyClient = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.PanelMenuDataClient.SuspendLayout()
        Me.PanelContentMenu.SuspendLayout()
        Me.ContainFinancialData.SuspendLayout()
        CType(Me.dgvFinancialData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel4.SuspendLayout()
        Me.containBankReferences.SuspendLayout()
        CType(Me.dgvBankReferences, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel5.SuspendLayout()
        Me.ContainTaxData.SuspendLayout()
        CType(Me.dgvTaxData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel2.SuspendLayout()
        Me.ContainContactDetails.SuspendLayout()
        CType(Me.dgvContactsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel3.SuspendLayout()
        Me.CustomPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CkBxBloqueo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cdtWeb)
        Me.Panel1.Controls.Add(Me.ckBxClientAAA)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cdtTelephone)
        Me.Panel1.Controls.Add(Me.cdtPostalCode)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cdtCologne)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cbxMunicipality)
        Me.Panel1.Controls.Add(Me.cbxState)
        Me.Panel1.Controls.Add(Me.cbxCountry)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cdtNumberExterior)
        Me.Panel1.Controls.Add(Me.cdtNumberInterior)
        Me.Panel1.Controls.Add(Me.cdtStreetClient)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cdtNameClient)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PanelMenuDataClient)
        Me.Panel1.Controls.Add(Me.PanelContentMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 533)
        Me.Panel1.TabIndex = 0
        '
        'CkBxBloqueo
        '
        Me.CkBxBloqueo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CkBxBloqueo.AutoSize = True
        Me.CkBxBloqueo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkBxBloqueo.Location = New System.Drawing.Point(652, 37)
        Me.CkBxBloqueo.Name = "CkBxBloqueo"
        Me.CkBxBloqueo.Size = New System.Drawing.Size(86, 20)
        Me.CkBxBloqueo.TabIndex = 28
        Me.CkBxBloqueo.Text = "Bloquear"
        Me.CkBxBloqueo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Pagina web"
        '
        'cdtWeb
        '
        Me.cdtWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtWeb.BackColor = System.Drawing.SystemColors.Window
        Me.cdtWeb.BorderColor = System.Drawing.Color.Black
        Me.cdtWeb.BorderRadius = 0
        Me.cdtWeb.BorderSize = 2
        Me.cdtWeb.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtWeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtWeb.ForeColor = System.Drawing.Color.Black
        Me.cdtWeb.Location = New System.Drawing.Point(12, 89)
        Me.cdtWeb.MultiLine = False
        Me.cdtWeb.Name = "cdtWeb"
        Me.cdtWeb.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtWeb.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtWeb.PlaceHolderText = ""
        Me.cdtWeb.ReadOnly = False
        Me.cdtWeb.Size = New System.Drawing.Size(751, 28)
        Me.cdtWeb.TabIndex = 3
        Me.cdtWeb.UnderLinedStyle = True
        Me.cdtWeb.UseSystemPasswordChar = False
        '
        'ckBxClientAAA
        '
        Me.ckBxClientAAA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckBxClientAAA.AutoSize = True
        Me.ckBxClientAAA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckBxClientAAA.Location = New System.Drawing.Point(652, 18)
        Me.ckBxClientAAA.Name = "ckBxClientAAA"
        Me.ckBxClientAAA.Size = New System.Drawing.Size(107, 20)
        Me.ckBxClientAAA.TabIndex = 25
        Me.ckBxClientAAA.Text = "Cliente AAA"
        Me.ckBxClientAAA.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(470, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Telefono"
        '
        'cdtTelephone
        '
        Me.cdtTelephone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtTelephone.BackColor = System.Drawing.SystemColors.Window
        Me.cdtTelephone.BorderColor = System.Drawing.Color.Black
        Me.cdtTelephone.BorderRadius = 0
        Me.cdtTelephone.BorderSize = 2
        Me.cdtTelephone.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtTelephone.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtTelephone.ForeColor = System.Drawing.Color.Black
        Me.cdtTelephone.Location = New System.Drawing.Point(473, 31)
        Me.cdtTelephone.MultiLine = False
        Me.cdtTelephone.Name = "cdtTelephone"
        Me.cdtTelephone.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtTelephone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtTelephone.PlaceHolderText = ""
        Me.cdtTelephone.ReadOnly = False
        Me.cdtTelephone.Size = New System.Drawing.Size(168, 28)
        Me.cdtTelephone.TabIndex = 2
        Me.cdtTelephone.UnderLinedStyle = True
        Me.cdtTelephone.UseSystemPasswordChar = False
        '
        'cdtPostalCode
        '
        Me.cdtPostalCode.BackColor = System.Drawing.SystemColors.Window
        Me.cdtPostalCode.BorderColor = System.Drawing.Color.Black
        Me.cdtPostalCode.BorderRadius = 0
        Me.cdtPostalCode.BorderSize = 2
        Me.cdtPostalCode.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtPostalCode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtPostalCode.ForeColor = System.Drawing.Color.Black
        Me.cdtPostalCode.Location = New System.Drawing.Point(269, 267)
        Me.cdtPostalCode.MultiLine = False
        Me.cdtPostalCode.Name = "cdtPostalCode"
        Me.cdtPostalCode.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtPostalCode.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtPostalCode.PlaceHolderText = ""
        Me.cdtPostalCode.ReadOnly = False
        Me.cdtPostalCode.Size = New System.Drawing.Size(109, 28)
        Me.cdtPostalCode.TabIndex = 11
        Me.cdtPostalCode.UnderLinedStyle = True
        Me.cdtPostalCode.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(269, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Codigo postal"
        '
        'cdtCologne
        '
        Me.cdtCologne.BackColor = System.Drawing.SystemColors.Window
        Me.cdtCologne.BorderColor = System.Drawing.Color.Black
        Me.cdtCologne.BorderRadius = 0
        Me.cdtCologne.BorderSize = 2
        Me.cdtCologne.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtCologne.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtCologne.ForeColor = System.Drawing.Color.Black
        Me.cdtCologne.Location = New System.Drawing.Point(12, 267)
        Me.cdtCologne.MultiLine = False
        Me.cdtCologne.Name = "cdtCologne"
        Me.cdtCologne.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCologne.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCologne.PlaceHolderText = ""
        Me.cdtCologne.ReadOnly = False
        Me.cdtCologne.Size = New System.Drawing.Size(251, 28)
        Me.cdtCologne.TabIndex = 10
        Me.cdtCologne.UnderLinedStyle = True
        Me.cdtCologne.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Colonia"
        '
        'cbxMunicipality
        '
        Me.cbxMunicipality.BackColor = System.Drawing.Color.Azure
        Me.cbxMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMunicipality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMunicipality.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMunicipality.FormattingEnabled = True
        Me.cbxMunicipality.Location = New System.Drawing.Point(526, 211)
        Me.cbxMunicipality.Name = "cbxMunicipality"
        Me.cbxMunicipality.Size = New System.Drawing.Size(236, 25)
        Me.cbxMunicipality.TabIndex = 9
        '
        'cbxState
        '
        Me.cbxState.BackColor = System.Drawing.Color.Azure
        Me.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(269, 211)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(251, 25)
        Me.cbxState.TabIndex = 8
        '
        'cbxCountry
        '
        Me.cbxCountry.BackColor = System.Drawing.Color.Azure
        Me.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCountry.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(12, 211)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(251, 25)
        Me.cbxCountry.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "País"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(266, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(523, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Municipio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(483, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No. Exterior"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(624, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No. Interior"
        '
        'cdtNumberExterior
        '
        Me.cdtNumberExterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtNumberExterior.BackColor = System.Drawing.SystemColors.Window
        Me.cdtNumberExterior.BorderColor = System.Drawing.Color.Black
        Me.cdtNumberExterior.BorderRadius = 0
        Me.cdtNumberExterior.BorderSize = 2
        Me.cdtNumberExterior.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtNumberExterior.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtNumberExterior.ForeColor = System.Drawing.Color.Black
        Me.cdtNumberExterior.Location = New System.Drawing.Point(487, 151)
        Me.cdtNumberExterior.MultiLine = False
        Me.cdtNumberExterior.Name = "cdtNumberExterior"
        Me.cdtNumberExterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberExterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberExterior.PlaceHolderText = ""
        Me.cdtNumberExterior.ReadOnly = False
        Me.cdtNumberExterior.Size = New System.Drawing.Size(135, 28)
        Me.cdtNumberExterior.TabIndex = 5
        Me.cdtNumberExterior.UnderLinedStyle = True
        Me.cdtNumberExterior.UseSystemPasswordChar = False
        '
        'cdtNumberInterior
        '
        Me.cdtNumberInterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtNumberInterior.BackColor = System.Drawing.SystemColors.Window
        Me.cdtNumberInterior.BorderColor = System.Drawing.Color.Black
        Me.cdtNumberInterior.BorderRadius = 0
        Me.cdtNumberInterior.BorderSize = 2
        Me.cdtNumberInterior.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtNumberInterior.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtNumberInterior.ForeColor = System.Drawing.Color.Black
        Me.cdtNumberInterior.Location = New System.Drawing.Point(628, 151)
        Me.cdtNumberInterior.MultiLine = False
        Me.cdtNumberInterior.Name = "cdtNumberInterior"
        Me.cdtNumberInterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberInterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberInterior.PlaceHolderText = ""
        Me.cdtNumberInterior.ReadOnly = False
        Me.cdtNumberInterior.Size = New System.Drawing.Size(135, 28)
        Me.cdtNumberInterior.TabIndex = 6
        Me.cdtNumberInterior.UnderLinedStyle = True
        Me.cdtNumberInterior.UseSystemPasswordChar = False
        '
        'cdtStreetClient
        '
        Me.cdtStreetClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtStreetClient.BackColor = System.Drawing.SystemColors.Window
        Me.cdtStreetClient.BorderColor = System.Drawing.Color.Black
        Me.cdtStreetClient.BorderRadius = 0
        Me.cdtStreetClient.BorderSize = 2
        Me.cdtStreetClient.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtStreetClient.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtStreetClient.ForeColor = System.Drawing.Color.Black
        Me.cdtStreetClient.Location = New System.Drawing.Point(12, 151)
        Me.cdtStreetClient.MultiLine = False
        Me.cdtStreetClient.Name = "cdtStreetClient"
        Me.cdtStreetClient.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtStreetClient.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtStreetClient.PlaceHolderText = ""
        Me.cdtStreetClient.ReadOnly = False
        Me.cdtStreetClient.Size = New System.Drawing.Size(469, 28)
        Me.cdtStreetClient.TabIndex = 4
        Me.cdtStreetClient.UnderLinedStyle = True
        Me.cdtStreetClient.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calle"
        '
        'cdtNameClient
        '
        Me.cdtNameClient.BackColor = System.Drawing.SystemColors.Window
        Me.cdtNameClient.BorderColor = System.Drawing.Color.Black
        Me.cdtNameClient.BorderRadius = 0
        Me.cdtNameClient.BorderSize = 2
        Me.cdtNameClient.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtNameClient.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtNameClient.ForeColor = System.Drawing.Color.Black
        Me.cdtNameClient.Location = New System.Drawing.Point(12, 31)
        Me.cdtNameClient.MultiLine = False
        Me.cdtNameClient.Name = "cdtNameClient"
        Me.cdtNameClient.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNameClient.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNameClient.PlaceHolderText = ""
        Me.cdtNameClient.ReadOnly = False
        Me.cdtNameClient.Size = New System.Drawing.Size(455, 28)
        Me.cdtNameClient.TabIndex = 1
        Me.cdtNameClient.UnderLinedStyle = True
        Me.cdtNameClient.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'PanelMenuDataClient
        '
        Me.PanelMenuDataClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenuDataClient.Controls.Add(Me.menuItemBankReferences)
        Me.PanelMenuDataClient.Controls.Add(Me.menuItemFinancialData)
        Me.PanelMenuDataClient.Controls.Add(Me.menuItemContactDetails)
        Me.PanelMenuDataClient.Controls.Add(Me.menuItemTaxData)
        Me.PanelMenuDataClient.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMenuDataClient.Location = New System.Drawing.Point(0, 304)
        Me.PanelMenuDataClient.Name = "PanelMenuDataClient"
        Me.PanelMenuDataClient.Size = New System.Drawing.Size(779, 25)
        Me.PanelMenuDataClient.TabIndex = 0
        Me.PanelMenuDataClient.Visible = False
        '
        'menuItemBankReferences
        '
        Me.menuItemBankReferences.BackColor = System.Drawing.Color.White
        Me.menuItemBankReferences.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuItemBankReferences.FlatAppearance.BorderSize = 0
        Me.menuItemBankReferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuItemBankReferences.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemBankReferences.Location = New System.Drawing.Point(358, 0)
        Me.menuItemBankReferences.Name = "menuItemBankReferences"
        Me.menuItemBankReferences.Size = New System.Drawing.Size(163, 23)
        Me.menuItemBankReferences.TabIndex = 2
        Me.menuItemBankReferences.TabStop = False
        Me.menuItemBankReferences.Tag = "BankReferences"
        Me.menuItemBankReferences.Text = "Referencias bancarias"
        Me.menuItemBankReferences.UseVisualStyleBackColor = False
        '
        'menuItemFinancialData
        '
        Me.menuItemFinancialData.BackColor = System.Drawing.Color.White
        Me.menuItemFinancialData.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuItemFinancialData.FlatAppearance.BorderSize = 0
        Me.menuItemFinancialData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuItemFinancialData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemFinancialData.Location = New System.Drawing.Point(228, 0)
        Me.menuItemFinancialData.Name = "menuItemFinancialData"
        Me.menuItemFinancialData.Size = New System.Drawing.Size(130, 23)
        Me.menuItemFinancialData.TabIndex = 1
        Me.menuItemFinancialData.TabStop = False
        Me.menuItemFinancialData.Tag = "FinancialData"
        Me.menuItemFinancialData.Text = "Datos Financieros"
        Me.menuItemFinancialData.UseVisualStyleBackColor = False
        '
        'menuItemContactDetails
        '
        Me.menuItemContactDetails.BackColor = System.Drawing.Color.White
        Me.menuItemContactDetails.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuItemContactDetails.FlatAppearance.BorderSize = 0
        Me.menuItemContactDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuItemContactDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemContactDetails.Location = New System.Drawing.Point(107, 0)
        Me.menuItemContactDetails.Name = "menuItemContactDetails"
        Me.menuItemContactDetails.Size = New System.Drawing.Size(121, 23)
        Me.menuItemContactDetails.TabIndex = 0
        Me.menuItemContactDetails.TabStop = False
        Me.menuItemContactDetails.Tag = "Contacts"
        Me.menuItemContactDetails.Text = "Datos Contactos"
        Me.menuItemContactDetails.UseVisualStyleBackColor = False
        '
        'menuItemTaxData
        '
        Me.menuItemTaxData.BackColor = System.Drawing.Color.SteelBlue
        Me.menuItemTaxData.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuItemTaxData.FlatAppearance.BorderSize = 0
        Me.menuItemTaxData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuItemTaxData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemTaxData.ForeColor = System.Drawing.Color.White
        Me.menuItemTaxData.Location = New System.Drawing.Point(0, 0)
        Me.menuItemTaxData.Name = "menuItemTaxData"
        Me.menuItemTaxData.Size = New System.Drawing.Size(107, 23)
        Me.menuItemTaxData.TabIndex = 0
        Me.menuItemTaxData.TabStop = False
        Me.menuItemTaxData.Tag = "TaxData"
        Me.menuItemTaxData.Text = "Datos Fiscales"
        Me.menuItemTaxData.UseVisualStyleBackColor = False
        '
        'PanelContentMenu
        '
        Me.PanelContentMenu.Controls.Add(Me.ContainFinancialData)
        Me.PanelContentMenu.Controls.Add(Me.containBankReferences)
        Me.PanelContentMenu.Controls.Add(Me.ContainTaxData)
        Me.PanelContentMenu.Controls.Add(Me.ContainContactDetails)
        Me.PanelContentMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelContentMenu.Location = New System.Drawing.Point(0, 329)
        Me.PanelContentMenu.Name = "PanelContentMenu"
        Me.PanelContentMenu.Size = New System.Drawing.Size(779, 204)
        Me.PanelContentMenu.TabIndex = 1
        Me.PanelContentMenu.Visible = False
        '
        'ContainFinancialData
        '
        Me.ContainFinancialData.Controls.Add(Me.dgvFinancialData)
        Me.ContainFinancialData.Controls.Add(Me.CustomPanel4)
        Me.ContainFinancialData.Location = New System.Drawing.Point(490, 6)
        Me.ContainFinancialData.Name = "ContainFinancialData"
        Me.ContainFinancialData.Size = New System.Drawing.Size(135, 149)
        Me.ContainFinancialData.TabIndex = 5
        Me.ContainFinancialData.Tag = "FinancialData"
        Me.ContainFinancialData.Visible = False
        '
        'dgvFinancialData
        '
        Me.dgvFinancialData.AllowUserToAddRows = False
        Me.dgvFinancialData.AllowUserToDeleteRows = False
        Me.dgvFinancialData.AllowUserToResizeColumns = False
        Me.dgvFinancialData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFinancialData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFinancialData.BackgroundColor = System.Drawing.Color.White
        Me.dgvFinancialData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgvFinancialData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinancialData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFinancialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinancialData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFinancialData.EnableHeadersVisualStyles = False
        Me.dgvFinancialData.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvFinancialData.Location = New System.Drawing.Point(0, 40)
        Me.dgvFinancialData.MultiSelect = False
        Me.dgvFinancialData.Name = "dgvFinancialData"
        Me.dgvFinancialData.ReadOnly = True
        Me.dgvFinancialData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvFinancialData.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFinancialData.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFinancialData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFinancialData.Size = New System.Drawing.Size(135, 109)
        Me.dgvFinancialData.TabIndex = 0
        Me.dgvFinancialData.TabStop = False
        '
        'CustomPanel4
        '
        Me.CustomPanel4.BackColor = System.Drawing.Color.Azure
        Me.CustomPanel4.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.CustomPanel4.BorderColor = System.Drawing.Color.CadetBlue
        Me.CustomPanel4.BorderColor2 = System.Drawing.Color.CadetBlue
        Me.CustomPanel4.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CustomPanel4.BorderRadius = 3
        Me.CustomPanel4.BorderSize = 1
        Me.CustomPanel4.Controls.Add(Me.btnDeleteFinancialData)
        Me.CustomPanel4.Controls.Add(Me.btnModifyFinancialData)
        Me.CustomPanel4.Controls.Add(Me.btnAddFinancialData)
        Me.CustomPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel4.GradientAngle = 50.0!
        Me.CustomPanel4.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomPanel4.Name = "CustomPanel4"
        Me.CustomPanel4.Padding = New System.Windows.Forms.Padding(4)
        Me.CustomPanel4.Size = New System.Drawing.Size(135, 40)
        Me.CustomPanel4.TabIndex = 2
        '
        'btnDeleteFinancialData
        '
        Me.btnDeleteFinancialData.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteFinancialData.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteFinancialData.BorderRadius = 5
        Me.btnDeleteFinancialData.BorderSize = 0
        Me.btnDeleteFinancialData.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteFinancialData.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteFinancialData.FlatAppearance.BorderSize = 0
        Me.btnDeleteFinancialData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnDeleteFinancialData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteFinancialData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteFinancialData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteFinancialData.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteFinancialData.Image = Global.CustomerCatalog.My.Resources.Resources.eliminar
        Me.btnDeleteFinancialData.Location = New System.Drawing.Point(199, 4)
        Me.btnDeleteFinancialData.Name = "btnDeleteFinancialData"
        Me.btnDeleteFinancialData.Size = New System.Drawing.Size(100, 32)
        Me.btnDeleteFinancialData.TabIndex = 3
        Me.btnDeleteFinancialData.TabStop = False
        Me.btnDeleteFinancialData.Text = "Eliminar"
        Me.btnDeleteFinancialData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteFinancialData.UseVisualStyleBackColor = False
        '
        'btnModifyFinancialData
        '
        Me.btnModifyFinancialData.BackColor = System.Drawing.Color.Transparent
        Me.btnModifyFinancialData.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyFinancialData.BorderRadius = 5
        Me.btnModifyFinancialData.BorderSize = 0
        Me.btnModifyFinancialData.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModifyFinancialData.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyFinancialData.FlatAppearance.BorderSize = 0
        Me.btnModifyFinancialData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnModifyFinancialData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnModifyFinancialData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyFinancialData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyFinancialData.ForeColor = System.Drawing.Color.Black
        Me.btnModifyFinancialData.Image = Global.CustomerCatalog.My.Resources.Resources.editar
        Me.btnModifyFinancialData.Location = New System.Drawing.Point(99, 4)
        Me.btnModifyFinancialData.Name = "btnModifyFinancialData"
        Me.btnModifyFinancialData.Size = New System.Drawing.Size(100, 32)
        Me.btnModifyFinancialData.TabIndex = 1
        Me.btnModifyFinancialData.TabStop = False
        Me.btnModifyFinancialData.Text = "Editar"
        Me.btnModifyFinancialData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyFinancialData.UseVisualStyleBackColor = False
        '
        'btnAddFinancialData
        '
        Me.btnAddFinancialData.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFinancialData.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddFinancialData.BorderRadius = 5
        Me.btnAddFinancialData.BorderSize = 0
        Me.btnAddFinancialData.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddFinancialData.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddFinancialData.FlatAppearance.BorderSize = 0
        Me.btnAddFinancialData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnAddFinancialData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddFinancialData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFinancialData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFinancialData.ForeColor = System.Drawing.Color.Black
        Me.btnAddFinancialData.Image = Global.CustomerCatalog.My.Resources.Resources.Agregar_Elemento
        Me.btnAddFinancialData.Location = New System.Drawing.Point(4, 4)
        Me.btnAddFinancialData.Name = "btnAddFinancialData"
        Me.btnAddFinancialData.Size = New System.Drawing.Size(95, 32)
        Me.btnAddFinancialData.TabIndex = 0
        Me.btnAddFinancialData.TabStop = False
        Me.btnAddFinancialData.Text = "Agregar"
        Me.btnAddFinancialData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddFinancialData.UseVisualStyleBackColor = False
        '
        'containBankReferences
        '
        Me.containBankReferences.Controls.Add(Me.dgvBankReferences)
        Me.containBankReferences.Controls.Add(Me.CustomPanel5)
        Me.containBankReferences.Location = New System.Drawing.Point(631, 6)
        Me.containBankReferences.Name = "containBankReferences"
        Me.containBankReferences.Size = New System.Drawing.Size(135, 149)
        Me.containBankReferences.TabIndex = 6
        Me.containBankReferences.Tag = "BankReferences"
        Me.containBankReferences.Visible = False
        '
        'dgvBankReferences
        '
        Me.dgvBankReferences.AllowUserToAddRows = False
        Me.dgvBankReferences.AllowUserToDeleteRows = False
        Me.dgvBankReferences.AllowUserToResizeColumns = False
        Me.dgvBankReferences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBankReferences.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBankReferences.BackgroundColor = System.Drawing.Color.White
        Me.dgvBankReferences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgvBankReferences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBankReferences.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBankReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBankReferences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBankReferences.EnableHeadersVisualStyles = False
        Me.dgvBankReferences.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvBankReferences.Location = New System.Drawing.Point(0, 40)
        Me.dgvBankReferences.MultiSelect = False
        Me.dgvBankReferences.Name = "dgvBankReferences"
        Me.dgvBankReferences.ReadOnly = True
        Me.dgvBankReferences.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBankReferences.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBankReferences.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBankReferences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBankReferences.Size = New System.Drawing.Size(135, 109)
        Me.dgvBankReferences.TabIndex = 0
        Me.dgvBankReferences.TabStop = False
        '
        'CustomPanel5
        '
        Me.CustomPanel5.BackColor = System.Drawing.Color.Azure
        Me.CustomPanel5.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.CustomPanel5.BorderColor = System.Drawing.Color.CadetBlue
        Me.CustomPanel5.BorderColor2 = System.Drawing.Color.CadetBlue
        Me.CustomPanel5.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CustomPanel5.BorderRadius = 3
        Me.CustomPanel5.BorderSize = 1
        Me.CustomPanel5.Controls.Add(Me.btnDeleteBankReference)
        Me.CustomPanel5.Controls.Add(Me.btnModifyBankReference)
        Me.CustomPanel5.Controls.Add(Me.btnAddBankReference)
        Me.CustomPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel5.GradientAngle = 50.0!
        Me.CustomPanel5.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel5.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomPanel5.Name = "CustomPanel5"
        Me.CustomPanel5.Padding = New System.Windows.Forms.Padding(4)
        Me.CustomPanel5.Size = New System.Drawing.Size(135, 40)
        Me.CustomPanel5.TabIndex = 2
        '
        'btnDeleteBankReference
        '
        Me.btnDeleteBankReference.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteBankReference.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteBankReference.BorderRadius = 5
        Me.btnDeleteBankReference.BorderSize = 0
        Me.btnDeleteBankReference.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteBankReference.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteBankReference.FlatAppearance.BorderSize = 0
        Me.btnDeleteBankReference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnDeleteBankReference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteBankReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteBankReference.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBankReference.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteBankReference.Image = Global.CustomerCatalog.My.Resources.Resources.eliminar
        Me.btnDeleteBankReference.Location = New System.Drawing.Point(199, 4)
        Me.btnDeleteBankReference.Name = "btnDeleteBankReference"
        Me.btnDeleteBankReference.Size = New System.Drawing.Size(100, 32)
        Me.btnDeleteBankReference.TabIndex = 3
        Me.btnDeleteBankReference.TabStop = False
        Me.btnDeleteBankReference.Text = "Eliminar"
        Me.btnDeleteBankReference.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteBankReference.UseVisualStyleBackColor = False
        '
        'btnModifyBankReference
        '
        Me.btnModifyBankReference.BackColor = System.Drawing.Color.Transparent
        Me.btnModifyBankReference.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyBankReference.BorderRadius = 5
        Me.btnModifyBankReference.BorderSize = 0
        Me.btnModifyBankReference.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModifyBankReference.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyBankReference.FlatAppearance.BorderSize = 0
        Me.btnModifyBankReference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnModifyBankReference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnModifyBankReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyBankReference.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyBankReference.ForeColor = System.Drawing.Color.Black
        Me.btnModifyBankReference.Image = Global.CustomerCatalog.My.Resources.Resources.editar
        Me.btnModifyBankReference.Location = New System.Drawing.Point(99, 4)
        Me.btnModifyBankReference.Name = "btnModifyBankReference"
        Me.btnModifyBankReference.Size = New System.Drawing.Size(100, 32)
        Me.btnModifyBankReference.TabIndex = 1
        Me.btnModifyBankReference.TabStop = False
        Me.btnModifyBankReference.Text = "Editar"
        Me.btnModifyBankReference.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyBankReference.UseVisualStyleBackColor = False
        '
        'btnAddBankReference
        '
        Me.btnAddBankReference.BackColor = System.Drawing.Color.Transparent
        Me.btnAddBankReference.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddBankReference.BorderRadius = 5
        Me.btnAddBankReference.BorderSize = 0
        Me.btnAddBankReference.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddBankReference.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddBankReference.FlatAppearance.BorderSize = 0
        Me.btnAddBankReference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnAddBankReference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddBankReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBankReference.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBankReference.ForeColor = System.Drawing.Color.Black
        Me.btnAddBankReference.Image = Global.CustomerCatalog.My.Resources.Resources.Agregar_Elemento
        Me.btnAddBankReference.Location = New System.Drawing.Point(4, 4)
        Me.btnAddBankReference.Name = "btnAddBankReference"
        Me.btnAddBankReference.Size = New System.Drawing.Size(95, 32)
        Me.btnAddBankReference.TabIndex = 0
        Me.btnAddBankReference.TabStop = False
        Me.btnAddBankReference.Text = "Agregar"
        Me.btnAddBankReference.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddBankReference.UseVisualStyleBackColor = False
        '
        'ContainTaxData
        '
        Me.ContainTaxData.Controls.Add(Me.dgvTaxData)
        Me.ContainTaxData.Controls.Add(Me.CustomPanel2)
        Me.ContainTaxData.Location = New System.Drawing.Point(12, 6)
        Me.ContainTaxData.Name = "ContainTaxData"
        Me.ContainTaxData.Size = New System.Drawing.Size(135, 149)
        Me.ContainTaxData.TabIndex = 3
        Me.ContainTaxData.Tag = "TaxData"
        '
        'dgvTaxData
        '
        Me.dgvTaxData.AllowUserToAddRows = False
        Me.dgvTaxData.AllowUserToDeleteRows = False
        Me.dgvTaxData.AllowUserToResizeColumns = False
        Me.dgvTaxData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTaxData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTaxData.BackgroundColor = System.Drawing.Color.White
        Me.dgvTaxData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgvTaxData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTaxData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTaxData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaxData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTaxData.EnableHeadersVisualStyles = False
        Me.dgvTaxData.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvTaxData.Location = New System.Drawing.Point(0, 40)
        Me.dgvTaxData.MultiSelect = False
        Me.dgvTaxData.Name = "dgvTaxData"
        Me.dgvTaxData.ReadOnly = True
        Me.dgvTaxData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTaxData.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTaxData.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTaxData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvTaxData.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTaxData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTaxData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        Me.dgvTaxData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvTaxData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTaxData.Size = New System.Drawing.Size(135, 109)
        Me.dgvTaxData.TabIndex = 0
        Me.dgvTaxData.TabStop = False
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BackColor = System.Drawing.Color.Azure
        Me.CustomPanel2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.CustomPanel2.BorderColor = System.Drawing.Color.CadetBlue
        Me.CustomPanel2.BorderColor2 = System.Drawing.Color.CadetBlue
        Me.CustomPanel2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CustomPanel2.BorderRadius = 3
        Me.CustomPanel2.BorderSize = 1
        Me.CustomPanel2.Controls.Add(Me.btnDeleteTaxData)
        Me.CustomPanel2.Controls.Add(Me.BtnModifyTax)
        Me.CustomPanel2.Controls.Add(Me.btnAddTax)
        Me.CustomPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel2.GradientAngle = 50.0!
        Me.CustomPanel2.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Padding = New System.Windows.Forms.Padding(4)
        Me.CustomPanel2.Size = New System.Drawing.Size(135, 40)
        Me.CustomPanel2.TabIndex = 2
        '
        'btnDeleteTaxData
        '
        Me.btnDeleteTaxData.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteTaxData.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteTaxData.BorderRadius = 5
        Me.btnDeleteTaxData.BorderSize = 0
        Me.btnDeleteTaxData.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteTaxData.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteTaxData.FlatAppearance.BorderSize = 0
        Me.btnDeleteTaxData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnDeleteTaxData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteTaxData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTaxData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTaxData.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteTaxData.Image = Global.CustomerCatalog.My.Resources.Resources.eliminar
        Me.btnDeleteTaxData.Location = New System.Drawing.Point(199, 4)
        Me.btnDeleteTaxData.Name = "btnDeleteTaxData"
        Me.btnDeleteTaxData.Size = New System.Drawing.Size(100, 32)
        Me.btnDeleteTaxData.TabIndex = 0
        Me.btnDeleteTaxData.TabStop = False
        Me.btnDeleteTaxData.Text = "Eliminar"
        Me.btnDeleteTaxData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteTaxData.UseVisualStyleBackColor = False
        '
        'BtnModifyTax
        '
        Me.BtnModifyTax.BackColor = System.Drawing.Color.Transparent
        Me.BtnModifyTax.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.BtnModifyTax.BorderRadius = 5
        Me.BtnModifyTax.BorderSize = 0
        Me.BtnModifyTax.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnModifyTax.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.BtnModifyTax.FlatAppearance.BorderSize = 0
        Me.BtnModifyTax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BtnModifyTax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnModifyTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModifyTax.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifyTax.ForeColor = System.Drawing.Color.Black
        Me.BtnModifyTax.Image = Global.CustomerCatalog.My.Resources.Resources.editar
        Me.BtnModifyTax.Location = New System.Drawing.Point(99, 4)
        Me.BtnModifyTax.Name = "BtnModifyTax"
        Me.BtnModifyTax.Size = New System.Drawing.Size(100, 32)
        Me.BtnModifyTax.TabIndex = 0
        Me.BtnModifyTax.TabStop = False
        Me.BtnModifyTax.Text = "Editar"
        Me.BtnModifyTax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModifyTax.UseVisualStyleBackColor = False
        '
        'btnAddTax
        '
        Me.btnAddTax.BackColor = System.Drawing.Color.Transparent
        Me.btnAddTax.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddTax.BorderRadius = 5
        Me.btnAddTax.BorderSize = 0
        Me.btnAddTax.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddTax.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddTax.FlatAppearance.BorderSize = 0
        Me.btnAddTax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnAddTax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTax.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTax.ForeColor = System.Drawing.Color.Black
        Me.btnAddTax.Image = Global.CustomerCatalog.My.Resources.Resources.Agregar_Elemento
        Me.btnAddTax.Location = New System.Drawing.Point(4, 4)
        Me.btnAddTax.Name = "btnAddTax"
        Me.btnAddTax.Size = New System.Drawing.Size(95, 32)
        Me.btnAddTax.TabIndex = 0
        Me.btnAddTax.TabStop = False
        Me.btnAddTax.Text = "Agregar"
        Me.btnAddTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddTax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddTax.UseVisualStyleBackColor = False
        '
        'ContainContactDetails
        '
        Me.ContainContactDetails.Controls.Add(Me.dgvContactsDetails)
        Me.ContainContactDetails.Controls.Add(Me.CustomPanel3)
        Me.ContainContactDetails.Location = New System.Drawing.Point(153, 6)
        Me.ContainContactDetails.Name = "ContainContactDetails"
        Me.ContainContactDetails.Size = New System.Drawing.Size(135, 149)
        Me.ContainContactDetails.TabIndex = 4
        Me.ContainContactDetails.Tag = "Contacts"
        Me.ContainContactDetails.Visible = False
        '
        'dgvContactsDetails
        '
        Me.dgvContactsDetails.AllowUserToAddRows = False
        Me.dgvContactsDetails.AllowUserToDeleteRows = False
        Me.dgvContactsDetails.AllowUserToResizeColumns = False
        Me.dgvContactsDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvContactsDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvContactsDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvContactsDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgvContactsDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContactsDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvContactsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactsDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvContactsDetails.EnableHeadersVisualStyles = False
        Me.dgvContactsDetails.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvContactsDetails.Location = New System.Drawing.Point(0, 40)
        Me.dgvContactsDetails.MultiSelect = False
        Me.dgvContactsDetails.Name = "dgvContactsDetails"
        Me.dgvContactsDetails.ReadOnly = True
        Me.dgvContactsDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvContactsDetails.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvContactsDetails.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvContactsDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContactsDetails.Size = New System.Drawing.Size(135, 109)
        Me.dgvContactsDetails.TabIndex = 0
        Me.dgvContactsDetails.TabStop = False
        '
        'CustomPanel3
        '
        Me.CustomPanel3.BackColor = System.Drawing.Color.Azure
        Me.CustomPanel3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.CustomPanel3.BorderColor = System.Drawing.Color.CadetBlue
        Me.CustomPanel3.BorderColor2 = System.Drawing.Color.CadetBlue
        Me.CustomPanel3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CustomPanel3.BorderRadius = 3
        Me.CustomPanel3.BorderSize = 1
        Me.CustomPanel3.Controls.Add(Me.btnDeleteContact)
        Me.CustomPanel3.Controls.Add(Me.btnModifyContactDetails)
        Me.CustomPanel3.Controls.Add(Me.btnaddContactDetail)
        Me.CustomPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel3.GradientAngle = 50.0!
        Me.CustomPanel3.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomPanel3.Name = "CustomPanel3"
        Me.CustomPanel3.Padding = New System.Windows.Forms.Padding(4)
        Me.CustomPanel3.Size = New System.Drawing.Size(135, 40)
        Me.CustomPanel3.TabIndex = 2
        '
        'btnDeleteContact
        '
        Me.btnDeleteContact.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteContact.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteContact.BorderRadius = 5
        Me.btnDeleteContact.BorderSize = 0
        Me.btnDeleteContact.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteContact.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteContact.FlatAppearance.BorderSize = 0
        Me.btnDeleteContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnDeleteContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteContact.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteContact.Image = Global.CustomerCatalog.My.Resources.Resources.eliminar
        Me.btnDeleteContact.Location = New System.Drawing.Point(199, 4)
        Me.btnDeleteContact.Name = "btnDeleteContact"
        Me.btnDeleteContact.Size = New System.Drawing.Size(100, 32)
        Me.btnDeleteContact.TabIndex = 3
        Me.btnDeleteContact.TabStop = False
        Me.btnDeleteContact.Text = "Eliminar"
        Me.btnDeleteContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteContact.UseVisualStyleBackColor = False
        '
        'btnModifyContactDetails
        '
        Me.btnModifyContactDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnModifyContactDetails.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyContactDetails.BorderRadius = 5
        Me.btnModifyContactDetails.BorderSize = 0
        Me.btnModifyContactDetails.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModifyContactDetails.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyContactDetails.FlatAppearance.BorderSize = 0
        Me.btnModifyContactDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnModifyContactDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnModifyContactDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyContactDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyContactDetails.ForeColor = System.Drawing.Color.Black
        Me.btnModifyContactDetails.Image = Global.CustomerCatalog.My.Resources.Resources.editar
        Me.btnModifyContactDetails.Location = New System.Drawing.Point(99, 4)
        Me.btnModifyContactDetails.Name = "btnModifyContactDetails"
        Me.btnModifyContactDetails.Size = New System.Drawing.Size(100, 32)
        Me.btnModifyContactDetails.TabIndex = 1
        Me.btnModifyContactDetails.TabStop = False
        Me.btnModifyContactDetails.Text = "Editar"
        Me.btnModifyContactDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyContactDetails.UseVisualStyleBackColor = False
        '
        'btnaddContactDetail
        '
        Me.btnaddContactDetail.BackColor = System.Drawing.Color.Transparent
        Me.btnaddContactDetail.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnaddContactDetail.BorderRadius = 5
        Me.btnaddContactDetail.BorderSize = 0
        Me.btnaddContactDetail.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnaddContactDetail.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnaddContactDetail.FlatAppearance.BorderSize = 0
        Me.btnaddContactDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnaddContactDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnaddContactDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddContactDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddContactDetail.ForeColor = System.Drawing.Color.Black
        Me.btnaddContactDetail.Image = Global.CustomerCatalog.My.Resources.Resources.Agregar_Elemento
        Me.btnaddContactDetail.Location = New System.Drawing.Point(4, 4)
        Me.btnaddContactDetail.Name = "btnaddContactDetail"
        Me.btnaddContactDetail.Size = New System.Drawing.Size(95, 32)
        Me.btnaddContactDetail.TabIndex = 0
        Me.btnaddContactDetail.TabStop = False
        Me.btnaddContactDetail.Text = "Agregar"
        Me.btnaddContactDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddContactDetail.UseVisualStyleBackColor = False
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BackColor = System.Drawing.Color.Azure
        Me.CustomPanel1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.CustomPanel1.BorderColor = System.Drawing.Color.CadetBlue
        Me.CustomPanel1.BorderColor2 = System.Drawing.Color.CadetBlue
        Me.CustomPanel1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CustomPanel1.BorderRadius = 3
        Me.CustomPanel1.BorderSize = 1
        Me.CustomPanel1.Controls.Add(Me.btnExportData)
        Me.CustomPanel1.Controls.Add(Me.btnSelectClient)
        Me.CustomPanel1.Controls.Add(Me.btnAddClient)
        Me.CustomPanel1.Controls.Add(Me.btnDeleteClient)
        Me.CustomPanel1.Controls.Add(Me.btnModifyClient)
        Me.CustomPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel1.GradientAngle = 50.0!
        Me.CustomPanel1.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Padding = New System.Windows.Forms.Padding(4)
        Me.CustomPanel1.Size = New System.Drawing.Size(779, 56)
        Me.CustomPanel1.TabIndex = 1
        '
        'btnExportData
        '
        Me.btnExportData.BackColor = System.Drawing.Color.Transparent
        Me.btnExportData.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnExportData.BorderRadius = 5
        Me.btnExportData.BorderSize = 0
        Me.btnExportData.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExportData.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnExportData.FlatAppearance.BorderSize = 0
        Me.btnExportData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnExportData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportData.ForeColor = System.Drawing.Color.Black
        Me.btnExportData.Image = Global.CustomerCatalog.My.Resources.Resources.Excel
        Me.btnExportData.Location = New System.Drawing.Point(656, 4)
        Me.btnExportData.Name = "btnExportData"
        Me.btnExportData.Size = New System.Drawing.Size(119, 48)
        Me.btnExportData.TabIndex = 16
        Me.btnExportData.Text = "Exportar datos"
        Me.btnExportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportData.UseVisualStyleBackColor = False
        '
        'btnSelectClient
        '
        Me.btnSelectClient.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectClient.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSelectClient.BorderRadius = 5
        Me.btnSelectClient.BorderSize = 0
        Me.btnSelectClient.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelectClient.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSelectClient.FlatAppearance.BorderSize = 0
        Me.btnSelectClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnSelectClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectClient.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectClient.ForeColor = System.Drawing.Color.Black
        Me.btnSelectClient.Image = Global.CustomerCatalog.My.Resources.Resources.Seleccionar_persona
        Me.btnSelectClient.Location = New System.Drawing.Point(328, 4)
        Me.btnSelectClient.Name = "btnSelectClient"
        Me.btnSelectClient.Size = New System.Drawing.Size(93, 48)
        Me.btnSelectClient.TabIndex = 15
        Me.btnSelectClient.Text = "Seleccionar"
        Me.btnSelectClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSelectClient.UseVisualStyleBackColor = False
        '
        'btnAddClient
        '
        Me.btnAddClient.BackColor = System.Drawing.Color.Transparent
        Me.btnAddClient.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddClient.BorderRadius = 5
        Me.btnAddClient.BorderSize = 0
        Me.btnAddClient.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddClient.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddClient.FlatAppearance.BorderSize = 0
        Me.btnAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddClient.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClient.ForeColor = System.Drawing.Color.Black
        Me.btnAddClient.ImageIndex = 0
        Me.btnAddClient.ImageList = Me.ImageList1
        Me.btnAddClient.Location = New System.Drawing.Point(220, 4)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(108, 48)
        Me.btnAddClient.TabIndex = 14
        Me.btnAddClient.Text = "Nuevo Cliente"
        Me.btnAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddClient.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Add Client.png")
        Me.ImageList1.Images.SetKeyName(1, "editar.png")
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteClient.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteClient.BorderRadius = 5
        Me.btnDeleteClient.BorderSize = 0
        Me.btnDeleteClient.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteClient.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteClient.FlatAppearance.BorderSize = 0
        Me.btnDeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteClient.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteClient.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteClient.Image = Global.CustomerCatalog.My.Resources.Resources.eliminar
        Me.btnDeleteClient.Location = New System.Drawing.Point(112, 4)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(108, 48)
        Me.btnDeleteClient.TabIndex = 13
        Me.btnDeleteClient.Text = "Eliminar"
        Me.btnDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteClient.UseVisualStyleBackColor = False
        Me.btnDeleteClient.Visible = False
        '
        'btnModifyClient
        '
        Me.btnModifyClient.BackColor = System.Drawing.Color.Transparent
        Me.btnModifyClient.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyClient.BorderRadius = 5
        Me.btnModifyClient.BorderSize = 0
        Me.btnModifyClient.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModifyClient.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyClient.FlatAppearance.BorderSize = 0
        Me.btnModifyClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnModifyClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnModifyClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyClient.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyClient.ForeColor = System.Drawing.Color.Black
        Me.btnModifyClient.ImageIndex = 1
        Me.btnModifyClient.ImageList = Me.ImageList1
        Me.btnModifyClient.Location = New System.Drawing.Point(4, 4)
        Me.btnModifyClient.Name = "btnModifyClient"
        Me.btnModifyClient.Size = New System.Drawing.Size(108, 48)
        Me.btnModifyClient.TabIndex = 12
        Me.btnModifyClient.Text = "Modificar"
        Me.btnModifyClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnModifyClient.UseVisualStyleBackColor = False
        Me.btnModifyClient.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xlsx"
        '
        'FrmClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 589)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CustomPanel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmClients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMenuDataClient.ResumeLayout(False)
        Me.PanelContentMenu.ResumeLayout(False)
        Me.ContainFinancialData.ResumeLayout(False)
        CType(Me.dgvFinancialData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel4.ResumeLayout(False)
        Me.containBankReferences.ResumeLayout(False)
        CType(Me.dgvBankReferences, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel5.ResumeLayout(False)
        Me.ContainTaxData.ResumeLayout(False)
        CType(Me.dgvTaxData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel2.ResumeLayout(False)
        Me.ContainContactDetails.ResumeLayout(False)
        CType(Me.dgvContactsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel3.ResumeLayout(False)
        Me.CustomPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMenuDataClient As Panel
    Friend WithEvents PanelContentMenu As Panel
    Friend WithEvents CustomPanel1 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents btnAddClient As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnSelectClient As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnExportData As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents menuItemContactDetails As Button
    Friend WithEvents menuItemTaxData As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CustomPanel2 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents BtnModifyTax As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnAddTax As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents ContainContactDetails As Panel
    Friend WithEvents CustomPanel3 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents btnModifyContactDetails As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents ContainTaxData As Panel
    Friend WithEvents btnaddContactDetail As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnModifyClient As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnDeleteTaxData As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnDeleteContact As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnDeleteClient As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Private WithEvents cdtNameClient As CustomControls.CustomTextBox
    Private WithEvents ckBxClientAAA As CheckBox
    Private WithEvents cdtTelephone As CustomControls.CustomTextBox
    Private WithEvents cdtStreetClient As CustomControls.CustomTextBox
    Private WithEvents cdtNumberExterior As CustomControls.CustomTextBox
    Private WithEvents cdtNumberInterior As CustomControls.CustomTextBox
    Private WithEvents cbxMunicipality As ComboBox
    Private WithEvents cbxState As ComboBox
    Private WithEvents cbxCountry As ComboBox
    Private WithEvents dgvTaxData As DataGridView
    Private WithEvents dgvContactsDetails As DataGridView
    Private WithEvents cdtWeb As CustomControls.CustomTextBox
    Private WithEvents cdtPostalCode As CustomControls.CustomTextBox
    Private WithEvents cdtCologne As CustomControls.CustomTextBox
    Private WithEvents CkBxBloqueo As CheckBox
    Friend WithEvents ContainFinancialData As Panel
    Private WithEvents dgvFinancialData As DataGridView
    Friend WithEvents CustomPanel4 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents btnDeleteFinancialData As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnModifyFinancialData As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnAddFinancialData As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents menuItemFinancialData As Button
    Friend WithEvents menuItemBankReferences As Button
    Friend WithEvents containBankReferences As Panel
    Private WithEvents dgvBankReferences As DataGridView
    Friend WithEvents CustomPanel5 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents btnDeleteBankReference As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnModifyBankReference As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnAddBankReference As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
