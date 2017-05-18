<div class="col-md-6">
	<div class="content-box-large">
		<div class="panel-heading">
			<legend>Catégories</legend>
		</div>
		<div class="panel-body">
			<table class="table">
			  <thead>
				<tr>
					<th class="libelle">Libellé</th>
					<th class="montantMaxU">Montant Maximum (Unitaire)</th> 
					<th class="montantMaxM">Montant Maximum (Mois)</th>   
					<th class="action">&nbsp;</th>              
				 </tr>
				 <?php    

					foreach( $lesCategories as $uneCategorie) 
					{
						$libelle = $uneCategorie['libelle'];
						$montantMaxU = $unFraisHorsForfait['montantMaxU'];
						$montantMaxM = $unFraisHorsForfait['montantMaxM'];
							
				?>		
						<tr>
							<td><?php echo $libelle ?></td>
							<td><?php echo $montantMaxU ?></td>
							<td><?php echo $montantMaxM ?></td>
						</tr><?php		 }  ?>	  
			 </table>
		</div> 
	</div>
</div>


    
                            
<div class="col-md-6">
	<div class="content-box-large">
		<div class="panel-heading">
			<legend>Nouvelle Categorie</legend>			
		</div>
		<div class="panel-body">
			<form class="form-horizontal" role="form" action="index.php?uc=gererCategories&action=validerCreationCategorie" method="post">
				<div class="form-group">
					<div class="form-group">
					<label for="txtDateHF"> Libellé :</label>
					</br>
					<input class="form-control" type="text" id="txtLibelleCat" name="libelle"/>
					</br></br>
					<label for="txtLibelleHF">Montant Maximum Unitaire :</label>
					</br>
					<input class="form-control" type="text" id="txtMontantMaxU" name="montantMaxU"/>  
					</br></br>
					<label for="txtMontantHF">Montant Maximum Par Mois : </label>
					</br>
					<input class="form-control" type="text" id="txtMontantMaxM" name="montantMaxM"/>  
					</br></br>
					</div>
				</div>
			<div class="horizontal-form">
				<input class="btn btn-primary" id="ajouter" type="submit" value="Ajouter" <?php if ($lesInfosFicheFrais['idEtat']!='CR') { echo 'disabled';} ?> />
				<input class="btn btn-primary" id="effacer" type="reset" value="Effacer" />
      
			</div>
        
			</form>
							
		</div>
	</div>
</div>
