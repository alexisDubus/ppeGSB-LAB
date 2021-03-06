<?php

include("vues/v_sommaire.php");
$idUtilisateur = $_SESSION['idUtilisateur'];
$mois = getMois(date("d/m/Y"));
$numAnnee =substr( $mois,0,4);
$numMois =substr( $mois,4,2);
$nomMois = donneNomMois($numMois);
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
                var_dump($date);
                if (substr($date, 5, 2) != date('m')) {
                    ajouterErreur("Date invalide.");
                    include("vues/v_erreurs.php");
                    break;
                }
		$description = $_REQUEST['description'];
		$quantite = $_REQUEST['quantite'];
                $date = dateAnglaisVersFrancais($date);
		valideInfosFrais($date,$description,$quantite);
                $idFraisForfait = $pdo->getIdFraisForfait($typeFrais);
		if (nbErreurs() != 0 ){
                    include("vues/v_erreurs.php");
		}
		else{
                    //$date2 = dateFrancaisVersAnglais($date2);
                    $mois = getMois($date);
                    $pdo->creeNouveauFraisForfait($idUtilisateur,$mois,$typeFrais,$description,$date,$quantite,$idFraisForfait[0]);
		}
		break;
	}
        case 'supprimerFrais':{
            $id = $_REQUEST['id'];
            $pdo->supprimerFraisForfait($id);
            break;
	}
}
$lesFraisForfait= $pdo->getLesFraisForfait($idUtilisateur,$mois);
$lesInfosFrais = $pdo->getLesInfosFrais($idUtilisateur,$mois);
$lesInfosFicheFrais = $pdo->getLesInfosFicheFrais($idUtilisateur,$mois);
$lesLibelleFrais = $pdo->getLibelleFraisForfait();
$nombreFrais = $pdo->getNombreFraisForfait();
include("vues/v_listeFraisForfait.php");

?>
