Imports System.Globalization
Imports Backend

Public Class VentasForm
    'Variables utiles
    Dim listClientes As New DataTable
    Dim cliente As New Cliente
    Dim producto As New Producto
    Dim vendedor As New Vendedor
    Dim sucursal As New Sucursal
    Dim deposito As New Deposito
    Dim cambio As New Cambio
    Dim venta As New Venta ' almacena la venta que se ve en pantalla
    Dim tipoAct As String
    Dim templado = False
    Dim templado2 = False
    Dim listadoVentas As New List(Of Integer)
    Dim ventaActual = 0
    Dim stock = 0
    Dim columnasGrid
    Dim modificar = False
    Dim produccionDia As New Produccion
    Dim produccionVenta As Double = 0
    Dim porUnidad = 0
    Dim dolar = False
    Dim descuentoTotal = 0
    Dim recargoTotal = 0
    Dim planos As New DataTable
    ' Carga del formulario
    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.PerformAutoScale()
        'Sets the scaling mode
        Me.AutoScaleMode = AutoScaleMode.Dpi
        'Enables appearance settings

        lblFechaVenta.Text = Date.Today
        lblProducto.Text = ""
        lblSuperficie.Text = "Superficie (m" & Chr(178) & ")"
        rbtnNo.Checked = True
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        calcularTotal(0)
        rbtnCont.Enabled = False
        rbtnCred.Enabled = False
        columnasGrid = dgvProductos.Columns
        cargarVentas()
        actualizarProduccion()
        dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
        cargarCambio()
    End Sub

    Private Sub cargarCambio()
        Try
            Dim daoc As New CambioDAO
            cambio = daoc.getCambio()
            lblCambio.Text = FormatCurrency(cambio.cambio)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub activarNavegacion()
        btnAnterior.Enabled = True
        btnSgte.Enabled = True
        btnUlt.Enabled = True
        btnPrim.Enabled = True
    End Sub

    'carga de las ventas del cliente seleccionado
    Private Sub cargarVentas()
        Try
            Dim daoV As New VentaDAO
            listadoVentas = daoV.getVentas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub asignarVendedor()
        Try
            Dim daoV As New VendedorDAO
            vendedor = daoV.getVendedor(cliente.vendedor)
            lblVendedor.Text = vendedor.nombre

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub

    Private Sub asignarSucursal()
        Try
            Dim daoV As New SucursalDAO
            sucursal = daoV.getSucursal(cliente.sucursal)
            lblSucursal.Text = sucursal.nombre

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub

    Private Sub asignarDeposito()
        Try
            Dim daoV As New DepositoDAO
            deposito = daoV.getDeposito(sucursal.deposito)
            lblDeposito.Text = deposito.nombre

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub

    Private Sub asignarCliente()
        Try
            Dim daoV As New ClienteDAO
            cliente = daoV.getCliente(venta.cliente)
            lblClienteNombre.Text = cliente.nombre
            lblClienteRuc.Text = cliente.ruc
            lblClienteTel.Text = cliente.telf
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub
    Private Sub rbtnSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSi.CheckedChanged
        If rbtnSi.Checked Then
            'pnldDir.Enabled = True
            txtPlazo1.Enabled = True
            txtPlazo1.Focus()
        Else
            txtPlazo1.Enabled = False
            'txtFecha1.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtCodProd_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtCodProd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim daoP As New ProductoDAO
            Dim daoT As New TipoProdDAO
            producto = daoP.getProductoByCod(txtCodProd.Text)

            Dim tipoP = daoT.getTipo(producto.tipo)
            If templado2 = True And (tipoP.nombre = "perfiles" Or tipoP.nombre = "herrajes" Or tipoP.nombre = "planchas") Then
                MsgBox("Solo puede agregar templados", MsgBoxStyle.Critical, "Tipo producto")
                Exit Sub
            ElseIf porUnidad = 1 And tipoP.nombre = "templado" Then
                MsgBox("No puede agregar templados. Solo productos que se venden por cantidad", MsgBoxStyle.Critical, "Tipo producto")
                Exit Sub
            End If

            If producto.descripcion IsNot Nothing Then
                stock = daoP.getStockSucursal(producto.id, sucursal.id, deposito.id)
                txtStock.Text = stock
                lblProducto.Text = producto.descripcion
                txtCodProd.Text = producto.codigo.ToUpper
                activarMedidas(producto.tipo)
                asignarPrecio()
                txtDescuento.Text = 0
                txtRecargo.Text = 0
                If porUnidad = 1 Then
                    stockReal()
                End If
                txtCantidad.Text = 1
                txtCantidad.Focus()
                txtCantidad.SelectAll()
            Else
                Dim buscarP As New ProductoBusqueda
                buscarP.filtro = txtCodProd.Text
                Dim res = buscarP.ShowDialog()
                If res = DialogResult.OK Then
                    producto = buscarP.producto
                    tipoP = daoT.getTipo(producto.tipo)
                    stock = daoP.getStockSucursal(producto.id, sucursal.id, deposito.id)
                    txtStock.Text = stock

                    If templado2 = True And (tipoP.nombre = "perfiles" Or tipoP.nombre = "herrajes" Or tipoP.nombre = "planchas") Then
                        MsgBox("Solo puede agregar templados", MsgBoxStyle.Critical, "Tipo producto")
                        Exit Sub
                    ElseIf porUnidad = 1 And tipoP.nombre = "templado" Then
                        MsgBox("No puede agregar templados. Solo productos que se venden por cantidad", MsgBoxStyle.Critical, "Tipo producto")
                        Exit Sub
                    End If

                    lblProducto.Text = producto.descripcion
                    txtCodProd.Text = producto.codigo.ToUpper
                    activarMedidas(producto.tipo)
                    asignarPrecio()
                    txtDescuento.Text = "0"
                    txtRecargo.Text = "0"
                    txtCantidad.Text = 1
                    txtCantidad.Focus()
                    txtCantidad.SelectAll()
                    If porUnidad = 1 Then
                        stockReal()
                    End If
                End If
                buscarP.Dispose()
            End If
        End If
    End Sub

    Private Sub stockReal()
        Dim dv As DataView
        dv = New DataView(dgvProductos.DataSource, "ProdID= '" & producto.id & "' ", "ProdID", DataViewRowState.CurrentRows)
        Dim st = 0
        For Each row As DataGridViewRow In dgvProductos.Rows
            If row.Cells.Item("IDProdCol").Value = producto.id Then
                st += row.Cells.Item("CantidadCol").Value
            End If
        Next
        txtStock.Text = CInt(txtStock.Text) - st
    End Sub

    Private Sub activarMedidas(ByVal tipo As Integer)
        Dim daoT As New TipoProdDAO
        Dim tipoP = daoT.getTipo(tipo)
        tipoAct = tipoP.nombre
        If tipoP.nombre = "perfiles" Or tipoP.nombre = "herrajes" Or tipoP.nombre = "planchas" Then
            txtAlto.Enabled = False
            txtAncho.Enabled = False
            txtObra.Enabled = True
            txtCantidad.Enabled = True
            txtCantidad.Focus()
            txtDescuento.Enabled = True
            txtRecargo.Enabled = True
        Else
            txtAlto.Enabled = True
            txtAncho.Enabled = True
            txtObra.Enabled = True
            templado = True
            txtCantidad.Enabled = True
            txtDescuento.Enabled = True
            txtRecargo.Enabled = True
        End If
    End Sub

    Private Sub desactivarMedidas()
        pnlTipoP.Enabled = False
        txtFactuNro.Enabled = False
        txtObservacion.Enabled = False
        txtCodProd.Enabled = False
        txtAlto.Enabled = False
        txtAncho.Enabled = False
        txtObra.Enabled = False
        txtCantidad.Enabled = False
        txtCantidad.Focus()
        txtDescuento.Enabled = False
        txtRecargo.Enabled = False
        templado = False
        templado2 = False
        porUnidad = 0
    End Sub
    Private Sub asignarPrecio()
        If rbtnGS.Checked Then
            Select Case cliente.precioDefault
                Case "A"
                    txtPrecio.Text = FormatCurrency(producto.PrecioA)
                Case "B"
                    txtPrecio.Text = FormatCurrency(producto.PrecioB)
                Case "C"
                    txtPrecio.Text = FormatCurrency(producto.PrecioC)
                Case "D"
                    txtPrecio.Text = FormatCurrency(producto.PrecioD)
                Case Else
                    txtPrecio.Text = 0
            End Select
            txtCantidad.Focus()
        Else
            Select Case cliente.precioDefault
                Case "A"
                    txtPrecio.Text = FormatCurrency(producto.PrecioA / cambio.cambio)
                Case "B"
                    txtPrecio.Text = FormatCurrency(producto.PrecioB / cambio.cambio)
                Case "C"
                    txtPrecio.Text = FormatCurrency(producto.PrecioC / cambio.cambio)
                Case "D"
                    txtPrecio.Text = FormatCurrency(producto.PrecioD / cambio.cambio)
                Case Else
                    txtPrecio.Text = 0
            End Select
        End If

    End Sub



    Private Sub activarCampos()
        'txtNroOrden.Enabled = True
        txtFactuNro.Enabled = True
        'txtVendedor.Enabled = True
        txtObservacion.Enabled = True
    End Sub

    Private Sub limpiarCampos()
        lblOTSeleccionada.Text = ""
        limpiarProductos()
        limpiarTotales()
        limpiarClientes()
        venta = New Venta
        cliente = New Cliente
        planos = New DataTable
        txtFactuNro.Text = ""
        lblCantidadPlanos.Visible = False
        lblSucursal.Text = ""
        lblDeposito.Text = ""
        lblCantidadPlanos.Text = ""
        lblTitCantPlanos.Visible = False
        txtObservacion.Text = ""
        lblFechaEntrega.Text = ""
        txtOT.Text = ""
        txtPlazo1.Text = ""
        lblEstado.Text = ""
        lblTipoFactura.Text = ""
        lblFechaVenta.Text = Date.Today
        rbtnCred.Checked = True
        templado = False
        templado2 = False
        porUnidad = 0
        produccionVenta = 0
        rbtnGS.Checked = True
        rbtnNo.Checked = True
    End Sub

    Private Sub nuevaVenta()
        'If cliente.nombre = "" Then
        Dim buscarC As New ClienteBusqueda
        Dim res = buscarC.ShowDialog()
        If res = DialogResult.OK Then
            limpiarCampos()
            btnModificar.Enabled = False
            btnImprimir.Visible = False
            descuentoTotal = 0
            recargoTotal = 0
            txtRecargoTotal.Text = FormatCurrency(0)
            txtDescuentoTotal.Text = FormatCurrency(0)
            cliente = buscarC.cliente
            lblClienteNombre.Text = cliente.nombre
            lblClienteRuc.Text = cliente.ruc
            lblClienteTel.Text = cliente.telf
            lblDirEnvio.Text = cliente.dir
            asignarVendedor()
            asignarSucursal()
            asignarDeposito()
            activarCamposNuevaVenta()
            modificar = False
            pnlTipoP.Visible = True
            pnlTipoVentaMoneda.Visible = True
            btnAnular.Enabled = False
            dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
            btnAnular.Enabled = False
            btnModificar.Enabled = False
            btnAnular.Enabled = False
        End If
        buscarC.Dispose()

    End Sub
    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevaVenta()
    End Sub

    Private Sub limpiarClientes()
        lblClienteNombre.Text = ""
        lblClienteRuc.Text = ""
        lblClienteTel.Text = ""
        lblVendedor.Text = ""
        lblDirEnvio.Text = ""
    End Sub
    Private Sub limpiarTotales()
        txtTotal.Text = FormatCurrency(0, 0)
        txtIva.Text = FormatCurrency(0, 0)
        txtSaldo.Text = FormatCurrency(0, 0)
        txtDescuentoTotal.Text = FormatCurrency(0, 0)
        txtRecargoTotal.Text = FormatCurrency(0, 0)
    End Sub

    Private Sub limpiarTotalesDolares()
        txtTotal.Text = String.Format("${0:n2}", CType(0, Double))
        txtIva.Text = String.Format("${0:n2}", CType(0, Double))
        txtSaldo.Text = String.Format("${0:n2}", CType(0, Double))
        txtDescuentoTotal.Text = String.Format("${0:n2}", CType(0, Double))
        txtRecargoTotal.Text = String.Format("${0:n2}", CType(0, Double))
    End Sub
    Private Sub limpiarProductos()
        txtCodProd.Text = ""
        txtAlto.Text = ""
        txtAncho.Text = ""
        txtCantidad.Text = ""
        txtDescuento.Text = ""
        txtStock.Text = ""
        txtSup.Text = ""
        txtPrecio.Text = ""
        txtRecargo.Text = ""
        txtObra.Text = ""
        porUnidad = 0
        lblProducto.Text = ""
    End Sub

    Private Sub limpiarProductos2()
        'txtCodProd.Text = ""
        txtAlto.Text = ""
        txtAncho.Text = ""
        txtCantidad.Text = ""
        txtDescuento.Text = ""
        txtStock.Text = ""
        txtSup.Text = ""
        'txtPrecio.Text = ""
        txtRecargo.Text = ""
        'txtObra.Text = ""
        'lblProducto.Text = ""
    End Sub

    Private Sub activarCamposNuevaVenta()
        txtFactuNro.Enabled = True
        txtFactuNro.Focus()
        txtObservacion.Enabled = True
        pnlEnvio.Enabled = True
        txtCodProd.Enabled = True
        pnlTipoP.Enabled = True
        btnGuardar.Enabled = True
        rbtnCont.Enabled = True
        rbtnCred.Enabled = True
        btnEliminarProd.Enabled = True
        pnlEnvioNuevo.Visible = True
    End Sub

    Private Sub desactivarCamposNuevaVenta()
        txtFactuNro.Enabled = False
        'txtNroOrden.Enabled = True
        ' txtNroOrden.Focus()
        'txtVendedor.Enabled = True
        txtFactuNro.Focus()
        txtObservacion.Enabled = False
        pnlEnvio.Enabled = False
        txtCodProd.Enabled = False
        pnlTipoP.Enabled = False
        btnGuardar.Enabled = False
        rbtnCont.Enabled = False
        rbtnCred.Enabled = False
        btnEliminarProd.Enabled = False
    End Sub


    Private Sub txtAncho_TextChanged(sender As Object, e As EventArgs) Handles txtAncho.TextChanged, txtAlto.TextChanged
        Try
            If txtAlto.Text.Contains(".") Then
                txtAlto.Text = Replace(txtAlto.Text, ".", ",")
                If txtAlto.Focused Then
                    txtAlto.SelectionStart = txtAlto.Text.Length
                End If
            End If

            If txtAncho.Text.Contains(".") Then
                txtAncho.Text = Replace(txtAncho.Text, ".", ",")
                If txtAncho.Focused Then
                    txtAncho.SelectionStart = txtAncho.Text.Length
                End If
            End If
            If txtAncho.Text <> "" And txtAlto.Text <> "" Then
                Dim str As Double
                If Double.TryParse((txtAlto.Text * txtAncho.Text) / 1000000, str) Then

                    txtSup.Text = Math.Round(str, 2)
                End If
            Else
                txtSup.Text = ""
            End If
        Catch ex As Exception
            txtAlto.Text = ""
            txtAncho.Text = ""
            txtSup.Text = ""
        End Try
    End Sub

    Private Sub txtObra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObra.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If validarProducto() Then
                Dim row2 As DataTable = dgvProductos.DataSource
                Dim row As DataRow = row2.NewRow
                Dim detalle As New DetalleVenta
                detalle.id = 0
                detalle.ventaCod = 0
                detalle.producto = producto.id
                row("ID") = 0
                row("Venta") = 0
                row("ProdID") = producto.id
                row("Producto") = producto.descripcion
                row("Obra") = txtObra.Text
                row("Código") = producto.codigo
                row("P. Unitario") = CDbl(txtPrecio.Text)

                detalle.desc = producto.descripcion
                detalle.obra = txtObra.Text
                detalle.precioU = CDbl(txtPrecio.Text)
                detalle.prodCod = producto.codigo
                Dim strdescuento = ""
                Dim strrecargo = ""
                If rbtnDol.Checked Then
                    strdescuento = txtDescuento.Text.Replace("$", "")
                    strrecargo = txtRecargo.Text.Replace("$", "")
                Else
                    strdescuento = txtDescuento.Text
                    strrecargo = txtRecargo.Text
                End If



                If templado = True Then

                    detalle.cantidad = CInt(txtCantidad.Text)

                    detalle.ancho = CDbl(txtAncho.Text)
                    detalle.alto = CDbl(txtAlto.Text)
                    detalle.sup = Math.Round(CDbl((detalle.ancho * detalle.alto) / 1000000), 2)
                    produccionVenta += detalle.sup * detalle.cantidad
                    detalle.total = detalle.sup * detalle.precioU * detalle.cantidad

                    If CDbl(strdescuento) <> 0 Then
                        Dim des = CDbl(strdescuento) * detalle.cantidad * detalle.sup
                        detalle.total = detalle.total - des
                    ElseIf CDbl(strrecargo) <> 0 Then
                        Dim rec = CDbl(strrecargo) * detalle.cantidad * detalle.sup
                        detalle.total = detalle.total + rec
                    End If
                    row("Cantidad") = detalle.cantidad
                    row("Ancho") = CDbl(detalle.ancho)
                    row("Alto") = CDbl(detalle.alto)
                    row("Superficie") = CDbl(detalle.sup) * detalle.cantidad
                    row("Total") = detalle.total
                    row("Descuento") = CDbl(strdescuento) * detalle.sup * detalle.cantidad
                    row("Recargo") = CDbl(strrecargo) * detalle.sup * detalle.cantidad
                    descuentoTotal += CDbl(strdescuento) * detalle.sup * detalle.cantidad
                    recargoTotal += CDbl(strrecargo) * detalle.sup * detalle.cantidad
                Else
                    If CInt(txtCantidad.Text) > CInt(txtStock.Text) Then
                        MsgBox("Cantidad ingresada mayor al stock disponible", MsgBoxStyle.Critical, "Stock insuficiente")
                        txtCantidad.Focus()
                        Exit Sub
                    ElseIf txtCantidad.Text = 0 Then
                        MsgBox("Stock no disponible", MsgBoxStyle.Critical, "Stock insuficiente")
                        txtCodProd.Focus()
                        Exit Sub
                    End If
                    detalle.cantidad = CInt(txtCantidad.Text)
                    detalle.ancho = 0
                    detalle.alto = 0
                    detalle.sup = 0
                    produccionVenta = 0
                    detalle.total = detalle.cantidad * detalle.precioU
                    If CDbl(strdescuento) <> 0 Then
                        Dim des = CDbl(strdescuento) * detalle.cantidad * detalle.sup
                        detalle.total = detalle.total - des
                    ElseIf CDbl(strrecargo) <> 0 Then
                        Dim rec = CDbl(strrecargo) * detalle.cantidad * detalle.sup
                        detalle.total = detalle.total + rec
                    End If

                    row("Cantidad") = detalle.cantidad
                    row("Ancho") = 0
                    row("Alto") = 0
                    row("Superficie") = 0
                    row("Total") = detalle.total
                    row("Descuento") = CDbl(strdescuento) * detalle.cantidad
                    row("Recargo") = CDbl(strrecargo) * detalle.cantidad
                    descuentoTotal += CDbl(strdescuento) * detalle.cantidad
                    recargoTotal += CDbl(strrecargo) * detalle.cantidad
                    porUnidad = 1
                    templado = False
                    templado2 = False
                End If



                row2.Rows.Add(row)
                dgvProductos.DataSource = row2
                'dgvProductos.Rows.Add(row)
                dgvProductos.ClearSelection()
                calcularTotal(detalle.total)

                If templado = True Then
                    templado2 = True
                Else
                    txtStock.Text -= CInt(txtCantidad.Text)
                End If
                'producto = New Producto
                limpiarProductos2()
                txtCodProd.Focus()
                deshabilitarProducto()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            txtRecargo.Focus()
            txtRecargo.SelectAll()
        End If
    End Sub

    Private Sub deshabilitarProducto()
        txtCantidad.Enabled = False
        txtAlto.Enabled = False
        txtAncho.Enabled = False
        txtDescuento.Enabled = False
        txtRecargo.Enabled = False
        txtObra.Enabled = False
    End Sub
    Private Sub calcularTotal(ByVal monto As Double)

        If dolar = False Then
            If txtTotal.Text = "" Then
                txtTotal.Text = FormatCurrency(0, 0)
                txtIva.Text = FormatCurrency(0)
            Else
                Dim tmp = CDbl(txtTotal.Text + monto)

                txtTotal.Text = FormatCurrency(tmp)
                txtIva.Text = FormatCurrency(tmp / 11)
            End If

            txtDescuentoTotal.Text = FormatCurrency(descuentoTotal)
            txtRecargoTotal.Text = FormatCurrency(recargoTotal)
            If rbtnCred.Checked Then
                txtSaldo.Text = txtTotal.Text
            Else
                txtSaldo.Text = FormatCurrency(0)
            End If
        Else
            If txtTotal.Text = "" Then
                Dim aux = 0
                Dim aux2 = aux.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                txtTotal.Text = aux2
                txtTotal.Text = aux2
                txtIva.Text = aux2
            Else
                Dim tmp = CDbl(txtTotal.Text.Replace("$", "")) + monto
                Dim tpm2 = tmp.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                Dim ivatmp = CDbl(tmp / 11)
                Dim ivatmp2 = ivatmp.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                txtTotal.Text = String.Format("${0:n2}", CType(tmp, Double))
                txtIva.Text = String.Format("${0:n2}", CType(ivatmp, Double))
            End If

            txtDescuentoTotal.Text = String.Format("${0:n2}", CType(descuentoTotal, Double))
            txtRecargoTotal.Text = String.Format("${0:n2}", CType(recargoTotal, Double))

            If rbtnCred.Checked Then
                txtSaldo.Text = txtTotal.Text
            Else
                txtSaldo.Text = String.Format("${0:n2}", CType(0, Double))
            End If
        End If

        'If rbtnCont.Enabled = True Then
        '    txtPago.Text = FormatCurrency(txtTotal.Text)
        'End If
    End Sub

    ' Guardar Venta
    Private Sub guardarVenta()
        If validarVenta() Then
            If modificar = False Then
                Try
                    Dim nuevaVenta As New Venta

                    nuevaVenta.cliente = cliente.id
                    nuevaVenta.obs = txtObservacion.Text
                    nuevaVenta.vendedor = vendedor.id
                    ' nuevaVenta.operacion = txtNroOrden.Text
                    If dolar = False Then
                        nuevaVenta.total = CDbl(txtTotal.Text)
                        nuevaVenta.moneda = "G"
                    Else
                        nuevaVenta.total = CDbl(txtTotal.Text.Replace("$", "").Replace(".", ","))
                        nuevaVenta.moneda = "S"
                    End If


                    nuevaVenta.fecha = Date.Now

                    nuevaVenta.factura = txtFactuNro.Text
                    nuevaVenta.descuento = descuentoTotal
                    nuevaVenta.recargo = recargoTotal

                    nuevaVenta.m2 = produccionVenta
                    If rbtnCont.Checked = True Then
                        nuevaVenta.credito = "N"
                        nuevaVenta.saldo = 0
                        nuevaVenta.estado = "C"
                    Else
                        nuevaVenta.credito = "S"

                        nuevaVenta.saldo = nuevaVenta.total
                        nuevaVenta.estado = "P"
                    End If

                    If rbtnSi.Checked Then
                        nuevaVenta.plazo = txtPlazo1.Text
                        nuevaVenta.direEnv = lblDirEnvio.Text
                        nuevaVenta.fechaP = CDate(lblFechaEntrega.Text)
                        nuevaVenta.envio = "S"
                    Else
                        nuevaVenta.envio = "N"
                    End If
                    Dim daoVenta As New VentaDAO
                    Dim ventaGuardada = daoVenta.guardarVenta(nuevaVenta, dgvProductos.Rows, sucursal, deposito, produccionVenta)
                    If templado2 = True Then
                        If planos.Rows.Count > 0 Then
                            daoVenta.guardarPlanos(ventaGuardada, planos)
                        End If
                    End If

                    MsgBox("¡Venta Realizada!", MsgBoxStyle.Information, "Notificación Venta")
                    limpiarCampos()
                    activarCamposNuevaVenta()
                    If nuevaVenta.m2 > 0 Then
                        actualizarProduccion()
                    End If
                    modificar = False
                    btnAnterior.Enabled = True
                    btnSgte.Enabled = True
                    btnPrim.Enabled = True
                    btnUlt.Enabled = True

                    dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
                    cargarVentas()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Try


                    venta.factura = txtFactuNro.Text





                    Dim daoVenta As New VentaDAO
                    daoVenta.actualizarVenta(venta, dgvProductos.Rows)


                    MsgBox("¡Venta Actualizada!", MsgBoxStyle.Information, "Notificación Venta")
                    desactivarCamposModificar()
                    limpiarCampos()
                    cargarVenta()
                    activarNavegacion()

                    'Dim result As Integer = MessageBox.Show("¡Venta realizada! ¿Imprimir factura?", "Atención", MessageBoxButtons.YesNo)

                    'If result = DialogResult.Yes Then

                    '    If result = DialogResult.OK Then
                    '        imprimirfact(ventaActual)
                    '    End If
                    'Else
                    '    Me.DialogResult = DialogResult.None

                    'End If
                    'limpiarCamposProducto()
                    'limpiarVenta()
                    activarNavegacion()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As Integer = MessageBox.Show("¿Guardar venta?", "Guardar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            guardarVenta()
        End If
    End Sub

    Private Sub actualizarProduccion()
        Try
            Dim daoP As New ProduccionDAO
            produccionDia = daoP.getProduccionDia()
            lblProduccion.Text = produccionDia.total & " m" & Chr(178) & ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '---------------------------------------------'---------------------------------------------'---------------------------------------------
    ' Validaciones
    'Validar Venta
    Private Function validarVenta() As Boolean
        If cliente.nombre = "" Then
            MsgBox("Seleccione un cliente", MsgBoxStyle.Critical, "Error de datos")
            Return False

            'ElseIf txtFactuNro.Text = "" Then
            '    MsgBox("Ingrese un número de factura para la venta", MsgBoxStyle.Critical, "Error de datos")
            '    txtFactuNro.Focus()
            '    Return False
        ElseIf rbtnCont.Checked = False And rbtnCred.Checked = False Then
            MsgBox("Seleccione un tipo de pago", MsgBoxStyle.Critical, "Error de datos")
            pnlTipoP.Focus()
            Return False
        ElseIf dgvProductos.Rows.Count = 0 Then
            MsgBox("Debe agregar al menos un producto para la venta", MsgBoxStyle.Critical, "Error de datos")
            btnSubirPlano.Focus()
            Return False
            'ElseIf templado2 = True And pbPlano.Image Is Nothing Then
            '    MsgBox("Debe agregar un plano para la venta", MsgBoxStyle.Critical, "Error de datos")
            '    txtCodProd.Focus()
            '    Return False
        ElseIf rbtnSi.Checked Then
            If txtPlazo1.Text = "" Then
                MsgBox("Ingrese la cantidad de días hábiles para la entrega", MsgBoxStyle.Critical, "Error de datos")
                txtPlazo1.Focus()
            End If
        End If
        Return True
    End Function

    Private Function validarProducto() As Boolean
        If templado = True Then
            If txtAlto.Text = "" Then
                MsgBox("Ingrese el alto del templado", MsgBoxStyle.Critical, "Error de datos")
                txtAlto.Focus()
                Return False
            ElseIf txtAlto.Text = 0 Then
                MsgBox("Ingrese el alto del templado", MsgBoxStyle.Critical, "Error de datos")
                txtAlto.Focus()
                Return False
            ElseIf txtAncho.Text = "" Then
                MsgBox("Ingrese el ancho del templado", MsgBoxStyle.Critical, "Error de datos")
                txtAncho.Focus()
                Return False
            ElseIf txtAncho.Text = 0 Then
                MsgBox("Ingrese el ancho del templado", MsgBoxStyle.Critical, "Error de datos")
                txtAncho.Focus()
                Return False
            End If
        End If
        If txtObra.Text = "" Then
            MsgBox("Ingrese la obra", MsgBoxStyle.Critical, "Error de datos")
            txtObra.Focus()
            Return False
        ElseIf txtCantidad.Text = "" Then
            MsgBox("Ingrese un cantidad ", MsgBoxStyle.Critical, "Error de datos")
            txtCantidad.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub rbtnCont_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCont.CheckedChanged
        If dolar = False Then
            If rbtnCont.Checked Then

                lblTipoFactura.Text = "Contado"
                txtObservacion.Focus()
                txtSaldo.Text = FormatCurrency(0)
            Else

                lblTipoFactura.Text = "Crédito"
                txtSaldo.Text = FormatCurrency(txtTotal.Text)

                txtObservacion.Focus()

            End If
        Else
            If rbtnCont.Checked Then

                txtSaldo.Text = String.Format("${0:n2}", CType(0, Double))
                lblTipoFactura.Text = "Contado"
                txtObservacion.Focus()
            Else
                Dim aux = txtTotal.Text.Replace("$", "")
                Dim montoTotal = CType(aux, Double)
                txtSaldo.Text = String.Format("${0:n2}", CType(aux, Double))
                lblTipoFactura.Text = "Crédito"
                txtObservacion.Focus()
            End If
        End If

    End Sub




    '---------------------------------------------'---------------------------------------------'---------------------------------------------
    ' Navegacion entre ventas
    Private Sub desactivarCampos()
        txtFactuNro.Enabled = False
        txtObservacion.Enabled = False
        txtCodProd.Enabled = False
        txtCantidad.Enabled = False
        txtAncho.Enabled = False
        txtAlto.Enabled = False
        txtObra.Enabled = False
        txtDescuento.Enabled = False
        txtRecargo.Enabled = False
        pnlTipoVentaMoneda.Visible = False
        limpiarProductos()
        pnlEnvioNuevo.Visible = False
    End Sub
    'Venta anterior
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If listadoVentas.Count > 0 Then
            ventaActual -= 1
            If ventaActual = -1 Then
                ventaActual = listadoVentas.Count - 1

            End If
            cargarVenta()
            desactivarCampos()
            btnModificar.Enabled = True
            btnImprimir.Visible = True
            btnAnular.Enabled = True
        End If

    End Sub
    ' Sgte venta
    Private Sub btnSgte_Click(sender As Object, e As EventArgs) Handles btnSgte.Click
        If listadoVentas.Count > 0 Then
            ventaActual += 1
            If ventaActual = listadoVentas.Count Then
                ventaActual = 0
            End If
            cargarVenta()
            desactivarCampos()
            btnModificar.Enabled = True
            btnImprimir.Visible = True
            btnAnular.Enabled = True
        End If
    End Sub
    'Primera Venta
    Private Sub btnPrim_Click(sender As Object, e As EventArgs) Handles btnPrim.Click
        If listadoVentas.Count > 0 Then
            ventaActual = 0
            cargarVenta()
            desactivarCampos()
            btnModificar.Enabled = True
            btnImprimir.Visible = True
            btnAnular.Enabled = True
        End If

    End Sub
    'Ultima venta
    Private Sub btnUlt_Click(sender As Object, e As EventArgs) Handles btnUlt.Click
        If listadoVentas.Count > 0 Then
            ventaActual = listadoVentas.Count - 1
            cargarVenta()
            desactivarCampos()
            btnModificar.Enabled = True
            btnImprimir.Visible = True
            btnAnular.Enabled = True
        End If
    End Sub
    ' carga la venta
    Private Sub cargarVenta()
        Try
            Dim daoV As New VentaDAO
            venta = daoV.getVenta(listadoVentas.Item(ventaActual))
            lblFechaVenta.Text = venta.fecha
            txtFactuNro.Text = venta.factura
            txtObservacion.Text = venta.obs
            Dim tmp = CDbl(venta.total)
            If venta.moneda = "G" Then
                txtTotal.Text = FormatCurrency(tmp, 3)
                txtIva.Text = FormatCurrency(tmp / 11, 3)
                txtSaldo.Text = FormatCurrency(venta.saldo, 3)
            Else
                Dim totalS = tmp.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                Dim IvaS = CDbl(tmp / 11).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                Dim saldoS = venta.saldo.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))

                txtTotal.Text = totalS
                txtIva.Text = IvaS
                txtSaldo.Text = saldoS
            End If

            lblOTSeleccionada.Text = venta.id
            lblSupTotalOT.Text = venta.m2
            Try
                cargarPlanos()
            Catch ex As Exception

            End Try



            If venta.envio = "S" Then
                'chbEntrega1.Checked = True
                txtPlazo1.Enabled = False
                'txtFecha1.Enabled = False
                txtPlazo1.Text = venta.plazo
                lblFechaEntrega.Text = venta.fechaP
            Else
                'chbEntrega1.Checked = False
                txtPlazo1.Text = ""
                lblFechaEntrega.Text = ""
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
            If venta.credito = "S" Then
                lblTipoFactura.Text = "Crédito"
            Else
                lblTipoFactura.Text = "Contado"
            End If

            If venta.moneda = "G" Then
                lblMonedaVenta.Text = "Guaraníes"
            Else
                lblMonedaVenta.Text = "Dólares"
            End If
            Dim det = daoV.getDetalle(venta.id)
            dgvProductos.DataSource = det.Tables("tabla")

            pnlTipoP.Visible = False
            cargarCliente()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargarCliente()
        Try
            Dim daoC As New ClienteDAO
            cliente = daoC.getCliente(venta.cliente)
            lblClienteNombre.Text = cliente.nombre
            lblClienteRuc.Text = cliente.ruc
            lblClienteTel.Text = cliente.telf
            asignarVendedor()
            asignarSucursal()
            asignarDeposito()
        Catch ex As Exception

        End Try
    End Sub
    ' Actualizar/Modificar Venta
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEtiquetas.Click
        If venta.id = 0 Then
            MsgBox("Seleccione una ot antes de imprimir etiquetas", MsgBoxStyle.Information, "Notificacion")
        Else
            Dim impEt As New TicketsForm
            impEt.idVenta = venta.id
            impEt.cliente = cliente.nombre
            impEt.obs = venta.obs
            impEt.ShowDialog()
        End If
    End Sub

    Private Sub activarCamposModificar()
        'dpFecha.Visible = True
        'txtFecha.Visible = False
        'dpFecha.Value = venta.fecha
        'dpFecha.Enabled = True
        txtFactuNro.Enabled = True
        txtObservacion.Enabled = True
        txtCodProd.Enabled = True
        btnGuardar.Enabled = True

        If venta.direEnv = "S" Then
            'pnlEntrega1.Enabled = True
            'chbEntrega1.Enabled = True
        End If
    End Sub

    Private Sub desactivarCamposModificar()
        'dpFecha.Visible = False
        'txtFecha.Visible = True
        'dpFecha.Value = venta.fecha
        'dpFecha.Enabled = False
        txtFactuNro.Enabled = False
        txtObservacion.Enabled = False
        txtCodProd.Enabled = False
        btnGuardar.Enabled = False


        If venta.direEnv = "S" Then
            pnlEntrega1.Enabled = False
            'chbEntrega1.Enabled = True
        End If
    End Sub
    '---------------------------------------------'---------------------------------------------'---------------------------------------------
    ' Formatos de numeros
    Private Sub precioClick(sender As Object, e As EventArgs)
        If sender.Text <> "" Then
            sender.Select(sender.TextLength - 2, 0)
        End If
    End Sub

    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtPlazo1.KeyPress

        soloNumeros(e)
    End Sub





    Private Sub txtPlazo1_TextChanged(sender As Object, e As EventArgs) Handles txtPlazo1.TextChanged
        If txtPlazo1.Text <> "" Then
            Dim tod = Date.Today
            Dim dateP = tod.AddDays(txtPlazo1.Text)
            If dateP.DayOfWeek = DayOfWeek.Sunday Then
                dateP = tod.AddDays(1)
            End If
            lblFechaEnvio.Text = dateP.ToShortDateString

        Else
            lblFechaEnvio.Text = Date.Today
        End If

    End Sub

    'Private Sub precioFormat(sender As Object, e As EventArgs)
    '    Try
    '        If modificar = False Then
    '            If sender.Text <> "" Then
    '                sender.Text = FormatCurrency(sender.Text, 1)
    '                sender.Select(sender.TextLength - 2, 0)
    '                If txtPago.Text <> "" And txtTotal.Text <> "" Then
    '                    txtSaldo.Text = FormatCurrency(txtTotal.Text - txtPago.Text, 1)
    '                End If
    '            Else
    '                sender.Text = FormatCurrency(0, 1)
    '                sender.Select(sender.TextLength - 2, 0)
    '                If txtTotal.Text <> "" And txtPago.Text <> "" Then
    '                    txtSaldo.Text = FormatCurrency(txtTotal.Text - txtPago.Text, 1)
    '                End If
    '            End If
    '        Else
    '            If sender.Text <> "" Then
    '                sender.Text = FormatCurrency(sender.Text, 1)
    '                sender.Select(sender.TextLength - 2, 0)
    '                If txtPago.Text <> "" And txtSaldo.Text <> "" Then
    '                    txtSaldo.Text = FormatCurrency(venta.saldo - txtPago.Text, 1)
    '                End If
    '            Else
    '                sender.Text = FormatCurrency(0, 1)
    '                sender.Select(sender.TextLength - 2, 0)
    '                If txtTotal.Text <> "" And txtPago.Text <> "" Then
    '                    txtSaldo.Text = FormatCurrency(venta.saldo - txtPago.Text, 1)
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        If dgvProductos.SelectedRows.Count > 0 Then

            For Each row As DataGridViewRow In dgvProductos.SelectedRows

                If rbtnGS.Checked Then


                    Dim monto = row.Cells("TotalCol").Value
                    Dim tmp = CDbl(txtTotal.Text - monto)

                    Dim strdescuento = CDbl(row.Cells("Descuento").Value)
                    Dim strrecargo = CDbl(row.Cells("Recargo").Value)

                    descuentoTotal -= strdescuento
                    recargoTotal -= strrecargo

                    txtTotal.Text = FormatCurrency(tmp)
                    txtIva.Text = FormatCurrency(tmp / 11)
                    txtDescuentoTotal.Text = FormatCurrency(descuentoTotal)
                    txtRecargoTotal.Text = FormatCurrency(recargoTotal)

                    If rbtnCont.Checked Then
                        txtSaldo.Text = FormatCurrency(0)
                    Else
                        txtSaldo.Text = FormatCurrency(tmp)
                    End If
                    Dim produc = row.Cells("IDProdCol").Value

                    If produc = producto.id And porUnidad = 1 Then
                        txtStock.Text = CInt(txtStock.Text) + row.Cells("CantidadCol").Value
                    End If
                Else
                    Dim strdescuento = CDbl(row.Cells("Descuento").Value)
                    Dim strrecargo = CDbl(row.Cells("Recargo").Value)

                    descuentoTotal -= strdescuento
                    recargoTotal -= strrecargo

                    Dim monto = row.Cells("TotalCol").Value
                    Dim totalAux = txtTotal.Text.Replace("$", "")
                    Dim tmp = CDbl(totalAux - monto)

                    txtTotal.Text = String.Format("${0:n2}", CType(tmp, Double))
                    Dim tmpiva = CDbl(tmp / 11)
                    txtIva.Text = String.Format("${0:n2}", CType(tmpiva, Double))
                    txtDescuentoTotal.Text = String.Format("${0:n2}", CType(descuentoTotal, Double))
                    txtRecargoTotal.Text = String.Format("${0:n2}", CType(recargoTotal, Double))


                    If rbtnCont.Checked Then
                        txtSaldo.Text = String.Format("${0:n2}", CType(0, Double))
                    Else
                        txtSaldo.Text = String.Format("${0:n2}", CType(tmp, Double))
                    End If

                    Dim produc = row.Cells("IDProdCol").Value

                    If produc = producto.id And porUnidad = 1 Then
                        txtStock.Text = CInt(txtStock.Text) + row.Cells("CantidadCol").Value
                    End If
                End If

                dgvProductos.Rows.Remove(row)
            Next

            If dgvProductos.Rows.Count = 0 Then
                porUnidad = 0
                templado = False
                templado2 = False
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'If venta.factura <> "" Then
        '    Dim result As Integer = MessageBox.Show("¿Imprimir factura?", "Factura", MessageBoxButtons.YesNo)
        '    If result = DialogResult.Yes Then
        '        If venta.estadoFactura = "S" Then
        '            MsgBox("Factura ya impresa", MsgBoxStyle.Critical, "Factura")
        '        Else
        '            imprimirfact()
        '        End If
        '    End If
        'Else
        Dim nroFactForm As New NroFactura
        nroFactForm.venta = venta
        Dim res = nroFactForm.ShowDialog
        If res = DialogResult.OK Then
            venta.factura = nroFactForm.venta.factura
            imprimirfact()
        End If
        'End If
    End Sub

    Public Sub imprimirfact()
        Try
            Dim facturaImprimir As New ImpresionFactura
            Dim daoCliente As New ClienteDAO

            'Dim currentVenta = daoVenta.obtenerVentaDatos(venta.id)
            Dim currentCliente = daoCliente.getCliente(venta.cliente)
            facturaImprimir.SetParameterValue("codigo", venta.id)
            facturaImprimir.SetParameterValue("nroFactura", venta.factura)
            facturaImprimir.SetParameterValue("cliente", currentCliente.nombre)
            facturaImprimir.SetParameterValue("ruc", currentCliente.ruc)
            facturaImprimir.SetParameterValue("Fecha", Date.Today)
            Dim convert As New NumLetra

            If venta.credito = "S" Then
                facturaImprimir.SetParameterValue("contado", "X")
                facturaImprimir.SetParameterValue("credito", "")
            Else
                facturaImprimir.SetParameterValue("contado", "")
                facturaImprimir.SetParameterValue("credito", "X")
            End If
            facturaImprimir.SetParameterValue("totalGuaranies", convert.EnLetras(venta.total))
            ''facturaImprimir.SetParameterValue("totalVenta", currentVenta.total)
            ''facturaImprimir.SetParameterValue("liquidacionIva10", currentVenta.total * 0.090909)
            '= facturaImprimir.PrintOptions.PrinterName = "EPSONLX-350" ''PONER NOMBRE DE IMPRESORA
            'facturaImprimir.PrintOptions.PrinterName = "Win2PDF"
            facturaImprimir.PrintOptions.PrinterName = "ELX350"
            'facturaImprimir.PrintOptions.PaperSource = "papelp2"
            Dim daoV As New VentaDAO
            daoV.actualizarVentaFactura(venta)
            facturaImprimir.PrintToPrinter(1, False, 0, 0)
            MsgBox("¡Factura impresa!", MsgBoxStyle.Information, "Notificación")
            txtOT.Text = venta.id
            cargarVentas()
            cargarVentaOT()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtOT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOT.KeyDown

        If e.KeyCode = Keys.Enter Then
            pnlEnvioNuevo.Visible = False
            pnlTipoVentaMoneda.Visible = False
            e.SuppressKeyPress = True
            Dim daoP As New VentaDAO
            Dim ventaAux = daoP.getVenta(txtOT.Text)
            If txtOT.Text <> "" Then
                lblTipoFactura.Visible = True
                txtFactuNro.Enabled = False
                txtObservacion.Enabled = False
                txtCodProd.Enabled = False
                txtCantidad.Enabled = False
                txtAncho.Enabled = False
                txtAlto.Enabled = False
                txtObra.Enabled = False
                txtDescuento.Enabled = False
                txtRecargo.Enabled = False

                cargarVentaOT()
                btnAnular.Enabled = True
                btnModificar.Enabled = True
                btnImprimir.Visible = True
            Else
                btnNuevo.PerformClick()
            End If
        End If
    End Sub

    Private Sub cargarVentaOT()
        Try
            Dim daoV As New VentaDAO

            If listadoVentas.Count = 0 Then
                cargarVentasOT()

            End If
            ventaActual = (listadoVentas.FindIndex(Function(value As Integer)
                                                       Return value = txtOT.Text
                                                   End Function))
            If ventaActual <> -1 Then
                venta = daoV.getVenta(listadoVentas.Item(ventaActual))
                lblFechaVenta.Text = venta.fecha
                txtFactuNro.Text = venta.factura
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
                pnlTipoP.Visible = False
                lblSupTotalOT.Text = venta.m2

                If venta.credito = "N" Then
                    'rbtnCont.Checked = True
                    lblTipoFactura.Text = "Contado"
                Else
                    'rbtnCred.AutoCheck = True
                    lblTipoFactura.Text = "Crédito"
                End If
                If venta.envio = "S" Then
                    'chbEntrega1.Checked = True
                    txtPlazo1.Enabled = False
                    'txtFecha1.Enabled = False
                    txtPlazo1.Text = venta.plazo
                    lblFechaEntrega.Text = venta.fechaP
                    lblFechaEntrega.Text = venta.fechaP
                    lblEnvio.Text = "Sí"
                Else
                    'chbEntrega1.Checked = False
                    txtPlazo1.Text = ""
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

                txtOT.Text = ""
                cargarPlanos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Private Sub cargarVentasOT()
        Try
            Dim daoV As New VentaDAO
            listadoVentas = daoV.listadoVentas(cliente.id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDescuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtRecargo.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            If txtAlto.Enabled Then
                txtAlto.Focus()
                txtAlto.SelectAll()
            Else
                txtCantidad.Focus()
                txtCantidad.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtRecargo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRecargo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtObra.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtDescuento.Focus()
            txtDescuento.SelectAll()
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtAncho.Enabled Then
                txtAncho.Focus()
            Else
                txtDescuento.Focus()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            txtCodProd.Focus()
            txtCodProd.SelectAll()
        End If
    End Sub

    Private Sub txtAncho_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAncho.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtAlto.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtCantidad.Focus()
            txtCantidad.SelectAll()
        End If
    End Sub

    Private Sub txtAlto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAlto.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtDescuento.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtAncho.Focus()
            txtAncho.SelectAll()
        End If
    End Sub

    Private Sub txtFactuNro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFactuNro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cliente.nombre = "" Then
                nuevaVenta()
            End If
            e.SuppressKeyPress = True
            txtObservacion.Focus()
        End If
    End Sub

    Private Sub txtObservacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObservacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCodProd.Focus()
        End If
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        Try
            Dim str2 As String = txtDescuento.Text
            If rbtnDol.Checked Then
                If sender.Text <> "" Then
                    ' Text1.text = Format(Text1.text, "Currency")
                    'Textbox1.Text = String.Format("{0:n2} $", CType(Textbox1.Text, Double))
                    Dim aux = txtDescuento.Text.Replace("$", "")
                    'descuentoTotal = CType(aux, Double)
                    txtDescuento.Text = String.Format("${0:n2}", CType(aux, Double))
                    txtDescuento.Select(sender.TextLength - 3, 0)
                Else
                    'descuentoTotal = CType(0, Double)
                    txtDescuento.Text = String.Format("${0:n2}", CType(0, Double))
                    txtDescuento.Select(sender.TextLength - 3, 0)
                End If
            Else
                If sender.Text <> "" Then
                    'descuentoTotal = CType(txtDescuento.Text, Double)
                    txtDescuento.Text = FormatCurrency(sender.Text, 1)
                    txtDescuento.Select(sender.TextLength - 2, 0)
                Else
                    'descuentoTotal = 0
                    txtDescuento.Text = FormatCurrency(0, 1)
                    txtDescuento.Select(sender.TextLength - 2, 0)
                End If
            End If
        Catch ex As Exception
            If rbtnDol.Checked Then
                txtDescuento.Text = String.Format("${0:n2}", CType(0, Double))
                txtDescuento.Select(sender.TextLength - 3, 0)
            Else
                txtDescuento.Text = FormatCurrency(0, 1)
                txtDescuento.Select(sender.TextLength - 2, 0)
            End If
        End Try


    End Sub

    Private Sub txtRecargo_TextChanged(sender As Object, e As EventArgs) Handles txtRecargo.TextChanged
        Try
            Dim str2 As String = txtRecargo.Text
            If rbtnDol.Checked Then
                If sender.Text <> "" Then
                    ' Text1.text = Format(Text1.text, "Currency")
                    'Textbox1.Text = String.Format("{0:n2} $", CType(Textbox1.Text, Double))
                    Dim aux = txtRecargo.Text.Replace("$", "")
                    'recargoTotal = CType(aux, Double)
                    txtRecargo.Text = String.Format("${0:n2}", CType(aux, Double))
                    txtRecargo.Select(sender.TextLength - 3, 0)
                Else
                    'recargoTotal = CType(0, Double)
                    txtRecargo.Text = String.Format("${0:n2}", CType(0, Double))
                    txtRecargo.Select(sender.TextLength - 3, 0)
                End If
            Else
                If sender.Text <> "" Then
                    'recargoTotal = CType(txtRecargo.Text, Double)
                    txtRecargo.Text = FormatCurrency(sender.Text, 1)
                    txtRecargo.Select(sender.TextLength - 2, 0)
                Else
                    'recargoTotal = 0
                    txtRecargo.Text = FormatCurrency(0, 1)
                    txtRecargo.Select(sender.TextLength - 2, 0)
                End If
            End If
        Catch ex As Exception
            If rbtnDol.Checked Then
                txtRecargo.Text = String.Format("${0:n2}", CType(0, Double))
                txtRecargo.Select(sender.TextLength - 3, 0)
            Else
                txtRecargo.Text = FormatCurrency(0, 1)
                txtRecargo.Select(sender.TextLength - 2, 0)
            End If
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSubirPlano.Click
        If templado2 = True Then
            '    'Dim file As New OpenFileDialog()
            '    'file.Filter = "Archivo JPG|*.jpg"
            '    'If file.ShowDialog() = DialogResult.OK Then
            '    '    pbPlano.Image = Image.FromFile(file.FileName)
            '    '    pbPlano.SizeMode = PictureBoxSizeMode.Zoom
            '    'End If
            '    'file.Dispose()
            Dim agregarP As New AgregarPlanos
            agregarP.ShowDialog()
            planos = agregarP.planos
            agregarP.Dispose()
            If planos.Rows.Count > 0 Then
                lblCantidadPlanos.Visible = True
                lblCantidadPlanos.Text = planos.Rows.Count
                lblTitCantPlanos.Visible = True
            End If
        Else
            If venta.m2 > 0 Then
                Dim agregarP As New AgregarPlanos
                agregarP.ShowDialog()
                Dim planos2 = agregarP.planos
                agregarP.Dispose()
                If planos2.Rows.Count > 0 Then
                    Dim result As Integer = MessageBox.Show("¿Guardar planos de venta?", "Guardar", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        Dim daoventa As New VentaDAO
                        daoventa.guardarPlanos(venta.id, planos2)
                        cargarPlanos()
                    End If
                End If
            End If
        End If
    End Sub

    'Private Sub pbPlano_Click(sender As Object, e As EventArgs) Handles pbPlano.Click
    '    Try
    '        If venta.plano <> "" Then
    '            Dim planoForm As New VerPlano
    '            planoForm.ruta = venta.plano
    '            planoForm.ShowDialog()
    '            planoForm.Dispose()
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim anularF As New ComentarioAnularVenta
        Dim res = anularF.ShowDialog()
        If res = DialogResult.OK Then
            Dim result As Integer = MessageBox.Show("¿Anular la OT seleccionada?", "Eliminar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim daov As New VentaDAO
                daov.anularVenta(venta, anularF.anular)
                MsgBox("OT anulada", MsgBoxStyle.Information, "Anulación")
                limpiarCampos()
                cargarVentas()
                actualizarProduccion()
                btnAnular.Enabled = False
                dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
            End If
        End If
        anularF.Dispose()
    End Sub

    Private Sub VentasForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control And e.KeyCode = Keys.G) Then
            e.SuppressKeyPress = True
            If cliente.nombre <> "" Then
                guardarVenta()
            End If
        End If
    End Sub





    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress, txtAlto.KeyPress, txtAncho.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtPlazo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPlazo1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtObservacion.Focus()
        End If
    End Sub

    Private Sub rbtnDol_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDol.CheckedChanged
        If rbtnDol.Checked And dolar = False Then
            If dgvProductos.Rows.Count > 0 Then
                Dim result As Integer = MessageBox.Show("Se borraran los productos añadidos. Desea cambiar de moneda?", "Cambio moneda", MessageBoxButtons.YesNo)
                If result = MsgBoxResult.Yes Then
                    dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
                    templado = False
                    templado2 = False
                    descuentoTotal = 0
                    recargoTotal = 0
                    limpiarTotalesDolares()
                    limpiarProductos()
                Else
                    rbtnGS.Checked = True
                    Exit Sub
                End If
            End If
            lbltitc.Visible = True
            lblCambio.Visible = True
            dolar = True
            txtObservacion.Focus()
        ElseIf rbtnDol.Checked Then
            lbltitc.Visible = True
            lblCambio.Visible = True
            dolar = True
            txtObservacion.Focus()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGS.CheckedChanged
        If rbtnGS.Checked And dolar = True Then
            If dgvProductos.Rows.Count > 0 Then
                Dim result As Integer = MessageBox.Show("Se borraran los productos añadidos. Desea cambiar de moneda?", "Cambio moneda", MessageBoxButtons.YesNo)
                If result = MsgBoxResult.Yes Then
                    dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
                    templado = False
                    templado2 = False
                    descuentoTotal = 0
                    recargoTotal = 0
                    limpiarTotales()
                    limpiarProductos()
                Else
                    rbtnDol.Checked = True
                    Exit Sub
                End If
            End If
            lbltitc.Visible = False
            lblCambio.Visible = False
            dolar = False
            txtObservacion.Focus()
        ElseIf rbtnGS.Checked Then
            lbltitc.Visible = False
            lblCambio.Visible = False
            dolar = False
            txtObservacion.Focus()
        End If
    End Sub

    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
        soloNumeros(e)
        txtRecargo.Text = 0
    End Sub

    Private Sub txtRecargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecargo.KeyPress
        soloNumeros(e)
        txtDescuento.Text = 0
    End Sub

    Private Sub txtDescuento_Click(sender As Object, e As EventArgs) Handles txtDescuento.Click
        txtDescuento.Select(sender.TextLength - 2, 0)
    End Sub

    Private Sub txtRecargo_Click(sender As Object, e As EventArgs) Handles txtRecargo.Click
        txtRecargo.Select(sender.TextLength - 2, 0)
    End Sub

    Private Sub btnPlanos_Click(sender As Object, e As EventArgs) Handles btnPlanos.Click
        If planos.Rows.Count > 0 Then
            Dim fplano As New VerPlano
            fplano.planos = planos
            fplano.ShowDialog()
            fplano.Dispose()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtFactuNro.Enabled = True
        btnGuardar.Enabled = True
        modificar = True
        txtFactuNro.Focus()
    End Sub




End Class