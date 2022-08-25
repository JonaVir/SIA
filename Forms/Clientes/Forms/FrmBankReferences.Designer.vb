<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBankReferences
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBankReferences))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdtBankName = New CustomControls.CustomTextBox()
        Me.cdtRazonSocial = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cdtBranchOffice = New CustomControls.CustomTextBox()
        Me.cdtAccount = New CustomControls.CustomTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cdtCellPhone = New CustomControls.CustomTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cdtExtension = New CustomControls.CustomTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cdtTelephone = New CustomControls.CustomTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cdtJob = New CustomControls.CustomTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cdtContactName = New CustomControls.CustomTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cdtNumberInterior = New CustomControls.CustomTextBox()
        Me.cdtNumberExterior = New CustomControls.CustomTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cdtStreet = New CustomControls.CustomTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cdtPostalCode = New CustomControls.CustomTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cdtCologne = New CustomControls.CustomTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxMunicipality = New System.Windows.Forms.ComboBox()
        Me.cbxState = New System.Windows.Forms.ComboBox()
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModify = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSave = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco"
        '
        'cdtBankName
        '
        Me.cdtBankName.BackColor = System.Drawing.Color.White
        Me.cdtBankName.BorderColor = System.Drawing.Color.Black
        Me.cdtBankName.BorderRadius = 0
        Me.cdtBankName.BorderSize = 2
        Me.cdtBankName.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtBankName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtBankName.ForeColor = System.Drawing.Color.Black
        Me.cdtBankName.Location = New System.Drawing.Point(12, 28)
        Me.cdtBankName.MultiLine = False
        Me.cdtBankName.Name = "cdtBankName"
        Me.cdtBankName.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtBankName.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtBankName.PlaceHolderText = ""
        Me.cdtBankName.ReadOnly = False
        Me.cdtBankName.Size = New System.Drawing.Size(167, 28)
        Me.cdtBankName.TabIndex = 1
        Me.cdtBankName.UnderLinedStyle = True
        Me.cdtBankName.UseSystemPasswordChar = False
        '
        'cdtRazonSocial
        '
        Me.cdtRazonSocial.BackColor = System.Drawing.Color.White
        Me.cdtRazonSocial.BorderColor = System.Drawing.Color.Black
        Me.cdtRazonSocial.BorderRadius = 0
        Me.cdtRazonSocial.BorderSize = 2
        Me.cdtRazonSocial.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtRazonSocial.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtRazonSocial.ForeColor = System.Drawing.Color.Black
        Me.cdtRazonSocial.Location = New System.Drawing.Point(185, 28)
        Me.cdtRazonSocial.MultiLine = False
        Me.cdtRazonSocial.Name = "cdtRazonSocial"
        Me.cdtRazonSocial.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtRazonSocial.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtRazonSocial.PlaceHolderText = ""
        Me.cdtRazonSocial.ReadOnly = False
        Me.cdtRazonSocial.Size = New System.Drawing.Size(339, 28)
        Me.cdtRazonSocial.TabIndex = 2
        Me.cdtRazonSocial.UnderLinedStyle = True
        Me.cdtRazonSocial.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Razon social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sucursal"
        '
        'cdtBranchOffice
        '
        Me.cdtBranchOffice.BackColor = System.Drawing.Color.White
        Me.cdtBranchOffice.BorderColor = System.Drawing.Color.Black
        Me.cdtBranchOffice.BorderRadius = 0
        Me.cdtBranchOffice.BorderSize = 2
        Me.cdtBranchOffice.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtBranchOffice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtBranchOffice.ForeColor = System.Drawing.Color.Black
        Me.cdtBranchOffice.Location = New System.Drawing.Point(12, 87)
        Me.cdtBranchOffice.MultiLine = False
        Me.cdtBranchOffice.Name = "cdtBranchOffice"
        Me.cdtBranchOffice.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtBranchOffice.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtBranchOffice.PlaceHolderText = ""
        Me.cdtBranchOffice.ReadOnly = False
        Me.cdtBranchOffice.Size = New System.Drawing.Size(134, 28)
        Me.cdtBranchOffice.TabIndex = 3
        Me.cdtBranchOffice.UnderLinedStyle = True
        Me.cdtBranchOffice.UseSystemPasswordChar = False
        '
        'cdtAccount
        '
        Me.cdtAccount.BackColor = System.Drawing.Color.White
        Me.cdtAccount.BorderColor = System.Drawing.Color.Black
        Me.cdtAccount.BorderRadius = 0
        Me.cdtAccount.BorderSize = 2
        Me.cdtAccount.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtAccount.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtAccount.ForeColor = System.Drawing.Color.Black
        Me.cdtAccount.Location = New System.Drawing.Point(152, 87)
        Me.cdtAccount.MultiLine = False
        Me.cdtAccount.Name = "cdtAccount"
        Me.cdtAccount.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtAccount.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtAccount.PlaceHolderText = ""
        Me.cdtAccount.ReadOnly = False
        Me.cdtAccount.Size = New System.Drawing.Size(167, 28)
        Me.cdtAccount.TabIndex = 4
        Me.cdtAccount.UnderLinedStyle = True
        Me.cdtAccount.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(149, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cuenta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cdtCellPhone)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cdtExtension)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cdtTelephone)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cdtJob)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cdtContactName)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 132)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Contacto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(233, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Celular"
        '
        'cdtCellPhone
        '
        Me.cdtCellPhone.BackColor = System.Drawing.Color.White
        Me.cdtCellPhone.BorderColor = System.Drawing.Color.Black
        Me.cdtCellPhone.BorderRadius = 0
        Me.cdtCellPhone.BorderSize = 2
        Me.cdtCellPhone.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtCellPhone.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtCellPhone.ForeColor = System.Drawing.Color.Black
        Me.cdtCellPhone.Location = New System.Drawing.Point(236, 94)
        Me.cdtCellPhone.MultiLine = False
        Me.cdtCellPhone.Name = "cdtCellPhone"
        Me.cdtCellPhone.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCellPhone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCellPhone.PlaceHolderText = ""
        Me.cdtCellPhone.ReadOnly = False
        Me.cdtCellPhone.Size = New System.Drawing.Size(135, 28)
        Me.cdtCellPhone.TabIndex = 9
        Me.cdtCellPhone.UnderLinedStyle = True
        Me.cdtCellPhone.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(150, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Extensión"
        '
        'cdtExtension
        '
        Me.cdtExtension.BackColor = System.Drawing.Color.White
        Me.cdtExtension.BorderColor = System.Drawing.Color.Black
        Me.cdtExtension.BorderRadius = 0
        Me.cdtExtension.BorderSize = 2
        Me.cdtExtension.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtExtension.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtExtension.ForeColor = System.Drawing.Color.Black
        Me.cdtExtension.Location = New System.Drawing.Point(150, 94)
        Me.cdtExtension.MultiLine = False
        Me.cdtExtension.Name = "cdtExtension"
        Me.cdtExtension.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtExtension.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtExtension.PlaceHolderText = ""
        Me.cdtExtension.ReadOnly = False
        Me.cdtExtension.Size = New System.Drawing.Size(68, 28)
        Me.cdtExtension.TabIndex = 8
        Me.cdtExtension.UnderLinedStyle = True
        Me.cdtExtension.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Telefono"
        '
        'cdtTelephone
        '
        Me.cdtTelephone.BackColor = System.Drawing.Color.White
        Me.cdtTelephone.BorderColor = System.Drawing.Color.Black
        Me.cdtTelephone.BorderRadius = 0
        Me.cdtTelephone.BorderSize = 2
        Me.cdtTelephone.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtTelephone.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtTelephone.ForeColor = System.Drawing.Color.Black
        Me.cdtTelephone.Location = New System.Drawing.Point(9, 94)
        Me.cdtTelephone.MultiLine = False
        Me.cdtTelephone.Name = "cdtTelephone"
        Me.cdtTelephone.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtTelephone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtTelephone.PlaceHolderText = ""
        Me.cdtTelephone.ReadOnly = False
        Me.cdtTelephone.Size = New System.Drawing.Size(135, 28)
        Me.cdtTelephone.TabIndex = 7
        Me.cdtTelephone.UnderLinedStyle = True
        Me.cdtTelephone.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(322, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Puesto"
        '
        'cdtJob
        '
        Me.cdtJob.BackColor = System.Drawing.Color.White
        Me.cdtJob.BorderColor = System.Drawing.Color.Black
        Me.cdtJob.BorderRadius = 0
        Me.cdtJob.BorderSize = 2
        Me.cdtJob.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtJob.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtJob.ForeColor = System.Drawing.Color.Black
        Me.cdtJob.Location = New System.Drawing.Point(325, 38)
        Me.cdtJob.MultiLine = False
        Me.cdtJob.Name = "cdtJob"
        Me.cdtJob.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtJob.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtJob.PlaceHolderText = ""
        Me.cdtJob.ReadOnly = False
        Me.cdtJob.Size = New System.Drawing.Size(181, 28)
        Me.cdtJob.TabIndex = 6
        Me.cdtJob.UnderLinedStyle = True
        Me.cdtJob.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Contacto"
        '
        'cdtContactName
        '
        Me.cdtContactName.BackColor = System.Drawing.Color.White
        Me.cdtContactName.BorderColor = System.Drawing.Color.Black
        Me.cdtContactName.BorderRadius = 0
        Me.cdtContactName.BorderSize = 2
        Me.cdtContactName.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtContactName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtContactName.ForeColor = System.Drawing.Color.Black
        Me.cdtContactName.Location = New System.Drawing.Point(9, 38)
        Me.cdtContactName.MultiLine = False
        Me.cdtContactName.Name = "cdtContactName"
        Me.cdtContactName.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtContactName.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtContactName.PlaceHolderText = ""
        Me.cdtContactName.ReadOnly = False
        Me.cdtContactName.Size = New System.Drawing.Size(310, 28)
        Me.cdtContactName.TabIndex = 5
        Me.cdtContactName.UnderLinedStyle = True
        Me.cdtContactName.UseSystemPasswordChar = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cdtNumberInterior)
        Me.GroupBox2.Controls.Add(Me.cdtNumberExterior)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cdtStreet)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cdtPostalCode)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cdtCologne)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbxMunicipality)
        Me.GroupBox2.Controls.Add(Me.cbxState)
        Me.GroupBox2.Controls.Add(Me.cbxCountry)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 259)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 194)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domicilio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(416, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "No. interior"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(310, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 16)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "No. Exterior"
        '
        'cdtNumberInterior
        '
        Me.cdtNumberInterior.BackColor = System.Drawing.Color.White
        Me.cdtNumberInterior.BorderColor = System.Drawing.Color.Black
        Me.cdtNumberInterior.BorderRadius = 0
        Me.cdtNumberInterior.BorderSize = 2
        Me.cdtNumberInterior.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtNumberInterior.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtNumberInterior.ForeColor = System.Drawing.Color.Black
        Me.cdtNumberInterior.Location = New System.Drawing.Point(419, 153)
        Me.cdtNumberInterior.MultiLine = False
        Me.cdtNumberInterior.Name = "cdtNumberInterior"
        Me.cdtNumberInterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberInterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberInterior.PlaceHolderText = ""
        Me.cdtNumberInterior.ReadOnly = False
        Me.cdtNumberInterior.Size = New System.Drawing.Size(87, 28)
        Me.cdtNumberInterior.TabIndex = 17
        Me.cdtNumberInterior.UnderLinedStyle = True
        Me.cdtNumberInterior.UseSystemPasswordChar = False
        '
        'cdtNumberExterior
        '
        Me.cdtNumberExterior.BackColor = System.Drawing.Color.White
        Me.cdtNumberExterior.BorderColor = System.Drawing.Color.Black
        Me.cdtNumberExterior.BorderRadius = 0
        Me.cdtNumberExterior.BorderSize = 2
        Me.cdtNumberExterior.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtNumberExterior.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtNumberExterior.ForeColor = System.Drawing.Color.Black
        Me.cdtNumberExterior.Location = New System.Drawing.Point(313, 153)
        Me.cdtNumberExterior.MultiLine = False
        Me.cdtNumberExterior.Name = "cdtNumberExterior"
        Me.cdtNumberExterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberExterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberExterior.PlaceHolderText = ""
        Me.cdtNumberExterior.ReadOnly = False
        Me.cdtNumberExterior.Size = New System.Drawing.Size(87, 28)
        Me.cdtNumberExterior.TabIndex = 16
        Me.cdtNumberExterior.UnderLinedStyle = True
        Me.cdtNumberExterior.UseSystemPasswordChar = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 16)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Calle"
        '
        'cdtStreet
        '
        Me.cdtStreet.BackColor = System.Drawing.Color.White
        Me.cdtStreet.BorderColor = System.Drawing.Color.Black
        Me.cdtStreet.BorderRadius = 0
        Me.cdtStreet.BorderSize = 2
        Me.cdtStreet.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtStreet.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtStreet.ForeColor = System.Drawing.Color.Black
        Me.cdtStreet.Location = New System.Drawing.Point(9, 153)
        Me.cdtStreet.MultiLine = False
        Me.cdtStreet.Name = "cdtStreet"
        Me.cdtStreet.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtStreet.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtStreet.PlaceHolderText = ""
        Me.cdtStreet.ReadOnly = False
        Me.cdtStreet.Size = New System.Drawing.Size(298, 28)
        Me.cdtStreet.TabIndex = 15
        Me.cdtStreet.UnderLinedStyle = True
        Me.cdtStreet.UseSystemPasswordChar = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(193, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Codigo postal"
        '
        'cdtPostalCode
        '
        Me.cdtPostalCode.BackColor = System.Drawing.Color.White
        Me.cdtPostalCode.BorderColor = System.Drawing.Color.Black
        Me.cdtPostalCode.BorderRadius = 0
        Me.cdtPostalCode.BorderSize = 2
        Me.cdtPostalCode.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtPostalCode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtPostalCode.ForeColor = System.Drawing.Color.Black
        Me.cdtPostalCode.Location = New System.Drawing.Point(196, 94)
        Me.cdtPostalCode.MultiLine = False
        Me.cdtPostalCode.Name = "cdtPostalCode"
        Me.cdtPostalCode.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtPostalCode.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtPostalCode.PlaceHolderText = ""
        Me.cdtPostalCode.ReadOnly = False
        Me.cdtPostalCode.Size = New System.Drawing.Size(111, 28)
        Me.cdtPostalCode.TabIndex = 14
        Me.cdtPostalCode.UnderLinedStyle = True
        Me.cdtPostalCode.UseSystemPasswordChar = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Colonia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(342, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Municipio"
        '
        'cdtCologne
        '
        Me.cdtCologne.BackColor = System.Drawing.Color.White
        Me.cdtCologne.BorderColor = System.Drawing.Color.Black
        Me.cdtCologne.BorderRadius = 0
        Me.cdtCologne.BorderSize = 2
        Me.cdtCologne.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtCologne.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtCologne.ForeColor = System.Drawing.Color.Black
        Me.cdtCologne.Location = New System.Drawing.Point(9, 94)
        Me.cdtCologne.MultiLine = False
        Me.cdtCologne.Name = "cdtCologne"
        Me.cdtCologne.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCologne.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCologne.PlaceHolderText = ""
        Me.cdtCologne.ReadOnly = False
        Me.cdtCologne.Size = New System.Drawing.Size(181, 28)
        Me.cdtCologne.TabIndex = 13
        Me.cdtCologne.UnderLinedStyle = True
        Me.cdtCologne.UseSystemPasswordChar = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(175, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Estado"
        '
        'cbxMunicipality
        '
        Me.cbxMunicipality.BackColor = System.Drawing.Color.Azure
        Me.cbxMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMunicipality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMunicipality.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMunicipality.FormattingEnabled = True
        Me.cbxMunicipality.Location = New System.Drawing.Point(345, 38)
        Me.cbxMunicipality.Name = "cbxMunicipality"
        Me.cbxMunicipality.Size = New System.Drawing.Size(161, 24)
        Me.cbxMunicipality.TabIndex = 12
        '
        'cbxState
        '
        Me.cbxState.BackColor = System.Drawing.Color.Azure
        Me.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxState.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(178, 38)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(161, 24)
        Me.cbxState.TabIndex = 11
        '
        'cbxCountry
        '
        Me.cbxCountry.BackColor = System.Drawing.Color.Azure
        Me.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCountry.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(9, 38)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(161, 24)
        Me.cbxCountry.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "País"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnModify)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 479)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(536, 34)
        Me.Panel1.TabIndex = 30
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.Navy
        Me.btnModify.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModify.BorderRadius = 8
        Me.btnModify.BorderSize = 0
        Me.btnModify.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModify.FlatAppearance.BorderSize = 0
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.ForeColor = System.Drawing.Color.White
        Me.btnModify.Location = New System.Drawing.Point(347, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(93, 28)
        Me.btnModify.TabIndex = 18
        Me.btnModify.Text = "Modificar"
        Me.btnModify.UseVisualStyleBackColor = False
        Me.btnModify.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Navy
        Me.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.BorderRadius = 8
        Me.btnSave.BorderSize = 0
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(440, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 28)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'FrmBankReferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(536, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cdtAccount)
        Me.Controls.Add(Me.cdtBranchOffice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cdtRazonSocial)
        Me.Controls.Add(Me.cdtBankName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmBankReferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Referencias bancarias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModify As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnSave As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents cdtBankName As CustomControls.CustomTextBox
    Private WithEvents cdtRazonSocial As CustomControls.CustomTextBox
    Private WithEvents cdtBranchOffice As CustomControls.CustomTextBox
    Private WithEvents cdtAccount As CustomControls.CustomTextBox
    Private WithEvents cdtJob As CustomControls.CustomTextBox
    Private WithEvents cdtContactName As CustomControls.CustomTextBox
    Private WithEvents cdtExtension As CustomControls.CustomTextBox
    Private WithEvents cdtTelephone As CustomControls.CustomTextBox
    Private WithEvents cbxMunicipality As ComboBox
    Private WithEvents cbxState As ComboBox
    Private WithEvents cbxCountry As ComboBox
    Private WithEvents cdtPostalCode As CustomControls.CustomTextBox
    Private WithEvents cdtCologne As CustomControls.CustomTextBox
    Private WithEvents cdtNumberInterior As CustomControls.CustomTextBox
    Private WithEvents cdtNumberExterior As CustomControls.CustomTextBox
    Private WithEvents cdtStreet As CustomControls.CustomTextBox
    Friend WithEvents Label17 As Label
    Private WithEvents cdtCellPhone As CustomControls.CustomTextBox
End Class
