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
import com.example.leo.gsb_mobile.object.Cabinet;
import com.example.leo.gsb_mobile.object.Medecin;
import com.example.leo.gsb_mobile.object.Utilisateur;

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

        editT_login = (EditText)findViewById(R.id.editText_login);
        editT_mdp = (EditText)findViewById(R.id.editText_mdp);
        btn_connexion = (Button)findViewById(R.id.btn_connexion);

        UtilisateurDAO utilisateurDAO = new UtilisateurDAO(this);
        MedecinDAO medecinDAO = new MedecinDAO(this);
        CabinetDAO cabinetDao = new CabinetDAO(this);

        // ----------------------------------
        cabinetDao.open();
        // Vérification de si il y a des cabinet dans la BDD
        if(cabinetDao.count() == 0){
            addCabinetInBDD(cabinetDao);
        }
        cabinetDao.close();
        // ----------------------------------
        medecinDAO.open();
        // Vérification de si il y a des medecin dans la BDD
        if(medecinDAO.count() == 0){
            addMedecinInBDD(medecinDAO);
        }
        medecinDAO.close();
        // ----------------------------------
        utilisateurDAO.open();
        // Vérification de si un utilisateur existe déja
        if(utilisateurDAO.count() == 1){
            goToCardViewSelector();
        }
        utilisateurDAO.close();
        // ----------------------------------


        btn_connexion.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String login = editT_login.getText().toString();
                String mdp = editT_mdp.getText().toString();

                UtilisateurDAO utilisateurDAO = new UtilisateurDAO(getApplicationContext());
                utilisateurDAO.open();

                if (login.isEmpty() || mdp.isEmpty()){
                    Toast toast = Toast.makeText(getApplicationContext(), "Tout les champs doivent être remplit", Toast.LENGTH_LONG);
                    toast.setGravity(Gravity.CENTER|Gravity.CENTER, 0, 0);
                    toast.show();
                }
                else {
                    // Récupération de l'utilisateur associé a ce login/mdp
                    // If utilisateur existe
                    Utilisateur unUser = new Utilisateur();
                    unUser.setUserId("a131");
                    unUser.setPrenom("Léo");
                    unUser.setNom("Marlière");
                    utilisateurDAO.ajouter(unUser);
                    utilisateurDAO.close();

                    //Log.i("CONNEXION", "Utilisateur créer");

                    goToCardViewSelector();
                }

            }
        });



    }

    private void addCabinetInBDD(CabinetDAO cabinetDAO){
        Cabinet cabinet1 = new Cabinet("198 rue de Lille", "59130", "Lambersart", 23.43 , 98.43);
        Cabinet cabinet2 = new Cabinet("1 rue Jean", "59000", "Lille", 23.43 , 98.43);
        Cabinet cabinet3 = new Cabinet("24 Rue Moulinette", "59000", "Lille", 23.43 , 98.43);
        Log.i("INFO_TESTFORLIST", "Cabinet crée");
        cabinetDAO.ajouter(cabinet1);
        cabinetDAO.ajouter(cabinet2);
        cabinetDAO.ajouter(cabinet3);
        Log.i("INFO_TESTFORLIST", "Cabinet ajouté a la BDD");
    }


    private void addMedecinInBDD(MedecinDAO medecinDAO){
        Medecin medecin1 = new Medecin("Paul", "Medecin1", "1", "a131");
        Medecin medecin2 = new Medecin("Sam", "Medecin2", "2", "a131");
        Medecin medecin3 = new Medecin("Max", "Medecin3", "1", "a131");
        Medecin medecin4 = new Medecin("Paul", "Medecin4", "0", "a131");
        Log.i("INFO_TESTFORLIST", "Médecin crée");
        medecinDAO.ajouter(medecin1);
        medecinDAO.ajouter(medecin2);
        medecinDAO.ajouter(medecin3);
        medecinDAO.ajouter(medecin4);
        Log.i("INFO_TESTFORLIST", "Medecin ajouté a la BDD");
    }


    public void goToCardViewSelector(){
        Intent i = new Intent(getApplicationContext(), CardViewSelector.class);
        startActivity(i);
    }




}
