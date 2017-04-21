using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metier;
using Passerelle;

namespace TestUnitaire2
{
    [TestClass]
    public class UnitTestMetier
    {
        [TestMethod]
        public void testConstructeurUtilisateur()
        {
            DateTime date = new DateTime(2017, 02, 02);
            String nom = "david";
            String prenom = "andre";
            String id = "1";
            String ville = "Lille";
            String email = "david.andre@gsb.com";
            String login = "dandre";
            String mdp = "oppg5";
            String adresse = "106 rue victor hugo";
            String cp = "59000";
            String idRole = "2";
            int version = 9;
            DateTime dateAttendu = new DateTime(2017, 02, 02);
            Utilisateur utilisateurObtenu = new Utilisateur("1", "david", "andre", "dandre", "oppg5", "106 rue victor hugo", "59000", "Lille", date, "2", "david.andre@gsb.com", 8);
            Assert.AreEqual(nom, utilisateurObtenu.getNom());
            Assert.AreEqual(prenom, utilisateurObtenu.getPrenom());
            Assert.AreEqual(id, utilisateurObtenu.getId());
            Assert.AreEqual(ville, utilisateurObtenu.getVille());
            Assert.AreEqual(email, utilisateurObtenu.getEmail());
            Assert.AreEqual(login, utilisateurObtenu.getLogin());
            Assert.AreEqual(mdp, utilisateurObtenu.getMdp());
            Assert.AreEqual(adresse, utilisateurObtenu.getAdresse());
            Assert.AreEqual(cp, utilisateurObtenu.getCp());
            Assert.AreEqual(idRole, utilisateurObtenu.getIdRole());
            Assert.AreEqual(8, utilisateurObtenu.getVersion());
            utilisateurObtenu.incrementeVersion();
            Assert.AreEqual(version, utilisateurObtenu.getVersion());
        }

        [TestMethod]
        public void testConstructeurUtilisateur2()
        {
            DateTime date = new DateTime(2017, 02, 02);
            String nom = "david";
            String prenom = "andre";
            String id = "1";
            String ville = "Lille";
            String email = "david.andre@gsb.com";
            String login = "dandre";
            String mdp = "oppg5";
            String adresse = "106 rue victor hugo";
            String cp = "59000";
            String idRole = "0";
            Boolean adminAttendu = true;
            int version = 9;
            DateTime dateAttendu = new DateTime(2017, 02, 02);
            Utilisateur utilisateurObtenu = new Utilisateur("1", "david", "andre", "dandre", "oppg5", "106 rue victor hugo", "59000", "Lille", date, "0", "david.andre@gsb.com", 8);
            Assert.AreEqual(adminAttendu, utilisateurObtenu.estUnAdmin());
        }

        [TestMethod]
        public void testConstructeurUtilisateur3()
        {
            String toStringAttendu = "david andre, 59000, Lille";
            DateTime dateAttendu = new DateTime(2017, 02, 02);
            Utilisateur utilisateurObtenu = new Utilisateur("1", "david", "andre", "dandre", "oppg5", "106 rue victor hugo", "59000", "Lille", dateAttendu, "0", "david.andre@gsb.com", 8);
            Assert.AreEqual(toStringAttendu, utilisateurObtenu.ToString());
        }

        [TestMethod]
        public void testConstructeurCabinet()
        {
            int id = 1;
            String rue = "20 rue Jean Bono";
            String cp = "59000";
            String ville = "Lille";
            double longitude = 25.78;
            double latitude = 34.24;
            String toStringAttendu = "20 rue Jean Bono Lille, 59000";
            Cabinet cabinetObtenu = new Cabinet(1, "20 rue Jean Bono", "59000", "Lille", 25.78, 34.24);
            Assert.AreEqual(id, cabinetObtenu.getId());
            Assert.AreEqual(rue, cabinetObtenu.getRue());
            Assert.AreEqual(cp, cabinetObtenu.getCP());
            Assert.AreEqual(ville, cabinetObtenu.getVille());
            Assert.AreEqual(longitude, cabinetObtenu.getLongitude());
            Assert.AreEqual(latitude, cabinetObtenu.getLatitude());
            Assert.AreEqual(toStringAttendu, cabinetObtenu.ToString());
        }

        [TestMethod]
        public void testConstructeurMedecin()
        {
            int idMedecin = 1;
            String nomMedecin = "Bernard";
            String prenomMedecin = "Jean";
            DateTime dateAttendu = new DateTime(2017, 02, 02);
            Utilisateur utilisateurObtenu = new Utilisateur("1", "david", "andre", "dandre", "oppg5", "106 rue victor hugo", "59000", "Lille", dateAttendu, "0", "david.andre@gsb.com", 8);
            String toStringAttendu = "Bernard Jean";
            Cabinet cabinetObtenu = new Cabinet(1, "20 rue Jean Bono", "59000", "Lille", 25.78, 34.24);
            Medecin medecinObtenu = new Medecin(1, "Bernard", "Jean", cabinetObtenu, utilisateurObtenu);
            Assert.AreEqual(idMedecin, medecinObtenu.getId());
            Assert.AreEqual(nomMedecin, medecinObtenu.getNom());
            Assert.AreEqual(prenomMedecin, medecinObtenu.getPrenom());
            Assert.AreEqual(toStringAttendu, medecinObtenu.ToString());
            Assert.AreEqual(cabinetObtenu, medecinObtenu.getCabinet());
            Assert.AreEqual(utilisateurObtenu, medecinObtenu.getVisiteur());
            Assert.AreEqual(utilisateurObtenu.getId(), medecinObtenu.getVisiteur().getId());
            Assert.AreEqual(utilisateurObtenu.getCp(), medecinObtenu.getVisiteur().getCp());
            Assert.AreEqual(utilisateurObtenu.getAdresse(), medecinObtenu.getVisiteur().getAdresse());
            Assert.AreEqual(utilisateurObtenu.getEmail(), medecinObtenu.getVisiteur().getEmail());
            Assert.AreEqual(utilisateurObtenu.getIdRole(), medecinObtenu.getVisiteur().getIdRole());
            Assert.AreEqual(utilisateurObtenu.getLogin(), medecinObtenu.getVisiteur().getLogin());
            Assert.AreEqual(utilisateurObtenu.getMdp(), medecinObtenu.getVisiteur().getMdp());
            Assert.AreEqual(utilisateurObtenu.GetType(), medecinObtenu.getVisiteur().GetType());

            medecinObtenu.getVisiteur().setCP("12300");
            utilisateurObtenu.setCP("12300");
            Assert.AreEqual(utilisateurObtenu.getCp(), medecinObtenu.getVisiteur().getCp());
            medecinObtenu.setId(3);
            medecinObtenu.setNom("Denis");
            medecinObtenu.setPrenom("Raoul");
            utilisateurObtenu.setPrenom("Philipe");
            utilisateurObtenu.setNom("Dupaté");
            utilisateurObtenu.setMdp("jambon");
            utilisateurObtenu.setEmail("philipe.dupaté@gsb.com");
            Assert.AreEqual("Denis", medecinObtenu.getNom());
            Assert.AreEqual("Raoul", medecinObtenu.getPrenom());
            Assert.AreEqual("Philipe", medecinObtenu.getVisiteur().getPrenom());
            Assert.AreEqual("Dupaté", medecinObtenu.getVisiteur().getNom());
            Assert.AreEqual("jambon", medecinObtenu.getVisiteur().getMdp());
            Assert.AreEqual("philipe.dupaté@gsb.com", medecinObtenu.getVisiteur().getEmail());
        }

    }
}