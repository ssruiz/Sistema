Imports Backend

Public Class MesaCorteForm

    Private Sub MesaCorteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conectar As New Acceso
        Try
            If conectar.login("CORTE", "CORTE") Then
            Else
                MsgBox("Conexión no realizada")
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        Dim cortef As New CorteForm
        cortef.mesa = 1
        Me.Visible = False
        cortef.Show()

    End Sub

    Private Sub btnMesa2_Click(sender As Object, e As EventArgs) Handles btnMesa2.Click
        Dim cortef As New CorteForm
        cortef.mesa = 2
        Me.Visible = False
        cortef.ShowDialog()
    End Sub


    Private Sub MesaCorteForm_closing(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
End Class