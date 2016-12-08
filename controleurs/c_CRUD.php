<?php

include("vues/v_sommaire.php");


$idUtilisateur = $_SESSION['idUtilisateur'];
$mois = getMois(date("d/m/Y"));
$numAnnee =substr( $mois,0,4);
$numMois =substr( $mois,4,2);

// On récupère l'action à effectuer (Create, Read, Update ou Delete).
$action = 'read';
if(isset($_REQUEST['action']) && in_array($_REQUEST['action'],
	array('create', 'read', 'update', 'delete')))
{
  $action = $_REQUEST['action'];
}

/* NTtaitement des différentes actions */
switch($action)
{
	/* Action "Voir" forfait  */
  case 'read':
  	$fraisforfaits = getFraisForfaitOnly();
        include ("vues/v_fraisforfait.php");
    break;

    /* Action "Créer" forfait  */
  case 'create':
      $id      = $_REQUEST['id'];
      $libelle = $_REQUEST['libelle'];
      $montant = $_REQUEST['montant'];
      valideInfosFraisForfait($id,$libelle,$montant);
      if (nbErreurs() != 0 )
        {
            include("vues/v_erreurs.php");
        }
      else {
          $pdo -> creerNouveauTypeFraisForfait($id,$libelle,$montant);
      }               
    break;

    /* Action "Modifier" forfait  */
  case 'update':
    break;

    /* Action "Supprimer" forfait  */
  case 'delete':
  			$id = isset($_POST['id']) ? $_POST['id'] : $_GET['id'];
 			// On s'assure que le forfait existe
 			if($fraisforfait = Doctrine_Core::getTable('fraisforfait')->find($id))
 			{
  				$fraisforfait->delete();
 			}
    break;
}

/* Nous appellerons ici la page HTML appropriée. */

