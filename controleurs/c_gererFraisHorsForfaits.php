<?php

include("vues/v_sommaire.php");
$idUtilisateur = $_SESSION['idUtilisateur'];
$mois = getMois(date("d/m/Y"));
$numAnnee =substr( $mois,0,4);
$numMois =substr( $mois,4,2);
$action = $_REQUEST['action'];
$date = date("d/m/Y");
switch($action){
	case 'validerCreationFrais':
	{
		$dateFrais = $_REQUEST['dateFrais'];
		$libelle = $_REQUEST['libelle'];
		$montant = $_REQUEST['montant'];
		valideInfosFrais($dateFrais,$libelle,$montant);
		if (nbErreurs() != 0 ){
			include("vues/v_erreurs.php");
		}
		else{
			$pdo->creeNouveauFraisHorsForfait($idUtilisateur,$mois,$libelle,$dateFrais,$montant);
		}
		break;
	}
	case 'supprimerFrais':{
		$idFrais = $_REQUEST['idFrais'];
	    $pdo->supprimerFraisHorsForfait($idFrais);
		break;
	}
}
$lesFraisHorsForfait = $pdo->getLesFraisHorsForfait($idUtilisateur,  substr($date, 6, 4),  substr($date, 3, 2));
$lesInfosFicheFrais = $pdo->getLesInfosFicheFrais($idUtilisateur,$mois);
include("vues/v_listeFraisHorsForfait.php");

?>
