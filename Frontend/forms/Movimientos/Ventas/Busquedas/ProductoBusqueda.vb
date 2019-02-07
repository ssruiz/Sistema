Imports Backend

Public Class ProductoBusqueda
    Public filtro As String
    Public producto As New Producto
    Dim list As New DataSet
    Private Sub ClienteBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProductos()
        aplicarFiltro()
    End Sub

    Private Sub cargarProductos()
        Dim daoC As New ProductoDAO
        Dim res = daoC.getProductos()
        list = res
    End Sub

    Private Sub aplicarFiltro()
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Código like '%{0}%' or Descripción like '%{0}%' or Tipo like '%{0}%' ", txtFiltro.Text)
        dgvProductos.DataSource = dv
        'dgvProductos.ClearSelection()
    End Sub
    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProductos.KeyDown
        Try
            If dgvProductos.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Dim row = dgvProductos.CurrentRow.Index
                    Dim codigo = dgvProductos.Item(0, row).Value
                    Dim daoC As New ProductoDAO
                    producto = daoC.getProducto(codigo)
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
End Class