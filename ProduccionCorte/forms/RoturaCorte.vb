Imports Backend

Public Class RoturaCorte
    Public mesa = 0
    Private Sub CorteRotura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim prodDao As New ProduccionDAO
            If txtNroProd.Text <> "" Then
                Dim producc = prodDao.getProduccion(txtNroProd.Text)

                If producc.idProd <> 0 Then
                    ' Guardar Corte
                    prodDao.guardarCorte(producc.idProd, mesa, 1)
                    MsgBox("Rotura Guardada", MsgBoxStyle.Information, "Corte")
                    Me.DialogResult = DialogResult.OK

                End If
            End If

        End If
    End Sub
End Class