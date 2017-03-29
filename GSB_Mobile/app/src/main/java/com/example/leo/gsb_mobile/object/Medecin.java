package com.example.leo.gsb_mobile.object;

/**
 * Created by Leo on 24/03/2017.
 */

public class Medecin {


    private String nom;
    private String prenom;
    private String idUtilisateur;
    private String idCabinet;

    public Medecin( String nom, String prenom, String idCabinet, String idUtilisateur) {
        super();
        this.nom = nom;
        this.prenom = prenom;
        this.idUtilisateur = idUtilisateur;
        this.idCabinet = idCabinet;
    }

    public Medecin(){}

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

    public String getIdUtilisateur() {
        return idUtilisateur;
    }

    public void setIdUtilisateur(String idUtilisateur) {
        this.idUtilisateur = idUtilisateur;
    }

    public String getIdCabinet() {
        return idCabinet;
    }

    public void setIdCabinet(String idCabinet) {
        this.idCabinet = idCabinet;
    }
}
