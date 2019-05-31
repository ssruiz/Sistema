Public Class AgregarPlanos
    Dim nombrePlano = ""
    Public planos As New DataTable
    Private Sub btnSubirPlano_Click(sender As Object, e As EventArgs) Handles btnSubirPlano.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            pbPlano.Image = Image.FromFile(file.FileName)
            nombrePlano = file.FileName
            pbPlano.SizeMode = PictureBoxSizeMode.Zoom
        End If
        file.Dispose()
    End Sub

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim row2 As DataTable = dgvPlanos.DataSource
            Dim row As DataRow = row2.NewRow
            row("ID") = 0
            row("Nombre") = nombrePlano
            row("Fecha") = Date.Today
            row("Venta") = 0


            row2.Rows.Add(row)
            dgvPlanos.DataSource = row2
            'dgvProductos.Rows.Add(row)
            dgvPlanos.ClearSelection()
            planos = dgvPlanos.DataSource
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarPlanos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPlanos.DataSource = New DataSet1.planosDetalleDataTable
    End Sub

    Private Sub btnEliminarProd_Click_1(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        If dgvPlanos.SelectedRows.Count > 0 Then

            For Each row As DataGridViewRow In dgvPlanos.SelectedRows
                dgvPlanos.Rows.Remove(row)
            Next
        End If
    End Sub
End Class