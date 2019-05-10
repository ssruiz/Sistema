Imports MySql.Data.MySqlClient

Public Class ProduccionDAO
    Dim con As New MySqlConnection
    Public Function getProduccionDia() As Produccion
        Dim prod As New Produccion
        Try

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM `producciondia` WHERE `prodDiaFecha` = CURDATE(); "
            Dim cmd As New MySqlCommand(query, con)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                prod.id = SafeGetInt(reader, 0)
                prod.total = SafeGetDouble(reader, 1)
            End While

        Catch ex As Exception
        Finally
            con.Close()
        End Try
        Return prod
    End Function
End Class
