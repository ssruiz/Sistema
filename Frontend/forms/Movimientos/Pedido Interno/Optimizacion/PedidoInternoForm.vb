Imports Backend

Public Class PedidoInternoForm
    Dim producto As New Producto
    Dim stock = 0
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProd.KeyPress
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

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label10.Click

    End Sub


End Class