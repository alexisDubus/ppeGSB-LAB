
<! Partie pour l'affichage d'un frais forfait !>

<div class="col-md-6">
    <div class="content-box-large">
        <div class="panel-heading">
            <legend>Modification du Frais Forfait  <?php 
            echo $id?> :</legend>            
        </div>

        <div class="panel-body">
            <form class="form-horizontal" role="form" action="index.php?uc=menuCRUD&action=update&etape=second&idFrais=<?php echo $_REQUEST['idFrais']?>" method="post">
                <div class="form-group">
                    <div class="form-group">

                    <label for="txtDateHF"> Identifiant : </label>
                    </br>
                    <input class="form-control" type="text" id="txtIdFF" name="id"  />
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
                <input class="btn btn-primary" id="ajouter" type="submit" value="Confirmer" />
                <input class="btn btn-primary" id="effacer" type="reset" value="Effacer" />
  
            </div>
        
            </form>
                            
        </div>
    </div>
</div>   
   