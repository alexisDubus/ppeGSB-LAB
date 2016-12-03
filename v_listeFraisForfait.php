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
			<form class="form-horizontal" role="form" method="POST"  action="index.php?uc=gererFrais&action=validerMajFraisForfait">
			  <div class="form-group">
				<?php
						foreach ($lesFraisForfait as $unFrais)
						{
							$idFrais = $unFrais['idfrais'];
							$libelle = $unFrais[	'libelle'];
							$quantite = $unFrais['quantite'];
					?>
							<div class="form-group">
								<label for="idFrais"><?php echo $libelle ?></label>
								<input class="form-control" placeholder="<?php echo $quantite?>" type="text" id="idFrais" name="lesFrais[<?php echo $idFrais?>]""<?php echo $quantite?>"<?php if ($lesInfosFicheFrais['idEtat']!='CR') { echo 'disabled';} ?> >
							</div>

					<?php
						}
					?>
				</div>
				<input class="btn btn-primary" id="ok" type="submit" value="Valider" size="20" <?php if ($lesInfosFicheFrais['idEtat']!='CR') { echo 'disabled';} ?>/>
			  </div>
			</form>
		</div>
	</div>






  