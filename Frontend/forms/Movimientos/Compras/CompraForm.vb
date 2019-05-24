Imports Backend

Public Class CompraForm
    'Variables utiles
    Dim listClientes As New DataTable
    Dim proveedor As New Proveedor
    Dim producto As New Producto
    Dim vendedor As New Vendedor
    Dim sucursal As New Sucursal
    Dim deposito As New Deposito
    Dim compra As New Compra ' almacena la compra que se ve en pantalla
    Dim tipoAct As String
    Dim listadoCompras As New List(Of Integer)
    Dim compraActual = 0
    Dim columnasGrid
    Dim modificar = False
    Dim produccionDia As New Produccion
    Dim produccionVenta As Double = 0

    Private Sub CompraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Date.Today
        lblProducto.Text = ""
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        calcularTotal(0, 0, 0, 0)
        rbtnCont.Enabled = False
        rbtnCred.Enabled = False
        columnasGrid = dgvProductos.Columns
        cargarCompras()
        PersonalizarDAtagridView(dgvProductos)
        dgvProductos.DataSource = New DataSet1.detalleCompraDataTable
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
            .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 101, 205)
            .AlternatingRowsDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            'Tipo de letra and color
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'Coloreo el background del DGV
            .BackgroundColor = Color.FromArgb(48, 65, 91)
        End With
    End Sub
    Private Sub cargarCompras()
        Try
            Dim daoV As New CompraDAO
            listadoCompras = daoV.getCompras()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub calcularTotal(ByVal monto As Double, ByVal iva5 As Double, ByVal iva10 As Double, ByVal exenta As Double)
        If txtTotal.Text = "" Then
            txtTotal.Text = FormatCurrency(0, 0)
            txtIva5.Text = FormatCurrency(0)
            txtIva10.Text = FormatCurrency(0)
            txtExentaT.Text = FormatCurrency(0)
        Else
            Dim tmp = CDbl(txtTotal.Text + monto)
            Dim ivaaux5 = CDbl(txtIva5.Text) + iva5
            Dim ivaaux10 = CDbl(txtIva10.Text) + iva10
            txtTotal.Text = FormatCurrency(tmp)
            txtIva5.Text = FormatCurrency(ivaaux5)
            txtIva10.Text = FormatCurrency(ivaaux10)
            txtExentaT.Text = FormatCurrency(exenta)
        End If

        If rbtnCont.Checked Then
            txtSaldo.Text = FormatCurrency(0)
        Else
            txtSaldo.Text = FormatCurrency(txtTotal.Text)

        End If
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim buscarP As New BuscarProveedor
        limpiarCampos()
        Dim res = buscarP.ShowDialog()
        If res = DialogResult.OK Then
            pnlTipoP.Visible = True
            proveedor = buscarP.proveedor
            asignarProveedor()
            prepararNuevaCompra()
            buscarP.Dispose()
            Dim buscarS As New BuscarSucursal
            Dim res2 = buscarS.ShowDialog()
            If res2 = DialogResult.OK Then
                sucursal = buscarS.sucursal
                asignarSucursal()
                asignarDeposito()
            End If
            txtFactuNro.Focus()
            buscarS.Dispose()
        End If
    End Sub

    Private Sub prepararNuevaCompra()
        modificar = False
        btnAnterior.Enabled = False
        btnSgte.Enabled = False
        btnPrim.Enabled = False
        btnUlt.Enabled = False
        btnAnular.Enabled = False
        dgvProductos.DataSource = New DataSet1.detalleCompraDataTable
        rbtnCont.Checked = True
        rbtnCred.Checked = True
        txtFactuNro.Enabled = True
        txtObservacion.Enabled = True
        txtCodProd.Enabled = True
        txtFecha.Text = Date.Today
        pnlTipoP.Enabled = True
        rbtnCont.Enabled = True
        rbtnCred.Enabled = True
        rbtnCont.Checked = True
        btnGuardar.Enabled = True
        btnEliminarProd.Enabled = True
    End Sub

    Private Sub desactivarCampos()
        modificar = True
        btnAnterior.Enabled = True
        btnSgte.Enabled = True
        btnPrim.Enabled = True
        btnUlt.Enabled = True
        btnAnular.Enabled = True
        txtFactuNro.Enabled = False
        txtObservacion.Enabled = False
        txtCodProd.Enabled = False
        pnlTipoP.Enabled = False
        rbtnCont.Enabled = False
        rbtnCred.Enabled = False
        rbtnCont.Checked = False
        btnGuardar.Enabled = False
        btnEliminarProd.Enabled = False
        txtCantidad.Enabled = False
    End Sub
    Private Sub asignarSucursal()
        lblSucursal.Text = sucursal.nombre
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

    Private Sub asignarProveedor()
        lblClienteNombre.Text = proveedor.nombre
        lblClienteRuc.Text = proveedor.ruc
        lblClienteTel.Text = proveedor.telf
    End Sub



    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress, txtExenta.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim daoP As New ProductoDAO
            Dim daoT As New TipoProdDAO
            producto = daoP.getProductoByCod(txtCodProd.Text)

            Dim tipoP = daoT.getTipo(producto.tipo)

            If producto.descripcion IsNot Nothing Then
                lblProducto.Text = producto.descripcion
                txtCodProd.Text = ""
                txtCantidad.Enabled = True
                txtExenta.Enabled = True
                txtExenta.Text = 0
                asignarCosto()
                txtExenta.Focus()
            Else
                Dim buscarP As New ProductoBusqueda
                buscarP.filtro = txtCodProd.Text
                Dim res = buscarP.ShowDialog()
                If res = DialogResult.OK Then
                    producto = buscarP.producto
                    tipoP = daoT.getTipo(producto.tipo)
                    lblProducto.Text = producto.descripcion
                    txtCodProd.Text = ""
                    txtCantidad.Enabled = True
                    txtExenta.Enabled = True
                    txtExenta.Text = 0
                    asignarCosto()
                    txtExenta.Focus()
                End If
                buscarP.Dispose()
            End If

        End If
    End Sub

    Private Sub asignarCosto()
        txtPrecio.Text = producto.costo
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
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
                row("Compra") = 0
                row("ProdID") = producto.id
                row("Producto") = producto.descripcion
                row("Cantidad") = txtCantidad.Text
                row("Código") = producto.codigo

                row("Costo") = CDbl(txtPrecio.Text)
                Dim total = 0
                Dim iva5 = 0
                Dim iva10 = 0
                Dim exenta = 0
                If producto.iva = 1 Then
                    total = CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text)
                    exenta = CDbl(txtExenta.Text) * CDbl(txtCantidad.Text)
                    If exenta <> 0 Then
                        total = total - exenta
                        row("Exenta") = exenta
                    Else
                        row("Exenta") = 0
                    End If
                    Dim iva = CDbl(total / 21)
                    iva5 = iva
                    row("Iva 5%") = Math.Round(iva)
                    row("Iva 10%") = 0
                    row("Total") = total
                ElseIf producto.iva = 2 Then
                    total = CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text)
                    exenta = CDbl(txtExenta.Text) * CDbl(txtCantidad.Text)
                    If exenta <> 0 Then
                        total = total - exenta
                        row("Exenta") = exenta
                    Else
                        row("Exenta") = 0
                    End If
                    Dim iva = CDbl(total / 11)
                    iva10 = iva
                    row("Iva 5%") = 0
                    row("Iva 10%") = Math.Round(iva)
                    row("Total") = total
                End If

                row2.Rows.Add(row)
                dgvProductos.DataSource = row2
                dgvProductos.ClearSelection()
                calcularTotal(total, iva5, iva10, exenta)
            End If
        End If
    End Sub
    Private Function validarProducto() As Boolean
        If txtCantidad.Text = "" Then
            MsgBox("Ingrese un cantidad ", MsgBoxStyle.Critical, "Error de datos")
            txtCantidad.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub txtExenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtExenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub txtFactuNro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFactuNro.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtObservacion.Focus()
        End If
    End Sub

    Private Sub txtObs_enter(sender As Object, e As KeyEventArgs) Handles txtObservacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCodProd.Focus()
        End If
    End Sub

    Private Sub rbtnCont_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCont.CheckedChanged
        If rbtnCont.Checked Then
            lblTipoFactura.Text = "Contado"
            txtSaldo.Text = FormatCurrency(0)
        Else
            lblTipoFactura.Text = "Crédito"
            txtSaldo.Text = FormatCurrency(txtTotal.Text)
        End If
    End Sub

    Private Sub guardarCompra()
        If validarVenta() Then
            If modificar = False Then
                Try
                    Dim nuevaCompra As New Compra

                    nuevaCompra.proveedor = proveedor.id
                    nuevaCompra.obs = txtObservacion.Text
                    nuevaCompra.sucursal = sucursal.id
                    nuevaCompra.total = txtTotal.Text
                    nuevaCompra.fecha = txtFecha.Text
                    nuevaCompra.factura = txtFactuNro.Text
                    nuevaCompra.iva10 = txtIva10.Text
                    nuevaCompra.iva5 = txtIva5.Text
                    nuevaCompra.excenta = txtExentaT.Text
                    ' nuevaVenta.operacion = txtNroOrden.Text

                    If rbtnCont.Checked = True Then
                        nuevaCompra.credito = "N"
                        nuevaCompra.saldo = 0
                        nuevaCompra.estado = "C"
                        nuevaCompra.fechaP = Date.Today
                    Else
                        nuevaCompra.credito = "S"

                        nuevaCompra.saldo = nuevaCompra.total
                        nuevaCompra.estado = "P"
                    End If

                    Dim daoCompra As New CompraDAO
                    Dim compraGuardada = daoCompra.guardarCompra(nuevaCompra, dgvProductos.Rows, sucursal, deposito, produccionVenta)


                    MsgBox("¡Compra Realizada!", MsgBoxStyle.Information, "Notificación Venta")
                    limpiarCampos()
                    prepararNuevaCompra()
                    modificar = False
                    btnAnterior.Enabled = False
                    btnSgte.Enabled = False
                    btnPrim.Enabled = False
                    btnUlt.Enabled = False


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                'Try
                '    compra.obs = txtObservacion.Text
                '    compra.factura = txtFactuNro.Text
                '    compra.proveedor = proveedor.id
                '    If rbtnCont.Checked = True Then
                '        'nuevaVenta.credito = "N"
                '        'nuevaVenta.saldo = 0
                '        'nuevaVenta.estado = "C"
                '    Else
                '        If CDbl(txtSaldo.Text) = 0 Then
                '            compra.saldo = 0
                '            compra.estado = "C"
                '        Else
                '            compra.saldo = CDbl(txtSaldo.Text)
                '        End If
                '    End If
                '    Dim daoVenta As New VentaDAO
                '    daoVenta.actualizarVenta(Venta, dgvProductos.Rows)
                '    MsgBox("¡Venta Actualizada!", MsgBoxStyle.Information, "Notificación Venta")
                '    desactivarCamposModificar()
                '    limpiarCampos()
                '    cargarVenta()
                '    activarNavegacion()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'End Try
            End If

        End If
    End Sub

    Private Sub limpiarCampos()
        ' txtNroOrden.Text = ""
        lblOTSeleccionada.Text = ""
        compra = New Compra
        proveedor = New Proveedor
        lblClienteNombre.Text = ""
        lblClienteRuc.Text = ""
        lblClienteTel.Text = ""
        txtFactuNro.Text = ""
        txtObservacion.Text = ""
        lblProducto.Text = ""
        txtCantidad.Text = ""

        lblEstado.Text = ""
        'txtOT.Text = ""
        txtFecha.Text = Date.Today
        txtPrecio.Text = ""
        txtTotal.Text = FormatCurrency(0)
        txtSaldo.Text = FormatCurrency(0)

        txtIva10.Text = FormatCurrency(0)
        txtIva5.Text = FormatCurrency(0)
        txtExenta.Text = FormatCurrency(0)
        txtExentaT.Text = FormatCurrency(0)
        rbtnCont.Checked = True
    End Sub
    Private Function validarVenta() As Boolean
        If proveedor.nombre = "" Then
            MsgBox("Seleccione un proveedor", MsgBoxStyle.Critical, "Error de datos")
            Return False

        ElseIf txtFactuNro.Text = "" Then
            MsgBox("Ingrese un número de factura para la compra", MsgBoxStyle.Critical, "Error de datos")
            txtFactuNro.Focus()
            Return False
        ElseIf rbtnCont.Checked = False And rbtnCred.Checked = False Then
            MsgBox("Seleccione un tipo de pago", MsgBoxStyle.Critical, "Error de datos")
            pnlTipoP.Focus()
            Return False
        ElseIf dgvProductos.Rows.Count = 0 Then
            MsgBox("Debe agregar al menos un producto para la compra", MsgBoxStyle.Critical, "Error de datos")
            Return False
        End If
        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardarCompra()
    End Sub


    Private Sub txtOT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOT.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            limpiarCampos()
            desactivarCampos()
            Dim daoP As New CompraDAO
            Dim compraAux = daoP.getCompra(txtOT.Text)
            If compraAux.id <> 0 Then
                compra = compraAux
                btnAnular.Enabled = True
                cargarSucursal()
                asignarDeposito()
                cargarCompra(0)

                btnGuardar.Enabled = False
                btnAnular.Enabled = True
                If compra.credito = "S" Then
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

    Private Sub cargarSucursal()
        Try
            Dim daoV As New SucursalDAO
            sucursal = daoV.getSucursal(compra.sucursal)
            lblSucursal.Text = sucursal.nombre
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub
    Private Sub cargarCompra(ByVal flag As Integer)
        Try
            Dim daoC As New CompraDAO
            If flag = 1 Then

                compra = daoC.getCompra(listadoCompras.Item(compraActual))
            End If

            lblOTSeleccionada.Text = compra.id
            lblSucursal.Text = sucursal.nombre
            lblDeposito.Text = deposito.nombre
            txtFactuNro.Text = compra.factura
            txtObservacion.Text = compra.obs
            txtFecha.Text = compra.fecha
            If compra.estado = "C" Then
                lblEstado.Text = "Pagado"
            ElseIf compra.estado = "P" Then
                lblEstado.Text = "Pendiente"
            ElseIf compra.estado = "A" Then
                lblEstado.Text = "Anulado"
            End If

            If compra.credito = "S" Then
                lblTipoFactura.Text = "Crédito"
            Else
                lblTipoFactura.Text = "Contado"
            End If

            Dim daoProv As New ProveedorDAO
            proveedor = daoProv.getProveedor(compra.proveedor)
            lblClienteNombre.Text = proveedor.nombre
            lblClienteRuc.Text = proveedor.ruc
            lblClienteTel.Text = proveedor.telf
            calcularTotal(compra.total, compra.iva5, compra.iva10, compra.excenta)
            txtSaldo.Text = FormatCurrency(compra.saldo)
            Dim det = daoC.getDetalle(compra.id)
            dgvProductos.DataSource = det.Tables("tabla")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim anularF As New ComentarioAnularVenta
        Dim res = anularF.ShowDialog()
        If res = DialogResult.OK Then
            Dim result As Integer = MessageBox.Show("¿Anular la OT seleccionada?", "Eliminar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim daov As New CompraDAO
                daov.anularCompra(compra, anularF.anular)
                MsgBox("OT anulada", MsgBoxStyle.Information, "Anulación")
                limpiarCampos()
                btnAnular.Enabled = False
                dgvProductos.DataSource = New DataSet1.detalleCompraDataTable
            End If
        End If
        anularF.Dispose()
    End Sub

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        If dgvProductos.SelectedRows.Count > 0 Then

            For Each row As DataGridViewRow In dgvProductos.SelectedRows
                Dim restarSub = row.Cells("TotalCol").Value

                Dim monto = row.Cells("TotalCol").Value
                Dim ex = row.Cells("excentaCol").Value
                Dim iva5 = row.Cells(6).Value
                Dim iva10 = row.Cells(7).Value
                Dim tmp = CDbl(txtTotal.Text - monto)
                Dim tmp2 = CDbl(txtIva5.Text - iva5)
                Dim tmp3 = CDbl(txtIva10.Text - iva10)
                Dim tmp4 = CDbl(txtExentaT.Text - ex)

                txtTotal.Text = FormatCurrency(tmp)
                txtIva5.Text = FormatCurrency(tmp2)
                txtIva10.Text = FormatCurrency(tmp3)
                txtExentaT.Text = FormatCurrency(tmp4)
                If rbtnCont.Checked = True Then
                    txtSaldo.Text = FormatCurrency(0)
                Else
                    txtSaldo.Text = FormatCurrency(tmp)

                End If



                dgvProductos.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub txtExenta_TextChanged(sender As Object, e As EventArgs) Handles txtExenta.TextChanged
        Try
            If sender.Text <> "" Then

                txtExenta.Text = FormatCurrency(txtExenta.Text)
                txtExenta.Select(txtExenta.TextLength, 0)
            Else

                txtExenta.Text = FormatCurrency(0)
                txtExenta.Select(txtExenta.TextLength, 0)
            End If
        Catch ex As Exception
            txtExenta.Text = FormatCurrency(0)
            txtExenta.Select(txtExenta.TextLength, 0)
        End Try

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If listadoCompras.Count > 0 Then
            compraActual -= 1
            If compraActual = -1 Then
                compraActual = listadoCompras.Count - 1

            End If
            cargarCompra(1)
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btnPrim_Click(sender As Object, e As EventArgs) Handles btnPrim.Click
        If listadoCompras.Count > 0 Then
            compraActual = 0
            cargarCompra(1)
        End If
    End Sub

    Private Sub btnSgte_Click(sender As Object, e As EventArgs) Handles btnSgte.Click
        If listadoCompras.Count > 0 Then
            compraActual += 1
            If compraActual = listadoCompras.Count Then
                compraActual = 0
            End If
            cargarCompra(1)
        End If
    End Sub

    Private Sub btnUlt_Click(sender As Object, e As EventArgs) Handles btnUlt.Click
        If listadoCompras.Count > 0 Then
            compraActual = listadoCompras.Count - 1
            cargarCompra(1)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)

    End Sub
End Class