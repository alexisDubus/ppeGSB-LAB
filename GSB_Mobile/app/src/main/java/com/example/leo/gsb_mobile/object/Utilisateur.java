package com.example.leo.gsb_mobile.object;

/**
 * Created by Leo on 24/03/2017.
 */

public class Utilisateur {

    private String userId;
    private String nom;
    private String prenom;
    private int numVersion;

    public Utilisateur(String userId, String nom, String prenom) {
        this.userId = userId;
        this.nom = nom;
        this.prenom = prenom;
    }

    public Utilisateur(){}

    public String getUserId() {
        return userId;
    }

    public void setUserId(String userId) {
        this.userId = userId;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getPrenom() {
        return prenom;
    }

    public void setPrenom(String prenom) {
        this.prenom = prenom;
    }

    public int getNumVersion() {
        return numVersion;
    }

    public void setNumVersion(int numVersion) {
        this.numVersion = numVersion;
    }
}
