<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoDetalle
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblchequev = New System.Windows.Forms.Label()
        Me.lblCheque = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblRecibo = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblTipoPago = New System.Windows.Forms.Label()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.lblNroOrden = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblComent = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(1116, 49)
        Me.Panel1.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(424, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(289, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "DETALLE DEL PAGO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblComent)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lblchequev)
        Me.GroupBox1.Controls.Add(Me.lblCheque)
        Me.GroupBox1.Controls.Add(Me.lblBanco)
        Me.GroupBox1.Controls.Add(Me.lblRecibo)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.lblTipoPago)
        Me.GroupBox1.Controls.Add(Me.lblFechaPago)
        Me.GroupBox1.Controls.Add(Me.lblNroOrden)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(24, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1072, 223)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(321, 103)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 19)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Recibo Nro."
        '
        'lblchequev
        '
        Me.lblchequev.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblchequev.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchequev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblchequev.Location = New System.Drawing.Point(822, 147)
        Me.lblchequev.Margin = New System.Windows.Forms.Padding(0)
        Me.lblchequev.Name = "lblchequev"
        Me.lblchequev.Padding = New System.Windows.Forms.Padding(4)
        Me.lblchequev.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblchequev.Size = New System.Drawing.Size(206, 36)
        Me.lblchequev.TabIndex = 22
        Me.lblchequev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCheque
        '
        Me.lblCheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblCheque.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCheque.Location = New System.Drawing.Point(822, 95)
        Me.lblCheque.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCheque.Name = "lblCheque"
        Me.lblCheque.Padding = New System.Windows.Forms.Padding(4)
        Me.lblCheque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCheque.Size = New System.Drawing.Size(206, 36)
        Me.lblCheque.TabIndex = 22
        Me.lblCheque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBanco
        '
        Me.lblBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblBanco.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBanco.Location = New System.Drawing.Point(822, 42)
        Me.lblBanco.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Padding = New System.Windows.Forms.Padding(4)
        Me.lblBanco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBanco.Size = New System.Drawing.Size(206, 36)
        Me.lblBanco.TabIndex = 22
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecibo
        '
        Me.lblRecibo.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblRecibo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecibo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRecibo.Location = New System.Drawing.Point(408, 92)
        Me.lblRecibo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRecibo.Name = "lblRecibo"
        Me.lblRecibo.Padding = New System.Windows.Forms.Padding(4)
        Me.lblRecibo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRecibo.Size = New System.Drawing.Size(251, 36)
        Me.lblRecibo.TabIndex = 22
        Me.lblRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonto
        '
        Me.lblMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblMonto.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMonto.Location = New System.Drawing.Point(106, 144)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Padding = New System.Windows.Forms.Padding(4)
        Me.lblMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMonto.Size = New System.Drawing.Size(192, 36)
        Me.lblMonto.TabIndex = 22
        Me.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoPago
        '
        Me.lblTipoPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblTipoPago.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTipoPago.Location = New System.Drawing.Point(409, 41)
        Me.lblTipoPago.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Padding = New System.Windows.Forms.Padding(4)
        Me.lblTipoPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoPago.Size = New System.Drawing.Size(250, 36)
        Me.lblTipoPago.TabIndex = 22
        Me.lblTipoPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaPago
        '
        Me.lblFechaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblFechaPago.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFechaPago.Location = New System.Drawing.Point(106, 95)
        Me.lblFechaPago.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Padding = New System.Windows.Forms.Padding(4)
        Me.lblFechaPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaPago.Size = New System.Drawing.Size(192, 36)
        Me.lblFechaPago.TabIndex = 22
        Me.lblFechaPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNroOrden
        '
        Me.lblNroOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblNroOrden.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNroOrden.Location = New System.Drawing.Point(109, 48)
        Me.lblNroOrden.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNroOrden.Name = "lblNroOrden"
        Me.lblNroOrden.Padding = New System.Windows.Forms.Padding(4)
        Me.lblNroOrden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNroOrden.Size = New System.Drawing.Size(189, 36)
        Me.lblNroOrden.TabIndex = 22
        Me.lblNroOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(672, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cheque Vencimiento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(752, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Banco"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(709, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cheque Nro."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(5, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nro. Orden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(5, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto Pagado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(321, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(322, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comentario"
        '
        'lblComent
        '
        Me.lblComent.AutoEllipsis = True
        Me.lblComent.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblComent.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblComent.Location = New System.Drawing.Point(409, 134)
        Me.lblComent.Margin = New System.Windows.Forms.Padding(0)
        Me.lblComent.Name = "lblComent"
        Me.lblComent.Padding = New System.Windows.Forms.Padding(4)
        Me.lblComent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComent.Size = New System.Drawing.Size(250, 67)
        Me.lblComent.TabIndex = 23
        Me.lblComent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PagoDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1116, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PagoDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago Detalle"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lblchequev As Label
    Friend WithEvents lblCheque As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents lblRecibo As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblTipoPago As Label
    Friend WithEvents lblFechaPago As Label
    Friend WithEvents lblNroOrden As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblComent As Label
    Friend WithEvents Label2 As Label
End Class
