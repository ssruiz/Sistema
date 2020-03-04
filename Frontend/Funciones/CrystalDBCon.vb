Imports CrystalDecisions.Shared

Public Class CrystalDBCon
    Public Function configureCrystalReports() As ConnectionInfo
        Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
        Try
            'Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
            myConnectionInfo.ServerName = "consis"
            myConnectionInfo.DatabaseName = "producir "
            myConnectionInfo.UserID = "samuel"
            myConnectionInfo.Password = "system"
            myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type 
            myConnectionInfo.IntegratedSecurity = False
            'setDBLOGONforREPORT(myConnectionInfo)
        Catch ex As Exception

        End Try
        Return myConnectionInfo
    End Function
End Class
