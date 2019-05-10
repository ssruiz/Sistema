Public Class VerPlano
    Public ruta As String
    Private Sub VerPlano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(ruta)
    End Sub
End Class