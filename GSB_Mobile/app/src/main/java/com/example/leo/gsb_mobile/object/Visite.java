package com.example.leo.gsb_mobile.object;

import java.util.Date;

/**
 * Created by Leo on 24/03/2017.
 */

public class Visite {

    private long visiteId;
    private Date dateVisite;
    private  boolean rdvOrNot;
    private Date heureArrive;
    private Date heureDebut;
    private Date heureFin;
    private long userId;
    private long medecinId;

    public Visite(Date dateVisite, boolean rdvOrNot, Date heureArrive, Date heureDebut, Date heureFin, long userId, long medecinId) {
        this.dateVisite = dateVisite;
        this.rdvOrNot = rdvOrNot;
        this.heureArrive = heureArrive;
        this.heureDebut = heureDebut;
        this.userId = userId;
        this.heureFin = heureFin;
        this.medecinId = medecinId;
    }

    public Visite(){}

    public long getVisiteId() {
        return visiteId;
    }

    public void setVisiteId(long visiteId) {
        this.visiteId = visiteId;
    }

    public Date getDateVisite() {
        return dateVisite;
    }

    public void setDateVisite(Date dateVisite) {
        this.dateVisite = dateVisite;
    }

    public boolean isRdvOrNot() {
        return rdvOrNot;
    }

    public void setRdvOrNot(boolean rdvOrNot) {
        this.rdvOrNot = rdvOrNot;
    }

    public Date getHeureArrive() {
        return heureArrive;
    }

    public void setHeureArrive(Date heureArrive) {
        this.heureArrive = heureArrive;
    }

    public Date getHeureDebut() {
        return heureDebut;
    }

    public void setHeureDebut(Date heureDebut) {
        this.heureDebut = heureDebut;
    }

    public long getUserId() {
        return userId;
    }

    public void setUserId(long userId) {
        this.userId = userId;
    }

    public Date getHeureFin() {
        return heureFin;
    }

    public void setHeureFin(Date heureFin) {
        this.heureFin = heureFin;
    }

    public long getMedecinId() {
        return medecinId;
    }

    public void setMedecinId(long medecinId) {
        this.medecinId = medecinId;
    }
}
