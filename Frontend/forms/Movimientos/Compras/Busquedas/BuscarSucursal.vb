Imports Backend

Public Class BuscarSucursal
    Public filtro As String
    Public sucursal As New Sucursal
    Dim list As New DataSet
    Private Sub ClienteBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSucursales()
        aplicarFiltro()
        dgvSucursales.Focus()
    End Sub

    Private Sub cargarSucursales()
        Dim daoC As New SucursalDAO
        Dim res = daoC.getSucursales()
        list = res
    End Sub

    Private Sub aplicarFiltro()
        Dim dv As New DataView(list.Tables("tabla"))
        dv.RowFilter = String.Format("Nombre like '%{0}%' ", txtFiltro.Text)
        dgvSucursales.DataSource = dv
        'dgvClientes.ClearSelection()
    End Sub

    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSucursales.KeyDown
        Try
            If dgvSucursales.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Dim row = dgvSucursales.CurrentRow.Index
                    Dim codigo = dgvSucursales.Item(0, row).Value
                    Dim daoC As New SucursalDAO


                    sucursal = daoC.getSucursal(codigo)
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
            dgvSucursales.Focus()
        End If
    End Sub
End Class