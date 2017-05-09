#!/bin/bash
 
#date du jour
DATE=`date +%d_%m_%y-%T`
echo "saisissez le nom de la base de donnees à restaurer" 
read SQL

#liste des dossier
echo "saisir le mot de passe pour vous connecter au serveur mysql"
LISTEBDD=$( echo 'show databases' | mysql -uroot -p )
 
#on boucle et on stocke les noms des BDD dans la variable SQL
for SQL in $LISTEBDD
 
do
 
if [ $SQL != "information_schema" ] && [ $SQL != "mysql" ] && [ $SQL != "phpmyadmin" ] && [ $SQL != "performance_schema" ] && [ $SQL != "sys" ] && [ $SQL != "Database" ]; then

echo "Saisir le mot de passe pour exporter la base de données en un fichier sql"  
mysqldump -uroot -p $SQL | gzip > backup/$SQL"_mysql_"$DATE.sql.gz
gzip -d backup/$SQL"_mysql_"$DATE.sql.gz 
fi
 
done
