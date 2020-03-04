Public Class AnularFacturaComentario
    Public anular As String = ""
    Private Sub txtAnular_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnular.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtAnular.Text <> "" Then
                anular = txtAnular.Text
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("Introduzca un motivo de anulación", MsgBoxStyle.Critical, "Anular")
                txtAnular.Focus()
            End If
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub ComentarioAnularPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAnular.Focus()
    End Sub
End Class