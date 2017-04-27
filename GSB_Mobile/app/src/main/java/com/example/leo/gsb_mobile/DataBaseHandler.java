package com.example.leo.gsb_mobile;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

/**
 * Created by Leo on 24/03/2017.
 * Classe permettant de créer la BDD SQLite
 * S'éxecute au premier lancement de l'application
 */

public class DataBaseHandler extends SQLiteOpenHelper {

    // -------------------- Table UTILISATEUR --------------------
    private static final String USER_TABLE_NAME = "Utilisateur";
    private static final String USER_KEY = "utilisateurId";
    private static final String USER_IDUSER = "realIdUser";
    private static final String USER_NAME = "utilisateurNom";
    private static final String USER_LASTNAME = "utilisateurPrenom";
    private static final String USER_VERSION = "utilisateurVersion";
    private static final String USER_POSX = "utilisateurPosX";
    private static final String USER_POSY = "utilisateurPosY";


    private static final String USER_TABLE_CREATE =
            "CREATE TABLE " + USER_TABLE_NAME + " (" +
                    USER_KEY + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    USER_IDUSER + " TEXT, " +
                    USER_NAME + " TEXT, " +
                    USER_LASTNAME + " TEXT, " +
                    USER_VERSION + " INTEGER, " +
                    USER_POSX + " REAL, " +
                    USER_POSY  + " REAL);";

    private static final String USER_TABLE_DROP = "DROP TABLE IF EXISTS " + USER_TABLE_NAME + ";";


    // -------------------- Table CABINET --------------------
    private static final String CABINET_TABLE_NAME = "Cabinet";
    private static final String CABINET_KEY = "cabinetId";
    private static final String CABINET_STREET = "cabinetRue";
    private static final String CABINET_CP = "cabinetCP";
    private static final String CABINET_TOWN = "cabinetVille";
    private static final String CABINET_POSX = "cabinetPosX";
    private static final String CABINET_POSY = "cabinetPosY";

    private static final String CABINET_TABLE_CREATE =
            "CREATE TABLE " + CABINET_TABLE_NAME + " (" +
                    CABINET_KEY + " INTEGER PRIMARY KEY, " +
                    CABINET_STREET + " TEXT, " +
                    CABINET_CP + " TEXT, " +
                    CABINET_TOWN + " TEXT, " +
                    CABINET_POSX + " REAL, " +
                    CABINET_POSY + " REAL);";

    private static final String CABINET_TABLE_DROP = "DROP TABLE IF EXISTS " + CABINET_TABLE_NAME + ";";


    // -------------------- Table MEDECIN --------------------
    private static final String MEDECIN_TABLE_NAME = "Medecin";
    private static final String MEDECIN_KEY = "medecinId";
    private static final String MEDECIN_NAME = "medecinNom";
    private static final String MEDECIN_LASTNAME = "medecinPrenom";

    private static final String MEDECIN_TABLE_CREATE =
            "CREATE TABLE " + MEDECIN_TABLE_NAME + "(" +
                    MEDECIN_KEY + " INTEGER PRIMARY KEY , " +
                    MEDECIN_NAME + " TEXT, " +
                    MEDECIN_LASTNAME + " TEXT, " +
                    CABINET_KEY + " TEXT, " +
                    USER_KEY + " TEXT);";

    private static final String MEDECIN_TABLE_DROP = "DROP TABLE IF EXISTS " + MEDECIN_TABLE_NAME + ";";

    // -------------------- Table VISITE --------------------
    private static final String VISITE_TABLE_NAME = "Visite";
    private static final String VISITE_KEY = "visiteId";
    private static final String VISITE_DATE = "visiteDateArrive";
    private static final String VISITE_RDV = "visiteRdv"; // Pas de boolean donc 0 ou 1
    private static final String VISITE_HOUR_ARRIVE = "visiteHeureArrive";
    private static final String VISITE_HOUR_START= "visiteHeureDebut";
    private static final String VISITE_HOUR_END = "visiteHeureFin";

    private static final String VISITE_TABLE_CREATE =
            "CREATE TABLE " + VISITE_TABLE_NAME + "(" +
                    VISITE_KEY + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    VISITE_DATE + " TEXT, " +
                    VISITE_RDV + " INTEGER, " +
                    VISITE_HOUR_ARRIVE + " TEXT, " +
                    VISITE_HOUR_START + " TEXT, " +
                    VISITE_HOUR_END + " TEXT, " +
                    MEDECIN_KEY + " TEXT, " +
                    USER_KEY + " TEXT);";

    private static final String VISITE_TABLE_DROP = "DROP TABLE IF EXISTS " + VISITE_TABLE_NAME + ";";

    // ----------------- Méthodes ---------------------

    public DataBaseHandler(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    /**
     * Méthode éxecutant les commandes DROP et CREATE de chaque table
     * @param db
     */
    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(USER_TABLE_DROP);
        db.execSQL(CABINET_TABLE_DROP);
        db.execSQL(MEDECIN_TABLE_DROP);
        db.execSQL(VISITE_TABLE_DROP);

        db.execSQL(USER_TABLE_CREATE);
        db.execSQL(CABINET_TABLE_CREATE);
        db.execSQL(MEDECIN_TABLE_CREATE);
        db.execSQL(VISITE_TABLE_CREATE);
    }

    /**
     * Méthode recreant la BDD lors d'un changement de version
     * @param db
     * @param oldVersion
     * @param newVersion
     */
    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        onCreate(db);
    }
}
