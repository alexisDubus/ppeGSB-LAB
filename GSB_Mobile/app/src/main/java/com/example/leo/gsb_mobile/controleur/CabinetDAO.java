package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;

import com.example.leo.gsb_mobile.object.Cabinet;

/**
 * Created by Leo on 26/03/2017.
 */

public class CabinetDAO extends DAOBase {

    public static final String TABLE_NAME = "Cabinet";
    public static final String KEY = "cabinetId";
    public static final String STREET = "cabinetRue";
    public static final String CP = "cabinetCP";
    public static final String TOWN = "cabinetVille";
    public static final String POSX = "cabinetPosX";
    public static final String POSY = "cabinetPosY";

    public CabinetDAO(Context pContext) {
        super(pContext);
    }

    public void ajouter(Cabinet cabinet) {
        // Ajout d'un cabinet dans la table Cabinet
        ContentValues value = new ContentValues();
        value.put(CabinetDAO.STREET, cabinet.getRue());
        value.put(CabinetDAO.CP, cabinet.getCodePostal());
        value.put(CabinetDAO.TOWN, cabinet.getVille());
        value.put(CabinetDAO.POSX, cabinet.getPosX());
        value.put(CabinetDAO.POSY, cabinet.getPosY());
        mDb.insert(CabinetDAO.TABLE_NAME, null, value);
    }

    public void supprimer(long id) {
        // Suppresssion d'un Cabinet
        mDb.delete(TABLE_NAME, KEY + " = ?", new String[]{String.valueOf(id)});
    }


    public int modifier(long id, Cabinet cabinet) {
        // CODE
        ContentValues values = new ContentValues();
        values.put(STREET, cabinet.getRue());
        values.put(CP, cabinet.getCodePostal());
        values.put(TOWN, cabinet.getVille());
        values.put(POSX, cabinet.getPosX());
        values.put(POSY, cabinet.getPosY());
        return mDb.update(TABLE_NAME, values, KEY + " = " +id, null);
    }

    public Cabinet selectionner(long id) {
        Cursor c = mDb.rawQuery("select cabinetRue, cabinetCP, cabinetVille, cabinetPosX, cabinetPosY from " + TABLE_NAME + " where cabinetId > ?", new String[]{""+id+""});
        return cursorToCabinet(c);
    }

    private Cabinet cursorToCabinet(Cursor c){
        if (c.getCount() == 0)
            return null;

        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée un Cabinet
        Cabinet unCabinet = new Cabinet();

        unCabinet.setRue(c.getString(0));
        unCabinet.setCodePostal(c.getString(1));
        unCabinet.setVille(c.getString(2));
        unCabinet.setPosX(c.getDouble(3));
        unCabinet.setPosY(c.getDouble(4));

        c.close();

        return unCabinet;
    }

    public long count(){
        long numberOfRows = DatabaseUtils.queryNumEntries(mDb, TABLE_NAME);
        return numberOfRows;
    }


}

