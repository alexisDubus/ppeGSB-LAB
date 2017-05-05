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

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * Created by Leo on 29/03/2017.
 * Classe permettant de gérer notre activité createVisite
 * C'est cette activité qui va nous permettre de créer une visite
 */
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

        // Association des éléments de notre layout
        editT_dateVisite = (EditText)findViewById(R.id.editText_date);
        editT_heureDebut = (EditText)findViewById(R.id.editText_heureDebut);
        editT_heureFin = (EditText)findViewById(R.id.editText_heureFin);
        editT_heureArrive = (EditText)findViewById(R.id.editText_heureArrive);
        txtV_nomEtPrenomMedecin =(TextView)findViewById(R.id.txt_NomEtPrenomMedecin);
        chkBox_non = (CheckBox)findViewById(R.id.chkBox_non);
        chkBox_oui = (CheckBox)findViewById(R.id.chkBox_oui);
        btn_create= (Button)findViewById(R.id.btn_create);
        Log.i("CREATEVISITE", "Element associe");

        // Récupération de l'Intent
        Intent i = getIntent();
        // Récupération des extras
        String nomMedecin = i.getStringExtra("NOMMEDECIN");
        String prenomMedecin = i.getStringExtra("PRENOMMEDECIN");
        idMedecin = i.getStringExtra("IDMEDECIN");
        Log.i("CREATEVISITE", "Intent récuperé");

        // Récupération de l'idUser
        UtilisateurDAO utilisateurDAO = new UtilisateurDAO(this);
        // On ouvre la connexion a la table Utilisateur
        utilisateurDAO.open();
        Utilisateur unUser = utilisateurDAO.selectionner(0);
        idUser = unUser.getUserId();
        utilisateurDAO.close();
        // On ferme la connexion a la table Utilisateur

        // On affiche le nom et le prénom du médecin
        txtV_nomEtPrenomMedecin.setText(""+nomMedecin+" "+prenomMedecin+"");

        // ------------------------ OnClickListener -------------------------------

        // Lorsque on check la box NON, la box OUI se dé-check, et inversement
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

        /*
        // Lorsque on clique sur un editText, il se vide de son contenu
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
*/

        // Bouton ---------- Création de la Visite --------------
        btn_create.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                // Récupération des champs
                String dateVisite = editT_dateVisite.getText().toString();
                String heureArrive = editT_heureArrive.getText().toString();
                String heureDebut = editT_heureDebut.getText().toString();
                String heureFin = editT_heureFin.getText().toString();

                // On vérifie si au moins une checkBox est check
                if (chkBox_non.isChecked()){rdvOrNot = 0;checkBoxChecked = 1;}
                if (chkBox_oui.isChecked()){rdvOrNot = 1;checkBoxChecked = 1;}

                // On vérifie si les champs entrés correspondent au bon format
                boolean dateOk = isValidDate(dateVisite);
                boolean hourArriveOk = isValidHour(heureArrive);
                boolean hourDebutOk = isValidHour(heureDebut);
                boolean hourFinOk = isValidHour(heureFin);

                try {
                    // On converti les heures en format Date
                    SimpleDateFormat formatter = new SimpleDateFormat("HH:mm");
                    Date heureArriveDate = formatter.parse(heureArrive);
                    Date heureDebutDate = formatter.parse(heureDebut);
                    Date heureFinDate = formatter.parse(heureFin);

                    // On vérifie que tout les champs sont remplis
                    if (dateVisite.isEmpty() || heureArrive.isEmpty() || heureDebut.isEmpty() || heureFin.isEmpty() || checkBoxChecked == 0)
                    {showToast("Tout les champs doivent être remplit");}

                    // On compare les heures (raison pour laquelle on les transforme en format Date
                    else if (heureDebutDate.compareTo(heureArriveDate)<0)
                    {showToast("L'heure de début ne peut être supérieure a l'heure d'arrivé");}
                    else if (heureFinDate.compareTo(heureDebutDate)<0)
                    {showToast("L'heure de fin ne peut être supérieure a l'heure de début");}

                    // Si les valeurs entré correspondent au format voulu, on peut ensuite créer la viste
                    else if (dateOk && hourArriveOk && hourDebutOk && hourFinOk){
                        // Création et ajout de la visite
                        VisiteDAO visiteDAO = new VisiteDAO(context);
                        // On ouvre la connexion a la table visite
                        visiteDAO.open();

                        // On transforme les heure du format HH:MM vers le format AAAA/MM/JJ HH:MM:
                        // Ici, le "%20" correspond a un espace dans une requete URL
                        heureArrive = dateVisite + "%20" + heureArrive + ":00";
                        heureDebut = dateVisite + "%20" + heureDebut + ":00";
                        heureFin = dateVisite + "%20" + heureFin + ":00";

                        // On crée la visite
                        Visite uneVisite = new Visite(dateVisite, rdvOrNot, heureArrive, heureDebut, heureFin, idUser, idMedecin);
                        Log.i("CREATEVISITE", "Visite créer");
                        Log.i("VISITE", uneVisite.getDateVisite()+ " " + uneVisite.getHeureArrive() + " " + uneVisite.getHeureDebut() + " ");
                        // On ajoute la visite à la BDD locale
                        visiteDAO.ajouter(uneVisite);
                        Log.i("CREATEVISITE", "Visite ajouté");
                        visiteDAO.close();
                        // On ouvre la connexion a la table visite

                        // Retour sur l'activity CardViewSelector
                        Intent i = new Intent(getApplicationContext(), CardViewSelector.class);
                        startActivity(i);
                    }
                    else{
                        showToast("Un des champs est incorrect");
                    }

                } catch (ParseException e) {
                    e.printStackTrace();
                }


            }
        });
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

    /**
     * Vérifie si un String correspond au format voulu
     * Ici, le format voulu est une date en yyyy-MM-dd
     * @param dateString
     * @return vrai si le format correspond, faux dans le cas contraire
     */
    public boolean isValidDate(String dateString) {
        SimpleDateFormat df = new SimpleDateFormat("yyyy-MM-dd");
        try {
            df.parse(dateString);
            return true;
        } catch (ParseException e) {
            return false;
        }
    }

    /**
     * Vérifie si un String correspond au format voulu
     * Ici, le format voulu est une heure en HH:mm
     * @param dateString
     * @return vrai si le format correspond, faux dans le cas contraire
     */
    public boolean isValidHour(String dateString) {
        SimpleDateFormat df = new SimpleDateFormat("HH:mm");
        try {
            df.parse(dateString);
            return true;
        } catch (ParseException e) {
            return false;
        }
    }
}


