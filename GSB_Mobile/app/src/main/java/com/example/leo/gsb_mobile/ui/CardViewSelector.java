package com.example.leo.gsb_mobile.ui;

import android.os.Bundle;

import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;

import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.controleur.CabinetDAO;
import com.example.leo.gsb_mobile.controleur.DAOBase;
import com.example.leo.gsb_mobile.controleur.MedecinDAO;
import com.example.leo.gsb_mobile.object.Cabinet;
import com.example.leo.gsb_mobile.object.CardView;
import com.example.leo.gsb_mobile.object.Medecin;

import java.util.ArrayList;
import java.util.List;


/**
 * Created by Leo on 28/03/2017.
 */

public class CardViewSelector extends AppCompatActivity{

    private RecyclerView recyclerView;
    private List<CardView> medecins = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cardviewselector);

        MedecinDAO medecinDAO = new MedecinDAO(this);
        medecinDAO.open();
        Log.i("INFO", "medecinDAO open");

        CabinetDAO cabinetDao = new CabinetDAO(this);
        cabinetDao.open();
        Log.i("INFO", "cabinetDAO open");

        testForList(medecinDAO, cabinetDao);
        ajouterMedecins(medecinDAO, cabinetDao);

        recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        recyclerView.setAdapter(new MyAdapter(medecins));

    }

    private void ajouterMedecins(MedecinDAO medecinDAO, CabinetDAO cabinetDAO){
        for (long x = 1 ; x<=4 ; x++) {
            Medecin unMedecin = medecinDAO.selectionner(x);
            Log.i("INFO_AJOUTERMEDECINS", "Medecin séléctionné");
            Cabinet unCabinet = cabinetDAO.selectionner(Long.parseLong(unMedecin.getIdCabinet()));
            String adresse = ""+unCabinet.getRue()+" "+unCabinet.getCodePostal()+" "+unCabinet.getVille()+" ";
            medecins.add(new CardView(unMedecin.getNom(), unMedecin.getPrenom(), adresse ));
            Log.i("INFO_AJOUTERMEDECINS", "Medecin ajouté a la liste");
        }

        medecinDAO.close();
        cabinetDAO.close();
        Log.i("INFO_AJOUTERMEDECINS", "Connexion close");
    }

    private void testForList(MedecinDAO medecinDAO, CabinetDAO cabinetDAO){
        Medecin medecin1 = new Medecin("Paul", "Medecin1", "1", "a131");
        Medecin medecin2 = new Medecin("Sam", "Medecin2", "1", "a131");
        Medecin medecin3 = new Medecin("Max", "Medecin3", "1", "a131");
        Medecin medecin4 = new Medecin("Paul", "Medecin4", "1", "a131");
        Cabinet cabinet1 = new Cabinet("198 rue de Lille", 59130, "Lambersart", 23.43 , 98.43);
        Cabinet cabinet2 = new Cabinet("1 rue Jean", 59000, "Lille", 23.43 , 98.43);
        Log.i("INFO_TESTFORLIST", "objet crée");
        medecinDAO.ajouter(medecin1);
        medecinDAO.ajouter(medecin2);
        medecinDAO.ajouter(medecin3);
        medecinDAO.ajouter(medecin4);
        Log.i("INFO_TESTFORLIST", "Medecin ajouté a la BDD");
        cabinetDAO.ajouter(cabinet1);
        cabinetDAO.ajouter(cabinet2);
        Log.i("INFO_TESTFORLIST", "Cabinet ajouté a la BDD");

    }


}
