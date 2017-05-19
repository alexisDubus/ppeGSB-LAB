package com.example.leo.gsb_mobile8_24.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;
import android.support.annotation.Nullable;

import com.example.leo.gsb_mobile8_24.object.Cabinet;

/**
 * Created by Leo on 26/03/2017.
 * Objet controlleur qui permet d'agir sur la table Cabinet de la BDD locale
 */
public class CabinetDAO extends DAOBase {

    // Création des constantes du nom des champs de la BDD
    private static final String TABLE_NAME = "Cabinet";
    private static final String KEY = "cabinetId";
    private static final String STREET = "cabinetRue";
    private static final String CP = "cabinetCP";
    private static final String TOWN = "cabinetVille";
    private static final String POSX = "cabinetPosX";
    private static final String POSY = "cabinetPosY";

    // Constructeur
    public CabinetDAO(Context pContext) {
        super(pContext);
    }


    /**
     * Recupere les differents paramètres de l'objet Cabinet pour ensuite ajouté le tout dans la BDD locale
     * @param cabinet
     */
    public void ajouter(Cabinet cabinet) {
        // Ajout d'un cabinet dans la table Cabinet
        ContentValues value = new ContentValues();
        value.put(CabinetDAO.KEY, cabinet.getId());
        value.put(CabinetDAO.STREET, cabinet.getRue());
        value.put(CabinetDAO.CP, cabinet.getCodePostal());
        value.put(CabinetDAO.TOWN, cabinet.getVille());
        value.put(CabinetDAO.POSX, cabinet.getPosX());
        value.put(CabinetDAO.POSY, cabinet.getPosY());
        mDb.insert(CabinetDAO.TABLE_NAME, null, value);
    }


    /**
     * Supprime tous les champs de la table Cabinet
     */
    public void supprimer() {
        mDb.delete(TABLE_NAME,null,null);
    }


    /**
     * Sélectionne dans la BDD locale le cabinet a la position de l'id entré
     * @param id
     * @return Cabinet
     */
    public Cabinet selectionner(long id) {
        Cursor c = mDb.rawQuery("select * from " + TABLE_NAME + " where cabinetId > ?", new String[]{""+id+""});
        return cursorToCabinet(c);
    }


    /**
     * Créer un objet Cabinet et lui donne en paramètre les valeurs du cursor
     * @param c
     * @return Cabinet
     */
    @Nullable
    private Cabinet cursorToCabinet(Cursor c){
        if (c.getCount() == 0)
            return null;
        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée un Cabinet
        Cabinet unCabinet = new Cabinet();
        // On lui passe les différentes valeurs du cursor
        unCabinet.setRue(c.getString(1));
        unCabinet.setCodePostal(c.getString(2));
        unCabinet.setVille(c.getString(3));
        unCabinet.setPosX(c.getDouble(4));
        unCabinet.setPosY(c.getDouble(5));

        c.close();
        return unCabinet;
    }


    /**
     * Renvoie le nombre d'élément dans la table
     * @return long
     */
    public long count(){
        long numberOfRows = DatabaseUtils.queryNumEntries(mDb, TABLE_NAME);
        return numberOfRows;
    }

}

