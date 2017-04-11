package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;

import com.example.leo.gsb_mobile.object.Utilisateur;
import com.example.leo.gsb_mobile.object.Visite;

/**
 * Created by Leo on 27/03/2017.
 */

public class VisiteDAO extends DAOBase {

    public static final String TABLE_NAME = "Visite";
    public static final String KEY = "visiteId";
    public static final String DATE = "visiteDateArrive";
    private static final String RDV = "visiteRdv";
    private static final String HOUR_ARRIVE = "visiteHeureArrive";
    private static final String HOUR_START = "visiteHeureDebut";
    private static final String HOUR_END = "visiteHeureFin";
    private static final String USER_KEY = "utilisateurId";
    private static final String MEDECIN_KEY = "medecinId";

    public VisiteDAO(Context pContext) {
        super(pContext);
    }


    public void ajouter (Visite visite){
        ContentValues value = new ContentValues();
        value.put(VisiteDAO.DATE, visite.getDateVisite());
        value.put(VisiteDAO.RDV, visite.getRdvOrNot());
        value.put(VisiteDAO.HOUR_ARRIVE, visite.getHeureArrive());
        value.put(VisiteDAO.HOUR_START, visite.getHeureDebut());
        value.put(VisiteDAO.HOUR_END, visite.getHeureFin());
        value.put(VisiteDAO.USER_KEY, visite.getUserId());
        value.put(VisiteDAO.MEDECIN_KEY, visite.getMedecinId());
        mDb.insert(VisiteDAO.TABLE_NAME, null, value);
    }

    public void supprimer() {
        //mDb.delete(TABLE_NAME, KEY + " = ?", new String[]{String.valueOf(id)});
        mDb.delete(TABLE_NAME,null,null);
    }

    public Visite selectionner(long id) {
        Cursor c = mDb.rawQuery("select * from " + TABLE_NAME + " where visiteId > ?", new String[]{""+id+""});
        return cursorToVisite(c);

    }

    private Visite cursorToVisite(Cursor c){
        if (c.getCount() == 0)
            return null;



        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée une visite
        Visite uneVisite = new Visite();

        uneVisite.setVisiteId(c.getString(0));
        uneVisite.setDateVisite(c.getString(1));
        uneVisite.setRdvOrNot(c.getInt(2));
        uneVisite.setHeureArrive(c.getString(3));
        uneVisite.setHeureDebut(c.getString(4));
        uneVisite.setHeureFin(c.getString(5));
        uneVisite.setUserId(c.getString(6));
        uneVisite.setMedecinId(c.getString(7));

        c.close();
        return uneVisite;
    }


    public long count(){
        long numberOfRows = DatabaseUtils.queryNumEntries(mDb, TABLE_NAME);
        return numberOfRows;
    }

}





























































































