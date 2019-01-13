Imports Backend

Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conexion()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub conexion()
        Try
            Dim conectar As New Acceso
            If (conectar.login(Me.txtUsuario.Text, Me.txtPasswd.Text)) Then
                Me.Visible = False
                Dim mdi As New Inicio
                mdi.Show()
            Else
                Me.lbAdvertencia.Visible = True

                Me.lbAdvertencia.Text = "Su usuario actualmente se encuentra desactivado." & vbCrLf & "Contacte al administrator."
                lbAdvertencia.Left = (Me.ClientSize.Width / 2) - (lbAdvertencia.Width / 2)
                Me.txtUsuario.Text = ""
                Me.txtPasswd.Text = ""
                Me.txtUsuario.Focus()
            End If
        Catch ex As Exception

            Me.lbAdvertencia.Visible = True
            Me.lbAdvertencia.Text = ex.Message
            lbAdvertencia.Left = (Me.ClientSize.Width / 2) - (lbAdvertencia.Width / 2)
            Me.txtUsuario.Text = ""
            Me.txtPasswd.Text = ""
            Me.txtUsuario.Focus()
        End Try
    End Sub

    Private Sub txtPasswd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasswd.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            conexion()
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        'pnlBienvenida.BackColor = Color.FromArgb(80, Color.Black)
        'lbbienvenida.BackColor = Color.FromArgb(80, Color.Black)

        'Dim image As New Bitmap(My.Resources.Panther1)
        'Me.BackgroundImage = My.Resources.fondo_bmp
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.ResumeLayout()
    End Sub
End Class
