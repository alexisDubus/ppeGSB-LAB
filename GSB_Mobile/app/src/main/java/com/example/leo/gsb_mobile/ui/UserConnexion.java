package com.example.leo.gsb_mobile.ui;

import android.Manifest;
import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.location.Criteria;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.ActivityCompat;
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
 * Classe permettant de gérer notre activité userConnexion
 * C'est l'activité qui se lance au lancement de l'application
 * C'est cette activité qui va nous permettre de nous connecter lors de notre première utilisation
 * C'est aussi elle qui va effectuer les différentes vérifications nécessaire (version/localisation...)
 */

public class UserConnexion extends Activity {

    public EditText editT_login;
    public EditText editT_mdp;
    public Button btn_connexion;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.user_connexion);

        Log.i("INFO", "Application Démarré");

        // Récupération et associations des éléments
        editT_login = (EditText) findViewById(R.id.editText_login);
        editT_mdp = (EditText) findViewById(R.id.editText_mdp);
        btn_connexion = (Button) findViewById(R.id.btn_connexion);

        // ----------------- Déroulement des différents test -----------------

        UtilisateurDAO utilisateurDAO = new UtilisateurDAO(this);
        // On ouvre la connexion à la table Utilisateur
        utilisateurDAO.open();

        // Vérification de si un utilisateur existe déja
        // Si il n'y en a pas, on doit donc passer par l'étape connexion
        // Sinon on entre dans la boucle afin de faire des vérifications
        if (utilisateurDAO.count() >= 1) {

            VisiteDAO visiteDAO = new VisiteDAO(this);
            // On ouvre la connexion à la table Visite
            visiteDAO.open();
            Log.i("VISITE", "" + visiteDAO.count() + "");
            // On regarde si la table Visite est vide
            if (visiteDAO.count() > 0) {
                // Si elle ne l'est pas, il appelle la méthode dropAllVisiteToBDDMySQL
                dropAllVisiteToBDDMySQL(visiteDAO);
            }
            // On ferme la connexion à la table Visite
            visiteDAO.close();

            // On ouvre la connexion à la table Utilisateur
            utilisateurDAO.open();
            // Récupération de l'utilisateur dans la BDD Sqlite
            Utilisateur unUser = utilisateurDAO.selectionner(0);
            String idUser = unUser.getUserId();
            String nom = unUser.getNom();
            String prenom = unUser.getPrenom();
            int versionOfUser = unUser.getNumVersion();
            double longitudeOld = unUser.getPosX();
            double latitudeOld = unUser.getPosY();
            Log.i("User From local", nom + " " + prenom + " : " + idUser);
            // On ferme la connexion à la table Utilisateur
            utilisateurDAO.close();

            // On récupère l'utilisateur de la BDD distante ayant le même idUser grâce à notre webservice
            String url = "http://172.16.8.15/PPEGSB4.0_Mobile/webservices/getUserVersion_WS.php?id=" + idUser + "";
            // On execute notre tâche Asynchrone éxecutant le webservice getUserVersion
            GetUserVersionFromBDD getUserVersion = new GetUserVersionFromBDD(getApplicationContext(), url);
            getUserVersion.execute();
            try {
                String user = getUserVersion.get();
                // Le résultat du webservice est stocké dans un array
                JSONArray array = new JSONArray(user);
                // On affiche l'array de l'utilisateur récuperé
                Log.d("User From BDD : ", "" + array + "");

                // Comment il n'y a qu'un utilisateur récuperer, i = 0
                int i = 0;
                // On récupère tout les paramètres de l'utilisateur
                String id = array.getJSONObject(i).getString("id");
                String newNom = array.getJSONObject(i).getString("nom");
                String newPrenom = array.getJSONObject(i).getString("prenom");
                int versionFromBDD = array.getJSONObject(i).getInt("version");
                // On crée ainsi un Utilisateur avec les données récuperées
                Utilisateur unNouveauUser = new Utilisateur(id, newNom, newPrenom, versionFromBDD);

                // On compare les numéros de version de l'utilisateur présent dans la BDD locale et celui de la BDD distante
                if (versionOfUser == versionFromBDD) {
                    // Dans les cas ou les versions sont identiques
                    // On vérifie les coordonnées

                    // On récupère la Localisation grâce a la méthode getLocation()
                    Location laPosition = getLocalisation();
                    // Si la Localisation n'est pas null (on arrive a récupérer une localisation)
                    if (laPosition != null) {
                        // On récupère la longitude et la latitude
                        double longitude = laPosition.getLongitude();
                        double latitude = laPosition.getLatitude();
                        // On compare les valeurs obtenues avec celles présent dans la BDD (récupérer précédament)
                        if (latitude != latitudeOld || longitude != longitudeOld) {
                            // Si elles sont différentes, on crée un nouveau utilisateur avec les nouvelles coordonéees
                            Utilisateur userWithNewPOS = new Utilisateur(id, nom, prenom, versionFromBDD, longitude, latitude);
                            // On remplace les utilisateurs dans la BDD locale (voir méthode changeUserInBDD)
                            changeUserInBDD(userWithNewPOS);
                            Log.i("USER_POSITION", "Coordonnées modifiées");
                        }
                    }
                    // Si on arrive pas à récupérer la localisation (laPosition=null), on ne fait rien de spécial
                    // On va ensuite vers l'activité CardViewSelector
                    goToCardViewSelector();
                    Log.i("USER_VERSION", "Identique");
                } else {
                    // Dans le cas ou les version ne sont pas identiques
                    Log.i("USER_VERSION", "Modifié");
                    // On supprime tout les cabinet et tout les médecins de la BDD locale
                    deleteAllCabinetFromBDD();
                    deleteAllMedecinsFromBDD();
                    // On supprime l'utilisateur et on le remplace par le nouveau
                    // (on change juste le numéro de version en soit)
                    changeUserInBDD(unNouveauUser);
                    Log.i("USER_VERSION", "User re-créer");
                    // On va ensuite vers l'activité CardViewSelector
                    goToCardViewSelector();
                }

            } catch (InterruptedException | ExecutionException | JSONException e) {
                e.printStackTrace();
            }
        }


        // --------------- OnClickListener sur le bouton ------------------

        // Dans le cas ou il n'y a pas encore d'utilisateur dans la BDD locale
        btn_connexion.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String login = editT_login.getText().toString();
                String mdp = editT_mdp.getText().toString();

                UtilisateurDAO utilisateurDAO = new UtilisateurDAO(getApplicationContext());
                // On ouvre la connexion a la table Utilisateur
                utilisateurDAO.open();

                // On vérifie si tout les champs sont remplis
                if (login.isEmpty() || mdp.isEmpty()) {
                    Toast toast = Toast.makeText(getApplicationContext(), "Tout les champs doivent être remplit", Toast.LENGTH_LONG);
                    toast.setGravity(Gravity.CENTER, 0, 0);
                    toast.show();
                } else {
                    String url = "http://172.16.8.15/PPEGSB4.0_Mobile/webservices/getUser_WS.php?login=" + login + "&mdp=" + mdp + "";
                    // On execute notre tâche Asynchrone éxecutant le webservice getUser
                    GetUserFromBDD getUser = new GetUserFromBDD(getApplicationContext(), url);
                    getUser.execute();
                    try {
                        String user = getUser.get();
                        // Si on ne récupère rien, c'est que les identifiants entrés sont faux
                        if (user.equals("[]\n")) {
                            Toast toast = Toast.makeText(getApplicationContext(), "Login/MotDePasse Incorrect", Toast.LENGTH_LONG);
                            toast.setGravity(Gravity.CENTER, 0, 0);
                            toast.show();
                        } else {
                            // Le résultat du webservice est stocké dans un array
                            JSONArray array = new JSONArray(user);
                            Log.d("utilisateur : ", "" + array + "");

                            // Comme il n'y a qu'un utilisateur récupérer, i = 0
                            int i = 0;
                            // On récupère tout les paramètres de l'utilisateur
                            String id = array.getJSONObject(i).getString("id");
                            String nom = array.getJSONObject(i).getString("nom");
                            String prenom = array.getJSONObject(i).getString("prenom");
                            int version = array.getJSONObject(i).getInt("version");

                            // On récupère ensuite la localistation
                            Location laPosition = getLocalisation();

                            if (laPosition != null) {
                                // Si on arrive a récupérer un localistation
                                double longitude = laPosition.getLongitude();
                                double latitude = laPosition.getLatitude();

                                // On crée et ajoute un utilisateur avec les différentes valeurs + longitude/latitude
                                Utilisateur unUser = new Utilisateur(id, nom, prenom, version, longitude, latitude);
                                utilisateurDAO.ajouter(unUser);
                            } else {
                                // Si on arrive pas a récupérer de localisation
                                // On crée et ajoute un utilisateur avec les différentes valeurs + position GPS de la TourEiffel
                                Utilisateur unUser = new Utilisateur(id, nom, prenom, version,  2.2945, 48.8584);
                                utilisateurDAO.ajouter(unUser);
                            }

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


    /**
     * Méthode permettant d'aller vers l'activité CardViewSelector
     */
    public void goToCardViewSelector() {
        Intent i = new Intent(getApplicationContext(), CardViewSelector.class);
        startActivity(i);
    }

    /**
     * Méthode supprimant tout les champs de la table Medecin
     */
    public void deleteAllMedecinsFromBDD() {
        MedecinDAO medecinDAO = new MedecinDAO(this);
        // On ouvre la connexion a la table Medecin
        medecinDAO.open();
        // On supprime tout les champs
        medecinDAO.supprimer();
        Log.i("DELETE", "Medecin  supprimé");
        // On ferme la connexion a la table Medecin
        medecinDAO.close();
    }

    /**
     * Méthode supprimant tout les champs de la table Cabinet
     */
    public void deleteAllCabinetFromBDD() {
        CabinetDAO cabinetDAO = new CabinetDAO(this);
        // On ouvre la connexion a la table Cabinet
        cabinetDAO.open();
        // On supprime tout les champs
        cabinetDAO.supprimer();
        Log.i("DELETE", "Cabinet  supprimé");
        // On ferme la connexion a la table Cabinet
        cabinetDAO.close();
    }

    /**
     * Méthode permettant de supprimer le contenu de la table utilisateur pour ensuite ajouter un nouveau utilisateur
     * @param unUser
     */
    public void changeUserInBDD(Utilisateur unUser) {
        UtilisateurDAO utilisateurDAO = new UtilisateurDAO(this);
        // On ouvre la connexion a la table Utilisateur
        utilisateurDAO.open();
        // On supprime tout les champs
        utilisateurDAO.supprimer();
        Log.i("DELETE", "User supprimé");
        // On ajoute dans la table l'utilisateur passé en paramètre
        utilisateurDAO.ajouter(unUser);
        // On ferme la connexion a la table Utilisateur
        utilisateurDAO.close();
    }

    /**
     * Pour chaque visite dans la table Visite
     * Crée la visite dans la BDD distante grâce au webservice setVisite
     * Supprime ensuite les visites de la BDD locale
     * @param visiteDAO
     */
    private void dropAllVisiteToBDDMySQL(VisiteDAO visiteDAO) {
        // Pour chaque visite de la BDD locale
        for (int i = 0; i < visiteDAO.count(); i++) {
            // Récupère la visite
            Visite uneVisite = visiteDAO.selectionner(i);
            String dateVisite = uneVisite.getDateVisite();
            int rdvOrNot = uneVisite.getRdvOrNot();
            String idUser = uneVisite.getUserId();
            String idMedecin = uneVisite.getMedecinId();
            String heureArrive = uneVisite.getHeureArrive();
            String heureDebut = uneVisite.getHeureDebut();
            String heureFin = uneVisite.getHeureFin();

            // L'ajoute à la BDD distante grâce à la tâche Asynchrone du webservice setVisite
            String url = "http://172.16.8.15/PPEGSB4.0_Mobile/webservices/setVisite_WS.php?datevisite=" + dateVisite + "&rdv=" + rdvOrNot + "&idutilisateur=" + idUser + "&idmedecin=" + idMedecin + "&heurearrivee=" + heureArrive + "&heuredepart=" + heureFin + "&heuredebut=" + heureDebut + "";
            SetVisiteToBDD setVisite = new SetVisiteToBDD(getApplicationContext(), url);
            setVisite.execute();
            Log.i("VISITE", "Visite du " + dateVisite + " crée");

        }
        // Puis on supprime toutes les visites
        visiteDAO.supprimer();
    }

    /**
     * Permet d'obtenir la localisation
     * On pourra ensuite récupérer la longitude/latitude
     * @return Location
     */
    @Nullable
    private Location getLocalisation() {

        LocationManager locationManager;
        String svcName = Context.LOCATION_SERVICE;
        locationManager = (LocationManager) getSystemService(svcName);
        Log.i("LOCATION", "locationManager" + locationManager + "");

        // Critère pour selectionner le meilleur fournisseur de position
        Criteria critere = new Criteria();
        critere.setAccuracy(Criteria.ACCURACY_COARSE);
        // Besoin de l'altitude : NON
        critere.setAltitudeRequired(false);
        // Besoin d'une precision : OUI
        critere.setBearingRequired(true);
        critere.setCostAllowed(false);
        // Energie consommé : MEDIUM
        critere.setPowerRequirement(Criteria.POWER_MEDIUM);
        critere.setSpeedRequired(false);
        Log.i("LOCATION", "Critère ok");

        // On obtient ainsi le meilleur fournisseur de position, en fonction des critères
        String provider = locationManager.getBestProvider(critere, true);
        Log.i("LOCATION", "provider" + provider + "");

        if (ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
            // Impossible de récuperer la position
            Toast.makeText(this, "First enable LOCATION ACCESS in settings.", Toast.LENGTH_LONG).show();
            return null;
        }
        else {
            // Sinon on récupère bien un objet Location
            Location l = locationManager.getLastKnownLocation(provider);
            locationManager.requestLocationUpdates(provider, 2000, 10, locationListener);
            Log.i("LOCATION", "Location = " + l + "");
            return l;
        }
    }

    private final LocationListener locationListener = new LocationListener() {
        public void onLocationChanged(Location location) {}
        public void onProviderDisabled(String provider) {}
        public void onProviderEnabled(String provider) {}
        public void onStatusChanged(String provider, int Status, Bundle extras) {}
    };


}






