Public Class InformesProduccion
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cbInformes.SelectedIndex = 1 Then
            Dim rpi As New InformeReporte
            rpi.filtro = 1
            rpi.inicio = dpInicio.Value
            '.Value.ToString("yyyyMMdd")
            rpi.fin = dpFin.Value
            rpi.ShowDialog()
            rpi.Dispose()
        ElseIf cbInformes.SelectedIndex = 2 Then
            Dim rpi As New InformeReporte
            rpi.filtro = 2
            rpi.inicio = dpInicio.Value
            rpi.fin = dpFin.Value
            rpi.ShowDialog()
            rpi.Dispose()
        ElseIf cbInformes.SelectedIndex = 3 Then
            Dim rpi As New InformeReporte
            rpi.filtro = 3
            rpi.inicio = dpInicio.Value
            rpi.fin = dpFin.Value
            rpi.ShowDialog()
            rpi.Dispose()
        ElseIf cbInformes.SelectedIndex = 4 Then
            Dim rpi As New InformeReporte
            rpi.filtro = 4
            rpi.inicio = dpInicio.Value
            rpi.fin = dpFin.Value
            rpi.ShowDialog()
            rpi.Dispose()
        End If
    End Sub

    Private Sub InformesProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbInformes.SelectedIndex = 0
    End Sub
End Class