package com.example.leo.gsb_mobile.web_services;



import android.app.Activity;
import android.content.Context;
import android.os.AsyncTask;
import android.util.Log;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLConnection;

/**
 * Created by Leo on 28/03/2017.
 */

public class GetMedecinFromBDD extends AsyncTask<Void, Void, String> {

    private Context context;

    public GetMedecinFromBDD(Context context) { this.context = context; }


    @Override
    protected void onPreExecute() {
        super.onPreExecute();
        Toast.makeText(context, "Début du traitement", Toast.LENGTH_LONG).show();
    }


    @Override
    protected String doInBackground(Void... params) {
        String result = appelWS("Applications/MAMP/htdocs/PPEGSB_4.0_Mobile/stockServer_Medecin.php?var=" );
        return result;
    }

    @Override
    protected void onPostExecute(String result) {
        Toast.makeText(context,result, Toast.LENGTH_LONG).show();
    }



    private String appelWS(String uneURL){
        String result="";
        try {
            InputStream in;
            URL url = new URL(uneURL);
            URLConnection connection = url.openConnection();
            HttpURLConnection httpConnection = (HttpURLConnection) connection;
            // Connexion à l'url
            httpConnection.connect();
            int responseCode = httpConnection.getResponseCode();

            if (responseCode == HttpURLConnection.HTTP_OK) {
                in = httpConnection.getInputStream(); result = convertStreamToString(in); Log.d("debogage",result);
            }
        }
        catch (Exception e) {
            Log.d("debogage", "erreur"+e.getMessage()); }
        return result;
    }



    private String convertStreamToString(InputStream is) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(is)); StringBuilder sb = new StringBuilder();
        try {
            String ligne = reader.readLine();
            while (ligne != null) {
                Log.d("debogage",ligne); sb.append(ligne + "\n"); ligne = reader.readLine();
            }
            reader.close();
        } catch (IOException e) { } finally {
            try {
                is.close();
            } catch (IOException e) {
                Log.d("debogage","catch"); }
        }
        return sb.toString();
    }


}
