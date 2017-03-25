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
        //private static List<ForfaitSki> listeDesForfaits = initPasserelle();
        private static List<Utilisateur> listeDesUtilisateurs = new List<Utilisateur>();
        private static String connectionString = "SERVER=172.16.9.3; DATABASE=gsb_frais; UID=lamp; PASSWORD=AzertY!59";
        private static MySqlConnection maConnection;

        public static void connexion()
        {
            maConnection = new MySqlConnection(connectionString);
            maConnection.Open();
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
                    Utilisateur unUtilisateur = new Utilisateur( id,  nom,  prenom,  login,  mdp,  adresse,  cp,  ville,  dateEmbauche,  idRole,  email,  version);
                    listeDesUtilisateurs.Add(unUtilisateur); //on rajoute l'utilisateur a la liste

                }
                catch (Exception exe1)
                {

                }
                
            }

            unJeuResultat.Close();
        }

    }
}
