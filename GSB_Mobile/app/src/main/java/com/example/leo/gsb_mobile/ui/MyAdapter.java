package com.example.leo.gsb_mobile.ui;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.leo.gsb_mobile.R;
import com.example.leo.gsb_mobile.object.CardView;

import java.util.List;



/**
 * Created by Leo on 28/03/2017.
 */

public class MyAdapter extends RecyclerView.Adapter<MyViewHolder> {


    List<CardView> myList;

    public MyAdapter(List<CardView> myList) {
        this.myList = myList;
    }

    //cette fonction permet de créer les viewHolder
    //et par la même indiquer la vue à inflater (à partir des layout xml)
    @Override
    public MyViewHolder onCreateViewHolder(ViewGroup viewGroup, int viewType) {
        View view = LayoutInflater.from(viewGroup.getContext()).inflate(R.layout.cardview,viewGroup,false);
        return new MyViewHolder(view);
    }

    //c'est ici que nous allons remplir notre cellule avec le texte de chaque MyObject
    @Override
    public void onBindViewHolder(MyViewHolder holder, int position) {
        CardView myCardView = myList.get(position);
        holder.bind(myCardView);
    }

    @Override
    public int getItemCount() {
        return myList.size();
    }
}
