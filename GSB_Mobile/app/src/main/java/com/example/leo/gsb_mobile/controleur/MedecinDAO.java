package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;

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
        value.put(MedecinDAO.KEY, medecin.getIdMedecin());
        value.put(MedecinDAO.NAME, medecin.getNom());
        value.put(MedecinDAO.LASTNAME, medecin.getPrenom());
        value.put(MedecinDAO.CABINET_KEY, medecin.getIdCabinet());
        value.put(MedecinDAO.USER_KEY, medecin.getIdUtilisateur());
        mDb.insert(MedecinDAO.TABLE_NAME, null, value);
    }

    public void supprimer() {
       // mDb.delete(TABLE_NAME, KEY + " = " +id,null)
        mDb.delete(TABLE_NAME,null,null);
    }

    public Medecin selectionner(long id) {
        Cursor c = mDb.rawQuery("select * from " + TABLE_NAME + " where medecinId >= ?", new String[]{""+id+""});
        return cursorToMedecin(c);
    }

    private Medecin cursorToMedecin(Cursor c){

        if (c.getCount() == 0)
            return null;
        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée un Medecin
        Medecin unMedecin = new Medecin();

        unMedecin.setIdMedecin(c.getInt(0));
        unMedecin.setNom(c.getString(1));
        unMedecin.setPrenom(c.getString(2));
        unMedecin.setIdCabinet(c.getString(3));
        unMedecin.setIdUtilisateur(c.getString(4));

        c.close();
        return unMedecin;
    }

    public long count(){
        long numberOfRows = DatabaseUtils.queryNumEntries(mDb, TABLE_NAME);
        return numberOfRows;
    }
}
