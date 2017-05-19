<div class="col-md-6">
	<div class="content-box-large">
		<div class="panel-heading">
			<legend>Vos véhicules : </legend>
		</div>
		<div class="panel-body">
			<table class="table">
			  <thead>
				<tr>
					<th class="date">Plaque</th>
					<th class="libelle">Libellé</th>  
					<th class="montant">Puissance</th>  
					<th class="action">&nbsp;</th>              
				 </tr>
				 <?php    

					foreach( $lesVehicules as $unVehicule) 
					{
						$libelle = $unVehicule['libelle'];
						$plaque = $unVehicule['plaque'];
						$puissance=$unVehicule['puissance'];
						$idVehicule = $unVehicule['id'];
                                                
						
				?>		
						<tr>
							<td> <?php echo $plaque ?></td>
							<td><?php echo $libelle ?></td>
							<td><?php echo $puissance ?></td>
                                        <?php echo '<td><a href="index.php?uc=vehicule&action=supprimerVehicule&id='.$idVehicule.'"
								onclick="return confirm(\'Voulez-vous vraiment supprimer ce frais?\');">Supprimer ce véhicule </a></td>'; 
                                        
                                        } ?>	
			 </table>
		</div> 
	</div>
</div>


    
                            
<div class="col-md-6">
	<div class="content-box-large">
		<div class="panel-heading">
			<legend>Nouveau véhicule</legend>			
		</div>
		<div class="panel-body">
			<form class="form-horizontal" role="form" action="index.php?uc=vehicule&action=validerCreationVehicule" method="post">
				<div class="form-group">
					<div class="form-group">
                                            
                                        <select name="idCategorie">
                                        <?php
                                         foreach ($typeCategorie as $value) {
                                             echo '<option id="'.$value['id'].'">'.$value['puissance'].'</option>';
                                         }
                                        ?>
                                        </select>
                                            
					<label for="txtLibelleHF">Libellé</label>
					</br>
					<input class="form-control" type="text" id="libelle" name="libelle"  />
					</br></br>
					<label for="plaque">plaque : </label>
					</br>
					<input class="form-control" type="text" id="plaque" name="plaque" />
					</br></br>
					</div>
				</div>
			<div class="horizontal-form">
				<input class="btn btn-primary" id="ajouter" type="submit" value="Ajouter"/>
				<input class="btn btn-primary" id="effacer" type="reset" value="Effacer" />
      
			</div>
        
			</form>
							
		</div>
	</div>
</div>



  

