package com.example.leo.gsb_mobile;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Leo on 24/03/2017.
 */

public class DataBaseHandler extends SQLiteOpenHelper {

    // -------------------- Table UTILISATEUR --------------------
    private static final String USER_TABLE_NAME = "Utilisateur";
    private static final String USER_KEY = "utilisateurId";
    private static final String USER_NAME = "utilisateurNom";
    private static final String USER_LASTNAME = "utilisateurPrenom";
    private static final String USER_LOGIN = "utilisateurLogin";
    private static final String USER_MDP = "utilisateurMdp";

    private static final String USER_TABLE_CREATE =
            "CREATE TABLE " + USER_TABLE_NAME + " (" +
                    USER_KEY + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    USER_NAME + " TEXT, " +
                    USER_LASTNAME + " TEXT, " +
                    USER_LOGIN + " TEXT, " +
                    USER_MDP + " TEXT);";

    public static final String USER_TABLE_DROP = "DROP TABLE IF EXISTS " + USER_TABLE_NAME + ";";


    // -------------------- Table CABINET --------------------
    private static final String CABINET_TABLE_NAME = "Cabinet";
    private static final String CABINET_KEY = "cabinetId";
    private static final String CABINET_STREET = "cabinetRue";
    private static final String CABINET_CP = "cabinetCP";
    private static final String CABINET_TOWN = "cabinetVille";
    private static final String CABINET_POSX = "cabinetPosX";
    private static final String CABINET_POSY = "cabinetPosY";

    private static String CABINET_TABLE_CREATE =
            "CREATE TABLE " + CABINET_TABLE_NAME + " (" +
                    CABINET_KEY + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    CABINET_STREET + " TEXT, " +
                    CABINET_CP + " INTEGER, " +
                    CABINET_TOWN + " TEXT, " +
                    CABINET_POSX + " REAL, " +
                    CABINET_POSY + " REAL);";

    public static final String CABINET_TABLE_DROP = "DROP TABLE IF EXISTS " + CABINET_TABLE_NAME + ";";


    // -------------------- Table MEDECIN --------------------
    private static final String MEDECIN_TABLE_NAME = "Medecin";
    private static final String MEDECIN_KEY = "medecinId";
    private static final String MEDECIN_NAME = "medecinNom";
    private static final String MEDECIN_LASTNAME = "medecinPrenom";

    private static String MEDECIN_TABLE_CREATE =
            "CREATE TABLE " + MEDECIN_TABLE_NAME + "(" +
                    MEDECIN_KEY + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    MEDECIN_NAME + " TEXT, " +
                    MEDECIN_LASTNAME + " TEXT, " +
                    CABINET_KEY + " INTEGER, " +
                    USER_KEY + " INTEGER);";

    public static final String MEDECIN_TABLE_DROP = "DROP TABLE IF EXISTS " + MEDECIN_TABLE_NAME + ";";

    // -------------------- Table VISITE --------------------
    private static final String VISITE_TABLE_NAME = "Visite";
    private static final String VISITE_KEY = "visiteId";
    private static final String VISITE_DATE = "visiteDateArrive";
    private static final String VISITE_RDV = "visiteRdv"; // Pas de boolean donc 0 ou 1
    private static final String VISITE_HOUR_ARRIVE = "visiteHeureArrive";
    private static final String VISITE_HOUR_START= "visiteHeureDebut";
    private static final String VISITE_HOUR_END = "visiteHeureFin";

    private static String VISITE_TABLE_CREATE =
            "CREATE TABLE " + VISITE_TABLE_NAME + "(" +
                    VISITE_KEY + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    VISITE_DATE + " TEXT, " +
                    VISITE_RDV + " INTEGER, " +
                    VISITE_HOUR_ARRIVE + " TEXT, " +
                    VISITE_HOUR_START + " TEXT, " +
                    VISITE_HOUR_END + " TEXT, " +
                    MEDECIN_KEY + " INTEGER, " +
                    USER_KEY + " INTEGER);";

    public static final String VISITE_TABLE_DROP = "DROP TABLE IF EXISTS " + VISITE_TABLE_NAME + ";";

    // ----------------- Méthodes ---------------------

    public DataBaseHandler(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(USER_TABLE_CREATE);
        db.execSQL(CABINET_TABLE_CREATE);
        db.execSQL(MEDECIN_TABLE_CREATE);
        db.execSQL(VISITE_TABLE_CREATE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL(USER_TABLE_DROP);
        db.execSQL(CABINET_TABLE_DROP);
        db.execSQL(MEDECIN_TABLE_DROP);
        db.execSQL(VISITE_TABLE_DROP);
        onCreate(db);
    }
}
