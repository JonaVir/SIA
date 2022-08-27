<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProveedores
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedores))
        Me.CustomPanel1 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnExportData = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSelectSupplier = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnAddSupplier = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnCancel = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnDeleteSupplier = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnModifySupplier = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSaveSupplier = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CdtCURP = New CustomControls.CustomTextBox()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.cdtRFC = New CustomControls.CustomTextBox()
        Me.CkBxActivo = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cdtWeb = New CustomControls.CustomTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cdtTelephone = New CustomControls.CustomTextBox()
        Me.cdtPostalCode = New CustomControls.CustomTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cdtColony = New CustomControls.CustomTextBox()
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
        Me.cdtStreet = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdtSupplierName = New CustomControls.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenuDataSuppliers = New System.Windows.Forms.Panel()
        Me.menuItemBankDetails = New System.Windows.Forms.Button()
        Me.menuItemContacts = New System.Windows.Forms.Button()
        Me.PanelContentMenu = New System.Windows.Forms.Panel()
        Me.ContainContacts = New System.Windows.Forms.Panel()
        Me.dgvContacts = New System.Windows.Forms.DataGridView()
        Me.CustomPanel2 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnDeleteContact = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.BtnModifyContact = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnAddContact = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.ContainBankDetails = New System.Windows.Forms.Panel()
        Me.dgvBankDetails = New System.Windows.Forms.DataGridView()
        Me.CustomPanel3 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnDeleteBankDetail = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnModifyBankDetail = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnaddBankDetail = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.CustomPanel1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.PanelMenuDataSuppliers.SuspendLayout()
        Me.PanelContentMenu.SuspendLayout()
        Me.ContainContacts.SuspendLayout()
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel2.SuspendLayout()
        Me.ContainBankDetails.SuspendLayout()
        CType(Me.dgvBankDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.CustomPanel1.Controls.Add(Me.btnSelectSupplier)
        Me.CustomPanel1.Controls.Add(Me.btnAddSupplier)
        Me.CustomPanel1.Controls.Add(Me.btnCancel)
        Me.CustomPanel1.Controls.Add(Me.btnDeleteSupplier)
        Me.CustomPanel1.Controls.Add(Me.btnModifySupplier)
        Me.CustomPanel1.Controls.Add(Me.btnSaveSupplier)
        Me.CustomPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel1.GradientAngle = 50.0!
        Me.CustomPanel1.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Padding = New System.Windows.Forms.Padding(4)
        Me.CustomPanel1.Size = New System.Drawing.Size(776, 56)
        Me.CustomPanel1.TabIndex = 2
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
        Me.btnExportData.Image = Global.proveedores.My.Resources.Resources.Excel
        Me.btnExportData.Location = New System.Drawing.Point(653, 4)
        Me.btnExportData.Name = "btnExportData"
        Me.btnExportData.Size = New System.Drawing.Size(119, 48)
        Me.btnExportData.TabIndex = 16
        Me.btnExportData.Text = "Exportar datos"
        Me.btnExportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportData.UseVisualStyleBackColor = False
        '
        'btnSelectSupplier
        '
        Me.btnSelectSupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectSupplier.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSelectSupplier.BorderRadius = 5
        Me.btnSelectSupplier.BorderSize = 0
        Me.btnSelectSupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelectSupplier.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSelectSupplier.FlatAppearance.BorderSize = 0
        Me.btnSelectSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnSelectSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSelectSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectSupplier.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSupplier.ForeColor = System.Drawing.Color.Black
        Me.btnSelectSupplier.Image = Global.proveedores.My.Resources.Resources.Seleccionar_persona
        Me.btnSelectSupplier.Location = New System.Drawing.Point(532, 4)
        Me.btnSelectSupplier.Name = "btnSelectSupplier"
        Me.btnSelectSupplier.Size = New System.Drawing.Size(93, 48)
        Me.btnSelectSupplier.TabIndex = 15
        Me.btnSelectSupplier.Text = "Seleccionar"
        Me.btnSelectSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSelectSupplier.UseVisualStyleBackColor = False
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSupplier.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddSupplier.BorderRadius = 5
        Me.btnAddSupplier.BorderSize = 0
        Me.btnAddSupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddSupplier.FlatAppearance.BorderSize = 0
        Me.btnAddSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnAddSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSupplier.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSupplier.ForeColor = System.Drawing.Color.Black
        Me.btnAddSupplier.Image = Global.proveedores.My.Resources.Resources.Add_Client
        Me.btnAddSupplier.Location = New System.Drawing.Point(406, 4)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(126, 48)
        Me.btnAddSupplier.TabIndex = 14
        Me.btnAddSupplier.Text = "Nuevo Proveedor"
        Me.btnAddSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddSupplier.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.BorderSize = 0
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Image = Global.proveedores.My.Resources.Resources.Cancelar_Operacion
        Me.btnCancel.Location = New System.Drawing.Point(313, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 48)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'btnDeleteSupplier
        '
        Me.btnDeleteSupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteSupplier.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteSupplier.BorderRadius = 5
        Me.btnDeleteSupplier.BorderSize = 0
        Me.btnDeleteSupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteSupplier.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteSupplier.FlatAppearance.BorderSize = 0
        Me.btnDeleteSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnDeleteSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSupplier.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSupplier.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteSupplier.Image = Global.proveedores.My.Resources.Resources.eliminar
        Me.btnDeleteSupplier.Location = New System.Drawing.Point(205, 4)
        Me.btnDeleteSupplier.Name = "btnDeleteSupplier"
        Me.btnDeleteSupplier.Size = New System.Drawing.Size(108, 48)
        Me.btnDeleteSupplier.TabIndex = 13
        Me.btnDeleteSupplier.Text = "Eliminar"
        Me.btnDeleteSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteSupplier.UseVisualStyleBackColor = False
        Me.btnDeleteSupplier.Visible = False
        '
        'btnModifySupplier
        '
        Me.btnModifySupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnModifySupplier.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifySupplier.BorderRadius = 5
        Me.btnModifySupplier.BorderSize = 0
        Me.btnModifySupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModifySupplier.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifySupplier.FlatAppearance.BorderSize = 0
        Me.btnModifySupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnModifySupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnModifySupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifySupplier.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifySupplier.ForeColor = System.Drawing.Color.Black
        Me.btnModifySupplier.Image = Global.proveedores.My.Resources.Resources.editar
        Me.btnModifySupplier.Location = New System.Drawing.Point(97, 4)
        Me.btnModifySupplier.Name = "btnModifySupplier"
        Me.btnModifySupplier.Size = New System.Drawing.Size(108, 48)
        Me.btnModifySupplier.TabIndex = 12
        Me.btnModifySupplier.Text = "Modificar"
        Me.btnModifySupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnModifySupplier.UseVisualStyleBackColor = False
        Me.btnModifySupplier.Visible = False
        '
        'btnSaveSupplier
        '
        Me.btnSaveSupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveSupplier.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSaveSupplier.BorderRadius = 5
        Me.btnSaveSupplier.BorderSize = 0
        Me.btnSaveSupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSaveSupplier.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSaveSupplier.FlatAppearance.BorderSize = 0
        Me.btnSaveSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnSaveSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSaveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSupplier.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSupplier.ForeColor = System.Drawing.Color.Black
        Me.btnSaveSupplier.Image = Global.proveedores.My.Resources.Resources.Guardar_Datos
        Me.btnSaveSupplier.Location = New System.Drawing.Point(4, 4)
        Me.btnSaveSupplier.Name = "btnSaveSupplier"
        Me.btnSaveSupplier.Size = New System.Drawing.Size(93, 48)
        Me.btnSaveSupplier.TabIndex = 14
        Me.btnSaveSupplier.Text = "Guardar"
        Me.btnSaveSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSaveSupplier.UseVisualStyleBackColor = False
        Me.btnSaveSupplier.Visible = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Label12)
        Me.MainPanel.Controls.Add(Me.CdtCURP)
        Me.MainPanel.Controls.Add(Me.lblRFC)
        Me.MainPanel.Controls.Add(Me.cdtRFC)
        Me.MainPanel.Controls.Add(Me.CkBxActivo)
        Me.MainPanel.Controls.Add(Me.Label11)
        Me.MainPanel.Controls.Add(Me.cdtWeb)
        Me.MainPanel.Controls.Add(Me.Label10)
        Me.MainPanel.Controls.Add(Me.cdtTelephone)
        Me.MainPanel.Controls.Add(Me.cdtPostalCode)
        Me.MainPanel.Controls.Add(Me.Label9)
        Me.MainPanel.Controls.Add(Me.cdtColony)
        Me.MainPanel.Controls.Add(Me.Label8)
        Me.MainPanel.Controls.Add(Me.cbxMunicipality)
        Me.MainPanel.Controls.Add(Me.cbxState)
        Me.MainPanel.Controls.Add(Me.cbxCountry)
        Me.MainPanel.Controls.Add(Me.Label7)
        Me.MainPanel.Controls.Add(Me.Label6)
        Me.MainPanel.Controls.Add(Me.Label5)
        Me.MainPanel.Controls.Add(Me.Label4)
        Me.MainPanel.Controls.Add(Me.Label3)
        Me.MainPanel.Controls.Add(Me.cdtNumberExterior)
        Me.MainPanel.Controls.Add(Me.cdtNumberInterior)
        Me.MainPanel.Controls.Add(Me.cdtStreet)
        Me.MainPanel.Controls.Add(Me.Label2)
        Me.MainPanel.Controls.Add(Me.cdtSupplierName)
        Me.MainPanel.Controls.Add(Me.Label1)
        Me.MainPanel.Controls.Add(Me.PanelMenuDataSuppliers)
        Me.MainPanel.Controls.Add(Me.PanelContentMenu)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 56)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(776, 594)
        Me.MainPanel.TabIndex = 3
        Me.MainPanel.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(208, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "CURP"
        '
        'CdtCURP
        '
        Me.CdtCURP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CdtCURP.BackColor = System.Drawing.SystemColors.Window
        Me.CdtCURP.BorderColor = System.Drawing.Color.Black
        Me.CdtCURP.BorderRadius = 0
        Me.CdtCURP.BorderSize = 2
        Me.CdtCURP.FocusColor = System.Drawing.Color.SteelBlue
        Me.CdtCURP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdtCURP.ForeColor = System.Drawing.Color.Black
        Me.CdtCURP.Location = New System.Drawing.Point(211, 152)
        Me.CdtCURP.MultiLine = False
        Me.CdtCURP.Name = "CdtCURP"
        Me.CdtCURP.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.CdtCURP.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.CdtCURP.PlaceHolderText = ""
        Me.CdtCURP.ReadOnly = False
        Me.CdtCURP.Size = New System.Drawing.Size(199, 28)
        Me.CdtCURP.TabIndex = 5
        Me.CdtCURP.UnderLinedStyle = True
        Me.CdtCURP.UseSystemPasswordChar = False
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFC.Location = New System.Drawing.Point(12, 130)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(32, 16)
        Me.lblRFC.TabIndex = 30
        Me.lblRFC.Text = "RFC"
        '
        'cdtRFC
        '
        Me.cdtRFC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.cdtRFC.BorderColor = System.Drawing.Color.Black
        Me.cdtRFC.BorderRadius = 0
        Me.cdtRFC.BorderSize = 2
        Me.cdtRFC.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtRFC.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtRFC.ForeColor = System.Drawing.Color.Black
        Me.cdtRFC.Location = New System.Drawing.Point(12, 152)
        Me.cdtRFC.MultiLine = False
        Me.cdtRFC.Name = "cdtRFC"
        Me.cdtRFC.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtRFC.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtRFC.PlaceHolderText = ""
        Me.cdtRFC.ReadOnly = False
        Me.cdtRFC.Size = New System.Drawing.Size(193, 28)
        Me.cdtRFC.TabIndex = 4
        Me.cdtRFC.UnderLinedStyle = True
        Me.cdtRFC.UseSystemPasswordChar = False
        '
        'CkBxActivo
        '
        Me.CkBxActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CkBxActivo.AutoSize = True
        Me.CkBxActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkBxActivo.Location = New System.Drawing.Point(696, 11)
        Me.CkBxActivo.Name = "CkBxActivo"
        Me.CkBxActivo.Size = New System.Drawing.Size(68, 20)
        Me.CkBxActivo.TabIndex = 28
        Me.CkBxActivo.Text = "Activo"
        Me.CkBxActivo.UseVisualStyleBackColor = True
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
        Me.cdtWeb.Size = New System.Drawing.Size(752, 28)
        Me.cdtWeb.TabIndex = 3
        Me.cdtWeb.UnderLinedStyle = True
        Me.cdtWeb.UseSystemPasswordChar = False
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
        Me.cdtTelephone.Size = New System.Drawing.Size(217, 28)
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
        Me.cdtPostalCode.Location = New System.Drawing.Point(269, 318)
        Me.cdtPostalCode.MultiLine = False
        Me.cdtPostalCode.Name = "cdtPostalCode"
        Me.cdtPostalCode.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtPostalCode.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtPostalCode.PlaceHolderText = ""
        Me.cdtPostalCode.ReadOnly = False
        Me.cdtPostalCode.Size = New System.Drawing.Size(109, 28)
        Me.cdtPostalCode.TabIndex = 13
        Me.cdtPostalCode.UnderLinedStyle = True
        Me.cdtPostalCode.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(269, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Codigo postal"
        '
        'cdtColony
        '
        Me.cdtColony.BackColor = System.Drawing.SystemColors.Window
        Me.cdtColony.BorderColor = System.Drawing.Color.Black
        Me.cdtColony.BorderRadius = 0
        Me.cdtColony.BorderSize = 2
        Me.cdtColony.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtColony.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtColony.ForeColor = System.Drawing.Color.Black
        Me.cdtColony.Location = New System.Drawing.Point(12, 318)
        Me.cdtColony.MultiLine = False
        Me.cdtColony.Name = "cdtColony"
        Me.cdtColony.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtColony.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtColony.PlaceHolderText = ""
        Me.cdtColony.ReadOnly = False
        Me.cdtColony.Size = New System.Drawing.Size(251, 28)
        Me.cdtColony.TabIndex = 12
        Me.cdtColony.UnderLinedStyle = True
        Me.cdtColony.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 299)
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
        Me.cbxMunicipality.Location = New System.Drawing.Point(526, 262)
        Me.cbxMunicipality.Name = "cbxMunicipality"
        Me.cbxMunicipality.Size = New System.Drawing.Size(238, 25)
        Me.cbxMunicipality.TabIndex = 11
        '
        'cbxState
        '
        Me.cbxState.BackColor = System.Drawing.Color.Azure
        Me.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxState.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(269, 262)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(251, 25)
        Me.cbxState.TabIndex = 10
        '
        'cbxCountry
        '
        Me.cbxCountry.BackColor = System.Drawing.Color.Azure
        Me.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCountry.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(12, 262)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(251, 25)
        Me.cbxCountry.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "País"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(266, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(523, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Municipio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(481, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No. Exterior"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(622, 183)
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
        Me.cdtNumberExterior.Location = New System.Drawing.Point(484, 202)
        Me.cdtNumberExterior.MultiLine = False
        Me.cdtNumberExterior.Name = "cdtNumberExterior"
        Me.cdtNumberExterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberExterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberExterior.PlaceHolderText = ""
        Me.cdtNumberExterior.ReadOnly = False
        Me.cdtNumberExterior.Size = New System.Drawing.Size(135, 28)
        Me.cdtNumberExterior.TabIndex = 7
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
        Me.cdtNumberInterior.Location = New System.Drawing.Point(625, 202)
        Me.cdtNumberInterior.MultiLine = False
        Me.cdtNumberInterior.Name = "cdtNumberInterior"
        Me.cdtNumberInterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberInterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberInterior.PlaceHolderText = ""
        Me.cdtNumberInterior.ReadOnly = False
        Me.cdtNumberInterior.Size = New System.Drawing.Size(139, 28)
        Me.cdtNumberInterior.TabIndex = 8
        Me.cdtNumberInterior.UnderLinedStyle = True
        Me.cdtNumberInterior.UseSystemPasswordChar = False
        '
        'cdtStreet
        '
        Me.cdtStreet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtStreet.BackColor = System.Drawing.SystemColors.Window
        Me.cdtStreet.BorderColor = System.Drawing.Color.Black
        Me.cdtStreet.BorderRadius = 0
        Me.cdtStreet.BorderSize = 2
        Me.cdtStreet.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtStreet.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtStreet.ForeColor = System.Drawing.Color.Black
        Me.cdtStreet.Location = New System.Drawing.Point(12, 202)
        Me.cdtStreet.MultiLine = False
        Me.cdtStreet.Name = "cdtStreet"
        Me.cdtStreet.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtStreet.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtStreet.PlaceHolderText = ""
        Me.cdtStreet.ReadOnly = False
        Me.cdtStreet.Size = New System.Drawing.Size(466, 28)
        Me.cdtStreet.TabIndex = 6
        Me.cdtStreet.UnderLinedStyle = True
        Me.cdtStreet.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calle"
        '
        'cdtSupplierName
        '
        Me.cdtSupplierName.BackColor = System.Drawing.SystemColors.Window
        Me.cdtSupplierName.BorderColor = System.Drawing.Color.Black
        Me.cdtSupplierName.BorderRadius = 0
        Me.cdtSupplierName.BorderSize = 2
        Me.cdtSupplierName.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtSupplierName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtSupplierName.ForeColor = System.Drawing.Color.Black
        Me.cdtSupplierName.Location = New System.Drawing.Point(12, 31)
        Me.cdtSupplierName.MultiLine = False
        Me.cdtSupplierName.Name = "cdtSupplierName"
        Me.cdtSupplierName.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtSupplierName.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtSupplierName.PlaceHolderText = ""
        Me.cdtSupplierName.ReadOnly = False
        Me.cdtSupplierName.Size = New System.Drawing.Size(455, 28)
        Me.cdtSupplierName.TabIndex = 1
        Me.cdtSupplierName.UnderLinedStyle = True
        Me.cdtSupplierName.UseSystemPasswordChar = False
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
        'PanelMenuDataSuppliers
        '
        Me.PanelMenuDataSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenuDataSuppliers.Controls.Add(Me.menuItemBankDetails)
        Me.PanelMenuDataSuppliers.Controls.Add(Me.menuItemContacts)
        Me.PanelMenuDataSuppliers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMenuDataSuppliers.Location = New System.Drawing.Point(0, 365)
        Me.PanelMenuDataSuppliers.Name = "PanelMenuDataSuppliers"
        Me.PanelMenuDataSuppliers.Size = New System.Drawing.Size(776, 25)
        Me.PanelMenuDataSuppliers.TabIndex = 0
        Me.PanelMenuDataSuppliers.Visible = False
        '
        'menuItemBankDetails
        '
        Me.menuItemBankDetails.BackColor = System.Drawing.Color.White
        Me.menuItemBankDetails.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuItemBankDetails.FlatAppearance.BorderSize = 0
        Me.menuItemBankDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuItemBankDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemBankDetails.Location = New System.Drawing.Point(107, 0)
        Me.menuItemBankDetails.Name = "menuItemBankDetails"
        Me.menuItemBankDetails.Size = New System.Drawing.Size(121, 23)
        Me.menuItemBankDetails.TabIndex = 0
        Me.menuItemBankDetails.TabStop = False
        Me.menuItemBankDetails.Tag = "Bank Details"
        Me.menuItemBankDetails.Text = "Datos Bancarios"
        Me.menuItemBankDetails.UseVisualStyleBackColor = False
        '
        'menuItemContacts
        '
        Me.menuItemContacts.BackColor = System.Drawing.Color.SteelBlue
        Me.menuItemContacts.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuItemContacts.FlatAppearance.BorderSize = 0
        Me.menuItemContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuItemContacts.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemContacts.ForeColor = System.Drawing.Color.White
        Me.menuItemContacts.Location = New System.Drawing.Point(0, 0)
        Me.menuItemContacts.Name = "menuItemContacts"
        Me.menuItemContacts.Size = New System.Drawing.Size(107, 23)
        Me.menuItemContacts.TabIndex = 0
        Me.menuItemContacts.TabStop = False
        Me.menuItemContacts.Tag = "Contacts"
        Me.menuItemContacts.Text = "Contactos"
        Me.menuItemContacts.UseVisualStyleBackColor = False
        '
        'PanelContentMenu
        '
        Me.PanelContentMenu.Controls.Add(Me.ContainContacts)
        Me.PanelContentMenu.Controls.Add(Me.ContainBankDetails)
        Me.PanelContentMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelContentMenu.Location = New System.Drawing.Point(0, 390)
        Me.PanelContentMenu.Name = "PanelContentMenu"
        Me.PanelContentMenu.Size = New System.Drawing.Size(776, 204)
        Me.PanelContentMenu.TabIndex = 1
        Me.PanelContentMenu.Visible = False
        '
        'ContainContacts
        '
        Me.ContainContacts.Controls.Add(Me.dgvContacts)
        Me.ContainContacts.Controls.Add(Me.CustomPanel2)
        Me.ContainContacts.Location = New System.Drawing.Point(12, 6)
        Me.ContainContacts.Name = "ContainContacts"
        Me.ContainContacts.Size = New System.Drawing.Size(355, 186)
        Me.ContainContacts.TabIndex = 3
        Me.ContainContacts.Tag = "Contacts"
        '
        'dgvContacts
        '
        Me.dgvContacts.AllowUserToAddRows = False
        Me.dgvContacts.AllowUserToDeleteRows = False
        Me.dgvContacts.AllowUserToResizeColumns = False
        Me.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvContacts.BackgroundColor = System.Drawing.Color.White
        Me.dgvContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgvContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContacts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvContacts.EnableHeadersVisualStyles = False
        Me.dgvContacts.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvContacts.Location = New System.Drawing.Point(0, 40)
        Me.dgvContacts.MultiSelect = False
        Me.dgvContacts.Name = "dgvContacts"
        Me.dgvContacts.ReadOnly = True
        Me.dgvContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvContacts.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContacts.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvContacts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvContacts.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvContacts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvContacts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        Me.dgvContacts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContacts.Size = New System.Drawing.Size(355, 146)
        Me.dgvContacts.TabIndex = 0
        Me.dgvContacts.TabStop = False
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
        Me.CustomPanel2.Controls.Add(Me.btnDeleteContact)
        Me.CustomPanel2.Controls.Add(Me.BtnModifyContact)
        Me.CustomPanel2.Controls.Add(Me.btnAddContact)
        Me.CustomPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel2.GradientAngle = 50.0!
        Me.CustomPanel2.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Padding = New System.Windows.Forms.Padding(4)
        Me.CustomPanel2.Size = New System.Drawing.Size(355, 40)
        Me.CustomPanel2.TabIndex = 2
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
        Me.btnDeleteContact.Image = Global.proveedores.My.Resources.Resources.eliminar1
        Me.btnDeleteContact.Location = New System.Drawing.Point(199, 4)
        Me.btnDeleteContact.Name = "btnDeleteContact"
        Me.btnDeleteContact.Size = New System.Drawing.Size(100, 32)
        Me.btnDeleteContact.TabIndex = 0
        Me.btnDeleteContact.TabStop = False
        Me.btnDeleteContact.Text = "Eliminar"
        Me.btnDeleteContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteContact.UseVisualStyleBackColor = False
        '
        'BtnModifyContact
        '
        Me.BtnModifyContact.BackColor = System.Drawing.Color.Transparent
        Me.BtnModifyContact.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.BtnModifyContact.BorderRadius = 5
        Me.BtnModifyContact.BorderSize = 0
        Me.BtnModifyContact.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnModifyContact.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.BtnModifyContact.FlatAppearance.BorderSize = 0
        Me.BtnModifyContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BtnModifyContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnModifyContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModifyContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifyContact.ForeColor = System.Drawing.Color.Black
        Me.BtnModifyContact.Image = Global.proveedores.My.Resources.Resources.editar1
        Me.BtnModifyContact.Location = New System.Drawing.Point(99, 4)
        Me.BtnModifyContact.Name = "BtnModifyContact"
        Me.BtnModifyContact.Size = New System.Drawing.Size(100, 32)
        Me.BtnModifyContact.TabIndex = 0
        Me.BtnModifyContact.TabStop = False
        Me.BtnModifyContact.Text = "Editar"
        Me.BtnModifyContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModifyContact.UseVisualStyleBackColor = False
        '
        'btnAddContact
        '
        Me.btnAddContact.BackColor = System.Drawing.Color.Transparent
        Me.btnAddContact.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddContact.BorderRadius = 5
        Me.btnAddContact.BorderSize = 0
        Me.btnAddContact.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddContact.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddContact.FlatAppearance.BorderSize = 0
        Me.btnAddContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnAddContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddContact.ForeColor = System.Drawing.Color.Black
        Me.btnAddContact.Image = Global.proveedores.My.Resources.Resources.Agregar_Elemento
        Me.btnAddContact.Location = New System.Drawing.Point(4, 4)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(95, 32)
        Me.btnAddContact.TabIndex = 0
        Me.btnAddContact.TabStop = False
        Me.btnAddContact.Text = "Agregar"
        Me.btnAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddContact.UseVisualStyleBackColor = False
        '
        'ContainBankDetails
        '
        Me.ContainBankDetails.Controls.Add(Me.dgvBankDetails)
        Me.ContainBankDetails.Controls.Add(Me.CustomPanel3)
        Me.ContainBankDetails.Location = New System.Drawing.Point(373, 6)
        Me.ContainBankDetails.Name = "ContainBankDetails"
        Me.ContainBankDetails.Size = New System.Drawing.Size(391, 186)
        Me.ContainBankDetails.TabIndex = 4
        Me.ContainBankDetails.Tag = "Bank Details"
        Me.ContainBankDetails.Visible = False
        '
        'dgvBankDetails
        '
        Me.dgvBankDetails.AllowUserToAddRows = False
        Me.dgvBankDetails.AllowUserToDeleteRows = False
        Me.dgvBankDetails.AllowUserToResizeColumns = False
        Me.dgvBankDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBankDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBankDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvBankDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgvBankDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBankDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBankDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBankDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBankDetails.EnableHeadersVisualStyles = False
        Me.dgvBankDetails.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvBankDetails.Location = New System.Drawing.Point(0, 40)
        Me.dgvBankDetails.MultiSelect = False
        Me.dgvBankDetails.Name = "dgvBankDetails"
        Me.dgvBankDetails.ReadOnly = True
        Me.dgvBankDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBankDetails.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBankDetails.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBankDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBankDetails.Size = New System.Drawing.Size(391, 146)
        Me.dgvBankDetails.TabIndex = 0
        Me.dgvBankDetails.TabStop = False
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
        Me.CustomPanel3.Controls.Add(Me.btnDeleteBankDetail)
        Me.CustomPanel3.Controls.Add(Me.btnModifyBankDetail)
        Me.CustomPanel3.Controls.Add(Me.btnaddBankDetail)
        Me.CustomPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel3.GradientAngle = 50.0!
        Me.CustomPanel3.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CustomPanel3.Name = "CustomPanel3"
        Me.CustomPanel3.Padding = New System.Windows.Forms.Padding(4)
        Me.CustomPanel3.Size = New System.Drawing.Size(391, 40)
        Me.CustomPanel3.TabIndex = 2
        '
        'btnDeleteBankDetail
        '
        Me.btnDeleteBankDetail.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteBankDetail.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteBankDetail.BorderRadius = 5
        Me.btnDeleteBankDetail.BorderSize = 0
        Me.btnDeleteBankDetail.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteBankDetail.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnDeleteBankDetail.FlatAppearance.BorderSize = 0
        Me.btnDeleteBankDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnDeleteBankDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteBankDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteBankDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBankDetail.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteBankDetail.Image = Global.proveedores.My.Resources.Resources.eliminar
        Me.btnDeleteBankDetail.Location = New System.Drawing.Point(199, 4)
        Me.btnDeleteBankDetail.Name = "btnDeleteBankDetail"
        Me.btnDeleteBankDetail.Size = New System.Drawing.Size(100, 32)
        Me.btnDeleteBankDetail.TabIndex = 3
        Me.btnDeleteBankDetail.TabStop = False
        Me.btnDeleteBankDetail.Text = "Eliminar"
        Me.btnDeleteBankDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteBankDetail.UseVisualStyleBackColor = False
        '
        'btnModifyBankDetail
        '
        Me.btnModifyBankDetail.BackColor = System.Drawing.Color.Transparent
        Me.btnModifyBankDetail.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyBankDetail.BorderRadius = 5
        Me.btnModifyBankDetail.BorderSize = 0
        Me.btnModifyBankDetail.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModifyBankDetail.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModifyBankDetail.FlatAppearance.BorderSize = 0
        Me.btnModifyBankDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnModifyBankDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnModifyBankDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyBankDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyBankDetail.ForeColor = System.Drawing.Color.Black
        Me.btnModifyBankDetail.Image = Global.proveedores.My.Resources.Resources.editar1
        Me.btnModifyBankDetail.Location = New System.Drawing.Point(99, 4)
        Me.btnModifyBankDetail.Name = "btnModifyBankDetail"
        Me.btnModifyBankDetail.Size = New System.Drawing.Size(100, 32)
        Me.btnModifyBankDetail.TabIndex = 1
        Me.btnModifyBankDetail.TabStop = False
        Me.btnModifyBankDetail.Text = "Editar"
        Me.btnModifyBankDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyBankDetail.UseVisualStyleBackColor = False
        '
        'btnaddBankDetail
        '
        Me.btnaddBankDetail.BackColor = System.Drawing.Color.Transparent
        Me.btnaddBankDetail.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnaddBankDetail.BorderRadius = 5
        Me.btnaddBankDetail.BorderSize = 0
        Me.btnaddBankDetail.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnaddBankDetail.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnaddBankDetail.FlatAppearance.BorderSize = 0
        Me.btnaddBankDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnaddBankDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnaddBankDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddBankDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddBankDetail.ForeColor = System.Drawing.Color.Black
        Me.btnaddBankDetail.Image = Global.proveedores.My.Resources.Resources.Agregar_Elemento
        Me.btnaddBankDetail.Location = New System.Drawing.Point(4, 4)
        Me.btnaddBankDetail.Name = "btnaddBankDetail"
        Me.btnaddBankDetail.Size = New System.Drawing.Size(95, 32)
        Me.btnaddBankDetail.TabIndex = 0
        Me.btnaddBankDetail.TabStop = False
        Me.btnaddBankDetail.Text = "Agregar"
        Me.btnaddBankDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddBankDetail.UseVisualStyleBackColor = False
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 650)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.CustomPanel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.CustomPanel1.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.PanelMenuDataSuppliers.ResumeLayout(False)
        Me.PanelContentMenu.ResumeLayout(False)
        Me.ContainContacts.ResumeLayout(False)
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel2.ResumeLayout(False)
        Me.ContainBankDetails.ResumeLayout(False)
        CType(Me.dgvBankDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomPanel1 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents MainPanel As Panel
    Private WithEvents CkBxActivo As CheckBox
    Friend WithEvents Label11 As Label
    Private WithEvents cdtWeb As CustomControls.CustomTextBox
    Friend WithEvents Label10 As Label
    Private WithEvents cdtTelephone As CustomControls.CustomTextBox
    Private WithEvents cdtPostalCode As CustomControls.CustomTextBox
    Friend WithEvents Label9 As Label
    Private WithEvents cdtColony As CustomControls.CustomTextBox
    Friend WithEvents Label8 As Label
    Private WithEvents cbxMunicipality As ComboBox
    Private WithEvents cbxState As ComboBox
    Private WithEvents cbxCountry As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents cdtNumberExterior As CustomControls.CustomTextBox
    Private WithEvents cdtNumberInterior As CustomControls.CustomTextBox
    Private WithEvents cdtStreet As CustomControls.CustomTextBox
    Friend WithEvents Label2 As Label
    Private WithEvents cdtSupplierName As CustomControls.CustomTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMenuDataSuppliers As Panel
    Friend WithEvents menuItemBankDetails As Button
    Friend WithEvents menuItemContacts As Button
    Friend WithEvents PanelContentMenu As Panel
    Friend WithEvents ContainContacts As Panel
    Private WithEvents dgvContacts As DataGridView
    Friend WithEvents CustomPanel2 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents btnDeleteContact As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents BtnModifyContact As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnAddContact As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents ContainBankDetails As Panel
    Private WithEvents dgvBankDetails As DataGridView
    Friend WithEvents CustomPanel3 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents btnDeleteBankDetail As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnModifyBankDetail As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnaddBankDetail As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents Label12 As Label
    Private WithEvents CdtCURP As CustomControls.CustomTextBox
    Friend WithEvents lblRFC As Label
    Private WithEvents cdtRFC As CustomControls.CustomTextBox
    Private WithEvents btnSaveSupplier As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents btnModifySupplier As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents btnExportData As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents btnSelectSupplier As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents btnAddSupplier As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents btnDeleteSupplier As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents btnCancel As CustomControls.ControlesPersonalizados.CustomButton
End Class
