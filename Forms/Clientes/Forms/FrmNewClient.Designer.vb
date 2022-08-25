<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewClient))
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
        Me.btnSave = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.SuspendLayout()
        '
        'CkBxBloqueo
        '
        Me.CkBxBloqueo.AutoSize = True
        Me.CkBxBloqueo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkBxBloqueo.Location = New System.Drawing.Point(535, 44)
        Me.CkBxBloqueo.Name = "CkBxBloqueo"
        Me.CkBxBloqueo.Size = New System.Drawing.Size(86, 20)
        Me.CkBxBloqueo.TabIndex = 4
        Me.CkBxBloqueo.Text = "Bloquear"
        Me.CkBxBloqueo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Pagina web"
        '
        'cdtWeb
        '
        Me.cdtWeb.BackColor = System.Drawing.SystemColors.Window
        Me.cdtWeb.BorderColor = System.Drawing.Color.Black
        Me.cdtWeb.BorderRadius = 0
        Me.cdtWeb.BorderSize = 2
        Me.cdtWeb.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtWeb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtWeb.ForeColor = System.Drawing.Color.Black
        Me.cdtWeb.Location = New System.Drawing.Point(12, 96)
        Me.cdtWeb.MultiLine = False
        Me.cdtWeb.Name = "cdtWeb"
        Me.cdtWeb.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtWeb.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtWeb.PlaceHolderText = ""
        Me.cdtWeb.ReadOnly = False
        Me.cdtWeb.Size = New System.Drawing.Size(630, 28)
        Me.cdtWeb.TabIndex = 5
        Me.cdtWeb.UnderLinedStyle = True
        Me.cdtWeb.UseSystemPasswordChar = False
        '
        'ckBxClientAAA
        '
        Me.ckBxClientAAA.AutoSize = True
        Me.ckBxClientAAA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckBxClientAAA.Location = New System.Drawing.Point(535, 25)
        Me.ckBxClientAAA.Name = "ckBxClientAAA"
        Me.ckBxClientAAA.Size = New System.Drawing.Size(107, 20)
        Me.ckBxClientAAA.TabIndex = 3
        Me.ckBxClientAAA.Text = "Cliente AAA"
        Me.ckBxClientAAA.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(356, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Telefono"
        '
        'cdtTelephone
        '
        Me.cdtTelephone.BackColor = System.Drawing.SystemColors.Window
        Me.cdtTelephone.BorderColor = System.Drawing.Color.Black
        Me.cdtTelephone.BorderRadius = 0
        Me.cdtTelephone.BorderSize = 2
        Me.cdtTelephone.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtTelephone.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtTelephone.ForeColor = System.Drawing.Color.Black
        Me.cdtTelephone.Location = New System.Drawing.Point(359, 38)
        Me.cdtTelephone.MultiLine = False
        Me.cdtTelephone.Name = "cdtTelephone"
        Me.cdtTelephone.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtTelephone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtTelephone.PlaceHolderText = ""
        Me.cdtTelephone.ReadOnly = False
        Me.cdtTelephone.Size = New System.Drawing.Size(167, 28)
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
        Me.cdtPostalCode.Location = New System.Drawing.Point(276, 276)
        Me.cdtPostalCode.MultiLine = False
        Me.cdtPostalCode.Name = "cdtPostalCode"
        Me.cdtPostalCode.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtPostalCode.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtPostalCode.PlaceHolderText = ""
        Me.cdtPostalCode.ReadOnly = False
        Me.cdtPostalCode.Size = New System.Drawing.Size(142, 28)
        Me.cdtPostalCode.TabIndex = 13
        Me.cdtPostalCode.UnderLinedStyle = True
        Me.cdtPostalCode.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(276, 257)
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
        Me.cdtCologne.Location = New System.Drawing.Point(12, 276)
        Me.cdtCologne.MultiLine = False
        Me.cdtCologne.Name = "cdtCologne"
        Me.cdtCologne.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCologne.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCologne.PlaceHolderText = ""
        Me.cdtCologne.ReadOnly = False
        Me.cdtCologne.Size = New System.Drawing.Size(258, 28)
        Me.cdtCologne.TabIndex = 12
        Me.cdtCologne.UnderLinedStyle = True
        Me.cdtCologne.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 257)
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
        Me.cbxMunicipality.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMunicipality.FormattingEnabled = True
        Me.cbxMunicipality.Location = New System.Drawing.Point(403, 218)
        Me.cbxMunicipality.Name = "cbxMunicipality"
        Me.cbxMunicipality.Size = New System.Drawing.Size(191, 25)
        Me.cbxMunicipality.TabIndex = 11
        '
        'cbxState
        '
        Me.cbxState.BackColor = System.Drawing.Color.Azure
        Me.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxState.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(209, 218)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(188, 25)
        Me.cbxState.TabIndex = 10
        '
        'cbxCountry
        '
        Me.cbxCountry.BackColor = System.Drawing.Color.Azure
        Me.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCountry.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(12, 218)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(191, 25)
        Me.cbxCountry.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "País"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(206, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(403, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Municipio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No. Exterior"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(504, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No. Interior"
        '
        'cdtNumberExterior
        '
        Me.cdtNumberExterior.BackColor = System.Drawing.SystemColors.Window
        Me.cdtNumberExterior.BorderColor = System.Drawing.Color.Black
        Me.cdtNumberExterior.BorderRadius = 0
        Me.cdtNumberExterior.BorderSize = 2
        Me.cdtNumberExterior.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtNumberExterior.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtNumberExterior.ForeColor = System.Drawing.Color.Black
        Me.cdtNumberExterior.Location = New System.Drawing.Point(366, 158)
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
        Me.cdtNumberInterior.BackColor = System.Drawing.SystemColors.Window
        Me.cdtNumberInterior.BorderColor = System.Drawing.Color.Black
        Me.cdtNumberInterior.BorderRadius = 0
        Me.cdtNumberInterior.BorderSize = 2
        Me.cdtNumberInterior.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtNumberInterior.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtNumberInterior.ForeColor = System.Drawing.Color.Black
        Me.cdtNumberInterior.Location = New System.Drawing.Point(507, 158)
        Me.cdtNumberInterior.MultiLine = False
        Me.cdtNumberInterior.Name = "cdtNumberInterior"
        Me.cdtNumberInterior.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNumberInterior.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNumberInterior.PlaceHolderText = ""
        Me.cdtNumberInterior.ReadOnly = False
        Me.cdtNumberInterior.Size = New System.Drawing.Size(135, 28)
        Me.cdtNumberInterior.TabIndex = 8
        Me.cdtNumberInterior.UnderLinedStyle = True
        Me.cdtNumberInterior.UseSystemPasswordChar = False
        '
        'cdtStreetClient
        '
        Me.cdtStreetClient.BackColor = System.Drawing.SystemColors.Window
        Me.cdtStreetClient.BorderColor = System.Drawing.Color.Black
        Me.cdtStreetClient.BorderRadius = 0
        Me.cdtStreetClient.BorderSize = 2
        Me.cdtStreetClient.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtStreetClient.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtStreetClient.ForeColor = System.Drawing.Color.Black
        Me.cdtStreetClient.Location = New System.Drawing.Point(12, 158)
        Me.cdtStreetClient.MultiLine = False
        Me.cdtStreetClient.Name = "cdtStreetClient"
        Me.cdtStreetClient.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtStreetClient.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtStreetClient.PlaceHolderText = ""
        Me.cdtStreetClient.ReadOnly = False
        Me.cdtStreetClient.Size = New System.Drawing.Size(348, 28)
        Me.cdtStreetClient.TabIndex = 6
        Me.cdtStreetClient.UnderLinedStyle = True
        Me.cdtStreetClient.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 139)
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
        Me.cdtNameClient.Location = New System.Drawing.Point(12, 38)
        Me.cdtNameClient.MultiLine = False
        Me.cdtNameClient.Name = "cdtNameClient"
        Me.cdtNameClient.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtNameClient.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtNameClient.PlaceHolderText = ""
        Me.cdtNameClient.ReadOnly = False
        Me.cdtNameClient.Size = New System.Drawing.Size(341, 28)
        Me.cdtNameClient.TabIndex = 1
        Me.cdtNameClient.UnderLinedStyle = True
        Me.cdtNameClient.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Navy
        Me.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.BorderRadius = 8
        Me.btnSave.BorderSize = 0
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(535, 308)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 28)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FrmNewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(652, 348)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CkBxBloqueo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cdtWeb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckBxClientAAA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxCountry)
        Me.Controls.Add(Me.cdtTelephone)
        Me.Controls.Add(Me.cbxState)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cdtPostalCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxMunicipality)
        Me.Controls.Add(Me.cdtNumberExterior)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cdtNumberInterior)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cdtStreetClient)
        Me.Controls.Add(Me.cdtCologne)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cdtNameClient)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmNewClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cliente nuevo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents CkBxBloqueo As CheckBox
    Friend WithEvents Label11 As Label
    Private WithEvents cdtWeb As CustomControls.CustomTextBox
    Private WithEvents ckBxClientAAA As CheckBox
    Friend WithEvents Label10 As Label
    Private WithEvents cdtTelephone As CustomControls.CustomTextBox
    Private WithEvents cdtPostalCode As CustomControls.CustomTextBox
    Friend WithEvents Label9 As Label
    Private WithEvents cdtCologne As CustomControls.CustomTextBox
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
    Private WithEvents cdtStreetClient As CustomControls.CustomTextBox
    Friend WithEvents Label2 As Label
    Private WithEvents cdtNameClient As CustomControls.CustomTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As CustomControls.ControlesPersonalizados.CustomButton
End Class
