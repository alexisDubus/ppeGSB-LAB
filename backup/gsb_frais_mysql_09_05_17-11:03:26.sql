-- MySQL dump 10.13  Distrib 5.7.18, for Linux (x86_64)
--
-- Host: localhost    Database: gsb_frais
-- ------------------------------------------------------
-- Server version	5.7.18-0ubuntu0.16.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cabinet`
--

DROP TABLE IF EXISTS `cabinet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cabinet` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rue` varchar(255) NOT NULL,
  `CP` varchar(25) NOT NULL,
  `ville` varchar(255) NOT NULL,
  `longitude` double NOT NULL,
  `latitude` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cabinet`
--

LOCK TABLES `cabinet` WRITE;
/*!40000 ALTER TABLE `cabinet` DISABLE KEYS */;
INSERT INTO `cabinet` VALUES (1,'91, rue nationale','59000','Lille',3.0582114,50.6347666),(2,'108, boulevard de la liberte','59000','Lille',3.0655001,50.629413),(3,'51, boulevard de la liberte','59000','Lille',3.0557126,50.6353533),(4,'81 rue nationale','59000','lille',3.0455384,50.6297968),(5,'5 rue nationale','95000','Paris',2.0614565,49.034538),(6,'5 rue de la paix','95000','Paris',2.3301829,48.8689845),(7,'2 Avenue du Général de Gaulle','51100','Reims',4.0209051,49.2484884),(8,'3 rue Gambetta','51100','Reims',4.0355698,49.2507635),(9,'1 rue Magellan','76600','LeHavre',0.1255419,49.493072),(10,'9 rue Saint-Pierre','13000','Marseille',5.3873545,43.2938706),(11,'10 Boulevard Jeanne d\'Arc','13000','Marseille',5.3992056,43.2939033),(12,'2 rue de Maubeuge','75001','paris',2.3402949,48.876043);
/*!40000 ALTER TABLE `cabinet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `etat`
--

DROP TABLE IF EXISTS `etat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `etat` (
  `id` char(2) NOT NULL,
  `libelle` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etat`
--

LOCK TABLES `etat` WRITE;
/*!40000 ALTER TABLE `etat` DISABLE KEYS */;
INSERT INTO `etat` VALUES ('CL','Saisie clôturée'),('CR','Fiche créée, saisie en cours'),('RB','Remboursée'),('VA','Validée et mise en paiement');
/*!40000 ALTER TABLE `etat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fichefrais`
--

DROP TABLE IF EXISTS `fichefrais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fichefrais` (
  `idutilisateur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `nbJustificatifs` int(11) DEFAULT NULL,
  `montantValide` decimal(10,2) DEFAULT NULL,
  `dateModif` date DEFAULT NULL,
  `idEtat` char(2) DEFAULT 'CR',
  PRIMARY KEY (`idutilisateur`,`mois`),
  KEY `idEtat` (`idEtat`),
  CONSTRAINT `fichefrais_ibfk_1` FOREIGN KEY (`idEtat`) REFERENCES `etat` (`id`),
  CONSTRAINT `fichefrais_ibfk_2` FOREIGN KEY (`idutilisateur`) REFERENCES `utilisateur` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fichefrais`
--

LOCK TABLES `fichefrais` WRITE;
/*!40000 ALTER TABLE `fichefrais` DISABLE KEYS */;
INSERT INTO `fichefrais` VALUES ('a131','201611',0,0.00,'2016-12-03','CL'),('a131','201612',0,0.00,'2017-03-07','CL'),('a131','201703',0,0.00,'2017-04-13','CL'),('a131','201704',0,0.00,'2017-05-09','CL'),('a131','201705',0,0.00,'2017-05-09','CR'),('a17','201611',0,0.00,'2016-12-03','CL'),('a17','201701',0,0.00,'2017-04-04','CL'),('a17','201702',0,0.00,'2017-04-03','CL'),('a17','201704',0,0.00,'2017-05-05','CL'),('a17','201705',0,0.00,'2017-05-05','CR'),('c3','201612',0,0.00,'2016-12-07','CR'),('f39','201612',0,0.00,'2016-12-03','CR'),('z44','201704',0,0.00,'2017-04-07','CR');
/*!40000 ALTER TABLE `fichefrais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fraisforfait`
--

DROP TABLE IF EXISTS `fraisforfait`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fraisforfait` (
  `id` char(3) NOT NULL,
  `libelle` char(20) DEFAULT NULL,
  `montant` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fraisforfait`
--

LOCK TABLES `fraisforfait` WRITE;
/*!40000 ALTER TABLE `fraisforfait` DISABLE KEYS */;
INSERT INTO `fraisforfait` VALUES ('ETP','Forfait Etape',10.00),('KM','Frais Kilométrique',0.62),('NUI','Nuitée Hôtel',80.00),('REP','Repas Restaurant',25.00);
/*!40000 ALTER TABLE `fraisforfait` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lignefraisforfait`
--

DROP TABLE IF EXISTS `lignefraisforfait`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lignefraisforfait` (
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
  KEY `idFraisForfait` (`idFraisForfait`),
  CONSTRAINT `lignefraisforfait_ibfk_1` FOREIGN KEY (`idutilisateur`, `mois`) REFERENCES `fichefrais` (`idutilisateur`, `mois`),
  CONSTRAINT `lignefraisforfait_ibfk_4` FOREIGN KEY (`idFraisForfait`) REFERENCES `fraisforfait` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lignefraisforfait`
--

LOCK TABLES `lignefraisforfait` WRITE;
/*!40000 ALTER TABLE `lignefraisforfait` DISABLE KEYS */;
INSERT INTO `lignefraisforfait` VALUES (68,'a17','201704','REP',345,8625.00,'2016-06-09','Repas Restaurant','Repas professionnel'),(69,'a17','201704','ETP',2,20.00,'2017-01-05','Forfait Etape','Réunion'),(73,'a17','201704','ETP',2,20.00,'2017-04-13','Forfait Etape','RDV medecin'),(74,'a17','201704','REP',8,200.00,'2017-04-01','Repas Restaurant','Repas professionnel'),(76,'a17','201704','ETP',2,20.00,'2017-04-15','Forfait Etape','RDV medecin'),(78,'a17','201611','ETP',1,10.00,'2016-11-22','Forfait Etape','Réunion'),(80,'a17','201611','ETP',2,20.00,'2016-11-03','Forfait Etape','RDV medecin'),(82,'a17','201704','NUI',4,320.00,'2017-04-15','Nuitée Hôtel','Hotel'),(91,'a17','201704','ETP',2,20.00,'2017-04-16','Forfait Etape','Réunion'),(94,'a17','201704','KM',4,2.48,'2017-04-01','Frais Kilométrique','Trajet'),(95,'a17','201705','ETP',0,0.00,NULL,NULL,NULL),(96,'a17','201705','KM',0,0.00,NULL,NULL,NULL),(97,'a17','201705','NUI',0,0.00,NULL,NULL,NULL),(98,'a17','201705','REP',0,0.00,NULL,NULL,NULL),(99,'a131','201705','ETP',0,0.00,NULL,NULL,NULL),(100,'a131','201705','KM',0,0.00,NULL,NULL,NULL),(101,'a131','201705','NUI',0,0.00,NULL,NULL,NULL),(102,'a131','201705','REP',0,0.00,NULL,NULL,NULL);
/*!40000 ALTER TABLE `lignefraisforfait` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`admin`@`%`*/ /*!50003 TRIGGER `before_insert_lignefraisforfait` BEFORE INSERT ON `lignefraisforfait`
 FOR EACH ROW SET NEW.montant = ( SELECT NEW.quantite * fraisforfait.montant 
                    FROM fraisforfait 
                    WHERE NEW.idFraisForfait = fraisforfait.id ) */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`admin`@`%`*/ /*!50003 TRIGGER `before_update_lignefraisforfait` BEFORE UPDATE ON `lignefraisforfait`
 FOR EACH ROW SET NEW.montant = 
( SELECT NEW.quantite* fraisforfait.montant 
  FROM fraisforfait 
  WHERE NEW.idFraisForfait = fraisforfait.id ) */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `lignefraishorsforfait`
--

DROP TABLE IF EXISTS `lignefraishorsforfait`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lignefraishorsforfait` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idutilisateur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `libelle` varchar(100) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `montant` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idutilisateur` (`idutilisateur`,`mois`),
  CONSTRAINT `lignefraishorsforfait_ibfk_1` FOREIGN KEY (`idutilisateur`, `mois`) REFERENCES `fichefrais` (`idutilisateur`, `mois`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lignefraishorsforfait`
--

LOCK TABLES `lignefraishorsforfait` WRITE;
/*!40000 ALTER TABLE `lignefraishorsforfait` DISABLE KEYS */;
INSERT INTO `lignefraishorsforfait` VALUES (1,'a131','201611','hotel trés cher','2016-10-12',120.00),(2,'a131','201611','Restaurant \"chez Benoît\"','2016-05-01',1500.00),(4,'a17','201704','Nouveau PC','2017-04-02',800.00),(5,'a17','201704','cartouches d\'encres imprimante','2017-04-02',20.00),(6,'a17','201704','Test','2017-02-02',100.00),(7,'a17','201704','Machine à café','2017-04-12',100.00),(8,'a17','201704','Donuts','2017-01-01',10.00);
/*!40000 ALTER TABLE `lignefraishorsforfait` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medecin`
--

DROP TABLE IF EXISTS `medecin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medecin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `idcabinet` int(11) NOT NULL,
  `idutilisateur` char(4) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idutilisateur` (`idutilisateur`,`idcabinet`),
  KEY `FK_medecin_id_cabinet` (`idcabinet`),
  CONSTRAINT `FK_medecin_id_cabinet` FOREIGN KEY (`idcabinet`) REFERENCES `cabinet` (`id`),
  CONSTRAINT `FK_medecin_id_utilisateur` FOREIGN KEY (`idutilisateur`) REFERENCES `utilisateur` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medecin`
--

LOCK TABLES `medecin` WRITE;
/*!40000 ALTER TABLE `medecin` DISABLE KEYS */;
INSERT INTO `medecin` VALUES (3,'Alexis','Fjord',3,'a93'),(4,'Dupont','Louis',2,'a93'),(13,'Peuplut','Jean',1,'a131'),(15,'Gilbert','Francis',1,'a131'),(16,'Patrick','Pierre',2,'a131'),(19,'Bernard','Jean',12,'a17'),(29,'Dupuit','Didier',10,'b4'),(30,'Souls','Jean-marc',11,'b34'),(31,'Poutau','Fabrice',12,'b25'),(32,'Gigot','Paul',7,'b28'),(33,'Guili','Robert',11,'b50'),(34,'Johnson','Marc',8,'b59'),(35,'Lapeche','Marine',6,'c14'),(36,'detour','Flore',5,'c54'),(37,'Grand','Julie',4,'d13'),(38,'Pilier','Babette',3,'e24'),(39,'Potue','Lydia',5,'e39'),(40,'Clear','Jean',9,'e49');
/*!40000 ALTER TABLE `medecin` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`admin`@`%`*/ /*!50003 TRIGGER `increment_utilisateur_version_insert_medecin` AFTER INSERT ON `medecin`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = new.idutilisateur */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`admin`@`%`*/ /*!50003 TRIGGER `increment_utilisateur_version_medecin` AFTER UPDATE ON `medecin`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`admin`@`%`*/ /*!50003 TRIGGER `increment_utilisateur_version_delete_medecin` AFTER DELETE ON `medecin`
 FOR EACH ROW update utilisateur 
set version = version + 1 
where id = old.idutilisateur */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `role` (
  `id` char(2) NOT NULL,
  `profession` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES ('0','Administrateur'),('1','Comptable'),('2','Visiteur médical');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statut`
--

DROP TABLE IF EXISTS `statut`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `statut` (
  `occupe` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statut`
--

LOCK TABLES `statut` WRITE;
/*!40000 ALTER TABLE `statut` DISABLE KEYS */;
INSERT INTO `statut` VALUES (0);
/*!40000 ALTER TABLE `statut` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
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
  `mdpSHA` char(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `role_ibfk_1` (`idRole`),
  CONSTRAINT `role_ibfk_1` FOREIGN KEY (`idRole`) REFERENCES `role` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Anciennement table visiteur';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilisateur`
--

LOCK TABLES `utilisateur` WRITE;
/*!40000 ALTER TABLE `utilisateur` DISABLE KEYS */;
INSERT INTO `utilisateur` VALUES ('a131','Villechalane','Louis','lvillachane','jux7g','8 rue des Charmes','46000','Cahors','2005-12-21','2','villachane.louis@gsb.fr',29,'rex','3abf9eb797afe468902101efe6b4b00f7d50802a'),('a17','Andre','David','dandre','oppg5','1 rue Petit','46200','Lalbenque','1998-11-23','2','andre.david@gsb.fr',41,'tigrou','12e0b9be32932a8028b0ef0432a0a0a99421f745'),('a55','Bedos','Christian','cbedos','gmhxd','1 rue Peranud','46250','Montcuq','1995-01-12','2','bedos@christian@gsb.fr',10,'rex','a34b9dfadee33917a63c3cdebdc9526230611f0b'),('a93','Tusseau','Louis','ltusseau','ktp3s','22 rue des Ternes','46123','Gramat','2000-05-01','2','tusseau.louis@gsb.fr',6,'rex','f1c1d39e9898f3202a2eaa3dc38ae61575cd77ad'),('b13','Bentot','Pascal','pbentot','doyw1','11 allée des Cerises','46512','Bessines','1992-07-09','2','bentot.pascal@gsb.fr',5,'rex','178e1efaf000fdf2267edc43fad2a65197a0ab10'),('b16','Bioret','Luc','lbioret','hrjfs','1 Avenue gambetta','46000','Cahors','1998-05-11','2','bioret.luc@gsb.fr',7,'rex','ab7fa51f9bf8fde35d9e5bcc5066d3b71dda00d2'),('b19','Bunisset','Francis','fbunisset','4vbnd','10 rue des Perles','93100','Montreuil','1987-10-21','2','buisset.francis@gsb.fr',4,'rex','aa710ca3a1f12234bc2872aa0a6f88d6cf896ae4'),('b25','Bunisset','Denise','dbunisset','s1y1r','23 rue Manin','75019','paris','2010-12-05','2','bunisset.denise@gsb.fr',7,'rex','40ff56dc0525aa08de29eba96271997a91e7d405'),('b28','Cacheux','Bernard','bcacheux','uf7r3','114 rue Blanche','75017','Paris','2009-11-12','2','cachez.bernard@gsb.fr',7,'rex','51a4fac4890def1ef8605f0b2e6554c86b2eb919'),('b34','Cadic','Eric','ecadic','6u8dc','123 avenue de la République','75011','Paris','2008-09-23','2','cadic.eric@gsb.fr',11,'rex','2ed5ee95d2588be3650a935ff7687dee46d70fc8'),('b4','Charoze','Catherine','ccharoze','u817o','100 rue Petit','75019','Paris','2005-11-12','2','charoze.catherine@gsb.fr',7,'rex','8b16cf71ab0842bd871bce99a1ba61dd7e9d4423'),('b50','Clepkens','Christophe','cclepkens','bw1us','12 allée des Anges','93230','Romainville','2003-08-11','2','clepkens.christophe@gsb.fr',3,'rex','7ddda57eca7a823c85ac0441adf56928b47ece76'),('b59','Cottin','Vincenne','vcottin','2hoh9','36 rue Des Roches','93100','Monteuil','2001-11-18','2','cottin.vincenne@gsb.fr',3,'rex','2f95d1cac7b8e7459376bf36b93ae7333026282d'),('c14','Daburon','François','fdaburon','7oqpv','13 rue de Chanzy','94000','Créteil','2002-02-11','2','daburon.francois@gsb.fr',3,'rex','5c7cc4a7f0123460c29c84d8f8a73bc86184adbb'),('c3','De','Philippe','pde','gk9kx','13 rue Barthes','94000','Créteil','2010-12-14','2','de.phillipe@gsb.fr',2,'rex','03b03872dd570959311f4fb9be01788e4d1a2abf'),('c54','Debelle','Michel','mdebelle','od5rt','181 avenue Barbusse','93210','Rosny','2006-11-23','2','debelle.phillipe@gsb.fr',7,'rex','1fa95c2fac5b14c6386b73cbe958b663fc66fdfa'),('d13','Debelle','Jeanne','jdebelle','nvwqq','134 allée des Joncs','44000','Nantes','2000-05-11','2','debelle.jeanne@gsb.fr',3,'rex','18c2cad6adb7cee7884f70108cfd0a9b448be9be'),('d51','Debroise','Michel','mdebroise','sghkb','2 Bld Jourdain','44000','Nantes','2001-04-17','2','debroise.michel@gsb.fr',2,'rex','46b609fe3aaa708f5606469b5bc1c0fa85010d76'),('e22','Desmarquest','Nathalie','ndesmarquest','f1fob','14 Place d Arc','45000','Orléans','2005-11-12','2','desmarquet.nathalie@gsb.fr',2,'rex','abc20ea01dabd079ddd63fd9006e7232e442973c'),('e24','Desnost','Pierre','pdesnost','4k2o5','16 avenue des Cèdres','23200','Guéret','2001-02-05','2','desnot.pierre@gsb.fr',3,'rex','8eaa8011ec8aa8baa63231a21d12f4138ccc1a3d'),('e39','Dudouit','Frédéric','fdudouit','44im8','18 rue de l église','23120','GrandBourg','2000-08-01','2','dudouit.frederic@gsb.fr',3,'rex','55072fa16c988da8f1fb31e40e4ac5f325ac145d'),('e49','Duncombe','Claude','cduncombe','qf77j','19 rue de la tour','23100','La souteraine','1987-10-10','2','duncombe.claude@gsb.fr',3,'rex','577576f0b2c56c43b596f701b782870c8742c592'),('e5','Enault-Pascreau','Céline','cenault','y2qdu','25 place de la gare','23200','Gueret','1995-09-01','2','enault-pascreau.celine@gsb.fr',2,'rex','cc0fb4115bb04c613fd1b95f4792fc44f07e9f4f'),('e52','Eynde','Valérie','veynde','i7sn3','3 Grand Place','13015','Marseille','1999-11-01','2','eynde.valerie@gsb.fr',2,'rex','d06ace8d729693904c304625e6a6fab6ab9e9746'),('f21','Finck','Jacques','jfinck','mpb3t','10 avenue du Prado','13002','Marseille','2001-11-10','2','finck.jacques@gsb.fr',2,'rex','6d8b2060b60132d9bdb09d37913fbef637b295f2'),('f39','Frémont','Fernande','ffremont','xs5tq','4 route de la mer','13012','Allauh','1998-10-01','1','fremont.fernande@gsb.fr',2,'rex','aa45efe9ecbf37db0089beeedea62ceb57db7f17'),('f4','Gest','Alain','agest','dywvt','30 avenue de la mer','13025','Berre','1985-11-01','0','gest.alain@gsb.fr',2,'rex','1af7dedacbbe8ce324e316429a816daeff4c542f'),('z44','Administrateur','Un','admin','admin','198 rue de lille','59130','Lammbersart','1985-11-01','0','admin.asmin@gsb.fr',2,'rex','d033e22ae348aeb5660fc2140aec35850c4da997');
/*!40000 ALTER TABLE `utilisateur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `visite`
--

DROP TABLE IF EXISTS `visite`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `visite` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `dateVisite` date NOT NULL,
  `rdv` tinyint(1) NOT NULL,
  `idutilisateur` char(4) NOT NULL,
  `idmedecin` int(11) NOT NULL,
  `heureArrivee` datetime NOT NULL,
  `heureDepart` datetime NOT NULL,
  `heureDebut` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idutilisateur` (`idutilisateur`,`idmedecin`),
  KEY `FK_visite_id_medecin` (`idmedecin`),
  CONSTRAINT `FK_visite_id_medecin` FOREIGN KEY (`idmedecin`) REFERENCES `medecin` (`id`),
  CONSTRAINT `FK_visite_id_utilisateur` FOREIGN KEY (`idutilisateur`) REFERENCES `utilisateur` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `visite`
--

LOCK TABLES `visite` WRITE;
/*!40000 ALTER TABLE `visite` DISABLE KEYS */;
INSERT INTO `visite` VALUES (11,'2017-04-05',1,'a131',13,'2017-04-05 14:10:00','2017-04-05 15:00:00','2017-04-05 14:30:00'),(15,'2017-02-02',1,'a17',19,'2017-02-02 10:30:00','2017-02-02 12:30:00','2017-02-02 11:30:00'),(22,'2017-03-04',1,'a55',3,'2017-03-04 12:00:00','2017-03-04 14:00:00','2017-03-04 12:30:00'),(23,'2017-01-04',13,'b13',3,'2017-01-04 10:00:00','2017-01-04 14:00:00','2017-01-04 12:30:00'),(24,'2017-06-04',16,'b16',3,'2017-06-04 09:00:00','2017-06-04 14:00:00','2017-06-04 12:30:00'),(28,'2017-04-29',1,'b4',29,'2017-04-29 13:36:00','2017-04-29 17:00:00','2017-04-29 15:00:00'),(29,'2017-12-04',1,'b34',30,'2017-12-04 14:20:00','2017-12-04 15:00:00','2017-12-04 14:30:00'),(30,'2017-04-24',1,'b25',31,'2017-04-24 06:00:00','2017-04-24 10:00:00','2017-04-24 08:00:00'),(31,'2017-04-14',1,'b28',32,'2017-04-14 10:21:00','2017-04-14 13:00:00','2017-04-14 11:00:00'),(32,'2017-04-25',1,'c54',36,'2017-04-25 08:38:00','2017-04-25 18:00:00','2017-04-25 11:00:00');
/*!40000 ALTER TABLE `visite` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`admin`@`%`*/ /*!50003 TRIGGER `increment_utilisateur_version_insert_visite` AFTER INSERT ON `visite`
 FOR EACH ROW update utilisateur 
set version = version + 1 
where id = new.idutilisateur */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`admin`@`%`*/ /*!50003 TRIGGER `increment_utilisateur_version_visite` AFTER UPDATE ON `visite`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`admin`@`%`*/ /*!50003 TRIGGER `increment_utilisateur_version_delete_visite` AFTER DELETE ON `visite`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-09 11:03:49
