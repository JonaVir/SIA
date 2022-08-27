<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSuppliersBankDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSuppliersBankDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModify = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSave = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.cdtName = New CustomControls.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdtClabe = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdtAccount = New CustomControls.CustomTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cdtBranchOffice = New CustomControls.CustomTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CdtTitular = New CustomControls.CustomTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbxDefault = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnModify)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 281)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(424, 30)
        Me.Panel1.TabIndex = 30
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.Navy
        Me.btnModify.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModify.BorderRadius = 5
        Me.btnModify.BorderSize = 0
        Me.btnModify.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnModify.FlatAppearance.BorderSize = 0
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.ForeColor = System.Drawing.Color.White
        Me.btnModify.Location = New System.Drawing.Point(235, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(93, 24)
        Me.btnModify.TabIndex = 7
        Me.btnModify.Text = "Modificar"
        Me.btnModify.UseVisualStyleBackColor = False
        Me.btnModify.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Navy
        Me.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.BorderRadius = 5
        Me.btnSave.BorderSize = 0
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(328, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 24)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'cdtName
        '
        Me.cdtName.BackColor = System.Drawing.Color.White
        Me.cdtName.BorderColor = System.Drawing.Color.Black
        Me.cdtName.BorderRadius = 0
        Me.cdtName.BorderSize = 2
        Me.cdtName.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtName.ForeColor = System.Drawing.Color.Black
        Me.cdtName.Location = New System.Drawing.Point(12, 28)
        Me.cdtName.MultiLine = False
        Me.cdtName.Name = "cdtName"
        Me.cdtName.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtName.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtName.PlaceHolderText = ""
        Me.cdtName.ReadOnly = False
        Me.cdtName.Size = New System.Drawing.Size(400, 28)
        Me.cdtName.TabIndex = 32
        Me.cdtName.UnderLinedStyle = True
        Me.cdtName.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Banco"
        '
        'cdtClabe
        '
        Me.cdtClabe.BackColor = System.Drawing.Color.White
        Me.cdtClabe.BorderColor = System.Drawing.Color.Black
        Me.cdtClabe.BorderRadius = 0
        Me.cdtClabe.BorderSize = 2
        Me.cdtClabe.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtClabe.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtClabe.ForeColor = System.Drawing.Color.Black
        Me.cdtClabe.Location = New System.Drawing.Point(12, 91)
        Me.cdtClabe.MultiLine = False
        Me.cdtClabe.Name = "cdtClabe"
        Me.cdtClabe.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtClabe.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtClabe.PlaceHolderText = ""
        Me.cdtClabe.ReadOnly = False
        Me.cdtClabe.Size = New System.Drawing.Size(184, 28)
        Me.cdtClabe.TabIndex = 34
        Me.cdtClabe.UnderLinedStyle = True
        Me.cdtClabe.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Clabe"
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
        Me.cdtAccount.Location = New System.Drawing.Point(12, 150)
        Me.cdtAccount.MultiLine = False
        Me.cdtAccount.Name = "cdtAccount"
        Me.cdtAccount.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtAccount.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtAccount.PlaceHolderText = ""
        Me.cdtAccount.ReadOnly = False
        Me.cdtAccount.Size = New System.Drawing.Size(207, 28)
        Me.cdtAccount.TabIndex = 36
        Me.cdtAccount.UnderLinedStyle = True
        Me.cdtAccount.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Cuenta"
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
        Me.cdtBranchOffice.Location = New System.Drawing.Point(225, 150)
        Me.cdtBranchOffice.MultiLine = False
        Me.cdtBranchOffice.Name = "cdtBranchOffice"
        Me.cdtBranchOffice.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtBranchOffice.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtBranchOffice.PlaceHolderText = ""
        Me.cdtBranchOffice.ReadOnly = False
        Me.cdtBranchOffice.Size = New System.Drawing.Size(187, 28)
        Me.cdtBranchOffice.TabIndex = 38
        Me.cdtBranchOffice.UnderLinedStyle = True
        Me.cdtBranchOffice.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(225, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Sucursal"
        '
        'CdtTitular
        '
        Me.CdtTitular.BackColor = System.Drawing.Color.White
        Me.CdtTitular.BorderColor = System.Drawing.Color.Black
        Me.CdtTitular.BorderRadius = 0
        Me.CdtTitular.BorderSize = 2
        Me.CdtTitular.FocusColor = System.Drawing.Color.SteelBlue
        Me.CdtTitular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdtTitular.ForeColor = System.Drawing.Color.Black
        Me.CdtTitular.Location = New System.Drawing.Point(12, 211)
        Me.CdtTitular.MultiLine = False
        Me.CdtTitular.Name = "CdtTitular"
        Me.CdtTitular.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.CdtTitular.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.CdtTitular.PlaceHolderText = ""
        Me.CdtTitular.ReadOnly = False
        Me.CdtTitular.Size = New System.Drawing.Size(400, 28)
        Me.CdtTitular.TabIndex = 40
        Me.CdtTitular.UnderLinedStyle = True
        Me.CdtTitular.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Nombre titular"
        '
        'chbxDefault
        '
        Me.chbxDefault.AutoSize = True
        Me.chbxDefault.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxDefault.Location = New System.Drawing.Point(12, 254)
        Me.chbxDefault.Name = "chbxDefault"
        Me.chbxDefault.Size = New System.Drawing.Size(73, 20)
        Me.chbxDefault.TabIndex = 42
        Me.chbxDefault.Text = "Default"
        Me.chbxDefault.UseVisualStyleBackColor = True
        '
        'FrmSuppliersBankDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(424, 311)
        Me.Controls.Add(Me.chbxDefault)
        Me.Controls.Add(Me.CdtTitular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cdtBranchOffice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cdtAccount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cdtClabe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cdtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSuppliersBankDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos bancarios"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModify As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnSave As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents cdtName As CustomControls.CustomTextBox
    Friend WithEvents Label1 As Label
    Private WithEvents cdtClabe As CustomControls.CustomTextBox
    Friend WithEvents Label2 As Label
    Private WithEvents cdtAccount As CustomControls.CustomTextBox
    Friend WithEvents Label3 As Label
    Private WithEvents cdtBranchOffice As CustomControls.CustomTextBox
    Friend WithEvents Label4 As Label
    Private WithEvents CdtTitular As CustomControls.CustomTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chbxDefault As CheckBox
End Class
