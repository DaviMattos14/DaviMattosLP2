-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.5-10.0.14-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para projetolp
CREATE DATABASE IF NOT EXISTS `projetolp` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `projetolp`;


-- Copiando estrutura para tabela projetolp.pergunta
CREATE TABLE IF NOT EXISTS `pergunta` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Texto` longtext NOT NULL,
  `Resposta` longtext NOT NULL,
  `Materia` varchar(50) NOT NULL,
  `Assunto` text NOT NULL,
  `Dificuldade` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela projetolp.pergunta: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `pergunta` DISABLE KEYS */;
INSERT INTO `pergunta` (`ID`, `Texto`, `Resposta`, `Materia`, `Assunto`, `Dificuldade`) VALUES
	(1, 'QUal é', 'Gghag', 'asdfsa', 'ads', 5),
	(10, 'a', 'a', 'a', 'a', 1);
/*!40000 ALTER TABLE `pergunta` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
