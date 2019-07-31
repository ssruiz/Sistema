Public Class SeleccionTemplado
    Public templado = 0
    Private Sub SeleccionTemplado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        templado = 1
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnMesa2_Click(sender As Object, e As EventArgs) Handles btnMesa2.Click
        templado = 2
        Me.DialogResult = DialogResult.OK
    End Sub
End Class