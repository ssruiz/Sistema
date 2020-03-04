Imports MySql.Data.MySqlClient

Public Class Consultas
    Dim con As New MySqlConnection
    Public Function getVentasM2() As Double
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ventas As New Double
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD())
            con.Open()
            Dim query = "SELECT SUM(t.m2) FROM (SELECT v.`ventM2` AS m2 FROM `ventas` v WHERE v.`ventFecha` = @fecha AND v.`ventEstado` <> 'A' ) AS t"
            Dim cmdVenta As New MySqlCommand(query, con)
            cmdVenta.Parameters.AddWithValue("@fecha", Date.Today)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                ventas = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception

            Console.Write(ex.Message)
        Finally
            con.Close()
        End Try
        Return ventas
    End Function

    Public Function getAnuladoas() As Double
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ventas As New Double
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD())
            con.Open()
            Dim query = "SELECT SUM(t.m2) FROM (SELECT v.`ventM2` AS m2 FROM `ventas` v WHERE v.`ventFU` = @fecha AND v.`ventEstado` = 'A' ) AS t"
            Dim cmdVenta As New MySqlCommand(query, con)
            cmdVenta.Parameters.AddWithValue("@fecha", Date.Today)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                ventas = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception

            Console.Write(ex.Message)
        Finally
            con.Close()
        End Try
        Return ventas
    End Function


    Public Function getCorte() As Double
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ventas As New Double
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD())
            con.Open()
            Dim query = "SELECT SUM(t.m2) FROM (SELECT pdi.`piCantidad` * ((p.`prodAncho`*p.`prodAlto`)/1000000) AS m2 FROM `pedidointernocab` pdi INNER JOIN `productos` p ON p.`prodCod` = pdi.`prodCod` WHERE pdi.`piEstado` = 'ENTREGADO' AND pdi. `piFecha` = @fecha ) AS t;"
            Dim cmdVenta As New MySqlCommand(query, con)
            cmdVenta.Parameters.AddWithValue("@fecha", Date.Today)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                ventas = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception

            Console.Write(ex.Message)
        Finally
            con.Close()
        End Try
        Return ventas
    End Function


    Public Function getPendientes() As Double
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ventas As New Double
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD())
            con.Open()
            Dim query = "Select SUM(tr.m2) FROM ( Select (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2 FROM `templado` t INNER JOIN `produccion` pr  On t.`pCod` = pr.`pCod` INNER JOIN `ventasdet` dt On dt.`ventDetcod` = pr.`ventDetCod` INNER JOIN `ventas` v On v.`ventCod` = pr.`ventCod` INNER JOIN `clientes` c On c.`clieCod` = v.`clieCod` WHERE (DATE_FORMAT(t.`templaFchIns`, '%Y-%m-%d') = CURDATE() And (t.`templaEstado` <> 'T' OR t.`templaEstado` IS NULL) AND v.`ventEstado` <> 'A' )) AS tr"
            Dim cmdVenta As New MySqlCommand(query, con)
            'cmdVenta.Parameters.AddWithValue("@fecha", Date.Today)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                ventas = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception

            Console.Write(ex.Message)
        Finally
            con.Close()
        End Try
        Return ventas
    End Function

    Public Function getProduccion() As Double
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ventas As New Double
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD())
            con.Open()
            Dim query = "SELECT SUM(tr.m2) FROM (SELECT dt.`ventDetSup`/ dt.`ventDetCantidad` AS m2 FROM `templado` t INNER JOIN `produccion` pr  ON t.`pCod` = pr.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = pr.`ventDetCod` INNER JOIN `productos` p ON p.`prodCod` = dt.`prodCod` WHERE DATE_FORMAT(t.`templaSalida`, '%Y-%m-%d') = CURDATE() AND t.`templaEstado` = 'T') AS tr"
            Dim cmdVenta As New MySqlCommand(query, con)
            'cmdVenta.Parameters.AddWithValue("@fecha", Date.Today)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                ventas = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception

            Console.Write(ex.Message)
        Finally
            con.Close()
        End Try
        Return ventas
    End Function

    Public Function getEfectivoDia() As Double
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ventas As New Double
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD())
            con.Open()
            Dim query = "SELECT SUM(t.efe) FROM (SELECT p.`pagoMonto` AS efe FROM `pagos` p WHERE DATE_FORMAT(`pagoFecha`, '%Y-%m-%d') = CURDATE() AND p.`tpagoCod` = 1 AND `pago_estado` <> 'A') AS t;"
            Dim cmdVenta As New MySqlCommand(query, con)
            'cmdVenta.Parameters.AddWithValue("@fecha", Date.Today)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                ventas = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception

            Console.Write(ex.Message)
        Finally
            con.Close()
        End Try
        Return ventas
    End Function

    Public Function getChequesDia() As Double
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ventas As New Double
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD())
            con.Open()
            Dim query = "SELECT SUM(t.efe) FROM (SELECT p.`pagoMonto` AS efe FROM `pagos` p WHERE DATE_FORMAT(`pagoFecha`, '%Y-%m-%d') = CURDATE() AND (p.`tpagoCod` = 3 or p.`tpagoCod` = 7 or p.`tpagoCod` = 5 or p.`tpagoCod` = 6)   AND `pago_estado` <> 'A') AS t;"
            Dim cmdVenta As New MySqlCommand(query, con)
            'cmdVenta.Parameters.AddWithValue("@fecha", Date.Today)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                ventas = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception

            Console.Write(ex.Message)
        Finally
            con.Close()
        End Try
        Return ventas
    End Function

    Public Function getReposicionesDia() As Double
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ventas As New Double
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD())
            con.Open()
            Dim query = " SELECT SUM(t.m2) FROM (SELECT (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2 FROM `reposiciones` r INNER JOIN `reposiciondetalle` dr ON dr.`idReposicion` = r.`repoCod` INNER JOIN `produccion` p ON p.`pCod` = dr.`idProd` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(r.`repoFI`, '%Y-%m-%d') = CURDATE() and dr.repoTemp = 'S' ) AS t;"
            Dim cmdVenta As New MySqlCommand(query, con)
            'cmdVenta.Parameters.AddWithValue("@fecha", Date.Today)
            Dim reader = cmdVenta.ExecuteReader()

            While reader.Read
                ventas = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ventas
        Catch ex As Exception

            Console.Write(ex.Message)
        Finally
            con.Close()
        End Try
        Return ventas
    End Function
End Class
