#!/bin/bash
cd ./BackupMYSQL/
ls -al
echo "saisir le nom de la base de données à restaurer"
read BDDNAME
echo "saisir le nom complet du fichier SQL à restaurer"
read SQLFILE
echo "Saisir le mot de passe de securité pour se connecter à mysql" 
echo "CREATE DATABASE IF NOT EXISTS $BDDNAME" | mysql -uroot -p
echo "Saisir le mot de passe pour importer le fichier sql"
mysql -uroot -p $BDDNAME < $SQLFILE
