-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 08-06-2020 a las 10:04:32
-- Versión del servidor: 5.7.24
-- Versión de PHP: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bopisoft`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evidencia`
--

DROP TABLE IF EXISTS `evidencia`;
CREATE TABLE IF NOT EXISTS `evidencia` (
  `IdGrupo` int(12) NOT NULL,
  `Unidad` int(1) NOT NULL,
  `Tipo` varchar(20) NOT NULL,
  `Archivo1` varchar(255) NOT NULL,
  `Archivo2` varchar(255) NOT NULL,
  PRIMARY KEY (`IdGrupo`,`Unidad`,`Tipo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lista_alumnos`
--

DROP TABLE IF EXISTS `lista_alumnos`;
CREATE TABLE IF NOT EXISTS `lista_alumnos` (
  `No_Control` int(8) NOT NULL,
  `IdGrupo` int(12) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apaterno` varchar(20) NOT NULL,
  `Amaterno` varchar(20) NOT NULL,
  PRIMARY KEY (`No_Control`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lista_carreras`
--

DROP TABLE IF EXISTS `lista_carreras`;
CREATE TABLE IF NOT EXISTS `lista_carreras` (
  `Clave` varchar(12) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`Clave`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `lista_carreras`
--

INSERT INTO `lista_carreras` (`Clave`, `Nombre`) VALUES
('1', 'Ingeniería en Sistemas Computacionales'),
('2', 'Ingeniería Industrial');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lista_departamentos`
--

DROP TABLE IF EXISTS `lista_departamentos`;
CREATE TABLE IF NOT EXISTS `lista_departamentos` (
  `IdDpto` int(12) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`IdDpto`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `lista_departamentos`
--

INSERT INTO `lista_departamentos` (`IdDpto`, `Nombre`) VALUES
(1, 'Departamento de Sistemas Computacionales'),
(2, 'Departamento de Ingeniería Industrial');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lista_grupos`
--

DROP TABLE IF EXISTS `lista_grupos`;
CREATE TABLE IF NOT EXISTS `lista_grupos` (
  `IdGrupo` int(12) NOT NULL,
  `Nombre` varchar(2) NOT NULL,
  `NombreCarrera` varchar(50) NOT NULL,
  `NombreMateria` varchar(50) NOT NULL,
  `IdPersonal` int(12) NOT NULL,
  `Semestre` int(1) NOT NULL,
  `Turno` char(1) NOT NULL,
  PRIMARY KEY (`IdGrupo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lista_materias`
--

DROP TABLE IF EXISTS `lista_materias`;
CREATE TABLE IF NOT EXISTS `lista_materias` (
  `IdMateria` int(12) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Creditos` int(1) NOT NULL,
  `Carrera` varchar(50) NOT NULL,
  `Unidades` int(1) NOT NULL,
  `Caracterización` text NOT NULL,
  `Competencia` text NOT NULL,
  PRIMARY KEY (`IdMateria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lista_personal`
--

DROP TABLE IF EXISTS `lista_personal`;
CREATE TABLE IF NOT EXISTS `lista_personal` (
  `IdPersonal` int(12) NOT NULL AUTO_INCREMENT,
  `Tipo` char(13) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apaterno` varchar(20) NOT NULL,
  `Amaterno` varchar(20) NOT NULL,
  `Sexo` char(1) NOT NULL,
  `NombreDpto` varchar(50) NOT NULL,
  `Direccion` varchar(40) NOT NULL,
  `Telefono` varchar(12) NOT NULL,
  `Contraseña` varchar(12) NOT NULL,
  `Foto` longblob NOT NULL,
  PRIMARY KEY (`IdPersonal`)
) ENGINE=MyISAM AUTO_INCREMENT=124 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia_contenido`
--

DROP TABLE IF EXISTS `materia_contenido`;
CREATE TABLE IF NOT EXISTS `materia_contenido` (
  `IdMateria` int(12) NOT NULL,
  `Unidad` int(2) NOT NULL,
  `Tema` varchar(255) NOT NULL,
  `Subtema` varchar(255) NOT NULL,
  PRIMARY KEY (`IdMateria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `notificacion_jefe`
--

DROP TABLE IF EXISTS `notificacion_jefe`;
CREATE TABLE IF NOT EXISTS `notificacion_jefe` (
  `IdNotif` int(12) NOT NULL,
  `Fecha` date NOT NULL,
  `IdGrupo` int(12) NOT NULL,
  `NombreGrupo` varchar(2) NOT NULL,
  `NombreDocente` varchar(20) NOT NULL,
  `Apaterno` varchar(20) NOT NULL,
  `Amaterno` varchar(20) NOT NULL,
  `NombreMateria` varchar(50) NOT NULL,
  `Tipo` varchar(30) NOT NULL,
  `Unidad` int(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planeacion`
--

DROP TABLE IF EXISTS `planeacion`;
CREATE TABLE IF NOT EXISTS `planeacion` (
  `IdPlaneacion` int(12) NOT NULL,
  `IdGrupo` int(12) NOT NULL,
  `NombreMateria` varchar(40) NOT NULL,
  `Unidad` int(1) NOT NULL,
  `CompetenciaMat` text NOT NULL,
  `Caracterizacion` text NOT NULL,
  `TemarioUnidad` text NOT NULL,
  `CompetenciaUnidad` text NOT NULL,
  `ActAprendizaje` text NOT NULL,
  `HrsTeoria` int(2) NOT NULL,
  `HrsPractica` int(2) NOT NULL,
  `SesionesEst` int(2) NOT NULL,
  `FechaExam` date NOT NULL,
  `Visitas` varchar(100) NOT NULL,
  `Practicas` text NOT NULL,
  `ActEnseñanza` text NOT NULL,
  `Recursos` varchar(200) NOT NULL,
  PRIMARY KEY (`IdPlaneacion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proyecto_individual`
--

DROP TABLE IF EXISTS `proyecto_individual`;
CREATE TABLE IF NOT EXISTS `proyecto_individual` (
  `IdProyecto` int(12) NOT NULL,
  `IdDocente` int(12) NOT NULL,
  `NombreDocente` varchar(20) NOT NULL,
  `Apaterno` varchar(20) NOT NULL,
  `Amaterno` varchar(20) NOT NULL,
  `NombreProyecto` varchar(60) NOT NULL,
  `Porcent_Avance` int(3) NOT NULL,
  `Objetivo` text NOT NULL,
  `Descripción` text NOT NULL,
  `Metas` text NOT NULL,
  `Actividades` text NOT NULL,
  `Archivo1` varchar(255) NOT NULL,
  `Archivo2` varchar(255) NOT NULL,
  `Archivo3` varchar(255) NOT NULL,
  `Conclusiones` text NOT NULL,
  PRIMARY KEY (`IdProyecto`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte_final`
--

DROP TABLE IF EXISTS `reporte_final`;
CREATE TABLE IF NOT EXISTS `reporte_final` (
  `IdReporte` int(12) NOT NULL,
  `NombreDepa` varchar(40) NOT NULL,
  `NombreDocente` varchar(20) NOT NULL,
  `Apaterno` varchar(20) NOT NULL,
  `Amaterno` varchar(20) NOT NULL,
  `Semestre` int(1) NOT NULL,
  PRIMARY KEY (`IdReporte`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte_final_contenido`
--

DROP TABLE IF EXISTS `reporte_final_contenido`;
CREATE TABLE IF NOT EXISTS `reporte_final_contenido` (
  `IdReporte` int(12) NOT NULL,
  `IdGrupo` int(20) NOT NULL,
  `NombreMateria` varchar(20) NOT NULL,
  `NombreCarrera` varchar(40) NOT NULL,
  `Total_Est` int(20) NOT NULL,
  `1op` int(2) NOT NULL,
  `2op` int(2) NOT NULL,
  `Porcent_Acred` decimal(2,0) NOT NULL,
  `No_Acred` int(2) NOT NULL,
  `Porcent_No_Acred` decimal(2,0) NOT NULL,
  `Deserto` int(2) NOT NULL,
  `Porcent_Des` decimal(2,0) NOT NULL,
  `Suma_Est` int(2) NOT NULL,
  PRIMARY KEY (`IdReporte`,`IdGrupo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `revision_docente`
--

DROP TABLE IF EXISTS `revision_docente`;
CREATE TABLE IF NOT EXISTS `revision_docente` (
  `IdRevision` int(12) NOT NULL,
  `IdGrupo` int(12) NOT NULL,
  `Fecha` date NOT NULL,
  `NombreGrupo` varchar(2) NOT NULL,
  `NombreMateria` varchar(40) NOT NULL,
  `Unidad` int(1) NOT NULL,
  `Tipo` varchar(20) NOT NULL,
  `Contenido` text NOT NULL,
  PRIMARY KEY (`IdRevision`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
