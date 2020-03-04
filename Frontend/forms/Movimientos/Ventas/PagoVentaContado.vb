Imports System.Globalization
Imports System.Web.UI.WebControls
Imports Backend

Public Class PagoVentaContado
    Public ventaId = 0
    Dim ventaMo As New Venta
    Public dolar = ""
    Dim cambio As New Cambio
    Dim montoTotal = 0
    Private Sub PagoVentaContado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        cargarTiposP()
        cargarBancos()
        cargarCambio()
        Dim daov As New VentaDAO

        cargarVentaOT(ventaId)
        'txtMontoPago.Text = 0
        'PersonalizarDAtagridView(Me.dgvPagos)
        'txtOt.Focus()
    End Sub

    Private Sub cargarVentaOT(ByVal id As String)
        Try
            Dim daoV As New VentaDAO
            Dim ventaaux = daoV.getVenta(id)

            If ventaaux.id <> 0 Then
                ventaMo = ventaaux
                'gbPago.Enabled = True
                'lblFechaVenta.Text = venta.fecha
                'lblNroOrden.Text = venta.id
                'lblFacturaNro.Text = venta.factura

                'lblFechaCaja.Text = Date.Now
                'txtObs.Text = venta.obs
                Dim tmp = CDbl(ventaMo.total)

                If ventaMo.moneda = "G" Then

                    'txtTotal.Text = FormatCurrency(tmp, 0)
                    'txtIva.Text = FormatCurrency(tmp / 11, 0)
                    'txtSaldo.Text = FormatCurrency(venta.saldo, 0)
                    'txtPago.Text = FormatCurrency(tmp - venta.saldo)
                    txtMontoPago.Text = FormatCurrency(ventaMo.total, 0)
                Else
                    'Dim totalS = tmp.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                    'Dim IvaS = CDbl(tmp / 11).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                    'Dim saldoS = venta.saldo.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                    Dim pagoS = (tmp / cambio.cambio).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                    'txtTotal.Text = totalS
                    'txtIva.Text = IvaS
                    'txtSaldo.Text = saldoS
                    'txtPago.Text = pagoS
                    txtMontoPago.Text = pagoS
                End If

                'If venta.envio = "N" Then
                '    lblFechaPrometida.Text = ""
                'Else
                '    lblFechaPrometida.Text = venta.fechaP
                'End If
                ' cargarCliente()
                'txtOt.Text = ""
                'cargarPagos()
                btnGuardar.Enabled = True
                txtFechaEmision.Text = Date.Today
            End If
        Catch ex As Exception
            MsgBox("asddsaqui " + ex.Message)
        End Try
    End Sub

    Private Sub cbTiposP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipodePago.SelectedIndexChanged
        If cbTipodePago.DataSource IsNot Nothing Then
            txtMontoPago.Text = FormatCurrency(ventaMo.total, 0)
            If cbTipodePago.SelectedValue = 3 Or cbTipodePago.SelectedValue = 4 Or cbTipodePago.SelectedValue = 5 Or cbTipodePago.SelectedValue = 6 Or cbTipodePago.SelectedValue = 7 Then
                dpChequeVenc.Enabled = True
                cbBancos.Enabled = True
                txtCheque.Enabled = True
                txtCheque.Text = ""
                cbBancos.SelectedValue = 0
                If cbTipodePago.SelectedValue = 4 Then
                    lblCurrentCurr.Text = "$"
                    txtMontoPago.Text = FormatCurrency(ventaMo.total, 0)
                Else
                    lblCurrentCurr.Text = ""
                    txtMontoPago.Text = FormatCurrency(ventaMo.total, 0)
                End If
            Else
                dpChequeVenc.Enabled = False
                cbBancos.Enabled = False
                txtCheque.Enabled = False
                txtCheque.Text = ""
                cbBancos.SelectedValue = 0
                If cbTipodePago.SelectedValue = 2 Then
                    lblCurrentCurr.Text = "$"
                Else
                    lblCurrentCurr.Text = ""

                End If
            End If
        End If

    End Sub

    Private Sub cargarTiposP()
        Try
            Dim tipoDao As New TipoPagoDAO


            If dolar = "G" Then
                Dim res = tipoDao.getTiposGS()
                cbTipodePago.DisplayMember = "Tipo"
                cbTipodePago.ValueMember = "ID"
                cbTipodePago.DataSource = res.Tables("tabla")
            Else
                Dim res = tipoDao.getTiposDOL()
                cbTipodePago.DisplayMember = "Tipo"
                cbTipodePago.ValueMember = "ID"
                cbTipodePago.DataSource = res.Tables("tabla")
            End If

        Catch ex As Exception
            MsgBox("adsa" + ex.Message)
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

    'Private Sub txtMontoPago_TextChanged(sender As Object, e As EventArgs) Handles txtMontoPago.TextChanged
    '    Try
    '        If cbTipodePago.SelectedValue = 2 Or cbTipodePago.SelectedValue = 4 Then
    '            If sender.Text <> "" Then
    '                ' Text1.text = Format(Text1.text, "Currency")
    '                'Textbox1.Text = String.Format("{0:n2} $", CType(Textbox1.Text, Double))
    '                Dim aux = txtMontoPago.Text.Replace("$", "")
    '                montoTotal = CType(aux, Double)
    '                'txtMontoPago.Text = String.Format("${0:n2}", CType(aux, Double))
    '                'txtMontoPago.Select(sender.TextLength - 3, 0)
    '                txtMontoPago.Text = String.Format("{0:n0}", CType(aux, Double))
    '                txtMontoPago.Select(sender.TextLength, 0)

    '            Else
    '                montoTotal = CType(0, Double)
    '                txtMontoPago.Text = String.Format("{0:n0}", CType(0, Double))
    '                txtMontoPago.Select(sender.TextLength, 0)
    '            End If
    '        Else
    '            If sender.Text <> "" Then
    '                montoTotal = CType(txtMontoPago.Text, Double)
    '                txtMontoPago.Text = FormatCurrency(sender.Text, 0)
    '                txtMontoPago.Select(sender.TextLength, 0)
    '            Else
    '                montoTotal = 0
    '                txtMontoPago.Text = FormatCurrency(0, 0)
    '                txtMontoPago.Select(sender.TextLength, 0)
    '            End If
    '        End If

    '    Catch ex As Exception
    '        If cbTipodePago.SelectedValue = 2 Or cbTipodePago.SelectedValue = 4 Then
    '            txtMontoPago.Text = String.Format("${0:n0}", CType(0, Double))
    '            txtMontoPago.Select(sender.TextLength - 1, 0)
    '        Else
    '            txtMontoPago.Text = FormatCurrency(0, 0)
    '            txtMontoPago.Select(sender.TextLength, 0)
    '        End If
    '    End Try
    'End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If validarPago() Then
            Dim result As Integer = MessageBox.Show("¿Guardar el pago?", "Guardar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                guardarPago()
                Me.DialogResult = DialogResult.OK
            End If
        End If

    End Sub

    Private Function validarPago() As Boolean
        If txtMontoPago.Text = "" Then
            MsgBox("Ingrese un monto para el pago", MsgBoxStyle.Critical, "Monto")
            txtMontoPago.Focus()
            Return False
        ElseIf CDbl(txtMontoPago.Text.Replace("$", "")) = 0 Then
            MsgBox("Ingrese un monto mayor a 0 para el pago", MsgBoxStyle.Critical, "Monto")
            txtMontoPago.Focus()
            Return False
        End If

        If txtRecibo.Text = "" Then
            'MsgBox("Ingrese un número de recibo", MsgBoxStyle.Critical, "Monto")
            'txtRecibo.Focus()
            'Return False
        End If
        If ventaMo.moneda = "G" Then
            If cbTipodePago.SelectedValue = 2 Or cbTipodePago.SelectedValue = 4 Then
                Dim montoGS = CDbl(txtMontoPago.Text.Replace("$", "")) * cambio.cambio
                If montoGS > ventaMo.total Then
                    MsgBox("El monto ingresado en dolares al cambio actual son " & montoGS & "GS. y supera al saldo de la venta", MsgBoxStyle.Critical, "Monto")
                    txtMontoPago.Text = ""
                    txtMontoPago.Focus()
                    Return False
                End If
            Else
                If CDbl(txtMontoPago.Text) > ventaMo.total Then
                    MsgBox("El monto supera al saldo de la venta", MsgBoxStyle.Critical, "Monto")
                    txtMontoPago.Focus()
                    Return False
                End If
            End If
        Else
            If cbTipodePago.SelectedValue = 1 Or cbTipodePago.SelectedValue = 3 Then
                Dim montoGS = CDbl(txtMontoPago.Text) / cambio.cambio
                If montoGS > ventaMo.total Then
                    MsgBox("El monto ingresado en guaranies al cambio actual son " & montoGS & " $ y supera al saldo de la venta", MsgBoxStyle.Critical, "Monto")
                    txtMontoPago.Text = ""
                    txtMontoPago.Focus()
                    Return False
                End If
            Else
                If CDbl(txtMontoPago.Text.Replace("$", "")) > ventaMo.total Then
                    MsgBox("El monto supera al saldo de la venta", MsgBoxStyle.Critical, "Monto")
                    txtMontoPago.Focus()
                    Return False
                End If
            End If
        End If
        ' Pago con cheques

        If cbTipodePago.SelectedValue = 3 Or cbTipodePago.SelectedValue = 4 Or cbTipodePago.SelectedValue = 7 Then
            If cbBancos.SelectedValue = 0 Then
                MsgBox("Seleccione un banco", MsgBoxStyle.Critical, "Banco no seleccionado")
                cbBancos.Focus()
                Return False
            ElseIf txtCheque.Text = "" Then
                MsgBox("Ingrese un número de cheque", MsgBoxStyle.Critical, "Cheque no ingresado")
                txtCheque.Focus()
                Return False
                'ElseIf dpChequeVenc.Value < Date.Today Then
                '    MsgBox("Fecha de vencimiento ya pasada", MsgBoxStyle.Critical, "Cheque vencimiento")
                '    txtCheque.Focus()
                '    Return False
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
            MsgBox("Pago registrado", MsgBoxStyle.Information, "Pago")
            'cargarVentaOT(venta.id)
            'cargarPagos()
            'limpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function llenarPago() As Pago
        Dim pag As New Pago
        If cbBancos.SelectedValue <> 0 Then
            pag.banco = cbBancos.SelectedValue
        End If
        pag.chequenro = txtCheque.Text
        pag.chequevenc = dpChequeVenc.Value
        pag.descuento = 0
        pag.dias = Date.Today
        pag.fecha = Date.Today
        pag.fechaI = Date.Today
        pag.fechaI = Date.Now
        If cbTipodePago.SelectedValue = 2 Or cbTipodePago.SelectedValue = 4 Then
            pag.moneda = "S"
        Else
            pag.moneda = "G"
        End If
        pag.monto = ventaMo.total
        pag.recargo = 0
        If txtRecibo.Text = "" Then
            pag.recibo = "Factura Contado"
        Else

            pag.recibo = txtRecibo.Text
        End If
        pag.saldo = 0
        pag.tpago = cbTipodePago.SelectedValue
        pag.venta = ventaMo.id

        Return pag
    End Function
End Class