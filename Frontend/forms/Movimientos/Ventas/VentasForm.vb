Imports Backend

Public Class VentasForm
    Dim listClientes As New DataTable
    Dim cliente As New Cliente
    Dim producto As New Producto
    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Date.Today
        lblProducto.Text = ""
        rbtnNo.Checked = True
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        'Dim btnImageIco As New Bitmap(New Bitmap(My.Resources.izquierda_icono), 35, 35)
        'btnAnterior.Image = btnImageIco
        'btnAnterior.ImageAlign = ContentAlignment.MiddleCenter
        'Dim btnImageIco2 As New Bitmap(New Bitmap(My.Resources.derecha_icon), 35, 35)
        'btnSgte.Image = btnImageIco2
        'btnSgte.ImageAlign = ContentAlignment.MiddleCenter

        'btnImageIco2 = New Bitmap(New Bitmap(My.Resources.primer_icon), 35, 35)
        'btnUlt.Image = btnImageIco2
        'btnUlt.ImageAlign = ContentAlignment.MiddleCenter

        'btnImageIco2 = New Bitmap(New Bitmap(My.Resources.abajo_icon), 35, 35)
        'btnPrim.Image = btnImageIco2
        'btnPrim.ImageAlign = ContentAlignment.MiddleCenter
    End Sub


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
                lblClienteTel.Text = cliente.nombre
                txtCliente.Text = ""
            End If
            buscarC.Dispose()
        End If
    End Sub

    Private Sub rbtnSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSi.CheckedChanged
        If rbtnSi.Checked Then
            pnlEntrega1.Enabled = True
            pnlEntrega2.Enabled = True
            pnldDir.Enabled = True
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
            Else
                Dim buscarP As New ProductoBusqueda
                buscarP.filtro = txtCodProd.Text
                Dim res = buscarP.ShowDialog()
                If res = DialogResult.OK Then
                    producto = buscarP.producto
                    lblProducto.Text = producto.descripcion
                    txtCodProd.Text = ""
                    activarMedidas(producto.tipo)
                End If
                buscarP.Dispose()
            End If
        End If
    End Sub

    Private Sub activarMedidas(ByVal tipo As Integer)
        Dim daoT As New TipoProdDAO
        Dim tipoP = daoT.getTipo(tipo)
        If tipoP.nombre = "plancha" Then

        End If
    End Sub

    Private Sub txtDirEnvio_TextChanged(sender As Object, e As EventArgs) Handles txtDirEnvio.TextChanged

    End Sub

    ' Nueva venta
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        If cliente.nombre <> "" Then
            activarCampos()
            limpiarCampos()
            txtNroOrden.Focus()
        Else
            MsgBox("Seleccione un cliente", MsgBoxStyle.Critical, "Notificación")
            txtCliente.Focus()
        End If
    End Sub

    Private Sub activarCampos()
        txtNroOrden.Enabled = True
        txtFactuNro.Enabled = True
        txtVendedor.Enabled = True
        txtObservacion.Enabled = True
    End Sub

    Private Sub limpiarCampos()
        txtNroOrden.Text = ""
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
        txtFecha1.Text = ""
        txtFecha2.Text = ""
        txtPlazo1.Text = ""
        txtPlazo2.Text = ""
        txtFecha.Text = Date.Today
        txtDirEnvio.Text = ""
    End Sub
End Class