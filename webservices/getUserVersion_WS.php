<?php
 
include'ConnexionBd.php';

$nom= $_REQUEST['nom'];
$prenom= $_REQUEST['prenom'];
 
$sql = "SELECT * FROM utilisateur WHERE nom = '" . $nom . "' AND prenom = '" . $prenom . "' ";


//echo $sql;
$result = $bd->query($sql);
 

$resultArray = array();
$tempArray = array();
 
while($row = $result->fetch(PDO::FETCH_ASSOC))
{
	$tempArray = $row;
    array_push($resultArray, $tempArray);
}
 
echo json_encode($resultArray);
//var_dump($resultArray);

$bd = null;

?>