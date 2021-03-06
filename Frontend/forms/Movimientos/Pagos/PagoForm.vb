﻿Imports System.Globalization
Imports Backend

Public Class PagoForm
    Dim venta As New Venta
    Dim cambio As New Cambio
    Dim montoTotal = 0
    Private Sub PagoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        Dim classResize As New ClsResizeForm
        classResize.ResizeForm(Me, 1339, 839)
        Me.WindowState = FormWindowState.Maximized
        Me.ResumeLayout()
        Me.Show()
        cargarTiposP()
        cargarBancos()
        cargarCambio()
        txtMontoPago.Text = 0
        PersonalizarDAtagridView(Me.dgvPagos)
        txtOt.Focus()

    End Sub

    Private Sub cargarTiposP()
        Try
            Dim tipoDao As New TipoPagoDAO
            Dim res = tipoDao.getTipos()
            cbTiposP.DisplayMember = "Tipo"
            cbTiposP.ValueMember = "ID"
            cbTiposP.DataSource = res.Tables("tabla")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargarCambio()
        Try
            Dim daoc As New CambioDAO
            cambio = daoc.getCambio()
            'lblCambio.Text = FormatCurrency(cambio.cambio)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarBancos()
        Try
            Dim bancoDao As New BancoDAO
            Dim res = bancoDao.getBancos()
            Dim lista2 = res.Tables("tabla").Copy()
            Dim rowSol = lista2.NewRow

            rowSol("Nombre") = "-- Seleccione un Banco -- "
            rowSol("ID") = 0

            lista2.Rows.InsertAt(rowSol, 0)

            cbBancos.DataSource = lista2
            cbBancos.DisplayMember = "Nombre"
            cbBancos.ValueMember = "ID"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tabControlPago.DrawItem

        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = tabControlPago.TabPages(e.Index)
        Dim ItemRect As Rectangle = tabControlPago.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.FromArgb(146, 43, 18))
        Dim TextBrush As New SolidBrush(Color.White)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.FromArgb(216, 65, 28)
            TextBrush.Color = Color.White
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If tabControlPago.Alignment = TabAlignment.Left Or tabControlPago.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If tabControlPago.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()

        Dim fb As New SolidBrush(Color.FromArgb(26, 51, 92)) 'Me.BackColor)
        Dim LastTabRect As Rectangle = tabControlPago.GetTabRect(tabControlPago.TabPages.Count - 1)
        Dim Rect As Rectangle

        Rect.Location = New Point(LastTabRect.Right + tabControlPago.Left, tabControlPago.Top)
        Rect.Size = New Size(tabControlPago.Right - Rect.Left, LastTabRect.Height)
        e.Graphics.FillRectangle(fb, Rect)

        fb.Dispose()

        'Label2.Text = "rect location = " & Rect.X & ", " & Rect.Y & ", Size = " & Rect.Width & ", " & Rect.Height
    End Sub

    Private Sub txtOt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim ot = ""
            If txtOt.Text = "" Then
                'Dim busquedaCli As New ClienteBusqueda
                'busquedaCli.ShowDialog()
                'Dim cli = busquedaCli.cliente
                'busquedaCli.Dispose()


                Dim busquedaOT As New VentaBusqueda

                busquedaOT.inicial = 1
                Dim r = busquedaOT.ShowDialog()
                If r = DialogResult.OK Then
                    ot = busquedaOT.ventaSel
                End If


                busquedaOT.Dispose()

            Else
                ot = txtOt.Text
            End If
            e.SuppressKeyPress = True
            Dim daoP As New VentaDAO
            Dim ventaAux = daoP.getVenta(ot)
            If ot <> "" Then
                cargarVentaOT(ot)
                cbTiposP.Focus()
            End If
        End If
        lblPagoResult.Visible = False
        lblAdvFecha.Visible = False
    End Sub

    Private Sub cargarVentaOT(ByVal id As String)
        Try
            Dim daoV As New VentaDAO
            Dim ventaaux = daoV.getVenta(id)

            If ventaaux.id <> 0 Then
                venta = ventaaux
                gbPago.Enabled = True
                lblFechaVenta.Text = venta.fecha
                lblNroOrden.Text = venta.id
                lblFacturaNro.Text = venta.factura

                lblFechaCaja.Text = Date.Now
                txtObs.Text = venta.obs
                Dim tmp = CDbl(venta.total)

                If venta.moneda = "G" Then

                    txtTotal.Text = FormatCurrency(tmp, 0)
                    txtIva.Text = FormatCurrency(tmp / 11, 0)
                    txtSaldo.Text = FormatCurrency(venta.saldo, 0)
                    txtPago.Text = FormatCurrency(tmp - venta.saldo)
                    txtMontoPago.Text = FormatCurrency(venta.saldo, 0)
                Else
                    Dim totalS = tmp.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                    Dim IvaS = CDbl(tmp / 11).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                    Dim saldoS = venta.saldo.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                    Dim pagoS = (tmp - venta.saldo).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                    txtTotal.Text = totalS
                    txtIva.Text = IvaS
                    txtSaldo.Text = saldoS
                    txtPago.Text = pagoS
                    txtMontoPago.Text = saldoS
                End If

                If venta.credito = "N" Then
                    txtRecibo.Text = 0
                    txtRecibo.Enabled = False
                Else
                    txtRecibo.Text = ""
                    txtRecibo.Enabled = True
                End If
                'If venta.envio = "N" Then
                '    lblFechaPrometida.Text = ""
                'Else
                '    lblFechaPrometida.Text = venta.fechaP
                'End If
                cargarCliente()
                txtOt.Text = ""
                cargarPagos()
                btnGuardar.Enabled = True
                txtFechaEmision.Text = Date.Today
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargarPagos()
        Try
            Dim daoP As New PagoDAO
            Dim res = daoP.getPagos(venta.id)
            dgvPagos.DataSource = res.Tables("tabla")
            dgvPagos.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargarCliente()
        Try
            Dim daoC As New ClienteDAO
            Dim cliente = daoC.getCliente(venta.cliente)
            lblCliente.Text = cliente.nombre
            txtCodClie.Text = cliente.id
            asignarVendedor(cliente.vendedor)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub asignarVendedor(ByVal idVend As Integer)
        Try
            Dim daoV As New VendedorDAO
            Dim vendedor = daoV.getVendedor(idVend)
            lblVendedor.Text = vendedor.nombre
            txtCodVend.Text = vendedor.id
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If venta.saldo = 0 Then
            MsgBox("Venta ya saldada", MsgBoxStyle.Information, "Pago")
        Else
            If validarPago() Then
                Dim result As Integer = MessageBox.Show("¿Guardar el pago?", "Guardar", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    guardarPago()
                    txtOt.Focus()
                    'txtOt.Select()
                End If
            End If
        End If
    End Sub

    Private Function validarPago() As Boolean
        If txtMontoPago.Text = "" Then
            'MsgBox("Ingrese un monto para el pago", MsgBoxStyle.Critical, "Monto")
            lblAvMonto.Text = "Ingrese un monto para el pago"
            lblAvMonto.Visible = True
            txtMontoPago.Focus()
            Return False
        ElseIf CDbl(txtMontoPago.Text.Replace("$", "")) = 0 Then
            lblAvMonto.Text = "Ingrese un monto mayor a 0 para el pago"
            lblAvMonto.Visible = True
            'MsgBox("Ingrese un monto mayor a 0 para el pago", MsgBoxStyle.Critical, "Monto")
            txtMontoPago.Focus()
            Return False
        End If

        If txtRecibo.Text = "" Then
            'MsgBox("Ingrese un número de recibo", MsgBoxStyle.Critical, "Monto")
            lblAdvRecibo.Visible = True
            txtRecibo.Focus()
            Return False
        Else
            lblAdvRecibo.Visible = False
        End If

        If venta.moneda = "G" Then
            If cbTiposP.SelectedValue = 2 Or cbTiposP.SelectedValue = 4 Then
                Dim montoGS = CDbl(txtMontoPago.Text.Replace("$", "")) * cambio.cambio
                If montoGS > venta.saldo Then
                    lblAvMonto.Text = "El monto ingresado en dolares al cambio actual son " & montoGS & "GS. y supera al saldo de la venta"
                    lblAvMonto.Visible = True
                    ' MsgBox("El monto ingresado en dolares al cambio actual son " & montoGS & "GS. y supera al saldo de la venta", MsgBoxStyle.Critical, "Monto")
                    txtMontoPago.Text = ""
                    txtMontoPago.Focus()
                    Return False
                End If
            Else
                If CDbl(txtMontoPago.Text) > venta.saldo Then
                    lblAvMonto.Text = "El monto supera al saldo de la venta"
                    lblAvMonto.Visible = True
                    'MsgBox("El monto supera al saldo de la venta", MsgBoxStyle.Critical, "Monto")
                    txtMontoPago.Focus()
                    Return False
                End If
            End If
        Else
            If cbTiposP.SelectedValue = 1 Or cbTiposP.SelectedValue = 3 Then
                Dim montoGS = CDbl(txtMontoPago.Text) / cambio.cambio
                If montoGS > venta.saldo Then
                    lblAvMonto.Text = "El monto ingresado en dolares al cambio actual son " & montoGS & "GS. y supera al saldo de la venta"
                    lblAvMonto.Visible = True
                    txtMontoPago.Text = ""
                    txtMontoPago.Focus()
                    Return False
                End If
            Else
                If CDbl(txtMontoPago.Text.Replace("$", "")) > venta.saldo Then
                    lblAvMonto.Text = "El monto supera al saldo de la venta"
                    lblAvMonto.Visible = True
                    txtMontoPago.Focus()
                    Return False
                End If
            End If
        End If
        ' Pago con cheques
        Dim test As Date
        If cbTiposP.SelectedValue = 3 Or cbTiposP.SelectedValue = 4 Or cbTiposP.SelectedValue = 7 Then
            If cbBancos.SelectedValue = 0 Then
                'MsgBox("Seleccione un banco", MsgBoxStyle.Critical, "Banco no seleccionado")
                lblAdvBanco.Visible = True
                cbBancos.Focus()
                Return False
            ElseIf txtCheque.Text = "" Then
                'MsgBox("Ingrese un número de cheque", MsgBoxStyle.Critical, "Cheque no ingresado")
                lblAdvCheque.Visible = True
                txtCheque.Focus()
                Return False
            ElseIf Not Date.TryParseExact(txtFechaVenci.Text.ToString(), "dd/mm/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, test) Then
                'MsgBox("Fecha de vencimiento ya pasada", MsgBoxStyle.Critical, "Cheque vencimiento")
                Dim sMsk = txtFechaVenci.Mask
                txtFechaVenci.Mask = ""
                txtFechaVenci.Text = ""
                txtFechaVenci.Mask = sMsk
                txtFechaVenci.Focus()
                lblAdvFecha.Visible = True
                Return False
            End If



        End If
            Return True
    End Function
    Private Sub guardarPago()
        Try
            Dim daop As New PagoDAO
            Dim pag As New Pago
            pag = llenarPago()
            daop.guardarPago(pag)
            'MsgBox("Pago registrado", MsgBoxStyle.Information, "Pago")
            lblPagoResult.Visible = True
            cargarVentaOT(venta.id)
            cargarPagos()
            limpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limpiarCampos()
        cbTiposP.SelectedValue = 1
        txtRecibo.Text = ""
        txtFechaEmision.Text = ""
        'txtMontoPago.Text = ""
        txtFechaEmision.Text = Date.Today
    End Sub
    Private Function llenarPago() As Pago
        Dim pag As New Pago
        If cbBancos.SelectedValue <> 0 Then
            pag.banco = cbBancos.SelectedValue
        End If
        pag.chequenro = txtCheque.Text
        Dim test As Date
        If Date.TryParseExact(txtFechaVenci.Text.ToString(), "dd/mm/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, test) Then
            '
            'pageMsgBox()
            pag.chequevenc = txtFechaVenci.Text.ToString()
            'pag.chequevenc = test
        Else
            'pag.chequevenc = Nothing
        End If

        pag.descuento = 0
        pag.dias = Date.Today
        pag.fecha = Date.Today
        pag.fechaI = Date.Today
        pag.fechaI = Date.Now
        If cbTiposP.SelectedValue = 2 Or cbTiposP.SelectedValue = 4 Then
            pag.moneda = "S"
        Else
            pag.moneda = "G"
        End If
        pag.monto = montoTotal
        pag.recargo = 0
        pag.recibo = txtRecibo.Text
        pag.saldo = venta.saldo - montoTotal
        pag.tpago = cbTiposP.SelectedValue
        pag.venta = venta.id

        Return pag
    End Function

    Private Sub txtMontoPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMontoPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = False
            txtRecibo.Focus()
            lblAvMonto.Visible = False
        End If
    End Sub

    Private Sub txtMontoPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoPago.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtMontoPago_TextChanged(sender As Object, e As EventArgs) Handles txtMontoPago.TextChanged
        Try
            If cbTiposP.SelectedValue = 2 Or cbTiposP.SelectedValue = 4 Then
                If sender.Text <> "" Then
                    ' Text1.text = Format(Text1.text, "Currency")
                    'Textbox1.Text = String.Format("{0:n2} $", CType(Textbox1.Text, Double))
                    Dim aux = txtMontoPago.Text.Replace("$", "")
                    montoTotal = CType(aux, Double)
                    'txtMontoPago.Text = String.Format("${0:n2}", CType(aux, Double))
                    'txtMontoPago.Select(sender.TextLength - 3, 0)
                    txtMontoPago.Text = String.Format("{0:n0}", CType(aux, Double))
                    txtMontoPago.Select(sender.TextLength, 0)

                Else
                    montoTotal = CType(0, Double)
                    txtMontoPago.Text = String.Format("{0:n0}", CType(0, Double))
                    txtMontoPago.Select(sender.TextLength, 0)
                End If
            Else
                If sender.Text <> "" Then
                    montoTotal = CType(txtMontoPago.Text, Double)
                    txtMontoPago.Text = FormatCurrency(sender.Text, 0)
                    txtMontoPago.Select(sender.TextLength, 0)
                Else
                    montoTotal = 0
                    txtMontoPago.Text = FormatCurrency(0, 0)
                    txtMontoPago.Select(sender.TextLength, 0)
                End If
            End If

        Catch ex As Exception
            If cbTiposP.SelectedValue = 2 Or cbTiposP.SelectedValue = 4 Then
                txtMontoPago.Text = String.Format("${0:n0}", CType(0, Double))
                txtMontoPago.Select(sender.TextLength - 1, 0)
            Else
                txtMontoPago.Text = FormatCurrency(0, 0)
                txtMontoPago.Select(sender.TextLength, 0)
            End If
        End Try
        'Try
        '    Dim str2 As String = txtDescuento.Text
        '    If rbtnDol.Checked Then
        '        If sender.Text <> "" Then
        '            ' Text1.text = Format(Text1.text, "Currency")
        '            'Textbox1.Text = String.Format("{0:n2} $", CType(Textbox1.Text, Double))
        '            Dim aux = txtDescuento.Text.Replace("$", "")
        '            'descuentoTotal = CType(aux, Double)
        '            txtDescuento.Text = String.Format("${0:n0}", CType(aux, Double))
        '            txtDescuento.Select(sender.TextLength, 0)
        '        Else
        '            'descuentoTotal = CType(0, Double)
        '            txtDescuento.Text = String.Format("${0:n0}", CType(0, Double))
        '            txtDescuento.Select(sender.TextLength, 0)
        '        End If
        '    Else
        '        If sender.Text <> "" Then
        '            'descuentoTotal = CType(txtDescuento.Text, Double)
        '            txtDescuento.Text = FormatCurrency(sender.Text, 0)
        '            txtDescuento.Select(sender.TextLength, 0)
        '        Else
        '            'descuentoTotal = 0
        '            txtDescuento.Text = FormatCurrency(0, 0)
        '            txtDescuento.Select(sender.TextLength, 0)
        '        End If
        '    End If
        'Catch ex As Exception
        '    If rbtnDol.Checked Then
        '        txtDescuento.Text = String.Format("${0:n0}", CType(0, Double))
        '        txtDescuento.Select(sender.TextLength - 1, 0)
        '    Else
        '        txtDescuento.Text = FormatCurrency(0, 0)
        '        txtDescuento.Select(sender.TextLength, 0)
        '    End If
        'End Try

    End Sub

    Private Sub txtMontoPago_Click(sender As Object, e As EventArgs) Handles txtMontoPago.Click
        If cbTiposP.SelectedValue = 2 Or cbTiposP.SelectedValue = 4 Then
            If sender.Text <> "" Then
                txtMontoPago.Select(sender.TextLength, 0)

            End If
        Else
            If sender.Text <> "" Then
                sender.Select(sender.TextLength, 0)

            End If
        End If
    End Sub

    Private Sub cbTiposP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTiposP.SelectedIndexChanged
        If cbTiposP.DataSource IsNot Nothing Then
            txtMontoPago.Text = FormatCurrency(venta.saldo, 0)
            If cbTiposP.SelectedValue = 3 Or cbTiposP.SelectedValue = 4 Or cbTiposP.SelectedValue = 5 Or cbTiposP.SelectedValue = 6 Or cbTiposP.SelectedValue = 7 Then
                'dpChequeVenc.Enabled = True
                cbBancos.Enabled = True
                txtCheque.Enabled = True
                txtFechaVenci.Enabled = True
                txtCheque.Text = ""
                cbBancos.SelectedValue = 0
                If cbTiposP.SelectedValue = 4 Then
                    lblCurrentCurr.Text = "$"
                Else
                    lblCurrentCurr.Text = ""

                End If
            Else
                'dpChequeVenc.Enabled = False
                cbBancos.Enabled = False
                txtCheque.Enabled = False
                txtFechaVenci.Enabled = False
                txtCheque.Text = ""
                cbBancos.SelectedValue = 0
                If cbTiposP.SelectedValue = 2 Then
                    lblCurrentCurr.Text = "$"
                Else
                    lblCurrentCurr.Text = ""

                End If
            End If
        End If

    End Sub

    Public Sub PersonalizarDAtagridView(ByVal dgv As DataGridView)
        With dgv

            .ForeColor = Color.FromArgb(245, 245, 245)
            .DefaultCellStyle.BackColor = Color.FromArgb(64, 69, 76)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.FromArgb(245, 245, 245)

            ' Inabilito EnableHeadersVisualStyles para que la personalizacion se haga efectiva

            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .ColumnHeadersHeight = 35
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 64, 23)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 101, 205)
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 101, 205)
            'Tipo de letra and color
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'Coloreo el background del DGV
            .BackgroundColor = Color.FromArgb(48, 65, 91)
        End With
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        Try
            If dgvPagos.SelectedRows.Count > 0 Then

                For Each row As DataGridViewRow In dgvPagos.SelectedRows

                    Dim id = row.Cells("ID").Value
                    Dim pagd As New PagoDetalle
                    pagd.id_pago = id
                    pagd.ShowDialog()
                    pagd.Dispose()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbBancos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBancos.SelectedIndexChanged
        'If cbBancos.Enabled Then
        '    txtCheque.Focus()
        'End If

    End Sub

    Private Sub txtCheque_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCheque.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtCheque.Text = "" Then
                txtCheque.Focus()
                lblAdvCheque.Visible = True

            Else
                txtFechaVenci.Focus()
                lblAdvCheque.Visible = False
            End If
            'txtMontoPago.Focus()
        End If
    End Sub

    Private Sub txtFechaEmision_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaEmision.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim faux As New Date
            Dim str = Date.TryParse(txtFechaEmision.Text, faux)
            If str = False Then
                MsgBox("Formato de fecha de emisión incorrecta. Debe ser DD/MM/AAAA", MsgBoxStyle.Critical, "Error en fecha")
                txtFechaEmision.Focus()
            Else
                txtRecibo.Focus()
            End If
        End If
    End Sub

    Private Sub txtRecibo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRecibo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar.PerformClick()
        End If
    End Sub

    Private Sub cbTiposP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTiposP.KeyPress

    End Sub

    Private Sub cbTiposP_KeyDown(sender As Object, e As KeyEventArgs) Handles cbTiposP.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If cbBancos.Enabled = True Then
                cbBancos.Focus()
            Else
                txtMontoPago.Focus()
            End If
        End If
    End Sub

    Private Sub cbBancos_KeyDown(sender As Object, e As KeyEventArgs) Handles cbBancos.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If cbBancos.SelectedIndex = 0 Then
                cbBancos.Focus()
                lblAdvBanco.Visible = True
            Else
                lblAdvBanco.Visible = False
                txtCheque.Focus()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvPagos.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvPagos.SelectedRows
                Dim co = row.Cells(0).Value
                Dim estado = row.Cells(6).Value
                If estado = "Anulado" Then
                    Exit Sub
                End If
                Dim anularF As New ComentarioAnularVenta
                Dim res = anularF.ShowDialog()
                If res = DialogResult.OK Then
                    Dim pagd As New PagoDAO
                    pagd.anularPago(co, anularF.anular)
                    MsgBox("Pago anulado correctamente", MsgBoxStyle.Information, "Anulación")
                    cargarVentaOT(venta.id)
                    cargarPagos()
                    limpiarCampos()
                    txtOt.Focus()
                End If
                anularF.Dispose()
            Next
        End If
    End Sub

    Private Sub btnDetalle_Click_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtFechaVenci_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtFechaVenci.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim test As Date
            If Date.TryParseExact(txtFechaVenci.Text.ToString(), "dd/mm/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, test) Then
                txtMontoPago.Focus()
                lblAdvFecha.Visible = False
            Else
                Dim sMsk = txtFechaVenci.Mask
                txtFechaVenci.Mask = ""
                txtFechaVenci.Text = ""
                txtFechaVenci.Mask = sMsk
                txtFechaVenci.Focus()
                lblAdvFecha.Visible = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rp As New InformeFacturasAnuladas
        rp.ShowDialog()
        rp.Dispose()

    End Sub
End Class