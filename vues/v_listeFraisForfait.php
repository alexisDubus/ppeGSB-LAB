<div class="col-md-6">
	<div class="content-box-large">
		<div class="panel-heading">
			<div class="panel-title"><h2></h2></div>
			</br></br>
		  <legend>Eléments forfaitisés du mois <?php 
			echo $nomMois;
			echo $numAnnee?> :</legend>			
		</div>
		<div class="panel-body">
                    <h3>Saisie d'un nouveau frais forfaitisé : </h3>
			<form class="form-horizontal" role="form" action="index.php?uc=gererFrais&action=validerCreationFrais" method="post">
			<div class="form-group"><br />
                                <label>Type de frais : </label>
                                <select name="typeFrais">
                                    <?php
                                        foreach ($lesLibelleFrais as $unLibelleFrais) {
                                            echo '<option>';
                                            echo $unLibelleFrais['libelle'];
                                            echo '</option>';
                                        }
                                    ?>
                                </select><br />
                                
                                <label>Date de l'engagement de la dépense : </label>
                                <input class="form-control" placeholder="0" type="Date" id="idFrais" name="date"><br />
                                
                                <label>Descritpion : </label>
                                <input class="form-control" type="text" id="idFrais" name="description"><br />
                                
                                <label>Quantité : </label><br />
                                <input class="form-control" type="text" id="idFrais" name="quantite"><br />
                        </div>
			<input class="btn btn-primary" id="ok" type="submit" value="Valider" size="20" />
                        </form
                </div>
            <div class="panel-body">
                <h3>Eléments forfaitisés (synthèse du mois)</h3>
                <table class="table">
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
                                    echo '<tr>
                                        . <td>';
                                    echo "Montant Total";
                                    echo '</td>';
                                    foreach ($lesLibelleFrais as $unLibelleFrais) {
                                        $quantiteFraisForfait = donneQuantiteTypeFrais($unLibelleFrais['libelle'], $lesFraisForfait);
                                        $montantFraisForfait = $pdo->getMontantFraisForfait($unLibelleFrais['libelle'], $quantiteFraisForfait);
                                        echo '<td>';
                                        echo $montantFraisForfait;
                                        echo '</td>';
                                    }
                                    echo '</tr>';
                                ?>
			 </table>
            </div>
            <div class="panel-body">
                <table class="table">
			  <thead>
				<tr>
					<th class="date">Date</th>
					<th class="typeFrais">Type Frais</th>  
					<th class="description">description</th>  
                                        <th class="quantite">Quantité</th>  
					<th class="action">&nbsp;</th>              
				 </tr>
				 <?php    
                                                                
					foreach( $lesInfosFrais as $unFraisForfait) 
					{
						$typeFrais = $unFraisForfait['libelle'];
						$date = $unFraisForfait['dateFrais'];
						$descriptiont=$unFraisForfait['description'];
						$quantite = $unFraisForfait['quantite'];
                                                $id = $unFraisForfait['id'];
						
				?>		
						<tr>
							<td> <?php echo $date ?></td>
							<td><?php echo $typeFrais ?></td>
							<td><?php echo $descriptiont ?></td>
                                                        <td><?php echo $quantite ?></td>
							<td> <?php 
									echo '<a href="index.php?uc=gererFrais&action=supprimerFrais&id='.$id.'"
								onclick="return confirm(\'Voulez-vous vraiment supprimer ce frais?\');">Supprimer ce frais</a></td>';
								
						?></tr><?php		 }  ?>	  
			 </table>
            </div>
        </div>
</div>

