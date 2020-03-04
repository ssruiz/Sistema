Imports Backend

Public Class AnularFacturaForm
    Dim venta As New Venta
    Dim cliente As New Cliente
    Private Sub txtOT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOT.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' pnlEnvioNuevo.Visible = False
            'pnlTipoVentaMoneda.Visible = False
            e.SuppressKeyPress = True
            Dim daoP As New VentaDAO
            Dim ventaAux = daoP.getVenta(txtOT.Text)
            If ventaAux.id <> 0 Then
                venta = ventaAux
                lblResult.Text = "OT sin factura actualmente."
                lblResult.BackColor = Color.Red
                lblResult.Visible = False
                ''lblTipoFactura.Visible = True
                ''txtFactuNro.Enabled = False
                ''txtObservacion.Enabled = False
                'txtCodProd.Enabled = False
                'txtCantidad.Enabled = False
                'txtAncho.Enabled = False
                'txtAlto.Enabled = False
                'txtObra.Enabled = False
                'txtDescuento.Enabled = False
                'txtRecargo.Enabled = False


                cargarVentaOT(txtOT.Text)
                cargarAnulaciones()
                ' btnAnular.Enabled = True
                ' btnModificar.Enabled = True
                'btnImprimir.Visible = True
                'lblTipoPago.Visible = False
                'cbTipodePago.Visible = False

                'lblEstado.Visible = True
                'Label26.Visible = True

            End If
        End If
    End Sub

    Private Sub cargarVentaOT(ByVal vent As String)
        Try
            Dim daoV As New VentaDAO


            lblFechaVenta.Text = venta.fecha
            lblFactura.Text = venta.factura

            Dim tmp = CDbl(venta.total) '- venta.descuento + venta.recargo
            lblOTSeleccionada.Text = venta.id
            lblSupTotalOT.Text = Math.Round(Venta.m2, 2)
            cargarCliente()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarCliente()
        Try
            Dim daoC As New ClienteDAO
            Cliente = daoC.getCliente(venta.cliente)
            lblClienteNombre.Text = Cliente.nombre
            lblClienteRuc.Text = Cliente.ruc
            lblClienteTel.Text = Cliente.cel
            asignarVendedor()
            asignarSucursal()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOT.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub asignarVendedor()
        Try
            Dim daoV As New VendedorDAO
            Dim Vendedor = daoV.getVendedor(cliente.vendedor)
            lblVendedor.Text = Vendedor.nombre

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub

    Private Sub asignarSucursal()
        Try
            Dim daoV As New SucursalDAO
            Dim Sucursal = daoV.getSucursal(cliente.sucursal)
            lblSucursal.Text = Sucursal.nombre
            Dim daoV2 As New DepositoDAO
            Dim Deposito = daoV2.getDeposito(Sucursal.deposito)
            lblDeposito.Text = Deposito.nombre
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Asignar Vendedor - Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If venta.id <> 0 Then
            If venta.factura = "" Then
                lblResult.Text = "OT sin factura actualmente."
                lblResult.BackColor = Color.Red
                lblResult.Visible = True
                Exit Sub
            End If

            Dim anularF As New AnularFacturaComentario
            Dim res = anularF.ShowDialog()
            If res = DialogResult.OK Then
                Dim pagd As New VentaDAO
                pagd.anularFactura(venta.id, venta.factura, anularF.anular)
                lblResult.Text = "Factura Anulada correctamente."
                lblResult.BackColor = Color.Green
                lblResult.Visible = True
                cargarVentaOT(venta.id)
                txtOT.Focus()
            End If

        End If
    End Sub

    Private Sub AnularFacturaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        Dim classResize As New ClsResizeForm
        classResize.ResizeForm(Me, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        ' Me.WindowState = FormWindowState.Maximized
        Me.ResumeLayout()
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        Me.Show()
        ' cargarAnulaciones()
        txtOT.Focus()
    End Sub

    Private Sub cargarAnulaciones()
        Try
            Dim ven As New VentaDAO
            Dim r = ven.cargarAnulacionesFactura(venta.id)
            dgvAnulaciones.DataSource = r.Tables("tabla")
            dgvAnulaciones.ClearSelection()

        Catch ex As Exception

        End Try
    End Sub
End Class