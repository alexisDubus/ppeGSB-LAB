package com.example.leo.gsb_mobile.ui;

import android.os.Bundle;

import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;

import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.controleur.CabinetDAO;
import com.example.leo.gsb_mobile.controleur.MedecinDAO;
import com.example.leo.gsb_mobile.controleur.UtilisateurDAO;
import com.example.leo.gsb_mobile.object.Cabinet;
import com.example.leo.gsb_mobile.object.CardView;
import com.example.leo.gsb_mobile.object.Medecin;
import com.example.leo.gsb_mobile.object.Utilisateur;
import com.example.leo.gsb_mobile.web_services.GetMedecinFromBDD;

import java.util.ArrayList;
import java.util.List;


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
        CabinetDAO cabinetDao = new CabinetDAO(this);

        //getMedecinFromBDD();

        addMedecinInList(medecinDAO, cabinetDao);

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




    private void getMedecinFromBDD(){
        new GetMedecinFromBDD(this).execute();
    }


}
