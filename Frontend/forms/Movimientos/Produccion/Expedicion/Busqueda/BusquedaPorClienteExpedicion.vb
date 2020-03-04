Imports Backend

Public Class BusquedaPorClienteExpedicion
    Dim clienteBusqueda As New Cliente
    Dim ventaSel = 0
    Dim inicial = 0
    Private Sub BusquedaPorClienteExpedicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '' BUSQUEDA POR CLIENTES
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusquedaPorCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim buscarC As New ClienteBusqueda
            Dim res = buscarC.ShowDialog()

            If res = DialogResult.OK Then
                clienteBusqueda = buscarC.cliente
                Dim daov As New VentaDAO
                Dim tab = daov.getVentasCliente(clienteBusqueda.id)
                dgvVentasPorCliente.DataSource = tab.Tables("tabla")
                dgvVentasPorCliente.ClearSelection()


            End If
            buscarC.Dispose()
        End If
    End Sub

    Private Sub dgvVentasPorCliente_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVentasPorCliente.SelectionChanged
        If dgvVentasPorCliente.Focused And dgvVentasPorCliente.SelectedRows.Count > 0 Then
            Try

                Dim row = dgvVentasPorCliente.CurrentRow
                Dim codigo = row.Cells(1).Value

                Dim daoP As New VentaDAO
                Dim producto = daoP.getDetalleBusquedaVentas(codigo)
                dgvDetalleVentaCliente.DataSource = producto.Tables("tabla")
                dgvDetalleVentaCliente.ClearSelection()

                dgvDetalleVentaCliente.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub dgvVentasPorFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvVentasPorCliente.KeyDown
        Try
            If sender.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Dim row = sender.CurrentRow
                    Dim codigo = row.Cells(1).Value
                    ventaSel = codigo
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class