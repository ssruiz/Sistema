Imports Backend

Public Class VentaBusqueda
    Public codigoCliente As String
    Public estadoFiltro As String
    Dim list As New DataSet
    Public venta As String

    Private Sub cargarVentasCliente()
        Try
            Dim daoV As New VentaDAO
            list = daoV.ventasCliente(codigoCliente)
            dgvVentas.DataSource = list.Tables("tabla")
            dgvVentas.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub aplicarFiltro()
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Factura like '%{0}%'", txtFiltro.Text)
        dgvVentas.DataSource = dv
        'dgvVendedores.ClearSelection()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chAnulado.CheckedChanged
        If chAnulado.Checked Then
            estadoFiltro = "Anulado"
        End If
    End Sub

    Private Sub chCobrado_CheckedChanged(sender As Object, e As EventArgs) Handles chCobrado.CheckedChanged
        If chCobrado.Checked Then
            estadoFiltro = "Cobrado"
        End If
    End Sub

    Private Sub chDevuelto_CheckedChanged(sender As Object, e As EventArgs) Handles chDevuelto.CheckedChanged
        If chDevuelto.Checked Then
            estadoFiltro = "Devuelto"
        End If
    End Sub

    Private Sub chPendiente_CheckedChanged(sender As Object, e As EventArgs) Handles chPendiente.CheckedChanged
        If chPendiente.Checked Then
            estadoFiltro = "Pendiente"
        End If
    End Sub

    Private Sub dgvVendedores_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvVentas.KeyDown
        Try
            If dgvVentas.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Dim row = dgvVentas.CurrentRow.Index
                    Dim codigo = dgvVentas.Item(0, row).Value

                    venta = codigo
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        aplicarFiltro()
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvVentas.Rows(0).Selected = True

            dgvVentas.Focus()
        End If
    End Sub

    Private Sub VentaBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarVentasCliente()
        'txtFiltro.Focus()
        'dgvVentas.Focus()
    End Sub

    Private Sub VentaBusqueda_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtFiltro.Focus()
    End Sub
End Class