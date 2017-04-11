package com.example.leo.gsb_mobile.ui;

import android.content.Intent;
import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.widget.TextView;

import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.object.CardView;

/**
 * Created by Leo on 28/03/2017.
 */

public class MyViewHolder extends RecyclerView.ViewHolder{

    private TextView textViewNomM;
    private TextView textViewPrenomM;
    private TextView textViewAdresseC;
    public int idMedecin;

    //itemView est la vue correspondante à 1 cellule
    public MyViewHolder(final View itemView) {
        super(itemView);
        textViewNomM = (TextView) itemView.findViewById(R.id.nomMedecin);
        textViewPrenomM = (TextView) itemView.findViewById(R.id.prenomMedecin);
        textViewAdresseC = (TextView) itemView.findViewById(R.id.adresseCabinet);

        itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(v.getContext(), CreateVisite.class);
                i.putExtra("NOMMEDECIN", textViewNomM.getText().toString());
                i.putExtra("PRENOMMEDECIN", textViewPrenomM.getText().toString());
                i.putExtra("IDMEDECIN", ""+idMedecin+"");
                v.getContext().startActivity(i);
            }
        });
    }

    // Méthode qui remplit la cellule en fonction d'un objet CardView
    public void bind(CardView object){
        textViewNomM.setText(object.getNomMedecin());
        textViewPrenomM.setText(object.getPrenomMedecin());
        textViewAdresseC.setText(object.getAdresseCabinet());
        idMedecin = object.getIdMedecin();
    }
}
