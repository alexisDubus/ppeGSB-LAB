package com.example.leo.gsb_mobile8_24.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;

import com.example.leo.gsb_mobile8_24.object.Medecin;

/**
 * Created by Leo on 27/03/2017.
 * Objet controlleur qui permet d'agir sur la table Medecin de la BDD locale
 */
public class MedecinDAO extends DAOBase {

    // Création des constantes du nom des champs de la BDD
    private static final String TABLE_NAME = "Medecin";
    private static final String KEY = "key";
    private static final String ID = "medecinId";
    private static final String NAME = "medecinNom";
    private static final String LASTNAME = "medecinPrenom";
    private static final String CABINET_KEY = "cabinetId";
    private static final String USER_KEY = "utilisateurId";

    // Constructeur
    public MedecinDAO(Context pContext) {
        super(pContext);
    }

    /**
     * Recupere les differents paramètres de l'objet Medecin pour ensuite ajouté le tout dans la BDD locale
     * @param medecin
     */
    public void ajouter (Medecin medecin){
        ContentValues value = new ContentValues();
        value.put(MedecinDAO.KEY, medecin.getKey());
        value.put(MedecinDAO.ID, medecin.getIdMedecin());
        value.put(MedecinDAO.NAME, medecin.getNom());
        value.put(MedecinDAO.LASTNAME, medecin.getPrenom());
        value.put(MedecinDAO.CABINET_KEY, medecin.getIdCabinet());
        value.put(MedecinDAO.USER_KEY, medecin.getIdUtilisateur());
        mDb.insert(MedecinDAO.TABLE_NAME, null, value);
    }


    /**
     * Supprime tous les champs de la table Medecin
     */
    public void supprimer() {
       // mDb.delete(TABLE_NAME, KEY + " = " +id,null)
        mDb.delete(TABLE_NAME,null,null);
    }


    /**
     * Sélectionne dans la BDD locale le medecin à la position de l'id entré
     * @param id
     * @return Medecin
     */
    public Medecin selectionner(long id) {
        Cursor c = mDb.rawQuery("select * from " + TABLE_NAME + " where key >= ?", new String[]{""+id+""});
        return cursorToMedecin(c);
    }

    /**
     * Créer un objet Medecin et lui donne en paramètre les valeurs du cursor
     * @param c
     * @return Medecin
     */
    private Medecin cursorToMedecin(Cursor c){
        if (c.getCount() == 0)
            return null;
        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée un Medecin
        Medecin unMedecin = new Medecin();
        unMedecin.setKey(c.getInt(0));
        unMedecin.setIdMedecin(c.getInt(1));
        unMedecin.setNom(c.getString(2));
        unMedecin.setPrenom(c.getString(3));
        unMedecin.setIdCabinet(c.getString(4));
        unMedecin.setIdUtilisateur(c.getString(5));

        c.close();
        return unMedecin;
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
