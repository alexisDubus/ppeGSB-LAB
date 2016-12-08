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
	case 'validerCreationFrais':{
                $typeFrais = $_REQUEST['typeFrais'];
		$date = $_REQUEST['date'];
		$description = $_REQUEST['description'];
		$quantite = $_REQUEST['quantite'];
                $date = dateAnglaisVersFrancais($date);
		valideInfosFrais($date,$description,$quantite);
                $idFraisForfait = donneIdFrais($typeFrais);
		if (nbErreurs() != 0 ){
			include("vues/v_erreurs.php");
		}
		else{
			$pdo->creeNouveauFraisForfait($idUtilisateur,$mois,$typeFrais,$description,$date,$quantite,$idFraisForfait);
		}
		break;
	}
        case 'supprimerFrais':{
		$typeFrais = $_REQUEST['typeFrais'];
                $pdo->supprimerFraisForfait($idUtilisateur,$mois,$typeFrais);
		break;
	}
}
$lesFraisForfait= $pdo->getLesFraisForfait($idUtilisateur,$mois);
$lesInfosFrais = $pdo->getLesInfosFrais();
$lesInfosFicheFrais = $pdo->getLesInfosFicheFrais($idUtilisateur,$mois);
include("vues/v_listeFraisForfait.php");

?>
