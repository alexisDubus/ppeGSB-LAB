

<style type="text/css">
<!--
table { vertical-align: top; }
tr    { vertical-align: top; }
td    { vertical-align: top; }
}
-->
</style>

<?php

//session_start();
require_once("fct.inc.php");
include_once '../../../include/class.pdogsb.inc.php';
$pdo = PdoGsb::getPdoGsb(); 

$leMois = 0; //en cas d'erreur
$idUtilisateur = "a131";
$lesMois=$pdo->getLesMoisDisponibles($idUtilisateur);
$moisASelectionner = $leMois;
$lesFraisHorsForfait = $pdo->getLesFraisHorsForfait($idUtilisateur,$leMois);
$lesFraisForfait= $pdo->getLesFraisForfait($idUtilisateur,$leMois);
$lesLibelleFrais = $pdo->getLibelleFraisForfait();
$lesInfosFicheFrais = $pdo->getLesInfosFicheFrais($idUtilisateur,$leMois);
$numAnnee =substr( $leMois,0,4);
$numMois =substr( $leMois,4,2);
 $nomMois = donneNomMois($numMois);
$libEtat = $lesInfosFicheFrais['libEtat'];
$montantValide = $lesInfosFicheFrais['montantValide'];
$nbJustificatifs = $lesInfosFicheFrais['nbJustificatifs'];
$dateModif =  $lesInfosFicheFrais['dateModif'];
$dateModif =  dateAnglaisVersFrancais($dateModif); 
                
 ?>
<page backcolor="#FEFEFE" backimg="./res/bas_page.png" backimgx="center" backimgy="bottom" backimgw="100%" backtop="0" backbottom="30mm" footer="date;heure;page" style="font-size: 12pt">
    <bookmark title="Lettre" level="0" ></bookmark>
    <table cellspacing="0" style="width: 100%; text-align: center; font-size: 14px">
        <tr>
           <!--  <td style="width: 75%;">
            </td>
           <td style="width: 25%; color: #444444;">
                <img style="width: 100%;" src="./res/logo.gif" alt="Logo"><br>
                RELATION CLIENT
            </td> -->
        </tr>
    </table>
    <br>
    <br>
    <table cellspacing="0" style="width: 100%; text-align: left; font-size: 11pt;">
        <tr>
            <td style="width:50%;"></td>
            <td style="width:14%; ">Client :</td>
            <td style="width:36%">M. Albert Dupont</td>
        </tr>
        <tr>
            <td style="width:50%;"></td>
            <td style="width:14%; ">Adresse :</td>
            <td style="width:36%">
                Résidence perdue<br>
                1, rue sans nom<br>
                00 000 - Pas de Ville<br>
            </td>
        </tr>
        <tr>
            <td style="width:50%;"></td>
            <td style="width:14%; ">Email :</td>
            <td style="width:36%">nomail@domain.com</td>
        </tr>
    </table>
    <br>
    <br>
    <table cellspacing="0" style="width: 100%; text-align: left;font-size: 10pt">
        <tr>
            <td style="width:50%;"></td>
          <!--  <td style="width:50%; ">Le   //echo date('d/m/Y'); </td> -->
            <td style="width:50%; ">Le <?php echo $dateModif ?></td>
        </tr>
    </table>
    <br>
    <i>
        <b><u>Votre fiche de frais </u></b><br>
    </i>
    <?php
    
    
    
    ?>
    <br>
    <br>
    <br>
    <br>
    <table cellspacing="0" style="width: 100%; border: solid 1px black; background: #E7E7E7; text-align: center; font-size: 10pt;">
        <tr>
            <th style="width: 12%">Produit</th>
            <th style="width: 52%">Désignation</th>
            <th style="width: 13%">Prix Unitaire</th>
            <th style="width: 10%">Quantité</th>
            <th style="width: 13%">Prix Net</th>
        </tr>
    </table>
<?php
    $nb = rand(5, 11);
    $produits = array();
    $total = 0;
    for ($k=0; $k<$nb; $k++) {
        $num = rand(100000, 999999);
        $nom = "le produit n°".rand(1, 100);
        $qua = rand(1, 20);
        $prix = rand(100, 9999)/100.;
        $total+= $prix*$qua;
        $produits[] = array($num, $nom, $qua, $prix, rand(0, $qua));
?>
    <table cellspacing="0" style="width: 100%; border: solid 1px black; background: #F7F7F7; text-align: center; font-size: 10pt;">
        <tr>
            <td style="width: 12%; text-align: left"><?php echo $num; ?></td>
            <td style="width: 52%; text-align: left"><?php echo $nom; ?></td>
            <td style="width: 13%; text-align: right"><?php echo number_format($prix, 2, ',', ' '); ?> &euro;</td>
            <td style="width: 10%"><?php echo $qua; ?></td>
            <td style="width: 13%; text-align: right;"><?php echo number_format($prix*$qua, 2, ',', ' '); ?> &euro;</td>
        </tr>
    </table>
<?php
    }
?>
    
</page>