Imports Backend

Public Class InformeReposiciones2
    Private Sub InformeReposiciones2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'Dim objreporte As New CRInformeRepo


            'objreporte.SetParameterValue("fecha1", dpInicio.Value)
            'objreporte.SetParameterValue("fecha2", dpInicio.Value)

            'Dim daou As New SesionDAO
            'objreporte.SetParameterValue("usuario", daou.getUsuario())

            'rptvRepo.ReportSource = objreporte

        Catch ex As Exception

        End Try
    End Sub
End Class