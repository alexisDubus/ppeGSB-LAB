CREATE TRIGGER `increment_utilisateur_version_medecin` AFTER UPDATE ON `medecin`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur;

CREATE TRIGGER `increment_utilisateur_version_visite` AFTER UPDATE ON `visite`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur;

CREATE TRIGGER `increment_utilisateur_version_insert_visite` AFTER INSERT ON `visite`
 FOR EACH ROW update utilisateur 
set version = version + 1 
where id = new.idutilisateur;

CREATE TRIGGER `increment_utilisateur_version_delete_visite` AFTER DELETE ON `visite`
 FOR EACH ROW update utilisateur 
set version = version + 1
where id = old.idutilisateur;

CREATE TRIGGER `increment_utilisateur_version_delete_medecin` AFTER DELETE ON `medecin`
 FOR EACH ROW update utilisateur 
set version = version + 1 
where id = old.idutilisateur

CREATE TRIGGER `increment_utilisateur_version_insert_medecin` AFTER INSERT ON `medecin`
 FOR EACH ROW update utilisateur 
set version = version + 1 
where id = new.idutilisateur;
