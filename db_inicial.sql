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

/*Table structure for table `bancos` */

DROP TABLE IF EXISTS `bancos`;

CREATE TABLE `bancos` (
  `banCod` int(11) NOT NULL AUTO_INCREMENT,
  `banNombre` varchar(30) NOT NULL,
  PRIMARY KEY (`banCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `bancos` */

/*Table structure for table `cambio` */

DROP TABLE IF EXISTS `cambio`;

CREATE TABLE `cambio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cambio` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `cambio` */

insert  into `cambio`(`id`,`cambio`) values (1,5000);

/*Table structure for table `clientes` */

DROP TABLE IF EXISTS `clientes`;

CREATE TABLE `clientes` (
  `clieCod` int(11) NOT NULL AUTO_INCREMENT,
  `clieLimitCred` double DEFAULT NULL COMMENT 'Limite de Crédito',
  `cliePrecio` char(1) NOT NULL,
  `tclieCod` int(11) NOT NULL COMMENT 'tipo de cliente',
  `clieCi` varchar(10) NOT NULL,
  `clieNombre` varchar(100) NOT NULL,
  `clieDirec` varchar(100) DEFAULT NULL,
  `clieCel` varchar(15) NOT NULL,
  `clieTelf` varchar(15) DEFAULT NULL,
  `clieMail` varchar(50) DEFAULT NULL,
  `clieRuc` varchar(20) NOT NULL,
  `vendCod` int(11) NOT NULL,
  `clieResponsable` varchar(50) DEFAULT NULL,
  `clieUI` varchar(10) DEFAULT NULL COMMENT 'usuario insert',
  `clieFI` datetime DEFAULT NULL COMMENT 'fecha Insert',
  `clieUU` varchar(10) DEFAULT NULL COMMENT 'usuario update',
  `clieFU` datetime DEFAULT NULL COMMENT 'fecha Update',
  `clieSaldo` double DEFAULT NULL COMMENT 'saldo de cliente',
  `sucCod` int(11) DEFAULT NULL,
  PRIMARY KEY (`clieCod`),
  UNIQUE KEY `clieRuc` (`clieRuc`),
  UNIQUE KEY `clieCi` (`clieCi`),
  KEY `clieUI` (`clieUI`),
  KEY `clieUU` (`clieUU`),
  KEY `vendCod` (`vendCod`),
  KEY `tclieCod` (`tclieCod`),
  KEY `sucCod` (`sucCod`),
  CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`clieUI`) REFERENCES `usuario` (`usucod`),
  CONSTRAINT `clientes_ibfk_2` FOREIGN KEY (`clieUU`) REFERENCES `usuario` (`usucod`),
  CONSTRAINT `clientes_ibfk_3` FOREIGN KEY (`vendCod`) REFERENCES `vendedores` (`vendcod`),
  CONSTRAINT `clientes_ibfk_4` FOREIGN KEY (`tclieCod`) REFERENCES `tipocliente` (`tcliecod`),
  CONSTRAINT `clientes_ibfk_5` FOREIGN KEY (`sucCod`) REFERENCES `sucursales` (`succod`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `clientes` */

/*Table structure for table `color` */

DROP TABLE IF EXISTS `color`;

CREATE TABLE `color` (
  `colorCod` int(11) NOT NULL AUTO_INCREMENT,
  `color` varchar(20) NOT NULL,
  PRIMARY KEY (`colorCod`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `color` */

/*Table structure for table `compras` */

DROP TABLE IF EXISTS `compras`;

CREATE TABLE `compras` (
  `comprasCod` int(11) NOT NULL AUTO_INCREMENT,
  `opeCod` int(11) DEFAULT NULL,
  `comprasCred` char(1) DEFAULT NULL,
  `comprasObs` varchar(100) DEFAULT NULL,
  `provCod` int(11) DEFAULT NULL,
  `comprasTotal` double DEFAULT NULL,
  `comprasEstado` char(1) DEFAULT NULL,
  `comprasNroFact` varchar(20) DEFAULT NULL,
  `comprasFchAnul` date DEFAULT NULL,
  `comprasFchPago` date DEFAULT NULL,
  `comprasSaldo` double DEFAULT NULL,
  `comprasFchFact` date DEFAULT NULL,
  `comprasUsrIns` varchar(10) DEFAULT NULL,
  `comprasFchIns` datetime DEFAULT NULL,
  `comprasUsrUpd` varchar(10) DEFAULT NULL,
  `comprasFchUpd` datetime DEFAULT NULL,
  `comprasExenta` double DEFAULT NULL,
  `compras5` double DEFAULT NULL,
  `compras10` double DEFAULT NULL,
  `sucCod` int(11) DEFAULT NULL,
  `depoCod` int(11) DEFAULT NULL,
  PRIMARY KEY (`comprasCod`),
  KEY `opeCod` (`opeCod`),
  KEY `sucCod` (`sucCod`),
  KEY `depoCod` (`depoCod`),
  KEY `provCod` (`provCod`),
  CONSTRAINT `compras_ibfk_1` FOREIGN KEY (`opeCod`) REFERENCES `operaciones` (`opecod`),
  CONSTRAINT `compras_ibfk_2` FOREIGN KEY (`sucCod`) REFERENCES `sucursales` (`succod`),
  CONSTRAINT `compras_ibfk_3` FOREIGN KEY (`depoCod`) REFERENCES `deposito` (`depocod`),
  CONSTRAINT `compras_ibfk_4` FOREIGN KEY (`provCod`) REFERENCES `proveedor` (`provcod`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `compras` */

/*Table structure for table `comprasdet` */

DROP TABLE IF EXISTS `comprasdet`;

CREATE TABLE `comprasdet` (
  `comprasDetCod` int(11) NOT NULL AUTO_INCREMENT,
  `comprasCod` int(11) DEFAULT NULL,
  `prodCod` int(11) DEFAULT NULL,
  `comprasDetCosto` double DEFAULT NULL,
  `comprasDetExenta` double DEFAULT NULL,
  `comprasDet5` double DEFAULT NULL,
  `comprasDet10` double DEFAULT NULL,
  `comprasDetCantidad` double DEFAULT NULL,
  PRIMARY KEY (`comprasDetCod`),
  KEY `comprasCod` (`comprasCod`),
  KEY `prodCod` (`prodCod`),
  CONSTRAINT `comprasdet_ibfk_1` FOREIGN KEY (`comprasCod`) REFERENCES `compras` (`comprascod`),
  CONSTRAINT `comprasdet_ibfk_2` FOREIGN KEY (`comprasCod`) REFERENCES `compras` (`comprascod`),
  CONSTRAINT `comprasdet_ibfk_3` FOREIGN KEY (`prodCod`) REFERENCES `productos` (`prodcod`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `comprasdet` */

/*Table structure for table `corte` */

DROP TABLE IF EXISTS `corte`;

CREATE TABLE `corte` (
  `corteCod` int(11) NOT NULL AUTO_INCREMENT,
  `corteMesa` int(11) DEFAULT NULL COMMENT 'puede ser 1, 2 o 3',
  `pCod` int(11) DEFAULT NULL,
  `corteRotFecha` datetime DEFAULT NULL COMMENT 'rotura fecha',
  `corteNroOpti` int(11) DEFAULT NULL COMMENT 'nro optimización',
  `corteUsuIns` varchar(10) DEFAULT NULL,
  `corteFchIns` datetime DEFAULT NULL,
  `corteUsuUpd` varchar(10) DEFAULT NULL,
  `corteFchUpd` datetime DEFAULT NULL,
  `corteEstado` char(1) DEFAULT NULL COMMENT 'T: Terminado - R : Roto',
  PRIMARY KEY (`corteCod`),
  KEY `pCod` (`pCod`),
  CONSTRAINT `corte_ibfk_1` FOREIGN KEY (`pCod`) REFERENCES `produccion` (`pcod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Data for the table `corte` */

/*Table structure for table `deposito` */

DROP TABLE IF EXISTS `deposito`;

CREATE TABLE `deposito` (
  `depoCod` int(11) NOT NULL AUTO_INCREMENT,
  `depoDesc` varchar(15) NOT NULL,
  PRIMARY KEY (`depoCod`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `deposito` */

/*Table structure for table `devoluciones` */

DROP TABLE IF EXISTS `devoluciones`;

CREATE TABLE `devoluciones` (
  `devoCod` int(11) NOT NULL AUTO_INCREMENT,
  `motCod` int(11) DEFAULT NULL,
  `sucCod` int(11) DEFAULT NULL,
  `depoCod` int(11) DEFAULT NULL,
  `pCod` int(11) DEFAULT NULL,
  PRIMARY KEY (`devoCod`),
  KEY `pCod` (`pCod`),
  KEY `sucCod` (`sucCod`),
  KEY `depoCod` (`depoCod`),
  KEY `motCod` (`motCod`),
  CONSTRAINT `devoluciones_ibfk_1` FOREIGN KEY (`pCod`) REFERENCES `produccion` (`pcod`),
  CONSTRAINT `devoluciones_ibfk_2` FOREIGN KEY (`sucCod`) REFERENCES `sucursales` (`succod`),
  CONSTRAINT `devoluciones_ibfk_3` FOREIGN KEY (`depoCod`) REFERENCES `deposito` (`depocod`),
  CONSTRAINT `devoluciones_ibfk_5` FOREIGN KEY (`motCod`) REFERENCES `motivos` (`motcod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `devoluciones` */

/*Table structure for table `espesor` */

DROP TABLE IF EXISTS `espesor`;

CREATE TABLE `espesor` (
  `espesorCod` int(11) NOT NULL AUTO_INCREMENT,
  `espesor` int(11) DEFAULT NULL,
  PRIMARY KEY (`espesorCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `espesor` */

/*Table structure for table `marcado` */

DROP TABLE IF EXISTS `marcado`;

CREATE TABLE `marcado` (
  `marcadoCod` int(11) NOT NULL AUTO_INCREMENT,
  `pCod` int(11) DEFAULT NULL,
  `marcadoRotFch` datetime DEFAULT NULL,
  `marcadoUsrIns` varchar(10) DEFAULT NULL,
  `marcadoFchIns` datetime DEFAULT NULL,
  `marcadoUsrUpd` varchar(10) DEFAULT NULL,
  `marcadoFchUpd` datetime DEFAULT NULL,
  `marcadoEstado` char(1) DEFAULT NULL COMMENT 'T: Terminado - R : Roto',
  PRIMARY KEY (`marcadoCod`),
  KEY `pCod` (`pCod`),
  CONSTRAINT `marcado_ibfk_1` FOREIGN KEY (`pCod`) REFERENCES `produccion` (`pcod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Data for the table `marcado` */

/*Table structure for table `motivos` */

DROP TABLE IF EXISTS `motivos`;

CREATE TABLE `motivos` (
  `motCod` int(11) NOT NULL AUTO_INCREMENT,
  `motDesc` varchar(30) NOT NULL,
  PRIMARY KEY (`motCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `motivos` */

/*Table structure for table `movinterno` */

DROP TABLE IF EXISTS `movinterno`;

CREATE TABLE `movinterno` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sucursalOrigen` int(11) DEFAULT NULL,
  `sucursalDestino` int(11) DEFAULT NULL,
  `depositoOrigen` int(11) DEFAULT NULL,
  `depositoDestino` int(11) DEFAULT NULL,
  `solicitante` varchar(30) DEFAULT NULL,
  `autorizado` varchar(30) DEFAULT NULL,
  `estado` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT 'B' COMMENT 'A:anulado B:activo',
  `fecha` date DEFAULT NULL,
  `observacion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `sucursalOrigen` (`sucursalOrigen`),
  KEY `sucursalDestino` (`sucursalDestino`),
  KEY `depositoOrigen` (`depositoOrigen`),
  KEY `depositoDestino` (`depositoDestino`),
  CONSTRAINT `movinterno_ibfk_1` FOREIGN KEY (`sucursalOrigen`) REFERENCES `sucursales` (`succod`) ON DELETE SET NULL,
  CONSTRAINT `movinterno_ibfk_2` FOREIGN KEY (`sucursalDestino`) REFERENCES `sucursales` (`succod`) ON DELETE SET NULL,
  CONSTRAINT `movinterno_ibfk_3` FOREIGN KEY (`depositoOrigen`) REFERENCES `deposito` (`depocod`) ON DELETE SET NULL,
  CONSTRAINT `movinterno_ibfk_4` FOREIGN KEY (`depositoDestino`) REFERENCES `deposito` (`depocod`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `movinterno` */

/*Table structure for table `movinternodetalle` */

DROP TABLE IF EXISTS `movinternodetalle`;

CREATE TABLE `movinternodetalle` (
  `idDetalle` int(11) NOT NULL AUTO_INCREMENT,
  `idMov` int(11) DEFAULT NULL,
  `prodId` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`idDetalle`),
  KEY `movinternodetalle_ibfk_1` (`idMov`),
  KEY `movinternodetalle_ibfk_2` (`prodId`),
  CONSTRAINT `movinternodetalle_ibfk_1` FOREIGN KEY (`idMov`) REFERENCES `movinterno` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `movinternodetalle_ibfk_2` FOREIGN KEY (`prodId`) REFERENCES `productos` (`prodcod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `movinternodetalle` */

/*Table structure for table `operaciones` */

DROP TABLE IF EXISTS `operaciones`;

CREATE TABLE `operaciones` (
  `opeCod` int(11) NOT NULL AUTO_INCREMENT,
  `opeDesc` varchar(30) NOT NULL,
  PRIMARY KEY (`opeCod`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `operaciones` */

insert  into `operaciones`(`opeCod`,`opeDesc`) values (1,'Venta'),(2,'Compra'),(3,'Mov.Interno');

/*Table structure for table `pagos` */

DROP TABLE IF EXISTS `pagos`;

CREATE TABLE `pagos` (
  `pagoCod` int(11) NOT NULL AUTO_INCREMENT,
  `ventCod` int(11) NOT NULL,
  `pagoFecha` datetime NOT NULL,
  `tpagoCod` int(11) NOT NULL,
  `banCod` int(11) DEFAULT NULL,
  `pagoMonto` double NOT NULL,
  `pagoDescuento` double DEFAULT NULL,
  `pagoRecargo` double DEFAULT NULL,
  `pagoMotivo` varchar(50) DEFAULT NULL,
  `pagoChqNro` varchar(30) DEFAULT NULL,
  `pagoChqVenc` date DEFAULT NULL,
  `pagoDias` date DEFAULT NULL,
  `pagoSaldo` double NOT NULL,
  `pagoNroRecibo` varchar(30) NOT NULL,
  `pagoUI` varchar(10) DEFAULT NULL,
  `pagoFI` datetime DEFAULT NULL,
  `pagoUU` varchar(10) DEFAULT NULL,
  `pagoFU` datetime DEFAULT NULL,
  `moneda` char(1) DEFAULT NULL,
  PRIMARY KEY (`pagoCod`),
  KEY `banCod` (`banCod`),
  KEY `ventCod` (`ventCod`),
  KEY `pagos_ibfk_3` (`tpagoCod`),
  CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`banCod`) REFERENCES `bancos` (`bancod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pagos_ibfk_2` FOREIGN KEY (`ventCod`) REFERENCES `ventas` (`ventcod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pagos_ibfk_3` FOREIGN KEY (`tpagoCod`) REFERENCES `tipopago` (`tpagocod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `pagos` */

/*Table structure for table `pedidointernocab` */

DROP TABLE IF EXISTS `pedidointernocab`;

CREATE TABLE `pedidointernocab` (
  `piCod` int(20) NOT NULL,
  `piFecha` date DEFAULT NULL,
  `piSolicitado` varchar(20) DEFAULT NULL,
  `piAutorizado` char(30) DEFAULT NULL,
  `depoCod` int(11) NOT NULL,
  `piCantidad` int(11) NOT NULL,
  `prodCod` int(11) NOT NULL,
  `piCodOpti` int(11) DEFAULT NULL,
  `piEstado` char(12) DEFAULT NULL,
  `piUsrIns` char(12) DEFAULT NULL,
  `piFchIns` datetime DEFAULT NULL,
  `piUsrUpd` char(12) DEFAULT NULL,
  `piFchUpd` datetime DEFAULT NULL,
  PRIMARY KEY (`piCod`),
  KEY `depoCod` (`depoCod`),
  KEY `prodCod` (`prodCod`),
  CONSTRAINT `pedidointernocab_ibfk_1` FOREIGN KEY (`depoCod`) REFERENCES `deposito` (`depocod`),
  CONSTRAINT `pedidointernocab_ibfk_2` FOREIGN KEY (`prodCod`) REFERENCES `productos` (`prodcod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `pedidointernocab` */

/*Table structure for table `pedidointernodet` */

DROP TABLE IF EXISTS `pedidointernodet`;

CREATE TABLE `pedidointernodet` (
  `piCodDet` int(11) NOT NULL AUTO_INCREMENT,
  `clieCod` int(11) NOT NULL,
  `piCod` int(11) DEFAULT NULL,
  `piLinea` int(11) DEFAULT NULL,
  `ventCod` int(11) NOT NULL,
  PRIMARY KEY (`piCodDet`),
  KEY `FK_pedidointernodet` (`piCod`),
  KEY `clieCod` (`clieCod`),
  KEY `ventCod` (`ventCod`),
  CONSTRAINT `pedidointernodet_ibfk_1` FOREIGN KEY (`piCod`) REFERENCES `pedidointernocab` (`picod`),
  CONSTRAINT `pedidointernodet_ibfk_2` FOREIGN KEY (`clieCod`) REFERENCES `clientes` (`cliecod`),
  CONSTRAINT `pedidointernodet_ibfk_3` FOREIGN KEY (`ventCod`) REFERENCES `ventas` (`ventcod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `pedidointernodet` */

/*Table structure for table `planos` */

DROP TABLE IF EXISTS `planos`;

CREATE TABLE `planos` (
  `id_plano` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_plano` varchar(300) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_venta` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_plano`),
  KEY `id_venta` (`id_venta`),
  CONSTRAINT `planos_ibfk_1` FOREIGN KEY (`id_venta`) REFERENCES `ventas` (`ventcod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `planos` */

/*Table structure for table `prodtipo` */

DROP TABLE IF EXISTS `prodtipo`;

CREATE TABLE `prodtipo` (
  `prodTipocod` int(11) NOT NULL AUTO_INCREMENT,
  `prodTipo` varchar(30) NOT NULL,
  PRIMARY KEY (`prodTipocod`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Data for the table `prodtipo` */

insert  into `prodtipo`(`prodTipocod`,`prodTipo`) values (9,'herrajes'),(10,'perfiles'),(11,'planchas'),(12,'templado');

/*Table structure for table `produccion` */

DROP TABLE IF EXISTS `produccion`;

CREATE TABLE `produccion` (
  `pCod` int(11) NOT NULL AUTO_INCREMENT,
  `ventCod` int(11) DEFAULT NULL,
  `ventDetCod` int(11) DEFAULT NULL,
  `repoCod` int(11) DEFAULT NULL,
  `pPanho` int(11) NOT NULL,
  `produccion_detalle` int(11) DEFAULT NULL,
  `produccion_ticket` char(1) DEFAULT 'N',
  PRIMARY KEY (`pCod`),
  KEY `ventCod` (`ventCod`),
  KEY `repoCod` (`repoCod`),
  KEY `produccion_detalle` (`produccion_detalle`),
  CONSTRAINT `produccion_ibfk_1` FOREIGN KEY (`ventCod`) REFERENCES `ventas` (`ventcod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `produccion_ibfk_2` FOREIGN KEY (`repoCod`) REFERENCES `reposiciones` (`repocod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `produccion_ibfk_3` FOREIGN KEY (`produccion_detalle`) REFERENCES `producciondetalle` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

/*Data for the table `produccion` */

/*Table structure for table `producciondetalle` */

DROP TABLE IF EXISTS `producciondetalle`;

CREATE TABLE `producciondetalle` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `prod_id` int(11) DEFAULT NULL,
  `ticket_impreso` char(1) DEFAULT 'N',
  PRIMARY KEY (`id`),
  KEY `prod_id` (`prod_id`),
  CONSTRAINT `producciondetalle_ibfk_1` FOREIGN KEY (`prod_id`) REFERENCES `productos` (`prodcod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Data for the table `producciondetalle` */

/*Table structure for table `producciondia` */

DROP TABLE IF EXISTS `producciondia`;

CREATE TABLE `producciondia` (
  `prodDiaCod` int(11) NOT NULL AUTO_INCREMENT,
  `prodDiaSup` decimal(10,2) DEFAULT NULL,
  `prodDiaFecha` date DEFAULT NULL,
  PRIMARY KEY (`prodDiaCod`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `producciondia` */

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
  `prodCosto` double DEFAULT NULL,
  `prodIva` int(11) NOT NULL DEFAULT '2' COMMENT '1= 5% ,2= 10%, 3=Exenta',
  PRIMARY KEY (`prodCod`),
  KEY `prodTipo` (`prodTipo`),
  KEY `prodColor` (`prodColor`),
  KEY `prodEsp` (`prodEsp`),
  KEY `prodTipoPl` (`prodTipoPl`),
  KEY `prodUI` (`prodUI`),
  KEY `prodUU` (`prodUU`),
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`prodTipo`) REFERENCES `prodtipo` (`prodtipocod`),
  CONSTRAINT `productos_ibfk_2` FOREIGN KEY (`prodColor`) REFERENCES `color` (`colorcod`) ON DELETE SET NULL,
  CONSTRAINT `productos_ibfk_4` FOREIGN KEY (`prodTipoPl`) REFERENCES `tipoplancha` (`tipocod`),
  CONSTRAINT `productos_ibfk_5` FOREIGN KEY (`prodUI`) REFERENCES `usuario` (`usucod`),
  CONSTRAINT `productos_ibfk_6` FOREIGN KEY (`prodUU`) REFERENCES `usuario` (`usucod`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `productos` */

/*Table structure for table `proveedor` */

DROP TABLE IF EXISTS `proveedor`;

CREATE TABLE `proveedor` (
  `provCod` int(11) NOT NULL AUTO_INCREMENT,
  `provNombre` varchar(50) NOT NULL,
  `provRuc` varchar(20) NOT NULL,
  `provTelefono` varchar(20) DEFAULT NULL,
  `provMail` varchar(20) DEFAULT NULL,
  `provContacto` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`provCod`),
  UNIQUE KEY `provRuc` (`provRuc`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `proveedor` */

/*Table structure for table `pulida` */

DROP TABLE IF EXISTS `pulida`;

CREATE TABLE `pulida` (
  `puliCod` int(11) NOT NULL AUTO_INCREMENT,
  `pCod` int(11) DEFAULT NULL,
  `puliRotFch` datetime DEFAULT NULL,
  `puliUsrIns` varchar(10) DEFAULT NULL,
  `puliFchIns` datetime DEFAULT NULL,
  `puliUsrUpd` varchar(10) DEFAULT NULL,
  `puliFchUpd` datetime DEFAULT NULL,
  `puliEstado` char(1) DEFAULT NULL COMMENT 'T: Terminado - R : Roto',
  PRIMARY KEY (`puliCod`),
  KEY `pCod` (`pCod`),
  CONSTRAINT `pulida_ibfk_1` FOREIGN KEY (`pCod`) REFERENCES `produccion` (`pcod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Data for the table `pulida` */

/*Table structure for table `reposiciones` */

DROP TABLE IF EXISTS `reposiciones`;

CREATE TABLE `reposiciones` (
  `repoCod` int(11) NOT NULL AUTO_INCREMENT,
  `ventCod` int(11) NOT NULL,
  `motCod` int(11) NOT NULL,
  `repoUI` varchar(10) DEFAULT NULL,
  `repoFI` datetime DEFAULT NULL,
  `repoUU` varchar(10) DEFAULT NULL,
  `repoFU` datetime DEFAULT NULL,
  PRIMARY KEY (`repoCod`),
  KEY `motCod` (`motCod`),
  KEY `ventCod` (`ventCod`),
  CONSTRAINT `reposiciones_ibfk_1` FOREIGN KEY (`motCod`) REFERENCES `motivos` (`motcod`),
  CONSTRAINT `reposiciones_ibfk_2` FOREIGN KEY (`ventCod`) REFERENCES `ventas` (`ventcod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `reposiciones` */

/*Table structure for table `stock` */

DROP TABLE IF EXISTS `stock`;

CREATE TABLE `stock` (
  `stCod` int(11) NOT NULL AUTO_INCREMENT,
  `prodCodigo` int(20) DEFAULT NULL,
  `stCantidad` decimal(10,0) DEFAULT NULL,
  `opCod` int(11) DEFAULT NULL,
  `stUsrIns` varchar(10) DEFAULT NULL,
  `stFchIns` datetime DEFAULT NULL,
  `sucCod` int(11) NOT NULL,
  `depoCod` int(11) NOT NULL,
  `ventaCod` int(11) DEFAULT NULL,
  `compraCod` int(11) DEFAULT NULL,
  `stEstado` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT 'B' COMMENT 'A: Anulado, B:ACTIVO',
  `movCod` int(11) DEFAULT NULL,
  PRIMARY KEY (`stCod`),
  KEY `prodCodigo` (`prodCodigo`),
  KEY `opCod` (`opCod`),
  KEY `stock_ibfk_4` (`ventaCod`),
  KEY `stock_ibfk_5` (`compraCod`),
  KEY `stock_ibfk_6` (`movCod`),
  CONSTRAINT `stock_ibfk_2` FOREIGN KEY (`opCod`) REFERENCES `operaciones` (`opecod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `stock_ibfk_3` FOREIGN KEY (`prodCodigo`) REFERENCES `productos` (`prodcod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `stock_ibfk_4` FOREIGN KEY (`ventaCod`) REFERENCES `ventas` (`ventcod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `stock_ibfk_5` FOREIGN KEY (`compraCod`) REFERENCES `compras` (`comprascod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `stock_ibfk_6` FOREIGN KEY (`movCod`) REFERENCES `movinterno` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

/*Data for the table `stock` */

/*Table structure for table `sucursales` */

DROP TABLE IF EXISTS `sucursales`;

CREATE TABLE `sucursales` (
  `sucCod` int(11) NOT NULL AUTO_INCREMENT,
  `sucDesc` varchar(20) NOT NULL,
  `depoCod` int(11) NOT NULL,
  PRIMARY KEY (`sucCod`),
  KEY `depoCod` (`depoCod`),
  CONSTRAINT `sucursales_ibfk_2` FOREIGN KEY (`depoCod`) REFERENCES `deposito` (`depocod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `sucursales` */

/*Table structure for table `templado` */

DROP TABLE IF EXISTS `templado`;

CREATE TABLE `templado` (
  `templaCod` int(11) NOT NULL AUTO_INCREMENT,
  `pCod` int(11) DEFAULT NULL,
  `templaEntrada` datetime DEFAULT NULL,
  `templaSalida` datetime DEFAULT NULL,
  `templaRotura` datetime DEFAULT NULL,
  `templaEstado` char(1) DEFAULT NULL COMMENT 'T: Terminado - R : Roto',
  `templaUsrIns` varchar(10) DEFAULT NULL,
  `templaFchIns` datetime DEFAULT NULL,
  `templaUsrUpd` varchar(10) DEFAULT NULL,
  `templaFchUpd` datetime DEFAULT NULL,
  PRIMARY KEY (`templaCod`),
  KEY `pCod` (`pCod`),
  CONSTRAINT `templado_ibfk_1` FOREIGN KEY (`pCod`) REFERENCES `produccion` (`pcod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Data for the table `templado` */

/*Table structure for table `tipocliente` */

DROP TABLE IF EXISTS `tipocliente`;

CREATE TABLE `tipocliente` (
  `tclieCod` int(11) NOT NULL AUTO_INCREMENT,
  `tclieDesc` varchar(20) DEFAULT NULL COMMENT 'puede ser interno/cliente',
  PRIMARY KEY (`tclieCod`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tipocliente` */

insert  into `tipocliente`(`tclieCod`,`tclieDesc`) values (1,'minorista'),(2,'mayorista');

/*Table structure for table `tipoiva` */

DROP TABLE IF EXISTS `tipoiva`;

CREATE TABLE `tipoiva` (
  `idIva` int(11) NOT NULL AUTO_INCREMENT,
  `descIva` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idIva`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tipoiva` */

insert  into `tipoiva`(`idIva`,`descIva`) values (1,'5%'),(2,'10%'),(3,'Exenta');

/*Table structure for table `tipopago` */

DROP TABLE IF EXISTS `tipopago`;

CREATE TABLE `tipopago` (
  `tpagoCod` int(11) NOT NULL AUTO_INCREMENT,
  `tpadoDesc` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`tpagoCod`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

/*Data for the table `tipopago` */

insert  into `tipopago`(`tpagoCod`,`tpadoDesc`) values (1,'Efectivo Gs'),(2,'Efectivo $'),(3,'Cheque Gs'),(4,'Cheque $'),(5,'Tarjeta Crédito'),(6,'Tarjeta Débito'),(7,'Boleta Depósito');

/*Table structure for table `tipoplancha` */

DROP TABLE IF EXISTS `tipoplancha`;

CREATE TABLE `tipoplancha` (
  `tipoCod` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) NOT NULL,
  PRIMARY KEY (`tipoCod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tipoplancha` */

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `usuCod` varchar(10) NOT NULL,
  `usuNombre` varchar(100) NOT NULL,
  `usuNivel` int(11) NOT NULL,
  `usuAlta` datetime NOT NULL,
  `usuEstado` char(1) NOT NULL,
  `sucCod` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuCod`),
  KEY `usuario_ibfk_1` (`sucCod`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`sucCod`) REFERENCES `sucursales` (`succod`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `usuario` */

/*Table structure for table `vendedores` */

DROP TABLE IF EXISTS `vendedores`;

CREATE TABLE `vendedores` (
  `vendCod` int(11) NOT NULL AUTO_INCREMENT,
  `vendNombre` varchar(50) NOT NULL,
  `vendCel` varchar(15) NOT NULL,
  `vendPorc` decimal(10,2) NOT NULL,
  PRIMARY KEY (`vendCod`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `vendedores` */

/*Table structure for table `ventas` */

DROP TABLE IF EXISTS `ventas`;

CREATE TABLE `ventas` (
  `ventCod` int(11) NOT NULL AUTO_INCREMENT,
  `opeCod` int(11) NOT NULL COMMENT 'tipo operacion/ mov interno/ venta',
  `ventCred` char(1) NOT NULL,
  `ventFecha` date NOT NULL,
  `ventFact` varchar(25) NOT NULL,
  `ventObs` varchar(100) DEFAULT NULL,
  `clieCod` int(11) NOT NULL,
  `vendCod` int(11) NOT NULL,
  `ventPlazo` int(3) DEFAULT NULL,
  `ventFechaProm` date DEFAULT NULL COMMENT 'fecha de promesa de entrega que va de acuerdo al plazo',
  `ventRecargo` decimal(2,2) DEFAULT NULL COMMENT 'porcentaje recargo',
  `ventDescuento` decimal(2,2) DEFAULT NULL COMMENT 'porcentaje descuento',
  `ventTotal` double(10,3) DEFAULT NULL,
  `ventSaldo` double(10,3) DEFAULT NULL,
  `ventEstado` char(1) DEFAULT NULL COMMENT 'A= Anulado, C= Cobrado, D:Devuelto; P: Pendiente de pago',
  `ventMotivo` varchar(100) DEFAULT NULL COMMENT 'Motivo anulacion',
  `ventEnvio` char(1) DEFAULT NULL COMMENT 'S: con envio, N: sin envio',
  `ventDireccEnv` varchar(150) DEFAULT NULL COMMENT 'direccion de envio',
  `ventUI` varchar(10) DEFAULT NULL,
  `ventFI` datetime DEFAULT NULL,
  `ventUU` varchar(10) DEFAULT NULL,
  `ventFU` datetime DEFAULT NULL,
  `ventM2` decimal(10,2) DEFAULT NULL COMMENT 'metros cuadrados de la ot',
  `estadoFactura` char(1) DEFAULT NULL COMMENT 'S: impreso, N: no impreso',
  `plano` varchar(300) DEFAULT NULL COMMENT 'ruta a la imagen en disco',
  `moneda` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT 'G' COMMENT 'G: guaranies, D: dolares',
  PRIMARY KEY (`ventCod`),
  KEY `clieCod` (`clieCod`),
  KEY `vendCod` (`vendCod`),
  KEY `ventUI` (`ventUI`),
  KEY `ventUU` (`ventUU`),
  KEY `opeCod` (`opeCod`),
  CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`clieCod`) REFERENCES `clientes` (`cliecod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`vendCod`) REFERENCES `vendedores` (`vendcod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ventas_ibfk_3` FOREIGN KEY (`ventUI`) REFERENCES `usuario` (`usucod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ventas_ibfk_4` FOREIGN KEY (`ventUU`) REFERENCES `usuario` (`usucod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ventas_ibfk_5` FOREIGN KEY (`opeCod`) REFERENCES `operaciones` (`opecod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

/*Data for the table `ventas` */

/*Table structure for table `ventasdet` */

DROP TABLE IF EXISTS `ventasdet`;

CREATE TABLE `ventasdet` (
  `ventDetcod` int(11) NOT NULL AUTO_INCREMENT,
  `ventCod` int(11) NOT NULL,
  `prodCod` int(11) DEFAULT NULL,
  `ventDetCantidad` decimal(10,2) DEFAULT NULL,
  `ventDetAncho` decimal(10,2) DEFAULT NULL,
  `ventDetAlto` decimal(10,2) DEFAULT NULL,
  `ventDetSup` decimal(10,2) DEFAULT NULL,
  `ventDetRecargo` decimal(2,2) DEFAULT NULL,
  `ventDetDescuento` decimal(2,2) DEFAULT NULL,
  `ventDetPrecioUnit` double(10,2) DEFAULT NULL,
  `ventDetPrecioReal` double(10,2) DEFAULT NULL,
  `ventDetPrecioCosto` double(10,2) DEFAULT NULL,
  `ventDetObra` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ventDetcod`),
  KEY `ventCod` (`ventCod`),
  KEY `prodCod` (`prodCod`),
  CONSTRAINT `ventasdet_ibfk_1` FOREIGN KEY (`ventCod`) REFERENCES `ventas` (`ventcod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ventasdet_ibfk_2` FOREIGN KEY (`prodCod`) REFERENCES `productos` (`prodcod`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

/*Data for the table `ventasdet` */

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
	update `ventas` v set v.`ventSaldo` = case when v.`ventSaldo` > 0 then  v.`ventSaldo` - NEW.`pagoMonto` end where v.`ventCod` = NEW.`ventCod`;
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

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `reporteventasfecha`(IN fecha1 Date, in fecha2 Date)
BEGIN
	SELECT * FROM `producir`.`vventasfecha` WHERE Estado <> 'A' and Fecha BETWEEN fecha1 AND fecha2;
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
 `Obra` varchar(30) 
)*/;

/*View structure for view traerproductos */

/*!50001 DROP TABLE IF EXISTS `traerproductos` */;
/*!50001 DROP VIEW IF EXISTS `traerproductos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `traerproductos` AS select `productos`.`prodCod` AS `prodCod`,`productos`.`prodTipo` AS `prodTipo`,`productos`.`prodDesc` AS `prodDesc`,`productos`.`prodColor` AS `prodColor`,`productos`.`prodEsp` AS `prodEsp`,`productos`.`prodTipoPl` AS `prodTipoPl`,`productos`.`prodAlto` AS `prodAlto`,`productos`.`prodAncho` AS `prodAncho`,`productos`.`prodSup` AS `prodSup`,`productos`.`prodPA` AS `prodPA`,`productos`.`prodPB` AS `prodPB`,`productos`.`prodPC` AS `prodPC`,`productos`.`prodPD` AS `prodPD`,`productos`.`prodUI` AS `prodUI`,`productos`.`prodFi` AS `prodFi`,`productos`.`prodUU` AS `prodUU`,`productos`.`prodFU` AS `prodFU`,`productos`.`prodSM` AS `prodSM` from `productos` */;

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

/*View structure for view vventasfecha */

/*!50001 DROP TABLE IF EXISTS `vventasfecha` */;
/*!50001 DROP VIEW IF EXISTS `vventasfecha` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vventasfecha` AS select `c`.`clieCod` AS `Código`,`c`.`clieNombre` AS `Cliente`,`v`.`ventCod` AS `OT`,`v`.`opeCod` AS `Oper`,`v`.`ventFecha` AS `Fecha`,`v`.`ventFact` AS `Factura`,`d`.`prodCod` AS `Cod`,`v`.`ventEstado` AS `Estado`,`d`.`ventDetCantidad` AS `Cantidad`,`p`.`prodDesc` AS `Producto`,`d`.`ventDetSup` AS `Superficie`,`d`.`ventDetPrecioReal` AS `Venta`,`d`.`ventDetObra` AS `Obra` from (((`ventas` `v` join `ventasdet` `d` on((`d`.`ventCod` = `v`.`ventCod`))) join `productos` `p` on((`p`.`prodCod` = `d`.`prodCod`))) join `clientes` `c` on((`c`.`clieCod` = `v`.`clieCod`))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
