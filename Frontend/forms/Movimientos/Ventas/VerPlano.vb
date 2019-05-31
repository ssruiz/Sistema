Public Class VerPlano
    Public ruta As String
    Public planos As DataTable
    Private Sub VerPlano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPlanos.DataSource = New DataSet1.planosDetalleDataTable
        dgvPlanos.DataSource = planos
        dgvPlanos.ClearSelection()
    End Sub

    Private Sub dgvPlanos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPlanos.SelectionChanged
        If dgvPlanos.Focused And dgvPlanos.SelectedRows.Count > 0 Then
            Try
                Dim row = dgvPlanos.CurrentRow.Index
                Dim dirImg = dgvPlanos.Item(2, row).Value
                Dim newImage As Image = Image.FromFile(dirImg)
                planoSeleccionado.Image = newImage
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class