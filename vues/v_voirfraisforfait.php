<div class="col-md-6">
    <div class="content-box-large">
	   <div class="panel-heading">
            <div class="panel-title"><h2> Liste des Frais Forfait </h2></div>
        </div>
        <div class="panel-body">
            <table class="table">
              <thead> 
                    <tr>
                        <th class="libelle">Identifiant</th>
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
                            <a href="index.php?uc=menuCRUD&action=update&id='.$id.'"?>Modifier</a>

                            <?php echo '<a href="index.php?uc=menuCRUD&action=delete&idFrais='.$id.'"'.'
                                onclick="return confirm(\'Voulez-vous vraiment supprimer ce frais?\');">Supprimer</a></td>';
                            ?></tr> <?php   } ?>
                </table>
        </div>
    </div>  
</div>  



<div class="col-md-6">
    <div class="content-box-large">
        <div class="panel-heading">
            <legend>Création d'un Frais Forfait</legend>            
        </div>

        <div class="panel-body">
            <form class="form-horizontal" role="form" action="index.php?uc=menuCRUD&action=update" method="post">
                <div class="form-group">
                    <div class="form-group">

                    <label for="txtDateHF"> Identifiant : </label>
                    </br>
                    <input class="form-control" type="text" id="txtIdFF" name="id" />
                    </br>
                    </br>

                    <label for="txtLibelleHF">Libellé :</label>
                    </br>
                    <input class="form-control" type="text" id="txtLibelleFF" name="libelle" />
                    </br>
                    </br>

                    <label for="txtMontantHF">Montant : </label>
                    </br>
                    <input class="form-control" type="text" id="txtMontantFF" name="montant" />
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
       
  