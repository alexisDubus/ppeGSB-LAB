package com.example.leo.gsb_mobile.controleur;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;

import com.example.leo.gsb_mobile.object.Utilisateur;
import com.example.leo.gsb_mobile.object.Visite;

/**
 * Created by Leo on 27/03/2017.
 * Objet controlleur qui permet d'agir sur la table Visite de la BDD locale
 */
public class VisiteDAO extends DAOBase {

    // Création des constantes du nom des champs de la BDD
    private static final String TABLE_NAME = "Visite";
    private static final String KEY = "visiteId";
    private static final String DATE = "visiteDateArrive";
    private static final String RDV = "visiteRdv";
    private static final String HOUR_ARRIVE = "visiteHeureArrive";
    private static final String HOUR_START = "visiteHeureDebut";
    private static final String HOUR_END = "visiteHeureFin";
    private static final String USER_KEY = "utilisateurId";
    private static final String MEDECIN_KEY = "medecinId";


    public VisiteDAO(Context pContext) {
        super(pContext);
    }


    /**
     * Recupere les differents paramètres de l'objet Visite pour ensuite ajouté le tout dans la BDD locale
     * @param visite
     */
    public void ajouter (Visite visite){
        ContentValues value = new ContentValues();
        value.put(VisiteDAO.DATE, visite.getDateVisite());
        value.put(VisiteDAO.RDV, visite.getRdvOrNot());
        value.put(VisiteDAO.HOUR_ARRIVE, visite.getHeureArrive());
        value.put(VisiteDAO.HOUR_START, visite.getHeureDebut());
        value.put(VisiteDAO.HOUR_END, visite.getHeureFin());
        value.put(VisiteDAO.USER_KEY, visite.getUserId());
        value.put(VisiteDAO.MEDECIN_KEY, visite.getMedecinId());
        mDb.insert(VisiteDAO.TABLE_NAME, null, value);
    }


    /**
     * Supprime tous les champs de la table Visite
     */
    public void supprimer(long id) {
        //mDb.delete(TABLE_NAME,null,null);
        mDb.delete(TABLE_NAME, KEY + " = ?", new String[] {String.valueOf(id)});
    }


    /**
     * Sélectionne dans la BDD locale la Visite à la position de l'id entré
     * @param id
     * @return Visite
     */
    public Visite selectionner(long id) {
        Cursor c = mDb.rawQuery("select * from " + TABLE_NAME + " where visiteId >= ?", new String[]{""+id+""});
        return cursorToVisite(c);
    }


    /**
     * Créer un objet Visite et lui donne en paramètre les valeurs du cursor
     * @param c
     * @return Visite
     */
    private Visite cursorToVisite(Cursor c){
        if (c.getCount() == 0)
            return null;
        //Sinon on se place sur le premier élément
        c.moveToFirst();
        // On crée une visite
        Visite uneVisite = new Visite();
        uneVisite.setVisiteId(c.getString(0));
        uneVisite.setDateVisite(c.getString(1));
        uneVisite.setRdvOrNot(c.getInt(2));
        uneVisite.setHeureArrive(c.getString(3));
        uneVisite.setHeureDebut(c.getString(4));
        uneVisite.setHeureFin(c.getString(5));
        uneVisite.setMedecinId(c.getString(6));
        uneVisite.setUserId(c.getString(7));

        c.close();
        return uneVisite;
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





























































































