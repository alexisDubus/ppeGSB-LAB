package com.example.leo.gsb_mobile.object;

/**
 * Created by Leo on 24/03/2017.
 * Objet Medecin
 */
public class Medecin {

    private int idMedecin;
    private String nom;
    private String prenom;
    private String idUtilisateur;
    private String idCabinet;

    public Medecin(int id, String nom, String prenom, String idCabinet, String idUtilisateur) {
        super();
        idMedecin = id;
        this.nom = nom;
        this.prenom = prenom;
        this.idCabinet = idCabinet;
        this.idUtilisateur = idUtilisateur;
    }

    public Medecin(){}

    public int getIdMedecin() {
        return idMedecin;
    }

    public void setIdMedecin(int  idMedecin) {
        this.idMedecin = idMedecin;
    }

    public String getNom() {return nom;}

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

    @Override
    public String toString() {
        return "Medecin{" +
                "idMedecin=" + idMedecin +
                ", nom='" + nom + '\'' +
                ", prenom='" + prenom + '\'' +
                ", idUtilisateur='" + idUtilisateur + '\'' +
                ", idCabinet='" + idCabinet + '\'' +
                '}';
    }
}
