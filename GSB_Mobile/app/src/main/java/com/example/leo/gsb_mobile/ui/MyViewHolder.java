package com.example.leo.gsb_mobile.ui;

import android.content.Intent;
import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.widget.TextView;

import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.object.CardView;

/**
 * Created by Leo on 28/03/2017.
 * Cette classe est nécessaire à la gestion de notre RecyclerView
 * Elle fonctionne de pair avec la classe MyAdapter
 */

public class MyViewHolder extends RecyclerView.ViewHolder{

    private TextView textViewNomM;
    private TextView textViewPrenomM;
    private TextView textViewAdresseC;
    private TextView textViewDistance;
    private int idMedecin;

    //itemView est la vue correspondante à 1 cellule
    public MyViewHolder(final View itemView) {
        super(itemView);
        // On associe nos éléments avec ceux du layout
        textViewNomM = (TextView) itemView.findViewById(R.id.nomMedecin);
        textViewPrenomM = (TextView) itemView.findViewById(R.id.prenomMedecin);
        textViewAdresseC = (TextView) itemView.findViewById(R.id.adresseCabinet);
        textViewDistance = (TextView) itemView.findViewById(R.id.distanceCabinet);

        // Lorsque l'on clique sur un CardView de la liste
        itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Cela déclanche un intent qui nous amène sur l'activité CreateVisite
                Intent i = new Intent(v.getContext(), CreateVisite.class);
                // On passe en Extra de l'intent les donnée dnt nous auront besoin dans l'activité CreateVisite
                i.putExtra("NOMMEDECIN", textViewNomM.getText().toString());
                i.putExtra("PRENOMMEDECIN", textViewPrenomM.getText().toString());
                i.putExtra("IDMEDECIN", ""+idMedecin+"");
                // On éxecute l'intent
                v.getContext().startActivity(i);
            }
        });
    }

    /**
     * Méthode qui remplit la cellule en fonction d'un objet CardView
     * Métohde appelé dans la classe MyAdapter
     * @param object
     */
    void bind(CardView object){
        // Associe a nos champs les valeurs de la CardView
        textViewNomM.setText(object.getNomMedecin());
        textViewPrenomM.setText(object.getPrenomMedecin());
        textViewAdresseC.setText(object.getAdresseCabinet());
        textViewDistance.setText(object.getDistance());
        idMedecin = object.getIdMedecin();
    }
}
