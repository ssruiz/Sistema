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
                'Dim rep As New CRInformeRepo
                Dim dao As New SesionDAO
                rep.SetParameterValue("fecha1", inicio)
                rep.SetParameterValue("fecha2", fin)

                rep.SetParameterValue("usuario", dao.getUsuario)
                crvProduc.ReportSource = rep
            Case 2
                Dim rep As New ReporteProd2
                Dim dao As New SesionDAO
                rep.SetParameterValue("fecha1", inicio)
                rep.SetParameterValue("fecha2", fin)

                rep.SetParameterValue("usuario", dao.getUsuario)
                crvProduc.ReportSource = rep
            Case 3
                Dim rep As New ReporteProd3
                Dim dao As New SesionDAO
                rep.SetParameterValue("fecha1", inicio)
                rep.SetParameterValue("fecha2", fin)

                rep.SetParameterValue("usuario", dao.getUsuario)
                crvProduc.ReportSource = rep

            Case 4
                Dim rep As New ReporteProd4
                Dim dao As New SesionDAO
                rep.SetParameterValue("f1", inicio)
                rep.SetParameterValue("f2", fin)

                rep.SetParameterValue("usuario", dao.getUsuario)
                crvProduc.ReportSource = rep

            Case 5
                Dim rep As New ReporteProd5
                Dim dao As New SesionDAO
                Dim daop As New ProduccionDAO

                Dim dt = daop.pulidasPendientes(inicio, fin)


                rep.SetDataSource(dt.Tables("tabla"))

                rep.SetParameterValue("usu", dao.getUsuario)
                rep.SetParameterValue("f1", inicio)
                rep.SetParameterValue("f2", fin)
                crvProduc.ReportSource = rep
        End Select
    End Sub
End Class