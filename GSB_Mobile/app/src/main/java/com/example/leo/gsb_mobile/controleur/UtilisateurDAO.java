package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;

import com.example.leo.gsb_mobile.object.Utilisateur;


/**
 * Created by Leo on 27/03/2017.
 */

public class UtilisateurDAO extends DAOBase {

    public static final String TABLE_NAME = "Utilisateur";
    public static final String KEY = "utilisateurId";
    public static final String NAME = "utilisateurNom";
    public static final String LASTNAME = "utilisateurPrenom";
    public static final String VERSION = "utilisateurVersion";

    public UtilisateurDAO(Context pContext) {
        super(pContext);
    }

    public void ajouter(Utilisateur user) {
        ContentValues value = new ContentValues();
        value.put(UtilisateurDAO.NAME, user.getNom());
        value.put(UtilisateurDAO.LASTNAME, user.getNom());
        value.put(UtilisateurDAO.VERSION, 1);
        mDb.insert(CabinetDAO.TABLE_NAME, null, value);
    }

    public void supprimer(long id) {
        mDb.delete(TABLE_NAME, KEY + " = ?", new String[]{String.valueOf(id)});
    }
}
