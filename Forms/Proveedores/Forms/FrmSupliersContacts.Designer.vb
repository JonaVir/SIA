<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupliersContacts
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModify = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnSave = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.cdtName = New CustomControls.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdtTelephone = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdtExtension = New CustomControls.CustomTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cdtCellphone = New CustomControls.CustomTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cdtEmail = New CustomControls.CustomTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cdtJobPosition = New CustomControls.CustomTextBox()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(432, 30)
        Me.Panel1.TabIndex = 29
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
        Me.btnModify.Location = New System.Drawing.Point(243, 3)
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
        Me.btnSave.Location = New System.Drawing.Point(336, 3)
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
        Me.cdtName.Size = New System.Drawing.Size(408, 28)
        Me.cdtName.TabIndex = 30
        Me.cdtName.UnderLinedStyle = True
        Me.cdtName.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nombre"
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
        Me.cdtTelephone.Location = New System.Drawing.Point(12, 88)
        Me.cdtTelephone.MultiLine = False
        Me.cdtTelephone.Name = "cdtTelephone"
        Me.cdtTelephone.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtTelephone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtTelephone.PlaceHolderText = ""
        Me.cdtTelephone.ReadOnly = False
        Me.cdtTelephone.Size = New System.Drawing.Size(140, 28)
        Me.cdtTelephone.TabIndex = 32
        Me.cdtTelephone.UnderLinedStyle = True
        Me.cdtTelephone.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 33
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
        Me.cdtExtension.Location = New System.Drawing.Point(158, 88)
        Me.cdtExtension.MultiLine = False
        Me.cdtExtension.Name = "cdtExtension"
        Me.cdtExtension.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtExtension.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtExtension.PlaceHolderText = ""
        Me.cdtExtension.ReadOnly = False
        Me.cdtExtension.Size = New System.Drawing.Size(78, 28)
        Me.cdtExtension.TabIndex = 34
        Me.cdtExtension.UnderLinedStyle = True
        Me.cdtExtension.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Extensión"
        '
        'cdtCellphone
        '
        Me.cdtCellphone.BackColor = System.Drawing.Color.White
        Me.cdtCellphone.BorderColor = System.Drawing.Color.Black
        Me.cdtCellphone.BorderRadius = 0
        Me.cdtCellphone.BorderSize = 2
        Me.cdtCellphone.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtCellphone.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtCellphone.ForeColor = System.Drawing.Color.Black
        Me.cdtCellphone.Location = New System.Drawing.Point(280, 88)
        Me.cdtCellphone.MultiLine = False
        Me.cdtCellphone.Name = "cdtCellphone"
        Me.cdtCellphone.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtCellphone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtCellphone.PlaceHolderText = ""
        Me.cdtCellphone.ReadOnly = False
        Me.cdtCellphone.Size = New System.Drawing.Size(140, 28)
        Me.cdtCellphone.TabIndex = 36
        Me.cdtCellphone.UnderLinedStyle = True
        Me.cdtCellphone.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 37
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
        Me.cdtEmail.Location = New System.Drawing.Point(12, 149)
        Me.cdtEmail.MultiLine = False
        Me.cdtEmail.Name = "cdtEmail"
        Me.cdtEmail.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtEmail.PlaceHolderText = ""
        Me.cdtEmail.ReadOnly = False
        Me.cdtEmail.Size = New System.Drawing.Size(408, 28)
        Me.cdtEmail.TabIndex = 38
        Me.cdtEmail.UnderLinedStyle = True
        Me.cdtEmail.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Correo"
        '
        'cdtJobPosition
        '
        Me.cdtJobPosition.BackColor = System.Drawing.Color.White
        Me.cdtJobPosition.BorderColor = System.Drawing.Color.Black
        Me.cdtJobPosition.BorderRadius = 0
        Me.cdtJobPosition.BorderSize = 2
        Me.cdtJobPosition.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtJobPosition.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtJobPosition.ForeColor = System.Drawing.Color.Black
        Me.cdtJobPosition.Location = New System.Drawing.Point(12, 209)
        Me.cdtJobPosition.MultiLine = False
        Me.cdtJobPosition.Name = "cdtJobPosition"
        Me.cdtJobPosition.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtJobPosition.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtJobPosition.PlaceHolderText = ""
        Me.cdtJobPosition.ReadOnly = False
        Me.cdtJobPosition.Size = New System.Drawing.Size(140, 28)
        Me.cdtJobPosition.TabIndex = 40
        Me.cdtJobPosition.UnderLinedStyle = True
        Me.cdtJobPosition.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Puesto"
        '
        'FrmSupliersContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 278)
        Me.Controls.Add(Me.cdtJobPosition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cdtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cdtCellphone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cdtExtension)
        Me.Controls.Add(Me.cdtTelephone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cdtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmSupliersContacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agenda Contactos"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModify As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnSave As CustomControls.ControlesPersonalizados.CustomButton
    Private WithEvents cdtName As CustomControls.CustomTextBox
    Friend WithEvents Label1 As Label
    Private WithEvents cdtTelephone As CustomControls.CustomTextBox
    Friend WithEvents Label2 As Label
    Private WithEvents cdtExtension As CustomControls.CustomTextBox
    Friend WithEvents Label3 As Label
    Private WithEvents cdtCellphone As CustomControls.CustomTextBox
    Friend WithEvents Label4 As Label
    Private WithEvents cdtEmail As CustomControls.CustomTextBox
    Friend WithEvents Label5 As Label
    Private WithEvents cdtJobPosition As CustomControls.CustomTextBox
    Friend WithEvents Label6 As Label
End Class
