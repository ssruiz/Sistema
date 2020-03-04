Imports Backend

Public Class TempladoRotura
    Public templa = 0
    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                Dim prodDao As New ProduccionDAO
                If txtNroProd.Text <> "" Then
                    Dim producc = prodDao.getProduccion(txtNroProd.Text)

                    If producc.idProd <> 0 Then
                        ' Guardar Corte
                        prodDao.guardarTemplado(producc.idProd, templa, 1)
                        MsgBox("Rotura Guardada", MsgBoxStyle.Information, "Templado")
                        Me.DialogResult = DialogResult.OK
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TempladoRotura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class