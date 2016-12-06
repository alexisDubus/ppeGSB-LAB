<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en-US" lang="en-US">

<head>
    <title>Affichage des différents Forfaits</title>
    <meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
</head>
<body>
    <h1>Liste des forfaits</h1>

    <!  Partie pour la création créer ( INSERT )  !>
    <a href="?action=create">Ajouter un nouveau forfait</a>
    <table>
        <tr>
            <th>Identifiant</th>
            <th>Libelle</th>
            <th>Montant</th>
            
            <th><em>Action</em></th>
        </tr>

        <! Boucle qui récupere toutes le fraisforfait pour les afficher !>
        <?php foreach($fraisforfaits as $fraisforfait): ?>
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
</body>


</html>
