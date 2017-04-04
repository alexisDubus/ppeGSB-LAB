<?php

/**
 * Fichier de mise à jour des données
 */

/**
 * Retourne tout les visiteurs
 * 
 * @param type $pdo
 * @return type
 */
function getLesVisiteurs($pdo)
{
		$req = "select * from visiteur";
		$res = $pdo->query($req);
		$lesLignes = $res->fetchAll();
		return $lesLignes;
}
/**
 * Retourne toutes les fiches de frais
 * 
 * @param type $pdo
 * @return type
 */
function getLesFichesFrais($pdo)
{
		$req = "select * from ficheFrais";
		$res = $pdo->query($req);
		$lesLignes = $res->fetchAll();
		return $lesLignes;
}
/**
 * Retourne les Id de frais forfait, ordonné par ordre alphabétique
 * 
 * @param type $pdo
 * @return type
 */
function getLesIdFraisForfait($pdo)
{
		$req = "select fraisforfait.id as id from fraisforfait order by fraisforfait.id";
		$res = $pdo->query($req);
		$lesLignes = $res->fetchAll();
		return $lesLignes;
}
/**
 * Retourne le dernier mois du visiteur donné en paramétre
 * 
 * @param type $pdo
 * @param type $idVisiteur
 * @return type dateTime
 */
function getDernierMois($pdo, $idVisiteur)
{
		$req = "select max(mois) as dernierMois from fichefrais where idVisiteur = '$idVisiteur'";
		$res = $pdo->query($req);
		$laLigne = $res->fetch();
		return $laLigne['dernierMois'];

}
/**
 * Retourne l'année actuelle et le mois suivant le tout concaténée en un seul bloc
 * 
 * @param type $mois
 * @return type
 */
function getMoisSuivant($mois){
		$numAnnee =substr( $mois,0,4);
		$numMois =substr( $mois,4,2);
		if($numMois=="12"){
			$numMois = "01"; 
			$numAnnee++;
		}
		else{
			$numMois++;

		}
		if(strlen($numMois)==1)
			$numMois="0".$numMois;
		return $numAnnee.$numMois;
}
/**
 * Retourne l'année actuelle et le mois précédent le tout concaténée en un seul bloc
 * 
 * @param type $mois
 * @return type
 */
function getMoisPrecedent($mois){
		$numAnnee =substr( $mois,0,4);
		$numMois =substr( $mois,4,2);
		if($numMois=="01"){
			$numMois = "12"; 
			$numAnnee--;
		}
		else{
			$numMois--;
		}
		if(strlen($numMois)==1)
			$numMois="0".$numMois;
		return $numAnnee.$numMois;
}
/**
 * Créé des fiches de frais sur les utilisateurs ayant déja des fiches de frais
 * le mois, le nombre de Justificatifs, le montant validé, la date de modification et l'id etat sont créé de facon aléatoire 
 * 
 * @param type $pdo
 */
function creationFichesFrais($pdo)
{
	$lesVisiteurs = getLesVisiteurs($pdo);
	$moisActuel = getMois(date("d/m/Y"));
	$moisDebut = "201001";
	$moisFin = getMoisPrecedent($moisActuel);
	foreach($lesVisiteurs as $unVisiteur)
	{
		$moisCourant = $moisFin;
		$idVisiteur = $unVisiteur['id'];
		$n = 1;
		while($moisCourant >= $moisDebut)
		{
			if($n == 1)
			{
				$etat = "CR";
				$moisModif = $moisCourant;
			}
			else
			{
				if($n == 2)
				{
					$etat = "VA";
					$moisModif = getMoisSuivant($moisCourant);
				}
				else
				{
					$etat = "RB";
					$moisModif = getMoisSuivant(getMoisSuivant($moisCourant));
				}
			}
			$numAnnee =substr( $moisModif,0,4);
			$numMois =substr( $moisModif,4,2);
			$dateModif = $numAnnee."-".$numMois."-".rand(1,8);
			$nbJustificatifs = rand(0,12);
			$req = "insert into fichefrais(idvisiteur,mois,nbJustificatifs,montantValide,dateModif,idEtat) 
			values ('$idVisiteur','$moisCourant',$nbJustificatifs,0,'$dateModif','$etat');";
			$pdo->exec($req);
			$moisCourant = getMoisPrecedent($moisCourant);
			$n++;
		}
	}
}
/**
 * Créé des lignes de frais forfait 
 * Le mois, l'id de frais forfait et la quantité sont générés aléatoirement 
 * 
 * @param type $pdo
 */
function creationFraisForfait($pdo)
{
	$lesFichesFrais= getLesFichesFrais($pdo);
	$lesIdFraisForfait = getLesIdFraisForfait($pdo);
	foreach($lesFichesFrais as $uneFicheFrais)
	{
		$idVisiteur = $uneFicheFrais['idVisiteur'];
		$mois =  $uneFicheFrais['mois'];
		foreach($lesIdFraisForfait as $unIdFraisForfait)
		{
			$idFraisForfait = $unIdFraisForfait['id'];
			if(substr($idFraisForfait,0,1)=="K")
			{
				$quantite =rand(300,1000);
			}
			else
			{
				$quantite =rand(2,20);
			}
			$req = "insert into lignefraisforfait(idvisiteur,mois,idfraisforfait,quantite)
			values('$idVisiteur','$mois','$idFraisForfait',$quantite);";
			$pdo->exec($req);	
		}
	}

}
/**
 * Retourne un tableau avec des données utilisé par les autres fonction pour 
 * créer des fiches de frais
 * 
 * @return array
 */
function getDesFraisHorsForfait()
{
	$tab = array(
				1 => array(
				      "lib" => "repas avec praticien",
					  "min" => 30,
					  "max" => 50 ),
				2 => array(
				      "lib" => "achat de matÃ©riel de papÃ¨terie",
					  "min" => 10,
					  "max" => 50 ),
				3	=> array(
				      "lib" => "taxi",
					  "min" => 20,
					  "max" => 80 ),
				4 => array(
				      "lib" => "achat d'espace publicitaire",
					  "min" => 20,
					  "max" => 150 ),
				5 => array(
				      "lib" => "location salle confÃ©rence",
					  "min" => 120,
					  "max" => 650 ),
				6 => array(
				      "lib" => "Voyage SNCF",
					  "min" => 30,
					  "max" => 150 ),
				7 => array(
					  "lib" => "traiteur, alimentation, boisson",
					  "min" => 25,
					  "max" => 450 ),
				8 => array(
					  "lib" => "rÃ©munÃ©ration intervenant/spÃ©cialiste",
					  "min" => 250,
					  "max" => 1200 ),
				9 => array(
					  "lib" => "location Ã©quipement vidÃ©o/sonore",
					  "min" => 100,
					  "max" => 850 ),
				10 => array(
					  "lib" => "location vÃ©hicule",
					  "min" => 25,
					  "max" => 450 ),
				11 => array(
					  "lib" => "frais vestimentaire/reprÃ©sentation",
					  "min" => 25,
					  "max" => 450 ) 
		);
	return $tab;
}
/**
 * Permet de modifier le mot de passe d'un utilisateur
 * Le nouveau mot de passe est créer automatiqument. 
 * 
 * @param type $pdo
 */
function updateMdpVisiteur($pdo)
{
	$req = "select * from visiteur";
		$res = $pdo->query($req);
		$lesLignes = $res->fetchAll();
		$lettres ="azertyuiopqsdfghjkmwxcvbn123456789";
		foreach($lesLignes as $unVisiteur)
		{
			$mdp = "";
			$id = $unVisiteur['id'];
			for($i =1;$i<=5;$i++)
			{
				$uneLettrehasard = substr( $lettres,rand(33,1),1);
				$mdp = $mdp.$uneLettrehasard;
			}
			
			$req = "update visiteur set mdp ='$mdp' where visiteur.id ='$id' ";
			$pdo->exec($req);
		}


}
/**
 * Créé des lignes de frais hors forfait 
 * Le mois, le libelle, la date et le montant sot générés aléatoirement
 * 
 * @param type $pdo
 */
function creationFraisHorsForfait($pdo)
{
	$desFrais = getDesFraisHorsForfait();
	$lesFichesFrais= getLesFichesFrais($pdo);
	
	foreach($lesFichesFrais as $uneFicheFrais)
	{
		$idVisiteur = $uneFicheFrais['idVisiteur'];
		$mois =  $uneFicheFrais['mois'];
		$nbFrais = rand(0,5);
		for($i=0;$i<=$nbFrais;$i++)
		{
			$hasardNumfrais = rand(1,count($desFrais)); 
			$frais = $desFrais[$hasardNumfrais];
			$lib = $frais['lib'];
			$min= $frais['min'];
			$max = $frais['max'];
			$hasardMontant = rand($min,$max);
			$numAnnee =substr( $mois,0,4);
			$numMois =substr( $mois,4,2);
			$hasardJour = rand(1,28);
			if(strlen($hasardJour)==1)
			{
				$hasardJour="0".$hasardJour;
			}
			$hasardMois = $numAnnee."-".$numMois."-".$hasardJour;
			$req = "insert into lignefraishorsforfait(idVisiteur,mois,libelle,date,montant)
			values('$idVisiteur','$mois','$lib','$hasardMois',$hasardMontant);";
			$pdo->exec($req);
		}
	}
}
/**
 * retourne la date donnée en paramétre au format année.mois
 * 
 * @param type $date
 * @return type
 */
function getMois($date){
		@list($jour,$mois,$annee) = explode('/',$date);
		if(strlen($mois) == 1){
			$mois = "0".$mois;
		}
		return $annee.$mois;
}
/**
 * Effectue une mise a jour des frais pour chaque utilisateur(s)
 * ayant au moins une fiche de frais forfait
 * 
 * @param type $pdo
 */
function majFicheFrais($pdo)
{
	
	$lesFichesFrais= getLesFichesFrais($pdo);
	foreach($lesFichesFrais as $uneFicheFrais)
	{
		$idVisiteur = $uneFicheFrais['idVisiteur'];
		$mois =  $uneFicheFrais['mois'];
		$dernierMois = getDernierMois($pdo, $idVisiteur);
		$req = "select sum(montant) as cumul from ligneFraisHorsForfait where ligneFraisHorsForfait.idVisiteur = '$idVisiteur' 
				and ligneFraisHorsForfait.mois = '$mois' ";
		$res = $pdo->query($req);
		$ligne = $res->fetch();
		$cumulMontantHorsForfait = $ligne['cumul'];
		$req = "select sum(ligneFraisForfait.quantite * fraisForfait.montant) as cumul from ligneFraisForfait, FraisForfait where
		ligneFraisForfait.idFraisForfait = fraisForfait.id   and   ligneFraisForfait.idVisiteur = '$idVisiteur' 
				and ligneFraisForfait.mois = '$mois' ";
		$res = $pdo->query($req);
		$ligne = $res->fetch();
		$cumulMontantForfait = $ligne['cumul'];
		$montantEngage = $cumulMontantHorsForfait + $cumulMontantForfait;
		$etat = $uneFicheFrais['idEtat'];
		if($etat == "CR" )
			$montantValide = 0;
		else
			$montantValide = $montantEngage*rand(80,100)/100;
		$req = "update fichefrais set montantValide =$montantValide where
		idVisiteur = '$idVisiteur' and mois='$mois'";
		$pdo->exec($req);
		
	}
}
?>




