Imports Backend

Public Class StockForm
    Dim list As New DataSet
    Private Sub StockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarStock()
    End Sub

    Private Sub cargarStock()
        Try
            Dim daoP As New ProductoDAO
            list = daoP.getStocks()
            dgvProductos.DataSource = list.Tables("tabla")
            dgvProductos.Columns("ID").Visible = False
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            'dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            dgvProductos.ClearSelection()
            PersonalizarDAtagridView(dgvProductos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub PersonalizarDAtagridView(ByVal dgv As DataGridView)
        With dgv
            .ForeColor = Color.FromArgb(245, 245, 245)
            .DefaultCellStyle.BackColor = Color.FromArgb(64, 69, 76)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.FromArgb(245, 245, 245)

            ' Inabilito EnableHeadersVisualStyles para que la personalizacion se haga efectiva

            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .ColumnHeadersHeight = 35
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 64, 23)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 101, 205)
            .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 101, 205)
            .AlternatingRowsDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            'Tipo de letra and color
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'Coloreo el background del DGV
            .BackgroundColor = Color.FromArgb(48, 65, 91)
        End With
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Código like '%{0}%' or Producto like '%{0}%' or Tipo like '%{0}%' ", txtBusqueda.Text)
            dgvProductos.DataSource = dv
            dgvProductos.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub rbHerrajes_CheckedChanged(sender As Object, e As EventArgs) Handles rbHerrajes.CheckedChanged
        If rbHerrajes.Checked Then
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Tipo like '%{0}%' ", "herrajes")
            dgvProductos.DataSource = dv
            dgvProductos.ClearSelection()
        End If
    End Sub

    Private Sub rbPerfiles_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerfiles.CheckedChanged
        If rbPerfiles.Checked Then
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Tipo like '%{0}%' ", "perfiles")
            dgvProductos.DataSource = dv
            dgvProductos.ClearSelection()
        End If
    End Sub

    Private Sub rbPlanchas_CheckedChanged(sender As Object, e As EventArgs) Handles rbPlanchas.CheckedChanged
        If rbPlanchas.Checked Then
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Tipo like '%{0}%' ", "planchas")
            dgvProductos.DataSource = dv
            dgvProductos.ClearSelection()
        End If
    End Sub

    Private Sub rbTemplados_CheckedChanged(sender As Object, e As EventArgs) Handles rbTemplados.CheckedChanged
        If rbTemplados.Checked Then
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Tipo like '%{0}%' ", "templado")
            dgvProductos.DataSource = dv
            dgvProductos.ClearSelection()
        End If
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        If rbTodos.Checked Then

            dgvProductos.DataSource = list.Tables("tabla")
            dgvProductos.ClearSelection()
        End If
    End Sub
End Class