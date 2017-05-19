package com.example.leo.gsb_mobile8_24.object;


/**
 * Created by Leo on 24/03/2017.
 * Objet Visite
 */
public class Visite {


    private String visiteId;
    private String dateVisite;
    private int rdvOrNot;
    private String heureArrive;
    private String heureDebut;
    private String heureFin;
    private String userId;
    private String medecinId;

    public Visite(String dateVisite, int rdvOrNot, String heureArrive, String heureDebut, String heureFin, String userId, String medecinId) {
        this.dateVisite = dateVisite;
        this.rdvOrNot = rdvOrNot;
        this.heureArrive = heureArrive;
        this.heureDebut = heureDebut;
        this.heureFin = heureFin;
        this.userId = userId;
        this.medecinId = medecinId;
    }

    public Visite() {
    }

    public String getVisiteId() {
        return visiteId;
    }

    public void setVisiteId(String visiteId) {
        this.visiteId = visiteId;
    }

    public String getDateVisite() {
        return dateVisite;
    }

    public void setDateVisite(String dateVisite) {
        this.dateVisite = dateVisite;
    }

    public int getRdvOrNot() {
        return rdvOrNot;
    }

    public void setRdvOrNot(int rdvOrNot) {
        this.rdvOrNot = rdvOrNot;
    }

    public String getHeureArrive() {
        return heureArrive;
    }

    public void setHeureArrive(String heureArrive) {
        this.heureArrive = heureArrive;
    }

    public String getHeureDebut() {
        return heureDebut;
    }

    public void setHeureDebut(String heureDebut) {
        this.heureDebut = heureDebut;
    }

    public String getHeureFin() {
        return heureFin;
    }

    public void setHeureFin(String heureFin) {
        this.heureFin = heureFin;
    }

    public String getUserId() {
        return userId;
    }

    public void setUserId(String userId) {
        this.userId = userId;
    }

    public String getMedecinId() {
        return medecinId;
    }

    public void setMedecinId(String medecinId) {
        this.medecinId = medecinId;
    }

    @Override
    public String toString() {
        return "Visite{" +
                "visiteId='" + visiteId + '\'' +
                ", dateVisite='" + dateVisite + '\'' +
                ", rdvOrNot=" + rdvOrNot +
                ", heureArrive='" + heureArrive + '\'' +
                ", heureDebut='" + heureDebut + '\'' +
                ", heureFin='" + heureFin + '\'' +
                ", userId='" + userId + '\'' +
                ", medecinId='" + medecinId + '\'' +
                '}';
    }
}
