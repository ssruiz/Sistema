Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim lg As New login
        lg.Show()
    End Sub

    Private Sub ColoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoresToolStripMenuItem.Click
        Dim color As New ColorForm
        color.ShowDialog()
        color.Dispose()

    End Sub

    Private Sub TipoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoProductoToolStripMenuItem.Click
        Dim tipoP As New TipoProd
        tipoP.ShowDialog()
        tipoP.Dispose()
    End Sub

    Private Sub Inicio_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class