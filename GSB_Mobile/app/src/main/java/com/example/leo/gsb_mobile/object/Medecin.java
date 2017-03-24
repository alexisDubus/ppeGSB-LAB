package com.example.leo.gsb_mobile.object;

/**
 * Created by Leo on 24/03/2017.
 */

public class Medecin {

    private long idMedecin;
    private String nom;
    private String prenom;
    private long idUtilisateur;
    private long idCabinet;

    public Medecin(long idMedecin, String nom, String prenom, long idUtilisateur, long idCabinet) {
        super();
        this.idMedecin = idMedecin;
        this.nom = nom;
        this.prenom = prenom;
        this.idUtilisateur = idUtilisateur;
        this.idCabinet = idCabinet;
    }

    public long getIdMedecin() {
        return idMedecin;
    }

    public void setIdMedecin(long idMedecin) {
        this.idMedecin = idMedecin;
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

    public long getIdUtilisateur() {
        return idUtilisateur;
    }

    public void setIdUtilisateur(long idUtilisateur) {
        this.idUtilisateur = idUtilisateur;
    }

    public long getIdCabinet() {
        return idCabinet;
    }

    public void setIdCabinet(long idCabinet) {
        this.idCabinet = idCabinet;
    }
}
