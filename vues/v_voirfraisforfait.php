<! Partie pour l'affichage des frais forfait existant !>

<div class="col-md-6">
    <div class="content-box-large">
	   <div class="panel-heading">
            <div class="panel-title"><h2> Liste des Frais Forfait </h2></div>
        </div>
        <div class="panel-body">
            <table class="table">
              <thead> 
                    <tr>
                        <th class="id">Identifiant</th>
                        <th class="libelle">Libelle</th>
                        <th class="montant">Montant</th>
                        <th class="action">&nbsp;</th>                      
                    </tr>

                    <?php foreach($lesfraisforfaits as $fraisforfait)
                        {
                            $id = $fraisforfait['id'];
                            $libelle = $fraisforfait['libelle'];
                            $montant=$fraisforfait['montant'];                       
                    ?>  
                    <tr>
                        <td><?php echo $id ?></td>
                        <td><?php echo $libelle ?></td>
                        <td><?php echo $montant ?></td>
                        <td>
                            <?php echo '<a href="index.php?uc=menuCRUD&action=update&etape=first&idFrais='.$id.'"'.'
                                onclick="return confirm(\'Voulez-vous vraiment modifier ce frais?\');">Modifier</a>';
                            ?>

                            <?php echo '<a href="index.php?uc=menuCRUD&action=delete&idFrais='.$id.'"'.'
                                onclick="return confirm(\'Voulez-vous vraiment supprimer ce frais?\');">Supprimer</a></td>';
                            ?></tr> <?php   } ?>
                </table>
        </div>
    </div>  
</div>  



<! Partie pour la création d'un nouveau frais forfait !>

<div class="col-md-6">
    <div class="content-box-large">
        <div class="panel-heading">
            <legend>Création d'un Frais Forfait</legend>            
        </div>

        <div class="panel-body">
            <form class="form-horizontal" role="form" action="index.php?uc=menuCRUD&action=create" method="post">
                <div class="form-group">
                    <div class="form-group">

                    <label for="txtIdFF"> Identifiant : </label>
                    </br>
                    <input class="form-control" type="text" id="txtBIdFF" name="id" />
                    </br>
                    </br>

                    <label for="txtLibelleFF">Libellé :</label>
                    </br>
                    <input class="form-control" type="text" id="txtBLibelleFF" name="libelle" />
                    </br>
                    </br>

                    <label for="txtMontantFF">Montant : </label>
                    </br>
                    <input class="form-control" type="text" id="txtBMontantFF" name="montant" />
                    </br>
                    </br>
                </div>
                </div>
            <div class="horizontal-form">
                <input class="btn btn-primary" id="ajouter" type="submit" value="Ajouter" />
                <input class="btn btn-primary" id="effacer" type="reset" value="Effacer" />
      
            </div>
        
            </form>
                            
        </div>
    </div>
</div>   
       
  