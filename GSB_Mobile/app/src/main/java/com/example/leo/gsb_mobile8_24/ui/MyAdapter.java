package com.example.leo.gsb_mobile8_24.ui;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.leo.gsb_mobile8_24.R;
import com.example.leo.gsb_mobile8_24.object.CardView;

import java.util.List;

/**
 * Created by Leo on 28/03/2017.
 * Cette classe est nécessaire a la gestion de notre RecyclerView
 * Elle fonctionne de pair avec la classe myViewHolder
 */

public class MyAdapter extends RecyclerView.Adapter<MyViewHolder> {

    List<CardView> myList;

    public MyAdapter(List<CardView> myList)
    {
        this.myList = myList;
    }

    //cette fonction permet de créer les viewHolder
    //et par la même indiquer la vue à inflater (à partir des layout xml)
    @Override
    public MyViewHolder onCreateViewHolder(ViewGroup viewGroup, int viewType) {
        View view = LayoutInflater.from(viewGroup.getContext()).inflate(R.layout.cardview,viewGroup,false);
        return new MyViewHolder(view);
    }


    @Override
    public void onBindViewHolder(MyViewHolder holder, int position) {
        // On recupère chaque CardView de la liste
        CardView myCardView = myList.get(position);
        // On récupère ensuite les informations de la CardView pour les afficher (voir MyViewHolder)
        holder.bind(myCardView);
    }

    @Override
    public int getItemCount() {
        return myList.size();
    }
}
