
<?php

$servername = "localhost";
$username = "lamp";
$password = "AzertY!59";

// Create connection
$conn = new mysqli($servername, $username, $password);

$query = "SELECT nom, , prenom , idCabinet, idUtilisateur FROM medecin "
		. "WHERE idUtilisateur = $_GET["var"]";

print(json_encode($query));	

?>