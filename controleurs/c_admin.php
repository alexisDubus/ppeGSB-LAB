<?php

/* 
 * Controleur du CRUD
 */

$action = $_REQUEST['action'];
$idUtilisateur = $_SESSION['idUtilisateur'];
/*
$leMois = $_REQUEST['lstMois']; 
$leRole = $_SESSION['role'];

$lesFraisHorsForfait = $pdo->getLesFraisHorsForfait($idUtilisateur,$leMois);
$lesInfosFicheFrais = $pdo->getLesInfosFicheFrais($idUtilisateur,$leMois);

*/



switch ($action)
{
    case 'majFraitForfait':{
        
		}
		break;
    case 'ajouterFraitForfait':{
        
		}
		break;
    case 'editerFraitForfait':{
        
		}
		break;
    case 'supprFraitForfait':{
        
		}
		break;
}