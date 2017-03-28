package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;

import com.example.leo.gsb_mobile.object.Visite;

/**
 * Created by Leo on 27/03/2017.
 */

public class VisiteDAO extends DAOBase {

    public static final String TABLE_NAME = "Visite";
    public static final String KEY = "id";
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
        value.put(String.valueOf(visite.getDateVisite()), VisiteDAO.DATE);
        value.put(VisiteDAO.RDV, visite.isRdvOrNot());
        value.put(VisiteDAO.HOUR_ARRIVE, String.valueOf(visite.getHeureArrive()));
        value.put(VisiteDAO.HOUR_START, String.valueOf(visite.getHeureDebut()));
        value.put(VisiteDAO.HOUR_END, String.valueOf(visite.getHeureFin()));
        value.put(VisiteDAO.USER_KEY, visite.getUserId());
        value.put(VisiteDAO.MEDECIN_KEY, visite.getMedecinId());
        mDb.insert(CabinetDAO.TABLE_NAME, null, value);
    }

    public void supprimer(long id) {
        mDb.delete(TABLE_NAME, KEY + " = ?", new String[]{String.valueOf(id)});
    }

}





























































































