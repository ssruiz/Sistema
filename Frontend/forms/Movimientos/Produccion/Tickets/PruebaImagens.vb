Imports System.IO
Imports System.Net
Imports System.Security.Principal

Public Class PruebaImagens
    Dim path = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            pbPlano.Image = Image.FromFile(file.FileName)

            pbPlano.SizeMode = PictureBoxSizeMode.Zoom
            path = file.FileName
        End If
        file.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            '"\\username:password@machinename"
            Dim ruta2 = "ftp://sistema:system@192.168.0.10/12.jpg"
            'Dim newImage = pbPlano.Image
            Dim fullPath = My.Computer.FileSystem.CombinePath("\\192.168.0.17\asd", "12.jpg")
            ''System.IO.File.Copy(path, ruta2, True)
            ''newImage.Save(ruta2, System.Drawing.Imaging.ImageFormat.Jpeg)
            ''System.IO.File.Copy(path, ruta2)
            'Dim source As New Uri(path)
            Dim user = "sistema"
            Dim pass = "system"
            'System.IO.File.Copy(path, "\\192.168.0.10\Z:\12.jpg")
            ''pbPlano.Image.SaveAs()
            ''Dim credentials As System.Net.NetworkCredential = System.Net.CredentialCache.DefaultNetworkCredentials
            My.Computer.Network.UploadFile(path, fullPath)




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PruebaImagens_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



End Class