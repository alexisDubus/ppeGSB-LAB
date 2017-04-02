<?php

$date = date('Y-m-d-H\hi');

// --- Sauvegarde ------
// Répertoire de destination des backups (chemin absolu !)
define(DIR_DEST, '/homez.xxx/xxxxxx/www/_archives/'); // A mettre une fois sur le FTP
// Paramètres de connexion à la base de données
define(DB_HOST, 'localhost');
define(DB_USER, 'lamp');
define(DB_PWD, 'AzertY!59');
define(DB_NAME, 'gsb_frais');
// Lancement du backup
system("mysqldump --host=".DB_HOST." --user=".DB_USER." --password=".DB_PWD." ".DB_NAME." > ".DIR_DEST.DB_NAME.".".$date.".sql");
system("gzip ".DIR_DEST.DB_NAME.".".$date.".sql");


// --- Suppression des vieux fichiers ---
$dir = "/homez.xxx/xxxxxxxx/www/_archives/"; // chemin absolu exemple:"/homez.xxxx/xxxxx/www/_archives/"
// Pour tous les fichiers du répertoire
foreach (glob($dir."*.gz") as $file) {
// Supprier les fichiers de plus de 30jours ( 2 592 000 secondes)
if (filemtime($file) < time() - 2592000) { 
    unlink($file);
    }
}

?>