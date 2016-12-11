<?php

include("vues/v_sommaire.php");

$idUtilisateur = $_SESSION['idUtilisateur'];
$mois = getMois(date("d/m/Y"));
$numAnnee =substr( $mois,0,4);
$numMois =substr( $mois,4,2);

// On récupère l'action read au début.
$action = $_REQUEST['action'];

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
    if (nbErreurs() != 0 ){
      include("vues/v_erreurs.php");
    }
    else{
          $pdo->creerNouveauTypeFraisForfait($id,$libelle,$montant);
        }              
    break;
  }

  
  case 'update':
  {
      $etape = $_REQUEST['etape'];
      switch($etape)
      {
        case 'first' :
        {         
          $id = $_REQUEST['idFrais'];
          $unFraisForfait = $pdo->getOneFraisForfait($id);
          include("vues/v_modifFraisForfait.php");
          break;
        }

        case 'second' :
        {
          $idOld   = $_REQUEST['idFrais'];
          $id      = $_REQUEST['id'];
          //$id      = "ETP";
          $libelle = $_REQUEST['libelle'];
          $montant = $_REQUEST['montant'];
          valideInfosFraisForfait($id,$libelle,$montant);
          if (nbErreurs() != 0 ){
            include("vues/v_erreurs.php");
          }
          else{
              $pdo->updateOneFraisForfait($idOld,$id,$libelle,$montant);
            }          
          break;
        }   
      }
  }

  
  case 'delete':
  {
      $id = $_REQUEST['idFrais'];
      $pdo->supprimerUnFraisForfait($id);
      break;
  }
  			
}


