Imports Backend

Public Class BuscarProveedor
    Public filtro As String
    Public proveedor As New Proveedor
    Dim list As New DataSet
    Private Sub ClienteBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProveedores()
        aplicarFiltro()
        dgvProveedor.Focus()
    End Sub

    Private Sub cargarProveedores()
        Dim daoC As New ProveedorDAO
        Dim res = daoC.getProveedores()
        list = res
    End Sub

    Private Sub aplicarFiltro()
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Nombre like '%{0}%' or RUC like '%{0}%' ", txtFiltro.Text)
        dgvProveedor.DataSource = dv
        'dgvClientes.ClearSelection()
    End Sub

    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProveedor.KeyDown
        Try
            If dgvProveedor.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Dim row = dgvProveedor.CurrentRow.Index
                    Dim codigo = dgvProveedor.Item(0, row).Value
                    Dim daoC As New ProveedorDAO

                    proveedor = daoC.getProveedor(codigo)
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
            dgvProveedor.Focus()
        End If
    End Sub
End Class