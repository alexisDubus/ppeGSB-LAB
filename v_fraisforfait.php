<?php

include("vues/v_sommaire.php");
?>
    <h1>Liste des forfaits</h1>

    <--!  Partie pour la création créer ( INSERT )  -->
    <a href="?action=create">Ajouter un nouveau forfait</a>
    <table>
        <tr>
            <th>Identifiant</th>
            <th>Libelle</th>
            <th>Montant</th>
            
            <th><em>Action</em></th>
        </tr>

        <--! Boucle qui récupere toutes le fraisforfait pour les afficher -->
        <?php
        //$fraitForfaits;
        foreach($fraisforfaits as $fraisforfait): 
            //What?
        ?>
        <tr>
            <td><?php echo $fraisforfait['id'] ?></td>
            <td><?php echo $fraisforfait['libelle'] ?></td>
            <td><?php echo $fraisforfait['montant'] ?></td>
            <td>

                <!  Association des boutons Modifier/Supprimer aux actions uptate/delete !>
                <a href="?action=update&amp;id=<?php echo $fraisforfait['id'] ?>">Modifier</a>
                <a href="?action=delete&amp;id=<?php echo $fraisforfait['id'] ?>">Supprimer</a>
            </td>
        </tr>
        <?php endforeach; ?>
    </table>
    