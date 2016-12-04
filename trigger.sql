-- phpMyAdmin SQL Dump
-- version 4.4.10
-- http://www.phpmyadmin.net
--
-- Client :  localhost:8889
-- Généré le :  Dim 04 Décembre 2016 à 14:57
-- Version du serveur :  5.5.42
-- Version de PHP :  5.6.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Base de données :  `gsb_frais`
--

-- 
------------------------------------- Creation des TRIGGER ----------------------------------
--
-- Trigger ce declanchant a chaque ajout d'une lignefraisfortait
--
DELIMITER 	|
CREATE TRIGGER after_insert_lignefraisforfait AFTER INSERT
ON lignefraisforfait FOR EACH ROW
BEGIN
	UPDATE fichefrais	
	SET montantValide = montantValide + ( 	SELECT lignefraisforfait.quantite*fraisforfait.montant
											FROM lignefraisforfait , fraisforfait
											WHERE lignefraisforfait.idFraisForfait = fraisforfait.id) 
	WHERE 	fichefrais.idutilisateur = lignefraisforfait.idutilisateur AND
			fichefrais.mois = lignefraisforfait.mois;
END 		|






--
-- Trigger ce declanchant a chaque modifiaction d'une fichefraisforfait
--
DELIMITER 	|
CREATE TRIGGER after_update_lignefraisforfait AFTER UPDATE
ON lignefraisforfait FOR EACH ROW
BEGIN
	UPDATE fichefrais	
	SET montantValide =  montantValide + ( 	SELECT (NEW.lignefraisforfait.quantite - OLD.lignefraisforfait.quantite)*fraisforfait.montantValide
											FROM lignefraisforfait , fraisforfait
											WHERE lignefraisforfait.idFraisForfait = fraisforfait.id)
	WHERE 	fichefrais.idutilisateur = lignefraisforfait.idutilisateur AND
			fichefrais.mois = lignefraisforfait.mois;
END 		|





