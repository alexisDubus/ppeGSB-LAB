package com.example.leo.gsb_mobile8_24.object;

/**
 * Created by Leo on 24/03/2017.
 * Objet Cabinet
 */
public class Cabinet {

    private int id;
    private String rue;
    private String codePostal;
    private String ville;
    private double posX;
    private double posY;

    public Cabinet(int id, String rue, String cp, String ville, double X, double Y){
        super();
        this.id = id;
        this.rue = rue;
        this.codePostal = cp;
        this.ville = ville;
        this.posX = X;
        this.posY = Y;
    }

    public Cabinet(){}

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getRue() {
        return rue;
    }

    public void setRue(String rue) {
        this.rue = rue;
    }

    public String getCodePostal() {
        return codePostal;
    }

    public void setCodePostal(String codePostal) {
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

    @Override
    public String toString() {
        return "Cabinet{" +
                "id=" + id +
                ", rue='" + rue + '\'' +
                ", codePostal=" + codePostal +
                ", ville='" + ville + '\'' +
                ", posX=" + posX +
                ", posY=" + posY +
                '}';
    }
}
