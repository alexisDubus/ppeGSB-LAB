using System;
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

namespace Passerelle
{
    /// <summary>
    /// sert a la connexion a la BDD et a faire le lien entre Métier et vue
    /// </summary>
    public static class Passerelle
    {
        private static List<Medecin> listeDesMedecins = new List<Medecin>();
        private static List<Cabinet> listeDesCabinets = new List<Cabinet>();
        private static List<Visite> listeDesVisites = new List<Visite>();
        private static List<Utilisateur> listeDesUtilisateurs = new List<Utilisateur>();
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
        public static List<Utilisateur> getAllVisiteur()
        {
            selectAllVisiteur();
            return listeDesUtilisateurs;
        }

        /// <summary>
        /// Selectionne tout les visiteurs et les met dans la liste
        /// </summary>
        public static void selectAllVisiteur()
        {
            connexion();
            MySqlCommand maCommande = maConnection.CreateCommand();
            String requeteSelect = "Select * from utilisateur;";
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
                listeDesUtilisateurs.Add(unUtilisateur); //on rajoute l'utilisateur a la liste

            }
            catch (Exception exe1)
            {

            }

        }

        #endregion



        #region Cabinet

        /// <summary>
        /// renvoi tout les cabinets
        /// </summary>
        /// <returns></returns>
        public static List<Cabinet> getAllCabinets()
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
            catch (Exception exe2)
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
