package com.example.leo.gsb_mobile.object;

/**
 * Created by Leo on 28/03/2017.
 */

public class CardView {

    private String nomMedecin;
    private String prenomMedecin;
    private String adresseCabinet;

    public CardView(String nomMedecin, String adresseCabinet, String prenomMedecin) {
        this.nomMedecin = nomMedecin;
        this.adresseCabinet = adresseCabinet;
        this.prenomMedecin = prenomMedecin;
    }

    public String getNomMedecin() {
        return nomMedecin;
    }

    public void setNomMedecin(String nomMedecin) {
        this.nomMedecin = nomMedecin;
    }

    public String getPrenomMedecin() {
        return prenomMedecin;
    }

    public void setPrenomMedecin(String prenomMedecin) {
        this.prenomMedecin = prenomMedecin;
    }

    public String getAdresseCabinet() {
        return adresseCabinet;
    }

    public void setAdresseCabinet(String adresseCabinet) {
        this.adresseCabinet = adresseCabinet;
    }
}
