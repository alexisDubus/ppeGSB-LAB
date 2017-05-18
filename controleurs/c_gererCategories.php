<?php

include("vues/v_sommaire.php");

// On récupère l'action read au début.
$action = $_REQUEST['action'];

switch($action)
{
  case 'read':
  
    $lesCategories =$pdo->getLesCategories();
    include("vues/v_listeCategories.php");
    break;
