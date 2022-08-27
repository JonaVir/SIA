<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExportData))
        Me.btnExport = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnExaminar = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.CdtRuta = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdtName = New CustomControls.CustomTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Navy
        Me.btnExport.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnExport.BorderRadius = 5
        Me.btnExport.BorderSize = 0
        Me.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(343, 139)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(91, 25)
        Me.btnExport.TabIndex = 11
        Me.btnExport.Text = "Exportar"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.Color.Navy
        Me.btnExaminar.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnExaminar.BorderRadius = 5
        Me.btnExaminar.BorderSize = 0
        Me.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnExaminar.FlatAppearance.BorderSize = 0
        Me.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExaminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ForeColor = System.Drawing.Color.White
        Me.btnExaminar.Location = New System.Drawing.Point(13, 139)
        Me.btnExaminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(91, 25)
        Me.btnExaminar.TabIndex = 10
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'CdtRuta
        '
        Me.CdtRuta.BackColor = System.Drawing.Color.White
        Me.CdtRuta.BorderColor = System.Drawing.Color.Black
        Me.CdtRuta.BorderRadius = 5
        Me.CdtRuta.BorderSize = 1
        Me.CdtRuta.FocusColor = System.Drawing.Color.SteelBlue
        Me.CdtRuta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdtRuta.ForeColor = System.Drawing.Color.Black
        Me.CdtRuta.Location = New System.Drawing.Point(13, 99)
        Me.CdtRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.CdtRuta.MultiLine = False
        Me.CdtRuta.Name = "CdtRuta"
        Me.CdtRuta.Padding = New System.Windows.Forms.Padding(13, 7, 13, 7)
        Me.CdtRuta.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.CdtRuta.PlaceHolderText = ""
        Me.CdtRuta.ReadOnly = True
        Me.CdtRuta.Size = New System.Drawing.Size(421, 32)
        Me.CdtRuta.TabIndex = 9
        Me.CdtRuta.UnderLinedStyle = False
        Me.CdtRuta.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ruta"
        '
        'cdtName
        '
        Me.cdtName.BackColor = System.Drawing.Color.White
        Me.cdtName.BorderColor = System.Drawing.Color.Black
        Me.cdtName.BorderRadius = 5
        Me.cdtName.BorderSize = 1
        Me.cdtName.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtName.ForeColor = System.Drawing.Color.Black
        Me.cdtName.Location = New System.Drawing.Point(13, 29)
        Me.cdtName.Margin = New System.Windows.Forms.Padding(4)
        Me.cdtName.MultiLine = False
        Me.cdtName.Name = "cdtName"
        Me.cdtName.Padding = New System.Windows.Forms.Padding(13, 7, 13, 7)
        Me.cdtName.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtName.PlaceHolderText = ""
        Me.cdtName.ReadOnly = False
        Me.cdtName.Size = New System.Drawing.Size(421, 32)
        Me.cdtName.TabIndex = 7
        Me.cdtName.UnderLinedStyle = False
        Me.cdtName.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre Archivo"
        '
        'FrmExportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(447, 169)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.CdtRuta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cdtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmExportData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exportar Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExport As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnExaminar As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents CdtRuta As CustomControls.CustomTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cdtName As CustomControls.CustomTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
