package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;

import com.example.leo.gsb_mobile.object.Cabinet;
import com.example.leo.gsb_mobile.object.Utilisateur;


/**
 * Created by Leo on 27/03/2017.
 * Objet controlleur qui permet d'agir sur la table Utilisateur de la BDD locale
 */

public class UtilisateurDAO extends DAOBase {

    // Création des constantes du nom des champs de la BDD
    private static final String TABLE_NAME = "Utilisateur";
    private static final String USERID = "realIdUser";
    private static final String NAME = "utilisateurNom";
    private static final String LASTNAME = "utilisateurPrenom";
    private static final String VERSION = "utilisateurVersion";
    private static final String POSX = "utilisateurPosX";
    private static final String POSY = "utilisateurPosY";


    public UtilisateurDAO(Context pContext) {
        super(pContext);
    }


    /**
     * Recupere les differents paramètres de l'objet Utilisateur pour ensuite ajouté le tout dans la BDD locale
     * @param user
     */
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


    /**
     * Supprime tous les champs de la table Utilisateur
     */
    public void supprimer() {
        mDb.delete(TABLE_NAME,null,null);
    }


    /**
     * Sélectionne dans la BDD locale l'Utilisateur a la position de l'id entré
     * @param id
     * @return Utilisateur
     */
    public Utilisateur selectionner(long id) {
        Cursor c = mDb.rawQuery("select * from "+ TABLE_NAME +" where utilisateurId > ?", new String[]{String.valueOf(id)});
        return cursorToUser(c);
    }


    /**
     * Créer un objet Utilisateur et lui donne en paramètre les valeurs du cursor
     * @param c
     * @return Utilisateur
     */
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


    /**
     * Renvoie le nombre d'élément dans la table
     * @return long
     */
    public long count(){
        long numberOfRows = DatabaseUtils.queryNumEntries(mDb, TABLE_NAME);
        return numberOfRows;
    }
}
