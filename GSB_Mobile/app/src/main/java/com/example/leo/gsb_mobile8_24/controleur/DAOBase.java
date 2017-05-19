package com.example.leo.gsb_mobile8_24.controleur;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

import com.example.leo.gsb_mobile8_24.DataBaseHandler;

/**
 * Created by Leo on 26/03/2017.
 * Objet controlleur qui permet de se connecter a la BDD local
 * Les différents controlleur vont ensuite hériter de cette classe afin d'agir sur une table en particulier
 */
class DAOBase {

    private final static int VERSION = 1;
    private final static String NOM = "database8_26.db";

    SQLiteDatabase mDb = null;
    private DataBaseHandler mHandler = null;

    DAOBase(Context pContext) {
        this.mHandler = new DataBaseHandler(pContext, NOM, null, VERSION);
    }

    // Ouvre la connexion a la base de donnée locale
    public SQLiteDatabase open() {
        mDb = mHandler.getWritableDatabase();
        return mDb;
    }

    // Ferme la connexion a la base de donnée locale
    public void close() {
        mDb.close();
    }

    // Get BDD
    public SQLiteDatabase getDb() {
        return mDb;
    }

}

