package com.example.leo.gsb_mobile.object;

/**
 * Created by Leo on 28/03/2017.
 */

public class CardView {

    private String nomMedecin;
    private String prenomMedecin;
    private String adresseCabinet;
    public int idMedecin;

    public CardView(String nomMedecin, String prenomMedecin, String adresseCabinet, int idMedecin) {
        this.nomMedecin = nomMedecin;
        this.adresseCabinet = adresseCabinet;
        this.prenomMedecin = prenomMedecin;
        this.idMedecin = idMedecin;
    }

    public int getIdMedecin() {
        return idMedecin;
    }

    public void setIdMedecin(int idMedecin) {
        this.idMedecin = idMedecin;
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
