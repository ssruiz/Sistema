Imports Backend
Imports CrystalDecisions.Shared

Public Class ReporteDeCobrosForm
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            Dim objreporte As New CobrosReporte2
            Dim daoc As New CobrosDAO
            Dim dsAnteriores = daoc.getCobrosAnteriores(dpInicio.Value)
            objreporte.SetParameterValue("inicio", dpInicio.Value)
            objreporte.SetParameterValue("fin", dpFin.Value)
            objreporte.SetParameterValue("hasta", dpInicio.Value)
            objreporte.SetParameterValue("inicioC", dpInicio.Value)
            objreporte.SetParameterValue("finC", dpFin.Value)
            objreporte.SetParameterValue("inicioR", dpInicio.Value)
            objreporte.SetParameterValue("finR", dpFin.Value)

            objreporte.SetParameterValue("inicioA", dpInicio.Value)
            objreporte.SetParameterValue("finA", dpFin.Value)

            ' objreporte.SetParameterValue("inicioanu", dpInicio.Value)
            'objreporte.SetParameterValue("finanu", dpFin.Value)

            objreporte.SetParameterValue("inicioCh", dpInicio.Value)
            objreporte.SetParameterValue("finCh", dpInicio.Value)

            Dim daou As New SesionDAO
            objreporte.SetParameterValue("estado", "")
            objreporte.SetParameterValue("unidad", 0)
            objreporte.SetParameterValue("tipov", "")
            objreporte.SetParameterValue("Usuario", daou.getUsuario())
            objreporte.SetDatabaseLogon("samuel", "system", "localhost", "producir")

            'objreporte.Subreports("Subreport1").Database.Tables("PagosAnteriores").SetDataSource(dsAnteriores.Tables("tabla"))
            'objreporte.Subreports("HeaderRpt.rpt").SetDataSource(HeaderDT)
            ReporteVentasView.ReportSource = objreporte

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub ReporteDeCobrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        'configureCrystalReports()
    End Sub

    Private Sub configureCrystalReports()
        Try
            Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
            myConnectionInfo.ServerName = "consis"
            myConnectionInfo.DatabaseName = "producir "
            myConnectionInfo.UserID = "samuel"
            myConnectionInfo.Password = "system"
            myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type 
            myConnectionInfo.IntegratedSecurity = False
            setDBLOGONforREPORT(myConnectionInfo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
        Dim mytableloginfos As New TableLogOnInfos()
        mytableloginfos = ReporteVentasView .LogOnInfo
        For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
            myTableLogOnInfo.ConnectionInfo = myconnectioninfo
        Next
    End Sub

End Class