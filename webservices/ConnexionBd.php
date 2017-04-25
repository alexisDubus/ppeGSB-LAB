<?php

try{
	$bd=new PDO('mysql:host=127.0.0.1;dbname=gsb_frais;port=8889','root','root');
}
catch(Exception $e){
	die('Erreur : '.$e->getMessage());
}

?>