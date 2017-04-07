<?php
 
include'ConnexionBd.php';

$dateVisite= $_REQUEST['datevisite'];
$rdv= $_REQUEST['rdv'];
$idutilisateur= $_REQUEST['idutilisateur'];
$idmedecin= $_REQUEST['idmedecin'];
$heurearrivee= $_REQUEST['heurearrivee'];
$heurefin= $_REQUEST['heurefin'];
$heuredebut= $_REQUEST['heuredebut'];


$sql = "INSERT INTO visite (datevisite, rdv, idutilisateur, idmedecin,heureArrivee, heureDepart, heureDebut) VALUES ('" . $dateVisite . "', '" . $rdv . "', '" . $idutilisateur . "' ,'" . $idmedecin . "' , '" . $heurearrivee . "' , '" . $heurefin . "','" . $heuredebut . "')";


echo $sql;

?>