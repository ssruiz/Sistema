<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendedorBusqueda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvVendedores = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 59)
        Me.Panel1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(247, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 41)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Buscar Vendedor"
        '
        'dgvVendedores
        '
        Me.dgvVendedores.AllowUserToAddRows = False
        Me.dgvVendedores.AllowUserToDeleteRows = False
        Me.dgvVendedores.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVendedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVendedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NombreC, Me.CIC, Me.RUCC})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVendedores.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVendedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVendedores.EnableHeadersVisualStyles = False
        Me.dgvVendedores.Location = New System.Drawing.Point(44, 190)
        Me.dgvVendedores.MultiSelect = False
        Me.dgvVendedores.Name = "dgvVendedores"
        Me.dgvVendedores.RowHeadersVisible = False
        Me.dgvVendedores.RowTemplate.Height = 24
        Me.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVendedores.Size = New System.Drawing.Size(684, 295)
        Me.dgvVendedores.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'NombreC
        '
        Me.NombreC.DataPropertyName = "Nombre"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.NombreC.DefaultCellStyle = DataGridViewCellStyle4
        Me.NombreC.HeaderText = "Nombre"
        Me.NombreC.Name = "NombreC"
        '
        'CIC
        '
        Me.CIC.DataPropertyName = "Celular"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.CIC.DefaultCellStyle = DataGridViewCellStyle5
        Me.CIC.HeaderText = "Celular"
        Me.CIC.Name = "CIC"
        '
        'RUCC
        '
        Me.RUCC.DataPropertyName = "Porcentaje"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.RUCC.DefaultCellStyle = DataGridViewCellStyle6
        Me.RUCC.HeaderText = "Porcentaje"
        Me.RUCC.Name = "RUCC"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(240, 99)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(271, 25)
        Me.txtFiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(185, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Filtro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(149, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Seleccione un vendedor y presione enter para confirmar"
        '
        'VendedorBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvVendedores)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "VendedorBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedor Busqueda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvVendedores As DataGridView
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NombreC As DataGridViewTextBoxColumn
    Friend WithEvents CIC As DataGridViewTextBoxColumn
    Friend WithEvents RUCC As DataGridViewTextBoxColumn
End Class
