<?php
 
include'ConnexionBd.php';

$login= $_REQUEST['login'];
$mdp= $_REQUEST['mdp'];
 
$sql = "SELECT * FROM utilisateur WHERE login = '" . $login . "' AND mdp = '" . $mdp . "' ";


//echo $sql;
$result = $bd->query($sql);
 

$resultArray = array();
$tempArray = array();
 
while($row = $result->fetch(PDO::FETCH_ASSOC))
{
	$tempArray = $row;
	$tempArray = array_map('utf8_encode',$tempArray);
    array_push($resultArray, $tempArray);
}
 
echo json_encode($resultArray);

$bd = null;

?>