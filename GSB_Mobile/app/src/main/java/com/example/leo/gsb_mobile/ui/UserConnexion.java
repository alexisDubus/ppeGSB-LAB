package com.example.leo.gsb_mobile.ui;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.controleur.CabinetDAO;
import com.example.leo.gsb_mobile.controleur.MedecinDAO;
import com.example.leo.gsb_mobile.controleur.UtilisateurDAO;
import com.example.leo.gsb_mobile.controleur.VisiteDAO;
import com.example.leo.gsb_mobile.object.Utilisateur;
import com.example.leo.gsb_mobile.object.Visite;
import com.example.leo.gsb_mobile.web_services.GetUserFromBDD;
import com.example.leo.gsb_mobile.web_services.GetUserVersionFromBDD;
import com.example.leo.gsb_mobile.web_services.SetVisiteToBDD;

import org.json.JSONArray;
import org.json.JSONException;
import java.util.concurrent.ExecutionException;

/**
 * Created by Leo on 04/04/2017.
 */

public class UserConnexion extends Activity {

    public EditText editT_login;
    public EditText editT_mdp;
    public Button btn_connexion;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.user_connexion);

        Log.i("INFO","Application Démarré");

        // Récupération et associations des éléments
        editT_login = (EditText)findViewById(R.id.editText_login);
        editT_mdp = (EditText)findViewById(R.id.editText_mdp);
        btn_connexion = (Button)findViewById(R.id.btn_connexion);

        // ----------------- Déroulement des différents test -----------------

        UtilisateurDAO utilisateurDAO = new UtilisateurDAO(this);
        utilisateurDAO.open();

        // Vérification de si un utilisateur existe déja
        // Si il n'y en a pas, on passe directement a la suite, sinon on entre dans la boucle
        if(utilisateurDAO.count() >= 1){

            VisiteDAO visiteDAO = new VisiteDAO(this);
            visiteDAO.open();
            if (visiteDAO.count() > 0){
                dropAllVisiteToBDDMySQL(visiteDAO);
            }
            visiteDAO.close();

            // Récupération de l'utilisateur dans la BDD Sqlite
            Utilisateur unUser = utilisateurDAO.selectionner(0);
            String nom = unUser.getNom();
            String prenom = unUser.getPrenom();
            int versionOfUser = unUser.getNumVersion();
            Log.i("User From local", nom + " " + prenom);

            // Récupération du même utilisateur dans la BDD distante
            String url = "http://10.0.2.2:8888/PPEGSB_4.0_Mobile/webservices/getUserVersion_WS.php?nom="+nom+"&prenom="+prenom+"";
            GetUserVersionFromBDD getUserVersion = new GetUserVersionFromBDD(getApplicationContext(),url);
            getUserVersion.execute();
            try {
                String user = getUserVersion.get();
                JSONArray array = new JSONArray(user);
                Log.d("User From BDD : ",""+array+"");

                int i = 0;
                String id= array.getJSONObject(i).getString("id");
                String newNom= array.getJSONObject(i).getString("nom");
                String newPrenom= array.getJSONObject(i).getString("prenom");
                int versionFromBDD = array.getJSONObject(i).getInt("version");
                Utilisateur unNouveauUser = new Utilisateur(id,newNom,newPrenom,versionFromBDD);

                // On compare les numéros de version
                if (versionOfUser == versionFromBDD){
                    // Si ils sont égaux, on ne change rien
                    goToCardViewSelector();
                    Log.i("USER_VERSION", "Identique");
                } else {
                    Log.i("USER_VERSION", "Version Modifié");
                    // Sinon on supprime tous les cabinet et médecins
                    deleteAllCabinetFromBDD();
                    deleteAllMedecinsFromBDD();
                    // On supprime l'utilisateur et on le remplace par le nouveau
                    // (on change juste le numéro de version en soit)
                    changeUserInBDD(unNouveauUser);
                    goToCardViewSelector();
                }

            } catch (InterruptedException | ExecutionException | JSONException e) {e.printStackTrace();}
        }

        // --------------- OnClickListener sur le bouton ------------------

        btn_connexion.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String login = editT_login.getText().toString();
                String mdp = editT_mdp.getText().toString();

                UtilisateurDAO utilisateurDAO = new UtilisateurDAO(getApplicationContext());
                utilisateurDAO.open();

                // On vérifie si tout les champs sont remplis
                if (login.isEmpty() || mdp.isEmpty()){
                    Toast toast = Toast.makeText(getApplicationContext(), "Tout les champs doivent être remplit", Toast.LENGTH_LONG);
                    toast.setGravity(Gravity.CENTER, 0, 0);
                    toast.show();
                }
                else {
                    // On appele le web service (dans la tâche asynchrone)
                    String url = "http://10.0.2.2:8888/PPEGSB_4.0_Mobile/webservices/getUser_WS.php?login="+login+"&mdp="+mdp+"";
                    GetUserFromBDD getUser = new GetUserFromBDD(getApplicationContext(),url);
                    getUser.execute();
                    try {
                        String user = getUser.get();
                        // Si on ne récupère rien, c'est que les champs étaient faux
                        if (user.equals("[]\n")){
                            Toast toast = Toast.makeText(getApplicationContext(), "Login/MotDePasse Incorrect", Toast.LENGTH_LONG);
                            toast.setGravity(Gravity.CENTER, 0, 0);
                            toast.show();
                        } else{
                            // Sinon on ajoute l'utilisateur récupéré
                            JSONArray array = new JSONArray(user);
                            Log.d("utilisateur : ",""+array+"");

                            int i = 0;
                            String id= array.getJSONObject(i).getString("id");
                            String nom= array.getJSONObject(i).getString("nom");
                            String prenom= array.getJSONObject(i).getString("prenom");
                            int version = array.getJSONObject(i).getInt("version");
                            Utilisateur unUser = new Utilisateur(id,nom,prenom,version);
                            utilisateurDAO.ajouter(unUser);

                            // On change ensuite d'activité'
                            goToCardViewSelector();
                        }
                    } catch (InterruptedException | ExecutionException | JSONException e) {
                        e.printStackTrace();
                    }
                }

            }
        });
    }


    public void goToCardViewSelector(){
        Intent i = new Intent(getApplicationContext(), CardViewSelector.class);
        startActivity(i);
    }

    public void deleteAllMedecinsFromBDD (){
        MedecinDAO medecinDAO = new MedecinDAO(this);
        medecinDAO.open();
        medecinDAO.supprimer();
        Log.i("DELETE", "Medecin  supprimé");
        medecinDAO.close();
    }

    public void deleteAllCabinetFromBDD(){
        CabinetDAO cabinetDAO = new CabinetDAO(this);
        cabinetDAO.open();
        cabinetDAO.supprimer();
        Log.i("DELETE", "Cabinet  supprimé");
        cabinetDAO.close();
    }

    public void changeUserInBDD(Utilisateur unUser){
        UtilisateurDAO utilisateurDAO = new UtilisateurDAO(this);
        utilisateurDAO.open();
        utilisateurDAO.supprimer();
        Log.i("DELETE", "User supprimé");
        utilisateurDAO.ajouter(unUser);
        utilisateurDAO.close();
    }

    // Ajoute chaque visite local a la BDD distante
    // Puis les supprime de la BDD local
    private  void dropAllVisiteToBDDMySQL(VisiteDAO visiteDAO){
        for (int i = 0 ; i < visiteDAO.count() ; i++){
            // Récupère chaque visite
            Visite uneVisite = visiteDAO.selectionner(i);
            String dateVisite = uneVisite.getDateVisite();
            int rdvOrNot = uneVisite.getRdvOrNot();
            String idUser = uneVisite.getUserId();
            String idMedecin = uneVisite.getMedecinId();
            String heureArrive = uneVisite.getHeureArrive();
            String heureDebut = uneVisite.getHeureDebut();
            String heureFin = uneVisite.getHeureFin();

            // L'ajoute a la BDD distante grâce au WS
            String url = "http://10.0.2.2:8888/PPEGSB_4.0_Mobile/webservices/setVisite_WS.php?datevisite="+dateVisite+"&rdv="+rdvOrNot+"&idutilisateur="+idUser+"&idmedecin="+idMedecin+"&heurearrivee="+heureArrive+"&heurefin="+heureFin+"&heuredebut="+heureDebut+"";
            SetVisiteToBDD setVisite = new SetVisiteToBDD(getApplicationContext(), url);
            setVisite.execute();
        }

        // Puis on supprime toutes les visites
        visiteDAO.supprimer();
    }





}