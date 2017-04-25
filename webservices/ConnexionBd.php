<?php

try{
	$bd=new PDO('mysql:host=172.16.223.129;dbname=gsb_frais;port=8889','administrateur','');
}
catch(Exception $e){
	die('Erreur : '.$e->getMessage());
}

?>