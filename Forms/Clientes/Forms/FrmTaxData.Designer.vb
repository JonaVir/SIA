<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTaxData
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTaxData))
        Me.cdtStreetClient = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdtRFC = New CustomControls.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdtCURP = New CustomControls.CustomTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cdtNumberExterior = New CustomControls.CustomTextBox()
        Me.cdtNumberInterior = New CustomControls.CustomTextBox()
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxState = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxMunicipality = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cdtPostalCode = New CustomControls.CustomTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cdtCologne = New CustomControls.CustomTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModify = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSave = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.CountriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.CountriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cdtStreetClient.Location = New System.Drawing.Point(12, 296)
        Me.cdtStreetClient.MultiLine = False
        Me.cdtStreetClient.Name = "cdtStreetClient"
        Me.cdtStreetClient.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtStreetClient.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtStreetClient.PlaceHolderText = ""
        Me.cdtStreetClient.ReadOnly = False
        Me.cdtStreetClient.Size = New System.Drawing.Size(224, 28)
        Me.cdtStreetClient.TabIndex = 8
        Me.cdtStreetClient.UnderLinedStyle = True
        Me.cdtStreetClient.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Calle"
        '
        'cdtRFC
        '
        Me.cdtRFC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.cdtRFC.BorderColor = System.Drawing.Color.Black
        Me.cdtRFC.BorderRadius = 0
        Me.cdtRFC.BorderSize = 2
        Me.cdtRFC.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtRFC.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtRFC.ForeColor = System.Drawing.Color.Black
        Me.cdtRFC.Location = New System.Drawing.Point(12, 28)
        Me.cdtRFC.MultiLine = False
        Me.cdtRFC.Name = "cdtRFC"
        Me.cdtRFC.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtRFC.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtRFC.PlaceHolderText = ""
        Me.cdtRFC.ReadOnly = False
        Me.cdtRFC.Size = New System.Drawing.Size(194, 28)
        Me.cdtRFC.TabIndex = 1
        Me.cdtRFC.UnderLinedStyle = True
        Me.cdtRFC.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "RFC"
        '
        'cdtCURP
        '
        Me.cdtCURP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdtCURP.BackColor = System.Drawing.SystemColors.Window
        Me.cdtCURP.BorderColor = System.Drawing.Color.Black
        Me.cdtCURP.BorderRadius = 0
        Me.cdtCURP.BorderSize = 2
        Me.cdtCURP.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtCURP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtCURP.ForeColor = System.Drawing.Color.Black
        Me.cdtCURP.Location = New System.Drawing.Point(213, 28)
        Me.cdtCURP.MultiLine = False
        Me.cdtCURP.Name = "cdtCURP"
        Me.cdtCURP.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCURP.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCURP.PlaceHolderText = ""
        Me.cdtCURP.ReadOnly = False
        Me.cdtCURP.Size = New System.Drawing.Size(194, 28)
        Me.cdtCURP.TabIndex = 2
        Me.cdtCURP.UnderLinedStyle = True
        Me.cdtCURP.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CURP"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(12, 330)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(168, 20)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Usar Domicilio cliente"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "No. Exterior"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(324, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "No. Interior"
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
        Me.cdtNumberExterior.Location = New System.Drawing.Point(242, 296)
        Me.cdtNumberExterior.MultiLine = False
        Me.cdtNumberExterior.Name = "cdtNumberExterior"
        Me.cdtNumberExterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberExterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberExterior.PlaceHolderText = ""
        Me.cdtNumberExterior.ReadOnly = False
        Me.cdtNumberExterior.Size = New System.Drawing.Size(79, 28)
        Me.cdtNumberExterior.TabIndex = 9
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
        Me.cdtNumberInterior.Location = New System.Drawing.Point(327, 296)
        Me.cdtNumberInterior.MultiLine = False
        Me.cdtNumberInterior.Name = "cdtNumberInterior"
        Me.cdtNumberInterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberInterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberInterior.PlaceHolderText = ""
        Me.cdtNumberInterior.ReadOnly = False
        Me.cdtNumberInterior.Size = New System.Drawing.Size(77, 28)
        Me.cdtNumberInterior.TabIndex = 10
        Me.cdtNumberInterior.UnderLinedStyle = True
        Me.cdtNumberInterior.UseSystemPasswordChar = False
        '
        'cbxCountry
        '
        Me.cbxCountry.BackColor = System.Drawing.Color.Azure
        Me.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(12, 86)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(289, 25)
        Me.cbxCountry.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "País"
        '
        'cbxState
        '
        Me.cbxState.BackColor = System.Drawing.Color.Azure
        Me.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(12, 133)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(289, 25)
        Me.cbxState.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Estado"
        '
        'cbxMunicipality
        '
        Me.cbxMunicipality.BackColor = System.Drawing.Color.Azure
        Me.cbxMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMunicipality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMunicipality.FormattingEnabled = True
        Me.cbxMunicipality.Location = New System.Drawing.Point(12, 191)
        Me.cbxMunicipality.Name = "cbxMunicipality"
        Me.cbxMunicipality.Size = New System.Drawing.Size(289, 25)
        Me.cbxMunicipality.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Municipio"
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
        Me.cdtPostalCode.Location = New System.Drawing.Point(307, 238)
        Me.cdtPostalCode.MultiLine = False
        Me.cdtPostalCode.Name = "cdtPostalCode"
        Me.cdtPostalCode.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtPostalCode.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtPostalCode.PlaceHolderText = ""
        Me.cdtPostalCode.ReadOnly = False
        Me.cdtPostalCode.Size = New System.Drawing.Size(100, 28)
        Me.cdtPostalCode.TabIndex = 7
        Me.cdtPostalCode.UnderLinedStyle = True
        Me.cdtPostalCode.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(304, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 25
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
        Me.cdtCologne.Location = New System.Drawing.Point(12, 238)
        Me.cdtCologne.MultiLine = False
        Me.cdtCologne.Name = "cdtCologne"
        Me.cdtCologne.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCologne.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCologne.PlaceHolderText = ""
        Me.cdtCologne.ReadOnly = False
        Me.cdtCologne.Size = New System.Drawing.Size(289, 28)
        Me.cdtCologne.TabIndex = 6
        Me.cdtCologne.UnderLinedStyle = True
        Me.cdtCologne.UseSystemPasswordChar = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Colonia"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnModify)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 381)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(419, 34)
        Me.Panel1.TabIndex = 27
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
        Me.btnModify.Location = New System.Drawing.Point(230, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(93, 28)
        Me.btnModify.TabIndex = 12
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
        Me.btnSave.Location = New System.Drawing.Point(323, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 28)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'CountriesBindingSource
        '
        Me.CountriesBindingSource.DataSource = GetType(LocationsDb.Coutries.Countries)
        '
        'FrmTaxData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(419, 415)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cdtPostalCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cdtCologne)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxMunicipality)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbxState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxCountry)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cdtNumberExterior)
        Me.Controls.Add(Me.cdtNumberInterior)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cdtCURP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cdtRFC)
        Me.Controls.Add(Me.cdtStreetClient)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTaxData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos Fiscales"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CountriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cdtStreetClient As CustomControls.CustomTextBox
    Friend WithEvents Label2 As Label
    Private WithEvents cdtRFC As CustomControls.CustomTextBox
    Friend WithEvents Label1 As Label
    Private WithEvents cdtCURP As CustomControls.CustomTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents cdtNumberExterior As CustomControls.CustomTextBox
    Private WithEvents cdtNumberInterior As CustomControls.CustomTextBox
    Private WithEvents cbxCountry As ComboBox
    Friend WithEvents Label7 As Label
    Private WithEvents cbxState As ComboBox
    Friend WithEvents Label6 As Label
    Private WithEvents cbxMunicipality As ComboBox
    Friend WithEvents Label8 As Label
    Private WithEvents cdtPostalCode As CustomControls.CustomTextBox
    Friend WithEvents Label9 As Label
    Private WithEvents cdtCologne As CustomControls.CustomTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModify As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnSave As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents CountriesBindingSource As BindingSource
End Class
