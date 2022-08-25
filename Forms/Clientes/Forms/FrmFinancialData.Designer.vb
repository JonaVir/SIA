<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinancialData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFinancialData))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdtCreditLimit = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxCurrency = New System.Windows.Forms.ComboBox()
        Me.ckbxLocked = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModify = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSave = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Limite Credito"
        '
        'cdtCreditLimit
        '
        Me.cdtCreditLimit.BackColor = System.Drawing.Color.White
        Me.cdtCreditLimit.BorderColor = System.Drawing.Color.Black
        Me.cdtCreditLimit.BorderRadius = 0
        Me.cdtCreditLimit.BorderSize = 2
        Me.cdtCreditLimit.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtCreditLimit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtCreditLimit.ForeColor = System.Drawing.Color.Black
        Me.cdtCreditLimit.Location = New System.Drawing.Point(12, 30)
        Me.cdtCreditLimit.MultiLine = False
        Me.cdtCreditLimit.Name = "cdtCreditLimit"
        Me.cdtCreditLimit.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCreditLimit.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCreditLimit.PlaceHolderText = ""
        Me.cdtCreditLimit.ReadOnly = False
        Me.cdtCreditLimit.Size = New System.Drawing.Size(144, 28)
        Me.cdtCreditLimit.TabIndex = 1
        Me.cdtCreditLimit.UnderLinedStyle = True
        Me.cdtCreditLimit.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Moneda"
        '
        'cbxCurrency
        '
        Me.cbxCurrency.BackColor = System.Drawing.Color.Azure
        Me.cbxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCurrency.FormattingEnabled = True
        Me.cbxCurrency.Items.AddRange(New Object() {"MXN", "USD", "EUR", "GBP"})
        Me.cbxCurrency.Location = New System.Drawing.Point(162, 33)
        Me.cbxCurrency.Name = "cbxCurrency"
        Me.cbxCurrency.Size = New System.Drawing.Size(89, 25)
        Me.cbxCurrency.TabIndex = 2
        '
        'ckbxLocked
        '
        Me.ckbxLocked.AutoSize = True
        Me.ckbxLocked.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbxLocked.Location = New System.Drawing.Point(12, 64)
        Me.ckbxLocked.Name = "ckbxLocked"
        Me.ckbxLocked.Size = New System.Drawing.Size(169, 20)
        Me.ckbxLocked.TabIndex = 3
        Me.ckbxLocked.Text = "Bloqueo contabilidad"
        Me.ckbxLocked.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnModify)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(263, 34)
        Me.Panel1.TabIndex = 29
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
        Me.btnModify.Location = New System.Drawing.Point(74, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(93, 28)
        Me.btnModify.TabIndex = 4
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
        Me.btnSave.Location = New System.Drawing.Point(167, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'FrmFinancialData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(263, 138)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ckbxLocked)
        Me.Controls.Add(Me.cbxCurrency)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cdtCreditLimit)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmFinancialData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos Financieros"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModify As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnSave As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents cdtCreditLimit As CustomControls.CustomTextBox
    Private WithEvents cbxCurrency As ComboBox
    Private WithEvents ckbxLocked As CheckBox
End Class
