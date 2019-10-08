Imports Backend

Public Class RoturaMarcado
    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim prodDao As New ProduccionDAO
            If txtNroProd.Text <> "" Then
                Dim producc = prodDao.getProduccion(txtNroProd.Text)

                If producc.idProd <> 0 Then
                    ' Guardar Corte
                    prodDao.guardarMarcado(producc.idProd, 1)
                    MsgBox("Rotura Guardada", MsgBoxStyle.Information, "Marcado")
                    Me.DialogResult = DialogResult.OK
                End If
            End If

        End If
    End Sub

    Private Sub RoturaPulida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNroProd.Focus()
    End Sub
End Class