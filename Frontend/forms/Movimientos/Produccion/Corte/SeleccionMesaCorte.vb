Public Class SeleccionMesaCorte
    Public mesacortes As Integer = 0
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        mesacortes = 1
        Me.Close()
    End Sub

    Private Sub btnMesa2_Click(sender As Object, e As EventArgs) Handles btnMesa2.Click
        mesacortes = 2
        Me.Close()
    End Sub

    Private Sub SeleccionMesaCorte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class