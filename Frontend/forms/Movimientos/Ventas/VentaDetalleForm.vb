Imports System.Globalization
Imports Backend

Public Class VentaDetalleForm
    Public txtOt As String = ""
    Dim venta As New Venta
    Dim cliente As New Cliente
    Dim planos As New DataTable

    Private Sub VentaDetalleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarVentaOT()
    End Sub

    Private Sub cargarVentaOT()
        Try
            Dim daoV As New VentaDAO

            venta = daoV.getVenta(txtOt)
            lblFechaVenta.Text = venta.fecha
            txtNroFactura.Text = venta.factura
            txtObservacion.Text = venta.obs
            Dim tmp = CDbl(venta.total)
            If venta.moneda = "G" Then
                lblMonedaVenta.Text = "Guaraníes"
                txtTotal.Text = FormatCurrency(tmp, 3)
                txtIva.Text = FormatCurrency(tmp / 11, 3)
                txtSaldo.Text = FormatCurrency(venta.saldo, 3)
                txtDescuentoTotal.Text = FormatCurrency(venta.descuento, 3)
                txtRecargoTotal.Text = FormatCurrency(venta.recargo, 3)
            Else
                lblMonedaVenta.Text = "Dólares"
                Dim totalS = tmp.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                Dim IvaS = CDbl(tmp / 11).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                Dim saldoS = venta.saldo.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                Dim des = venta.descuento.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                Dim rec = venta.recargo.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                txtTotal.Text = totalS
                txtIva.Text = IvaS
                txtSaldo.Text = saldoS
                txtDescuentoTotal.Text = des
                txtRecargoTotal.Text = rec
            End If

            lblOTSeleccionada.Text = venta.id


            If venta.credito = "N" Then
                'rbtnCont.Checked = True
                lblTipoFactura.Text = "Contado"
            Else
                'rbtnCred.AutoCheck = True
                lblTipoFactura.Text = "Crédito"
            End If
            If venta.envio = "S" Then
                'chbEntrega1.Checked = True

                lblFechaEntrega.Text = venta.fechaP
                lblFechaEntrega.Text = venta.fechaP
                lblEnvio.Text = "Sí"
            Else
                'chbEntrega1.Checked = False

                lblFechaEntrega.Text = ""
                lblFechaEntrega.Text = ""
                lblEnvio.Text = "No"
            End If
            If venta.estado = "A" Then
                lblEstado.Text = "Anulado"
                txtObservacion.Text = txtObservacion.Text + ". Anulado por: " + venta.motivo
            ElseIf venta.estado = "P" Then
                lblEstado.Text = "Pendiente"
            ElseIf venta.estado = "D" Then
                lblEstado.Text = "Devuelto"
            Else
                lblEstado.Text = "Cobrado"
            End If


            Dim det = daoV.getDetalle(venta.id)
            dgvProductos.DataSource = det.Tables("tabla")
            cargarCliente()


            cargarPlanos()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarCliente()
        Try
            Dim daoC As New ClienteDAO
            cliente = daoC.getCliente(venta.cliente)
            lblClienteNombre.Text = Cliente.nombre
            lblClienteRuc.Text = cliente.ruc
            lblClienteTel.Text = cliente.telf
            asignarVendedor()
            asignarSucursal()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargarPlanos()
        Try
            Dim daov As New VentaDAO
            Dim res = daov.cargarPlanos(venta.id)
            planos = res.Tables("tabla")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub asignarVendedor()
        Try
            Dim daoV As New VendedorDAO
            Dim vendedor = daoV.getVendedor(cliente.vendedor)
            lblVendedor.Text = vendedor.nombre

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub

    Private Sub asignarSucursal()
        Try
            Dim daoV As New SucursalDAO
            Dim sucursal = daoV.getSucursal(cliente.sucursal)
            lblSucursal.Text = sucursal.nombre
            Dim daoD As New DepositoDAO
            Dim Deposito = daoD.getDeposito(sucursal.deposito)
            lblDeposito.Text = Deposito.nombre
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub

    Private Sub btnPlanos_Click(sender As Object, e As EventArgs) Handles btnPlanos.Click
        If planos.Rows.Count > 0 Then
            Dim fplano As New VerPlano
            fplano.planos = planos
            fplano.ShowDialog()
            fplano.Dispose()
        End If
    End Sub
End Class