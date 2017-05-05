package com.example.leo.gsb_mobile.web_services;

import android.content.Context;
import android.os.AsyncTask;
import android.util.Log;
import android.widget.Toast;

import com.example.leo.gsb_mobile.Constant;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLConnection;

/**
 * Created by Leo on 05/04/2017.
 * Tâche Asynchrone éxecutant le webservice getCabinet
 */

public class GetCabinetFromBDD extends AsyncTask<Void, Void, String> {

    private Context context;

    public GetCabinetFromBDD(Context context) {
        this.context = context;

    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();
    }

    @Override
    protected String doInBackground(Void... params) {
        String result = appelWS("http://"+ Constant.ADRESS_IP_SERVER+"/GSB/webservices/getCabinet_WS.php");
        return result;
    }

    @Override
    protected void onPostExecute(String result) {
    }


    private String appelWS(String uneURL) {
        String result = "";
        try {
            InputStream in;
            URL url = new URL(uneURL);
            URLConnection connection = url.openConnection();
            HttpURLConnection httpConnection = (HttpURLConnection) connection;
            // Connexion à l'url
            httpConnection.connect();
            int responseCode = httpConnection.getResponseCode();

            if (responseCode == HttpURLConnection.HTTP_OK) {
                in = httpConnection.getInputStream();
                result = convertStreamToString(in);
            }
        } catch (Exception e) {
            Log.d("debogage", "erreur" + e.getMessage());
        }
        return result;
    }

    private String convertStreamToString(InputStream is) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(is));
        StringBuilder sb = new StringBuilder();
        try {
            String ligne = reader.readLine();
            while (ligne != null) {
                sb.append(ligne + "\n");
                ligne = reader.readLine();
            }
            reader.close();
        } catch (IOException e) {
        } finally {
            try {
                is.close();
            } catch (IOException e) {
                Log.d("debogage", "catch");
            }
        }
        return sb.toString();
    }

}
