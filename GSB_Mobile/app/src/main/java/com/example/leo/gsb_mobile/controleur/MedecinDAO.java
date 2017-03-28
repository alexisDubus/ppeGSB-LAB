package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;

import com.example.leo.gsb_mobile.object.Cabinet;
import com.example.leo.gsb_mobile.object.Medecin;

/**
 * Created by Leo on 27/03/2017.
 */

public class MedecinDAO extends DAOBase {

    public static final String TABLE_NAME = "Medecin";
    public static final String KEY = "medecinId";
    public static final String NAME = "medecinNom";
    public static final String LASTNAME = "medecinPrenom";
    public static final String CABINET_KEY = "cabinetId";
    public static final String USER_KEY = "utilisateurId";

    public MedecinDAO(Context pContext) {
        super(pContext);
    }

    public void ajouter (Medecin medecin){
        ContentValues value = new ContentValues();
        value.put(MedecinDAO.NAME, medecin.getNom());
        value.put(MedecinDAO.LASTNAME, medecin.getPrenom());
        value.put(MedecinDAO.CABINET_KEY, medecin.getIdCabinet());
        value.put(MedecinDAO.USER_KEY, medecin.getIdUtilisateur());
        mDb.insert(CabinetDAO.TABLE_NAME, null, value);
    }

    public void supprimer(long id) {
        mDb.delete(TABLE_NAME, KEY + " = ?", new String[]{String.valueOf(id)});
    }

    public Medecin selectionner(long id) {
        Cursor c = mDb.rawQuery("select * " + " from " + TABLE_NAME + " where medecinId > ?", new String[]{""+id+""});
        return cursorToMedecin(c);
    }

    private Medecin cursorToMedecin(Cursor c){
        if (c.getCount() == 0)
            return null;

        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée un Cabinet
        Medecin unMedecin = new Medecin();

        unMedecin.setNom(c.getString(1));
        unMedecin.setPrenom(c.getString(2));

        c.close();

        return unMedecin;
    }
}
