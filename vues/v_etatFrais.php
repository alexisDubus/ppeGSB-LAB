<div class="col-md-6">
	<div class="content-box-large">
		<div class="panel-heading">
			<div class="panel-title"><h2>Fiche de frais du mois <?php 
			echo $nomMois;
			echo $numAnnee?> :</h2></div>
		</div>
		<div class="panel-body">
				</br></br>
        <h3>Etat : <?php echo $libEtat?> depuis le <?php echo $dateModif?> <br></br> </h3>
				</br></br> 
	
  	<table class="table">
            <caption>Descriptif des éléments forfaitisés</caption>
			  <thead>
                              <tr>
                                    <th class="quantiteTotale"></th>
					<?php
                                        foreach ($lesLibelleFrais as $unLibelleFrais) {
                                            echo '<th>';
                                            echo $unLibelleFrais['libelle'];
                                            echo '</th>';
                                        }
                                    ?>
					<th class="action">&nbsp;</th>                
				 </tr>
                                <?php
                                    echo '<tr>
                                        . <td>';
                                    echo "Quantité Totale";
                                    echo '</td>';
                                    foreach ($lesLibelleFrais as $unLibelleFrais) {
                                        $quantiteFraisForfait = donneQuantiteTypeFrais($unLibelleFrais['libelle'], $lesFraisForfait);
                                        echo '<td>';
                                        echo $quantiteFraisForfait;
                                        echo '</td>';
                                    }
                                ?>
			 </table>
  	<table class="table">
  	   <caption>Descriptif des éléments hors forfait <?php echo $nbJustificatifs ?> justificatifs reçus 
       <table class="table">
			  <thead>
				<tr>
					<th class="date">Date</th>
					<th class="libelle">Libellé</th>  
					<th class="montant">Montant</th>  
					<th class="action">&nbsp;</th>              
				 </tr>
				 <?php    

					foreach( $lesFraisHorsForfait as $unFraisHorsForfait) 
					{
						$libelle = $unFraisHorsForfait['libelle'];
						$date = $unFraisHorsForfait['date'];
						$montant=$unFraisHorsForfait['montant'];
						$id = $unFraisHorsForfait['id']
						
				?>		
						<tr>
							<td> <?php echo $date ?></td>
							<td><?php echo $libelle ?></td>
							<td><?php echo $montant ?></td>
						</tr><?php		 }  ?>	  
			 </table>
               <?php
                $id = $_SESSION['idUtilisateur']; 
                $nom = $_SESSION['nom'];
                $prenom = $_SESSION['prenom'];
                $anneeMois = $nomMois.' '. $numAnnee;
               
                //Envoie via l'url les données pour la génération du PDF. 
            echo '<a class="btn btn-primary" href="fpdf/tutorial/tuto2.php?idUtilisateur='.$id.'&nom='.$nom.'&prenom='.$prenom.'&numAnne='.$numAnnee.'&AN='.$anneeMois.'&leMois='.$leMois.'">Télécharger le pdf du mois '.$anneeMois.'</a>'; 
            
            ?>
               
    </div>
  </div>