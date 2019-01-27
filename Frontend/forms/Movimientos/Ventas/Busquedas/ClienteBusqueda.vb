Imports Backend

Public Class ClienteBusqueda
    Public filtro As String
    Public cliente As New Cliente
    Dim list As New DataSet
    Private Sub ClienteBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarClientes()
        aplicarFiltro()
    End Sub

    Private Sub cargarClientes()
        Dim daoC As New ClienteDAO
        Dim res = daoC.getClientes()
        list = res
    End Sub

    Private Sub aplicarFiltro()
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Nombre like '%{0}%' or CI like '%{0}%' ", txtFiltro.Text)
        dgvClientes.DataSource = dv
        dgvClientes.ClearSelection()
    End Sub
    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvClientes.KeyDown
        Try
            If dgvClientes.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Dim row = dgvClientes.CurrentRow.Index
                    Dim codigo = dgvClientes.Item(0, row).Value
                    Dim daoC As New ClienteDAO
                    cliente = daoC.getCliente(codigo)
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