Imports Backend

Public Class SeleccionTemplado
    Private Sub SeleccionTemplado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conectar As New Acceso
        Try
            If conectar.login("TEMPLADO", "TEMPLADO") Then

            Else

                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox("Conexión no realizada")
            Application.Exit()
        End Try
    End Sub

    Private Sub MesaCorteForm_closing(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        Dim temf As New TempladoForm
        temf.templado = 1
        Me.Visible = False
        temf.Show()
    End Sub

    Private Sub btnMesa2_Click(sender As Object, e As EventArgs) Handles btnMesa2.Click
        Dim temf As New TempladoForm
        temf.templado = 2
        Me.Visible = False
        temf.Show()
    End Sub
End Class