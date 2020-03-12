<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaldoPorClienteProduccionForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.cbTipoCliente = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvOTS = New System.Windows.Forms.DataGridView()
        Me.FacturaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalFactCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpedidasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaltantesCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReporteGral = New System.Windows.Forms.Button()
        Me.btnReporteIndividual = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvOTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 53)
        Me.Panel1.TabIndex = 5
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(419, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(449, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "SALDO PRODUCCION CLIENTE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOT)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.cbTipoCliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1371, 167)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtOT
        '
        Me.txtOT.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOT.Location = New System.Drawing.Point(1136, 33)
        Me.txtOT.Margin = New System.Windows.Forms.Padding(0)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(188, 25)
        Me.txtOT.TabIndex = 9
        Me.txtOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(749, 33)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(232, 25)
        Me.txtCliente.TabIndex = 9
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbTipoCliente
        '
        Me.cbTipoCliente.FormattingEnabled = True
        Me.cbTipoCliente.Items.AddRange(New Object() {"Interno", "Normal", "Todos"})
        Me.cbTipoCliente.Location = New System.Drawing.Point(158, 36)
        Me.cbTipoCliente.Name = "cbTipoCliente"
        Me.cbTipoCliente.Size = New System.Drawing.Size(199, 25)
        Me.cbTipoCliente.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Location = New System.Drawing.Point(378, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(140, 42)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1003, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buscar por OT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(557, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CLIENTE ESPECíFICO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIPO CLIENTE"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dgvOTS)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(27, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(9, 11, 9, 11)
        Me.GroupBox2.Size = New System.Drawing.Size(1312, 393)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OTS"
        '
        'dgvOTS
        '
        Me.dgvOTS.AllowUserToAddRows = False
        Me.dgvOTS.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvOTS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvOTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvOTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOTS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaCol, Me.ClienteCol, Me.OTCol, Me.TotalFactCol, Me.TotalPagCol, Me.SaldoCol, Me.TotalPCol, Me.ExpedidasCol, Me.FaltantesCol})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOTS.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvOTS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOTS.EnableHeadersVisualStyles = False
        Me.dgvOTS.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvOTS.Location = New System.Drawing.Point(9, 31)
        Me.dgvOTS.Name = "dgvOTS"
        Me.dgvOTS.ReadOnly = True
        Me.dgvOTS.RowHeadersVisible = False
        Me.dgvOTS.RowTemplate.Height = 24
        Me.dgvOTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOTS.Size = New System.Drawing.Size(1294, 351)
        Me.dgvOTS.TabIndex = 1
        '
        'FacturaCol
        '
        Me.FacturaCol.DataPropertyName = "Factura"
        Me.FacturaCol.HeaderText = "Factura"
        Me.FacturaCol.Name = "FacturaCol"
        Me.FacturaCol.ReadOnly = True
        '
        'ClienteCol
        '
        Me.ClienteCol.DataPropertyName = "Cliente"
        Me.ClienteCol.HeaderText = "Cliente"
        Me.ClienteCol.Name = "ClienteCol"
        Me.ClienteCol.ReadOnly = True
        '
        'OTCol
        '
        Me.OTCol.DataPropertyName = "OT"
        Me.OTCol.HeaderText = "OT"
        Me.OTCol.Name = "OTCol"
        Me.OTCol.ReadOnly = True
        '
        'TotalFactCol
        '
        Me.TotalFactCol.DataPropertyName = "TotalFactura"
        Me.TotalFactCol.HeaderText = "Total Factura"
        Me.TotalFactCol.Name = "TotalFactCol"
        Me.TotalFactCol.ReadOnly = True
        '
        'TotalPagCol
        '
        Me.TotalPagCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TotalPagCol.DataPropertyName = "TotalPagado"
        Me.TotalPagCol.HeaderText = "Pagado"
        Me.TotalPagCol.Name = "TotalPagCol"
        Me.TotalPagCol.ReadOnly = True
        Me.TotalPagCol.Width = 89
        '
        'SaldoCol
        '
        Me.SaldoCol.DataPropertyName = "Saldo"
        Me.SaldoCol.HeaderText = "Saldo"
        Me.SaldoCol.Name = "SaldoCol"
        Me.SaldoCol.ReadOnly = True
        '
        'TotalPCol
        '
        Me.TotalPCol.DataPropertyName = "TotalPiezas"
        Me.TotalPCol.HeaderText = "Total Piezas"
        Me.TotalPCol.Name = "TotalPCol"
        Me.TotalPCol.ReadOnly = True
        '
        'ExpedidasCol
        '
        Me.ExpedidasCol.DataPropertyName = "PiezasExpedidas"
        Me.ExpedidasCol.HeaderText = "Expedidas"
        Me.ExpedidasCol.Name = "ExpedidasCol"
        Me.ExpedidasCol.ReadOnly = True
        '
        'FaltantesCol
        '
        Me.FaltantesCol.DataPropertyName = "PiezasRestantes"
        Me.FaltantesCol.HeaderText = "Faltantes"
        Me.FaltantesCol.Name = "FaltantesCol"
        Me.FaltantesCol.ReadOnly = True
        '
        'btnReporteGral
        '
        Me.btnReporteGral.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnReporteGral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteGral.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteGral.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReporteGral.Location = New System.Drawing.Point(36, 237)
        Me.btnReporteGral.Name = "btnReporteGral"
        Me.btnReporteGral.Size = New System.Drawing.Size(236, 42)
        Me.btnReporteGral.TabIndex = 4
        Me.btnReporteGral.Text = "Generar Reporte"
        Me.btnReporteGral.UseVisualStyleBackColor = False
        '
        'btnReporteIndividual
        '
        Me.btnReporteIndividual.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnReporteIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteIndividual.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteIndividual.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReporteIndividual.Location = New System.Drawing.Point(1103, 253)
        Me.btnReporteIndividual.Name = "btnReporteIndividual"
        Me.btnReporteIndividual.Size = New System.Drawing.Size(236, 42)
        Me.btnReporteIndividual.TabIndex = 4
        Me.btnReporteIndividual.Text = "Reporte Individual"
        Me.btnReporteIndividual.UseVisualStyleBackColor = False
        '
        'SaldoPorClienteProduccionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1371, 718)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReporteIndividual)
        Me.Controls.Add(Me.btnReporteGral)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SaldoPorClienteProduccionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo Por Cliente - Produccion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvOTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbTipoCliente As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvOTS As DataGridView
    Friend WithEvents FacturaCol As DataGridViewTextBoxColumn
    Friend WithEvents ClienteCol As DataGridViewTextBoxColumn
    Friend WithEvents OTCol As DataGridViewTextBoxColumn
    Friend WithEvents TotalFactCol As DataGridViewTextBoxColumn
    Friend WithEvents TotalPagCol As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCol As DataGridViewTextBoxColumn
    Friend WithEvents TotalPCol As DataGridViewTextBoxColumn
    Friend WithEvents ExpedidasCol As DataGridViewTextBoxColumn
    Friend WithEvents FaltantesCol As DataGridViewTextBoxColumn
    Friend WithEvents txtOT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReporteGral As Button
    Friend WithEvents btnReporteIndividual As Button
End Class
