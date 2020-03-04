Imports MySql.Data.MySqlClient

Public Class ProductoDAO
    Dim con As New MySqlConnection
    Public Function getProductos() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadoproductos"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    ' Guarda un nuevo producto en la DB
    Public Sub guardar(ByVal modelo As Producto)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            ', `prodEsp`
            Dim query As String = "INSERT INTO `productos` (`prodCodigo`, `prodTipo`, `prodDesc`, `prodColor`, `prodAlto`, `prodAncho`, `prodSup`, `prodPA`, `prodPB`, `prodPC`, `prodPD`, `prodUI`, `prodFi`, `prodUU`, `prodFU`, `prodSM`, `prodTipoPl`,`prodEsp`,`prodCosto`, `prodIva`) VALUES (@codigo, @tipo, @desc, @color, @alto, @ancho, @superf, @pa, @pb, @pc, @pd, @userI, @fecha, @userI, @fecha, @stockm,@tpl,@espe,@costo,@iva);"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@codigo", modelo.codigo)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            cmd.Parameters.AddWithValue("@color", modelo.color)
            cmd.Parameters.AddWithValue("@pa", modelo.PrecioA)
            cmd.Parameters.AddWithValue("@pb", modelo.PrecioB)
            cmd.Parameters.AddWithValue("@pc", modelo.PrecioC)
            cmd.Parameters.AddWithValue("@pd", modelo.PrecioD)
            cmd.Parameters.AddWithValue("@userI", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@espe", modelo.espesor)
            cmd.Parameters.AddWithValue("@costo", modelo.costo)
            cmd.Parameters.AddWithValue("@iva", modelo.iva)

            'cmd.Parameters.AddWithValue("@fe", modelo.alto)
            'cmd.Parameters.AddWithValue("@alto", modelo.alto)

            If modelo.tipoPL <> 0 Then
                cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
                cmd.Parameters.AddWithValue("@alto", modelo.alto)
                cmd.Parameters.AddWithValue("@ancho", modelo.ancho)
                cmd.Parameters.AddWithValue("@superf", modelo.superficie)
                cmd.Parameters.AddWithValue("@stockm", modelo.stockMin)
            Else
                cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
                cmd.Parameters.AddWithValue("@alto", DBNull.Value)
                cmd.Parameters.AddWithValue("@ancho", DBNull.Value)
                cmd.Parameters.AddWithValue("@superf", DBNull.Value)
                cmd.Parameters.AddWithValue("@stockm", modelo.stockMin)
            End If
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub eliminar(ByVal id As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query As String = "DELETE FROM `productos` WHERE `prodCod` = @id;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub update(ByVal modelo As Producto)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            '`prodEsp` = @esp,
            Dim query = "UPDATE `productos` SET `prodCodigo` = @cod, `prodTipo` = @tipo, `prodDesc` = @desc, `prodColor` = @color,  `prodAlto` = @alto, `prodAncho` = @ancho, `prodSup` = @sup, `prodPA` = @pa, `prodPB` = @pb, `prodPC` = @pc, `prodPD` = @pd, `prodUU` = @user, `prodFU` = @fecha, `prodSM` = @stm, `prodTipoPl` = @tpl, `prodEsp` = @esp, `prodCosto` = @costo, `prodIva`= @iva WHERE `prodCod` = @id;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", modelo.id)
            cmd.Parameters.AddWithValue("@cod", modelo.codigo)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            cmd.Parameters.AddWithValue("@color", modelo.color)
            cmd.Parameters.AddWithValue("@esp", modelo.espesor)
            ' cmd.Parameters.AddWithValue("@pl", modelo.tipoPL)

            cmd.Parameters.AddWithValue("@pa", modelo.PrecioA)
            cmd.Parameters.AddWithValue("@pb", modelo.PrecioB)
            cmd.Parameters.AddWithValue("@pc", modelo.PrecioC)
            cmd.Parameters.AddWithValue("@pd", modelo.PrecioD)
            cmd.Parameters.AddWithValue("@user", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@costo", modelo.costo)
            cmd.Parameters.AddWithValue("@iva", modelo.iva)

            If modelo.tipoPL <> 0 Then
                cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
                cmd.Parameters.AddWithValue("@alto", modelo.alto)
                cmd.Parameters.AddWithValue("@ancho", modelo.ancho)
                cmd.Parameters.AddWithValue("@sup", modelo.superficie)
                cmd.Parameters.AddWithValue("@stm", modelo.stockMin)
            Else
                cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
                cmd.Parameters.AddWithValue("@alto", DBNull.Value)
                cmd.Parameters.AddWithValue("@ancho", DBNull.Value)
                cmd.Parameters.AddWithValue("@sup", DBNull.Value)
                cmd.Parameters.AddWithValue("@stm", DBNull.Value)
            End If
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getProducto(ByVal id As String) As Producto
        Try
            Dim modelo As New Producto
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from productos where prodCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.codigo = SafeGetString(reader, 1)
                modelo.tipo = SafeGetInt(reader, 2)
                modelo.descripcion = SafeGetString(reader, 3)
                modelo.color = SafeGetInt(reader, 4)
                modelo.espesor = SafeGetInt(reader, 5)
                modelo.tipoPL = SafeGetInt(reader, 6)
                modelo.alto = SafeGetDecimal(reader, 7)
                modelo.ancho = SafeGetDecimal(reader, 8)
                modelo.superficie = SafeGetDecimal(reader, 9)
                modelo.PrecioA = SafeGetDouble(reader, 10)
                modelo.PrecioB = SafeGetDouble(reader, 11)
                modelo.PrecioC = SafeGetDouble(reader, 12)
                modelo.PrecioD = SafeGetDouble(reader, 13)
                modelo.usuarioI = SafeGetString(reader, 14)
                modelo.fechaI = SafeGetDate(reader, 15)
                modelo.usuarioM = SafeGetString(reader, 16)
                modelo.fechaM = SafeGetDate(reader, 17)
                modelo.stockMin = SafeGetInt(reader, 18)
                modelo.costo = SafeGetDouble(reader, 19)
                modelo.iva = SafeGetInt(reader, 20)
            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function getProductoByCod(ByVal id As String) As Producto
        Try
            Dim modelo As New Producto
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from productos where prodCodigo = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.codigo = SafeGetString(reader, 1)
                modelo.tipo = SafeGetInt(reader, 2)
                modelo.descripcion = SafeGetString(reader, 3)
                modelo.color = SafeGetInt(reader, 4)
                modelo.espesor = SafeGetInt(reader, 5)
                modelo.tipoPL = SafeGetInt(reader, 6)
                modelo.alto = SafeGetDecimal(reader, 7)
                modelo.ancho = SafeGetDecimal(reader, 8)
                modelo.superficie = SafeGetDecimal(reader, 9)
                modelo.PrecioA = SafeGetDouble(reader, 10)
                modelo.PrecioB = SafeGetDouble(reader, 11)
                modelo.PrecioC = SafeGetDouble(reader, 12)
                modelo.PrecioD = SafeGetDouble(reader, 13)
                modelo.usuarioI = SafeGetString(reader, 14)
                modelo.fechaI = SafeGetDate(reader, 15)
                modelo.usuarioM = SafeGetString(reader, 16)
                modelo.fechaM = SafeGetDate(reader, 17)
                modelo.stockMin = SafeGetInt(reader, 18)
                modelo.costo = SafeGetDouble(reader, 19)
                modelo.iva = SafeGetInt(reader, 20)
            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function getStock(ByVal id As String) As Integer
        Dim stock = 0
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from vstockproductos where Cod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                stock = SafeGetInt(reader, 2)
            End While
            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return stock
    End Function

    Public Function getStocks() As DataSet
        Dim stock = 0
        Dim ds As New DataSet
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from vstockproductosdet"
            Dim cmd As New MySqlCommand(query, con)
            Dim adp As New MySqlDataAdapter(query, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getStockSucursal(ByVal id As String, ByVal sucursal As Integer, ByVal depo As Integer) As Integer
        Dim stock = 0
        Try


            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select Stock from vstockproductossuc where IDP = @id and IDS = @suc and IDD= @depo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@suc", sucursal)
            cmd.Parameters.AddWithValue("@depo", depo)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                stock = SafeGetInt(reader, 0)
            End While
            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return stock
    End Function

    Public Function TotalDepositoMes(mes As String, hoy As String, filtro As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "(SELECT s.`prodCodigo` AS Prod, SUM(s.`stCantidad`) AS Inicial, 0 AS Entrada, 0 AS Salida, 0 AS Total, p.`prodDesc` AS Producto, dep.`depoDesc` AS Deposito, p.`prodTipo` AS Tipo FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` WHERE ((DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') < '" & mes & " 00:00:00')) " & filtro & " GROUP BY s.`prodCodigo`, p.`prodDesc`,dep.`depoDesc` ) UNION (SELECT s.`prodCodigo` AS Prod, 0 AS Inicial, SUM(s.`stCantidad`) AS Entrada , 0 AS Salida, 0 AS Total, p.`prodDesc` AS Producto, dep.`depoDesc` AS Deposito, p.`prodTipo` AS Tipo FROM `stock` s WHERE ((DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') >= '" & mes & " 00:00:00')) AND DATE_FORMAT((s.`stFchIns` , '%Y/%m/%d %T')) <= '" & hoy & " 23:59:59' AND s.stCantidad > 0 " & filtro & " GROUP BY s.`prodCodigo`, p.`prodDesc`,dep.`depoDesc` ) UNION (SELECT s.`prodCodigo` AS Prod, 0 AS Inicial, 0 AS Entrada , SUM(s.`stCantidad`) AS Salida, 0 AS Total, p.`prodDesc` AS Producto, dep.`depoDesc` AS Deposito, p.`prodTipo` AS Tipo FROM `stock` s WHERE ((DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') >= '" & mes & " 00:00:00')) AND DATE_FORMAT((s.`stFchIns` , '%Y/%m/%d %T')) <= '" & hoy & " 23:59:59' AND s.stCantidad < 0 " & filtro & " GROUP BY s.`prodCodigo`, p.`prodDesc`,dep.`depoDesc` ) UNION (SELECT s.`prodCodigo` AS Prod, 0 AS Inicial, 0 AS Entrada , 0 AS Salida, SUM(s.`stCantidad`) AS Total, p.`prodDesc` AS Producto, dep.`depoDesc` AS Deposito, p.`prodTipo` AS Tipo FROM `stock` s WHERE ((DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') >= '" & mes & " 00:00:00')) AND DATE_FORMAT((s.`stFchIns` , '%Y/%m/%d %T')) <= '" & hoy & " 23:59:59' AND s.stCantidad < 0 " & filtro & " GROUP BY s.`prodCodigo`, p.`prodDesc`,dep.`depoDesc` ORDER BY Prod,Tipo)"

            Dim Sql = "SELECT  s.`prodCodigo` as Articod, Sum(s.`stCantidad`) AS Inicial,0 as Entrada,0 as Salida,0 as Total,p.`prodDesc` as ArtiDesc, dep.`depoDesc` as DepoDesc, p.`prodTipo`" _
           & " FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` INNER JOIN `prodtipo` tp ON tp.`prodTipocod` = p.`prodTipo` " _
           & " WHERE((DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T')  < '" & mes & " 00:00:00')) " & filtro & " " _
           & " GROUP BY s.`prodCodigo`, p.`prodDesc`,dep.`depoDesc`" _
          & " UNION " _
       & " SELECT s.`prodCodigo` as Articod,0 as Inicial , SUM(s.`stCantidad`) AS Entrada,0 as Salida,0 as Total , p.`prodDesc` as ArtiDesc, dep.`depoDesc` as DepoDesc,p.`prodTipo`" _
          & " FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` INNER JOIN `prodtipo` tp ON tp.`prodTipocod` = p.`prodTipo`" _
           & " WHERE((DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') >= '" & mes & " 00:00:00' And DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') <= '" & hoy & " 23:59:59') and s.`stCantidad` > 0) " & filtro & " " _
          & " GROUP BY s.`prodCodigo`, p.`prodDesc`,dep.`depoDesc`" _
            & " UNION " _
        & " SELECT s.`prodCodigo` as Articod,0 as Inicial ,0 as Entrada, Sum(s.`stCantidad`) AS Salida,0 as Total, p.`prodDesc` as ArtiDesc, dep.`depoDesc` as DepoDesc, p.`prodTipo`" _
          & " FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` INNER JOIN `prodtipo` tp ON tp.`prodTipocod` = p.`prodTipo`" _
           & " WHERE((DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') >= '" & mes & " 00:00:00' And DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') <= '" & hoy & " 23:59:59') and s.`stCantidad` < 0)  " & filtro & " " _
          & " GROUP BY s.`prodCodigo`, p.`prodDesc`,dep.`depoDesc`" _
        & " UNION " _
       & " SELECT  s.`prodCodigo`  as Articod,0 as Inicial ,0 as Entrada,0 as Salida, Sum(s.`stCantidad`) AS Total,p.`prodDesc` as ArtiDesc, dep.`depoDesc` as DepoDesc,p.`prodTipo`" _
           & " FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` INNER JOIN `prodtipo` tp ON tp.`prodTipocod` = p.`prodTipo`" _
            & " WHERE((DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') >= '" & mes & " 00:00:00' And DATE_FORMAT((s.`stFchIns`), '%Y/%m/%d %T') <= '" & hoy & " 23:59:59')) " & filtro & " " _
           & "  GROUP BY s.`prodCodigo`, p.`prodDesc`,dep.`depoDesc` ORDER BY Articod,prodTipo"

            Dim sql2 = "Select * from (SELECT  s.`prodCodigo` as Articod, Sum(s.`stCantidad`) AS Inicial,0 as Entrada,0 as Salida,0 as Total,p.`prodDesc` as ArtiDesc, dep.`depoDesc` as DepoDesc" _
           & " FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` INNER JOIN `prodtipo` tp ON tp.`prodTipocod` = p.`prodTipo` " _
           & " WHERE((DATE_FORMAT((s.`stFchIns`), '%Y-%m-%d H:mm:ss')  < '" & mes & " 00:00:00'))" _
           & " GROUP BY s.`prodCodigo`, p.`prodDesc`, dep.`depoDesc`" _
          & " UNION " _
       & " SELECT  s.`prodCodigo` as Articod,0 as Inicial ,Sum(s.`stCantidad`) AS Entrada,0 as Salida,0 as Total ,p.`prodDesc` as ArtiDesc, dep.`depoDesc` as DepoDesc" _
          & " FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` INNER JOIN `prodtipo` tp ON tp.`prodTipocod` = p.`prodTipo`  " _
           & " WHERE((DATE_FORMAT((s.`stFchIns`), '%Y-%m-%d H:mm:ss') >= '" & mes & " 00:00:00' And DATE_FORMAT((s.`stFchIns`), '%Y-%m-%d H:mm:ss') <= '" & hoy & " 23:59:59') and s.`stCantidad` > 0) " _
          & " GROUP BY s.`prodCodigo`, p.`prodDesc`, dep.`depoDesc`" _
            & " UNION " _
        & " SELECT  s.`prodCodigo` as Articod,0 as Inicial ,0 as Entrada,Sum(s.`stCantidad`) AS Salida,0 as Total, p.`prodDesc` as ArtiDesc, dep.`depoDesc` as DepoDesc" _
          & " FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` INNER JOIN `prodtipo` tp ON tp.`prodTipocod` = p.`prodTipo` " _
           & " WHERE((DATE_FORMAT((s.`stFchIns`), '%Y-%m-%d H:mm:ss') >= '" & mes & " 00:00:00' And DATE_FORMAT((s.`stFchIns`), '%Y-%m-%d H:mm:ss') <= '" & hoy & " 23:59:59') and s.`stCantidad` < 0) " _
          & " GROUP BY s.`prodCodigo`, p.`prodDesc`, dep.`depoDesc`" _
        & " UNION " _
       & " SELECT s.`prodCodigo` as Articod,0 as Inicial ,0 as Entrada,0 as Salida, Sum(s.`stCantidad`) AS Total,p.`prodDesc` as ArtiDesc, dep.`depoDesc` as DepoDesc" _
           & " FROM `stock` s INNER JOIN `deposito` dep ON dep.`depoCod` = s.`depoCod` INNER JOIN `productos` p ON p.`prodCod` = s.`prodCodigo` INNER JOIN `prodtipo` tp ON tp.`prodTipocod` = p.`prodTipo` " _
            & " WHERE((DATE_FORMAT((s.`stFchIns`), '%Y-%m-%d H:mm:ss') >= '" & mes & " 00:00:00' And DATE_FORMAT((s.`stFchIns`), '%Y-%m-%d H:mm:ss') <= '" & hoy & " 23:59:59')) " _
           & " GROUP BY s.`prodCodigo`, p.`prodDesc`, dep.`depoDesc` ORDER BY Articod) as t"
            ' MsgBox(mysql)

            Dim querydef = ""
            'Dim FILE_NAME As String = "C:\Users\ssrui\Desktop\test.txt"

            'If System.IO.File.Exists(FILE_NAME) = True Then

            '    Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            '    objWriter.Write(sql2)
            '    objWriter.Close()
            '    ' MessageBox.Show("Text written to file")
            'End If

            Dim cmd As New MySqlCommand(sql2, con)
            ' cmd.Parameters.AddWithValue("@codigo", id)
            ' Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(sql2, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
            'reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function
End Class

