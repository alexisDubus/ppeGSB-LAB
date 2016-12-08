<div class="col-md-6">
	<div class="content-box-large">
		<div class="panel-heading">
			<div class="panel-title"><h2></h2></div>
			</br></br>
		  <legend>Eléments forfaitisés du mois <?php 
				switch ($numMois) {
			case 1:
				echo "de janvier ";
				break;
			case 2:
				echo "de février ";
				break;
			case 3:
				echo "de mars ";
				break;
			case 4:
				echo "d'avril ";
				break;
			case 5:
				echo "de mai ";
				break;
			case 6:
				echo "de juin ";
				break;
			case 7:
				echo "de juillet ";
				break;
			case 8:
				echo "d'août ";
				break;
			case 9:
				echo "de septembre ";
				break;
			case 10:
				echo "d'octobre ";
				break;
			case 11:
				echo "de novembre ";
				break;
			case 12:
				echo "de décembre ";
				break;		
			}
			echo $numAnnee?> :</legend>			
		</div>
		<div class="panel-body">
                    <h3>Saisie d'un nouveau frais forfaitisé : </h3>
			<form class="form-horizontal" role="form" action="index.php?uc=gererFrais&action=validerCreationFrais" method="post">
			<div class="form-group"><br />
                                <label>Type de frais : </label>
                                <select name="typeFrais">
                                    <option>Forfait Etape</option>
                                    <option>Frais Kilométrique</option>
                                    <option>Nuitée Hôtel</option>
                                    <option>Repas Restaurant</option>
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
					<th>Forfait Etape</th>
					<th>Frais Kilométrique</th>  
					<th>Nuitée Hôtel</th>  
                                        <th>Repas Restaurant</th>  
					<th class="action">&nbsp;</th>                
				 </tr>
                                 
                                 <?php    
                                        $quantiteForfaitEtape = donneQuantiteTypeFrais("Forfait Etape", $lesFraisForfait);
                                        $quantiteFraisKilometrique = donneQuantiteTypeFrais("Frais Kilométrique", $lesFraisForfait);
                                        $quantiteNuiteeHotel = donneQuantiteTypeFrais("Nuitée Hôtel", $lesFraisForfait);
                                        $quantiteRepasRestaurant = donneQuantiteTypeFrais("Repas Restaurant", $lesFraisForfait);
				?>		
						<tr>
                                                    <td> <?php echo "Quantité Totale"?></td>
                                                    <td> <?php echo $quantiteForfaitEtape ?></td>
                                                    <td><?php echo $quantiteFraisKilometrique ?></td>
                                                    <td><?php echo $quantiteNuiteeHotel ?></td>
                                                    <td><?php echo $quantiteRepasRestaurant ?></td>
                                                </tr>
                                <?php 
                                        $montantForfaitEtape = donneMontantTotal("Forfait Etape", $quantiteForfaitEtape);
                                        $montantFraisKilometrique = donneMontantTotal("Frais Kilométrique", $quantiteFraisKilometrique);
                                        $montantNuiteeHotel = donneMontantTotal("Nuitée Hôtel", $quantiteNuiteeHotel);
                                        $montantRepasRestaurant = donneMontantTotal("Repas Restaurant", $quantiteRepasRestaurant);
                                ?>
                                           	<tr>
                                                    <td> <?php echo "Montant Totale"?></td>
                                                    <td> <?php echo $montantForfaitEtape ?></td>
                                                    <td><?php echo $montantFraisKilometrique ?></td>
                                                    <td><?php echo $montantNuiteeHotel ?></td>
                                                    <td><?php echo $montantRepasRestaurant ?></td>
                                                </tr>
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
						
				?>		
						<tr>
							<td> <?php echo $date ?></td>
							<td><?php echo $typeFrais ?></td>
							<td><?php echo $descriptiont ?></td>
                                                        <td><?php echo $quantite ?></td>
							<td> <?php 
									echo '<a href="index.php?uc=gererFrais&action=supprimerFrais&typeFrais='.$typeFrais.'"
								onclick="return confirm(\'Voulez-vous vraiment supprimer ce frais?\');">Supprimer ce frais</a></td>';
								
						?></tr><?php		 }  ?>	  
			 </table>
            </div>
        </div>
</div>

