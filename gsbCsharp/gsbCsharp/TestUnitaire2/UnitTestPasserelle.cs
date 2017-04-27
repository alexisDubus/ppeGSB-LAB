using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Passerelle;
using Metier;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.ComponentModel;

namespace TestUnitaire2
{
    [TestClass]
    public class UnitTestPasserelle
    {
        
        [TestMethod]
        public void testPasserelleCheckValueIsCorrect()
        {
            String strAttendu = "correct";
            String strObtenu = Passerelle.Passerelle.checkValueIsCorrect("correct");
            Assert.AreEqual(strAttendu, strObtenu.ToString());
            strAttendu = "";
            strObtenu = Passerelle.Passerelle.checkValueIsCorrect("2cor2rect");
            Assert.AreEqual(strAttendu, strObtenu.ToString());

            strAttendu = "azertyuiopqsdfghjklmwxcvbn";
            strObtenu = Passerelle.Passerelle.checkValueIsCorrect("azertyuiopqsdfghjklmwxcvbn");
            Assert.AreEqual(strAttendu, strObtenu.ToString());

            strAttendu = "tàtâ";
            strObtenu = Passerelle.Passerelle.checkValueIsCorrect("tàtâ");
            Assert.AreEqual(strAttendu, strObtenu.ToString());

            strAttendu = "";
            strObtenu = Passerelle.Passerelle.checkValueIsCorrect("%*");
            Assert.AreEqual(strAttendu, strObtenu.ToString());

            strAttendu = "";
            strObtenu = Passerelle.Passerelle.checkValueIsCorrect("2");
            Assert.AreEqual(strAttendu, strObtenu.ToString());
        }


        [TestMethod]
        public void TestPasserelleCheckValueIsCorrectNumber()
        {
            String strAttendu = "";
            String strObtenu = Passerelle.Passerelle.checkValueIsCorrectNumber("aze");
            Assert.AreEqual(strAttendu, strObtenu.ToString());
            strAttendu = "1";
            strObtenu = Passerelle.Passerelle.checkValueIsCorrectNumber("1");
            Assert.AreEqual(strAttendu, strObtenu.ToString());
            
        }


        [TestMethod]
        public void TestPasserelleUtilisateurSession()
        {
            DateTime date = new DateTime(2017, 02, 02);
            DateTime dateAttendu = new DateTime(2017, 02, 02);
            Utilisateur visiteur = new Utilisateur("1", "david", "andre", "dandre", "oppg5", "106 rue victor hugo", "59000", "Lille", date, "2", "david.andre@gsb.com", 8); //c'est un visiteur

            Passerelle.Passerelle.setVisiteurSession(visiteur);
            Assert.AreEqual(visiteur, Passerelle.Passerelle.getVisiteurSession());

            Passerelle.Passerelle.setIdUtilisateurSession(visiteur.getId());
            Passerelle.Passerelle.setTypeUtilisateurSession(int.Parse(visiteur.getIdRole()));
            Assert.AreEqual(visiteur.getId(), Passerelle.Passerelle.getIdUtilisateurSession());
            Assert.AreEqual(2, Passerelle.Passerelle.getIdRoleUtilisateurSession());

        }

        [TestMethod]
        public void TestPasserelleUtilisateurSessionAdmin()
        {
            DateTime date = new DateTime(2017, 02, 02);
            DateTime dateAttendu = new DateTime(2017, 02, 02);
            Utilisateur visiteur = new Utilisateur("1", "admin", "admin", "admin", "admin", "106 rue victor hugo", "59000", "Lille", date, "0", "admin.admin@gsb.com", 8); //c'est un admin

            Passerelle.Passerelle.setVisiteurSession(visiteur);
            Assert.AreEqual(visiteur, Passerelle.Passerelle.getVisiteurSession());

            Passerelle.Passerelle.setIdUtilisateurSession(visiteur.getId());
            Passerelle.Passerelle.setTypeUtilisateurSession(int.Parse(visiteur.getIdRole()));
            Assert.AreEqual(visiteur.getId(), Passerelle.Passerelle.getIdUtilisateurSession());
            Assert.AreEqual(0, Passerelle.Passerelle.getIdRoleUtilisateurSession());

        }


        [TestMethod]
        public void TestPasserelleGeneral()
        {
            DateTime date = new DateTime(2017, 02, 02);
            DateTime dateAttendu = new DateTime(2017, 02, 02);

            BindingList<Medecin> listeDesMedecins = new BindingList<Medecin>();
            BindingList<Cabinet> listeDesCabinets = new BindingList<Cabinet>();
            BindingList<Visite> listeDesVisites = new BindingList<Visite>();
            BindingList<Utilisateur> listeDesVisiteurs = new BindingList<Utilisateur>();

            Utilisateur visiteur1 = new Utilisateur( "alexis", "testeur", "atesteur", "atesteur", "42 rue victor hugo", "59000", "Lille", date, "2", "alexis.testeur@gsb.com", 5);
            Utilisateur visiteur2 = new Utilisateur("louis", "dewavrin", "ldewavrin", "azert", "106 rue nova", "59000", "Lille", date, "2", "louis.dewavrin@gsb.com", 8);
            Utilisateur visiteur3 = new Utilisateur("admin", "admin", "admin", "admin", "106 rue victor hugo", "59000", "Lille", date, "2", "admin.admin@gsb.com", 2);
            /*listeDesVisiteurs.Add(visiteur1);
            listeDesVisiteurs.Add(visiteur2);
            listeDesVisiteurs.Add(visiteur3); */

            Cabinet cabinet1 = new Cabinet("101 rue nova", "59000", "Lille", 7859.6558, 87287.2782);
            Cabinet cabinet2 = new Cabinet("101 rue de la liberté", "59000", "Lille", 4459.658, 87287.2782);
            Cabinet cabinet3 = new Cabinet("82 rue nova", "59000", "Lille", 459.6558, 75287.2782);
            

            listeDesCabinets.Add(cabinet1);
            listeDesCabinets.Add(cabinet2);
            listeDesCabinets.Add(cabinet3);

            CollectionAssert.AreEqual(listeDesCabinets, listeDesCabinets);

            Medecin medecin1 = new Medecin("paul", "coupé", cabinet1);


            //Passerelle.Passerelle.
            


        }

        [TestMethod]
        public void TestPasserelleAdd()
        {
            Cabinet cabinet1 = new Cabinet(2, "rue Dupont", "59000", "Lille", 928.22, 222.22);
            Passerelle.Passerelle.addCabinet(cabinet1);
            DateTime date = new DateTime(2017, 02, 02);
            Utilisateur utilisateur1 = new Utilisateur("a17", "david", "andre", "dandre",
                "oppg5", "106 rue victor hugo", "59000", "Lille", date, "2", "david.andre@gsb.com", 8);
            Medecin medecin1 = new Medecin("Bernard", "Jean", cabinet1, utilisateur1);
            Passerelle.Passerelle.addMedecin(medecin1);
            DateTime heureArrivee = new DateTime(2017, 02, 02, 10, 30, 0, 0);
            DateTime heureDepart = new DateTime(2017, 02, 02, 12, 30, 0, 0);
            DateTime heureDebut = new DateTime(2017, 02, 02, 11, 30, 0, 0);
            Visite visite1 = new Visite(date, true, utilisateur1, medecin1, heureArrivee, heureDepart, heureDebut);
            Passerelle.Passerelle.addVisite(visite1);
        }

        [TestMethod]
        public void TestPasserelleEdit()
        {
            Cabinet cabinet1 = new Cabinet(2, "rue Dupont", "59000", "Lille", 928.22, 222.22);
            Passerelle.Passerelle.editCabinet(cabinet1);
            DateTime date = new DateTime(2017, 02, 02);
            Utilisateur utilisateur1 = new Utilisateur("a17", "david", "andre", "dandre",
                "oppg5", "106 rue victor hugo", "59000", "Lille", date, "2", "david.andre@gsb.com", 8);
            Medecin medecin1 = new Medecin("Bernard", "Jean", cabinet1, utilisateur1);
            Passerelle.Passerelle.editMedecin(medecin1);
            DateTime heureArrivee = new DateTime(2017, 02, 02, 10, 30, 0, 0);
            DateTime heureDepart = new DateTime(2017, 02, 02, 12, 30, 0, 0);
            DateTime heureDebut = new DateTime(2017, 02, 02, 11, 30, 0, 0);
            Visite visite1 = new Visite(date, true, utilisateur1, medecin1, heureArrivee, heureDepart, heureDebut);
            Passerelle.Passerelle.editVisite(visite1);
        }
    }
}
