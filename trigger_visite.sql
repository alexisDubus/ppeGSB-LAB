CREATE TRIGGER `increment_utilisateur_version_visite` AFTER UPDATE ON `visite`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur
