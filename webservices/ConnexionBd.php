<?php

try{
	$bd=new PDO('mysql:host=localhost;dbname=gsb_frais;port=8889','administrateur','');
}
catch(Exception $e){
	die('Erreur : '.$e->getMessage());
}

?>