Imports MySql.Data.MySqlClient

Public Class Acceso
    Public Sub login(ByVal user As String, ByVal passwd As String)

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(user, passwd))
            con.Open()

            con.Close()
            Sesion.Usuario = user
            Sesion.Password = passwd

        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 1042
                    Throw New DAOException("No se puede acceder al servidor." & vbCrLf & "Contacte al administrator.")
                Case 1045
                    Throw New DAOException("Usuario o contraseña incorrectos." & vbCrLf & "intente de nuevo.")
                Case 0

                    Throw New DAOException("Usuario o contraseña incorrectos." & vbCrLf & "intente de nuevo.")
            End Select
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function seguridad() As Integer
        Dim res = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT nivel FROM seguridad WHERE cod_usuario = @usr"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@usr", Sesion.Usuario)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                res = SafeGetInt(reader, 0)
                Sesion.Nivel = res
            End If
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return res
    End Function

    Public Function permisosAnular() As Boolean
        If Sesion.Nivel = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
