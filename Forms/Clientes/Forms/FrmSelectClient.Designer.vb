<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSelectClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectClient))
        Me.CustomPanel1 = New CustomControls.ControlesPersonalizados.CustomPanel()
        Me.btnAddClient = New CustomControls.ControlesPersonalizados.CustomButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cdtFilter = New CustomControls.CustomTextBox()
        Me.cbxFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvClients = New System.Windows.Forms.DataGridView()
        Me.CustomPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CustomPanel1.Controls.Add(Me.btnAddClient)
        Me.CustomPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel1.GradientAngle = 50.0!
        Me.CustomPanel1.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomPanel1.MinimumSize = New System.Drawing.Size(27, 26)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.CustomPanel1.Size = New System.Drawing.Size(684, 40)
        Me.CustomPanel1.TabIndex = 2
        '
        'btnAddClient
        '
        Me.btnAddClient.BackColor = System.Drawing.Color.Transparent
        Me.btnAddClient.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddClient.BorderRadius = 5
        Me.btnAddClient.BorderSize = 0
        Me.btnAddClient.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddClient.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddClient.FlatAppearance.BorderSize = 0
        Me.btnAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddClient.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClient.ForeColor = System.Drawing.Color.Black
        Me.btnAddClient.Image = Global.CustomerCatalog.My.Resources.Resources.Seleccionar
        Me.btnAddClient.Location = New System.Drawing.Point(5, 5)
        Me.btnAddClient.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(110, 30)
        Me.btnAddClient.TabIndex = 0
        Me.btnAddClient.Text = "Seleccionar"
        Me.btnAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddClient.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cdtFilter)
        Me.Panel1.Controls.Add(Me.cbxFilter)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 67)
        Me.Panel1.TabIndex = 3
        '
        'cdtFilter
        '
        Me.cdtFilter.BackColor = System.Drawing.SystemColors.Window
        Me.cdtFilter.BorderColor = System.Drawing.Color.Black
        Me.cdtFilter.BorderRadius = 0
        Me.cdtFilter.BorderSize = 2
        Me.cdtFilter.FocusColor = System.Drawing.Color.SteelBlue
        Me.cdtFilter.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdtFilter.ForeColor = System.Drawing.Color.Black
        Me.cdtFilter.Location = New System.Drawing.Point(208, 32)
        Me.cdtFilter.MultiLine = False
        Me.cdtFilter.Name = "cdtFilter"
        Me.cdtFilter.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cdtFilter.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.cdtFilter.PlaceHolderText = "Palabra Clave"
        Me.cdtFilter.ReadOnly = False
        Me.cdtFilter.Size = New System.Drawing.Size(197, 28)
        Me.cdtFilter.TabIndex = 2
        Me.cdtFilter.UnderLinedStyle = True
        Me.cdtFilter.UseSystemPasswordChar = False
        '
        'cbxFilter
        '
        Me.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxFilter.FormattingEnabled = True
        Me.cbxFilter.Location = New System.Drawing.Point(12, 35)
        Me.cbxFilter.Name = "cbxFilter"
        Me.cbxFilter.Size = New System.Drawing.Size(190, 25)
        Me.cbxFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtrar..."
        '
        'dgvClients
        '
        Me.dgvClients.AllowUserToAddRows = False
        Me.dgvClients.AllowUserToDeleteRows = False
        Me.dgvClients.AllowUserToResizeColumns = False
        Me.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvClients.BackgroundColor = System.Drawing.Color.White
        Me.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClients.EnableHeadersVisualStyles = False
        Me.dgvClients.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvClients.Location = New System.Drawing.Point(0, 107)
        Me.dgvClients.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvClients.MultiSelect = False
        Me.dgvClients.Name = "dgvClients"
        Me.dgvClients.ReadOnly = True
        Me.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClients.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClients.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClients.Size = New System.Drawing.Size(684, 443)
        Me.dgvClients.TabIndex = 11
        '
        'FrmSelectClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 550)
        Me.Controls.Add(Me.dgvClients)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CustomPanel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmSelectClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar cliente"
        Me.CustomPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomPanel1 As CustomControls.ControlesPersonalizados.CustomPanel
    Friend WithEvents btnAddClient As CustomControls.ControlesPersonalizados.CustomButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvClients As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxFilter As ComboBox
    Friend WithEvents cdtFilter As CustomControls.CustomTextBox
End Class
