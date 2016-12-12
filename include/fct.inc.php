<?php
 /**
 * Teste si un quelconque utilisateur est connecté
 * @return boolean
 */
function estConnecte(){
  return isset($_SESSION['idUtilisateur']);
}
/**
 * Enregistre dans une variable session les infos d'un utilisateur
 
 * @param $id 
 * @param $nom
 * @param $prenom
 */
function connecter($id,$nom,$prenom){
	$_SESSION['idUtilisateur']= $id; 
	$_SESSION['nom']= $nom;
	$_SESSION['prenom']= $prenom;

}
/**
 * Détruit la session active
 */
function deconnecter(){
	session_destroy();
}
/**
 * Transforme une date au format français jj/mm/aaaa vers le format anglais aaaa-mm-jj
 
 * @param $madate au format  jj/mm/aaaa
 * @return la date au format anglais aaaa-mm-jj
*/
function dateFrancaisVersAnglais($maDate){
	@list($jour,$mois,$annee) = explode('/',$maDate);
	return date('Y-m-d',mktime(0,0,0,$mois,$jour,$annee));
}
/**
 * Transforme une date au format format anglais aaaa-mm-jj vers le format français jj/mm/aaaa 
 * @param $madate au format  aaaa-mm-jj
 * @return la date au format format français jj/mm/aaaa
*/
function dateAnglaisVersFrancais($maDate){
   @list($annee,$mois,$jour)=explode('-',$maDate);
   $date="$jour"."/".$mois."/".$annee;
   return $date;
}
/**
 * retourne le mois au format aaaamm selon le jour dans le mois
 
 * @param $date au format  jj/mm/aaaa
 * @return le mois au format aaaamm
*/
function getMois($date){
		@list($jour,$mois,$annee) = explode('/',$date);
		if(strlen($mois) == 1){
			$mois = "0".$mois;
		}
		return $annee.$mois;
}

/* gestion des erreurs ============*/

/**
 * Indique si une valeur est un entier positif ou nul
 
 * @param $valeur
 * @return vrai ou faux
*/
function estEntierPositif($valeur) {
	return preg_match("/[^0-9]/", $valeur) == 0;
	
}

/**
 * Indique si un tableau de valeurs est constitué d'entiers positifs ou nuls
 
 * @param $tabEntiers : le tableau
 * @return vrai ou faux
*/
function estTableauEntiers($tabEntiers) {
	$ok = true;
	if (isset($unEntier) ){
		foreach($tabEntiers as $unEntier){
			if(!estEntierPositif($unEntier)){
		 		$ok=false; 
			}
		}	
	}
	return $ok;
}
/**
 * Vérifie si une date est inférieure d'un an à la date actuelle
 
 * @param $dateTestee 
 * @return vrai ou faux
*/
function estDateDepassee($dateTestee){
	$dateActuelle=date("d/m/Y");
	@list($jour,$mois,$annee) = explode('/',$dateActuelle);
	$annee--;
	$AnPasse = $annee.$mois.$jour;
	@list($jourTeste,$moisTeste,$anneeTeste) = explode('/',$dateTestee);
	return ($anneeTeste.$moisTeste.$jourTeste < $AnPasse); 
}
/**
 * Vérifie la validité du format d'une date française jj/mm/aaaa 
 
 * @param $date 
 * @return vrai ou faux
*/
function estDateValide($date){
	$tabDate = explode('/',$date);
	$dateOK = true;
	if (count($tabDate) != 3) {
	    $dateOK = false;
    }
    else {
		if (!estTableauEntiers($tabDate)) {
			$dateOK = false;
		}
		else {
			if (!checkdate($tabDate[1], $tabDate[0], $tabDate[2])) {
				$dateOK = false;
			}
		}
    }
	return $dateOK;
}

/**
 * Vérifie que le tableau de frais ne contient que des valeurs numériques 
 
 * @param $lesFrais 
 * @return vrai ou faux
*/
function lesQteFraisValides($lesFrais){
	return estTableauEntiers($lesFrais);
}
/**
 * Vérifie la validité des trois arguments : la date, le libellé du frais et le montant 
 
 * des message d'erreurs sont ajoutés au tableau des erreurs
 
 * @param $dateFrais 
 * @param $libelle 
 * @param $montant
 */
function valideInfosFrais($dateFrais,$libelle,$montant){
	if($dateFrais==""){
		ajouterErreur("Le champ date ne doit pas être vide");
	}
	else{
		if(!estDatevalide($dateFrais)){
			ajouterErreur("Date invalide");
		}	
		else{
			if(estDateDepassee($dateFrais)){
				ajouterErreur("date d'enregistrement du frais dépassé, plus de 1 an");
			}			
		}
	}
	if($libelle == ""){
		ajouterErreur("Le champ description ne peut pas être vide");
	}
	if($montant == ""){
		ajouterErreur("Le champ montant ne peut pas être vide");
	}
	else
		if( !is_numeric($montant) ){
			ajouterErreur("Le champ montant doit être numérique");
		}
}


/**
 * Vérifie la validité des trois arguments : l'id, le libellé du fraisforfait et le montant 
 
 * des message d'erreurs sont ajoutés au tableau des erreurs
 *--------- A mettre das fct.php
 
 * @param $id 
 * @param $libelle 
 * @param $montant
 */
function valideInfosFraisForfait($id,$libelle,$montant)
{
	if($id=="")
	{
		ajouterErreur("Le champ identifiant ne doit pas être vide");
	}
	if($libelle == "")
	{
		ajouterErreur("Le champ description ne peut pas être vide");
	}
	if($montant == "")
	{
		ajouterErreur("Le champ montant ne peut pas être vide");
	}
		else
		if( !is_numeric($montant) )
		{
			ajouterErreur("Le champ montant doit être numérique");
		}
}



/**
 * Ajoute le libellé d'une erreur au tableau des erreurs 
 
 * @param $msg : le libellé de l'erreur 
 */
function ajouterErreur($msg){
   if (! isset($_REQUEST['erreurs'])){
      $_REQUEST['erreurs']=array();
	} 
   $_REQUEST['erreurs'][]=$msg;
}
/**
 * Retoune le nombre de lignes du tableau des erreurs 
 
 * @return le nombre d'erreurs
 */
function nbErreurs(){
   if (!isset($_REQUEST['erreurs'])){
	   return 0;
	}
	else{
	   return count($_REQUEST['erreurs']);
	}
}

/**
 * 
 * @param type $type
 * @param type $lesFraisForfaits
 * @return int
 */
function donneQuantiteTypeFrais($type, $lesFraisForfaits) {
    $quantiteFrais = 0;
    foreach ($lesFraisForfaits as $leFraisForfait) {
        if ($leFraisForfait['libelle'] == $type) {
            $quantiteFrais += (int)$leFraisForfait['quantite'];
        }
    }
    return $quantiteFrais;
}

/**
 * 
 * @param type $type
 * @return string
 */
function donneIdFrais($type) {
    $idFrais = "";
    switch ($type) {
        case ("Forfait Etape") : 
            $idFrais = "ETP";
            break;
        case ("Frais Kilométrique") :
            $idFrais = "KM";
            break;
        case ("Nuitée Hôtel") :
            $idFrais = "NUI";
            break;
        case ("Repas Restaurant") :
            $idFrais = "REP";
            break;
    }
    return $idFrais;
}

/**
 * 
 * @param type $type
 * @param type $quantite
 * @return type
 */
function donneMontantTotal($type, $quantite) {
    $montantTotal = 0.00;
    switch ($type) {
        case ("Forfait Etape") : 
            $montantTotal = $quantite * 110;
            break;
        case ("Frais Kilométrique") :
            $montantTotal = $quantite * 0.62;
            break;
        case ("Nuitée Hôtel") :
            $montantTotal = $quantite * 80;
            break;
        case ("Repas Restaurant") :
            $montantTotal = $quantite * 25;
            break;
    }
    return $montantTotal;
}

/**
 * 
 * @param type $numMois
 * @return string
 */
function donneNomMois($numMois) {
    $nomMois = "";
    switch ($numMois) {
	case 1:
            $nomMois = "de janvier ";
            break;
	case 2:
            $nomMois = "de février ";
            break;
	case 3:
            $nomMois = "de mars ";
            break;
	case 4:
            $nomMois = "d'avril ";
            break;
	case 5:
            $nomMois = "de mai ";
            break;
	case 6:
            $nomMois = "de juin ";
            break;
	case 7:
            $nomMois = "de juillet ";
            break;
	case 8:
            $nomMois = "d'août ";
            break;
	case 9:
            $nomMois = "de septembre ";
            break;
	case 10:
            $nomMois = "d'octobre ";
            break;
	case 11:
            $nomMois = "de novembre ";
            break;
	case 12:
            $nomMois = "de décembre ";
            break;		
	}
    return $nomMois;
}
?>