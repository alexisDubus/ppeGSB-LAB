package com.example.leo.gsb_mobile.object;

/**
 * Created by Leo on 24/03/2017.
 */

public class Cabinet {

    private long idCabinet;
    private String rue;
    private int codePostal;
    private String ville;
    private double posX;
    private double posY;

    public Cabinet(long id, String rue, int cp, String ville, double X, double Y){
        super();
        this.idCabinet = id;
        this.rue = rue;
        this.codePostal = cp;
        this.ville = ville;
        this.posX = X;
        this.posY = Y;
    }

    public long getId() {
        return idCabinet;
    }

    public void setId(long id) {
        this.idCabinet = id;
    }

    public String getRue() {
        return rue;
    }

    public void setRue(String rue) {
        this.rue = rue;
    }

    public int getCodePostal() {
        return codePostal;
    }

    public void setCodePostal(int codePostal) {
        this.codePostal = codePostal;
    }

    public String getVille() {
        return ville;
    }

    public void setVille(String ville) {
        this.ville = ville;
    }

    public double getPosX() {
        return posX;
    }

    public void setPosX(double posX) {
        this.posX = posX;
    }

    public double getPosY() {
        return posY;
    }

    public void setPosY(double posY) {
        this.posY = posY;
    }
}
