Imports Backend

Public Class VentasForm
    'Variables utiles
    Dim listClientes As New DataTable
    Dim cliente As New Cliente
    Dim producto As New Producto
    Dim vendedor As New Vendedor
    Dim venta As New Venta ' almacena la venta que se ve en pantalla
    Dim tipoAct As String
    Dim listadoVentas As New List(Of Integer)
    Dim ventaActual = 0
    Dim columnasGrid
    Dim modificar = False
    ' Carga del formulario
    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Date.Today
        lblProducto.Text = ""
        rbtnNo.Checked = True
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        calcularTotal(0)
        rbtnCont.Enabled = False
        rbtnCred.Enabled = False
        columnasGrid = dgvProductos.Columns
        Dim daoV As New VentaDAO
        Dim det = daoV.getDetalle(-1)
        dgvProductos.DataSource = det.Tables("tabla")
    End Sub

    'Busqueda de cliente
    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim buscarC As New ClienteBusqueda
            buscarC.filtro = txtCliente.Text
            Dim res = buscarC.ShowDialog()
            If res = DialogResult.OK Then
                cliente = buscarC.cliente
                lblClienteNombre.Text = cliente.nombre
                lblClienteRuc.Text = cliente.ruc
                lblClienteTel.Text = cliente.telf
                txtCliente.Text = ""
                btnGuardar.Enabled = False
                asignarVendedor()
                cargarVentas()
                activarNavegacion()
                txtDirEnvio.Text = cliente.dir
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
            listadoVentas = daoV.listadoVentas(cliente.id)
            If listadoVentas.Count > 0 Then
                cargarPrimeraVenta()
            End If

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

        If venta.envio = "S" Then
            chbEntrega1.Checked = True
            txtPlazo1.Enabled = False
            txtFecha1.Enabled = False
            txtPlazo1.Text = venta.plazo
            txtFecha1.Text = venta.fechaP
        Else
            chbEntrega1.Checked = False
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
            txtVendedor.Text = vendedor.nombre
            txtVendedor.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub
    Private Sub rbtnSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSi.CheckedChanged
        If rbtnSi.Checked Then
            pnlEntrega1.Enabled = True
            pnlEntrega2.Enabled = True
            pnldDir.Enabled = True
            txtPlazo1.Enabled = False
            txtPlazo2.Enabled = False
            txtFecha1.Enabled = False
            txtFecha2.Enabled = False
        Else
            pnlEntrega1.Enabled = False
            pnlEntrega2.Enabled = False
            pnldDir.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtCodProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim daoP As New ProductoDAO
            producto = daoP.getProductoByCod(txtCodProd.Text)
            If producto.descripcion IsNot Nothing Then
                lblProducto.Text = producto.descripcion
                txtCodProd.Text = ""
                activarMedidas(producto.tipo)
                asignarPrecio()
            Else
                Dim buscarP As New ProductoBusqueda
                buscarP.filtro = txtCodProd.Text
                Dim res = buscarP.ShowDialog()
                If res = DialogResult.OK Then
                    producto = buscarP.producto
                    lblProducto.Text = producto.descripcion
                    txtCodProd.Text = ""
                    activarMedidas(producto.tipo)
                    asignarPrecio()
                End If
                buscarP.Dispose()
            End If
        End If
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
        Else
            txtAlto.Enabled = True
            txtAncho.Enabled = True
            txtObra.Enabled = True
            txtCantidad.Enabled = False
        End If
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
    End Sub
    Private Sub txtDirEnvio_TextChanged(sender As Object, e As EventArgs) Handles txtDirEnvio.TextChanged

    End Sub

    ' Nueva venta
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        If cliente.nombre <> "" Then
            activarCampos()
            limpiarCampos()
            txtFactuNro.Focus()
            'txtNroOrden.Focus()
        Else
            MsgBox("Seleccione un cliente", MsgBoxStyle.Critical, "Notificación")
            txtCliente.Focus()
        End If
    End Sub

    Private Sub activarCampos()
        'txtNroOrden.Enabled = True
        txtFactuNro.Enabled = True
        txtVendedor.Enabled = True
        txtObservacion.Enabled = True
    End Sub

    Private Sub limpiarCampos()
        'txtNroOrden.Text = ""
        txtFactuNro.Text = ""
        txtVendedor.Text = ""
        txtObservacion.Text = ""
        txtCliente.Text = ""
        lblClienteNombre.Text = ""
        lblClienteRuc.Text = ""
        lblClienteTel.Text = ""
        lblProducto.Text = ""
        txtAlto.Text = ""
        txtAncho.Text = ""
        txtCantidad.Text = ""
        txtSup.Text = ""
        txtObra.Text = ""
        txtPrecio.Text = ""
        txtFecha1.Text = ""
        txtFecha2.Text = ""
        txtPlazo1.Text = ""
        txtPlazo2.Text = ""
        txtFecha.Text = Date.Today
        txtDirEnvio.Text = ""
        txtTotal.Text = FormatCurrency(0)
        txtSaldo.Text = FormatCurrency(0)
        txtPago.Text = FormatCurrency(0)
        txtIva.Text = FormatCurrency(0)
    End Sub

    Private Sub limpiarCampos2()
        ' txtNroOrden.Text = ""
        txtFactuNro.Text = ""
        txtObservacion.Text = ""
        txtCliente.Text = ""
        lblProducto.Text = ""
        txtAlto.Text = ""
        txtAncho.Text = ""
        txtCantidad.Text = ""
        txtSup.Text = ""
        txtObra.Text = ""
        txtFecha1.Text = ""
        txtFecha2.Text = ""
        txtPlazo1.Text = ""
        txtPlazo2.Text = ""
        txtFecha.Text = Date.Today
        txtPrecio.Text = ""
        txtTotal.Text = FormatCurrency(0)
        txtSaldo.Text = FormatCurrency(0)
        txtPago.Text = FormatCurrency(0)
        txtIva.Text = FormatCurrency(0)
        rbtnCont.Checked = True
    End Sub

    Private Sub chbEntrega1_CheckedChanged(sender As Object, e As EventArgs) Handles chbEntrega1.CheckedChanged, chbEntrega2.CheckedChanged
        If chbEntrega1.Checked Then
            chbEntrega2.Enabled = True
            txtPlazo1.Enabled = True
            txtPlazo1.Focus()
        Else
            chbEntrega2.Enabled = False
            txtPlazo1.Enabled = False
        End If
    End Sub

    Private Sub chbEntrega2_CheckedChanged(sender As Object, e As EventArgs) Handles chbEntrega2.CheckedChanged
        If chbEntrega2.Checked And chbEntrega1.Checked Then
            txtPlazo2.Enabled = True
            txtPlazo2.Focus()
        ElseIf chbEntrega2.Checked And Not chbEntrega1.Checked Then
            MsgBox("Debe existir una primera entrega", MsgBoxStyle.Information, "Notificación")
            txtPlazo2.Enabled = False
        Else
            txtPlazo2.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If cliente.nombre = "" Then
            MsgBox("Seleccione un cliente antes de crear una venta", MsgBoxStyle.Information, "Notificacion")
            txtCliente.Focus()

        Else
            activarCamposNuevaVenta()
            modificar = False
            btnAnterior.Enabled = False
            btnSgte.Enabled = False
            btnPrim.Enabled = False
            btnUlt.Enabled = False
            limpiarCampos2()
            dgvProductos.DataSource = New DataSet1.detalleVentaDataTable

        End If
    End Sub

    Private Sub activarCamposNuevaVenta()
        txtFactuNro.Enabled = True
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
    Private Sub txtVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim buscarV As New VendedorBusqueda
            buscarV.filtro = txtCliente.Text
            Dim res = buscarV.ShowDialog()
            If res = DialogResult.OK Then
                vendedor = buscarV.vendedor
                txtVendedor.Text = vendedor.nombre
                txtVendedor.Enabled = False
            End If
            buscarV.Dispose()
        End If
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
                If Double.TryParse(txtAlto.Text * txtAncho.Text, str) Then

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
                detalle.desc = producto.descripcion
                detalle.obra = txtObra.Text
                detalle.precioU = CDbl(txtPrecio.Text)
                detalle.prodCod = producto.codigo
                If txtCantidad.Text = "" Then
                    detalle.cantidad = 0
                    detalle.ancho = CDbl(txtAncho.Text)
                    detalle.alto = CDbl(txtAlto.Text)
                    detalle.sup = detalle.ancho * detalle.alto
                    detalle.total = detalle.sup * detalle.precioU
                    row("Cantidad") = 0
                    row("Ancho") = CDbl(txtAncho.Text)
                    row("Alto") = CDbl(txtAlto.Text)
                    row("Superficie") = detalle.ancho * detalle.alto
                    row("Total") = detalle.sup * detalle.precioU
                Else
                    detalle.cantidad = CInt(txtCantidad.Text)
                    detalle.ancho = 0
                    detalle.alto = 0
                    detalle.sup = 0
                    detalle.total = detalle.cantidad * detalle.precioU

                    row("Cantidad") = detalle.cantidad
                    row("Ancho") = 0
                    row("Alto") = 0
                    row("Superficie") = 0
                    row("Total") = detalle.cantidad * detalle.precioU
                End If




                'row("Impuesto") = cbImpuesto.SelectedItem("Impuesto")
                'row("Iva") = FormatCurrency(iva)
                'row("Sub-Total") = FormatCurrency(total - iva)
                'row("Total") = FormatCurrency(total)

                'If txtSub.Text = "" Then
                '    txtSub.Text = FormatCurrency(total - iva)
                'Else
                '    txtSub.Text = FormatCurrency(CDbl(txtSub.Text) + total - iva)
                'End If
                'If txtTotalVenta.Text <> "" Then
                '    txtTotalVenta.Text = FormatCurrency(CDbl(txtTotalVenta.Text) + total)
                'Else
                '    txtTotalVenta.Text = FormatCurrency(total)
                'End If

                'If txtIva.Text <> "" Then
                '    txtIva.Text = FormatCurrency(CDbl(txtIva.Text) + iva)
                'Else
                '    txtIva.Text = FormatCurrency(iva)
                'End If

                'Dim agregar As New DataGridViewRow
                'dgvProductos.Rows.Add(txtCodProd)
                'Dim dt As DataTable = DirectCast(dgvProductos.DataSource, DataTable)
                'dt.Rows.Add(row)
                'dgvProductos.Rows.Add(detalle.id, detalle.ventaCod, detalle.producto, detalle.prodCod, detalle.desc, detalle.cantidad, detalle.ancho, detalle.alto, detalle.sup, detalle.precioU, detalle.total, detalle.obra)
                row2.Rows.Add(row)
                dgvProductos.DataSource = row2
                'dgvProductos.Rows.Add(row)
                dgvProductos.ClearSelection()
                calcularTotal(detalle.total)
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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
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
                    'If txtDescuento.Text = "" Then

                    '    venta.descuento = 0

                    'Else
                    '    venta.descuento = CDbl(txtDescuento.Text)
                    'End If
                    'venta.fecha = Date.Today
                    'venta.factura = txtFactuNro.Text
                    'venta.total = CDbl(txtTotalVenta.Text)
                    Dim daoVenta As New VentaDAO
                    Dim ventaGuardada = daoVenta.guardarVenta(nuevaVenta, dgvProductos.Rows)


                    MsgBox("¡Venta Realizada!", MsgBoxStyle.Information, "Notificación Venta")
                    desactivarCamposNuevaVenta()
                    limpiarCampos2()
                    cargarVentas()
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
                    'nuevaVenta.cliente = cliente.id
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
                    'If txtDescuento.Text = "" Then

                    '    venta.descuento = 0

                    'Else
                    '    venta.descuento = CDbl(txtDescuento.Text)
                    'End If
                    'venta.fecha = Date.Today
                    'venta.factura = txtFactuNro.Text
                    'venta.total = CDbl(txtTotalVenta.Text)
                    Dim daoVenta As New VentaDAO
                    daoVenta.actualizarVenta(venta, dgvProductos.Rows)


                    MsgBox("¡Venta Actualizada!", MsgBoxStyle.Information, "Notificación Venta")
                    desactivarCamposModificar()
                    limpiarCampos2()
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

    '---------------------------------------------'---------------------------------------------'---------------------------------------------
    ' Validaciones
    'Validar Venta
    Private Function validarVenta() As Boolean
        'If txtFactuNro.Text = "" Then
        '    MsgBox("Ingrese un número de factura para la venta", MsgBoxStyle.Critical, "Error de datos")
        '    txtFactuNro.Focus()
        '    Return False
        If rbtnCont.Checked = False And rbtnCred.Checked = False Then
            MsgBox("Seleccione un tipo de pago", MsgBoxStyle.Critical, "Error de datos")
            pnlTipoP.Focus()
            Return False
        ElseIf dgvProductos.Rows.Count = 0 Then
            MsgBox("Debe agregar al menos un producto para la venta", MsgBoxStyle.Critical, "Error de datos")
            txtCodProd.Focus()
            Return False
        ElseIf rbtnSi.Checked Then
            If chbEntrega1.Checked = False Then
                MsgBox("Debe agregar al menos una entrega a la venta", MsgBoxStyle.Critical, "Error de datos")
                chbEntrega1.Focus()
            Else
                If txtPlazo1.Text = "" Then
                    MsgBox("Ingrese la cantidad de días hábiles para la entrega", MsgBoxStyle.Critical, "Error de datos")
                    txtPlazo1.Focus()
                End If
            End If
        End If
            Return True
    End Function

    Private Function validarProducto() As Boolean
        Return True
    End Function

    Private Sub rbtnCont_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCont.CheckedChanged
        If rbtnCont.Checked Then
            txtPago.Enabled = False
            txtPago.Text = FormatCurrency(txtTotal.Text)

        Else
            txtPago.Enabled = True
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


            If venta.credito = "N" Then
                rbtnCont.Checked = True
                txtPago.Text = FormatCurrency(tmp)
            Else
                rbtnCred.AutoCheck = True
                txtPago.Text = FormatCurrency(0)
            End If
            txtSaldo.Text = FormatCurrency(venta.saldo)
            If venta.envio = "S" Then
                chbEntrega1.Checked = True
                txtPlazo1.Enabled = False
                txtFecha1.Enabled = False
                txtPlazo1.Text = venta.plazo
                txtFecha1.Text = venta.fechaP
            Else
                chbEntrega1.Checked = False
                txtPlazo1.Text = ""
                txtFecha1.Text = ""
            End If
            Dim det = daoV.getDetalle(venta.id)
            dgvProductos.DataSource = det.Tables("tabla")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Actualizar/Modificar Venta
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If cliente.nombre = "" Then
            MsgBox("Seleccione un cliente antes de modificar una venta", MsgBoxStyle.Information, "Notificacion")
            txtCliente.Focus()
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
            chbEntrega1.Enabled = True
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
            chbEntrega1.Enabled = True
        End If
    End Sub
    '---------------------------------------------'---------------------------------------------'---------------------------------------------
    ' Formatos de numeros
    Private Sub precioClick(sender As Object, e As EventArgs) Handles txtPago.Click
        If sender.Text <> "" Then
            sender.Select(sender.TextLength - 2, 0)
        End If
    End Sub

    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtPago.KeyPress, txtPlazo1.KeyPress, txtPlazo2.KeyPress, txtAncho.KeyPress, txtAlto.KeyPress, txtSup.KeyPress, txtCantidad.KeyPress

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
                dgvProductos.Rows.Remove(row)
            Next
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
                txtCliente.Focus()
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
End Class