Public Class InformesProduccion
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cbInformes.SelectedIndex = 1 Then
            '.Value.ToString("yyyyMMdd")
            Dim rpi As New InformeReporte With {
                .filtro = 1,
                .inicio = dpInicio.Value,
                .fin = dpFin.Value
            }
            rpi.ShowDialog()
            rpi.Dispose()
        ElseIf cbInformes.SelectedIndex = 2 Then
            Dim rpi As New InformeReporte With {
                .filtro = 2,
                .inicio = dpInicio.Value,
                .fin = dpFin.Value
            }
            rpi.ShowDialog()
            rpi.Dispose()
        ElseIf cbInformes.SelectedIndex = 3 Then
            Dim rpi As New InformeReporte With {
                .filtro = 3,
                .inicio = dpInicio.Value,
                .fin = dpFin.Value
            }
            rpi.ShowDialog()
            rpi.Dispose()
        ElseIf cbInformes.SelectedIndex = 4 Then
            Dim rpi As New InformeReporte With {
                .filtro = 4,
                .inicio = dpInicio.Value,
                .fin = dpFin.Value
            }
            rpi.ShowDialog()
            rpi.Dispose()

        ElseIf cbInformes.SelectedIndex = 5 Then
            Dim rpi As New InformeReporte With {
                .filtro = 5,
                .inicio = dpInicio.Value,
                .fin = dpFin.Value
            }
            rpi.ShowDialog()
            rpi.Dispose()
        End If
    End Sub

    Private Sub InformesProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbInformes.SelectedIndex = 0
    End Sub
End Class