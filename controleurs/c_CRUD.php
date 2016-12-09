<?php
require(dirname(__FILE__).'/../config/global.php');

require_once("include/fct.inc.php");
require_once ("include/class.pdogsb.inc.php");

// On récupère l'action à effectuer (Create, Read, Update ou Delete).
$action = 'read';
if(isset($_REQUEST['action']) && in_array($_REQUEST['action'],
	array('create', 'read', 'update', 'delete')))
{
  $action = $_REQUEST['action'];
}

/* NTtaitement des différentes actions */
switch($action)
{
	/* Action "Voir" forfait  */
  case 'read':
  	$fraisforfaits = Doctrine_Core::getTable('fraisforfait')->findAll();
    break;

    /* Action "Créer" forfait  */
  case 'create':
    break;

    /* Action "Modifier" forfait  */
  case 'update':
    break;

    /* Action "Supprimer" forfait  */
  case 'delete':
  			$id = isset($_POST['id']) ? $_POST['id'] : $_GET['id'];
 			// On s'assure que le forfait existe
 			if($fraisforfait = Doctrine_Core::getTable('fraisforfait')->find($id))
 			{
  				$fraisforfait->delete();
 			}
    break;
}

/* Nous appellerons ici la page HTML appropriée. */
include(HTML_DIR.$action.'.php');
