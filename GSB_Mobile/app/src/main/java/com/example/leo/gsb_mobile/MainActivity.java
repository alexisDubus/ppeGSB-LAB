package com.example.leo.gsb_mobile;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ProgressBar;

import com.example.leo.gsb_mobile.controleur.UtilisateurDAO;
import com.example.leo.gsb_mobile.object.Utilisateur;
import com.example.leo.gsb_mobile.web_services.GetMedecinFromBDD;

public class MainActivity extends Activity {

    private ProgressBar mProgressBar;
    private Button mButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        mButton = (Button)findViewById(R.id.btnLaunch);

        Utilisateur user = new Utilisateur("a131","Villechalane","Louis",1);
        UtilisateurDAO userDAO = new UtilisateurDAO(this);
        userDAO.ajouter(user);

        mButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                GetMedecinFromBDD traitement = new GetMedecinFromBDD(getApplicationContext());
                traitement.execute();
            }
        });



    }
}
