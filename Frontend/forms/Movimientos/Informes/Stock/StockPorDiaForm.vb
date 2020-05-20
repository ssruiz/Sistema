Imports Backend

Public Class StockPorDiaForm
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim filtro = cbTipo.SelectedValue.ToString
        Dim daop As New ProduccionDAO

        Dim res = daop.getSalidas(dpInicio.Value.ToShortDateString, dpFin.Value.ToShortDateString, filtro)

        Dim rpt As New StockSalidasRangoRpt
        rpt.SetDataSource(res.Tables("tabla"))
        rpt.SetParameterValue("desde", dpInicio.Value.ToShortDateString)
        rpt.SetParameterValue("hasta", dpFin.Value.ToShortDateString)

        Dim selectedDataRow = cbTipo.SelectedItem
        Dim type = selectedDataRow("Tipo").toString()
        rpt.SetParameterValue("tipo", type)

        rptSalidas.ReportSource = rpt

    End Sub

    Private Sub StockPorDiaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        cargarTipos()
    End Sub

    Private Sub cargarTipos()
        Dim daoC As New TipoProdDAO
        Dim colores = daoC.getTipos()
        Dim listColores = colores.Tables("tabla")
        Dim rowV = listColores.NewRow()
        ' rowV("Tipo") = "Todos"
        'rowV("ID") = 0
        'listColores.Rows.InsertAt(rowV, 0)

        cbTipo.DataSource = listColores.Copy
        cbTipo.DisplayMember = "Tipo"
        cbTipo.ValueMember = "ID"
    End Sub
End Class