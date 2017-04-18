package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;

import com.example.leo.gsb_mobile.object.Cabinet;
import com.example.leo.gsb_mobile.object.Utilisateur;


/**
 * Created by Leo on 27/03/2017.
 */

public class UtilisateurDAO extends DAOBase {

    public static final String TABLE_NAME = "Utilisateur";
    public static final String KEY = "utilisateurId";
    public static final String USERID = "realIdUser";
    public static final String NAME = "utilisateurNom";
    public static final String LASTNAME = "utilisateurPrenom";
    public static final String VERSION = "utilisateurVersion";
    private static final String POSX = "utilisateurPosX";
    private static final String POSY = "utilisateurPosY";


    public UtilisateurDAO(Context pContext) {
        super(pContext);
    }

    public void ajouter(Utilisateur user) {
        ContentValues value = new ContentValues();

        value.put(UtilisateurDAO.USERID, user.getUserId());
        value.put(UtilisateurDAO.NAME, user.getNom());
        value.put(UtilisateurDAO.LASTNAME, user.getPrenom());
        value.put(UtilisateurDAO.VERSION, user.getNumVersion());
        value.put(UtilisateurDAO.POSX, user.getPosX());
        value.put(UtilisateurDAO.POSY, user.getPosY());

        mDb.insert(UtilisateurDAO.TABLE_NAME, null, value);

    }

    public void supprimer() {
       // mDb.delete(TABLE_NAME, KEY + " = "+id,null);
        mDb.delete(TABLE_NAME,null,null);
    }

    public Utilisateur selectionner(long id) {
        Cursor c = mDb.rawQuery("select * from "+ TABLE_NAME +" where utilisateurId > ?", new String[]{String.valueOf(id)});
        return cursorToUser(c);
    }

    private Utilisateur cursorToUser(Cursor c){

        if (c.getCount() == 0)
            return null;

        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée un Utilisateur
        Utilisateur unUtilisateur = new Utilisateur();

        unUtilisateur.setUserId(c.getString(1));
        unUtilisateur.setNom(c.getString(2));
        unUtilisateur.setPrenom(c.getString(3));
        unUtilisateur.setNumVersion(c.getInt(4));
        unUtilisateur.setPosX(c.getDouble(5));
        unUtilisateur.setPosY(c.getDouble(6));

        c.close();
        return unUtilisateur;
    }

    public long count(){
        long numberOfRows = DatabaseUtils.queryNumEntries(mDb, TABLE_NAME);
        return numberOfRows;
    }
}
