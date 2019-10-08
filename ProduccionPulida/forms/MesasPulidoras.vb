Imports Backend

Public Class MesasPulidoras
    Private Sub MesasPulidoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conectar As New Acceso
        Try
            If conectar.login("PULIDA", "PULIDA") Then
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
        Dim pulf As New PulidaForm
        pulf.mesa = 1
        Me.Visible = False
        pulf.Show()
    End Sub

    Private Sub btnMesa2_Click(sender As Object, e As EventArgs) Handles btnMesa2.Click
        Dim pulf As New PulidaForm
        pulf.mesa = 2
        Me.Visible = False
        pulf.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pulf As New PulidaForm
        pulf.mesa = 3
        Me.Visible = False
        pulf.Show()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
End Class