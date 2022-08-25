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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdtName = New CustomControls.CustomTextBox()
        Me.CdtRuta = New CustomControls.CustomTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExaminar = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.btnExport = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Archivo"
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
        Me.cdtName.Location = New System.Drawing.Point(12, 28)
        Me.cdtName.MultiLine = False
        Me.cdtName.Name = "cdtName"
        Me.cdtName.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtName.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtName.PlaceHolderText = ""
        Me.cdtName.ReadOnly = False
        Me.cdtName.Size = New System.Drawing.Size(324, 28)
        Me.cdtName.TabIndex = 1
        Me.cdtName.UnderLinedStyle = False
        Me.cdtName.UseSystemPasswordChar = False
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
        Me.CdtRuta.Location = New System.Drawing.Point(8, 78)
        Me.CdtRuta.MultiLine = False
        Me.CdtRuta.Name = "CdtRuta"
        Me.CdtRuta.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.CdtRuta.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.CdtRuta.PlaceHolderText = ""
        Me.CdtRuta.ReadOnly = True
        Me.CdtRuta.Size = New System.Drawing.Size(324, 28)
        Me.CdtRuta.TabIndex = 3
        Me.CdtRuta.UnderLinedStyle = False
        Me.CdtRuta.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ruta"
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
        Me.btnExaminar.Location = New System.Drawing.Point(12, 112)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(84, 26)
        Me.btnExaminar.TabIndex = 4
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = False
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
        Me.btnExport.Location = New System.Drawing.Point(252, 112)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(84, 26)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Exportar"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmExportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(348, 145)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.CdtRuta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cdtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmExportData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exportar Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cdtName As CustomControls.CustomTextBox
    Friend WithEvents CdtRuta As CustomControls.CustomTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExaminar As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents btnExport As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
