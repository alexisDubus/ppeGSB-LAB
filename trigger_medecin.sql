CREATE TRIGGER `increment_utilisateur_version_medecin` AFTER UPDATE ON `medecin`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur
