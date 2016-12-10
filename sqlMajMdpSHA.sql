ALTER TABLE `utilisateur`
ADD `mdpSHA` char(255);
UPDATE `utilisateur` SET `mdpSHA` = sha1(`mdp`);
ALTER TABLE `utilisateur`
DROP COLUMN `mdp`;





