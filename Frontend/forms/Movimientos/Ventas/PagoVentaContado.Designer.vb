<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoVentaContado
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTipoPago = New System.Windows.Forms.Label()
        Me.cbTipodePago = New System.Windows.Forms.ComboBox()
        Me.dpChequeVenc = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtRecibo = New System.Windows.Forms.TextBox()
        Me.txtFechaEmision = New System.Windows.Forms.TextBox()
        Me.txtMontoPago = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblCurrentCurr = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(769, 46)
        Me.Panel1.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(196, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(360, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "PAGO VENTA CONTADO"
        '
        'lblTipoPago
        '
        Me.lblTipoPago.AutoSize = True
        Me.lblTipoPago.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTipoPago.Location = New System.Drawing.Point(26, 40)
        Me.lblTipoPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Size = New System.Drawing.Size(91, 19)
        Me.lblTipoPago.TabIndex = 18
        Me.lblTipoPago.Text = "Tipo De Pago"
        '
        'cbTipodePago
        '
        Me.cbTipodePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipodePago.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipodePago.FormattingEnabled = True
        Me.cbTipodePago.Location = New System.Drawing.Point(164, 37)
        Me.cbTipodePago.Name = "cbTipodePago"
        Me.cbTipodePago.Size = New System.Drawing.Size(166, 25)
        Me.cbTipodePago.TabIndex = 17
        '
        'dpChequeVenc
        '
        Me.dpChequeVenc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dpChequeVenc.Enabled = False
        Me.dpChequeVenc.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpChequeVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpChequeVenc.Location = New System.Drawing.Point(164, 166)
        Me.dpChequeVenc.Name = "dpChequeVenc"
        Me.dpChequeVenc.Size = New System.Drawing.Size(166, 25)
        Me.dpChequeVenc.TabIndex = 37
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Image = Global.Frontend.My.Resources.Resources.guardar
        Me.btnGuardar.Location = New System.Drawing.Point(287, 227)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(173, 49)
        Me.btnGuardar.TabIndex = 36
        Me.btnGuardar.Text = "Guardar Pago"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.Enabled = False
        Me.cbBancos.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(164, 92)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(166, 25)
        Me.cbBancos.TabIndex = 35
        '
        'txtCheque
        '
        Me.txtCheque.Enabled = False
        Me.txtCheque.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(164, 130)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(166, 25)
        Me.txtCheque.TabIndex = 31
        '
        'txtRecibo
        '
        Me.txtRecibo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibo.Location = New System.Drawing.Point(498, 167)
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(152, 25)
        Me.txtRecibo.TabIndex = 32
        Me.txtRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.Enabled = False
        Me.txtFechaEmision.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaEmision.Location = New System.Drawing.Point(498, 127)
        Me.txtFechaEmision.Name = "txtFechaEmision"
        Me.txtFechaEmision.Size = New System.Drawing.Size(152, 25)
        Me.txtFechaEmision.TabIndex = 33
        Me.txtFechaEmision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMontoPago
        '
        Me.txtMontoPago.Enabled = False
        Me.txtMontoPago.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPago.Location = New System.Drawing.Point(498, 91)
        Me.txtMontoPago.Name = "txtMontoPago"
        Me.txtMontoPago.Size = New System.Drawing.Size(152, 25)
        Me.txtMontoPago.TabIndex = 34
        Me.txtMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(26, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 19)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Vencimiento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Location = New System.Drawing.Point(26, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 19)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Cheque/Boleta Nro:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(26, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 19)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Banco"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Location = New System.Drawing.Point(386, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 19)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Fecha Emisión:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Location = New System.Drawing.Point(386, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 19)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Recibo Nro:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Location = New System.Drawing.Point(386, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 19)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Monto"
        '
        'lblCurrentCurr
        '
        Me.lblCurrentCurr.AutoSize = True
        Me.lblCurrentCurr.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentCurr.Location = New System.Drawing.Point(656, 95)
        Me.lblCurrentCurr.Name = "lblCurrentCurr"
        Me.lblCurrentCurr.Size = New System.Drawing.Size(0, 19)
        Me.lblCurrentCurr.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbTipodePago)
        Me.GroupBox1.Controls.Add(Me.lblCurrentCurr)
        Me.GroupBox1.Controls.Add(Me.lblTipoPago)
        Me.GroupBox1.Controls.Add(Me.dpChequeVenc)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbBancos)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCheque)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtRecibo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtFechaEmision)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMontoPago)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 295)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'PagoVentaContado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 369)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PagoVentaContado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PagoVentaContado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTipoPago As Label
    Friend WithEvents cbTipodePago As ComboBox
    Friend WithEvents dpChequeVenc As DateTimePicker
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cbBancos As ComboBox
    Friend WithEvents txtCheque As TextBox
    Friend WithEvents txtRecibo As TextBox
    Friend WithEvents txtFechaEmision As TextBox
    Friend WithEvents txtMontoPago As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblCurrentCurr As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
