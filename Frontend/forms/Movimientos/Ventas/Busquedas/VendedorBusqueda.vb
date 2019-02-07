Imports Backend

Public Class VendedorBusqueda
    Public filtro As String
    Public vendedor As New Vendedor
    Dim list As New DataSet
    Private Sub ClienteBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarVendedores()
        aplicarFiltro()
    End Sub

    Private Sub cargarVendedores()
        Dim daoC As New VendedorDAO
        Dim res = daoC.getVendedores()
        list = res
    End Sub

    Private Sub aplicarFiltro()
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Nombre like '%{0}%' or Celular like '%{0}%' ", txtFiltro.Text)
        dgvVendedores.DataSource = dv
        'dgvVendedores.ClearSelection()
    End Sub
    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvVendedores.KeyDown
        Try
            If dgvVendedores.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Dim row = dgvVendedores.CurrentRow.Index
                    Dim codigo = dgvVendedores.Item(0, row).Value
                    Dim daoC As New VendedorDAO
                    vendedor = daoC.getVendedor(codigo)
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