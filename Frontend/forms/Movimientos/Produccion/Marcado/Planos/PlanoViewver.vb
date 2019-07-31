Public Class PlanoViewver
    Public plano


    Private Sub PlanoViewver_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Me.Close()
    End Sub

    Private Sub PlanoViewver_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BringToFront()
        PictureBox1.Image = plano
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub PlanoViewver_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub
End Class