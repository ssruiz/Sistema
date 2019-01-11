Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim lg As New login
        lg.Show()
    End Sub


    ' Mantenimiento Productos
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim prod As New ProductoForm
        prod.ShowDialog()
        prod.Dispose()
    End Sub

    ' Mantemientos Colores
    Private Sub ColoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoresToolStripMenuItem.Click
        Dim color As New ColorForm
        color.ShowDialog()
        color.Dispose()

    End Sub

    Private Sub TipoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoProductoToolStripMenuItem.Click
        Dim tipoP As New TipoProd
        tipoP.ShowDialog()
        tipoP.Dispose()
    End Sub

    Private Sub Inicio_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColoresMenu())
    End Sub

    Private Sub manteTS_DropDownOpened(sender As Object, e As EventArgs) Handles manteTS.DropDownOpened
        Dim ob = DirectCast(sender, ToolStripMenuItem)
        ob.ForeColor = Color.Black

    End Sub

    Private Sub manteTS_DropDownClosed(sender As Object, e As EventArgs) Handles manteTS.DropDownClosed
        Dim ob = DirectCast(sender, ToolStripMenuItem)
        ob.ForeColor = Color.White
    End Sub

    Private Sub manteTS_MouseEnter(sender As Object, e As EventArgs) Handles manteTS.MouseEnter
        Dim ob = DirectCast(sender, ToolStripMenuItem)

    End Sub


End Class