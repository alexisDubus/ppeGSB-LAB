<?php


if(!isset($_REQUEST['action'])){
	$_REQUEST['action'] = 'demandeConnexion';
}
$action = $_REQUEST['action'];
switch($action){
	case 'demandeConnexion':{
		include("vues/v_connexion.php");
		break;
	}
        case 'motDePasseOublie':{
            
            break;
        }
	case 'valideConnexion':{
		$login = $_REQUEST['login'];
		$mdp = $_REQUEST ['mdp'];
		$utilisateur = $pdo->getInfosUtilisateur($login,$mdp);
		if(!is_array( $utilisateur)){
			ajouterErreur("Login ou mot de passe incorrect");
			include("vues/v_erreurs.php");
			include("vues/v_connexion.php");
		}
		else { 
			$id = $utilisateur['id'];
                        //$pdo->getRoleUtilisateur($id); //va initialiser la variable $_SESSION['role']
			$nom =  $utilisateur['nom'];
			$prenom = $utilisateur['prenom'];
			connecter($id,$nom,$prenom);
			include("vues/v_sommaire.php");
			}

			break;	
	}
	default :{
		include("vues/v_connexion.php");
		break;
	}
}
?>
