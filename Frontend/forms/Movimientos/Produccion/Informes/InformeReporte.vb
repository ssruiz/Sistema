Imports Backend

Public Class InformeReporte
    Public filtro = 0
    Public inicio As Date
    Public fin As Date
    Private Sub InformeReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        Select Case filtro
            Case 1
                Dim rep As New ReporteProd1
                Dim dao As New SesionDAO
                rep.SetParameterValue("f1", inicio)
                rep.SetParameterValue("f2", fin)

                rep.SetParameterValue("usuario", dao.getUsuario)
                crvProduc.ReportSource = rep
            Case 2
                Dim rep As New ReporteProd2
                Dim dao As New SesionDAO
                rep.SetParameterValue("f1", inicio)
                rep.SetParameterValue("f2", fin)

                rep.SetParameterValue("usuario", dao.getUsuario)
                crvProduc.ReportSource = rep
            Case 3
                Me.Close()

            Case 4
                Dim rep As New ReporteProd4
                Dim dao As New SesionDAO
                rep.SetParameterValue("f1", inicio)
                rep.SetParameterValue("f2", fin)

                rep.SetParameterValue("usuario", dao.getUsuario)
                crvProduc.ReportSource = rep
        End Select
    End Sub
End Class