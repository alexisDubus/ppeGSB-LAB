<?php
 
include'ConnexionBd.php';

$id = $_REQUEST['id'];

 
$sql = "SELECT * FROM medecin WHERE idutilisateur = '" . $id . "'";


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