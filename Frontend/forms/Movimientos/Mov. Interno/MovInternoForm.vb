Imports Backend

Public Class MovInternoForm
    Dim sucursales As DataSet
    Dim depositos As DataSet
    Dim producto As Producto
    Dim stock As Integer
    Private Sub MovInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSucursales()
        txtFecha.Text = Date.Today
        Dim daoS As New SesionDAO
        lblAuto.Text = daoS.getUsuario()
        dgvProductos.DataSource = New DataSet1.detalleMIDataTable
    End Sub

    Private Sub cargarSucursales()
        Try
            Dim daoS As New SucursalDAO
            sucursales = daoS.getSucursalesCB()
            Dim lista = sucursales.Tables("tabla").Copy

            Dim lista2 = sucursales.Tables("tabla").Copy()
            Dim rowSol = lista.NewRow
            Dim rowDest = lista2.NewRow
            rowSol("Nombre") = "-- Seleccione Sucursal -- "
            rowSol("ID") = 0
            rowDest("Nombre") = "-- Seleccione Sucursal -- "
            rowDest("ID") = 0
            lista.Rows.InsertAt(rowSol, 0)
            lista2.Rows.InsertAt(rowDest, 0)
            cbS1.DataSource = lista
            cbS1.DisplayMember = "Nombre"
            cbS1.ValueMember = "ID"
            cbS2.DataSource = lista2
            cbS2.DisplayMember = "Nombre"
            cbS2.ValueMember = "ID"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub cargarDepositos1(ByVal id As Integer)
        Try
            If id <> 0 Then
                Dim daoD As New SucursalDAO
                depositos = daoD.getSucursalesDepositos(id)
                Dim lista = depositos.Tables("tabla").Copy
                Dim rowSol = lista.NewRow
                rowSol("Depósito") = "-- Seleccione Depósito -- "
                rowSol("IDD") = 0
                lista.Rows.InsertAt(rowSol, 0)
                cbDepo1.DataSource = lista
                cbDepo1.DisplayMember = "Depósito"
                cbDepo1.ValueMember = "IDD"
                cbDepo1.Enabled = True
            Else
                Dim lista = depositos.Tables("tabla").Clone
                Dim rowSol = lista.NewRow
                rowSol("Depósito") = "-- Seleccione una sucursal -- "
                rowSol("IDD") = 0
                lista.Rows.InsertAt(rowSol, 0)
                cbDepo1.DataSource = lista
                cbDepo1.DisplayMember = "Depósito"
                cbDepo1.ValueMember = "IDD"
                cbDepo1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargarDepositos2(ByVal id As Integer)
        Try
            If id <> 0 Then
                Dim daoD As New SucursalDAO
                depositos = daoD.getSucursalesDepositos(id)
                Dim lista = depositos.Tables("tabla").Copy
                Dim rowSol = lista.NewRow
                rowSol("Depósito") = "-- Seleccione Depósito -- "
                rowSol("IDD") = 0
                lista.Rows.InsertAt(rowSol, 0)
                cbDepo2.DataSource = lista
                cbDepo2.DisplayMember = "Depósito"
                cbDepo2.ValueMember = "IDD"
                cbDepo2.Enabled = True
            Else
                Dim lista = depositos.Tables("tabla").Clone
                Dim rowSol = lista.NewRow
                rowSol("Depósito") = "-- Seleccione una sucursal -- "
                rowSol("IDD") = 0
                lista.Rows.InsertAt(rowSol, 0)
                cbDepo2.DataSource = lista
                cbDepo2.DisplayMember = "Depósito"
                cbDepo2.ValueMember = "IDD"
                cbDepo2.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbS1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbS1.SelectedIndexChanged
        Try
            cargarDepositos1(cbS1.SelectedValue)
            If cbS1.SelectedValue = cbS2.SelectedValue Then
                cbS2.SelectedValue = 0
            End If
            limpiarCampos()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbS2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbS2.SelectedIndexChanged
        Try
            cargarDepositos2(cbS2.SelectedValue)
            If cbS1.SelectedValue = cbS2.SelectedValue Then
                cbS2.SelectedValue = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProd.KeyPress
        If validarCampos() Then
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                Dim daoP As New ProductoDAO
                Dim daoT As New TipoProdDAO
                producto = daoP.getProductoByCod(txtCodProd.Text)

                Dim tipoP = daoT.getTipo(producto.tipo)

                If producto.descripcion IsNot Nothing Then
                    lblDescPr.Text = producto.descripcion
                    lblCodigo.Text = producto.codigo
                    txtCodProd.Text = ""
                    txtCantidad.Enabled = True
                    stock = daoP.getStockSucursal(producto.id, cbS1.SelectedValue, cbDepo1.SelectedValue)
                    lblStock.Text = stock
                    stockReal()
                    txtCantidad.Focus()
                Else
                    Dim buscarP As New ProductoBusqueda
                    buscarP.filtro = txtCodProd.Text
                    Dim res = buscarP.ShowDialog()
                    If res = DialogResult.OK Then
                        producto = buscarP.producto
                        tipoP = daoT.getTipo(producto.tipo)
                        lblDescPr.Text = producto.descripcion
                        lblCodigo.Text = producto.codigo
                        txtCodProd.Text = ""
                        txtCantidad.Enabled = True
                        stock = daoP.getStockSucursal(producto.id, cbS1.SelectedValue, cbDepo1.SelectedValue)
                        lblStock.Text = stock
                        stockReal()
                        txtCantidad.Focus()

                    End If
                    buscarP.Dispose()
                End If

            End If
        End If

    End Sub


    Public Function validarCampos() As Boolean
        If cbS1.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar una sucursal de origen", MsgBoxStyle.Critical, "Faltan parámetros")
            Return False
        ElseIf cbDepo1.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un depósito de origen", MsgBoxStyle.Critical, "Faltan parámetros")
            Return False
        End If
        Return True
    End Function

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        soloNumeros(e)
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
                row("Mov") = 0
                row("ProdID") = producto.id
                row("Producto") = producto.descripcion
                row("Cantidad") = txtCantidad.Text
                row("Código") = producto.codigo

                row2.Rows.Add(row)
                dgvProductos.DataSource = row2
                dgvProductos.ClearSelection()
                lblStock.Text -= CInt(txtCantidad.Text)
            End If
        End If
    End Sub
    Private Function validarProducto() As Boolean
        If txtCantidad.Text = "" Then
            MsgBox("Ingrese un cantidad ", MsgBoxStyle.Critical, "Error de datos")
            txtCantidad.Focus()
            Return False
        ElseIf CInt(txtCantidad.TEXT) > CInt(lblStock.text) Then
            MsgBox("Cantidad ingresada supera al stock disponible ", MsgBoxStyle.Critical, "Error de datos")
            txtCantidad.Focus()
            Return False
        ElseIf CInt(lblStock.Text) = 0 Then
            MsgBox("No hay stock disponible para realizar movimiento de este producto", MsgBoxStyle.Critical, "Error de datos")
            txtCantidad.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        If dgvProductos.SelectedRows.Count > 0 Then

            For Each row As DataGridViewRow In dgvProductos.SelectedRows
                Dim produc = row.Cells("IDProdCol").Value

                If produc = producto.id Then
                    lblStock.Text = CInt(lblStock.Text) + row.Cells("CantidadCol").Value
                End If

                dgvProductos.Rows.Remove(row)
            Next
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
        lblStock.Text = CInt(lblStock.Text) - st
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarMovimiento() Then
            Try
                Dim mov As New MInterno
                mov.id = 0
                mov.obs = txtObservacion.Text
                mov.sdestino = cbS2.SelectedValue
                mov.sorigen = cbS1.SelectedValue
                mov.fecha = Date.Now
                mov.dorigen = cbDepo1.SelectedValue
                mov.ddestino = cbDepo2.SelectedValue
                mov.solicitante = txtSolicitante.Text
                Dim daoM As New MovInternoDAO

                Dim res = daoM.guardarMovimiento(mov, dgvProductos.Rows)

                If res <> 0 Then
                    MsgBox("Movimiento registrado", MsgBoxStyle.Information, "Éxito")
                End If
                limpiarCampos2()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub limpiarCampos()
        lblCodigo.Text = ""
        lblDescPr.Text = ""
        lblStock.Text = ""
        dgvProductos.DataSource = New DataSet1.detalleMIDataTable
    End Sub

    Private Sub limpiarCampos2()
        txtSolicitante.Text = ""
        lblCodigo.Text = ""
        lblDescPr.Text = ""
        lblStock.Text = ""
        dgvProductos.DataSource = New DataSet1.detalleMIDataTable
        cbS1.SelectedValue = 0
        cbS2.SelectedValue = 0
    End Sub
    Private Function validarMovimiento() As Boolean
        If cbS1.SelectedValue = cbS2.SelectedValue Then
            MsgBox("La sucursal de destino es igual a la de origen", MsgBoxStyle.Critical, "Error de datos")
            Return False
        ElseIf cbS2.SelectedValue = 0 Then
            MsgBox("Seleccione una sucursal de destino", MsgBoxStyle.Critical, "Error de datos")
            cbS2.Focus()
            Return False
        ElseIf cbDepo2.SelectedValue = 0 Then
            MsgBox("Seleccione un depósito de destino", MsgBoxStyle.Critical, "Error de datos")
            cbDepo2.Focus()
            Return False
        ElseIf dgvProductos.Rows.Count = 0 Then
            MsgBox("Debe agregar al menos un producto al movimiento", MsgBoxStyle.Critical, "Error de datos")
            txtCodProd.Focus()
            Return False
        ElseIf txtSolicitante.Text = "" Then
            MsgBox("Ingrese un solicitante para el registro", MsgBoxStyle.Critical, "Error de datos")
            txtSolicitante.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos2()
    End Sub

    Private Sub txtSolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSolicitante.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtObservacion.Focus()
        End If
    End Sub

    Private Sub cbDepo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepo2.SelectedIndexChanged
        If cbDepo2.SelectedIndex <> 0 Then
            txtCodProd.Focus()
        End If
    End Sub

    Private Sub txtObservacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObservacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCodProd.Focus()
        End If
    End Sub
End Class