<!DOCTYPE html>
<html lang="fr">
<head>
    <title>Menu d'administration du laboratoire GSB</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <!-- Bootstrap -->
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- styles -->
    <link href="css/styles.css" rel="stylesheet">
    <meta charset="UTF-8">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
    <![endif]-->
  </head>

  <body background="assets/img/laboratoire.jpg">

      <!-- **********************************************************************************************************************************************************
      MAIN CONTENT
      *********************************************************************************************************************************************************** -->

<div class="page-content container">
	<div class="row">
		<div class="col-md-4 col-md-offset-4">
			<div class="login-wrapper">
				<div class="box">
					<div class="content-wrap">
						<legend>Création du nouveau mot de passe</legend>
							<form method="post" action="index.php?uc=connexion&action=nouveauMDP" role='form'>
                                                            <p>Entrez votre nouveau mot de passe :</p>
                                                            <input name="mdp" class="form-control" type="password" placeholder="Mot de passe">
                                                            </br>
                                                            <p>Entrez de nouveau votre mot de passe :</p>
                                                            <input name="mdp2" class="form-control" type="password" placeholder="Confirmation mot de passe">
                                                            </br>
                                                            <input type="submit" class="btn btn-primary signup" value="Valider">
                                                            </br>
							</form>
							</br>
					</div>							
				</div>
			</div>
		</div>
	</div>
</div>

  <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://code.jquery.com/jquery.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/custom.js"></script>
  </body>
</html>