﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PagoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabControlPago = New System.Windows.Forms.TabControl()
        Me.tabPagoNroOrden = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbPago = New System.Windows.Forms.GroupBox()
        Me.lblAvMonto = New System.Windows.Forms.Label()
        Me.lblAdvRecibo = New System.Windows.Forms.Label()
        Me.lblPagoResult = New System.Windows.Forms.Label()
        Me.txtFechaVenci = New System.Windows.Forms.MaskedTextBox()
        Me.lblCurrentCurr = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.cbTiposP = New System.Windows.Forms.ComboBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtRecibo = New System.Windows.Forms.TextBox()
        Me.txtFechaEmision = New System.Windows.Forms.TextBox()
        Me.txtMontoPago = New System.Windows.Forms.TextBox()
        Me.lblAdvBanco = New System.Windows.Forms.Label()
        Me.lblAdvCheque = New System.Windows.Forms.Label()
        Me.lblAdvFecha = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblFacturaNro = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCodVend = New System.Windows.Forms.Label()
        Me.txtCodClie = New System.Windows.Forms.Label()
        Me.lblFechaVenta = New System.Windows.Forms.Label()
        Me.lblNroOrden = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtOt = New System.Windows.Forms.TextBox()
        Me.lblFechaCaja = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoPagoCOl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tabControlPago.SuspendLayout()
        Me.tabPagoNroOrden.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbPago.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControlPago
        '
        Me.tabControlPago.Controls.Add(Me.tabPagoNroOrden)
        Me.tabControlPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlPago.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabControlPago.ItemSize = New System.Drawing.Size(313, 35)
        Me.tabControlPago.Location = New System.Drawing.Point(0, 0)
        Me.tabControlPago.Margin = New System.Windows.Forms.Padding(0)
        Me.tabControlPago.Name = "tabControlPago"
        Me.tabControlPago.Padding = New System.Drawing.Point(50, 2)
        Me.tabControlPago.SelectedIndex = 0
        Me.tabControlPago.Size = New System.Drawing.Size(1321, 792)
        Me.tabControlPago.TabIndex = 4
        '
        'tabPagoNroOrden
        '
        Me.tabPagoNroOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.tabPagoNroOrden.Controls.Add(Me.TableLayoutPanel1)
        Me.tabPagoNroOrden.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPagoNroOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tabPagoNroOrden.Location = New System.Drawing.Point(4, 39)
        Me.tabPagoNroOrden.Margin = New System.Windows.Forms.Padding(0)
        Me.tabPagoNroOrden.Name = "tabPagoNroOrden"
        Me.tabPagoNroOrden.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPagoNroOrden.Size = New System.Drawing.Size(1313, 749)
        Me.tabPagoNroOrden.TabIndex = 0
        Me.tabPagoNroOrden.Text = "Pago Por Número de Orden"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbPago, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1307, 743)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'gbPago
        '
        Me.gbPago.AutoSize = True
        Me.gbPago.Controls.Add(Me.lblAvMonto)
        Me.gbPago.Controls.Add(Me.lblAdvRecibo)
        Me.gbPago.Controls.Add(Me.lblPagoResult)
        Me.gbPago.Controls.Add(Me.txtFechaVenci)
        Me.gbPago.Controls.Add(Me.lblCurrentCurr)
        Me.gbPago.Controls.Add(Me.btnGuardar)
        Me.gbPago.Controls.Add(Me.cbBancos)
        Me.gbPago.Controls.Add(Me.cbTiposP)
        Me.gbPago.Controls.Add(Me.txtCheque)
        Me.gbPago.Controls.Add(Me.txtRecibo)
        Me.gbPago.Controls.Add(Me.txtFechaEmision)
        Me.gbPago.Controls.Add(Me.txtMontoPago)
        Me.gbPago.Controls.Add(Me.lblAdvBanco)
        Me.gbPago.Controls.Add(Me.lblAdvCheque)
        Me.gbPago.Controls.Add(Me.lblAdvFecha)
        Me.gbPago.Controls.Add(Me.Label9)
        Me.gbPago.Controls.Add(Me.Label13)
        Me.gbPago.Controls.Add(Me.Label14)
        Me.gbPago.Controls.Add(Me.Label15)
        Me.gbPago.Controls.Add(Me.Label11)
        Me.gbPago.Controls.Add(Me.Label16)
        Me.gbPago.Controls.Add(Me.Label17)
        Me.gbPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbPago.Enabled = False
        Me.gbPago.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gbPago.Location = New System.Drawing.Point(0, 300)
        Me.gbPago.Margin = New System.Windows.Forms.Padding(0)
        Me.gbPago.Name = "gbPago"
        Me.gbPago.Padding = New System.Windows.Forms.Padding(0)
        Me.gbPago.Size = New System.Drawing.Size(1307, 151)
        Me.gbPago.TabIndex = 3
        Me.gbPago.TabStop = False
        Me.gbPago.Text = "PAGO"
        '
        'lblAvMonto
        '
        Me.lblAvMonto.AutoEllipsis = True
        Me.lblAvMonto.AutoSize = True
        Me.lblAvMonto.BackColor = System.Drawing.Color.Maroon
        Me.lblAvMonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAvMonto.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvMonto.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblAvMonto.Location = New System.Drawing.Point(956, 30)
        Me.lblAvMonto.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAvMonto.Name = "lblAvMonto"
        Me.lblAvMonto.Size = New System.Drawing.Size(51, 19)
        Me.lblAvMonto.TabIndex = 29
        Me.lblAvMonto.Text = "Monto"
        Me.lblAvMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAvMonto.Visible = False
        '
        'lblAdvRecibo
        '
        Me.lblAdvRecibo.AutoSize = True
        Me.lblAdvRecibo.BackColor = System.Drawing.Color.Maroon
        Me.lblAdvRecibo.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvRecibo.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblAdvRecibo.Location = New System.Drawing.Point(956, 103)
        Me.lblAdvRecibo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAdvRecibo.Name = "lblAdvRecibo"
        Me.lblAdvRecibo.Size = New System.Drawing.Size(151, 19)
        Me.lblAdvRecibo.TabIndex = 29
        Me.lblAdvRecibo.Text = "Ingrese Nro. de Recibo"
        Me.lblAdvRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAdvRecibo.Visible = False
        '
        'lblPagoResult
        '
        Me.lblPagoResult.AutoSize = True
        Me.lblPagoResult.BackColor = System.Drawing.Color.ForestGreen
        Me.lblPagoResult.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagoResult.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblPagoResult.Location = New System.Drawing.Point(1141, 107)
        Me.lblPagoResult.Name = "lblPagoResult"
        Me.lblPagoResult.Size = New System.Drawing.Size(105, 19)
        Me.lblPagoResult.TabIndex = 28
        Me.lblPagoResult.Text = "Pago Realizado"
        Me.lblPagoResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPagoResult.Visible = False
        '
        'txtFechaVenci
        '
        Me.txtFechaVenci.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaVenci.Location = New System.Drawing.Point(325, 100)
        Me.txtFechaVenci.Margin = New System.Windows.Forms.Padding(0)
        Me.txtFechaVenci.Mask = "00/00/0000"
        Me.txtFechaVenci.Name = "txtFechaVenci"
        Me.txtFechaVenci.Size = New System.Drawing.Size(166, 25)
        Me.txtFechaVenci.TabIndex = 27
        Me.txtFechaVenci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFechaVenci.ValidatingType = GetType(Date)
        '
        'lblCurrentCurr
        '
        Me.lblCurrentCurr.AutoSize = True
        Me.lblCurrentCurr.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentCurr.Location = New System.Drawing.Point(956, 30)
        Me.lblCurrentCurr.Name = "lblCurrentCurr"
        Me.lblCurrentCurr.Size = New System.Drawing.Size(0, 19)
        Me.lblCurrentCurr.TabIndex = 25
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Image = Global.Frontend.My.Resources.Resources.guardar
        Me.btnGuardar.Location = New System.Drawing.Point(1124, 53)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(141, 49)
        Me.btnGuardar.TabIndex = 23
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
        Me.cbBancos.Location = New System.Drawing.Point(325, 30)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(166, 25)
        Me.cbBancos.TabIndex = 22
        '
        'cbTiposP
        '
        Me.cbTiposP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposP.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTiposP.FormattingEnabled = True
        Me.cbTiposP.Location = New System.Drawing.Point(9, 69)
        Me.cbTiposP.Name = "cbTiposP"
        Me.cbTiposP.Size = New System.Drawing.Size(165, 25)
        Me.cbTiposP.TabIndex = 22
        '
        'txtCheque
        '
        Me.txtCheque.Enabled = False
        Me.txtCheque.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(325, 68)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(166, 25)
        Me.txtCheque.TabIndex = 3
        '
        'txtRecibo
        '
        Me.txtRecibo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibo.Location = New System.Drawing.Point(801, 100)
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(152, 25)
        Me.txtRecibo.TabIndex = 3
        Me.txtRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.Enabled = False
        Me.txtFechaEmision.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaEmision.Location = New System.Drawing.Point(801, 65)
        Me.txtFechaEmision.Name = "txtFechaEmision"
        Me.txtFechaEmision.Size = New System.Drawing.Size(152, 25)
        Me.txtFechaEmision.TabIndex = 3
        Me.txtFechaEmision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMontoPago
        '
        Me.txtMontoPago.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPago.Location = New System.Drawing.Point(801, 30)
        Me.txtMontoPago.Name = "txtMontoPago"
        Me.txtMontoPago.Size = New System.Drawing.Size(152, 25)
        Me.txtMontoPago.TabIndex = 3
        Me.txtMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAdvBanco
        '
        Me.lblAdvBanco.AutoSize = True
        Me.lblAdvBanco.BackColor = System.Drawing.Color.Maroon
        Me.lblAdvBanco.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvBanco.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblAdvBanco.Location = New System.Drawing.Point(491, 33)
        Me.lblAdvBanco.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAdvBanco.Name = "lblAdvBanco"
        Me.lblAdvBanco.Size = New System.Drawing.Size(138, 19)
        Me.lblAdvBanco.TabIndex = 1
        Me.lblAdvBanco.Text = "Seleccione un banco"
        Me.lblAdvBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAdvBanco.Visible = False
        '
        'lblAdvCheque
        '
        Me.lblAdvCheque.AutoSize = True
        Me.lblAdvCheque.BackColor = System.Drawing.Color.Maroon
        Me.lblAdvCheque.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvCheque.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblAdvCheque.Location = New System.Drawing.Point(491, 71)
        Me.lblAdvCheque.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAdvCheque.Name = "lblAdvCheque"
        Me.lblAdvCheque.Size = New System.Drawing.Size(178, 19)
        Me.lblAdvCheque.TabIndex = 1
        Me.lblAdvCheque.Text = "Ingrese Nro Cheque/Boleta"
        Me.lblAdvCheque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAdvCheque.Visible = False
        '
        'lblAdvFecha
        '
        Me.lblAdvFecha.AutoSize = True
        Me.lblAdvFecha.BackColor = System.Drawing.Color.Maroon
        Me.lblAdvFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvFecha.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblAdvFecha.Location = New System.Drawing.Point(491, 103)
        Me.lblAdvFecha.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAdvFecha.Name = "lblAdvFecha"
        Me.lblAdvFecha.Size = New System.Drawing.Size(98, 19)
        Me.lblAdvFecha.TabIndex = 1
        Me.lblAdvFecha.Text = "Fecha Inválida"
        Me.lblAdvFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAdvFecha.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(184, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Vencimiento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Location = New System.Drawing.Point(184, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 19)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Cheque/Boleta Nro:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(184, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 19)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Banco"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Location = New System.Drawing.Point(699, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 19)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Fecha Emisión:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Location = New System.Drawing.Point(699, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Recibo Nro:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Location = New System.Drawing.Point(699, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Monto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Location = New System.Drawing.Point(3, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 19)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Tipo Pago"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.lblVendedor)
        Me.GroupBox1.Controls.Add(Me.lblFacturaNro)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.txtCodVend)
        Me.GroupBox1.Controls.Add(Me.txtCodClie)
        Me.GroupBox1.Controls.Add(Me.lblFechaVenta)
        Me.GroupBox1.Controls.Add(Me.lblNroOrden)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(3, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(1301, 227)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE LA ORDEN"
        '
        'lblVendedor
        '
        Me.lblVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblVendedor.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblVendedor.Location = New System.Drawing.Point(623, 94)
        Me.lblVendedor.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Padding = New System.Windows.Forms.Padding(4)
        Me.lblVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVendedor.Size = New System.Drawing.Size(232, 34)
        Me.lblVendedor.TabIndex = 22
        Me.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFacturaNro
        '
        Me.lblFacturaNro.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblFacturaNro.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturaNro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFacturaNro.Location = New System.Drawing.Point(565, 48)
        Me.lblFacturaNro.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFacturaNro.Name = "lblFacturaNro"
        Me.lblFacturaNro.Padding = New System.Windows.Forms.Padding(4)
        Me.lblFacturaNro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFacturaNro.Size = New System.Drawing.Size(290, 34)
        Me.lblFacturaNro.TabIndex = 22
        Me.lblFacturaNro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtObs.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtObs.Location = New System.Drawing.Point(953, 52)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(0)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObs.Size = New System.Drawing.Size(338, 80)
        Me.txtObs.TabIndex = 22
        '
        'lblCliente
        '
        Me.lblCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCliente.Location = New System.Drawing.Point(145, 94)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCliente.Size = New System.Drawing.Size(287, 34)
        Me.lblCliente.TabIndex = 22
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodVend
        '
        Me.txtCodVend.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtCodVend.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodVend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCodVend.Location = New System.Drawing.Point(565, 94)
        Me.txtCodVend.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCodVend.Name = "txtCodVend"
        Me.txtCodVend.Padding = New System.Windows.Forms.Padding(4)
        Me.txtCodVend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodVend.Size = New System.Drawing.Size(43, 34)
        Me.txtCodVend.TabIndex = 22
        Me.txtCodVend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodClie
        '
        Me.txtCodClie.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtCodClie.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodClie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCodClie.Location = New System.Drawing.Point(87, 94)
        Me.txtCodClie.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCodClie.Name = "txtCodClie"
        Me.txtCodClie.Padding = New System.Windows.Forms.Padding(4)
        Me.txtCodClie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodClie.Size = New System.Drawing.Size(48, 34)
        Me.txtCodClie.TabIndex = 22
        Me.txtCodClie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblFechaVenta.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFechaVenta.Location = New System.Drawing.Point(87, 46)
        Me.lblFechaVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.Padding = New System.Windows.Forms.Padding(4)
        Me.lblFechaVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaVenta.Size = New System.Drawing.Size(122, 34)
        Me.lblFechaVenta.TabIndex = 22
        Me.lblFechaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNroOrden
        '
        Me.lblNroOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblNroOrden.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNroOrden.Location = New System.Drawing.Point(297, 48)
        Me.lblNroOrden.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNroOrden.Name = "lblNroOrden"
        Me.lblNroOrden.Padding = New System.Windows.Forms.Padding(4)
        Me.lblNroOrden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNroOrden.Size = New System.Drawing.Size(135, 34)
        Me.lblNroOrden.TabIndex = 22
        Me.lblNroOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.txtSaldo)
        Me.Panel4.Controls.Add(Me.txtPago)
        Me.Panel4.Controls.Add(Me.txtIva)
        Me.Panel4.Controls.Add(Me.txtTotal)
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(20, 151)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(908, 58)
        Me.Panel4.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(1, 21)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 19)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Total"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Location = New System.Drawing.Point(211, 21)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 19)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "IVA"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label24.Location = New System.Drawing.Point(651, 20)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 19)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Saldo"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label23.Location = New System.Drawing.Point(417, 21)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 19)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Pagado"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtSaldo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSaldo.Location = New System.Drawing.Point(699, 11)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Padding = New System.Windows.Forms.Padding(4)
        Me.txtSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaldo.Size = New System.Drawing.Size(151, 34)
        Me.txtSaldo.TabIndex = 22
        Me.txtSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtPago.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPago.Location = New System.Drawing.Point(476, 12)
        Me.txtPago.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Padding = New System.Windows.Forms.Padding(4)
        Me.txtPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPago.Size = New System.Drawing.Size(151, 34)
        Me.txtPago.TabIndex = 22
        Me.txtPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIva
        '
        Me.txtIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtIva.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIva.Location = New System.Drawing.Point(253, 12)
        Me.txtIva.Margin = New System.Windows.Forms.Padding(0)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Padding = New System.Windows.Forms.Padding(4)
        Me.txtIva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIva.Size = New System.Drawing.Size(151, 34)
        Me.txtIva.TabIndex = 22
        Me.txtIva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTotal.Location = New System.Drawing.Point(54, 12)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Padding = New System.Windows.Forms.Padding(4)
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotal.Size = New System.Drawing.Size(151, 34)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(463, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Factura Nro:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(953, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Observacion"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(212, 52)
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
        Me.Label3.Location = New System.Drawing.Point(19, 52)
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
        Me.Label4.Location = New System.Drawing.Point(463, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vendedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(13, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cliente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtOt)
        Me.Panel1.Controls.Add(Me.lblFechaCaja)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1301, 61)
        Me.Panel1.TabIndex = 2
        '
        'txtOt
        '
        Me.txtOt.Location = New System.Drawing.Point(139, 18)
        Me.txtOt.Name = "txtOt"
        Me.txtOt.Size = New System.Drawing.Size(184, 30)
        Me.txtOt.TabIndex = 3
        Me.txtOt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFechaCaja
        '
        Me.lblFechaCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblFechaCaja.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFechaCaja.Location = New System.Drawing.Point(441, 16)
        Me.lblFechaCaja.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaCaja.Name = "lblFechaCaja"
        Me.lblFechaCaja.Padding = New System.Windows.Forms.Padding(4)
        Me.lblFechaCaja.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaCaja.Size = New System.Drawing.Size(235, 34)
        Me.lblFechaCaja.TabIndex = 22
        Me.lblFechaCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(25, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NRO ORDEN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(356, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fecha Caja"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnDetalle)
        Me.Panel2.Controls.Add(Me.dgvPagos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 451)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1307, 292)
        Me.Panel2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = Global.Frontend.My.Resources.Resources.eliminar
        Me.Button1.Location = New System.Drawing.Point(1047, 93)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 49)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Anular Pago"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDetalle.Image = Global.Frontend.My.Resources.Resources.nuevo
        Me.btnDetalle.Location = New System.Drawing.Point(1047, 31)
        Me.btnDetalle.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(141, 49)
        Me.btnDetalle.TabIndex = 20
        Me.btnDetalle.Text = "Ver Detalle"
        Me.btnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDetalle.UseVisualStyleBackColor = False
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPagos.ColumnHeadersHeight = 30
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.VentaCol, Me.FechaCol, Me.TipoPCol, Me.MontoCol, Me.Recibo, Me.EstadoPagoCOl})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPagos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPagos.EnableHeadersVisualStyles = False
        Me.dgvPagos.Location = New System.Drawing.Point(29, 31)
        Me.dgvPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPagos.MultiSelect = False
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.RowHeadersVisible = False
        Me.dgvPagos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPagos.RowTemplate.Height = 24
        Me.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagos.Size = New System.Drawing.Size(1003, 154)
        Me.dgvPagos.TabIndex = 19
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'VentaCol
        '
        Me.VentaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VentaCol.DataPropertyName = "Venta"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.VentaCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.VentaCol.HeaderText = "Venta"
        Me.VentaCol.Name = "VentaCol"
        Me.VentaCol.Visible = False
        '
        'FechaCol
        '
        Me.FechaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaCol.DataPropertyName = "Fecha"
        Me.FechaCol.HeaderText = "Fecha"
        Me.FechaCol.Name = "FechaCol"
        '
        'TipoPCol
        '
        Me.TipoPCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TipoPCol.DataPropertyName = "Tipo Pago"
        Me.TipoPCol.HeaderText = "Tipo Pago"
        Me.TipoPCol.Name = "TipoPCol"
        '
        'MontoCol
        '
        Me.MontoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MontoCol.DataPropertyName = "Monto"
        Me.MontoCol.HeaderText = "Monto"
        Me.MontoCol.Name = "MontoCol"
        '
        'Recibo
        '
        Me.Recibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Recibo.DataPropertyName = "Recibo Nro."
        Me.Recibo.HeaderText = "Recibo Nro."
        Me.Recibo.Name = "Recibo"
        '
        'EstadoPagoCOl
        '
        Me.EstadoPagoCOl.DataPropertyName = "Estado"
        Me.EstadoPagoCOl.HeaderText = "Estado"
        Me.EstadoPagoCOl.Name = "EstadoPagoCOl"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = Global.Frontend.My.Resources.Resources.planos3
        Me.Button2.Location = New System.Drawing.Point(1047, 164)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 49)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Facturas Anuladas"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PagoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1321, 792)
        Me.Controls.Add(Me.tabControlPago)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "PagoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PagoForm"
        Me.tabControlPago.ResumeLayout(False)
        Me.tabPagoNroOrden.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gbPago.ResumeLayout(False)
        Me.gbPago.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControlPago As TabControl
    Friend WithEvents tabPagoNroOrden As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtOt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents gbPago As GroupBox
    Friend WithEvents cbBancos As ComboBox
    Friend WithEvents cbTiposP As ComboBox
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
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblVendedor As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblNroOrden As Label
    Friend WithEvents lblFechaCaja As Label
    Friend WithEvents lblFacturaNro As Label
    Friend WithEvents txtCodVend As Label
    Friend WithEvents txtCodClie As Label
    Friend WithEvents lblFechaVenta As Label
    Friend WithEvents txtObs As Label
    Friend WithEvents txtSaldo As Label
    Friend WithEvents txtPago As Label
    Friend WithEvents txtIva As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents lblCurrentCurr As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDetalle As Button
    Friend WithEvents dgvPagos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents VentaCol As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents TipoPCol As DataGridViewTextBoxColumn
    Friend WithEvents MontoCol As DataGridViewTextBoxColumn
    Friend WithEvents Recibo As DataGridViewTextBoxColumn
    Friend WithEvents EstadoPagoCOl As DataGridViewTextBoxColumn
    Friend WithEvents txtFechaVenci As MaskedTextBox
    Friend WithEvents lblAdvFecha As Label
    Friend WithEvents lblPagoResult As Label
    Friend WithEvents lblAdvRecibo As Label
    Friend WithEvents lblAvMonto As Label
    Friend WithEvents lblAdvBanco As Label
    Friend WithEvents lblAdvCheque As Label
    Friend WithEvents Button2 As Button
End Class
