<?php
//session_start();
//require ('../../include/fct.inc.php');
require('../fpdf.php');
//include_once '../../include/fct.inc.php';

include_once '../../include/class.pdogsb.inc.php';
$pdo = PdoGsb::getPdoGsb();
//echo '<a href="vues/html2pdf/examples/devTest.php?idUtilisateur='.$id.'&nom='.$nom.'&prenom='.$prenom.'&nomMois='.$nomMois.'numAnne'.$numAnnee.'">Télécharger le pdf</a>'; 

$idUtilisateur = $_GET['idUtilisateur'];
//$idUtilisateur2 = $_SESSION['idUtilisateur'];
$nom= $_GET['nom'];
$prenom = $_GET['prenom'];
//$nomMois = $_GET['nomMois'];
$numAnnee = $_GET['numAnne'];
$an = $_GET['AN'];
$leMois = $_GET['leMois'];
$dateModif = $_GET['dateModif'];
if($leMois == NULL)
{
     $leMois = 0; //en cas d'erreur
}
$lesMois=$pdo->getLesMoisDisponibles($idUtilisateur);
$moisASelectionner = $leMois;
$lesFraisHorsForfait = $pdo->getLesFraisHorsForfait($idUtilisateur,$leMois);
$lesFraisForfait= $pdo->getLesFraisForfait($idUtilisateur,$leMois);
$lesLibelleFrais = $pdo->getLibelleFraisForfait();
$lesInfosFicheFrais = $pdo->getLesInfosFicheFrais($idUtilisateur,$leMois);
$libEtat = $lesInfosFicheFrais['libEtat'];
$montantValide = $lesInfosFicheFrais['montantValide'];
$nbJustificatifs = $lesInfosFicheFrais['nbJustificatifs'];
$dateModif =  $lesInfosFicheFrais['dateModif'];


class PDF extends FPDF
{
    
    // Tableau simple
function BasicTable($header, $lesLibelleFrais)
{
	// En-t�te
	foreach($header as $col)
		$this->Cell(40,7,$col,1);
	$this->Ln();
	// Donn�es
        
        
        foreach ($lesLibelleFrais as $unLibelleFrais) {
            $leLibelle = $unLibelleFrais['libelle'];
            $leLibelle = addslashes($leLibelle);
            $quantiteFraisForfait = donneQuantiteTypeFrais($unLibelleFrais['libelle'], $lesFraisForfait);
            $leLibelle = utf8_decode($leLibelle);
            
            foreach($lesFraisHorsForfait as $col)
			$this->Cell(40,6,$col,1);
		$this->Ln;
       }

}

// En-t�te
function Header()
{
	// Logo
	//$this->Image('logo.png',10,6,30);
	// Police Arial gras 15
	$this->SetFont('Arial','B',15);
	// D�calage � droite
	$this->Cell(80);
	// Titre
	$this->Cell(50,10,'Fiche de frais GSB',1,0,'C');
	// Saut de ligne
	$this->Ln(20);
}

// Pied de page
function Footer()
{
	// Positionnement � 1,5 cm du bas
	$this->SetY(-15);
	// Police Arial italique 8
	$this->SetFont('Arial','I',8);
        
        $this->Cell(0,10,'Edité par Galaxy Swiss Bourdin (GSB)',0,0,'C');
	// Num�ro de page
	$this->Cell(0,10,'Page '.$this->PageNo().'/{nb}',0,0,'C');
}
}


// Instanciation de la classe d�riv�e
$pdf = new PDF();
$pdf->AliasNbPages();
$pdf->AddPage();
$pdf->SetFont('Arial','',12);
$pdf->Cell(0,10,utf8_decode('Fiche de frais de '.$nom.' '.$prenom. ' pour le mois ').$an,0,1);
$pdf->Cell(0,10,utf8_decode('Identifiant utilisateur: ').$idUtilisateur,0,1);
//$pdf->Write(5,'Pour d�couvrir les nouveaut�s de ce tutoriel, cliquez ');

$pdf->Cell(0,10,utf8_decode('Voici l\'ensemble des éléments forfaitisés '),0,1);
foreach ($lesLibelleFrais as $unLibelleFrais) {
      $leLibelle = $unLibelleFrais['libelle'];
      $leLibelle = addslashes($leLibelle);
      $quantiteFraisForfait = donneQuantiteTypeFrais($unLibelleFrais['libelle'], $lesFraisForfait);
      $leLibelle = utf8_decode($leLibelle);
      
      $pdf->Cell(0,10,$leLibelle. ' : ' .$quantiteFraisForfait. ' euros ',0,1);
 }

 $header = array('Pays', 'Capitale', 'Superficie (km�)', 'Pop. (milliers)');
// Chargement des donn�es
// 
//$pdf->AddPage();
//$pdf->BasicTable($header, $lesLibelleFrais);
 
$pdf->Output();
?>



/*  ============= Mise en page ========================   */

﻿<?php
 /**
 * Teste si un quelconque utilisateur est connecté
 * @return boolean
 */
function estConnecte(){
  return isset($_SESSION['idUtilisateur']);
}
/**
 * Enregistre dans une variable session les infos d'un utilisateur
 
 * @param $id 
 * @param $nom
 * @param $prenom
 */
function connecter($id,$nom,$prenom){
	$_SESSION['idUtilisateur']= $id; 
	$_SESSION['nom']= $nom;
	$_SESSION['prenom']= $prenom;

}
/**
 * Détruit la session active
 */
function deconnecter(){
	session_destroy();
}
/**
 * Transforme une date au format français jj/mm/aaaa vers le format anglais aaaa-mm-jj
 
 * @param $madate au format  jj/mm/aaaa
 * @return la date au format anglais aaaa-mm-jj
*/
function dateFrancaisVersAnglais($maDate){
	@list($jour,$mois,$annee) = explode('/',$maDate);
	return date('Y-m-d',mktime(0,0,0,$mois,$jour,$annee));
}
/**
 * Transforme une date au format format anglais aaaa-mm-jj vers le format français jj/mm/aaaa 
 * @param $madate au format  aaaa-mm-jj
 * @return la date au format format français jj/mm/aaaa
*/
function dateAnglaisVersFrancais($maDate){
   @list($annee,$mois,$jour)=explode('-',$maDate);
   $date="$jour"."/".$mois."/".$annee;
   return $date;
}
/**
 * retourne le mois au format aaaamm selon le jour dans le mois
 
 * @param $date au format  jj/mm/aaaa
 * @return le mois au format aaaamm
*/
function getMois($date){
		@list($jour,$mois,$annee) = explode('/',$date);
		if(strlen($mois) == 1){
			$mois = "0".$mois;
		}
		return $annee.$mois;
}

/* gestion des erreurs ============*/

/**
 * Indique si une valeur est un entier positif ou nul
 
 * @param $valeur
 * @return vrai ou faux
*/
function estEntierPositif($valeur) {
	return preg_match("/[^0-9]/", $valeur) == 0;
	
}

/**
 * Indique si un tableau de valeurs est constitué d'entiers positifs ou nuls
 
 * @param $tabEntiers : le tableau
 * @return vrai ou faux
*/
function estTableauEntiers($tabEntiers) {
	$ok = true;
	if (isset($unEntier) ){
		foreach($tabEntiers as $unEntier){
			if(!estEntierPositif($unEntier)){
		 		$ok=false; 
			}
		}	
	}
	return $ok;
}
/**
 * Vérifie si une date est inférieure d'un an à la date actuelle
 
 * @param $dateTestee 
 * @return vrai ou faux
*/
function estDateDepassee($dateTestee){
	$dateActuelle=date("d/m/Y");
	@list($jour,$mois,$annee) = explode('/',$dateActuelle);
	$annee--;
	$AnPasse = $annee.$mois.$jour;
	@list($jourTeste,$moisTeste,$anneeTeste) = explode('/',$dateTestee);
	return ($anneeTeste.$moisTeste.$jourTeste < $AnPasse); 
}
/**
 * Vérifie la validité du format d'une date française jj/mm/aaaa 
 
 * @param $date 
 * @return vrai ou faux
*/
function estDateValide($date){
	$tabDate = explode('/',$date);
	$dateOK = true;
	if (count($tabDate) != 3) {
	    $dateOK = false;
    }
    else {
		if (!estTableauEntiers($tabDate)) {
			$dateOK = false;
		}
		else {
			if (!checkdate($tabDate[1], $tabDate[0], $tabDate[2])) {
				$dateOK = false;
			}
		}
    }
	return $dateOK;
}

/**
 * Vérifie que le tableau de frais ne contient que des valeurs numériques 
 
 * @param $lesFrais 
 * @return vrai ou faux
*/
function lesQteFraisValides($lesFrais){
	return estTableauEntiers($lesFrais);
}
/**
 * Vérifie la validité des trois arguments : la date, le libellé du frais et le montant 
 
 * des message d'erreurs sont ajoutés au tableau des erreurs
 
 * @param $dateFrais 
 * @param $libelle 
 * @param $montant
 */
function valideInfosFrais($dateFrais,$libelle,$montant){
	if($dateFrais==""){
		ajouterErreur("Le champ date ne doit pas être vide");
	}
	else{
		if(!estDatevalide($dateFrais)){
			ajouterErreur("Date invalide");
		}	
		else{
			if(estDateDepassee($dateFrais)){
				ajouterErreur("date d'enregistrement du frais dépassé, plus de 1 an");
			}			
		}
	}
	if($libelle == ""){
		ajouterErreur("Le champ description ne peut pas être vide");
	}
	if($montant == ""){
		ajouterErreur("Le champ montant ne peut pas être vide");
	}
	else
		if( !is_numeric($montant) ){
			ajouterErreur("Le champ montant doit être numérique");
		}
}


/**
 * Vérifie la validité des trois arguments : l'id, le libellé du fraisforfait et le montant 
 
 * des message d'erreurs sont ajoutés au tableau des erreurs
 *--------- A mettre das fct.php
 
 * @param $id 
 * @param $libelle 
 * @param $montant
 */
function valideInfosFraisForfait($id,$libelle,$montant)
{
	if($id=="")
	{
		ajouterErreur("Le champ identifiant ne doit pas être vide");
	}
	if($libelle == "")
	{
		ajouterErreur("Le champ description ne peut pas être vide");
	}
	if($montant == "")
	{
		ajouterErreur("Le champ montant ne peut pas être vide");
	}
		else
		if( !is_numeric($montant) )
		{
			ajouterErreur("Le champ montant doit être numérique");
		}
}



/**
 * Ajoute le libellé d'une erreur au tableau des erreurs 
 
 * @param $msg : le libellé de l'erreur 
 */
function ajouterErreur($msg){
   if (! isset($_REQUEST['erreurs'])){
      $_REQUEST['erreurs']=array();
	} 
   $_REQUEST['erreurs'][]=$msg;
}
/**
 * Retoune le nombre de lignes du tableau des erreurs 
 
 * @return le nombre d'erreurs
 */
function nbErreurs(){
   if (!isset($_REQUEST['erreurs'])){
	   return 0;
	}
	else{
	   return count($_REQUEST['erreurs']);
	}
}

/**
 * 
 * @param type $type
 * @param type $lesFraisForfaits
 * @return int
 */
function donneQuantiteTypeFrais($type, $lesFraisForfaits) {
    $quantiteFrais = 0;
    foreach ($lesFraisForfaits as $leFraisForfait) {
        if ($leFraisForfait['libelle'] == $type) {
            $quantiteFrais += (int)$leFraisForfait['quantite'];
        }
    }
    return $quantiteFrais;
}


/**
 * 
 * @param type $numMois
 * @return string
 */
function donneNomMois($numMois) {
    $nomMois = "";
    switch ($numMois) {
	case 1:
            $nomMois = "de janvier ";
            break;
	case 2:
            $nomMois = "de février ";
            break;
	case 3:
            $nomMois = "de mars ";
            break;
	case 4:
            $nomMois = "d'avril ";
            break;
	case 5:
            $nomMois = "de mai ";
            break;
	case 6:
            $nomMois = "de juin ";
            break;
	case 7:
            $nomMois = "de juillet ";
            break;
	case 8:
            $nomMois = "d'août ";
            break;
	case 9:
            $nomMois = "de septembre ";
            break;
	case 10:
            $nomMois = "d'octobre ";
            break;
	case 11:
            $nomMois = "de novembre ";
            break;
	case 12:
            $nomMois = "de décembre ";
            break;		
	}
    return $nomMois;
}

function envoyerMail($adresse, $newMDP) {
    $subject = "Nouveau mot de passe";
    $message = "Bonjour madame/monsieur, votre nouveau mot de passe est : '$newMDP[0]]'";
    mail($adresse[0], $subject, $message);
}
?>