<?php

include("vues/v_sommaire.php");
$idUtilisateur = $_SESSION['idUtilisateur'];
$mois = getMois(date("d/m/Y"));
$numAnnee =substr( $mois,0,4);
$numMois =substr( $mois,4,2);
$action = $_REQUEST['action'];
switch($action){
	case 'saisirFraisForfaitisés':{
		if($pdo->estPremierFraisMois($idUtilisateur,$mois)){
			$pdo->creeNouvellesLignesFrais($idUtilisateur,$mois);
		}
		break;
	}
	case 'validerMajFraisForfait':{
                
		$lesFrais = $_REQUEST['lesFrais'];
		if(lesQteFraisValides($lesFrais)){
	  	 	$pdo->majFraisForfait($idUtilisateur,$mois,$lesFrais);
		}
		else{
			ajouterErreur("Les valeurs des frais doivent �tre num�riques");
			include("vues/v_erreurs.php");
		}
	  break;
	}
}
$lesFraisForfait= $pdo->getLesFraisForfait($idUtilisateur,$mois);
$lesInfosFicheFrais = $pdo->getLesInfosFicheFrais($idUtilisateur,$mois);
include("vues/v_listeFraisForfait.php");

?>
