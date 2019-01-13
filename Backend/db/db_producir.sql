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
CREATE DATABASE /*!32312 IF NOT EXISTS*/`producir` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `producir`;

/*Table structure for table `color` */

DROP TABLE IF EXISTS `color`;

CREATE TABLE `color` (
  `colorCod` int(11) NOT NULL AUTO_INCREMENT,
  `color` varchar(20) NOT NULL,
  PRIMARY KEY (`colorCod`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;

/*Table structure for table `espesor` */

DROP TABLE IF EXISTS `espesor`;

CREATE TABLE `espesor` (
  `espesorCod` int(11) NOT NULL AUTO_INCREMENT,
  `espesor` int(11) DEFAULT NULL,
  PRIMARY KEY (`espesorCod`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Table structure for table `prodtipo` */

DROP TABLE IF EXISTS `prodtipo`;

CREATE TABLE `prodtipo` (
  `prodTipocod` int(11) NOT NULL AUTO_INCREMENT,
  `prodTipo` varchar(30) NOT NULL,
  PRIMARY KEY (`prodTipocod`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

/*Table structure for table `productos` */

DROP TABLE IF EXISTS `productos`;

CREATE TABLE `productos` (
  `prodCod` int(11) NOT NULL AUTO_INCREMENT,
  `prodCodigo` varchar(20) NOT NULL,
  `prodTipo` int(11) NOT NULL,
  `prodDesc` varchar(30) NOT NULL,
  `prodColor` int(11) DEFAULT NULL,
  `prodEsp` int(11) DEFAULT NULL,
  `prodTipoPl` int(11) DEFAULT NULL,
  `prodAlto` decimal(10,2) DEFAULT NULL,
  `prodAncho` decimal(10,2) DEFAULT NULL,
  `prodSup` decimal(10,2) DEFAULT NULL,
  `prodPA` double NOT NULL,
  `prodPB` double NOT NULL,
  `prodPC` double NOT NULL,
  `prodPD` double NOT NULL,
  `prodUI` varchar(10) DEFAULT NULL COMMENT 'usuario insertador',
  `prodFi` datetime DEFAULT NULL COMMENT 'feha insert',
  `prodUU` varchar(10) DEFAULT NULL COMMENT 'usuario actualizador',
  `prodFU` datetime DEFAULT NULL COMMENT 'fecha actualizacion',
  `prodSM` int(11) DEFAULT NULL COMMENT 'stock min',
  PRIMARY KEY (`prodCod`),
  KEY `prodTipo` (`prodTipo`),
  KEY `prodColor` (`prodColor`),
  KEY `prodEsp` (`prodEsp`),
  KEY `prodTipoPl` (`prodTipoPl`),
  KEY `prodUI` (`prodUI`),
  KEY `prodUU` (`prodUU`),
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`prodTipo`) REFERENCES `prodtipo` (`prodtipocod`),
  CONSTRAINT `productos_ibfk_2` FOREIGN KEY (`prodColor`) REFERENCES `color` (`colorcod`) ON DELETE SET NULL,
  CONSTRAINT `productos_ibfk_3` FOREIGN KEY (`prodEsp`) REFERENCES `espesor` (`espesorcod`),
  CONSTRAINT `productos_ibfk_4` FOREIGN KEY (`prodTipoPl`) REFERENCES `tipoplancha` (`tipocod`),
  CONSTRAINT `productos_ibfk_5` FOREIGN KEY (`prodUI`) REFERENCES `usuario` (`usucod`),
  CONSTRAINT `productos_ibfk_6` FOREIGN KEY (`prodUU`) REFERENCES `usuario` (`usucod`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Table structure for table `tipoplancha` */

DROP TABLE IF EXISTS `tipoplancha`;

CREATE TABLE `tipoplancha` (
  `tipoCod` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) NOT NULL,
  PRIMARY KEY (`tipoCod`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `usuCod` varchar(10) NOT NULL,
  `usuNombre` varchar(100) NOT NULL,
  `usuNivel` int(11) NOT NULL,
  `usuAlta` datetime NOT NULL,
  `usuEstado` char(1) NOT NULL,
  PRIMARY KEY (`usuCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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

/*Table structure for table `vlistadocolores` */

DROP TABLE IF EXISTS `vlistadocolores`;

/*!50001 DROP VIEW IF EXISTS `vlistadocolores` */;
/*!50001 DROP TABLE IF EXISTS `vlistadocolores` */;

/*!50001 CREATE TABLE  `vlistadocolores`(
 `ID` int(11) ,
 `Color` varchar(20) 
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
 `Codigo` varchar(20) ,
 `Descripción` varchar(30) ,
 `Tipo` varchar(30) ,
 `Alta` varchar(100) ,
 `Fecha alta` datetime ,
 `Ultima mod` varchar(100) ,
 `Fecha Ultima mod.` datetime 
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

/*View structure for view traerproductos */

/*!50001 DROP TABLE IF EXISTS `traerproductos` */;
/*!50001 DROP VIEW IF EXISTS `traerproductos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `traerproductos` AS select `productos`.`prodCod` AS `prodCod`,`productos`.`prodTipo` AS `prodTipo`,`productos`.`prodDesc` AS `prodDesc`,`productos`.`prodColor` AS `prodColor`,`productos`.`prodEsp` AS `prodEsp`,`productos`.`prodTipoPl` AS `prodTipoPl`,`productos`.`prodAlto` AS `prodAlto`,`productos`.`prodAncho` AS `prodAncho`,`productos`.`prodSup` AS `prodSup`,`productos`.`prodPA` AS `prodPA`,`productos`.`prodPB` AS `prodPB`,`productos`.`prodPC` AS `prodPC`,`productos`.`prodPD` AS `prodPD`,`productos`.`prodUI` AS `prodUI`,`productos`.`prodFi` AS `prodFi`,`productos`.`prodUU` AS `prodUU`,`productos`.`prodFU` AS `prodFU`,`productos`.`prodSM` AS `prodSM` from `productos` */;

/*View structure for view vlistadocolores */

/*!50001 DROP TABLE IF EXISTS `vlistadocolores` */;
/*!50001 DROP VIEW IF EXISTS `vlistadocolores` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadocolores` AS select `color`.`colorCod` AS `ID`,`color`.`color` AS `Color` from `color` */;

/*View structure for view vlistadoespesores */

/*!50001 DROP TABLE IF EXISTS `vlistadoespesores` */;
/*!50001 DROP VIEW IF EXISTS `vlistadoespesores` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadoespesores` AS select `espesor`.`espesorCod` AS `ID`,`espesor`.`espesor` AS `Espesor` from `espesor` */;

/*View structure for view vlistadoproductos */

/*!50001 DROP TABLE IF EXISTS `vlistadoproductos` */;
/*!50001 DROP VIEW IF EXISTS `vlistadoproductos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadoproductos` AS select `p`.`prodCod` AS `ID`,`p`.`prodCodigo` AS `Codigo`,`p`.`prodDesc` AS `Descripción`,`t`.`prodTipo` AS `Tipo`,`u`.`usuNombre` AS `Alta`,`p`.`prodFi` AS `Fecha alta`,`u2`.`usuNombre` AS `Ultima mod`,`p`.`prodFU` AS `Fecha Ultima mod.` from (((`productos` `p` join `prodtipo` `t` on((`p`.`prodTipo` = `t`.`prodTipocod`))) join `usuario` `u` on((`u`.`usuCod` = `p`.`prodUI`))) join `usuario` `u2` on((`u2`.`usuCod` = `p`.`prodUU`))) */;

/*View structure for view vlistadotipoplancha */

/*!50001 DROP TABLE IF EXISTS `vlistadotipoplancha` */;
/*!50001 DROP VIEW IF EXISTS `vlistadotipoplancha` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadotipoplancha` AS select `tipoplancha`.`tipoCod` AS `ID`,`tipoplancha`.`tipo` AS `Tipo` from `tipoplancha` */;

/*View structure for view vlistadotipoprod */

/*!50001 DROP TABLE IF EXISTS `vlistadotipoprod` */;
/*!50001 DROP VIEW IF EXISTS `vlistadotipoprod` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadotipoprod` AS select `prodtipo`.`prodTipocod` AS `ID`,`prodtipo`.`prodTipo` AS `Tipo` from `prodtipo` */;

/*View structure for view vlistadousuarios */

/*!50001 DROP TABLE IF EXISTS `vlistadousuarios` */;
/*!50001 DROP VIEW IF EXISTS `vlistadousuarios` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vlistadousuarios` AS select `usuario`.`usuCod` AS `Código`,`usuario`.`usuNombre` AS `Nombre`,`usuario`.`usuNivel` AS `Nivel`,(case `usuario`.`usuEstado` when 'A' then 'Activo' when 'I' then 'Inactivo' end) AS `Estado` from `usuario` */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
