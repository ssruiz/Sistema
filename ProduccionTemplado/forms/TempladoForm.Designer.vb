<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempladoForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNroProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoturaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorteCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AltoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnchoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanhoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroProdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPulidora = New System.Windows.Forms.Label()
        Me.dgvPulida = New System.Windows.Forms.DataGridView()
        Me.txtSalidaEntrada = New System.Windows.Forms.Label()
        Me.lblFechaVenta = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMesa1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPulida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.Location = New System.Drawing.Point(759, 174)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(213, 69)
        Me.btnConfirmar.TabIndex = 44
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(540, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(181, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "TEMPLADO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNroProd)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 77)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(517, 79)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'txtNroProd
        '
        Me.txtNroProd.Location = New System.Drawing.Point(177, 33)
        Me.txtNroProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroProd.Name = "txtNroProd"
        Me.txtNroProd.Size = New System.Drawing.Size(299, 22)
        Me.txtNroProd.TabIndex = 8
        Me.txtNroProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(15, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro Producción"
        '
        'RoturaCol
        '
        Me.RoturaCol.DataPropertyName = "Rotura"
        Me.RoturaCol.HeaderText = "Rotura"
        Me.RoturaCol.Name = "RoturaCol"
        '
        'SalidaCol
        '
        Me.SalidaCol.DataPropertyName = "Salida"
        Me.SalidaCol.HeaderText = "Salida"
        Me.SalidaCol.Name = "SalidaCol"
        '
        'CorteCol
        '
        Me.CorteCol.DataPropertyName = "Horno"
        Me.CorteCol.HeaderText = "Horno"
        Me.CorteCol.Name = "CorteCol"
        '
        'AltoCol
        '
        Me.AltoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AltoCol.DataPropertyName = "Alto"
        Me.AltoCol.HeaderText = "Alto"
        Me.AltoCol.Name = "AltoCol"
        '
        'AnchoCol
        '
        Me.AnchoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AnchoCol.DataPropertyName = "Ancho"
        Me.AnchoCol.HeaderText = "Ancho"
        Me.AnchoCol.Name = "AnchoCol"
        '
        'PanhoCol
        '
        Me.PanhoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PanhoCol.DataPropertyName = "Panho"
        Me.PanhoCol.HeaderText = "Paño"
        Me.PanhoCol.Name = "PanhoCol"
        '
        'FechaCol
        '
        Me.FechaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaCol.DataPropertyName = "Código"
        Me.FechaCol.HeaderText = "Código"
        Me.FechaCol.Name = "FechaCol"
        '
        'NroProdCol
        '
        Me.NroProdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NroProdCol.DataPropertyName = "Nro. Prod."
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.NroProdCol.DefaultCellStyle = DataGridViewCellStyle5
        Me.NroProdCol.HeaderText = "Nro. Prod."
        Me.NroProdCol.Name = "NroProdCol"
        '
        'txtPulidora
        '
        Me.txtPulidora.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPulidora.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulidora.ForeColor = System.Drawing.Color.AliceBlue
        Me.txtPulidora.Location = New System.Drawing.Point(762, 77)
        Me.txtPulidora.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPulidora.Name = "txtPulidora"
        Me.txtPulidora.Padding = New System.Windows.Forms.Padding(4)
        Me.txtPulidora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPulidora.Size = New System.Drawing.Size(463, 69)
        Me.txtPulidora.TabIndex = 43
        Me.txtPulidora.Text = "MESA DE PULIDA1"
        Me.txtPulidora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPulida
        '
        Me.dgvPulida.AllowUserToAddRows = False
        Me.dgvPulida.AllowUserToDeleteRows = False
        Me.dgvPulida.AllowUserToResizeColumns = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPulida.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPulida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPulida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPulida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPulida.ColumnHeadersHeight = 30
        Me.dgvPulida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPulida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroProdCol, Me.FechaCol, Me.PanhoCol, Me.AnchoCol, Me.AltoCol, Me.CorteCol, Me.SalidaCol, Me.RoturaCol})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPulida.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPulida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPulida.EnableHeadersVisualStyles = False
        Me.dgvPulida.Location = New System.Drawing.Point(36, 296)
        Me.dgvPulida.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPulida.MultiSelect = False
        Me.dgvPulida.Name = "dgvPulida"
        Me.dgvPulida.RowHeadersVisible = False
        Me.dgvPulida.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPulida.RowTemplate.Height = 24
        Me.dgvPulida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPulida.Size = New System.Drawing.Size(1188, 382)
        Me.dgvPulida.TabIndex = 42
        '
        'txtSalidaEntrada
        '
        Me.txtSalidaEntrada.AutoSize = True
        Me.txtSalidaEntrada.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalidaEntrada.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtSalidaEntrada.Location = New System.Drawing.Point(15, 30)
        Me.txtSalidaEntrada.Name = "txtSalidaEntrada"
        Me.txtSalidaEntrada.Size = New System.Drawing.Size(93, 23)
        Me.txtSalidaEntrada.TabIndex = 23
        Me.txtSalidaEntrada.Text = "Nro. Salida"
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblFechaVenta.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFechaVenta.Location = New System.Drawing.Point(385, 23)
        Me.lblFechaVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.Padding = New System.Windows.Forms.Padding(4)
        Me.lblFechaVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaVenta.Size = New System.Drawing.Size(113, 34)
        Me.lblFechaVenta.TabIndex = 24
        Me.lblFechaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(304, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Roturas"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(140, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(4)
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(113, 34)
        Me.Label1.TabIndex = 26
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMesa1
        '
        Me.btnMesa1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnMesa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMesa1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMesa1.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMesa1.Image = Global.ProduccionTemplado.My.Resources.Resources._3
        Me.btnMesa1.Location = New System.Drawing.Point(1009, 172)
        Me.btnMesa1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMesa1.Name = "btnMesa1"
        Me.btnMesa1.Size = New System.Drawing.Size(215, 69)
        Me.btnMesa1.TabIndex = 45
        Me.btnMesa1.Text = "Rotura"
        Me.btnMesa1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMesa1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSalidaEntrada)
        Me.GroupBox1.Controls.Add(Me.lblFechaVenta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 164)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(517, 79)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 49)
        Me.Panel1.TabIndex = 39
        '
        'TempladoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 716)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtPulidora)
        Me.Controls.Add(Me.dgvPulida)
        Me.Controls.Add(Me.btnMesa1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TempladoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TempladoForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvPulida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConfirmar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNroProd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RoturaCol As DataGridViewTextBoxColumn
    Friend WithEvents SalidaCol As DataGridViewTextBoxColumn
    Friend WithEvents CorteCol As DataGridViewTextBoxColumn
    Friend WithEvents AltoCol As DataGridViewTextBoxColumn
    Friend WithEvents AnchoCol As DataGridViewTextBoxColumn
    Friend WithEvents PanhoCol As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents NroProdCol As DataGridViewTextBoxColumn
    Friend WithEvents txtPulidora As Label
    Friend WithEvents dgvPulida As DataGridView
    Friend WithEvents txtSalidaEntrada As Label
    Friend WithEvents lblFechaVenta As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMesa1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
