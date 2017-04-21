<?php

// session_start();
// require_once("include/fct.inc.php");
// require_once ("include/class.pdogsb.inc.php");
// $pdo = PdoGsb::getPdoGsb();
// $estConnecte = estConnecte();

// if(!isset($_REQUEST['uc']) || !$estConnecte)
// {
//    $_REQUEST['uc'] = 'connexion';
// }	

// $uc = $_REQUEST['uc'];

// $occupe= $pdo->estEnMaj();

// if($occupe == 0)
// {
//     switch($uc)
//     {
//             case 'connexion':
//             {
//                     include("controleurs/c_connexion.php");break;
//             }	
//             case 'gererFrais' :
//             {
//                     include("controleurs/c_gererFrais.php");break;
//             }
//         case 'gererFraisHorsForfaits' :
//         {
//                     include("controleurs/c_gererFraisHorsForfaits.php");break;
//             }
//             case 'etatFrais' :
//             {
//                     include("controleurs/c_etatFrais.php");break; 
//             }
//             case 'menuCRUD' : 
//             {
//                     include("controleurs/c_CRUD.php");break;
//     }

//     }
// }
//  else {
//      echo "<h1>L'application est actuellement indisponible. Merci de revenir d'ici quelques minutes.  </h1>";
// }
echo "test";

?>
