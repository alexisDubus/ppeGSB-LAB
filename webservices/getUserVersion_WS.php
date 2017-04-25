<?php
 
include'ConnexionBd.php';

$id= $_REQUEST['id'];
$sql = "SELECT * FROM utilisateur WHERE id = '" . $id . "'";

$result = $bd->query($sql);
$resultArray = array();
$tempArray = array();
 
while($row = $result->fetch(PDO::FETCH_ASSOC))
{
	$tempArray = $row;
    array_push($resultArray, $tempArray);
}
 
echo json_encode($resultArray);
$bd = null;

?>