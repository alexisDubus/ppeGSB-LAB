<div class="col-md-6">
    <div class="content-box-large">
	<div class="panel-heading">
            <div class="panel-title"><h1> Liste des Frais Forfait existant
                <table>  
                <tr>
                    <?php               
                        $a = '<table><tr>';
                        foreach ( $fraisforfait as $unFraisForfait ) 
                        {
                            // Recuperation de l'id
                            $id = $unFraisForfait['id'];
                            $a.= '<th>'.$id.'</th>';
                    ?>	
                            <th> <?php echo $id?></th>
                    <?php      
                            // Recuperation du libelle
                            $libelle = $unFraisForfait['libelle'];
                            $a.= '<th>'.$libelle.'</th>';
                    ?>	
                            <th> <?php echo $libelle?></th>
                    <?php       
                            // Recuperation du montant
                            $montant = $unFraisForfait['montant'];
                            $a.= '<th>'.$montant.'</th>';
                    ?>	
                            <th> <?php echo $montant?></th>
                            
                            <a href="?action=update&amp;id=<?php echo $fraisforfait['id'] ?>">Modifier</a>
                            <a href="?action=delete&amp;id=<?php echo $fraisforfait['id'] ?>">Supprimer</a>  
                 
                 <?php  } ?>
                </tr>
                </table>
                
       
  