Imports Backend

Public Class VentasForm
    'Variables utiles
    Dim listClientes As New DataTable
    Dim cliente As New Cliente
    Dim producto As New Producto
    Dim vendedor As New Vendedor
    Dim sucursal As New Sucursal
    Dim deposito As New Deposito
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

    ' Carga del formulario
    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Date.Today
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
    End Sub

    'Busqueda de cliente
    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim buscarC As New ClienteBusqueda

            Dim res = buscarC.ShowDialog()
            If res = DialogResult.OK Then
                cliente = buscarC.cliente
                lblClienteNombre.Text = cliente.nombre
                lblClienteRuc.Text = cliente.ruc
                lblClienteTel.Text = cliente.telf

                asignarVendedor()
                asignarSucursal()
                asignarDeposito()
                'cargarVentas()
                'activarNavegacion()
                limpiarCampos()
                activarCamposNuevaVenta()
                modificar = False
                btnAnterior.Enabled = False
                btnSgte.Enabled = False
                btnPrim.Enabled = False
                btnUlt.Enabled = False
                btnAnular.Enabled = False
                dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
                txtDirEnvio.Text = cliente.dir
                btnNuevo.Enabled = False
            End If
            buscarC.Dispose()
        End If
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
            'MsgBox(listadoVentas.Count)

            'MsgBox("Venta actual " + ventaActual.ToString)
            'If listadoVentas.Count > 0 Then
            '    cargarPrimeraVenta()
            '    lblOTActual.Text = venta.id
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Carga la primera venta
    Private Sub cargarPrimeraVenta()
        Dim daoV As New VentaDAO
        ventaActual = 0
        venta = daoV.getVenta(listadoVentas.Item(ventaActual))
        txtFecha.Text = venta.fecha
        txtFactuNro.Text = venta.factura
        txtObservacion.Text = venta.obs
        Dim tmp = CDbl(venta.total)

        txtTotal.Text = FormatCurrency(tmp)
        txtIva.Text = FormatCurrency(tmp / 11)
        txtSaldo.Text = FormatCurrency(venta.saldo)

        If venta.credito = "N" Then
            rbtnCont.Checked = True

        Else
            rbtnCred.Checked = True
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
        If venta.envio = "S" Then
            'chbEntrega1.Checked = True
            txtPlazo1.Enabled = False
            txtFecha1.Enabled = False
            txtPlazo1.Text = venta.plazo
            txtFecha1.Text = venta.fechaP
        Else
            'chbEntrega1.Checked = False
            txtPlazo1.Text = ""
            txtFecha1.Text = ""
        End If
        Dim det = daoV.getDetalle(venta.id)
        dgvProductos.DataSource = det.Tables("tabla")
    End Sub

    Private Sub asignarVendedor()
        Try
            Dim daoV As New VendedorDAO
            vendedor = daoV.getVendedor(cliente.vendedor)
            'lblVendedor.Text = vendedor.nombre

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
            txtFecha1.Enabled = False
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
                txtCodProd.Text = ""
                activarMedidas(producto.tipo)
                asignarPrecio()
                txtDescuento.Text = 0
                txtRecargo.Text = 0
                If porUnidad = 1 Then
                    stockReal()
                End If

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
                    txtCodProd.Text = ""
                    activarMedidas(producto.tipo)
                    asignarPrecio()
                    txtDescuento.Text = "0"
                    txtRecargo.Text = "0"
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
        Select Case cliente.precioDefault
            Case "A"
                txtPrecio.Text = producto.PrecioA
            Case "B"
                txtPrecio.Text = producto.PrecioB
            Case "C"
                txtPrecio.Text = producto.PrecioC
            Case "D"
                txtPrecio.Text = producto.PrecioD
            Case Else
                txtPrecio.Text = 0
        End Select
        txtCantidad.Focus()
    End Sub



    Private Sub activarCampos()
        'txtNroOrden.Enabled = True
        txtFactuNro.Enabled = True
        'txtVendedor.Enabled = True
        txtObservacion.Enabled = True
    End Sub

    Private Sub limpiarCampos()
        ' txtNroOrden.Text = ""
        lblOTSeleccionada.Text = ""
        venta = New Venta
        cliente = New Cliente
        lblClienteNombre.Text = ""
        lblClienteRuc.Text = ""
        lblClienteTel.Text = ""
        txtFactuNro.Text = ""
        pbPlano.Image = Nothing
        txtObservacion.Text = ""
        lblProducto.Text = ""
        txtAlto.Text = ""
        txtAncho.Text = ""
        txtCantidad.Text = ""
        txtSup.Text = ""
        txtObra.Text = ""
        txtFecha1.Text = ""
        lblOTActual.Text = ""
        txtOT.Text = ""
        txtPlazo1.Text = ""
        txtFecha.Text = Date.Today
        txtPrecio.Text = ""
        txtTotal.Text = FormatCurrency(0)
        txtSaldo.Text = FormatCurrency(0)
        txtPago.Text = FormatCurrency(0)
        txtIva.Text = FormatCurrency(0)
        rbtnCont.Checked = True
        templado = False
        templado2 = False
        porUnidad = 0
        txtDirEnvio.Text = ""
        produccionVenta = 0
    End Sub

    'Private Sub chbEntrega1_CheckedChanged(sender As Object, e As EventArgs) 
    '    If chbEntrega1.Checked Then
    '        chbEntrega2.Enabled = True
    '        txtPlazo1.Enabled = True
    '        txtPlazo1.Focus()
    '    Else
    '        chbEntrega2.Enabled = False
    '        txtPlazo1.Enabled = False
    '    End If
    'End Sub

    'Private Sub chbEntrega2_CheckedChanged(sender As Object, e As EventArgs) Handles chbEntrega2.CheckedChanged
    '    If chbEntrega2.Checked And chbEntrega1.Checked Then
    '        txtPlazo2.Enabled = True
    '        txtPlazo2.Focus()
    '    ElseIf chbEntrega2.Checked And Not chbEntrega1.Checked Then
    '        MsgBox("Debe existir una primera entrega", MsgBoxStyle.Information, "Notificación")
    '        txtPlazo2.Enabled = False
    '    Else
    '        txtPlazo2.Enabled = False
    '    End If
    'End Sub

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'If cliente.nombre = "" Then
        Dim buscarC As New ClienteBusqueda

        Dim res = buscarC.ShowDialog()
        If res = DialogResult.OK Then
            cliente = buscarC.cliente
            lblClienteNombre.Text = cliente.nombre
            lblClienteRuc.Text = cliente.ruc
            lblClienteTel.Text = cliente.telf
            asignarVendedor()
            asignarSucursal()
            asignarDeposito()
            'cargarVentas()
            'activarNavegacion()
            'limpiarCampos()
            activarCamposNuevaVenta()
            modificar = False
            btnAnterior.Enabled = False
            btnSgte.Enabled = False
            btnPrim.Enabled = False
            btnUlt.Enabled = False
            btnAnular.Enabled = False
            dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
            txtDirEnvio.Text = cliente.dir
            rbtnCont.Checked = True
            rbtnCred.Checked = True
            'btnNuevo.Enabled = False
        End If
        buscarC.Dispose()

        'Else
        '    txtCliente.Focus()
        '    limpiarCampos()
        '    activarCamposNuevaVenta()
        '    modificar = False
        '    btnAnterior.Enabled = False
        '    btnSgte.Enabled = False
        '    btnPrim.Enabled = False
        '    btnUlt.Enabled = False
        '    btnAnular.Enabled = False
        '    dgvProductos.DataSource = New DataSet1.detalleVentaDataTable

        'End If
    End Sub

    Private Sub activarCamposNuevaVenta()
        txtFactuNro.Enabled = True
        txtFactuNro.Focus()
        'txtNroOrden.Enabled = True
        ' txtNroOrden.Focus()
        'txtVendedor.Enabled = True
        txtFactuNro.Focus()
        txtObservacion.Enabled = True
        pnlEnvio.Enabled = True
        txtCodProd.Enabled = True
        pnlTipoP.Enabled = True
        btnGuardar.Enabled = True
        rbtnCont.Enabled = True
        rbtnCred.Enabled = True
        btnEliminarProd.Enabled = True
        pnlEntrega1.Enabled = True
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

                    txtSup.Text = str
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
                row("Descuento") = txtDescuento.Text
                row("Recargo") = txtRecargo.Text
                detalle.desc = producto.descripcion
                detalle.obra = txtObra.Text
                detalle.precioU = CDbl(txtPrecio.Text)
                detalle.prodCod = producto.codigo

                If templado = True Then

                    detalle.cantidad = CInt(txtCantidad.Text)
                    detalle.ancho = CDbl(txtAncho.Text)
                    detalle.alto = CDbl(txtAlto.Text)
                    detalle.sup = CDbl((detalle.ancho * detalle.alto) / 1000000)
                    produccionVenta += detalle.sup
                    detalle.total = detalle.sup * detalle.precioU * detalle.cantidad
                    If txtDescuento.Text <> FormatPercent(0) Then
                        Dim str As String = txtDescuento.Text
                        str = str.Replace("%", "")
                        Dim val = CDbl(str) / 100
                        Dim descuento = detalle.total * val
                        detalle.total = detalle.total - descuento
                    ElseIf txtRecargo.Text <> FormatPercent(0) Then
                        Dim str As String = txtRecargo.Text
                        str = str.Replace("%", "")
                        Dim val = CDbl(str) / 100
                        Dim descuento = detalle.total * val
                        detalle.total = detalle.total + descuento
                    End If
                    row("Cantidad") = detalle.cantidad
                    row("Ancho") = CDbl(detalle.ancho)
                    row("Alto") = CDbl(detalle.alto)
                    row("Superficie") = detalle.sup
                    row("Total") = detalle.total
                Else
                    If txtCantidad.Text > txtStock.Text Then
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
                    If txtDescuento.Text <> FormatPercent(0) Then
                        Dim str As String = txtDescuento.Text
                        str = str.Replace("%", "")
                        Dim val = CDbl(str) / 100
                        Dim descuento = detalle.total * val
                        detalle.total = detalle.total - descuento
                    ElseIf txtRecargo.Text <> FormatPercent(0) Then
                        Dim str As String = txtRecargo.Text
                        str = str.Replace("%", "")
                        Dim val = CDbl(str) / 100
                        Dim descuento = detalle.total * val
                        detalle.total = detalle.total + descuento
                    End If
                    row("Cantidad") = detalle.cantidad
                    row("Ancho") = 0
                    row("Alto") = 0
                    row("Superficie") = 0
                    row("Total") = detalle.total
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
                'limpiarCamposProducto()
            End If
        End If
    End Sub

    Private Sub calcularTotal(ByVal monto As Double)
        If txtTotal.Text = "" Then
            txtTotal.Text = FormatCurrency(0, 0)
            txtIva.Text = FormatCurrency(0)
        Else
            Dim tmp = CDbl(txtTotal.Text + monto)

            txtTotal.Text = FormatCurrency(tmp)
            txtIva.Text = FormatCurrency(tmp / 11)
        End If

        If rbtnCont.Enabled = True Then
            txtPago.Text = FormatCurrency(txtTotal.Text)
        End If
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
                    nuevaVenta.total = txtTotal.Text
                    nuevaVenta.fecha = txtFecha.Text

                    nuevaVenta.factura = txtFactuNro.Text

                    nuevaVenta.m2 = produccionVenta
                    If rbtnCont.Checked = True Then
                        nuevaVenta.credito = "N"
                        nuevaVenta.saldo = 0
                        nuevaVenta.estado = "C"
                    Else
                        nuevaVenta.credito = "S"

                        nuevaVenta.saldo = nuevaVenta.total - CDbl(txtPago.Text)
                        nuevaVenta.estado = "P"
                    End If

                    If rbtnSi.Checked Then
                        nuevaVenta.plazo = txtPlazo1.Text
                        nuevaVenta.direEnv = txtDirEnvio.Text
                        nuevaVenta.fechaP = txtFecha1.Text
                        nuevaVenta.envio = "S"
                    Else
                        nuevaVenta.envio = "N"
                    End If
                    Dim daoVenta As New VentaDAO
                    Dim ventaGuardada = daoVenta.guardarVenta(nuevaVenta, dgvProductos.Rows, sucursal, deposito, produccionVenta)
                    If templado2 = True Then
                        If pbPlano.Image IsNot Nothing Then
                            Dim ruta = "venta_" + ventaGuardada.ToString + "_plano_.jpg"
                            Dim plano As Image = pbPlano.Image
                            daoVenta.guardarImagen(ruta, ventaGuardada, plano)
                        End If
                    End If

                    MsgBox("¡Venta Realizada!", MsgBoxStyle.Information, "Notificación Venta")
                    limpiarCampos()
                    activarCamposNuevaVenta()
                    If nuevaVenta.m2 > 0 Then
                        actualizarProduccion()
                    End If
                    modificar = False
                    btnAnterior.Enabled = False
                    btnSgte.Enabled = False
                    btnPrim.Enabled = False
                    btnUlt.Enabled = False

                    dgvProductos.DataSource = New DataSet1.detalleVentaDataTable
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Try
                    'Dim nuevaVenta As New Venta

                    'nuevaVenta.cliente = cliente.id

                    venta.obs = txtObservacion.Text
                    'venta.vendedor = vendedor.id
                    ' nuevaVenta.operacion = txtNroOrden.Text
                    'venta.total = txtTotal.Text
                    venta.fecha = dpFecha.Value

                    venta.factura = txtFactuNro.Text
                    venta.cliente = cliente.id
                    'nuevaVenta.vendedor = vendedor.id

                    If rbtnCont.Checked = True Then
                        'nuevaVenta.credito = "N"
                        'nuevaVenta.saldo = 0
                        'nuevaVenta.estado = "C"
                    Else
                        If CDbl(txtSaldo.Text) = 0 Then
                            venta.saldo = 0
                            venta.estado = "C"
                        Else
                            venta.saldo = CDbl(txtSaldo.Text)
                        End If
                    End If

                    If rbtnSi.Checked Then
                        venta.plazo = txtPlazo1.Text
                        venta.direEnv = txtDirEnvio.Text
                        venta.fechaP = txtFecha1.Text
                        venta.envio = "S"
                    Else
                        venta.envio = "N"
                    End If

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

        ElseIf txtFactuNro.Text = "" Then
            MsgBox("Ingrese un número de factura para la venta", MsgBoxStyle.Critical, "Error de datos")
            txtFactuNro.Focus()
            Return False
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
        If rbtnCont.Checked Then
            txtPago.Enabled = False
            txtPago.Text = FormatCurrency(txtTotal.Text)
            lblTipoFactura.Text = "Contado"
        Else
            txtPago.Enabled = True
            lblTipoFactura.Text = "Crédito"
        End If
    End Sub




    '---------------------------------------------'---------------------------------------------'---------------------------------------------
    ' Navegacion entre ventas

    'Venta anterior
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If listadoVentas.Count > 0 Then
            ventaActual -= 1
            If ventaActual = -1 Then
                ventaActual = listadoVentas.Count - 1

            End If
            cargarVenta()
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
        End If
    End Sub
    'Primera Venta
    Private Sub btnPrim_Click(sender As Object, e As EventArgs) Handles btnPrim.Click
        If listadoVentas.Count > 0 Then
            ventaActual = 0
            cargarVenta()
        End If

    End Sub
    'Ultima venta
    Private Sub btnUlt_Click(sender As Object, e As EventArgs) Handles btnUlt.Click
        If listadoVentas.Count > 0 Then
            ventaActual = listadoVentas.Count - 1
            cargarVenta()
        End If
    End Sub
    ' carga la venta
    Private Sub cargarVenta()
        Try
            Dim daoV As New VentaDAO
            venta = daoV.getVenta(listadoVentas.Item(ventaActual))
            txtFecha.Text = venta.fecha
            txtFactuNro.Text = venta.factura
            txtObservacion.Text = venta.obs
            Dim tmp = CDbl(venta.total)
            txtTotal.Text = FormatCurrency(tmp)
            txtIva.Text = FormatCurrency(tmp / 11)
            lblOTSeleccionada.Text = venta.id
            Try
                If venta.plano <> "" Then
                    pbPlano.Image = Image.FromFile(venta.plano)
                Else
                    pbPlano.Image = Nothing
                End If
            Catch ex As Exception
                pbPlano.Image = Nothing
            End Try


            If venta.credito = "N" Then
                rbtnCont.Checked = True
                txtPago.Text = FormatCurrency(tmp)
            Else
                rbtnCred.AutoCheck = True
                txtPago.Text = FormatCurrency(0)
            End If
            txtSaldo.Text = FormatCurrency(venta.saldo)
            If venta.envio = "S" Then
                'chbEntrega1.Checked = True
                txtPlazo1.Enabled = False
                txtFecha1.Enabled = False
                txtPlazo1.Text = venta.plazo
                txtFecha1.Text = venta.fechaP
            Else
                'chbEntrega1.Checked = False
                txtPlazo1.Text = ""
                txtFecha1.Text = ""
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
            Dim det = daoV.getDetalle(venta.id)
            dgvProductos.DataSource = det.Tables("tabla")
            lblOTActual.Text = venta.id
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Actualizar/Modificar Venta
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If cliente.nombre = "" Then
            MsgBox("Seleccione un cliente antes de modificar una venta", MsgBoxStyle.Information, "Notificacion")
        Else
            activarCamposModificar()
            modificar = True
        End If
    End Sub

    Private Sub activarCamposModificar()
        dpFecha.Visible = True
        txtFecha.Visible = False
        dpFecha.Value = venta.fecha
        dpFecha.Enabled = True
        txtFactuNro.Enabled = True
        txtObservacion.Enabled = True
        txtCodProd.Enabled = True
        btnGuardar.Enabled = True
        If venta.credito = "N" Then
            txtPago.Enabled = False

        Else
            txtPago.Enabled = True
        End If

        If venta.direEnv = "S" Then
            pnlEntrega1.Enabled = True
            'chbEntrega1.Enabled = True
        End If
    End Sub

    Private Sub desactivarCamposModificar()
        dpFecha.Visible = False
        txtFecha.Visible = True
        dpFecha.Value = venta.fecha
        dpFecha.Enabled = False
        txtFactuNro.Enabled = False
        txtObservacion.Enabled = False
        txtCodProd.Enabled = False
        btnGuardar.Enabled = False
        If venta.credito = "N" Then
            txtPago.Enabled = False

        Else
            txtPago.Enabled = False
        End If

        If venta.direEnv = "S" Then
            pnlEntrega1.Enabled = False
            'chbEntrega1.Enabled = True
        End If
    End Sub
    '---------------------------------------------'---------------------------------------------'---------------------------------------------
    ' Formatos de numeros
    Private Sub precioClick(sender As Object, e As EventArgs) Handles txtPago.Click
        If sender.Text <> "" Then
            sender.Select(sender.TextLength - 2, 0)
        End If
    End Sub

    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtPago.KeyPress, txtPlazo1.KeyPress, txtAncho.KeyPress, txtAlto.KeyPress, txtSup.KeyPress, txtCantidad.KeyPress, txtDescuento.KeyPress, txtRecargo.KeyPress

        soloNumeros(e)
    End Sub



    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        Dim val = CDbl(txtSaldo.Text)
        If val < 0 Then
            txtPago.Text = FormatCurrency(txtTotal.Text)
        End If
    End Sub

    Private Sub txtPlazo1_TextChanged(sender As Object, e As EventArgs) Handles txtPlazo1.TextChanged
        If txtPlazo1.Text <> "" Then
            Dim tod = Date.Today
            Dim dateP = tod.AddDays(txtPlazo1.Text)
            If dateP.DayOfWeek = DayOfWeek.Sunday Then
                dateP = tod.AddDays(1)
            End If
            txtFecha1.Text = dateP
        Else
            txtFecha1.Text = Date.Today
        End If

    End Sub

    Private Sub precioFormat(sender As Object, e As EventArgs) Handles txtPago.TextChanged
        Try
            If modificar = False Then
                If sender.Text <> "" Then
                    sender.Text = FormatCurrency(sender.Text, 1)
                    sender.Select(sender.TextLength - 2, 0)
                    If txtPago.Text <> "" And txtTotal.Text <> "" Then
                        txtSaldo.Text = FormatCurrency(txtTotal.Text - txtPago.Text, 1)
                    End If
                Else
                    sender.Text = FormatCurrency(0, 1)
                    sender.Select(sender.TextLength - 2, 0)
                    If txtTotal.Text <> "" And txtPago.Text <> "" Then
                        txtSaldo.Text = FormatCurrency(txtTotal.Text - txtPago.Text, 1)
                    End If
                End If
            Else
                If sender.Text <> "" Then
                    sender.Text = FormatCurrency(sender.Text, 1)
                    sender.Select(sender.TextLength - 2, 0)
                    If txtPago.Text <> "" And txtSaldo.Text <> "" Then
                        txtSaldo.Text = FormatCurrency(venta.saldo - txtPago.Text, 1)
                    End If
                Else
                    sender.Text = FormatCurrency(0, 1)
                    sender.Select(sender.TextLength - 2, 0)
                    If txtTotal.Text <> "" And txtPago.Text <> "" Then
                        txtSaldo.Text = FormatCurrency(venta.saldo - txtPago.Text, 1)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        If dgvProductos.SelectedRows.Count > 0 Then

            For Each row As DataGridViewRow In dgvProductos.SelectedRows

                Dim restarSub = row.Cells("TotalCol").Value

                Dim monto = row.Cells("TotalCol").Value
                Dim tmp = CDbl(txtTotal.Text - monto)

                txtTotal.Text = FormatCurrency(tmp)
                txtIva.Text = FormatCurrency(tmp / 11)
                txtSaldo.Text = FormatCurrency(tmp - CDbl(txtPago.Text))
                Dim produc = row.Cells("IDProdCol").Value

                If produc = producto.id And porUnidad = 1 Then
                    txtStock.Text = CInt(txtStock.Text) + row.Cells("CantidadCol").Value
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
    'Busqueda de ventas
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If cliente.nombre <> "" Then
                Dim busqV As New VentaBusqueda
                busqV.codigoCliente = cliente.id
                busqV.estadoFiltro = ""
                Dim res = busqV.ShowDialog()
                If res = DialogResult.OK Then
                    Dim ventaCodigoSel = busqV.venta
                    Dim aux = listadoVentas.IndexOf(ventaCodigoSel)
                    ventaActual = aux
                    cargarVenta()
                End If
                busqV.Dispose()
            Else
                MsgBox("Seleccione un cliente", MsgBoxStyle.Critical, "Notificación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim nroFactForm As New NroFactura
        nroFactForm.venta = venta
        Dim res = nroFactForm.ShowDialog
        If res = DialogResult.OK Then
            venta.factura = nroFactForm.venta.factura
            'imprimirfact()
        End If

    End Sub

    Public Sub imprimirfact()
        Dim facturaImprimir As New ImpresionFactura
        Dim daoCliente As New ClienteDAO

        'Dim currentVenta = daoVenta.obtenerVentaDatos(venta.id)
        Dim currentCliente = daoCliente.getCliente(venta.cliente)
        facturaImprimir.SetParameterValue("codigo", venta.id)
        facturaImprimir.SetParameterValue("nroFactura", venta.factura)
        facturaImprimir.SetParameterValue("cliente", currentCliente.nombre)
        facturaImprimir.SetParameterValue("ruc", currentCliente.ruc)
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
        facturaImprimir.PrintOptions.PrinterName = "EPSONLX-350" ''PONER NOMBRE DE IMPRESORA

        facturaImprimir.PrintToPrinter(1, False, 0, 0)
        MsgBox("¡Factura impresa!", MsgBoxStyle.Information, "Notificación")
        'daoVenta.facturaImpresa(Codigo)

    End Sub

    Private Sub pnlEnvio_Paint(sender As Object, e As PaintEventArgs) Handles pnlEnvio.Paint

    End Sub

    Private Sub txtOT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOT.KeyDown
        If e.KeyCode = Keys.Enter Then
            pnlEnvioNuevo.Visible = False
            e.SuppressKeyPress = True
            Dim daoP As New VentaDAO
            Dim ventaAux = daoP.getVenta(txtOT.Text)
            If ventaAux.id <> 0 Then
                venta = ventaAux
                btnAnular.Enabled = True
                asignarCliente()
                cargarVentasOT()
                desactivarMedidas()
                activarNavegacion()
                asignarSucursal()
                asignarDeposito()
                asignarVendedor()
                cargarVentaOT()
                lblOTActual.Text = venta.id
                btnGuardar.Enabled = False
                If venta.credito = "S" Then
                    lblTipoFactura.Text = "Crédito"
                Else
                    lblTipoFactura.Text = "Contado"
                End If
            Else
                'Dim buscarP As New ProductoBusqueda
                'buscarP.filtro = txtCodProd.Text
                'Dim res = buscarP.ShowDialog()
                'If res = DialogResult.OK Then
                '    producto = buscarP.producto
                '    lblProducto.Text = producto.descripcion
                '    txtCodProd.Text = ""
                '    activarMedidas(producto.tipo)
                '    asignarPrecio()
                'End If
                'buscarP.Dispose()
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
                                                       Return value = venta.id
                                                   End Function))
            venta = daoV.getVenta(listadoVentas.Item(ventaActual))
            txtFecha.Text = venta.fecha
            txtFactuNro.Text = venta.factura
            txtObservacion.Text = venta.obs
            Dim tmp = CDbl(venta.total)
            txtTotal.Text = FormatCurrency(tmp)
            txtIva.Text = FormatCurrency(tmp / 11)
            lblOTSeleccionada.Text = venta.id
            If venta.plano <> "" Then
                pbPlano.Image = Image.FromFile(venta.plano)
            Else
                pbPlano.Image = Nothing
            End If

            If venta.credito = "N" Then
                rbtnCont.Checked = True
                txtPago.Text = FormatCurrency(tmp)
            Else
                rbtnCred.AutoCheck = True
                txtPago.Text = FormatCurrency(0)
            End If
            txtSaldo.Text = FormatCurrency(venta.saldo)
            If venta.envio = "S" Then
                'chbEntrega1.Checked = True
                txtPlazo1.Enabled = False
                txtFecha1.Enabled = False
                txtPlazo1.Text = venta.plazo
                txtFecha1.Text = venta.fechaP
                lblFechaEntrega.Text = venta.fechaP
                lblEnvio.Text = "Sí"
            Else
                'chbEntrega1.Checked = False
                txtPlazo1.Text = ""
                txtFecha1.Text = ""
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarVentasOT()
        Try
            Dim daoV As New VentaDAO

            listadoVentas = daoV.listadoVentas(cliente.id)
            'MsgBox(listadoVentas.Count)

            'MsgBox("Venta actual " + ventaActual.ToString)
            'If listadoVentas.Count > 0 Then
            '    cargarPrimeraVenta()
            '    lblOTActual.Text = venta.id
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDescuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtRecargo.Focus()
        End If
    End Sub

    Private Sub txtRecargo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRecargo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtObra.Focus()
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
        End If
    End Sub

    Private Sub txtAncho_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAncho.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtAlto.Focus()
        End If
    End Sub

    Private Sub txtAlto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAlto.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtDescuento.Focus()
        End If
    End Sub

    Private Sub txtFactuNro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFactuNro.KeyDown
        If e.KeyCode = Keys.Enter Then
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
        Dim str2 As String = txtDescuento.Text
        If sender.text = FormatPercent(0) Then
            Exit Sub
        ElseIf sender.Text <> "" Then
            Dim str As String = txtDescuento.Text
            str = str.Replace("%", "")
            Dim val = CDbl(str) / 100
            sender.Text = FormatPercent(val)
            sender.Select(sender.TextLength - 4, 0)

            txtRecargo.Text = FormatPercent(0)
        Else
            sender.Text = ""
        End If
    End Sub

    Private Sub txtRecargo_TextChanged(sender As Object, e As EventArgs) Handles txtRecargo.TextChanged
        Dim str2 As String = txtRecargo.Text
        If sender.text = FormatPercent(0) Then
            Exit Sub
        ElseIf sender.Text <> "" Then
            Dim str As String = txtRecargo.Text
            str = str.Replace("%", "")
            Dim val = CDbl(str) / 100
            sender.Text = FormatPercent(val)
            sender.Select(sender.TextLength - 4, 0)
            txtDescuento.Text = FormatPercent(0)
        Else
            sender.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSubirPlano.Click
        If templado2 = True Then
            Dim file As New OpenFileDialog()
            file.Filter = "Archivo JPG|*.jpg"
            If file.ShowDialog() = DialogResult.OK Then
                pbPlano.Image = Image.FromFile(file.FileName)
                pbPlano.SizeMode = PictureBoxSizeMode.Zoom
            End If
            file.Dispose()
        End If
    End Sub

    Private Sub pbPlano_Click(sender As Object, e As EventArgs) Handles pbPlano.Click
        Try
            If venta.plano <> "" Then
                Dim planoForm As New VerPlano
                planoForm.ruta = venta.plano
                planoForm.ShowDialog()
                planoForm.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub

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
End Class