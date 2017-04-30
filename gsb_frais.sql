-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Dim 30 Avril 2017 à 17:08
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gsb_frais`
--

-- --------------------------------------------------------

--
-- Structure de la table `cabinet`
--

CREATE TABLE `cabinet` (
  `id` int(11) NOT NULL,
  `rue` varchar(255) NOT NULL,
  `CP` varchar(25) NOT NULL,
  `ville` varchar(255) NOT NULL,
  `longitude` double NOT NULL,
  `latitude` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `cabinet`
--

INSERT INTO `cabinet` (`id`, `rue`, `CP`, `ville`, `longitude`, `latitude`) VALUES
(1, '91, rue nationale', '59000', 'Lille', 1205815.584, 56214556.5969),
(2, 'rue Dupont', '59000', 'Lille', 928.22, 222.22),
(3, '51, boulevard de la liberté', '59000', 'Lille', 1555815.584, 5621875556.5969),
(4, '155 rue de Paris', '59000', 'Lille', 3.0683173, 50.6331888),
(5, '5 rue Dupont', '59000', 'Lille', 928.22, 222.22),
(6, '12 rue Dupuit', '59000', 'Lille', 998.22, 322.22),
(7, '120 Avenue Fosh', '59000', 'Lille', 228.22, 292.22),
(8, '78 Boulevard De Gaule', '59000', 'Lille', 718.12, 456.12),
(9, '34 rue Pagnol', '59000', 'Lille', 58.22, 22.22),
(10, '28 rue Hugo', '59000', 'Lille', 108.22, 2.22),
(11, '10 Avenue Bjorn', '59000', 'Lille', 92128.22, 2022.22),
(12, '39 Boulevard de Paris', '59000', 'Lille', 128.22, 982.22),
(13, '111 Avenue Fosh', '59000', 'Lille', 2008.22, 2299.29),
(14, '20 Boulevard de la liberté', '59000', 'Lille', 1010.1, 2817),
(15, '39 rue nationale', '59000', 'Lille', 7168, 838.118);

-- --------------------------------------------------------

--
-- Structure de la table `etat`
--

CREATE TABLE `etat` (
  `id` char(2) NOT NULL,
  `libelle` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `etat`
--

INSERT INTO `etat` (`id`, `libelle`) VALUES
('CL', 'Saisie clôturée'),
('CR', 'Fiche créée, saisie en cours'),
('RB', 'Remboursée'),
('VA', 'Validée et mise en paiement');

-- --------------------------------------------------------

--
-- Structure de la table `fichefrais`
--

CREATE TABLE `fichefrais` (
  `idutilisateur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `nbJustificatifs` int(11) DEFAULT NULL,
  `montantValide` decimal(10,2) DEFAULT NULL,
  `dateModif` date DEFAULT NULL,
  `idEtat` char(2) DEFAULT 'CR'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `fichefrais`
--

INSERT INTO `fichefrais` (`idutilisateur`, `mois`, `nbJustificatifs`, `montantValide`, `dateModif`, `idEtat`) VALUES
('a131', '201611', 0, '0.00', '2016-12-03', 'CL'),
('a131', '201612', 0, '0.00', '2017-03-07', 'CL'),
('a131', '201703', 0, '0.00', '2017-04-13', 'CL'),
('a131', '201704', 0, '0.00', '2017-04-13', 'CR'),
('a17', '201611', 0, '0.00', '2016-12-03', 'CL'),
('a17', '201701', 0, '0.00', '2017-04-04', 'CL'),
('a17', '201702', 0, '0.00', '2017-04-03', 'CL'),
('a17', '201704', 0, '0.00', '2017-04-04', 'CR'),
('c3', '201612', 0, '0.00', '2016-12-07', 'CR'),
('f39', '201612', 0, '0.00', '2016-12-03', 'CR'),
('z44', '201704', 0, '0.00', '2017-04-07', 'CR');

-- --------------------------------------------------------

--
-- Structure de la table `fraisforfait`
--

CREATE TABLE `fraisforfait` (
  `id` char(3) NOT NULL,
  `libelle` char(20) DEFAULT NULL,
  `montant` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `fraisforfait`
--

INSERT INTO `fraisforfait` (`id`, `libelle`, `montant`) VALUES
('ETP', 'Forfait Etape', '10.00'),
('KM', 'Frais Kilométrique', '0.62'),
('NUI', 'Nuitée Hôtel', '80.00'),
('REP', 'Repas Restaurant', '25.00');

-- --------------------------------------------------------

--
-- Structure de la table `lignefraisforfait`
--

CREATE TABLE `lignefraisforfait` (
  `id` int(11) NOT NULL,
  `idutilisateur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `idFraisForfait` char(3) NOT NULL,
  `quantite` int(11) DEFAULT NULL,
  `montant` decimal(10,2) NOT NULL,
  `dateFrais` date DEFAULT NULL,
  `typeFrais` varchar(20) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `lignefraisforfait`
--

INSERT INTO `lignefraisforfait` (`id`, `idutilisateur`, `mois`, `idFraisForfait`, `quantite`, `montant`, `dateFrais`, `typeFrais`, `description`) VALUES
(69, 'a17', '201704', 'ETP', 2, '20.00', '2017-01-05', 'Forfait Etape', 'Réunion'),
(73, 'a17', '201704', 'ETP', 2, '20.00', '2017-04-13', 'Forfait Etape', 'RDV medecin'),
(74, 'a17', '201704', 'REP', 8, '200.00', '2017-04-01', 'Repas Restaurant', 'Repas professionnel'),
(76, 'a17', '201704', 'ETP', 2, '20.00', '2017-04-15', 'Forfait Etape', 'RDV medecin'),
(78, 'a17', '201611', 'ETP', 1, '10.00', '2016-11-22', 'Forfait Etape', 'Réunion'),
(80, 'a17', '201611', 'ETP', 2, '20.00', '2016-11-03', 'Forfait Etape', 'RDV medecin'),
(82, 'a17', '201704', 'NUI', 4, '320.00', '2017-04-15', 'Nuitée Hôtel', 'Hotel'),
(91, 'a17', '201704', 'ETP', 2, '20.00', '2017-04-16', 'Forfait Etape', 'Réunion'),
(94, 'a17', '201704', 'KM', 4, '2.48', '2017-04-01', 'Frais Kilométrique', 'Trajet');

--
-- Déclencheurs `lignefraisforfait`
--
DELIMITER $$
CREATE TRIGGER `before_insert_lignefraisforfait` BEFORE INSERT ON `lignefraisforfait` FOR EACH ROW SET NEW.montant = ( SELECT NEW.quantite * fraisforfait.montant 
                    FROM fraisforfait 
                    WHERE NEW.idFraisForfait = fraisforfait.id )
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `before_update_lignefraisforfait` BEFORE UPDATE ON `lignefraisforfait` FOR EACH ROW SET NEW.montant = 
( SELECT NEW.quantite* fraisforfait.montant 
  FROM fraisforfait 
  WHERE NEW.idFraisForfait = fraisforfait.id )
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `lignefraishorsforfait`
--

CREATE TABLE `lignefraishorsforfait` (
  `id` int(11) NOT NULL,
  `idutilisateur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `libelle` varchar(100) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `montant` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `lignefraishorsforfait`
--

INSERT INTO `lignefraishorsforfait` (`id`, `idutilisateur`, `mois`, `libelle`, `date`, `montant`) VALUES
(1, 'a131', '201611', 'hotel trés cher', '2016-10-12', '120.00'),
(2, 'a131', '201611', 'Restaurant "chez Benoît"', '2016-05-01', '1500.00'),
(4, 'a17', '201704', 'Nouveau PC', '2017-04-02', '800.00'),
(5, 'a17', '201704', 'cartouches d\'encres imprimante', '2017-04-02', '20.00'),
(6, 'a17', '201704', 'Test', '2017-02-02', '100.00'),
(7, 'a17', '201704', 'Machine à café', '2017-04-12', '100.00'),
(8, 'a17', '201704', 'Donuts', '2017-01-01', '10.00');

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

CREATE TABLE `medecin` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `idcabinet` int(11) NOT NULL,
  `idutilisateur` char(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `medecin`
--

INSERT INTO `medecin` (`id`, `nom`, `prenom`, `idcabinet`, `idutilisateur`) VALUES
(3, 'Alexis', 'Fjord', 3, 'a93'),
(4, 'Dupont', 'Louis', 2, 'a93'),
(13, 'Peuplut', 'Jean', 1, 'a131'),
(15, 'Gilbert', 'Francis', 1, 'a131'),
(16, 'Patrick', 'Pierre', 2, 'a131'),
(19, 'Bernard', 'Jean', 12, 'a17'),
(29, 'Dupuit', 'Didier', 15, 'b4'),
(30, 'Souls', 'Jean-marc', 14, 'b34'),
(31, 'Poutau', 'Fabrice', 13, 'b25'),
(32, 'Gigot', 'Paul', 12, 'b28'),
(33, 'Guili', 'Robert', 11, 'b50'),
(34, 'Johnson', 'Marc', 10, 'b59'),
(35, 'Lapeche', 'Marine', 9, 'c14'),
(36, 'detour', 'Flore', 8, 'c54'),
(37, 'Grand', 'Julie', 7, 'd13'),
(38, 'Pilier', 'Babette', 6, 'e24'),
(39, 'Potue', 'Lydia', 5, 'e39'),
(40, 'Clear', 'Jean', 4, 'e49');

--
-- Déclencheurs `medecin`
--
DELIMITER $$
CREATE TRIGGER `increment_utilisateur_version_delete_medecin` AFTER DELETE ON `medecin` FOR EACH ROW update utilisateur 
set version = version + 1 
where id = old.idutilisateur
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `increment_utilisateur_version_insert_medecin` AFTER INSERT ON `medecin` FOR EACH ROW update utilisateur 
set version = version + 1
where id = new.idutilisateur
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `increment_utilisateur_version_medecin` AFTER UPDATE ON `medecin` FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `role`
--

CREATE TABLE `role` (
  `id` char(2) NOT NULL,
  `profession` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `role`
--

INSERT INTO `role` (`id`, `profession`) VALUES
('0', 'Administrateur'),
('1', 'Comptable'),
('2', 'Visiteur médical');

-- --------------------------------------------------------

--
-- Structure de la table `statut`
--

CREATE TABLE `statut` (
  `occupe` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `statut`
--

INSERT INTO `statut` (`occupe`) VALUES
(0);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id` char(4) NOT NULL,
  `nom` char(30) DEFAULT NULL,
  `prenom` char(30) DEFAULT NULL,
  `login` char(20) DEFAULT NULL,
  `mdp` char(20) DEFAULT NULL,
  `adresse` char(30) DEFAULT NULL,
  `cp` char(5) DEFAULT NULL,
  `ville` char(30) DEFAULT NULL,
  `dateEmbauche` date DEFAULT NULL,
  `idRole` varchar(25) DEFAULT NULL,
  `email` varchar(500) DEFAULT NULL,
  `version` int(5) NOT NULL,
  `reponse` varchar(50) DEFAULT NULL,
  `mdpSHA` char(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Anciennement table visiteur';

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom`, `prenom`, `login`, `mdp`, `adresse`, `cp`, `ville`, `dateEmbauche`, `idRole`, `email`, `version`, `reponse`, `mdpSHA`) VALUES
('a131', 'Villechalane', 'Louis', 'lvillachane', 'jux7g', '8 rue des Charmes', '46000', 'Cahors', '2005-12-21', '2', 'villachane.louis@gsb.fr', 29, 'rex', '3abf9eb797afe468902101efe6b4b00f7d50802a'),
('a17', 'Andre', 'David', 'dandre', 'oppg5', '1 rue Petit', '46200', 'Lalbenque', '1998-11-23', '2', 'andre.david@gsb.fr', 39, 'tigrou', '12e0b9be32932a8028b0ef0432a0a0a99421f745'),
('a55', 'Bedos', 'Christian', 'cbedos', 'gmhxd', '1 rue Peranud', '46250', 'Montcuq', '1995-01-12', '2', 'bedos@christian@gsb.fr', 8, NULL, 'a34b9dfadee33917a63c3cdebdc9526230611f0b'),
('a93', 'Tusseau', 'Louis', 'ltusseau', 'ktp3s', '22 rue des Ternes', '46123', 'Gramat', '2000-05-01', '2', 'tusseau.louis@gsb.fr', 6, NULL, 'f1c1d39e9898f3202a2eaa3dc38ae61575cd77ad'),
('b13', 'Bentot', 'Pascal', 'pbentot', 'doyw1', '11 allée des Cerises', '46512', 'Bessines', '1992-07-09', '2', 'bentot.pascal@gsb.fr', 3, NULL, '178e1efaf000fdf2267edc43fad2a65197a0ab10'),
('b16', 'Bioret', 'Luc', 'lbioret', 'hrjfs', '1 Avenue gambetta', '46000', 'Cahors', '1998-05-11', '2', 'bioret.luc@gsb.fr', 5, NULL, 'ab7fa51f9bf8fde35d9e5bcc5066d3b71dda00d2'),
('b19', 'Bunisset', 'Francis', 'fbunisset', '4vbnd', '10 rue des Perles', '93100', 'Montreuil', '1987-10-21', '2', 'buisset.francis@gsb.fr', 4, NULL, 'aa710ca3a1f12234bc2872aa0a6f88d6cf896ae4'),
('b25', 'Bunisset', 'Denise', 'dbunisset', 's1y1r', '23 rue Manin', '75019', 'paris', '2010-12-05', '2', 'bunisset.denise@gsb.fr', 5, NULL, '40ff56dc0525aa08de29eba96271997a91e7d405'),
('b28', 'Cacheux', 'Bernard', 'bcacheux', 'uf7r3', '114 rue Blanche', '75017', 'Paris', '2009-11-12', '2', 'cachez.bernard@gsb.fr', 5, NULL, '51a4fac4890def1ef8605f0b2e6554c86b2eb919'),
('b34', 'Cadic', 'Eric', 'ecadic', '6u8dc', '123 avenue de la République', '75011', 'Paris', '2008-09-23', '2', 'cadic.eric@gsb.fr', 8, NULL, '2ed5ee95d2588be3650a935ff7687dee46d70fc8'),
('b4', 'Charoze', 'Catherine', 'ccharoze', 'u817o', '100 rue Petit', '75019', 'Paris', '2005-11-12', '2', 'charoze.catherine@gsb.fr', 5, NULL, '8b16cf71ab0842bd871bce99a1ba61dd7e9d4423'),
('b50', 'Clepkens', 'Christophe', 'cclepkens', 'bw1us', '12 allée des Anges', '93230', 'Romainville', '2003-08-11', '2', 'clepkens.christophe@gsb.fr', 3, NULL, '7ddda57eca7a823c85ac0441adf56928b47ece76'),
('b59', 'Cottin', 'Vincenne', 'vcottin', '2hoh9', '36 rue Des Roches', '93100', 'Monteuil', '2001-11-18', '2', 'cottin.vincenne@gsb.fr', 3, NULL, '2f95d1cac7b8e7459376bf36b93ae7333026282d'),
('c14', 'Daburon', 'François', 'fdaburon', '7oqpv', '13 rue de Chanzy', '94000', 'Créteil', '2002-02-11', '2', 'daburon.francois@gsb.fr', 3, NULL, '5c7cc4a7f0123460c29c84d8f8a73bc86184adbb'),
('c3', 'De', 'Philippe', 'pde', 'gk9kx', '13 rue Barthes', '94000', 'Créteil', '2010-12-14', '2', 'de.phillipe@gsb.fr', 2, NULL, '03b03872dd570959311f4fb9be01788e4d1a2abf'),
('c54', 'Debelle', 'Michel', 'mdebelle', 'od5rt', '181 avenue Barbusse', '93210', 'Rosny', '2006-11-23', '2', 'debelle.phillipe@gsb.fr', 5, NULL, '1fa95c2fac5b14c6386b73cbe958b663fc66fdfa'),
('d13', 'Debelle', 'Jeanne', 'jdebelle', 'nvwqq', '134 allée des Joncs', '44000', 'Nantes', '2000-05-11', '2', 'debelle.jeanne@gsb.fr', 3, NULL, '18c2cad6adb7cee7884f70108cfd0a9b448be9be'),
('d51', 'Debroise', 'Michel', 'mdebroise', 'sghkb', '2 Bld Jourdain', '44000', 'Nantes', '2001-04-17', '2', 'debroise.michel@gsb.fr', 2, NULL, '46b609fe3aaa708f5606469b5bc1c0fa85010d76'),
('e22', 'Desmarquest', 'Nathalie', 'ndesmarquest', 'f1fob', '14 Place d Arc', '45000', 'Orléans', '2005-11-12', '2', 'desmarquet.nathalie@gsb.fr', 2, NULL, 'abc20ea01dabd079ddd63fd9006e7232e442973c'),
('e24', 'Desnost', 'Pierre', 'pdesnost', '4k2o5', '16 avenue des Cèdres', '23200', 'Guéret', '2001-02-05', '2', 'desnot.pierre@gsb.fr', 3, NULL, '8eaa8011ec8aa8baa63231a21d12f4138ccc1a3d'),
('e39', 'Dudouit', 'Frédéric', 'fdudouit', '44im8', '18 rue de l église', '23120', 'GrandBourg', '2000-08-01', '2', 'dudouit.frederic@gsb.fr', 3, NULL, '55072fa16c988da8f1fb31e40e4ac5f325ac145d'),
('e49', 'Duncombe', 'Claude', 'cduncombe', 'qf77j', '19 rue de la tour', '23100', 'La souteraine', '1987-10-10', '2', 'duncombe.claude@gsb.fr', 3, NULL, '577576f0b2c56c43b596f701b782870c8742c592'),
('e5', 'Enault-Pascreau', 'Céline', 'cenault', 'y2qdu', '25 place de la gare', '23200', 'Gueret', '1995-09-01', '2', 'enault-pascreau.celine@gsb.fr', 2, NULL, 'cc0fb4115bb04c613fd1b95f4792fc44f07e9f4f'),
('e52', 'Eynde', 'Valérie', 'veynde', 'i7sn3', '3 Grand Place', '13015', 'Marseille', '1999-11-01', '2', 'eynde.valerie@gsb.fr', 2, NULL, 'd06ace8d729693904c304625e6a6fab6ab9e9746'),
('f21', 'Finck', 'Jacques', 'jfinck', 'mpb3t', '10 avenue du Prado', '13002', 'Marseille', '2001-11-10', '2', 'finck.jacques@gsb.fr', 2, NULL, '6d8b2060b60132d9bdb09d37913fbef637b295f2'),
('f39', 'Frémont', 'Fernande', 'ffremont', 'xs5tq', '4 route de la mer', '13012', 'Allauh', '1998-10-01', '1', 'fremont.fernande@gsb.fr', 2, NULL, 'aa45efe9ecbf37db0089beeedea62ceb57db7f17'),
('f4', 'Gest', 'Alain', 'agest', 'dywvt', '30 avenue de la mer', '13025', 'Berre', '1985-11-01', '0', 'gest.alain@gsb.fr', 2, NULL, '1af7dedacbbe8ce324e316429a816daeff4c542f'),
('z44', 'Administrateur', 'Un', 'admin', 'admin', '198 rue de lille', '59130', 'Lammbersart', '1985-11-01', '0', 'admin.asmin@gsb.fr', 2, NULL, 'd033e22ae348aeb5660fc2140aec35850c4da997');

-- --------------------------------------------------------

--
-- Structure de la table `visite`
--

CREATE TABLE `visite` (
  `id` int(11) NOT NULL,
  `dateVisite` date NOT NULL,
  `rdv` tinyint(1) NOT NULL,
  `idutilisateur` char(4) NOT NULL,
  `idmedecin` int(11) NOT NULL,
  `heureArrivee` datetime NOT NULL,
  `heureDepart` datetime NOT NULL,
  `heureDebut` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `visite`
--

INSERT INTO `visite` (`id`, `dateVisite`, `rdv`, `idutilisateur`, `idmedecin`, `heureArrivee`, `heureDepart`, `heureDebut`) VALUES
(11, '2017-04-05', 1, 'a131', 13, '2017-04-05 14:10:00', '2017-04-05 15:00:00', '2017-04-05 14:30:00'),
(15, '2017-02-02', 1, 'a17', 19, '2017-02-02 10:30:00', '2017-02-02 12:30:00', '2017-02-02 11:30:00'),
(22, '2017-03-04', 1, 'a55', 3, '2017-03-04 12:00:00', '2017-03-04 14:00:00', '2017-03-04 12:30:00'),
(23, '2017-01-04', 13, 'b13', 3, '2017-01-04 10:00:00', '2017-01-04 14:00:00', '2017-01-04 12:30:00'),
(24, '2017-06-04', 16, 'b16', 3, '2017-06-04 09:00:00', '2017-06-04 14:00:00', '2017-06-04 12:30:00'),
(26, '0000-00-00', 1, 'b34', 4, '2017-04-20 09:20:00', '2017-04-20 10:00:00', '2017-04-20 09:30:00'),
(28, '2017-04-29', 1, 'b4', 29, '2017-04-29 13:36:00', '2017-04-29 17:00:00', '2017-04-29 15:00:00'),
(29, '2017-12-04', 1, 'b34', 30, '2017-12-04 14:20:00', '2017-12-04 15:00:00', '2017-12-04 14:30:00'),
(30, '2017-04-24', 1, 'b25', 31, '2017-04-24 06:00:00', '2017-04-24 10:00:00', '2017-04-24 08:00:00'),
(31, '2017-04-14', 1, 'b28', 32, '2017-04-14 10:21:00', '2017-04-14 13:00:00', '2017-04-14 11:00:00'),
(32, '2017-04-25', 1, 'c54', 36, '2017-04-25 08:38:00', '2017-04-25 18:00:00', '2017-04-25 11:00:00');

--
-- Déclencheurs `visite`
--
DELIMITER $$
CREATE TRIGGER `increment_utilisateur_version_delete_visite` AFTER DELETE ON `visite` FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `increment_utilisateur_version_insert_visite` AFTER INSERT ON `visite` FOR EACH ROW update utilisateur 
set version = version + 1 
where id = new.idutilisateur
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `increment_utilisateur_version_visite` AFTER UPDATE ON `visite` FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur
$$
DELIMITER ;

--
-- Index pour les tables exportées
--

--
-- Index pour la table `cabinet`
--
ALTER TABLE `cabinet`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `etat`
--
ALTER TABLE `etat`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `fichefrais`
--
ALTER TABLE `fichefrais`
  ADD PRIMARY KEY (`idutilisateur`,`mois`),
  ADD KEY `idEtat` (`idEtat`);

--
-- Index pour la table `fraisforfait`
--
ALTER TABLE `fraisforfait`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `lignefraisforfait`
--
ALTER TABLE `lignefraisforfait`
  ADD PRIMARY KEY (`id`),
  ADD KEY `lignefraisforfait_ibfk_1` (`idutilisateur`,`mois`),
  ADD KEY `idFraisForfait` (`idFraisForfait`);

--
-- Index pour la table `lignefraishorsforfait`
--
ALTER TABLE `lignefraishorsforfait`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idutilisateur` (`idutilisateur`,`mois`);

--
-- Index pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idutilisateur` (`idutilisateur`,`idcabinet`),
  ADD KEY `FK_medecin_id_cabinet` (`idcabinet`);

--
-- Index pour la table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role_ibfk_1` (`idRole`);

--
-- Index pour la table `visite`
--
ALTER TABLE `visite`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idutilisateur` (`idutilisateur`,`idmedecin`),
  ADD KEY `FK_visite_id_medecin` (`idmedecin`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `cabinet`
--
ALTER TABLE `cabinet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT pour la table `lignefraisforfait`
--
ALTER TABLE `lignefraisforfait`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=95;
--
-- AUTO_INCREMENT pour la table `lignefraishorsforfait`
--
ALTER TABLE `lignefraishorsforfait`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `medecin`
--
ALTER TABLE `medecin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;
--
-- AUTO_INCREMENT pour la table `visite`
--
ALTER TABLE `visite`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `fichefrais`
--
ALTER TABLE `fichefrais`
  ADD CONSTRAINT `fichefrais_ibfk_1` FOREIGN KEY (`idEtat`) REFERENCES `etat` (`id`),
  ADD CONSTRAINT `fichefrais_ibfk_2` FOREIGN KEY (`idutilisateur`) REFERENCES `utilisateur` (`id`);

--
-- Contraintes pour la table `lignefraisforfait`
--
ALTER TABLE `lignefraisforfait`
  ADD CONSTRAINT `lignefraisforfait_ibfk_1` FOREIGN KEY (`idutilisateur`,`mois`) REFERENCES `fichefrais` (`idutilisateur`, `mois`),
  ADD CONSTRAINT `lignefraisforfait_ibfk_4` FOREIGN KEY (`idFraisForfait`) REFERENCES `fraisforfait` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `lignefraishorsforfait`
--
ALTER TABLE `lignefraishorsforfait`
  ADD CONSTRAINT `lignefraishorsforfait_ibfk_1` FOREIGN KEY (`idutilisateur`,`mois`) REFERENCES `fichefrais` (`idutilisateur`, `mois`);

--
-- Contraintes pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD CONSTRAINT `FK_medecin_id_cabinet` FOREIGN KEY (`idcabinet`) REFERENCES `cabinet` (`id`),
  ADD CONSTRAINT `FK_medecin_id_utilisateur` FOREIGN KEY (`idutilisateur`) REFERENCES `utilisateur` (`id`);

--
-- Contraintes pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `role_ibfk_1` FOREIGN KEY (`idRole`) REFERENCES `role` (`id`);

--
-- Contraintes pour la table `visite`
--
ALTER TABLE `visite`
  ADD CONSTRAINT `FK_visite_id_medecin` FOREIGN KEY (`idmedecin`) REFERENCES `medecin` (`id`),
  ADD CONSTRAINT `FK_visite_id_utilisateur` FOREIGN KEY (`idutilisateur`) REFERENCES `utilisateur` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
