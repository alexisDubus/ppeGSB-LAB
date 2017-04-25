<?php

try{
	$bd=new PDO('mysql:host=127.0.0.1;dbname=gsb_frais;port=8889','lamp','AzertY!59');
}
catch(Exception $e){
	die('Erreur : '.$e->getMessage());
}

?>