package com.example.leo.gsb_mobile.ui;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import com.example.leo.gsb_mobile.Constant;
import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.controleur.CabinetDAO;
import com.example.leo.gsb_mobile.controleur.MedecinDAO;
import com.example.leo.gsb_mobile.controleur.UtilisateurDAO;
import com.example.leo.gsb_mobile.controleur.VisiteDAO;
import com.example.leo.gsb_mobile.object.Cabinet;
import com.example.leo.gsb_mobile.object.CardView;
import com.example.leo.gsb_mobile.object.Medecin;
import com.example.leo.gsb_mobile.object.Utilisateur;
import com.example.leo.gsb_mobile.object.Visite;
import com.example.leo.gsb_mobile.web_services.GetCabinetFromBDD;
import com.example.leo.gsb_mobile.web_services.GetMedecinFromBDD;
import com.example.leo.gsb_mobile.web_services.SetVisiteToBDD;

import org.json.JSONArray;
import org.json.JSONException;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;
import java.util.concurrent.ExecutionException;


/**
 * Created by Leo on 28/03/2017.
 * Classe permettant de gérer notre activité CardViewSelector
 * C'est cette activité qui va nous afficher la liste de nos médecins
 */
public class CardViewSelector extends AppCompatActivity{

    // Liste de CardView que l'on va remplir dans addMedecinsInList
    private List<CardView> medecins = new ArrayList<>();
    // Bouton pour envoyer les visites sur le serveur
    private Button btn_dropVisite;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cardviewselector);

        btn_dropVisite=(Button)findViewById(R.id.btn_dropVisite);


        // On créer des instance de nos controlleurs
        // On les utilisera ensuite pour agir sur nos tables
        MedecinDAO medecinDAO = new MedecinDAO(this);
        CabinetDAO cabinetDAO = new CabinetDAO(this);
        UtilisateurDAO utilisateurDAO = new UtilisateurDAO(this);
        VisiteDAO visiteDAO = new VisiteDAO(getApplicationContext());

        // Il est possible que les tables Cabinet et Medecin soient vide
        // Cela arrive dans le cas on il y a un changement de version d'utilisateur (voir UserConnexion)
        // On doit donc effectuer des vérifications au lancement de l'activité

        // On vérifie si la table Cabinet possède des cabinets
        cabinetDAO.open();
        if (cabinetDAO.count() == 0){
            // Si non, on appelle la méthode getCabinetFromBdd
            getCabinetFromBdd(cabinetDAO);
        }
        cabinetDAO.close();

        // On vérifie si la table Medecin possède des médecins
        medecinDAO.open();
        if (medecinDAO.count() == 0) {
            // Si non, on appelle la méthode getMedecinFromBdd
            getMedecinFromBDD(medecinDAO);
        }
        medecinDAO.close();

        visiteDAO.open();
        if (visiteDAO.count() == 0){
            btn_dropVisite.setVisibility(View.GONE);
        } else {
            btn_dropVisite.setVisibility(View.VISIBLE);
        }
        visiteDAO.close();


        // On ajoute ensuite notre liste medecins des objects CardView
        // Ces objets sont créer en fonction des médecins et des cabinets présent dans la BDD locale
        addMedecinInList(medecinDAO, cabinetDAO, utilisateurDAO);

        // On récupère l'objet recyclerView de notre layout
        // Un recyclerView est une liste d'objet (ici de CardView)
        // Ca particularité est qu'il permet de récupérer une object sorti de l'écran lors du scroll pour le réutiliser
        // On évite ainsi les ralentissement en cas d'un grand nombre d'objet
        RecyclerView recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        // On passe ensuite au recycler un objet de la classe MyAdapter avec la liste des CardView en paramètre
        // L'objet MyAdapter va ensuite créer un objet MyViewHolder pour chaque CardView de la liste
        // L'objet MyViewHolder se charge ensuite d'attribuer les différentes valeurs de la CardView à notre layout cardView
        // Ainsi, on obtient une liste avec un CardView pour chaque médecin
        recyclerView.setAdapter(new MyAdapter(medecins));

        btn_dropVisite.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                VisiteDAO visiteDAO = new VisiteDAO(getApplicationContext());
                // On ouvre la connexion à la table Visite
                visiteDAO.open();
                Log.i("VISITE", "" + visiteDAO.count() + "");
                // On regarde si la table Visite est vide
                if (visiteDAO.count() > 0) {
                    // Si elle ne l'est pas, il appelle la méthode dropAllVisiteToBDDMySQL
                    dropAllVisiteToBDDMySQL(visiteDAO);
                } else{
                    // Crée le Toast
                    showToast("Aucune visite dans la BDD locale");
                }

                // On ferme la connexion à la table Visite
                visiteDAO.close();


            }
        });
    }

    /**
     * Cette méthode va créer un objet CardView pour chaque médecins présent dans la BDD local
     * Elle va ensuite ajouter cette CardView à la liste medecins
     * @param medecinDAO
     * @param cabinetDAO
     * @param utilisateurDAO
     */
    private void addMedecinInList(MedecinDAO medecinDAO, CabinetDAO cabinetDAO, UtilisateurDAO utilisateurDAO){
        String adresse;
        int distance = 0;

        // On ouvre la connexion à la table medecin
        medecinDAO.open();
        // Pour chaque médecins présent dans la table
        for (int i = 1 ; i <= medecinDAO.count() ;  i++) {

            // On sélectionne le médecin
            Medecin unMedecin = medecinDAO.selectionner(i);
            Log.i("INFO_AJOUTERMEDECINS", ""+ unMedecin.getNom() + " " + unMedecin.getPrenom() +" séléctionné");
            // On récupère l'idCabinet du médecin sélectionné
            int idCabinet = Integer.parseInt(unMedecin.getIdCabinet());
            // On ferme la connexion à la table medecin
            medecinDAO.close();

            // On ouvre la connexion à la table cabinet
            cabinetDAO.open();
            // On récupère le cabinet en fonction de l'idCabinet
            Cabinet unCabinet = cabinetDAO.selectionner(idCabinet-1);
            // On récupère les différents champs afn de créer une adresse
            adresse = unCabinet.getRue()+" "+unCabinet.getCodePostal()+" "+unCabinet.getVille();
            cabinetDAO.close();
            // On ferme la connexion à la table cabinet

            // On ouvre la connexion à la table utilisateur
            utilisateurDAO.open();
            // On sélectionne le seul utilisateur de la base (position 0)
            Utilisateur unUser = utilisateurDAO.selectionner(0);
            // On récupère ca longitude et latitude
            double longitude = unUser.getPosX();
            double latitude = unUser.getPosY();
            // Si Longitude et latitude = 0, c'est que la récupération de position ne c'est pas fait correctement
            if (longitude == 0 || latitude == 0){
                Log.i("Coordonnées GPS", "Longitude et latitude = 0");
            } else{
                // Sinon, on utilise la méthode getDistance pour obtenir la distance en Km entre l'utilisateur et le cabinet récuperer
                distance = getDistance(longitude, latitude, unCabinet.getPosX(), unCabinet.getPosY());
            }
            utilisateurDAO.close();
            // On ferme la connexion à la table utilisateur

            String sDistance = ""+distance+" KM";
            // On crée une objet CardView avec le nom, le prenom et l'id du médecin, l'adresse du cabinet et la distance
            // On ajout ensuite la CardView crée à la liste medecins
            medecins.add(new CardView(unMedecin.getNom(), unMedecin.getPrenom(), adresse , unMedecin.getIdMedecin(), sDistance));
            Log.i("INFO_AJOUTERMEDECINS", ""+ unMedecin.getNom() + " " + unMedecin.getPrenom() + " ajouté à la liste");

            // On ouvre ensuite la connexion a la table medecin car on en a besoin pour le test for
            medecinDAO.open();
        }

        // On signale ensuite que tous les médecins présent dans la BDD locale ont été ajouté
        Log.i("INFO_AJOUTERMEDECINS", "Tous les médecins ont été ajoutés");
    }


    /**
     * Méthode permettant de récuperer les médecins de la BDD distante grâce à un WebService
     * @param medecinDAO
     */
    private void getMedecinFromBDD(MedecinDAO medecinDAO) {
        // On appelle la tâche Asynchrone GetMedecinFromBDD
        GetMedecinFromBDD getMedecin = new GetMedecinFromBDD(this);
        getMedecin.execute();
        try {
            String lesMedecins = getMedecin.get();
            // Le résultat du webservice est stocké dans un array
            JSONArray array = new JSONArray(lesMedecins);
            // On affiche l'array et le nombre de médecins récuperer
            Log.d("Mes medecins : ",""+array+"");
            Log.d("Nombres : ",""+array.length());

            // On parcourt chaque médecins de l'array
            for(int i = 0 ; i < array.length() ; i++) {
                int key = i+1;
                // On récupère tout les paramètres du médecins
                int idMedecin= array.getJSONObject(i).getInt("id");
                String nom= array.getJSONObject(i).getString("nom");
                String prenom= array.getJSONObject(i).getString("prenom");
                String idCabinet= array.getJSONObject(i).getString("idcabinet");
                String idUtilisateur= array.getJSONObject(i).getString("idutilisateur");
                // On crée un objet médecin avec les valeurs récuperées
                Medecin unMedecin = new Medecin(key,idMedecin,nom,prenom,idCabinet,idUtilisateur);
                // On l'ajoute ensuite à la BDD locale
                medecinDAO.ajouter(unMedecin);
                Log.i("CREATE", unMedecin.getKey() +" Medecin "+ unMedecin.getNom() + " " + unMedecin.getPrenom() + "("+unMedecin.getIdMedecin()+ ") crée");
            }

        } catch (InterruptedException | ExecutionException | JSONException e) {
            e.printStackTrace();
        }
    }

    /**
     * Méthode permettant de récuperer les cabinets de la BDD distante grâce à un WebService
     * @param cabinetDAO
     */
    private void getCabinetFromBdd(CabinetDAO cabinetDAO){
        // On appelle la tâche Asynchrone GetCabinetFromBDD
        GetCabinetFromBDD getCabinet = new GetCabinetFromBDD(getApplicationContext());
        getCabinet.execute();
        try {
            String lesCabinets = getCabinet.get();
            // Le résultat du webservice est stocké dans un array
            JSONArray array = new JSONArray(lesCabinets);
            // On affiche l'array et le nombre de cabinets récuperer
            Log.d("Mes Cabinets : ",""+array+"");
            Log.d("Nombres : ",""+array.length());

            // On parcourt chaque cabinets de l'array
            for(int i = 0 ; i < array.length() ; i++){
                // On récupère tout les paramètres du cabinet
                int id = array.getJSONObject(i).getInt("id");
                String rue= array.getJSONObject(i).getString("rue");
                String CP= array.getJSONObject(i).getString("CP");
                String ville= array.getJSONObject(i).getString("ville");
                double longitude = array.getJSONObject(i).getDouble("longitude");
                double latitude = array.getJSONObject(i).getDouble("longitude");
                // On crée ainsi un cabinet que l'on ajoute à la BDD
                Cabinet unCabinet = new Cabinet(id,rue,CP,ville,longitude,latitude);
                cabinetDAO.ajouter(unCabinet);
                Log.i("CREATE", "Cabinet crée");
                }

            } catch (InterruptedException | ExecutionException | JSONException e) {
                e.printStackTrace();
            }
    }

    /**
     * Permet de calculer la distance (en KM) entre l'utilisateur et un cabinet
     * @param lat1 latitude de l'utilisateur
     * @param lng1 longitude de l'utilisateur
     * @param lat2 latitude du cabinet
     * @param lng2 longitude du cabinet
     * @return une distance
     */
    private int getDistance(double lat1, double lng1, double lat2, double lng2) {

        double earthRadius = 6371; // kilometer output
        double dLat = Math.toRadians(lat2-lat1);
        double dLng = Math.toRadians(lng2-lng1);
        double sindLat = Math.sin(dLat / 2);
        double sindLng = Math.sin(dLng / 2);

        double a = Math.pow(sindLat, 2) + Math.pow(sindLng, 2)
                * Math.cos(Math.toRadians(lat1)) * Math.cos(Math.toRadians(lat2));
        double c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1-a));
        double dist = earthRadius * c;

        int distance = (int)dist / 20; // output distance
        return distance;
    }

    /**
     * Pour chaque visite dans la table Visite
     * Crée la visite dans la BDD distante grâce au webservice setVisite
     * Supprime ensuite les visites de la BDD locale
     * @param visiteDAO
     */
    private void dropAllVisiteToBDDMySQL(VisiteDAO visiteDAO) {
        String result = null;
        // Pour chaque visite de la BDD locale
        for (int i = 0; i < visiteDAO.count(); i++) {
            // Récupère la visite
            Visite uneVisite = visiteDAO.selectionner(i);
            if (uneVisite != null){
                String dateVisite = uneVisite.getDateVisite();
                int rdvOrNot = uneVisite.getRdvOrNot();
                String idUser = uneVisite.getUserId();
                String idMedecin = uneVisite.getMedecinId();
                String heureArrive = uneVisite.getHeureArrive();
                String heureDebut = uneVisite.getHeureDebut();
                String heureFin = uneVisite.getHeureFin();

                // L'ajoute à la BDD distante grâce à la tâche Asynchrone du webservice setVisite
                String url = "http://"+Constant.ADRESS_IP_SERVER+ "/webservices/setVisite_WS.php?datevisite=" + dateVisite + "&rdv=" + rdvOrNot + "&idutilisateur=" + idUser + "&idmedecin=" + idMedecin + "&heurearrivee=" + heureArrive + "&heuredepart=" + heureFin + "&heuredebut=" + heureDebut;
                Log.i("URL",url);
                SetVisiteToBDD setVisite = new SetVisiteToBDD(getApplicationContext(), url);
                setVisite.execute();
                try {
                    result = setVisite.get();
                    if (!Objects.equals(result, "")){
                        Log.i("VISITE", "Visite du " + dateVisite + " crée");
                        showToast("Visite du "+ dateVisite + " envoyé à la BDD");
                        // Puis on supprime la visite
                        //visiteDAO.supprimer(i);
                    } else{
                        showToast("Aucune connexion Internet");
                    }
                } catch (InterruptedException | ExecutionException e) {
                    e.printStackTrace();
                }
            }
        }
        if ( result != ""){
            visiteDAO.supprimer();
            // Il n'y a plus de visite dans la BDD, on peut donc masquer le bouton
            btn_dropVisite.setVisibility(View.GONE);
        }
    }

    /**
     * Méthode permettant d'afficher un Toast avec le message entré
     * @param message
     */
    public void showToast( String message){
        // Crée le Toast
        Toast toast = Toast.makeText(getApplicationContext(), message, Toast.LENGTH_LONG);
        // Positionne le Toast au centre de l'écran
        toast.setGravity(Gravity.CENTER, 0, 0);
        // Affiche le Toast
        toast.show();
    }



}
