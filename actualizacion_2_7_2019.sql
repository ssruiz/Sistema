/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 8.0.13 : Database - producir
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
USE `producir`;

/* Trigger structure for table `compras` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `anularCompra` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `anularCompra` AFTER UPDATE ON `compras` FOR EACH ROW BEGIN
	IF (NEW.`comprasEstado` = 'A') THEN		
		UPDATE `producir`.`stock` st SET `stEstado` = 'A' WHERE st.`compraCod` = NEW.`comprasCod`;	
	END IF;
    END */$$


DELIMITER ;

/* Trigger structure for table `pagos` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `tpagoventa` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `tpagoventa` AFTER INSERT ON `pagos` FOR EACH ROW BEGIN
	update `ventas` v 
	set v.`ventSaldo` = case when v.`ventSaldo` > 0 then  v.`ventSaldo` - NEW.`pagoMonto` end ,
	v.`ventEstado` = case when v.`ventSaldo` - NEW.`pagoMonto` = 0 then 'C' else v.`ventEstado` end;
	 
    END */$$


DELIMITER ;

/* Trigger structure for table `ventas` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `tproduccion` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `tproduccion` AFTER INSERT ON `ventas` FOR EACH ROW BEGIN
	
    IF not EXISTS (SELECT * FROM `producir`.`producciondia` WHERE `prodDiaFecha` = CURDATE()) THEN
	INSERT INTO `producir`.`producciondia` (`prodDiaSup`, `prodDiaFecha`) VALUES ( 0, CURDATE());
    END IF;
	IF (NEW.`ventM2` > 0) THEN
		UPDATE `producir`.`producciondia` SET `prodDiaSup` = `prodDiaSup` + NEW.`ventM2` WHERE `prodDiaFecha` = CURDATE();
	END IF;
    END */$$


DELIMITER ;

/* Trigger structure for table `ventas` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `pagodeventa` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `pagodeventa` BEFORE UPDATE ON `ventas` FOR EACH ROW BEGIN
	IF (NEW.`ventSaldo` = 0 and NEW.`ventEstado` = 'P') then
		SET NEW.`ventEstado` = 'C';
	end if;
    END */$$


DELIMITER ;

/* Trigger structure for table `ventas` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `anularVenta` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `anularVenta` AFTER UPDATE ON `ventas` FOR EACH ROW BEGIN
	if (NEW.`ventEstado` = 'A') then
		if (NEW.`ventM2` > 0) then
			UPDATE `producir`.`producciondia` pd SET pd.`prodDiaSup` = pd.`prodDiaSup` - NEW.`ventM2` WHERE pd.`prodDiaFecha` = NEW.`ventFecha`;
		elseif (NEW.`ventM2` = 0) then
			UPDATE `producir`.`stock` st SET `stEstado` = 'A' where st.`ventaCod` = NEW.`ventCod`;
		end if;
	
	end if;
    END */$$


DELIMITER ;

/* Procedure structure for procedure `facturadetalle` */

/*!50003 DROP PROCEDURE IF EXISTS  `facturadetalle` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `facturadetalle`(IN codigo VARCHAR (25))
BEGIN
	SELECT * FROM `producir`.`vdetalleventa` WHERE Venta = codigo ;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `insertarColor` */

/*!50003 DROP PROCEDURE IF EXISTS  `insertarColor` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarColor`(in pColor varchar(20))
BEGIN
INSERT INTO `producir`.`color` (`color`)
VALUES
  ( pColor);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `insertarProductos` */

/*!50003 DROP PROCEDURE IF EXISTS  `insertarProductos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarProductos`( in pprodCodigo varchar(20),in pprodTipo int, in pprodDesc VARCHAR(30),
    in pprodColor int, in pprodEsp int ,in pprodTipoPl int,in pprodAlto decimal(10,2), in pprodAncho DECIMAL(10,2) ,
    in pprodSup DECIMAL(10,2),in pprodPA double,IN pprodPB DOUBLE, IN pprodPC DOUBLE,IN pprodPD DOUBLE,
    IN USUARIO VARCHAR(10), IN pprodSM INT)
BEGIN
	DECLARE ACTUAL DATETIME;
	SELECT NOW() INTO ACTUAL;
INSERT INTO `producir`.`productos` (
  `prodCod`,
  `prodCodigo`,
  `prodTipo`,
  `prodDesc`,
  `prodColor`,
  `prodEsp`,
  `prodTipoPl`,
  `prodAlto`,
  `prodAncho`,
  `prodSup`,
  `prodPA`,
  `prodPB`,
  `prodPC`,
  `prodPD`,
  `prodUI`,
  `prodFi`,
  `USUARIO`,
  `ACTUAL`,
  `prodSM`
)
VALUES
  (
    pprodCod,
    pprodCodigo,
    pprodTipo,
    pprodDesc,
    pprodColor,
    pprodEsp,
    pprodTipoPl,
    pprodAlto,
    pprodAncho,
    pprodSup,
    pprodPA,
    pprodPB,
    pprodPC,
    pprodPD,
    pprodUI,
    ACTUAL,
    pprodSM
  );
	END */$$
DELIMITER ;

/* Procedure structure for procedure `pcajaresumen` */

/*!50003 DROP PROCEDURE IF EXISTS  `pcajaresumen` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pcajaresumen`(IN inicio Date, in fin date, in estado CHAR, in unidad INT, in tipov char)
BEGIN
	if unidad = 0 then
		SELECT
		SUM(v.`ventM2`) AS M2,
		SUM(CASE v.`ventEstado` WHEN 'A' THEN 1 ELSE 0 END) AS Anulados,
		SUM(CASE v.`ventCred` WHEN 'S' THEN 1 ELSE 0 END) AS Credito,
		SUM(CASE v.`ventCred` WHEN 'N' THEN 1 ELSE 0 END) AS Contado,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventRecargo` ELSE 0 END) AS RecargoGS,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventDescuento` ELSE 0 END) AS DescuentoGS,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventTotal` ELSE 0 END) AS TotalGS,
		AVG(CASE v.`moneda` WHEN 'G' THEN v.`ventTotal` ELSE NULL END) AS TotalPGS,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventRecargo` ELSE 0 END) AS RecargoDol,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventDescuento` ELSE 0 END) AS DescuentoDol,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventTotal` ELSE 0 END) AS TotalDol,
		AVG(CASE v.`moneda` WHEN 'D' THEN v.`ventTotal` ELSE NULL END) AS TotalPDol,
		COUNT(v.`ventCod`) AS TotalVentas,
		SUM(CASE v.`moneda` WHEN 'G' THEN 1 ELSE 0 END) AS VentasAG,
		SUM(CASE v.`moneda` WHEN 'D' THEN 1 ELSE 0 END) AS VentasAD
		FROM `ventas` v
		WHERE v.`ventFecha` BETWEEN inicio AND fin AND (v.`ventEstado` = estado OR estado = '') and (v.`ventCred` = tipov or tipov = '');
	/*POR UNIDAD*/
	elseif unidad =1 then
		SELECT
		SUM(v.`ventM2`) AS M2,
		SUM(CASE v.`ventEstado` WHEN 'A' THEN 1 ELSE 0 END) AS Anulados,
		SUM(CASE v.`ventCred` WHEN 'S' THEN 1 ELSE 0 END) AS Credito,
		SUM(CASE v.`ventCred` WHEN 'N' THEN 1 ELSE 0 END) AS Contado,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventRecargo` ELSE 0 END) AS RecargoGS,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventDescuento` ELSE 0 END) AS DescuentoGS,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventTotal` ELSE 0 END) AS TotalGS,
		AVG(CASE v.`moneda` WHEN 'G' THEN v.`ventTotal` ELSE NULL END) AS TotalPGS,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventRecargo` ELSE 0 END) AS RecargoDol,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventDescuento` ELSE 0 END) AS DescuentoDol,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventTotal` ELSE 0 END) AS TotalDol,
		AVG(CASE v.`moneda` WHEN 'D' THEN v.`ventTotal` ELSE NULL END) AS TotalPDol,
		COUNT(v.`ventCod`) AS TotalVentas,
		SUM(CASE v.`moneda` WHEN 'G' THEN 1 ELSE 0 END) AS VentasAG,
		SUM(CASE v.`moneda` WHEN 'D' THEN 1 ELSE 0 END) AS VentasAD
		FROM `ventas` v
		WHERE v.`ventFecha` BETWEEN inicio AND fin AND (v.`ventEstado` = estado OR estado = '') AND (v.`ventCred` = tipov OR tipov = '') and v.`ventM2` = 0;
	/*SOLO M2*/
	else
		SELECT
		SUM(v.`ventM2`) AS M2,
		SUM(CASE v.`ventEstado` WHEN 'A' THEN 1 ELSE 0 END) AS Anulados,
		SUM(CASE v.`ventCred` WHEN 'S' THEN 1 ELSE 0 END) AS Credito,
		SUM(CASE v.`ventCred` WHEN 'N' THEN 1 ELSE 0 END) AS Contado,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventRecargo` ELSE 0 END) AS RecargoGS,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventDescuento` ELSE 0 END) AS DescuentoGS,
		SUM(CASE v.`moneda` WHEN 'G' THEN v.`ventTotal` ELSE 0 END) AS TotalGS,
		AVG(CASE v.`moneda` WHEN 'G' THEN v.`ventTotal` ELSE NULL END) AS TotalPGS,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventRecargo` ELSE 0 END) AS RecargoDol,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventDescuento` ELSE 0 END) AS DescuentoDol,
		SUM(CASE v.`moneda` WHEN 'D' THEN v.`ventTotal` ELSE 0 END) AS TotalDol,
		AVG(CASE v.`moneda` WHEN 'D' THEN v.`ventTotal` ELSE NULL END) AS TotalPDol,
		COUNT(v.`ventCod`) AS TotalVentas,
		SUM(CASE v.`moneda` WHEN 'G' THEN 1 ELSE 0 END) AS VentasAG,
		SUM(CASE v.`moneda` WHEN 'D' THEN 1 ELSE 0 END) AS VentasAD
		FROM `ventas` v
		WHERE v.`ventFecha` BETWEEN inicio AND fin AND (v.`ventEstado` = estado OR estado = '') AND (v.`ventCred` = tipov OR tipov = '') AND v.`ventM2` > 0;
	end if;
	
    END */$$
DELIMITER ;

/* Procedure structure for procedure `reportecomprasfecha` */

/*!50003 DROP PROCEDURE IF EXISTS  `reportecomprasfecha` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `reportecomprasfecha`(IN fecha1 DATE, IN fecha2 DATE)
BEGIN
	SELECT * FROM `producir`.`vcomprasfecha` WHERE Estado <> 'A' AND Fecha BETWEEN fecha1 AND fecha2;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `reportetickets` */

/*!50003 DROP PROCEDURE IF EXISTS  `reportetickets` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `reportetickets`(IN inicio int, in fin int )
BEGIN
	select * from `vticketventa` where Produccion between  inicio and fin;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `reporteventasfecha` */

/*!50003 DROP PROCEDURE IF EXISTS  `reporteventasfecha` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `reporteventasfecha`(IN fecha1 Date, in fecha2 Date, IN estadov CHAR, IN unidadv INT, IN tipovv CHAR)
BEGIN
	IF unidadv = 0 THEN
		SELECT * FROM `producir`.`vventasfecha` WHERE  Fecha BETWEEN fecha1 AND fecha2
		and (Estado = estado OR estadov = '' OR estado = NULL) AND (Tipov = tipovv or tipovv = '' or tipovv=null);
	elseif unidadv =1 then
		SELECT * FROM `producir`.`vventasfecha` WHERE  Fecha BETWEEN fecha1 AND fecha2
		AND (Estado = estado OR estado = '' OR estadov = NULL) AND (Tipov = tipovv OR tipovv = '' OR tipovv=NULL) and M2 =0;
	else
		SELECT * FROM `producir`.`vventasfecha` WHERE  Fecha BETWEEN fecha1 AND fecha2
		AND (Estado = estado OR estado = '' OR estadov = NULL) AND (Tipov = tipovv OR tipovv = '' OR tipovv=NULL) AND M2 > 0;
	end if;
	
    END */$$
DELIMITER ;

/*Table structure for table `traerproductos` */

DROP TABLE IF EXISTS `traerproductos`;

/*!50001 DROP VIEW IF EXISTS `traerproductos` */;
/*!50001 DROP TABLE IF EXISTS `traerproductos` */;

/*!50001 CREATE TABLE  `traerproductos`(
 `prodCod` int(11) ,
 `prodTipo` int(11) ,
 `prodDesc` varchar(30) ,
 `prodColor` int(11) ,
 `prodEsp` int(11) ,
 `prodTipoPl` int(11) ,
 `prodAlto` decimal(10,2) ,
 `prodAncho` decimal(10,2) ,
 `prodSup` decimal(10,2) ,
 `prodPA` double ,
 `prodPB` double ,
 `prodPC` double ,
 `prodPD` double ,
 `prodUI` varchar(10) ,
 `prodFi` datetime ,
 `prodUU` varchar(10) ,
 `prodFU` datetime ,
 `prodSM` int(11) 
)*/;

/*Table structure for table `vcajaresumen` */

DROP TABLE IF EXISTS `vcajaresumen`;

/*!50001 DROP VIEW IF EXISTS `vcajaresumen` */;
/*!50001 DROP TABLE IF EXISTS `vcajaresumen` */;

/*!50001 CREATE TABLE  `vcajaresumen`(
 `M2` decimal(32,2) ,
 `Anulados` decimal(23,0) 
)*/;

/*Table structure for table `vcomprasfecha` */

DROP TABLE IF EXISTS `vcomprasfecha`;

/*!50001 DROP VIEW IF EXISTS `vcomprasfecha` */;
/*!50001 DROP TABLE IF EXISTS `vcomprasfecha` */;

/*!50001 CREATE TABLE  `vcomprasfecha`(
 `Código` varchar(20) ,
 `Proveedor` varchar(50) ,
 `OT` int(11) ,
 `Oper` int(11) ,
 `Fecha` date ,
 `Factura` varchar(20) ,
 `Cod` int(11) ,
 `Estado` char(1) ,
 `Cantidad` double ,
 `Producto` varchar(30) ,
 `Precio` double 
)*/;

/*Table structure for table `vdetallecompra` */

DROP TABLE IF EXISTS `vdetallecompra`;

/*!50001 DROP VIEW IF EXISTS `vdetallecompra` */;
/*!50001 DROP TABLE IF EXISTS `vdetallecompra` */;

/*!50001 CREATE TABLE  `vdetallecompra`(
 `ID` int(11) ,
 `Compra` int(11) ,
 `ProdID` int(11) ,
 `Código` varchar(20) ,
 `Producto` varchar(30) ,
 `Cantidad` double ,
 `Exenta` double ,
 `Iva 5%` double ,
 `Iva 10%` double ,
 `Costo` double ,
 `Total` double 
)*/;

/*Table structure for table `vdetallemi` */

DROP TABLE IF EXISTS `vdetallemi`;

/*!50001 DROP VIEW IF EXISTS `vdetallemi` */;
/*!50001 DROP TABLE IF EXISTS `vdetallemi` */;

/*!50001 CREATE TABLE  `vdetallemi`(
 `ID` int(11) ,
 `Mov` int(11) ,
 `ProdID` int(11) ,
 `Código` varchar(20) ,
 `Producto` varchar(30) ,
 `Cantidad` int(11) 
)*/;

/*Table structure for table `vdetalleventa` */

DROP TABLE IF EXISTS `vdetalleventa`;

/*!50001 DROP VIEW IF EXISTS `vdetalleventa` */;
/*!50001 DROP TABLE IF EXISTS `vdetalleventa` */;

/*!50001 CREATE TABLE  `vdetalleventa`(
 `ID` int(11) ,
 `Venta` int(11) ,
 `ProdID` int(11) ,
 `Código` varchar(20) ,
 `Producto` varchar(30) ,
 `Cantidad` decimal(10,2) ,
 `Ancho` decimal(10,2) ,
 `Alto` decimal(10,2) ,
 `Descuento` varchar(8) ,
 `Recargo` varchar(8) ,
 `Superficie` decimal(10,2) ,
 `P. Unitario` double(10,2) ,
 `Total` double(10,2) ,
 `Obra` varchar(30) 
)*/;

/*Table structure for table `vetiquetas` */

DROP TABLE IF EXISTS `vetiquetas`;

/*!50001 DROP VIEW IF EXISTS `vetiquetas` */;
/*!50001 DROP TABLE IF EXISTS `vetiquetas` */;

/*!50001 CREATE TABLE  `vetiquetas`(
 `Panho` int(11) ,
 `Produccion` int(11) ,
 `Venta` int(11) ,
 `Alto` decimal(10,2) ,
 `Ancho` decimal(10,2) ,
 `Superficie` decimal(10,2) ,
 `Impreso` varchar(2) 
)*/;

/*Table structure for table `vlistadobancos` */

DROP TABLE IF EXISTS `vlistadobancos`;

/*!50001 DROP VIEW IF EXISTS `vlistadobancos` */;
/*!50001 DROP TABLE IF EXISTS `vlistadobancos` */;

/*!50001 CREATE TABLE  `vlistadobancos`(
 `ID` int(11) ,
 `Nombre` varchar(30) 
)*/;

/*Table structure for table `vlistadoclientes` */

DROP TABLE IF EXISTS `vlistadoclientes`;

/*!50001 DROP VIEW IF EXISTS `vlistadoclientes` */;
/*!50001 DROP TABLE IF EXISTS `vlistadoclientes` */;

/*!50001 CREATE TABLE  `vlistadoclientes`(
 `ID` int(11) ,
 `Nombre` varchar(100) ,
 `CI` varchar(10) ,
 `RUC` varchar(20) ,
 `Tipo` varchar(20) ,
 `Insertado por` varchar(100) ,
 `Última actualización` varchar(100) ,
 `Fecha actualización` datetime 
)*/;

/*Table structure for table `vlistadocolores` */

DROP TABLE IF EXISTS `vlistadocolores`;

/*!50001 DROP VIEW IF EXISTS `vlistadocolores` */;
/*!50001 DROP TABLE IF EXISTS `vlistadocolores` */;

/*!50001 CREATE TABLE  `vlistadocolores`(
 `ID` int(11) ,
 `Color` varchar(20) 
)*/;

/*Table structure for table `vlistadodepositos` */

DROP TABLE IF EXISTS `vlistadodepositos`;

/*!50001 DROP VIEW IF EXISTS `vlistadodepositos` */;
/*!50001 DROP TABLE IF EXISTS `vlistadodepositos` */;

/*!50001 CREATE TABLE  `vlistadodepositos`(
 `ID` int(11) ,
 `Nombre` varchar(15) 
)*/;

/*Table structure for table `vlistadoespesores` */

DROP TABLE IF EXISTS `vlistadoespesores`;

/*!50001 DROP VIEW IF EXISTS `vlistadoespesores` */;
/*!50001 DROP TABLE IF EXISTS `vlistadoespesores` */;

/*!50001 CREATE TABLE  `vlistadoespesores`(
 `ID` int(11) ,
 `Espesor` int(11) 
)*/;

/*Table structure for table `vlistadoproductos` */

DROP TABLE IF EXISTS `vlistadoproductos`;

/*!50001 DROP VIEW IF EXISTS `vlistadoproductos` */;
/*!50001 DROP TABLE IF EXISTS `vlistadoproductos` */;

/*!50001 CREATE TABLE  `vlistadoproductos`(
 `ID` int(11) ,
 `Código` varchar(20) ,
 `Descripción` varchar(30) ,
 `Tipo` varchar(30) ,
 `Alta` varchar(100) ,
 `Fecha alta` datetime ,
 `Última mod` varchar(100) ,
 `Fecha Última mod.` datetime 
)*/;

/*Table structure for table `vlistadoproveedores` */

DROP TABLE IF EXISTS `vlistadoproveedores`;

/*!50001 DROP VIEW IF EXISTS `vlistadoproveedores` */;
/*!50001 DROP TABLE IF EXISTS `vlistadoproveedores` */;

/*!50001 CREATE TABLE  `vlistadoproveedores`(
 `ID` int(11) ,
 `Nombre` varchar(50) ,
 `RUC` varchar(20) ,
 `Telefono` varchar(20) 
)*/;

/*Table structure for table `vlistadospagosventa` */

DROP TABLE IF EXISTS `vlistadospagosventa`;

/*!50001 DROP VIEW IF EXISTS `vlistadospagosventa` */;
/*!50001 DROP TABLE IF EXISTS `vlistadospagosventa` */;

/*!50001 CREATE TABLE  `vlistadospagosventa`(
 `ID` int(11) ,
 `Venta` int(11) ,
 `Fecha` datetime ,
 `Tipo Pago` varchar(30) ,
 `Monto` double ,
 `Recibo Nro.` varchar(30) 
)*/;

/*Table structure for table `vlistadosucursales` */

DROP TABLE IF EXISTS `vlistadosucursales`;

/*!50001 DROP VIEW IF EXISTS `vlistadosucursales` */;
/*!50001 DROP TABLE IF EXISTS `vlistadosucursales` */;

/*!50001 CREATE TABLE  `vlistadosucursales`(
 `ID` int(11) ,
 `Nombre` varchar(20) ,
 `Depósito` varchar(15) 
)*/;

/*Table structure for table `vlistadosucursalesdep` */

DROP TABLE IF EXISTS `vlistadosucursalesdep`;

/*!50001 DROP VIEW IF EXISTS `vlistadosucursalesdep` */;
/*!50001 DROP TABLE IF EXISTS `vlistadosucursalesdep` */;

/*!50001 CREATE TABLE  `vlistadosucursalesdep`(
 `ID` int(11) ,
 `Nombre` varchar(20) ,
 `IDD` int(11) ,
 `Depósito` varchar(15) 
)*/;

/*Table structure for table `vlistadotipoc` */

DROP TABLE IF EXISTS `vlistadotipoc`;

/*!50001 DROP VIEW IF EXISTS `vlistadotipoc` */;
/*!50001 DROP TABLE IF EXISTS `vlistadotipoc` */;

/*!50001 CREATE TABLE  `vlistadotipoc`(
 `ID` int(11) ,
 `Nombre` varchar(20) 
)*/;

/*Table structure for table `vlistadotipoplancha` */

DROP TABLE IF EXISTS `vlistadotipoplancha`;

/*!50001 DROP VIEW IF EXISTS `vlistadotipoplancha` */;
/*!50001 DROP TABLE IF EXISTS `vlistadotipoplancha` */;

/*!50001 CREATE TABLE  `vlistadotipoplancha`(
 `ID` int(11) ,
 `Tipo` varchar(20) 
)*/;

/*Table structure for table `vlistadotipoprod` */

DROP TABLE IF EXISTS `vlistadotipoprod`;

/*!50001 DROP VIEW IF EXISTS `vlistadotipoprod` */;
/*!50001 DROP TABLE IF EXISTS `vlistadotipoprod` */;

/*!50001 CREATE TABLE  `vlistadotipoprod`(
 `ID` int(11) ,
 `Tipo` varchar(30) 
)*/;

/*Table structure for table `vlistadotipospagos` */

DROP TABLE IF EXISTS `vlistadotipospagos`;

/*!50001 DROP VIEW IF EXISTS `vlistadotipospagos` */;
/*!50001 DROP TABLE IF EXISTS `vlistadotipospagos` */;

/*!50001 CREATE TABLE  `vlistadotipospagos`(
 `ID` int(11) ,
 `Tipo` varchar(30) 
)*/;

/*Table structure for table `vlistadousuarios` */

DROP TABLE IF EXISTS `vlistadousuarios`;

/*!50001 DROP VIEW IF EXISTS `vlistadousuarios` */;
/*!50001 DROP TABLE IF EXISTS `vlistadousuarios` */;

/*!50001 CREATE TABLE  `vlistadousuarios`(
 `Código` varchar(10) ,
 `Nombre` varchar(100) ,
 `Nivel` int(11) ,
 `Estado` varchar(8) 
)*/;

/*Table structure for table `vlistadovendedores` */

DROP TABLE IF EXISTS `vlistadovendedores`;

/*!50001 DROP VIEW IF EXISTS `vlistadovendedores` */;
/*!50001 DROP TABLE IF EXISTS `vlistadovendedores` */;

/*!50001 CREATE TABLE  `vlistadovendedores`(
 `ID` int(11) ,
 `Nombre` varchar(50) ,
 `Celular` varchar(15) ,
 `Porcentaje` varchar(16) 
)*/;

/*Table structure for table `vlistadoventascliente` */

DROP TABLE IF EXISTS `vlistadoventascliente`;

/*!50001 DROP VIEW IF EXISTS `vlistadoventascliente` */;
/*!50001 DROP TABLE IF EXISTS `vlistadoventascliente` */;

/*!50001 CREATE TABLE  `vlistadoventascliente`(
 `ID` int(11) ,
 `Fecha` date ,
 `Factura` varchar(25) ,
 `ClienteCod` int(11) ,
 `Cliente` varchar(100) ,
 `Estado` varchar(9) 
)*/;

/*Table structure for table `vmovimientosinternos` */

DROP TABLE IF EXISTS `vmovimientosinternos`;

/*!50001 DROP VIEW IF EXISTS `vmovimientosinternos` */;
/*!50001 DROP TABLE IF EXISTS `vmovimientosinternos` */;

/*!50001 CREATE TABLE  `vmovimientosinternos`(
 `ID` int(11) ,
 `SO` int(11) ,
 `SD` int(11) ,
 `Solicitante` varchar(30) ,
 `Autorizador` varchar(30) ,
 `Fecha` date ,
 `Estado` varchar(7) 
)*/;

/*Table structure for table `vplanosventa` */

DROP TABLE IF EXISTS `vplanosventa`;

/*!50001 DROP VIEW IF EXISTS `vplanosventa` */;
/*!50001 DROP TABLE IF EXISTS `vplanosventa` */;

/*!50001 CREATE TABLE  `vplanosventa`(
 `ID` int(11) ,
 `Nombre` varchar(300) ,
 `Fecha` date ,
 `Venta` int(11) 
)*/;

/*Table structure for table `vstockproductos` */

DROP TABLE IF EXISTS `vstockproductos`;

/*!50001 DROP VIEW IF EXISTS `vstockproductos` */;
/*!50001 DROP TABLE IF EXISTS `vstockproductos` */;

/*!50001 CREATE TABLE  `vstockproductos`(
 `Producto` varchar(30) ,
 `Cod` int(20) ,
 `Stock` decimal(32,0) 
)*/;

/*Table structure for table `vstockproductosdet` */

DROP TABLE IF EXISTS `vstockproductosdet`;

/*!50001 DROP VIEW IF EXISTS `vstockproductosdet` */;
/*!50001 DROP TABLE IF EXISTS `vstockproductosdet` */;

/*!50001 CREATE TABLE  `vstockproductosdet`(
 `Producto` varchar(30) ,
 `Sucursal` varchar(20) ,
 `ID` int(20) ,
 `Código` varchar(20) ,
 `Stock` decimal(32,0) ,
 `Stock mínimo` int(11) ,
 `Tipo` varchar(30) 
)*/;

/*Table structure for table `vstockproductossuc` */

DROP TABLE IF EXISTS `vstockproductossuc`;

/*!50001 DROP VIEW IF EXISTS `vstockproductossuc` */;
/*!50001 DROP TABLE IF EXISTS `vstockproductossuc` */;

/*!50001 CREATE TABLE  `vstockproductossuc`(
 `IDP` int(11) ,
 `Producto` varchar(30) ,
 `IDS` int(11) ,
 `Sucursal` varchar(20) ,
 `IDD` int(11) ,
 `Deposito` varchar(15) ,
 `ID` int(20) ,
 `Código` varchar(20) ,
 `Stock` decimal(32,0) ,
 `Stock mínimo` int(11) ,
 `Tipo` varchar(30) 
)*/;

/*Table structure for table `vticketventa` */

DROP TABLE IF EXISTS `vticketventa`;

/*!50001 DROP VIEW IF EXISTS `vticketventa` */;
/*!50001 DROP TABLE IF EXISTS `vticketventa` */;

/*!50001 CREATE TABLE  `vticketventa`(
 `Venta` int(11) ,
 `Produccion` int(11) ,
 `Sup` decimal(24,8) ,
 `Obra` varchar(30) ,
 `Alto` decimal(10,2) ,
 `Ancho` decimal(10,2) ,
 `Obs` varchar(100) ,
 `Detalle` int(11) ,
 `CliCod` int(11) ,
 `Cliente` varchar(100) ,
 `CodProd` varchar(20) ,
 `Producto` varchar(30) ,
 `Panhos` bigint(21) 
)*/;

/*Table structure for table `vventascaja` */

DROP TABLE IF EXISTS `vventascaja`;

/*!50001 DROP VIEW IF EXISTS `vventascaja` */;
/*!50001 DROP TABLE IF EXISTS `vventascaja` */;

/*!50001 CREATE TABLE  `vventascaja`(
 `ID` int(11) ,
 `Fecha` date ,
 `Tipo` varchar(7) ,
 `Cliente` varchar(100) ,
 `Total` double(10,3) ,
 `M2` decimal(10,2) ,
 `Estado` varchar(9) 
)*/;

/*Table structure for table `vventasfecha` */

DROP TABLE IF EXISTS `vventasfecha`;

/*!50001 DROP VIEW IF EXISTS `vventasfecha` */;
/*!50001 DROP TABLE IF EXISTS `vventasfecha` */;

/*!50001 CREATE TABLE  `vventasfecha`(
 `Código` int(11) ,
 `Cliente` varchar(100) ,
 `OT` int(11) ,
 `Oper` int(11) ,
 `Fecha` date ,
 `Factura` varchar(25) ,
 `Cod` int(11) ,
 `Estado` char(1) ,
 `Cantidad` decimal(10,2) ,
 `Producto` varchar(30) ,
 `Superficie` decimal(10,2) ,
 `Venta` double(10,2) ,
 `Obra` varchar(30) ,
 `Tipov` char(1) ,
 `M2` decimal(10,2) 
)*/;

/*View structure for view traerproductos */

/*!50001 DROP TABLE IF EXISTS `traerproductos` */;
/*!50001 DROP VIEW IF EXISTS `traerproductos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `traerproductos` AS select `productos`.`prodCod` AS `prodCod`,`productos`.`prodTipo` AS `prodTipo`,`productos`.`prodDesc` AS `prodDesc`,`productos`.`prodColor` AS `prodColor`,`productos`.`prodEsp` AS `prodEsp`,`productos`.`prodTipoPl` AS `prodTipoPl`,`productos`.`prodAlto` AS `prodAlto`,`productos`.`prodAncho` AS `prodAncho`,`productos`.`prodSup` AS `prodSup`,`productos`.`prodPA` AS `prodPA`,`productos`.`prodPB` AS `prodPB`,`productos`.`prodPC` AS `prodPC`,`productos`.`prodPD` AS `prodPD`,`productos`.`prodUI` AS `prodUI`,`productos`.`prodFi` AS `prodFi`,`productos`.`prodUU` AS `prodUU`,`productos`.`prodFU` AS `prodFU`,`productos`.`prodSM` AS `prodSM` from `productos` */;

/*View structure for view vcajaresumen */

/*!50001 DROP TABLE IF EXISTS `vcajaresumen` */;
/*!50001 DROP VIEW IF EXISTS `vcajaresumen` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vcajaresumen` AS select sum(`v`.`ventM2`) AS `M2`,sum((case `v`.`ventEstado` when 'A' then 1 end)) AS `Anulados` from `ventas` `v` */;

/*View structure for view vcomprasfecha */

/*!50001 DROP TABLE IF EXISTS `vcomprasfecha` */;
/*!50001 DROP VIEW IF EXISTS `vcomprasfecha` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vcomprasfecha` AS select `p`.`prodCodigo` AS `Código`,`pr`.`provNombre` AS `Proveedor`,`c`.`comprasCod` AS `OT`,`c`.`opeCod` AS `Oper`,`c`.`comprasFchFact` AS `Fecha`,`c`.`comprasNroFact` AS `Factura`,`d`.`prodCod` AS `Cod`,`c`.`comprasEstado` AS `Estado`,`d`.`comprasDetCantidad` AS `Cantidad`,`p`.`prodDesc` AS `Producto`,((`d`.`comprasDetCantidad` * `d`.`comprasDetCosto`) - `d`.`comprasDetExenta`) AS `Precio` from (((`compras` `c` join `comprasdet` `d` on((`d`.`comprasCod` = `c`.`comprasCod`))) join `proveedor` `pr` on((`pr`.`provCod` = `c`.`provCod`))) join `productos` `p` on((`p`.`prodCod` = `d`.`prodCod`))) */;

/*View structure for view vdetallecompra */

/*!50001 DROP TABLE IF EXISTS `vdetallecompra` */;
/*!50001 DROP VIEW IF EXISTS `vdetallecompra` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vdetallecompra` AS select `d`.`comprasDetCod` AS `ID`,`d`.`comprasCod` AS `Compra`,`d`.`prodCod` AS `ProdID`,`p`.`prodCodigo` AS `Código`,`p`.`prodDesc` AS `Producto`,`d`.`comprasDetCantidad` AS `Cantidad`,`d`.`comprasDetExenta` AS `Exenta`,`d`.`comprasDet5` AS `Iva 5%`,`d`.`comprasDet10` AS `Iva 10%`,`d`.`comprasDetCosto` AS `Costo`,((`d`.`comprasDetCantidad` * `d`.`comprasDetCosto`) - `d`.`comprasDetExenta`) AS `Total` from (`comprasdet` `d` join `productos` `p` on((`p`.`prodCod` = `d`.`prodCod`))) */;

/*View structure for view vdetallemi */

/*!50001 DROP TABLE IF EXISTS `vdetallemi` */;
/*!50001 DROP VIEW IF EXISTS `vdetallemi` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vdetallemi` AS select `d`.`idDetalle` AS `ID`,`d`.`idMov` AS `Mov`,`d`.`prodId` AS `ProdID`,`p`.`prodCodigo` AS `Código`,`p`.`prodDesc` AS `Producto`,`d`.`cantidad` AS `Cantidad` from (`movinternodetalle` `d` join `productos` `p` on((`p`.`prodCod` = `d`.`prodId`))) */;

/*View structure for view vdetalleventa */

/*!50001 DROP TABLE IF EXISTS `vdetalleventa` */;
/*!50001 DROP VIEW IF EXISTS `vdetalleventa` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vdetalleventa` AS select `d`.`ventDetcod` AS `ID`,`v`.`ventCod` AS `Venta`,`d`.`prodCod` AS `ProdID`,`p`.`prodCodigo` AS `Código`,`p`.`prodDesc` AS `Producto`,`d`.`ventDetCantidad` AS `Cantidad`,`d`.`ventDetAncho` AS `Ancho`,`d`.`ventDetAlto` AS `Alto`,concat((`d`.`ventDetDescuento` * 100),'%') AS `Descuento`,concat((`d`.`ventDetRecargo` * 100),'%') AS `Recargo`,`d`.`ventDetSup` AS `Superficie`,`d`.`ventDetPrecioUnit` AS `P. Unitario`,`d`.`ventDetPrecioReal` AS `Total`,`d`.`ventDetObra` AS `Obra` from ((`ventasdet` `d` join `ventas` `v` on((`d`.`ventCod` = `v`.`ventCod`))) join `productos` `p` on((`p`.`prodCod` = `d`.`prodCod`))) */;

/*View structure for view vetiquetas */

/*!50001 DROP TABLE IF EXISTS `vetiquetas` */;
/*!50001 DROP VIEW IF EXISTS `vetiquetas` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vetiquetas` AS select `p`.`pPanho` AS `Panho`,`p`.`pCod` AS `Produccion`,`p`.`ventCod` AS `Venta`,`dv`.`ventDetAlto` AS `Alto`,`dv`.`ventDetAncho` AS `Ancho`,`dv`.`ventDetSup` AS `Superficie`,(case `p`.`produccion_ticket` when 'S' then 'Si' when 'N' then 'No' end) AS `Impreso` from ((`produccion` `p` join `ventas` `v` on((`v`.`ventCod` = `p`.`ventCod`))) join `ventasdet` `dv` on((`dv`.`ventDetcod` = `p`.`ventDetCod`))) group by `p`.`pCod` */;

/*View structure for view vlistadobancos */

/*!50001 DROP TABLE IF EXISTS `vlistadobancos` */;
/*!50001 DROP VIEW IF EXISTS `vlistadobancos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadobancos` AS select `bancos`.`banCod` AS `ID`,`bancos`.`banNombre` AS `Nombre` from `bancos` */;

/*View structure for view vlistadoclientes */

/*!50001 DROP TABLE IF EXISTS `vlistadoclientes` */;
/*!50001 DROP VIEW IF EXISTS `vlistadoclientes` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadoclientes` AS select `c`.`clieCod` AS `ID`,`c`.`clieNombre` AS `Nombre`,`c`.`clieCi` AS `CI`,`c`.`clieRuc` AS `RUC`,`t`.`tclieDesc` AS `Tipo`,`u1`.`usuNombre` AS `Insertado por`,`u2`.`usuNombre` AS `Última actualización`,`c`.`clieFU` AS `Fecha actualización` from (((`clientes` `c` join `usuario` `u1` on((`u1`.`usuCod` = `c`.`clieUI`))) join `usuario` `u2` on((`u2`.`usuCod` = `c`.`clieUU`))) join `tipocliente` `t` on((`t`.`tclieCod` = `c`.`tclieCod`))) */;

/*View structure for view vlistadocolores */

/*!50001 DROP TABLE IF EXISTS `vlistadocolores` */;
/*!50001 DROP VIEW IF EXISTS `vlistadocolores` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadocolores` AS select `color`.`colorCod` AS `ID`,`color`.`color` AS `Color` from `color` */;

/*View structure for view vlistadodepositos */

/*!50001 DROP TABLE IF EXISTS `vlistadodepositos` */;
/*!50001 DROP VIEW IF EXISTS `vlistadodepositos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadodepositos` AS select `deposito`.`depoCod` AS `ID`,`deposito`.`depoDesc` AS `Nombre` from `deposito` */;

/*View structure for view vlistadoespesores */

/*!50001 DROP TABLE IF EXISTS `vlistadoespesores` */;
/*!50001 DROP VIEW IF EXISTS `vlistadoespesores` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadoespesores` AS select `espesor`.`espesorCod` AS `ID`,`espesor`.`espesor` AS `Espesor` from `espesor` */;

/*View structure for view vlistadoproductos */

/*!50001 DROP TABLE IF EXISTS `vlistadoproductos` */;
/*!50001 DROP VIEW IF EXISTS `vlistadoproductos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadoproductos` AS select `p`.`prodCod` AS `ID`,`p`.`prodCodigo` AS `Código`,`p`.`prodDesc` AS `Descripción`,`t`.`prodTipo` AS `Tipo`,`u`.`usuNombre` AS `Alta`,`p`.`prodFi` AS `Fecha alta`,`u2`.`usuNombre` AS `Última mod`,`p`.`prodFU` AS `Fecha Última mod.` from (((`productos` `p` join `prodtipo` `t` on((`p`.`prodTipo` = `t`.`prodTipocod`))) join `usuario` `u` on((`u`.`usuCod` = `p`.`prodUI`))) join `usuario` `u2` on((`u2`.`usuCod` = `p`.`prodUU`))) */;

/*View structure for view vlistadoproveedores */

/*!50001 DROP TABLE IF EXISTS `vlistadoproveedores` */;
/*!50001 DROP VIEW IF EXISTS `vlistadoproveedores` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadoproveedores` AS select `proveedor`.`provCod` AS `ID`,`proveedor`.`provNombre` AS `Nombre`,`proveedor`.`provRuc` AS `RUC`,`proveedor`.`provTelefono` AS `Telefono` from `proveedor` */;

/*View structure for view vlistadospagosventa */

/*!50001 DROP TABLE IF EXISTS `vlistadospagosventa` */;
/*!50001 DROP VIEW IF EXISTS `vlistadospagosventa` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadospagosventa` AS select `p`.`pagoCod` AS `ID`,`p`.`ventCod` AS `Venta`,`p`.`pagoFecha` AS `Fecha`,`t`.`tpadoDesc` AS `Tipo Pago`,`p`.`pagoMonto` AS `Monto`,`p`.`pagoNroRecibo` AS `Recibo Nro.` from (`pagos` `p` join `tipopago` `t` on((`t`.`tpagoCod` = `p`.`tpagoCod`))) */;

/*View structure for view vlistadosucursales */

/*!50001 DROP TABLE IF EXISTS `vlistadosucursales` */;
/*!50001 DROP VIEW IF EXISTS `vlistadosucursales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadosucursales` AS select `s`.`sucCod` AS `ID`,`s`.`sucDesc` AS `Nombre`,`d`.`depoDesc` AS `Depósito` from (`sucursales` `s` join `deposito` `d` on((`d`.`depoCod` = `s`.`depoCod`))) */;

/*View structure for view vlistadosucursalesdep */

/*!50001 DROP TABLE IF EXISTS `vlistadosucursalesdep` */;
/*!50001 DROP VIEW IF EXISTS `vlistadosucursalesdep` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadosucursalesdep` AS select `s`.`sucCod` AS `ID`,`s`.`sucDesc` AS `Nombre`,`d`.`depoCod` AS `IDD`,`d`.`depoDesc` AS `Depósito` from (`sucursales` `s` join `deposito` `d` on((`d`.`depoCod` = `s`.`depoCod`))) */;

/*View structure for view vlistadotipoc */

/*!50001 DROP TABLE IF EXISTS `vlistadotipoc` */;
/*!50001 DROP VIEW IF EXISTS `vlistadotipoc` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadotipoc` AS select `tipocliente`.`tclieCod` AS `ID`,`tipocliente`.`tclieDesc` AS `Nombre` from `tipocliente` */;

/*View structure for view vlistadotipoplancha */

/*!50001 DROP TABLE IF EXISTS `vlistadotipoplancha` */;
/*!50001 DROP VIEW IF EXISTS `vlistadotipoplancha` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadotipoplancha` AS select `tipoplancha`.`tipoCod` AS `ID`,`tipoplancha`.`tipo` AS `Tipo` from `tipoplancha` */;

/*View structure for view vlistadotipoprod */

/*!50001 DROP TABLE IF EXISTS `vlistadotipoprod` */;
/*!50001 DROP VIEW IF EXISTS `vlistadotipoprod` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadotipoprod` AS select `prodtipo`.`prodTipocod` AS `ID`,`prodtipo`.`prodTipo` AS `Tipo` from `prodtipo` */;

/*View structure for view vlistadotipospagos */

/*!50001 DROP TABLE IF EXISTS `vlistadotipospagos` */;
/*!50001 DROP VIEW IF EXISTS `vlistadotipospagos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadotipospagos` AS select `t`.`tpagoCod` AS `ID`,`t`.`tpadoDesc` AS `Tipo` from `tipopago` `t` */;

/*View structure for view vlistadousuarios */

/*!50001 DROP TABLE IF EXISTS `vlistadousuarios` */;
/*!50001 DROP VIEW IF EXISTS `vlistadousuarios` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadousuarios` AS select `usuario`.`usuCod` AS `Código`,`usuario`.`usuNombre` AS `Nombre`,`usuario`.`usuNivel` AS `Nivel`,(case `usuario`.`usuEstado` when 'A' then 'Activo' when 'I' then 'Inactivo' end) AS `Estado` from `usuario` */;

/*View structure for view vlistadovendedores */

/*!50001 DROP TABLE IF EXISTS `vlistadovendedores` */;
/*!50001 DROP VIEW IF EXISTS `vlistadovendedores` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadovendedores` AS select `vendedores`.`vendCod` AS `ID`,`vendedores`.`vendNombre` AS `Nombre`,`vendedores`.`vendCel` AS `Celular`,concat((`vendedores`.`vendPorc` * 100),'%') AS `Porcentaje` from `vendedores` */;

/*View structure for view vlistadoventascliente */

/*!50001 DROP TABLE IF EXISTS `vlistadoventascliente` */;
/*!50001 DROP VIEW IF EXISTS `vlistadoventascliente` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadoventascliente` AS select `v`.`ventCod` AS `ID`,`v`.`ventFecha` AS `Fecha`,`v`.`ventFact` AS `Factura`,`v`.`clieCod` AS `ClienteCod`,`c`.`clieNombre` AS `Cliente`,(case `v`.`ventEstado` when 'A' then 'Anulado' when 'P' then 'Pendiente' when 'D' then 'Devuelto' when 'C' then 'Cobrado' end) AS `Estado` from (`ventas` `v` join `clientes` `c` on((`c`.`clieCod` = `v`.`clieCod`))) */;

/*View structure for view vmovimientosinternos */

/*!50001 DROP TABLE IF EXISTS `vmovimientosinternos` */;
/*!50001 DROP VIEW IF EXISTS `vmovimientosinternos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vmovimientosinternos` AS select `mi`.`id` AS `ID`,`mi`.`sucursalOrigen` AS `SO`,`mi`.`sucursalDestino` AS `SD`,`mi`.`solicitante` AS `Solicitante`,`mi`.`autorizado` AS `Autorizador`,`mi`.`fecha` AS `Fecha`,(case `mi`.`estado` when 'A' then 'Anulado' when 'B' then 'Activo' end) AS `Estado` from `movinterno` `mi` */;

/*View structure for view vplanosventa */

/*!50001 DROP TABLE IF EXISTS `vplanosventa` */;
/*!50001 DROP VIEW IF EXISTS `vplanosventa` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vplanosventa` AS select `p`.`id_plano` AS `ID`,`p`.`nombre_plano` AS `Nombre`,`p`.`fecha` AS `Fecha`,`p`.`id_venta` AS `Venta` from `planos` `p` */;

/*View structure for view vstockproductos */

/*!50001 DROP TABLE IF EXISTS `vstockproductos` */;
/*!50001 DROP VIEW IF EXISTS `vstockproductos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstockproductos` AS select `p`.`prodDesc` AS `Producto`,`s`.`prodCodigo` AS `Cod`,sum((case when (`s`.`stEstado` = 'B') then `s`.`stCantidad` else 0 end)) AS `Stock` from (`stock` `s` join `productos` `p` on((`p`.`prodCod` = `s`.`prodCodigo`))) group by `s`.`prodCodigo` */;

/*View structure for view vstockproductosdet */

/*!50001 DROP TABLE IF EXISTS `vstockproductosdet` */;
/*!50001 DROP VIEW IF EXISTS `vstockproductosdet` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstockproductosdet` AS select `p`.`prodDesc` AS `Producto`,`suc`.`sucDesc` AS `Sucursal`,`s`.`prodCodigo` AS `ID`,`p`.`prodCodigo` AS `Código`,sum((case when (`s`.`stEstado` = 'B') then `s`.`stCantidad` else 0 end)) AS `Stock`,`p`.`prodSM` AS `Stock mínimo`,`t`.`prodTipo` AS `Tipo` from (((`stock` `s` join `productos` `p` on((`p`.`prodCod` = `s`.`prodCodigo`))) join `prodtipo` `t` on((`t`.`prodTipocod` = `p`.`prodTipo`))) join `sucursales` `suc` on((`suc`.`sucCod` = `s`.`sucCod`))) group by `s`.`prodCodigo`,`s`.`sucCod` */;

/*View structure for view vstockproductossuc */

/*!50001 DROP TABLE IF EXISTS `vstockproductossuc` */;
/*!50001 DROP VIEW IF EXISTS `vstockproductossuc` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstockproductossuc` AS select `p`.`prodCod` AS `IDP`,`p`.`prodDesc` AS `Producto`,`suc`.`sucCod` AS `IDS`,`suc`.`sucDesc` AS `Sucursal`,`d`.`depoCod` AS `IDD`,`d`.`depoDesc` AS `Deposito`,`s`.`prodCodigo` AS `ID`,`p`.`prodCodigo` AS `Código`,sum((case when (`s`.`stEstado` = 'B') then `s`.`stCantidad` else 0 end)) AS `Stock`,`p`.`prodSM` AS `Stock mínimo`,`t`.`prodTipo` AS `Tipo` from ((((`stock` `s` join `productos` `p` on((`p`.`prodCod` = `s`.`prodCodigo`))) join `prodtipo` `t` on((`t`.`prodTipocod` = `p`.`prodTipo`))) join `sucursales` `suc` on((`suc`.`sucCod` = `s`.`sucCod`))) join `deposito` `d` on((`d`.`depoCod` = `s`.`depoCod`))) group by `s`.`prodCodigo`,`s`.`sucCod` */;

/*View structure for view vticketventa */

/*!50001 DROP TABLE IF EXISTS `vticketventa` */;
/*!50001 DROP VIEW IF EXISTS `vticketventa` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vticketventa` AS select `p`.`ventCod` AS `Venta`,`p`.`pCod` AS `Produccion`,((`dv`.`ventDetAlto` * `dv`.`ventDetAncho`) / 1000000) AS `Sup`,`dv`.`ventDetObra` AS `Obra`,`dv`.`ventDetAlto` AS `Alto`,`dv`.`ventDetAncho` AS `Ancho`,`v`.`ventObs` AS `Obs`,`p`.`produccion_detalle` AS `Detalle`,`c`.`clieCod` AS `CliCod`,`c`.`clieNombre` AS `Cliente`,`pr`.`prodCodigo` AS `CodProd`,`pr`.`prodDesc` AS `Producto`,`ng`.`auxPan` AS `Panhos` from ((((((`produccion` `p` join `ventas` `v` on((`v`.`ventCod` = `p`.`ventCod`))) join `clientes` `c` on((`c`.`clieCod` = `v`.`clieCod`))) join `producciondetalle` `pd` on((`pd`.`id` = `p`.`produccion_detalle`))) join `productos` `pr` on((`pr`.`prodCod` = `pd`.`prod_id`))) join `ventasdet` `dv` on((`v`.`ventCod` = `dv`.`ventCod`))) join (select `aux`.`ventCod` AS `ventaaux`,count(0) AS `auxPan` from `produccion` `aux` group by `ventaaux`) `ng`) group by `Produccion` */;

/*View structure for view vventascaja */

/*!50001 DROP TABLE IF EXISTS `vventascaja` */;
/*!50001 DROP VIEW IF EXISTS `vventascaja` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vventascaja` AS select `v`.`ventCod` AS `ID`,`v`.`ventFecha` AS `Fecha`,(case `v`.`ventCred` when 'S' then 'Crédito' else 'Contado' end) AS `Tipo`,`c`.`clieNombre` AS `Cliente`,`v`.`ventTotal` AS `Total`,`v`.`ventM2` AS `M2`,(case `v`.`ventEstado` when 'A' then 'Anulado' when 'C' then 'Cobrado' when 'D' then 'Devuelto' when 'P' then 'Pendiente' end) AS `Estado` from (`ventas` `v` join `clientes` `c` on((`c`.`clieCod` = `v`.`clieCod`))) */;

/*View structure for view vventasfecha */

/*!50001 DROP TABLE IF EXISTS `vventasfecha` */;
/*!50001 DROP VIEW IF EXISTS `vventasfecha` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vventasfecha` AS select `c`.`clieCod` AS `Código`,`c`.`clieNombre` AS `Cliente`,`v`.`ventCod` AS `OT`,`v`.`opeCod` AS `Oper`,`v`.`ventFecha` AS `Fecha`,`v`.`ventFact` AS `Factura`,`d`.`prodCod` AS `Cod`,`v`.`ventEstado` AS `Estado`,`d`.`ventDetCantidad` AS `Cantidad`,`p`.`prodDesc` AS `Producto`,`d`.`ventDetSup` AS `Superficie`,`d`.`ventDetPrecioReal` AS `Venta`,`d`.`ventDetObra` AS `Obra`,`v`.`ventCred` AS `Tipov`,`v`.`ventM2` AS `M2` from (((`ventas` `v` join `ventasdet` `d` on((`d`.`ventCod` = `v`.`ventCod`))) join `productos` `p` on((`p`.`prodCod` = `d`.`prodCod`))) join `clientes` `c` on((`c`.`clieCod` = `v`.`clieCod`))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
