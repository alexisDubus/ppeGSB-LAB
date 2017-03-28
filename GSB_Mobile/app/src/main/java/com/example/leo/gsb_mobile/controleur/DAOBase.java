package com.example.leo.gsb_mobile.controleur;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

import com.example.leo.gsb_mobile.DataBaseHandler;

/**
 * Created by Leo on 26/03/2017.
 */

public abstract class DAOBase {

    protected final static int VERSION = 1;
    protected final static String NOM = "database.db";

    protected SQLiteDatabase mDb = null;
    protected DataBaseHandler mHandler = null;

    public DAOBase(Context pContext) {
        this.mHandler = new DataBaseHandler(pContext, NOM, null, VERSION);
    }

    // Open connexion to BDD
    public SQLiteDatabase open() {
        // Pas besoin de fermer la dernière base puisque getWritableDatabase s'en charge
        mDb = mHandler.getWritableDatabase();
        return mDb;
    }

    // Close connexion to BDD
    public void close() {
        mDb.close();
    }

    // Get BDD
    public SQLiteDatabase getDb() {
        return mDb;
    }
}

