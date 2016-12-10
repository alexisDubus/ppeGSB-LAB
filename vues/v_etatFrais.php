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
                                                    <td> <?php echo $quantiteForfaitEtape ?></td>
                                                    <td><?php echo $quantiteFraisKilometrique ?></td>
                                                    <td><?php echo $quantiteNuiteeHotel ?></td>
                                                    <td><?php echo $quantiteRepasRestaurant ?></td>
                                                </tr>
			 </table>
  	<table class="table">
  	   <caption>Descriptif des éléments hors forfait -<?php echo $nbJustificatifs ?> justificatifs reçus -
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
	
	
	
  </div>
  </div>