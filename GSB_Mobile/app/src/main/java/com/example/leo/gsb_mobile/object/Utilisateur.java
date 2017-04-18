package com.example.leo.gsb_mobile.object;

/**
 * Created by Leo on 24/03/2017.
 */

public class Utilisateur {

    private String userId;
    private String nom;
    private String prenom;
    private int numVersion;
    private double posX;
    private double posY;

    public Utilisateur(String userId, String nom, String prenom, int version) {
        this.userId = userId;
        this.nom = nom;
        this.prenom = prenom;
        this.numVersion = version;
    }

    public Utilisateur(String userId, String nom, String prenom, int version, double posX, double posY) {
        this.userId = userId;
        this.nom = nom;
        this.prenom = prenom;
        this.numVersion = version;
        this.posX = posX;
        this.posY = posY;
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

    public double getPosX() {return posX;}

    public void setPosX(double posX) {this.posX = posX;}

    public double getPosY() {return posY;}

    public void setPosY(double posY) {this.posY = posY;}
}
