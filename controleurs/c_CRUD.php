<?php


include("vues/v_sommaire.php");

$idUtilisateur = $_SESSION['idUtilisateur'];
$mois = getMois(date("d/m/Y"));
$numAnnee =substr( $mois,0,4);
$numMois =substr( $mois,4,2);

// On récupère l'action read au début.
$action = $_REQUEST['action'];



/* Traitement des différentes actions */
switch($action)
{
  case 'read':
  {
    $lesfraisforfaits =$pdo->getFraisForfaitOnly();
    include("vues/v_voirfraisforfait.php");
    break;
  }

  case 'create':
  {
      $id      = $_REQUEST['id'];
      $libelle = $_REQUEST['libelle'];
      $montant = $_REQUEST['montant'];
      valideInfosFraisForfait($id,$libelle,$montant);
      if (nbErreurs() != 0 )
      {
            include("vues/v_erreurs.php");
      }
      else 
      {
          $pdo -> creerNouveauTypeFraisForfait($id,$libelle,$montant);
      }              
    break;
  }

  
  case 'update':
  {
    break;
  }
    

  
  case 'delete':
  {
      $id = isset($_POST['id']) ? $_POST['id'] : $_GET['id'];
      // On s'assure que le forfait existe
      if($fraisforfait = Doctrine_Core::getTable('fraisforfait')->find($id))
      {
          $fraisforfait->delete();
      }
    break;
  }
  			
}


