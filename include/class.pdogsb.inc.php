<?php

/** 
 * Classe d'accès aux données. 
 
 * Utilise les services de la classe PDO
 * pour l'application GSB
 * Les attributs sont tous statiques,
 * les 4 premiers pour la connexion
 * $monPdo de type PDO 
 * $monPdoGsb qui contiendra l'unique instance de la classe
 
 * @package default
 * @author Cheri Bibi
 * @version    1.0
 * @link       http://www.php.net/manual/fr/book.pdo.php
 */

class PdoGsb
{

        
        private static $serveur='mysql:host=localhost';
        private static $bdd='dbname=gsb_frais';
        private static $user='root';    		
        private static $leMdp = 'root';
        //private static $bdd='dbname=gsb_frais';   		
      	//private static $user='root';    		
      	//private static $mdp='AzertY!59';	
	private static $monPdo;
	private static $monPdoGsb=null;
		
/**
 * Constructeur privé, crée l'instance de PDO qui sera sollicitée
 * pour toutes les méthodes de la classe
 */				
	private function __construct(){
    	PdoGsb::$monPdo = new PDO(PdoGsb::$serveur.';'.PdoGsb::$bdd, PdoGsb::$user, PdoGsb::$leMdp);
		PdoGsb::$monPdo->query("SET CHARACTER SET utf8");

	}
	public function _destruct(){
		PdoGsb::$monPdo = null;
	}
/**
 * Fonction statique qui crée l'unique instance de la classe
 
 * Appel : $instancePdoGsb = PdoGsb::getPdoGsb();
 
 * @return l'unique objet de la classe PdoGsb
 */
	public  static function getPdoGsb(){
		if(PdoGsb::$monPdoGsb==null){
			PdoGsb::$monPdoGsb= new PdoGsb();
		}
		return PdoGsb::$monPdoGsb;  
	}
/**
 * Retourne les informations d'un utilisateur
 
 * @param $login 
 * @param $mdp
 * @return l'id, le type,le nom et le prénom sous la forme d'un tableau associatif 
*/
	public function getInfosUtilisateur($login, $mdp){
                $mdpSHA = sha1($mdp);
                
		$req = "select utilisateur.id as id, utilisateur.nom as nom, utilisateur.prenom as prenom, utilisateur.idRole as idRole, role.profession as role from utilisateur, role 
		where utilisateur.login='$login' and utilisateur.mdpSHA='$mdpSHA' and utilisateur.idRole = role.id ";
		$rs = PdoGsb::$monPdo->query($req);
		$ligne = $rs->fetch();
                $_SESSION['role']= $ligne["role"];
		return $ligne;
	}
        
  /**
  *  Initialise la valeur $_SESSION['role'] de l'utilisateur qui est fonction de sa profession(Administrateur, comptable ou visiteur médical)
  *  la variable superglobale $_SESSION['role'] sera affichée au nivreau de la barre de navigation
  * 
  * @param type $utilisateur
  */
        public function getRoleUtilisateur($idutilisateur)
        {
                //$requete = "select role.profession as role from role where role.id = 0;";
                $requete = "select role.profession as role from role, utilisateur where utilisateur.id='$idutilisateur' and utilisateur.idRole = role.id;";
		$retour = PdoGsb::$monPdo->query($requete);
		$ligneRetour = $retour->fetch();
                
                $_SESSION['role']= $ligneRetour["role"];
                if($ligneRetour["role"] == null )
                {
                    var_dump($ligneRetour);
                }
        }

        /**
 * Retourne sous forme d'un tableau associatif toutes les lignes de frais hors forfait
 * concernées par les deux arguments
 
 * La boucle foreach ne peut être utilisée ici car on procède
 * à une modification de la structure itérée - transformation du champ date-
 
 * @param $idUtilisateur
 * @param $mois sous la forme aaaamm
 * @return tous les champs des lignes de frais hors forfait sous la forme d'un tableau associatif 
*/
	public function getLesFraisHorsForfait($idUtilisateur,$mois){
	    $req = "select * from lignefraishorsforfait where lignefraishorsforfait.idUtilisateur ='$idUtilisateur' 
		and lignefraishorsforfait.mois = '$mois' ";	
		$res = PdoGsb::$monPdo->query($req);
		$lesLignes = $res->fetchAll();
		$nbLignes = count($lesLignes);
		for ($i=0; $i<$nbLignes; $i++){
			$date = $lesLignes[$i]['date'];
			$lesLignes[$i]['date'] =  dateAnglaisVersFrancais($date);
		}
		return $lesLignes; 
                
	}

	/**
 * Retourne sous forme d'un tableau associatif toutes les lignes de la table 
 * fraisforfait
 *
 * @return l'id, le libelle et le montant sous la forme d'un tableau associatif 
 */
        public function getFraisForfaitOnly()
        {
            $req = "select  fraisforfait.id as id, fraisforfait.libelle as libelle, fraisforfait.montant as montant
                    from    fraisforfait";
            $res = PdoGsb::$monPdo->query($req);
			$lesLignes = $res->fetchAll();
			return $lesLignes;        
        }

/** Retourne sous forme d'un tableau associatif le frais forfait correspondant a l'id d'un 
 * fraisforfait
 *
 * @return l'id, le libelle et le montant sous la forme d'un tableau associatif 
 */
        public function getOneFraisForfait($id)
        {
            $req = "select  *
            		from    fraisforfait
            		where fraisforfait.id ='$id'";
            $res = PdoGsb::$monPdo->query($req);
			$lesLignes = $res->fetchAll();
			return $lesLignes;        
        }
/**
 * Retourne le nombre de justificatif d'un utilisateur pour un mois donné
 
 * @param $idUtilisateur
 * @param $mois sous la forme aaaamm
 * @return le nombre entier de justificatifs 
*/
	public function getNbjustificatifs($idUtilisateur, $mois){
		$req = "select fichefrais.nbjustificatifs as nb from  fichefrais where fichefrais.idutilisateur ='$idUtilisateur' and fichefrais.mois = '$mois'";
		$res = PdoGsb::$monPdo->query($req);
		$laLigne = $res->fetch();
		return $laLigne['nb'];
	}
/**
 * Retourne sous forme d'un tableau associatif toutes les lignes de frais au forfait
 * concernées par les deux arguments
 
 * @param $idUtilisateur 
 * @param $mois sous la forme aaaamm
 * @return l'id, le libelle et la quantité sous la forme d'un tableau associatif 
*/
	public function getLesFraisForfait($idUtilisateur, $mois){
		$req = "select fraisforfait.id as idfrais, fraisforfait.libelle as libelle, 
		lignefraisforfait.quantite as quantite from lignefraisforfait inner join fraisforfait 
		on fraisforfait.id = lignefraisforfait.idfraisforfait
		where lignefraisforfait.idutilisateur ='$idUtilisateur' and lignefraisforfait.mois='$mois' 
		order by lignefraisforfait.idfraisforfait";	
		$res = PdoGsb::$monPdo->query($req);
		$lesLignes = $res->fetchAll();
		return $lesLignes; 
	}
        
        /**
         * retourne les frais forfaits d'un utilisateur
         * 
         * @param type $idUtilisateur
         * @return type
         */
        public function getLesInfosFrais($idUtilisateur){
		$req = "select fraisforfait.id as idfrais, fraisforfait.libelle as libelle, 
		lignefraisforfait.id as id, lignefraisforfait.quantite as quantite, lignefraisforfait.dateFrais as dateFrais, lignefraisforfait.description as description from lignefraisforfait inner join fraisforfait 
		on fraisforfait.id = lignefraisforfait.idfraisforfait where lignefraisforfait.idutilisateur = '$idUtilisateur'";	
		$res = PdoGsb::$monPdo->query($req);
		$lesLignes = $res->fetchAll();
		return $lesLignes; 
	}

        /**
         * 
         * @return type
         */
        public function getLibelleFraisForfait() {
            $req = "select fraisforfait.libelle as libelle from fraisforfait";
            $res = PdoGsb::$monPdo->query($req);
            $lesLignes = $res->fetchAll();
            return $lesLignes;
        }
        
        /**
         * 
         * @return type
         */
        public function getNombreFraisForfait() {
            $req = "select count(*) as nombreFrais from fraisforfait";
            $res = PdoGsb::$monPdo->query($req);
            $lesLignes = $res->fetchAll();
            return $lesLignes;
        }
/**
 * Retourne tous les id de la table FraisForfait
 
 * @return un tableau associatif 
*/
	public function getLesIdFrais(){
		$req = "select fraisforfait.id as idfrais from fraisforfait order by fraisforfait.id";
		$res = PdoGsb::$monPdo->query($req);
		$lesLignes = $res->fetchAll();
		return $lesLignes;
	}
/**
 * Met à jour la table lignefraisforfait
 
 * Met à jour la table lignefraisforfait pour un utilisateur et
 * un mois donné en enregistrant les nouveaux montants
 
 * @param $idUtilisateur
 * @param $mois sous la forme aaaamm
 * @param $lesFrais tableau associatif de clé idFrais et de valeur la quantité pour ce frais
 * @return un tableau associatif 
*/
	public function majFraisForfait($idUtilisateur, $mois, $lesFrais){
		$lesCles = array_keys($lesFrais);
		foreach($lesCles as $unIdFrais){
			$qte = $lesFrais[$unIdFrais];
			$req = "update lignefraisforfait set lignefraisforfait.quantite = $qte
			where lignefraisforfait.idutilisateur = '$idUtilisateur' and lignefraisforfait.mois = '$mois'
			and lignefraisforfait.idfraisforfait = '$unIdFrais'";
			PdoGsb::$monPdo->exec($req);
		}
	}
/**
 * met à jour le nombre de justificatifs de la table fichefrais
 * pour le mois et le utilisateur concerné
 
 * @param $idUtilisateur
 * @param $mois sous la forme aaaamm
 * @param $nbJustificatifs
*/
	public function majNbJustificatifs($idUtilisateur, $mois, $nbJustificatifs){
		$req = "update fichefrais set nbjustificatifs = $nbJustificatifs 
		where fichefrais.idutilisateur = '$idUtilisateur' and fichefrais.mois = '$mois'";
		PdoGsb::$monPdo->exec($req);	
	}
/**
 * Teste si un utilisateur possède une fiche de frais pour le mois passé en argument
 
 * @param $idUtilisateur 
 * @param $mois sous la forme aaaamm
 * @return vrai ou faux 
*/	
	public function estPremierFraisMois($idUtilisateur,$mois)
	{
		$ok = false;
		$req = "select count(*) as nblignesfrais from fichefrais 
		where fichefrais.mois = '$mois' and fichefrais.idutilisateur = '$idUtilisateur'";
		$res = PdoGsb::$monPdo->query($req);
		$laLigne = $res->fetch();
		if($laLigne['nblignesfrais'] == 0){
			$ok = true;
		}
		return $ok;
	}
/**
 * Retourne le dernier mois en cours d'un utilisateur
 
 * @param $idUtilisateur 
 * @return le mois sous la forme aaaamm
*/	
	public function dernierMoisSaisi($idUtilisateur){
		$req = "select max(mois) as dernierMois from fichefrais where fichefrais.idutilisateur = '$idUtilisateur'";
		$res = PdoGsb::$monPdo->query($req);
		$laLigne = $res->fetch();
		$dernierMois = $laLigne['dernierMois'];
		return $dernierMois;
	}
	
/**
 * Crée une nouvelle fiche de frais et les lignes de frais au forfait pour un utilisateur et un mois donnés
 
 * récupère le dernier mois en cours de traitement, met à 'CL' son champs idEtat, crée une nouvelle fiche de frais
 * avec un idEtat à 'CR' et crée les lignes de frais forfait de quantités nulles 
 * @param $idUtilisateur
 * @param $mois sous la forme aaaamm
*/
	public function creeNouvellesLignesFrais($idUtilisateur,$mois){
		$dernierMois = $this->dernierMoisSaisi($idUtilisateur);
		$laDerniereFiche = $this->getLesInfosFicheFrais($idUtilisateur,$dernierMois);
		if($laDerniereFiche['idEtat']=='CR'){
				$this->majEtatFicheFrais($idUtilisateur, $dernierMois,'CL');
				
		}
		$req = "insert into fichefrais(idutilisateur,mois,nbJustificatifs,montantValide,dateModif,idEtat) 
		values('$idUtilisateur','$mois',0,0,now(),'CR')";
                
		PdoGsb::$monPdo->exec($req);
		$lesIdFrais = $this->getLesIdFrais();
		foreach($lesIdFrais as $uneLigneIdFrais){
			$unIdFrais = $uneLigneIdFrais['idfrais'];
			$req = "insert into lignefraisforfait(idutilisateur,mois,idFraisForfait,quantite) 
			values('$idUtilisateur','$mois','$unIdFrais',0)";
			PdoGsb::$monPdo->exec($req);
		 }
	}
        /**
         * 
         * @param type $idUtilisateur
         * @param type $mois
         * @param type $typeFrais
         * @param type $description
         * @param type $date
         * @param type $quantite
         */
        public function creeNouveauFraisForfait($idUtilisateur,$mois,$typeFrais,$description,$date,$quantite,$idFraisForfait){
                $quantiteInt = (int)$quantite;
		$dateFr = dateFrancaisVersAnglais($date);
		//$req = "insert into lignefraisforfait (idutilisateur,mois,idFraisForfait,quantite,montant,dateFrais,typeFrais,description) values($idUtilisateur,$mois,`ETP`,$quantiteInt,0.00,$dateFr,$typeFrais,$description);";
                $req = "insert into lignefraisforfait (idutilisateur,mois,idFraisForfait,quantite,montant,dateFrais,typeFrais,description) values('$idUtilisateur','$mois','$idFraisForfait',$quantiteInt,0.00,'$dateFr','$typeFrais','$description');";
		PdoGsb::$monPdo->exec($req);
	}

        /**
         * Crée un nouveau frais hors forfait pour un utilisateur et un mois donné
         * à partir des informations fournies en paramètre

         * @param $idUtilisateur
         * @param $mois sous la forme aaaamm
         * @param $libelle : le libelle du frais
         * @param $date : la date du frais au format français jj//mm/aaaa
         * @param $montant : le montant
        */
	public function creeNouveauFraisHorsForfait($idUtilisateur,$mois,$libelle,$date,$montant){
		$dateFr = dateFrancaisVersAnglais($date);
		$req = "insert into lignefraishorsforfait 
		values(DEFAULT,'$idUtilisateur','$mois','$libelle','$dateFr','$montant')";
		PdoGsb::$monPdo->exec($req);
	}

        /**
         * créé un nouveau forfait en fonction des paramétres
         * 
         * @param type $id
         * @param type $libelle
         * @param type $montant
         */
	public function creerNouveauTypeFraisForfait ($id,$libelle,$montant)
	{
		$req = "insert into fraisforfait (id,libelle,montant) values ('$id','$libelle','$montant'); ";
		PdoGsb::$monPdo->exec($req);
	}
	
        /**
         * supprime un frais forfait
         * 
         * @param type $idFrais
         */
	public function supprimerUnFraisForfait($idFrais)
	{
		$req = "delete from fraisforfait where fraisforfait.id = '$idFrais'";
		PdoGsb::$monPdo->exec($req);
	}
        
        /*
        public function supprimerFraisForfait($id){
		$req = "delete from lignefraisforfait where lignefraisforfait.id ='$id';";
		PdoGsb::$monPdo->exec($req);
		}
         /*

        /**
         * 
         * @param type $idFrais
         */
        public function supprimerFraisForfait($idUtilisateur,$mois,$typeFrais)
        {
		$req = "delete from lignefraisforfait where lignefraisforfait.idutilisateur ='$idUtilisateur' and lignefraisforfait.mois ='$mois' and lignefraisforfait.typeFrais ='$typeFrais';";
        }
        
/**
 * Supprime le frais hors forfait dont l'id est passé en argument
 
 * @param $idFrais 
*/
	public function supprimerFraisHorsForfait($idFrais){
		$req = "delete from lignefraishorsforfait where lignefraishorsforfait.id =$idFrais ";
		PdoGsb::$monPdo->exec($req);
	}
/**
 * Retourne les mois pour lesquels un utilisateur a une fiche de frais
 
 * @param $idUtilisateur
 * @return un tableau associatif de clé un mois -aaaamm- et de valeurs l'année et le mois correspondant 
*/
	public function getLesMoisDisponibles($idUtilisateur){
		$req = "select fichefrais.mois as mois from  fichefrais where fichefrais.idutilisateur ='$idUtilisateur' and fichefrais.idEtat in ('CR', 'VA')
		order by fichefrais.mois desc ";
		$res = PdoGsb::$monPdo->query($req);
		$lesMois =array();
		$laLigne = $res->fetch();
		while($laLigne != null)	{
			$mois = $laLigne['mois'];
			$numAnnee =substr( $mois,0,4);
			$numMois =substr( $mois,4,2);
			$lesMois["$mois"]=array(
		    "mois"=>"$mois",
		    "numAnnee"  => "$numAnnee",
			"numMois"  => "$numMois"
             );
			$laLigne = $res->fetch(); 		
		}
		return $lesMois;
	}
	

/**
 * Retourne les informations d'une fiche de frais d'un utilisateur pour un mois donné
 
 * @param $idUtilisateur
 * @param $mois sous la forme aaaamm
 * @return un tableau avec des champs de jointure entre une fiche de frais et la ligne d'état 
*/	
	public function getLesInfosFicheFrais($idUtilisateur,$mois){
		$req = "select fichefrais.idEtat as idEtat, fichefrais.dateModif as dateModif, fichefrais.nbJustificatifs as nbJustificatifs, 
			fichefrais.montantValide as montantValide, etat.libelle as libEtat from  fichefrais inner join etat on fichefrais.idEtat = etat.id 
			where fichefrais.idutilisateur ='$idUtilisateur' and fichefrais.mois = '$mois'";
		$res = PdoGsb::$monPdo->query($req);
		$laLigne = $res->fetch();
		return $laLigne;
	}
/**
 * Modifie l'état et la date de modification d'une fiche de frais
 
 * Modifie le champ idEtat et met la date de modif à aujourd'hui
 * @param $idUtilisateur
 * @param $mois sous la forme aaaamm
 */
 
	public function majEtatFicheFrais($idUtilisateur,$mois,$etat){
		$req = "update fichefrais set idEtat = '$etat', dateModif = now() 
		where fichefrais.idutilisateur ='$idUtilisateur' and fichefrais.mois = '$mois'";
		PdoGsb::$monPdo->exec($req);
	}
	
}


?>
