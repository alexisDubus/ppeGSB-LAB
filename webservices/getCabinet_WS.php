<?php
 
include'ConnexionBd.php';


$sql = "SELECT * FROM cabinet";

//echo $sql;
$result = $bd->query($sql);
 
$resultArray = array();
$tempArray = array();
while($row = $result->fetch(PDO::FETCH_ASSOC))
{
	$tempArray = $row;
    array_push($resultArray, $tempArray);
}

//$resultArray = $result->fetchAll();

echo json_encode($resultArray);


?>