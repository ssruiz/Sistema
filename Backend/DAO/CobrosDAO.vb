Imports MySql.Data.MySqlClient

Public Class CobrosDAO
    Dim con As New MySqlConnection
    Public Function getCobrosAnteriores(ByVal hasta As Date) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "CALL spauxcobrosanteriores(@ot);"
            Dim cmd As New MySqlCommand(mysql, con)

            cmd.Parameters.AddWithValue("@ot", hasta)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getCobros(ByVal inicio As Date, ByVal hasta As Date) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "CALL sppagosresumen(@inicio,@hasta);"
            Dim cmd As New MySqlCommand(mysql, con)

            cmd.Parameters.AddWithValue("@inicio", inicio)
            cmd.Parameters.AddWithValue("@hasta", hasta)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function
End Class
