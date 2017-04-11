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

import com.example.leo.gsb_mobile.web_services.GetCabinetFromBDD;
import com.example.leo.gsb_mobile.web_services.GetMedecinFromBDD;

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


        addMedecinInList(medecinDAO, cabinetDAO);

        recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        recyclerView.setAdapter(new MyAdapter(medecins));

    }

    private void addMedecinInList(MedecinDAO medecinDAO, CabinetDAO cabinetDAO){
        String adresse;
        medecinDAO.open();
        for (int i = 0 ; i < medecinDAO.count() ;  i++) {
            Medecin unMedecin = medecinDAO.selectionner(i);
            Log.i("INFO_AJOUTERMEDECINS", ""+ unMedecin.getNom() + " " + unMedecin.getPrenom() +" séléctionné");
            medecinDAO.close();
            cabinetDAO.open();
            Cabinet unCabinet = cabinetDAO.selectionner(Long.parseLong(unMedecin.getIdCabinet()));
            adresse = unCabinet.getRue()+" "+unCabinet.getCodePostal()+" "+unCabinet.getVille();
            cabinetDAO.close();
            medecins.add(new CardView(unMedecin.getNom(), unMedecin.getPrenom(), adresse , unMedecin.getIdMedecin()));
            Log.i("INFO_AJOUTERMEDECINS", ""+ unMedecin.getNom() + " " + unMedecin.getPrenom() + " ajouté à la liste");
            medecinDAO.open();
        }
        Log.i("INFO_AJOUTERMEDECINS", "Connexion close");
    }



    private void getMedecinFromBDD(MedecinDAO medecinDAO) {
        // Vérification de si il y a des medecin dans la BDD
        GetMedecinFromBDD getMedecin = new GetMedecinFromBDD(this);
        getMedecin.execute();
        try {
            String lesMedecins = getMedecin.get();
            JSONArray array = new JSONArray(lesMedecins);
            Log.d("Mes medecins : ",""+array+"");
            Log.d("Nombres : ",""+array.length());

            for(int i = 0 ; i < array.length() ; i++) {
                String nom= array.getJSONObject(i).getString("nom");
                String prenom= array.getJSONObject(i).getString("prenom");
                String idCabinet= array.getJSONObject(i).getString("idcabinet");
                String idUtilisateur= array.getJSONObject(i).getString("idutilisateur");
                Medecin unMedecin = new Medecin(i,nom,prenom,idCabinet,idUtilisateur);
                medecinDAO.ajouter(unMedecin);
                Log.i("CREATE", "Medecin "+ unMedecin.getNom() + " " + unMedecin.getPrenom() + " crée");
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
            // On recupere un tableau JSON
            String lesCabinets = getCabinet.get();
            JSONArray array = new JSONArray(lesCabinets);
            Log.d("Mes Cabinets : ",""+array+"");
            Log.d("Nombres : ",""+array.length());

            // On parcourt le tableau et on recupere chaque valeurs
            for(int i = 0 ; i < array.length() ; i++){
                int id = array.getJSONObject(i).getInt("id");
                String rue= array.getJSONObject(i).getString("rue");
                String CP= array.getJSONObject(i).getString("CP");
                String ville= array.getJSONObject(i).getString("ville");
                double longitude = array.getJSONObject(i).getDouble("longitude");
                double latitude = array.getJSONObject(i).getDouble("longitude");
                // On crée ainsi un cabinet que l'on ajoute a la BDD
                Cabinet unCabinet = new Cabinet(id,rue,CP,ville,longitude,latitude);
                cabinetDAO.ajouter(unCabinet);
                Log.i("CREATE", "Cabinet crée");
                }

            } catch (InterruptedException | ExecutionException | JSONException e) {
                e.printStackTrace();
            }
    }



}
