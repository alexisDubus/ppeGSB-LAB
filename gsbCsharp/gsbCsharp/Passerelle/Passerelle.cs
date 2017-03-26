﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using Metier;
using System.ComponentModel;

namespace Passerelle
{
    /// <summary>
    /// sert a la connexion a la BDD et a faire le lien entre Métier et vue
    /// </summary>
    public static class Passerelle
    {
        
        private static BindingList<Medecin> listeDesMedecins = new BindingList<Medecin>();
        private static BindingList<Cabinet> listeDesCabinets = new BindingList<Cabinet>();
        private static BindingList<Visite> listeDesVisites = new BindingList<Visite>();
        private static BindingList<Utilisateur> listeDesVisiteurs = new BindingList<Utilisateur>();
        private static String connectionString = "SERVER=127.0.0.1; DATABASE=gsb_frais; UID=lamp; PASSWORD=AzertY!59";
        //private static String connectionString = "SERVER=172.16.9.4; DATABASE=gsb_frais; UID=lamp; PASSWORD=AzertY!59";
        private static MySqlConnection maConnection;

        

        /// <summary>
        /// fonction de connexion a la base de données
        /// </summary>
        public static void connexion()
        {
            maConnection = new MySqlConnection(connectionString);
            maConnection.Open();
        }

        #region Utilisateur

        /// <summary>
        /// renvoi tout les utilisateurs
        /// </summary>
        /// <returns></returns>
        public static BindingList<Utilisateur> getAllVisiteur()
        {
            BindingList<Medecin> listeReset = new BindingList<Medecin>();
            listeDesMedecins = listeReset;
            selectAllVisiteur();
            return listeDesVisiteurs;
        }

        /// <summary>
        /// Selectionne tout les visiteurs et les met dans la liste
        /// </summary>
        public static void selectAllVisiteur()
        {
            connexion();
            MySqlCommand maCommande = maConnection.CreateCommand();
            String requeteSelect = "Select * from utilisateur where idRole = 2;";
            maCommande.CommandText = requeteSelect;
            MySqlDataReader unJeuResultat = maCommande.ExecuteReader();
            //return unJeuResultat;

            while (unJeuResultat.Read())
            {
                getAVisiteur(unJeuResultat);
            }

            unJeuResultat.Close();
        }


        public static void getAVisiteur(MySqlDataReader unJeuResultat)
        {

            String id = (String)unJeuResultat.GetString("id");
            String nom = (String)unJeuResultat.GetString("nom");
            String prenom = (String)unJeuResultat.GetString("prenom");
            String login = (String)unJeuResultat.GetString("login");
            String adresse = (String)unJeuResultat.GetString("adresse");
            String cp = (String)unJeuResultat.GetString("cp");
            String ville = (String)unJeuResultat.GetString("ville");
            DateTime dateEmbauche = (DateTime)unJeuResultat.GetMySqlDateTime("dateEmbauche");
            String idRole = (String)unJeuResultat.GetString("idRole");
            String email = (String)unJeuResultat.GetString("email");
            String mdp = (String)unJeuResultat.GetString("mdp");
            int version = (int)unJeuResultat.GetInt16("version");
            try
            {
                Utilisateur unUtilisateur = new Utilisateur(id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche, idRole, email, version);
                listeDesVisiteurs.Add(unUtilisateur); //on rajoute l'utilisateur a la liste

            }
            catch (Exception exeUtilisateur)
            {

            }

        }

        #endregion


        #region Medecin

        /// <summary>
        /// renvoi tout les Medecin
        /// </summary>
        /// <returns></returns>
        public static BindingList<Utilisateur> getAllMedecin()
        {
            selectAllMedecin();
            return listeDesVisiteurs;
        }

        /// <summary>
        /// Selectionne tout les medecin et les met dans la liste
        /// </summary>
        public static void selectAllMedecin()
        {
            connexion();
            MySqlCommand maCommande = maConnection.CreateCommand();
            String requeteSelect = "Select * from medecin;";
            maCommande.CommandText = requeteSelect;
            MySqlDataReader unJeuResultat = maCommande.ExecuteReader();
            //return unJeuResultat;

            while (unJeuResultat.Read())
            {
                getAMedecin(unJeuResultat);
            }

            unJeuResultat.Close();
        }


        public static void getAMedecin(MySqlDataReader unJeuResultat)
        {

            int id = (int)unJeuResultat.GetInt16("id");
            String nom = (String)unJeuResultat.GetString("nom");
            String prenom = (String)unJeuResultat.GetString("prenom");
            int idCabinet = (int)unJeuResultat.GetInt16("idcabinet");
            String idUtilisateur = (String)unJeuResultat.GetString("idutilisateur");
            try
            {
                Utilisateur unUtilisateur = new Utilisateur();
                Cabinet unCabinet = new Cabinet();
                foreach (Metier.Utilisateur leVisiteur in listeDesVisiteurs)
                {
                    if (idUtilisateur == leVisiteur.getId())
                        unUtilisateur = leVisiteur;
                }

                foreach (Metier.Cabinet leCabinet in listeDesCabinets)
                {
                    if (idCabinet == leCabinet.getId())
                        unCabinet = leCabinet;
                }

                Medecin unMedecin = new Medecin(id, nom, prenom, unCabinet, unUtilisateur);
                listeDesMedecins.Add(unMedecin);

            }
            catch (Exception exeMedecin)
            {

            }

        }

        #endregion


        #region Visite

        /// <summary>
        /// renvoi tout les Visites
        /// </summary>
        /// <returns></returns>
        public static BindingList<Visite> getAllVisite()
        {
            selectAllVisite();
            return listeDesVisites;
        }

        /// <summary>
        /// Selectionne tout les Visites et les met dans la liste
        /// </summary>
        public static void selectAllVisite()
        {
            connexion();
            MySqlCommand maCommande = maConnection.CreateCommand();
            String requeteSelect = "Select * from visite;";
            maCommande.CommandText = requeteSelect;
            MySqlDataReader unJeuResultat = maCommande.ExecuteReader();
            //return unJeuResultat;

            while (unJeuResultat.Read())
            {
                getAVisite(unJeuResultat);
            }

            unJeuResultat.Close();
        }


        public static void getAVisite(MySqlDataReader unJeuResultat)
        {

            int id = (int)unJeuResultat.GetInt16("id");
            DateTime dateVisite = (DateTime)unJeuResultat.GetDateTime("dateVisite");
            Boolean rdv = (Boolean)unJeuResultat.GetBoolean("rdv");
            String idUtilisateur = (String)unJeuResultat.GetString("idutilisateur");
            int idMedecin = (int)unJeuResultat.GetInt16("idMedecin");
            DateTime heureArrivee = (DateTime)unJeuResultat.GetDateTime("heureArrivee");
            DateTime heureDepart = (DateTime)unJeuResultat.GetDateTime("heureDepart");
            DateTime heureDebut = (DateTime)unJeuResultat.GetDateTime("heureDebut");
            try
            {
                Utilisateur unUtilisateur = new Utilisateur();
                Medecin unMedecin = new Medecin();
                foreach (Metier.Utilisateur leVisiteur in listeDesVisiteurs)
                {
                    if (idUtilisateur == leVisiteur.getId())
                        unUtilisateur = leVisiteur;
                }

                foreach (Metier.Medecin leMedecin in listeDesMedecins)
                {
                    if (idMedecin == leMedecin.getId())
                        unMedecin = leMedecin;
                }

                Visite visite = new Visite(id, dateVisite, rdv, unUtilisateur, unMedecin, heureArrivee, heureDepart, heureDebut);
                listeDesVisites.Add(visite);

            }
            catch (Exception exeVisite)
            {

            }

        }

        #endregion


        #region Cabinet

        /// <summary>
        /// renvoi tout les cabinets
        /// </summary>
        /// <returns></returns>
        public static BindingList<Cabinet> getAllCabinets()
        {
            selectAllCabinets();
            return listeDesCabinets;
        }

        /// <summary>
        /// Selectionne tout les cabinets et les met dans la liste
        /// </summary>
        public static void selectAllCabinets()
        {
            connexion();
            MySqlCommand maCommande = maConnection.CreateCommand();
            String requeteSelect = "Select * from cabinet;";
            maCommande.CommandText = requeteSelect;
            MySqlDataReader unJeuResultat = maCommande.ExecuteReader();
            //return unJeuResultat;

            while (unJeuResultat.Read())
            {
                getACabinet(unJeuResultat);

            }

            unJeuResultat.Close();
        }

        public static void getACabinet(MySqlDataReader unJeuResultat)
        {
            int id = (int)unJeuResultat.GetInt16("id");
            String rue = (String)unJeuResultat.GetString("rue");
            String cp = (String)unJeuResultat.GetString("CP");
            String ville = (String)unJeuResultat.GetString("ville");
            double longitude = (double)unJeuResultat.GetDouble("longitude");
            double latitude = (double)unJeuResultat.GetDouble("latitude");
            try
            {
                Cabinet unCabinet = new Cabinet(id, rue, cp, ville, longitude, latitude);
                listeDesCabinets.Add(unCabinet);

            }
            catch (Exception exeCabinet)
            {

            }
        }


        public static void addCabinet(Cabinet cabinet)
        {
            connexion();
            MySqlCommand maCommande = maConnection.CreateCommand();
            maCommande.CommandText = "INSERT INTO cabinet(rue, CP, ville, longitude, latitude) VALUES(@rue, @CP, @ville, @longitude, @latitude);";
            //maCommande.Parameters.AddWithValue("@id", cabinet.getId());
            maCommande.Parameters.AddWithValue("@rue", cabinet.getRue());
            maCommande.Parameters.AddWithValue("@CP", cabinet.getCP());
            maCommande.Parameters.AddWithValue("@ville", cabinet.getVille());
            maCommande.Parameters.AddWithValue("@longitude", cabinet.getLongitude());
            maCommande.Parameters.AddWithValue("@latitude", cabinet.getLatitude());

            maCommande.ExecuteNonQuery();
            int lastId = (int)maCommande.LastInsertedId;
            cabinet.setId(lastId);
            listeDesCabinets.Add(cabinet);
        }

        #endregion


    }
}
