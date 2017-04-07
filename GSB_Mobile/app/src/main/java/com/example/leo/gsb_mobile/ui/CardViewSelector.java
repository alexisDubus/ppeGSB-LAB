package com.example.leo.gsb_mobile.ui;

import android.os.Bundle;

import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;

import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.controleur.CabinetDAO;
import com.example.leo.gsb_mobile.controleur.MedecinDAO;

import com.example.leo.gsb_mobile.controleur.VisiteDAO;
import com.example.leo.gsb_mobile.object.Cabinet;
import com.example.leo.gsb_mobile.object.CardView;
import com.example.leo.gsb_mobile.object.Medecin;

import com.example.leo.gsb_mobile.object.Visite;
import com.example.leo.gsb_mobile.web_services.GetCabinetFromBDD;
import com.example.leo.gsb_mobile.web_services.GetMedecinFromBDD;
import com.example.leo.gsb_mobile.web_services.SetVisiteToBDD;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ExecutionException;


/**
 * Created by Leo on 28/03/2017.
 */

public class CardViewSelector extends AppCompatActivity{

    private RecyclerView recyclerView;
    private List<CardView> medecins = new ArrayList<CardView>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cardviewselector);

        MedecinDAO medecinDAO = new MedecinDAO(this);
        CabinetDAO cabinetDAO = new CabinetDAO(this);
        VisiteDAO visiteDAO = new VisiteDAO(this);

        cabinetDAO.open();
        if (cabinetDAO.count() == 0){
            getCabinetFromBdd(cabinetDAO);
        }
        cabinetDAO.close();

        medecinDAO.open();
        if (medecinDAO.count() == 0) {
            getMedecinFromBDD(medecinDAO);
        }
        medecinDAO.close();

        visiteDAO.open();
        if (visiteDAO.count() > 0){
            dropAllVisiteToBDDMySQL(visiteDAO);
        }
        visiteDAO.close();

        addMedecinInList(medecinDAO, cabinetDAO);

        recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        recyclerView.setAdapter(new MyAdapter(medecins));

    }

    private void addMedecinInList(MedecinDAO medecinDAO, CabinetDAO cabinetDAO){
        String adresse;
        for (long x = 0; x<=3 ; x++) {
            medecinDAO.open();
            Medecin unMedecin = medecinDAO.selectionner(x);
            Log.i("INFO_AJOUTERMEDECINS", "Medecin séléctionné");
            cabinetDAO.open();
            Cabinet unCabinet = cabinetDAO.selectionner(Long.parseLong(unMedecin.getIdCabinet()));
            adresse = unCabinet.getRue()+" "+unCabinet.getCodePostal()+" "+unCabinet.getVille();
            medecins.add(new CardView(unMedecin.getNom(), unMedecin.getPrenom(), adresse , unMedecin.getIdMedecin()));
            Log.i("INFO_AJOUTERMEDECINS", "Medecin ajouté a la liste");
        }

        cabinetDAO.close();
        Log.i("INFO_AJOUTERMEDECINS", "Connexion close");
    }



    private void getMedecinFromBDD(MedecinDAO medecinDAO) {
        // Vérification de si il y a des medecin dans la BDD
        GetMedecinFromBDD getMedecin = new GetMedecinFromBDD(this);
        try {
            String lesMedecins = getMedecin.get();
            JSONArray array = new JSONArray(lesMedecins);
            Log.d("debogage ",""+array.length());

            for(int i = 0 ; i < array.length() ; i++) {
                String nom= array.getJSONObject(i).getString("nom");
                String prenom= array.getJSONObject(i).getString("prenom");
                String idCabinet= array.getJSONObject(i).getString("idcabinet");
                String idUtilisateur= array.getJSONObject(i).getString("idtilisateur");
                Medecin unMedecin = new Medecin(nom,prenom,idCabinet,idUtilisateur);
                medecinDAO.ajouter(unMedecin);
            }

        } catch (InterruptedException | ExecutionException | JSONException e) {
            e.printStackTrace();
        }
    }

    private void getCabinetFromBdd(CabinetDAO cabinetDAO){
        // Vérification de si il y a des cabinet dans la BDD
        GetCabinetFromBDD getCabinet = new GetCabinetFromBDD(this);
        getCabinet.execute();
        try {
            String lesCabinets = getCabinet.get();
            JSONArray array = new JSONArray(lesCabinets);
            Log.d("debogage ",""+array.length());

            for(int i = 0 ; i < array.length() ; i++) {
                String rue= array.getJSONObject(i).getString("rue");
                String CP= array.getJSONObject(i).getString("CP");
                String ville= array.getJSONObject(i).getString("ville");
                double longitude = array.getJSONObject(i).getDouble("longitude");
                double latitude = array.getJSONObject(i).getDouble("longitude");
                Cabinet unCabinet = new Cabinet(rue,CP,ville,longitude,latitude);
                cabinetDAO.ajouter(unCabinet);
                }

            } catch (InterruptedException | ExecutionException | JSONException e) {
                e.printStackTrace();
            }
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
            String url = "http://10.0.2.2:8888/PPEGSB_4.0_Mobile/webservices/setVisite_WS.php?datevisite="+dateVisite+"&rdv=+"+rdvOrNot+"&idutilisateur="+idUser+"&idmedecin="+idMedecin+"&heurearrivee="+heureArrive+"&heurefin="+heureFin+"&heuredebut="+heureDebut+"";
            SetVisiteToBDD setVisite = new SetVisiteToBDD(getApplicationContext(), url);
            setVisite.execute();
        }

        // Puis on supprime toutes les visites
        for (int i = 0 ; i < visiteDAO.count() ; i++){
            visiteDAO.supprimer(i);
        }

    }


}
