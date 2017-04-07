package com.example.leo.gsb_mobile.ui;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.controleur.UtilisateurDAO;
import com.example.leo.gsb_mobile.controleur.VisiteDAO;
import com.example.leo.gsb_mobile.object.Utilisateur;
import com.example.leo.gsb_mobile.object.Visite;

public class CreateVisite extends Activity {

    public EditText editT_dateVisite;
    public EditText editT_heureDebut;
    public EditText editT_heureFin;
    public EditText editT_heureArrive;
    public CheckBox chkBox_oui;
    public CheckBox chkBox_non;

    public TextView txtV_nomEtPrenomMedecin;

    private String idMedecin;
    public String idUser;

    public int rdvOrNot ;
    public int checkBoxChecked = 0;

    public Button btn_create;

    public Context context = this;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.create_visite);

        // Association des éléments
        editT_dateVisite = (EditText)findViewById(R.id.editText_date);
        editT_heureDebut = (EditText)findViewById(R.id.editText_heureDebut);
        editT_heureFin = (EditText)findViewById(R.id.editText_heureFin);
        editT_heureArrive = (EditText)findViewById(R.id.editText_heureArrive);
        txtV_nomEtPrenomMedecin =(TextView)findViewById(R.id.txt_NomEtPrenomMedecin);
        chkBox_non = (CheckBox)findViewById(R.id.chkBox_non);
        chkBox_oui = (CheckBox)findViewById(R.id.chkBox_oui);
        btn_create= (Button)findViewById(R.id.btn_create);
        Log.i("CREATEVISITE", "Element associe");

        // Récupération des données dans l'Intent
        Intent i = getIntent();
        String nomMedecin = i.getStringExtra("NOMMEDECIN");
        String prenomMedecin = i.getStringExtra("PRENOMMEDECIN");
        idMedecin = i.getStringExtra("IDMEDECIN");
        Log.i("CREATEVISITE", "Intent récuperé");

        // Récupération de l'idUser
        UtilisateurDAO utilisateurDAO = new UtilisateurDAO(this);
        utilisateurDAO.open();
        Utilisateur unUser = utilisateurDAO.selectionner(0);
        idUser = unUser.getUserId();
        utilisateurDAO.close();

        txtV_nomEtPrenomMedecin.setText(""+nomMedecin+" "+prenomMedecin+"");

        // ------------------------ OnClickListener -------------------------------

        // CheckBox
        chkBox_oui.setOnClickListener(new View.OnClickListener() {
           @Override
           public void onClick(View v) {
               chkBox_non.setChecked(false);
           }
        });
        chkBox_non.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                chkBox_oui.setChecked(false);
            }
        });

        // editText
        editT_heureDebut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {editT_heureDebut.getText().clear();
            }
        });
        editT_heureFin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {editT_heureFin.getText().clear();
            }
        });
        editT_heureArrive.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {editT_heureArrive.getText().clear();
            }
        });
        editT_dateVisite.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {editT_dateVisite.getText().clear();
            }
        });

        // Bouton ---------- Création de la Visite --------------
        btn_create.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                // Récupération des champs
                String dateVisite = editT_dateVisite.getText().toString();
                String heureArrive = editT_heureArrive.getText().toString();
                String heureDebut = editT_heureDebut.getText().toString();
                String heureFin = editT_heureFin.getText().toString();

                // Vérifications
                if (chkBox_non.isChecked()){rdvOrNot = 0;checkBoxChecked = 1;}
                if (chkBox_oui.isChecked()){rdvOrNot = 1;checkBoxChecked = 1;}

                if (dateVisite.isEmpty() || heureArrive.isEmpty() || heureDebut.isEmpty() || heureFin.isEmpty() || checkBoxChecked == 0){
                    Toast toast = Toast.makeText(getApplicationContext(), "Tout les champs doivent être remplit", Toast.LENGTH_LONG);
                    toast.setGravity(Gravity.CENTER|Gravity.CENTER, 0, 0);
                    toast.show();
                }else{
                    // Création et ajout de la visite
                    VisiteDAO visiteDAO = new VisiteDAO(context);
                    visiteDAO.open();
                    Visite uneVisite = new Visite(dateVisite, rdvOrNot, heureArrive, heureDebut, heureFin, idUser, idMedecin);
                    Log.i("CREATEVISITE", "Visite créer");
                    visiteDAO.ajouter(uneVisite);
                    Log.i("CREATEVISITE", "Visite ajouté");
                    visiteDAO.close();

                    // Retour sur l'activity List
                    Intent i = new Intent(getApplicationContext(), CardViewSelector.class);
                    startActivity(i);
                }
            }
        });
    }
}
