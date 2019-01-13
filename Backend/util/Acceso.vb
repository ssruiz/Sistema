Imports MySql.Data.MySqlClient

Public Class Acceso
    Public Function login(ByVal user As String, ByVal passwd As String) As Boolean

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(user, passwd))
            con.Open()
            Dim query = "select * from usuario where usuNombre = @user"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@user", user)
            Dim reader = cmd.ExecuteReader()
            Dim estado As Char
            If reader.Read Then
                Sesion.Usuario = user
                Sesion.Password = passwd
                Sesion.Codigo = SafeGetString(reader, 0)
                Sesion.Nivel = SafeGetInt(reader, 2)
                estado = safeGetChar(reader, 4)
            Else
                Sesion.Usuario = user
                Sesion.Password = passwd
            End If
            con.Close()
            If estado = "I" Then
                Return False
            Else
                Return True
            End If

        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 1042
                    Throw New DAOException("No se puede acceder al servidor." & vbCrLf & "Contacte al administrator.")
                Case 1045
                    Throw New DAOException("Usuario o contraseña incorrectos." & vbCrLf & "Intente de nuevo.")
                Case 0

                    Throw New DAOException("Usuario o contraseña incorrectos." & vbCrLf & "Intente de nuevo.")
            End Select

        End Try
    End Function

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
