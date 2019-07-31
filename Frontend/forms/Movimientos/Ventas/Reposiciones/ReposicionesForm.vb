Imports Backend

Public Class ReposicionesForm
    Dim producc As New CargaProduccion
    Dim productoP As New Producto
    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtNroProd.Text <> "" Then
                Dim daov As New ReposicionesDAO
                producc = daov.getProduccion(txtNroProd.Text)
                Dim daop As New ProductoDAO
                productoP = daop.getProducto(producc.codProd)
                cargarProduccion()
                Dim r = daov.cargarListado(txtNroProd.Text)
                dgvReposiciones.DataSource = r.Tables("tabla")
                btnGuardar.Enabled = True
                dgvReposiciones.ClearSelection()
            End If
        End If
    End Sub

    Private Sub cargarProduccion()
        txtAlto.Text = producc.alto
        txtAncho.Text = producc.ancho
        txtPanho.Text = producc.panho
        txtProducto.Text = productoP.descripcion
        txtSup.Text = producc.sup
        txtCliente.Text = producc.cliente
        txtCliCod.Text = producc.cliCod
        txtOpCod.Text = producc.opCod
        txtOpDesc.Text = producc.opDesc
        txtFecha.Text = producc.fechaOt
        txtOT.Text = producc.venta
    End Sub
    Private Sub ReposicionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvReposiciones.DataSource = New DataSet1.listadoReposicionesDataTable
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As Integer = MessageBox.Show("¿Guardar reposición?", "Guardar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim daor As New ReposicionesDAO
                daor.guardarReposicion(txtOT.Text, txtMotCod.Text, producc.idProd)
                MsgBox("Reposición guardad", MsgBoxStyle.Information, "Notificación")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class