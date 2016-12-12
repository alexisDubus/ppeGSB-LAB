-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2016 at 03:06 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `gsb_prod`
--

-- --------------------------------------------------------

--
-- Table structure for table `etat`
--

CREATE TABLE IF NOT EXISTS `etat` (
  `id` char(2) NOT NULL,
  `libelle` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `etat`
--

INSERT INTO `etat` (`id`, `libelle`) VALUES
('CL', 'Saisie clôturée'),
('CR', 'Fiche créée, saisie en cours'),
('RB', 'Remboursée'),
('VA', 'Validée et mise en paiement');

-- --------------------------------------------------------

--
-- Table structure for table `fichefrais`
--

CREATE TABLE IF NOT EXISTS `fichefrais` (
  `idutilisateur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `nbJustificatifs` int(11) DEFAULT NULL,
  `montantValide` decimal(10,2) DEFAULT NULL,
  `dateModif` date DEFAULT NULL,
  `idEtat` char(2) DEFAULT 'CR',
  PRIMARY KEY (`idutilisateur`,`mois`),
  KEY `idEtat` (`idEtat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `fichefrais`
--

INSERT INTO `fichefrais` (`idutilisateur`, `mois`, `nbJustificatifs`, `montantValide`, `dateModif`, `idEtat`) VALUES
('a131', '201611', 0, '0.00', '2016-12-03', 'CL'),
('a131', '201612', 0, '0.00', '2016-12-03', 'CR'),
('a17', '201611', 0, '0.00', '2016-12-03', 'CL'),
('b13', '201612', 0, '0.00', '2016-12-12', 'CR'),
('c3', '201612', 0, '0.00', '2016-12-07', 'CR'),
('f39', '201612', 0, '0.00', '2016-12-03', 'CR');

-- --------------------------------------------------------

--
-- Table structure for table `fraisforfait`
--

CREATE TABLE IF NOT EXISTS `fraisforfait` (
  `id` char(3) NOT NULL,
  `libelle` char(20) DEFAULT NULL,
  `montant` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `fraisforfait`
--

INSERT INTO `fraisforfait` (`id`, `libelle`, `montant`) VALUES
('ETP', 'Forfait Etape', '10.00'),
('KM', 'Frais Kilométrique', '0.62'),
('NUI', 'Nuitée Hôtel', '80.00'),
('REP', 'Repas Restaurant', '25.00');

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
  KEY `lignefraisforfait_ibfk_1` (`idutilisateur`,`mois`),
  KEY `idFraisForfait` (`idFraisForfait`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=22 ;

--
-- Dumping data for table `lignefraisforfait`
--

INSERT INTO `lignefraisforfait` (`id`, `idutilisateur`, `mois`, `idFraisForfait`, `quantite`, `montant`, `dateFrais`, `typeFrais`, `description`) VALUES
(8, 'a131', '201612', 'NUI', 3, '240.00', '2016-09-02', 'Nuitée Hôtel', 'Hôtel "du lac"'),
(9, 'a131', '201612', 'KM', 9, '5.58', '2016-09-04', 'Frais Kilométrique', 'Lyon - Paris'),
(10, 'a131', '201612', 'REP', 31, '775.00', '2016-09-21', 'Repas Restaurant', 'Soirée Dr Dupont'),
(11, 'a131', '201612', 'KM', 40, '24.80', '2016-09-20', 'Frais Kilométrique', 'Trajet Paris - Bordeaux'),
(17, 'a131', '201612', 'ETP', 2, '220.00', '2016-09-08', 'Forfait Etape', 'Voyage a Paris'),
(18, 'b13', '201612', 'ETP', 0, '0.00', NULL, NULL, NULL),
(19, 'b13', '201612', 'KM', 0, '0.00', NULL, NULL, NULL),
(20, 'b13', '201612', 'NUI', 0, '0.00', NULL, NULL, NULL),
(21, 'b13', '201612', 'REP', 0, '0.00', NULL, NULL, NULL);

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

-- --------------------------------------------------------

--
-- Table structure for table `lignefraishorsforfait`
--

CREATE TABLE IF NOT EXISTS `lignefraishorsforfait` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idutilisateur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `libelle` varchar(100) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `montant` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idutilisateur` (`idutilisateur`,`mois`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `lignefraishorsforfait`
--

INSERT INTO `lignefraishorsforfait` (`id`, `idutilisateur`, `mois`, `libelle`, `date`, `montant`) VALUES
(1, 'a131', '201611', 'hotel trés cher', '2016-10-12', '120.00'),
(2, 'a131', '201611', 'Restaurant "chez Benoît"', '2016-05-01', '1500.00');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE IF NOT EXISTS `role` (
  `id` char(2) NOT NULL,
  `profession` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id`, `profession`) VALUES
('0', 'Administrateur'),
('1', 'Comptable'),
('2', 'Visiteur médical');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateur`
--

CREATE TABLE IF NOT EXISTS `utilisateur` (
  `id` char(4) NOT NULL,
  `nom` char(30) DEFAULT NULL,
  `prenom` char(30) DEFAULT NULL,
  `login` char(20) DEFAULT NULL,
  `adresse` char(30) DEFAULT NULL,
  `cp` char(5) DEFAULT NULL,
  `ville` char(30) DEFAULT NULL,
  `dateEmbauche` date DEFAULT NULL,
  `idRole` varchar(25) DEFAULT NULL,
  `mdpSHA` char(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `role_ibfk_1` (`idRole`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Anciennement table visiteur';

--
-- Dumping data for table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom`, `prenom`, `login`, `adresse`, `cp`, `ville`, `dateEmbauche`, `idRole`, `mdpSHA`) VALUES
('a131', 'Villechalane', 'Louis', 'lvillachane', '8 rue des Charmes', '46000', 'Cahors', '2005-12-21', '2', '3abf9eb797afe468902101efe6b4b00f7d50802a'),
('a17', 'Andre', 'David', 'dandre', '1 rue Petit', '46200', 'Lalbenque', '1998-11-23', '2', '12e0b9be32932a8028b0ef0432a0a0a99421f745'),
('a55', 'Bedos', 'Christian', 'cbedos', '1 rue Peranud', '46250', 'Montcuq', '1995-01-12', '2', 'a34b9dfadee33917a63c3cdebdc9526230611f0b'),
('a93', 'Tusseau', 'Louis', 'ltusseau', '22 rue des Ternes', '46123', 'Gramat', '2000-05-01', '2', 'f1c1d39e9898f3202a2eaa3dc38ae61575cd77ad'),
('b13', 'Bentot', 'Pascal', 'pbentot', '11 allée des Cerises', '46512', 'Bessines', '1992-07-09', '2', '178e1efaf000fdf2267edc43fad2a65197a0ab10'),
('b16', 'Bioret', 'Luc', 'lbioret', '1 Avenue gambetta', '46000', 'Cahors', '1998-05-11', '2', 'ab7fa51f9bf8fde35d9e5bcc5066d3b71dda00d2'),
('b19', 'Bunisset', 'Francis', 'fbunisset', '10 rue des Perles', '93100', 'Montreuil', '1987-10-21', '2', 'aa710ca3a1f12234bc2872aa0a6f88d6cf896ae4'),
('b25', 'Bunisset', 'Denise', 'dbunisset', '23 rue Manin', '75019', 'paris', '2010-12-05', '2', '40ff56dc0525aa08de29eba96271997a91e7d405'),
('b28', 'Cacheux', 'Bernard', 'bcacheux', '114 rue Blanche', '75017', 'Paris', '2009-11-12', '2', '51a4fac4890def1ef8605f0b2e6554c86b2eb919'),
('b34', 'Cadic', 'Eric', 'ecadic', '123 avenue de la République', '75011', 'Paris', '2008-09-23', '2', '2ed5ee95d2588be3650a935ff7687dee46d70fc8'),
('b4', 'Charoze', 'Catherine', 'ccharoze', '100 rue Petit', '75019', 'Paris', '2005-11-12', '2', '8b16cf71ab0842bd871bce99a1ba61dd7e9d4423'),
('b50', 'Clepkens', 'Christophe', 'cclepkens', '12 allée des Anges', '93230', 'Romainville', '2003-08-11', '2', '7ddda57eca7a823c85ac0441adf56928b47ece76'),
('b59', 'Cottin', 'Vincenne', 'vcottin', '36 rue Des Roches', '93100', 'Monteuil', '2001-11-18', '2', '2f95d1cac7b8e7459376bf36b93ae7333026282d'),
('c14', 'Daburon', 'François', 'fdaburon', '13 rue de Chanzy', '94000', 'Créteil', '2002-02-11', '2', '5c7cc4a7f0123460c29c84d8f8a73bc86184adbb'),
('c3', 'De', 'Philippe', 'pde', '13 rue Barthes', '94000', 'Créteil', '2010-12-14', '2', '03b03872dd570959311f4fb9be01788e4d1a2abf'),
('c54', 'Debelle', 'Michel', 'mdebelle', '181 avenue Barbusse', '93210', 'Rosny', '2006-11-23', '2', '1fa95c2fac5b14c6386b73cbe958b663fc66fdfa'),
('d13', 'Debelle', 'Jeanne', 'jdebelle', '134 allée des Joncs', '44000', 'Nantes', '2000-05-11', '2', '18c2cad6adb7cee7884f70108cfd0a9b448be9be'),
('d51', 'Debroise', 'Michel', 'mdebroise', '2 Bld Jourdain', '44000', 'Nantes', '2001-04-17', '2', '46b609fe3aaa708f5606469b5bc1c0fa85010d76'),
('e22', 'Desmarquest', 'Nathalie', 'ndesmarquest', '14 Place d Arc', '45000', 'Orléans', '2005-11-12', '2', 'abc20ea01dabd079ddd63fd9006e7232e442973c'),
('e24', 'Desnost', 'Pierre', 'pdesnost', '16 avenue des Cèdres', '23200', 'Guéret', '2001-02-05', '2', '8eaa8011ec8aa8baa63231a21d12f4138ccc1a3d'),
('e39', 'Dudouit', 'Frédéric', 'fdudouit', '18 rue de l église', '23120', 'GrandBourg', '2000-08-01', '2', '55072fa16c988da8f1fb31e40e4ac5f325ac145d'),
('e49', 'Duncombe', 'Claude', 'cduncombe', '19 rue de la tour', '23100', 'La souteraine', '1987-10-10', '2', '577576f0b2c56c43b596f701b782870c8742c592'),
('e5', 'Enault-Pascreau', 'Céline', 'cenault', '25 place de la gare', '23200', 'Gueret', '1995-09-01', '2', 'cc0fb4115bb04c613fd1b95f4792fc44f07e9f4f'),
('e52', 'Eynde', 'Valérie', 'veynde', '3 Grand Place', '13015', 'Marseille', '1999-11-01', '2', 'd06ace8d729693904c304625e6a6fab6ab9e9746'),
('f21', 'Finck', 'Jacques', 'jfinck', '10 avenue du Prado', '13002', 'Marseille', '2001-11-10', '2', '6d8b2060b60132d9bdb09d37913fbef637b295f2'),
('f39', 'Frémont', 'Fernande', 'ffremont', '4 route de la mer', '13012', 'Allauh', '1998-10-01', '1', 'aa45efe9ecbf37db0089beeedea62ceb57db7f17'),
('f4', 'Gest', 'Alain', 'agest', '30 avenue de la mer', '13025', 'Berre', '1985-11-01', '0', '1af7dedacbbe8ce324e316429a816daeff4c542f'),
('z44', 'Administrateur', 'Un', 'admin', '198 rue de lille', '59130', 'Lammbersart', '1985-11-01', '0', 'd033e22ae348aeb5660fc2140aec35850c4da997');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `fichefrais`
--
ALTER TABLE `fichefrais`
  ADD CONSTRAINT `fichefrais_ibfk_1` FOREIGN KEY (`idEtat`) REFERENCES `etat` (`id`),
  ADD CONSTRAINT `fichefrais_ibfk_2` FOREIGN KEY (`idutilisateur`) REFERENCES `utilisateur` (`id`);

--
-- Constraints for table `lignefraisforfait`
--
ALTER TABLE `lignefraisforfait`
  ADD CONSTRAINT `lignefraisforfait_ibfk_3` FOREIGN KEY (`idFraisForfait`) REFERENCES `fraisforfait` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `lignefraisforfait_ibfk_1` FOREIGN KEY (`idutilisateur`, `mois`) REFERENCES `fichefrais` (`idutilisateur`, `mois`);

--
-- Constraints for table `lignefraishorsforfait`
--
ALTER TABLE `lignefraishorsforfait`
  ADD CONSTRAINT `lignefraishorsforfait_ibfk_1` FOREIGN KEY (`idutilisateur`, `mois`) REFERENCES `fichefrais` (`idutilisateur`, `mois`);

--
-- Constraints for table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `role_ibfk_1` FOREIGN KEY (`idRole`) REFERENCES `role` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
