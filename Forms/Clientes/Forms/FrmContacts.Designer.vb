<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContacts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContacts))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModify = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSave = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdtName = New CustomControls.CustomTextBox()
        Me.cdtTelephone = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdtExtension = New CustomControls.CustomTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cdtCellPhone = New CustomControls.CustomTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cdtEmail = New CustomControls.CustomTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cdtJob = New CustomControls.CustomTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnModify)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(437, 34)
        Me.Panel1.TabIndex = 28
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
        Me.btnModify.Location = New System.Drawing.Point(248, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(93, 28)
        Me.btnModify.TabIndex = 7
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
        Me.btnSave.Location = New System.Drawing.Point(341, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 28)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nombre"
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
        Me.cdtName.Size = New System.Drawing.Size(413, 28)
        Me.cdtName.TabIndex = 1
        Me.cdtName.UnderLinedStyle = True
        Me.cdtName.UseSystemPasswordChar = False
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
        Me.cdtTelephone.Location = New System.Drawing.Point(12, 85)
        Me.cdtTelephone.MultiLine = False
        Me.cdtTelephone.Name = "cdtTelephone"
        Me.cdtTelephone.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtTelephone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtTelephone.PlaceHolderText = ""
        Me.cdtTelephone.ReadOnly = False
        Me.cdtTelephone.Size = New System.Drawing.Size(147, 28)
        Me.cdtTelephone.TabIndex = 2
        Me.cdtTelephone.UnderLinedStyle = True
        Me.cdtTelephone.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Telefono"
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
        Me.cdtExtension.Location = New System.Drawing.Point(165, 85)
        Me.cdtExtension.MultiLine = False
        Me.cdtExtension.Name = "cdtExtension"
        Me.cdtExtension.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtExtension.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtExtension.PlaceHolderText = ""
        Me.cdtExtension.ReadOnly = False
        Me.cdtExtension.Size = New System.Drawing.Size(79, 28)
        Me.cdtExtension.TabIndex = 3
        Me.cdtExtension.UnderLinedStyle = True
        Me.cdtExtension.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Extensión"
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
        Me.cdtCellPhone.Location = New System.Drawing.Point(278, 85)
        Me.cdtCellPhone.MultiLine = False
        Me.cdtCellPhone.Name = "cdtCellPhone"
        Me.cdtCellPhone.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCellPhone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCellPhone.PlaceHolderText = ""
        Me.cdtCellPhone.ReadOnly = False
        Me.cdtCellPhone.Size = New System.Drawing.Size(147, 28)
        Me.cdtCellPhone.TabIndex = 4
        Me.cdtCellPhone.UnderLinedStyle = True
        Me.cdtCellPhone.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(279, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Celular"
        '
        'cdtEmail
        '
        Me.cdtEmail.BackColor = System.Drawing.Color.White
        Me.cdtEmail.BorderColor = System.Drawing.Color.Black
        Me.cdtEmail.BorderRadius = 0
        Me.cdtEmail.BorderSize = 2
        Me.cdtEmail.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtEmail.ForeColor = System.Drawing.Color.Black
        Me.cdtEmail.Location = New System.Drawing.Point(12, 143)
        Me.cdtEmail.MultiLine = False
        Me.cdtEmail.Name = "cdtEmail"
        Me.cdtEmail.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtEmail.PlaceHolderText = ""
        Me.cdtEmail.ReadOnly = False
        Me.cdtEmail.Size = New System.Drawing.Size(413, 28)
        Me.cdtEmail.TabIndex = 5
        Me.cdtEmail.UnderLinedStyle = True
        Me.cdtEmail.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Correo Electronico"
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
        Me.cdtJob.Location = New System.Drawing.Point(12, 200)
        Me.cdtJob.MultiLine = False
        Me.cdtJob.Name = "cdtJob"
        Me.cdtJob.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtJob.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtJob.PlaceHolderText = ""
        Me.cdtJob.ReadOnly = False
        Me.cdtJob.Size = New System.Drawing.Size(147, 28)
        Me.cdtJob.TabIndex = 6
        Me.cdtJob.UnderLinedStyle = True
        Me.cdtJob.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Puesto"
        '
        'FrmContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(437, 266)
        Me.Controls.Add(Me.cdtJob)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cdtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cdtCellPhone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cdtExtension)
        Me.Controls.Add(Me.cdtTelephone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cdtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmContacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Contactos"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModify As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnSave As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents cdtName As CustomControls.CustomTextBox
    Private WithEvents cdtTelephone As CustomControls.CustomTextBox
    Private WithEvents cdtExtension As CustomControls.CustomTextBox
    Private WithEvents cdtCellPhone As CustomControls.CustomTextBox
    Private WithEvents cdtEmail As CustomControls.CustomTextBox
    Private WithEvents cdtJob As CustomControls.CustomTextBox
End Class
