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
                                    <option>Forfait etape</option>
                                    <option>Frais kilométrique</option>
                                    <option>Nuitée hôtel</option>
                                    <option>Repas restaurant</option>
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
        </div>
</div>

