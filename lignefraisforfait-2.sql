-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2016 at 05:17 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `gsb_frais`
--

-- --------------------------------------------------------

--
-- Table structure for table `lignefraisforfait`
--

CREATE TABLE IF NOT EXISTS `lignefraisforfait` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idutilisateur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `idFraisForfait` char(3) NOT NULL,
  `quantite` int(11) DEFAULT NULL,
  `montant` decimal(10,2) NOT NULL,
  `dateFrais` date DEFAULT NULL,
  `typeFrais` varchar(20) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `lignefraisforfait_ibfk_1` (`idutilisateur`,`mois`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=18 ;

--
-- Dumping data for table `lignefraisforfait`
--

INSERT INTO `lignefraisforfait` (`id`, `idutilisateur`, `mois`, `idFraisForfait`, `quantite`, `montant`, `dateFrais`, `typeFrais`, `description`) VALUES
(8, 'a131', '201612', 'NUI', 3, '240.00', '2016-09-02', 'Nuitée Hôtel', 'Hôtel "Au gros dodo"'),
(9, 'a131', '201612', 'KM', 9, '5.58', '2016-09-04', 'Frais Kilométrique', 'Rallye'),
(10, 'a131', '201612', 'REP', 31, '775.00', '2016-09-21', 'Repas Restaurant', 'Cassoulet'),
(11, 'a131', '201612', 'KM', 40, '24.80', '2016-09-20', 'Frais Kilométrique', 'Tour du monde'),
(17, 'a131', '201612', 'ETP', 2, '220.00', '2016-09-08', 'Forfait Etape', 'Réunion');

--
-- Triggers `lignefraisforfait`
--
DROP TRIGGER IF EXISTS `before_insert_lignefraisforfait`;
DELIMITER //
CREATE TRIGGER `before_insert_lignefraisforfait` BEFORE INSERT ON `lignefraisforfait`
 FOR EACH ROW SET NEW.montant = ( SELECT NEW.quantite * fraisforfait.montant 
                    FROM fraisforfait 
                    WHERE NEW.idFraisForfait = fraisforfait.id )
//
DELIMITER ;
DROP TRIGGER IF EXISTS `before_update_lignefraisforfait`;
DELIMITER //
CREATE TRIGGER `before_update_lignefraisforfait` BEFORE UPDATE ON `lignefraisforfait`
 FOR EACH ROW SET NEW.montant = 
( SELECT NEW.quantite* fraisforfait.montant 
  FROM fraisforfait 
  WHERE NEW.idFraisForfait = fraisforfait.id )
//
DELIMITER ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `lignefraisforfait`
--
ALTER TABLE `lignefraisforfait`
  ADD CONSTRAINT `lignefraisforfait_ibfk_1` FOREIGN KEY (`idutilisateur`, `mois`) REFERENCES `fichefrais` (`idutilisateur`, `mois`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
