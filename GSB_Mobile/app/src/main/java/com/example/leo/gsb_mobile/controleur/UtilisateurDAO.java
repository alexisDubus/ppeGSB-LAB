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
    public static final String USERID = "id";
    public static final String NAME = "utilisateurNom";
    public static final String LASTNAME = "utilisateurPrenom";
    public static final String VERSION = "utilisateurVersion";


    public UtilisateurDAO(Context pContext) {
        super(pContext);
    }

    public void ajouter(Utilisateur user) {
        ContentValues value = new ContentValues();
        value.put(UtilisateurDAO.USERID, user.getUserId());
        value.put(UtilisateurDAO.NAME, user.getNom());
        value.put(UtilisateurDAO.LASTNAME, user.getPrenom());
        value.put(UtilisateurDAO.VERSION, user.getNumVersion());
        mDb.insert(UtilisateurDAO.TABLE_NAME, null, value);

       // String commande = "INSERT into Utilisateur(utilisateurId, utilisateurNom, utilisateurPrenom, utilisateurVersion) VALUES (\"" +user.getUserId() + "\",\"" +user.getNom() + "\" ,\"" +user.getPrenom() + "\", "+ 1 + ")";
       // mDb.execSQL(commande);
    }

    public void supprimer(long id) {
        mDb.delete(TABLE_NAME, KEY + " = ?", new String[]{String.valueOf(id)});
    }

    public Utilisateur selectionner(long id) {
        Cursor c = mDb.rawQuery("select * from " + TABLE_NAME + " where utilisateurId > ?", new String[]{""+id+""});
        return cursorToUser(c);
    }

    private Utilisateur cursorToUser(Cursor c){
        if (c.getCount() == 0)
            return null;

        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée un Utilisateur
        Utilisateur unUtilisateur = new Utilisateur();

        unUtilisateur.setUserId(c.getString(0));
        unUtilisateur.setNom(c.getString(1));
        unUtilisateur.setPrenom(c.getString(2));
        unUtilisateur.setNumVersion(c.getInt(3));

        c.close();
        return unUtilisateur;
    }

    public long count(){
        long numberOfRows = DatabaseUtils.queryNumEntries(mDb, TABLE_NAME);
        return numberOfRows;
    }
}
