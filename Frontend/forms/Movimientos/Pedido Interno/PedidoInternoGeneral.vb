Imports Backend

Public Class PedidoInternoGeneral
    Dim producto As New Producto
    Dim stock = 0
    Dim venta As New Venta
    Private Sub PedidoInternoGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        Dim classResize As New ClsResizeForm
        classResize.ResizeForm(Me, 1273, 895)
        Me.WindowState = FormWindowState.Maximized
        Me.ResumeLayout()
        Me.Show()
        controlarNivel()
        cargarPedidos()
        ' Pedido Interno
        'tabControlPago.TabPages.Remove(tabControlPago.TabPages(0))
        dgvPage2.DataSource = New DataSetPedidoInterno.PedidoInternoDataTable
    End Sub

    Public Sub controlarNivel()
        Try
            Dim daou As New SesionDAO
            Dim niv = daou.getNivel()
            If niv = 3 Then


            ElseIf niv = 2 Then

            ElseIf niv = 3 Then

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub tabControlPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlPago.SelectedIndexChanged
        If tabControlPago.SelectedTab.Name = "tabPagePedidoInterno" Then
            'MsgBox(tabControlPago.SelectedIndex)
            cbProvP2.SelectedIndex = 0
            cbAutoP2.SelectedIndex = 0
            cbSoliPage2.SelectedIndex = 0
        ElseIf tabControlPago.SelectedTab.Name = "tabPageInicio" Then
            cargarPedidos()
        ElseIf tabControlPago.SelectedTab.Name = "tabPageAutorizar" Then
            Dim r = cargarPedidosEstado("GENERADO")
            dgvAutorizarPage.DataSource = r.Tables("tabla")
            dgvAutorizarPage.ClearSelection()
            dgvDetalleAutorizar.DataSource = ""
        ElseIf tabControlPago.SelectedTab.Name = "tabPageAnulacion" Then
            Dim r = cargarPedidosEstado("GENERADO")
            dgvAnulacion.DataSource = r.Tables("tabla")
            dgvAnulacion.ClearSelection()
            dgvDetalleAnulacion.DataSource = ""
        ElseIf tabControlPago.SelectedTab.Name = "tabPageDeposito" Then
            Dim r = cargarPedidosEstado("AUTORIZADO")
            dgvSalidas.DataSource = r.Tables("tabla")
            dgvSalidas.ClearSelection()

        End If
    End Sub


    Private Function cargarPedidosEstado(ByVal estado As String) As DataSet
        Dim r As New DataSet
        Try
            Dim pedd As New PedidoInternoDAO
            r = pedd.getPedidosEstado(estado)
        Catch ex As Exception

        End Try
        Return r
    End Function
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


    '' TAB INICIO
    Private Sub cargarPedidos()
        Dim daop As New PedidoInternoDAO
        Dim r = daop.getPedidos()
        dgvPedidosEstado.DataSource = r.Tables("tabla")
        dgvPedidosEstado.ClearSelection()
        dgvPedidosDetalle.DataSource = ""
    End Sub

    Private Sub dgvPedidosEstado_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPedidosEstado.SelectionChanged
        If dgvPedidosEstado.Focused And dgvPedidosEstado.SelectedRows.Count > 0 Then
            Try
                'btnGuardar.Enabled = False
                'btnModificar.Enabled = True
                Dim row = dgvPedidosEstado.CurrentRow.Index
                Dim codigo = dgvPedidosEstado.Item(0, row).Value
                Dim daoP As New PedidoInternoDAO
                Dim produc = daoP.getDetallePedido(codigo)
                dgvPedidosDetalle.DataSource = produc.Tables("tabla")
                'lblAlto.Text = Math.Round(produc.alto, 0)
                'lblAncho.Text = Math.Round(produc.ancho, 0)
                'lblSupProd.Text = Math.Round(produc.sup, 2)
                'cargarProducto(producto)
                'desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    '' --------------------TAB NUEVO PEDIDO ---------------------------------------------------------------------------------------
    Private Sub txtCodProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim daoP As New ProductoDAO
            Dim daoT As New TipoProdDAO
            producto = daoP.getProductoByCod(txtCodProd.Text)

            Dim tipoP = daoT.getTipo(producto.tipo)
            'If templado2 = True And (tipoP.nombre = "perfiles" Or tipoP.nombre = "herrajes" Or tipoP.nombre = "planchas") Then
            '    MsgBox("Solo puede agregar templados", MsgBoxStyle.Critical, "Tipo producto")
            '    Exit Sub
            'ElseIf porUnidad = 1 And tipoP.nombre = "templado" Then
            '    MsgBox("No puede agregar templados. Solo productos que se venden por cantidad", MsgBoxStyle.Critical, "Tipo producto")
            '    Exit Sub
            'End If

            If producto.descripcion IsNot Nothing Then
                stock = daoP.getStockSucursal(producto.id, 4, 7)
                lblStockDisp.Text = stock
                lblDesc.Text = producto.descripcion
                txtCodProd.Text = producto.codigo.ToUpper
                lblCodProd.Text = producto.codigo

                'activarMedidas(producto.tipo)
                'asignarPrecio()
                'txtDescuento.Text = 0
                'txtRecargo.Text = 0
                'If porUnidad = 1 Then
                '    stockReal()
                'End If
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
                    stock = daoP.getStockSucursal(producto.id, 4, 7)
                    lblStockDisp.Text = stock

                    'If templado2 = True And (tipoP.nombre = "perfiles" Or tipoP.nombre = "herrajes" Or tipoP.nombre = "planchas") Then
                    '    MsgBox("Solo puede agregar templados", MsgBoxStyle.Critical, "Tipo producto")
                    '    Exit Sub
                    'ElseIf porUnidad = 1 And tipoP.nombre = "templado" Then
                    '    MsgBox("No puede agregar templados. Solo productos que se venden por cantidad", MsgBoxStyle.Critical, "Tipo producto")
                    '    Exit Sub
                    'End If

                    lblDesc.Text = producto.descripcion
                    lblCodProd.Text = producto.codigo
                    txtCodProd.Text = producto.codigo.ToUpper
                    'activarMedidas(producto.tipo)
                    'asignarPrecio()
                    'txtDescuento.Text = "0"
                    'txtRecargo.Text = "0"
                    txtCantidad.Text = 1
                    txtCantidad.Focus()
                    txtCantidad.SelectAll()
                    'If porUnidad = 1 Then
                    '    stockReal()
                    'End If
                End If
                buscarP.Dispose()

            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtNroOpti.Focus()
        End If
    End Sub

    Private Sub txtNroOpti_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroOpti.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtOt.Focus()
        End If
    End Sub

    Private Sub btnPrim_Click(sender As Object, e As EventArgs) Handles btnAgregarOt.Click
        Dim daoP As New VentaDAO
        Dim ventaAux = daoP.getVenta(txtOt.Text)
        If ventaAux.id <> 0 Then
            Dim row2 As DataTable = dgvPage2.DataSource
            Dim row As DataRow = row2.NewRow

            Dim lin = dgvPage2.Rows.Count()
            row(0) = lin + 1
            row(1) = producto.codigo
            row(2) = producto.descripcion
            row(3) = ventaAux.id
            row(4) = ventaAux.cliente
            Dim daoc As New ClienteDAO
            Dim cliente = daoc.getCliente(ventaAux.cliente)

            row(5) = cliente.nombre
            row2.Rows.Add(row)
            dgvPage2.DataSource = row2
            'lblTipoFactura.Visible = True
            'txtFactuNro.Enabled = False
            'txtObservacion.Enabled = False
            'txtCodProd.Enabled = False
            'txtCantidad.Enabled = False
            'txtAncho.Enabled = False
            'txtAlto.Enabled = False
            'txtObra.Enabled = False
            'txtDescuento.Enabled = False
            'txtRecargo.Enabled = False

            'cargarVentaOT(txtOt.Text)
            'btnAnular.Enabled = True
            'btnModificar.Enabled = True
            'btnImprimir.Visible = True
            'lblTipoPago.Visible = False
            'cbTipodePago.Visible = False

            'lblEstado.Visible = True
            'Label26.Visible = True
        Else
        End If
    End Sub

    Private Sub txtOt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' pnlEnvioNuevo.Visible = False
            'pnlTipoVentaMoneda.Visible = False
            'MsgBox(cbSoliPage2.SelectedItem)
            e.SuppressKeyPress = True
            btnAgregarOt.PerformClick()
        End If
    End Sub



    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        Try
            If dgvPage2.SelectedRows.Count > 0 Then

                For Each row22 As DataGridViewRow In dgvPage2.SelectedRows



                    dgvPage2.Rows.Remove(row22)
                    'linea = linea - 1
                    'lblLinea.Text = linea
                Next
                Dim lin = 1
                Dim row2 As DataTable = dgvPage2.DataSource
                Dim row As DataRow = row2.NewRow
                For Each row3 As DataRow In row2.Rows
                    row3(0) = lin
                    lin += 1
                Next
                dgvPage2.DataSource = row2
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validarPedido() Then
            Dim ped As New PedidoInterno
            ped.cantidad = txtCantidad.Text
            ped.auto = cbAutoP2.SelectedItem
            ped.soli = cbSoliPage2.SelectedItem
            ped.prodCod = producto.id
            ped.prov = 4
            ped.opti = txtNroOpti.Text
            ped.fecha = Date.Today
            ped.depo = 7
            Dim daop As New PedidoInternoDAO
            daop.guardarPedido(ped, dgvPage2.Rows)
            MsgBox("Pedido Guardado", MsgBoxStyle.Information, "Éxito")
            limpiarPage2()
        End If
    End Sub

    Private Sub limpiarPage2()
        txtCodProd.Text = ""
        lblCodProd.Text = ""
        lblDesc.Text = ""
        lblStockDisp.Text = ""
        txtCantidad.Text = ""
        txtNroOpti.Text = ""
        txtOt.Text = ""
        dgvPage2.DataSource = New DataSetPedidoInterno.PedidoInternoDataTable
        txtCodProd.Focus()
    End Sub
    Private Function validarPedido() As Boolean
        If producto.id = 0 Then
            MsgBox("Seleccione un producto para el pedido", MsgBoxStyle.Critical, "Producto")
            txtCodProd.Focus()
            Return False
        ElseIf txtCantidad.Text = "" Then
            MsgBox("Ingrese una cantidad para el pedido", MsgBoxStyle.Critical, "Producto")
            txtCantidad.Focus()
            Return False
        ElseIf dgvPage2.Rows.Count = 0 Then
            MsgBox("Ingrese detalle para el pedido", MsgBoxStyle.Critical, "OT")
            txtOt.Focus()
            Return False
        ElseIf txtNroOpti.Text = "" Then
            MsgBox("Ingrese Nro. Optimización para el pedido", MsgBoxStyle.Critical, "OT")
            txtNroOpti.Focus()
            Return False
        End If
        Return True
    End Function

    '' AUTORIZAR PEDIDO
    Private Sub dgvAutorizarPage_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAutorizarPage.SelectionChanged
        If dgvAutorizarPage.Focused And dgvAutorizarPage.SelectedRows.Count > 0 Then
            Try
                'btnGuardar.Enabled = False
                'btnModificar.Enabled = True
                Dim row = dgvAutorizarPage.CurrentRow.Index
                Dim codigo = dgvAutorizarPage.Item(0, row).Value
                Dim daoP As New PedidoInternoDAO
                Dim produc = daoP.getDetallePedido(codigo)
                dgvDetalleAutorizar.DataSource = produc.Tables("tabla")
                dgvDetalleAutorizar.ClearSelection()
                'lblAlto.Text = Math.Round(produc.alto, 0)
                'lblAncho.Text = Math.Round(produc.ancho, 0)
                'lblSupProd.Text = Math.Round(produc.sup, 2)
                'cargarProducto(producto)
                'desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnAutorizar_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        Try
            If dgvAutorizarPage.SelectedRows.Count > 0 Then
                Dim row = dgvAutorizarPage.CurrentRow.Index
                Dim codigo = dgvAutorizarPage.Item(0, row).Value
                Dim daop As New PedidoInternoDAO
                daop.autorizar(codigo)
                MsgBox("Pedido Atuorizado", MsgBoxStyle.Information, "Autorización")
                Dim r = cargarPedidosEstado("GENERADO")
                dgvAutorizarPage.DataSource = r.Tables("tabla")
                dgvAutorizarPage.ClearSelection()
                dgvDetalleAutorizar.DataSource = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvAnulacion_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAnulacion.SelectionChanged
        If dgvAnulacion.Focused And dgvAnulacion.SelectedRows.Count > 0 Then
            Try
                'btnGuardar.Enabled = False
                'btnModificar.Enabled = True
                Dim row = dgvAnulacion.CurrentRow.Index
                Dim codigo = dgvAnulacion.Item(0, row).Value
                Dim daoP As New PedidoInternoDAO
                Dim produc = daoP.getDetallePedido(codigo)
                dgvDetalleAnulacion.DataSource = produc.Tables("tabla")
                dgvDetalleAnulacion.ClearSelection()
                'lblAlto.Text = Math.Round(produc.alto, 0)
                'lblAncho.Text = Math.Round(produc.ancho, 0)
                'lblSupProd.Text = Math.Round(produc.sup, 2)
                'cargarProducto(producto)
                'desactivarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If dgvAnulacion.SelectedRows.Count > 0 Then
                Dim row = dgvAnulacion.CurrentRow.Index
                Dim codigo = dgvAnulacion.Item(0, row).Value
                Dim daop As New PedidoInternoDAO
                daop.anular(codigo)
                MsgBox("Pedido Anulado", MsgBoxStyle.Information, "Anulación")
                Dim r = cargarPedidosEstado("GENERADO")
                dgvAnulacion.DataSource = r.Tables("tabla")
                dgvAnulacion.ClearSelection()
                dgvDetalleAnulacion.DataSource = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If dgvSalidas.SelectedRows.Count > 0 Then
                Dim row = dgvSalidas.CurrentRow.Index
                Dim codigo = dgvSalidas.Item(0, row).Value
                Dim daop As New PedidoInternoDAO
                daop.darSalida(codigo)
                MsgBox("Salida Registrada", MsgBoxStyle.Information, "Salida")
                Dim r = cargarPedidosEstado("AUTORIZADO")
                dgvSalidas.DataSource = r.Tables("tabla")
                dgvSalidas.ClearSelection()
                dgvSalidas.DataSource = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim objreporte As New CRInformeSalidasPI
            objreporte.SetParameterValue("desde", dpDesdeInforme.Value)
            objreporte.SetParameterValue("hasta", dpHastaInforme.Value)

            Dim daou As New SesionDAO

            objreporte.SetParameterValue("usuario", daou.getUsuario())

            crvSalidas.ReportSource = objreporte

        Catch ex As Exception

        End Try
    End Sub
End Class