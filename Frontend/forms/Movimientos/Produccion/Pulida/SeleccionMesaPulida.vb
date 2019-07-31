Public Class SeleccionMesaPulida
    Public pulidora = 0
    Private Sub SeleccionMesaPulida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        pulidora = 1
        Me.Close()
    End Sub

    Private Sub btnMesa2_Click(sender As Object, e As EventArgs) Handles btnMesa2.Click
        pulidora = 2
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pulidora = 3
        Me.Close()
    End Sub
End Class