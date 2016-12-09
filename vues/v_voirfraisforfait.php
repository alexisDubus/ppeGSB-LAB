<div class="col-md-6">
    <div class="content-box-large">
	   <div class="panel-heading">
            <div class="panel-title"><h2> Liste des Frais Forfait </h2></div>
        </div>
        <div class="panel-body">
                <a href="?action=create">Ajouter un nouvel article</a>

                <table>  
                    <tr>
                        <th>Identifiant</th>
                        <th>Libelle</th>
                        <th>Montant</th>                       
                    </tr>

                    <?php foreach($lesfraisforfaits as $fraisforfait): ?>
                    <tr>
                        <td><?php echo $fraisforfait['id'] ?></td>
                        <td><?php echo $fraisforfait['libelle'] ?></td>
                        <td><?php echo $fraisforfait['montant'] ?></td>
                        <td>
                            <a href="?action=update&amp;id=<?php echo $fraisforfait['id'] ?>">Modifier</a>                           
                            <a href="?action=delete&amp;id=<?php echo $fraisforfait['id'] ?>">Supprimer</a>
                        </td>
                        <td></td>
                    </tr>
                    <?php endforeach; ?>
                </table>
        </div>
    </div>  
</div>      
       
  