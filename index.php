<?php
require_once("include/fct.inc.php");
require_once ("include/class.pdogsb.inc.php");
session_start();
$pdo = PdoGsb::getPdoGsb();
$estConnecte = estConnecte();
if(!isset($_REQUEST['uc']) || !$estConnecte){
   $_REQUEST['uc'] = 'connexion';
}	 
$uc = $_REQUEST['uc'];
switch($uc){
	case 'connexion':{
		include("controleurs/c_connexion.php");break;
	}
	case 'gererFrais' :{
		include("controleurs/c_gererFrais.php");break;
	}
        case 'gererFraisHorsForfaits' :{
		include("controleurs/c_gererFraisHorsForfaits.php");break;
	}
	case 'etatFrais' :{
		include("controleurs/c_etatFrais.php");break; 
	}
	
	
	}
/*if($_SESSION['role'] == 'Administrateur')
{
    include("controleurs/c_admin.php");
     //header('Location: http://www.votresite.com/pageprotegee.php');
    //Redirige vers vues/v_ajouteFrais.php
}*/
	
	


?>
