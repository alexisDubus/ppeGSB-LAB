<?php

require('../fpdf.php');
include_once '../../include/class.pdogsb.inc.php';
$pdo = PdoGsb::getPdoGsb();
$idUtilisateur = $_GET['idUtilisateur'];

$nom= $_GET['nom'];
$prenom = $_GET['prenom'];

$numAnnee = $_GET['numAnne'];
$an = $_GET['AN'];
$leMois = $_GET['leMois'];
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
$dateModif = dateAnglaisVersFrancais($dateModif);

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
        
        $this->Cell(0,10, utf8_decode('Créé par Galaxy Swiss Bourdin (GSB)'),0,0,'C');
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
$pdf->Cell(0,10,utf8_decode(''),0,1);
$pdf->Cell(0,10,utf8_decode('Identifiant utilisateur : ').$idUtilisateur,0,1);
$pdf->Cell(0,10,utf8_decode(''),0,1);
//$pdf->Write(5,'Pour d�couvrir les nouveaut�s de ce tutoriel, cliquez ');

$pdf->Cell(0,10,utf8_decode('Voici l\'ensemble des éléments forfaitisés (dernière modification le '.$dateModif.' ) : '),0,1);

foreach ($lesLibelleFrais as $unLibelleFrais) {
      $leLibelle = $unLibelleFrais['libelle'];
      $leLibelle = addslashes($leLibelle);
      $quantiteFraisForfait = donneQuantiteTypeFrais($unLibelleFrais['libelle'], $lesFraisForfait);
      $leLibelle = utf8_decode($leLibelle);
      
      $pdf->Cell(0,10,$leLibelle. ' : ' .$quantiteFraisForfait. ' frais ',0,1);
 }

 $header = array('Pays', 'Capitale', 'Superficie (km�)', 'Pop. (milliers)');
// Chargement des donn�es
// 
//$pdf->AddPage();
//$pdf->BasicTable($header, $lesLibelleFrais);
 
$pdf->Output();
?>



/*  ============= Fin De Mise en page ========================   */

﻿<?php

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



?>