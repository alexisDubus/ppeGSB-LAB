using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data;
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
        public static BindingList<String> listeDepartements = new BindingList<String>();
        private static BindingList<Medecin> listeDesMedecins = new BindingList<Medecin>();
        private static BindingList<Cabinet> listeDesCabinets = new BindingList<Cabinet>();
        private static BindingList<Visite> listeDesVisites = new BindingList<Visite>();
        private static BindingList<Utilisateur> listeDesVisiteurs = new BindingList<Utilisateur>();
        //private static String connectionString = "SERVER=172.16.9.3; DATABASE=gsb_frais; UID=lamp; PASSWORD=AzertY!59";
        private static String connectionString = "SERVER=127.0.0.1; DATABASE=gsb_frais; UID=lamp; PASSWORD=AzertY!59";
        private static MySqlConnection maConnection;

        
        /// <summary>
        /// fonction de connexion a la base de données
        /// </summary>
        public static void connexion()
        {
            maConnection = new MySqlConnection(connectionString);
            try
            {
                maConnection.Open();
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        throw new Exception("Cannot connect to server.  Contact administrator");
                       
                    case 1042:
                        throw new Exception("Unable to connect to any of the specified MySQL hosts.");

                    case 1045:
                        throw new Exception("Invalid username/password, please try again");

                    default:
                        throw new Exception("erreur inconnue");
                }
            }
        }

        public static void init()
        {
            listeDesCabinets = getAllCabinets();

            listeDesVisiteurs = getAllVisiteur();

            listeDesMedecins = getAllMedecin();
            
            listeDesVisites = getAllVisite();

            initListeDepartements();
        }

        public static void initListeDepartements()
        {
            BindingList<String> listeReset = new BindingList<String>();
            listeDepartements = listeReset;
            for (int i = 1; i <= 9; i++)
            {
                listeDepartements.Add("0"+ i.ToString() +"000");
            }
            for (int i = 10; i <= 95; i++)
            {
                listeDepartements.Add(i.ToString() + "000");
            }
            listeDepartements.Add("97100");
            listeDepartements.Add("97200");
            listeDepartements.Add("97300");
            listeDepartements.Add("97400");
            listeDepartements.Add("97600");
        }

        public static BindingList<String> returnListeDepartements()
        {
            return listeDepartements;
        }
            

        #region Utilisateur

        public static BindingList<Medecin> getListeMedecinVisiteur2(Utilisateur unVisiteur)
        {
            BindingList<Medecin> liste = new BindingList<Medecin>();
            Utilisateur leVisiteur;
            foreach (Metier.Medecin leMedecin in listeDesMedecins)

            {
                leVisiteur = leMedecin.getVisiteur();
                if (unVisiteur.getId()==leVisiteur.getId())
                    liste.Add(leMedecin);
            }
            return liste;
        }

        /// <summary>
        /// Inutilisé
        /// </summary>
        /// <param name="unVisiteur"></param>
        /// <returns></returns>
        public static BindingList<Medecin> getListeMedecinVisiteur(Utilisateur unVisiteur)
        {
            connexion();
            BindingList<Medecin> listeMedecin = new BindingList<Medecin>();
            MySqlCommand maCommande = maConnection.CreateCommand();
            String requeteSelect = "Select * from medecin where idutilisateur = '"+ unVisiteur.getId() + "'";
            maCommande.CommandText = requeteSelect;
            MySqlDataReader unJeuResultat = maCommande.ExecuteReader();

            while (unJeuResultat.Read())
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
                    listeMedecin.Add(unMedecin);

                }
                catch (Exception exeMedecin)
                {

                }
                
            }

            unJeuResultat.Close();
            return listeMedecin;
        }


        /// <summary>
        /// Retourne la liste des Visiteur, aucune requéte
        /// </summary>
        /// <returns></returns>
        public static BindingList<Utilisateur> returnAllvisiteur()
        {
            return listeDesVisiteurs;
        }

        /// <summary>
        /// renvoi tout les utilisateurs aprés les avoir récupéré de la BDD
        /// </summary>
        /// <returns></returns>
        public static BindingList<Utilisateur> getAllVisiteur()
        {
            BindingList<Utilisateur> listeReset = new BindingList<Utilisateur>();
            listeDesVisiteurs = listeReset;
            
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
        /// Retourne la liste des Medecin, aucune requéte
        /// </summary>
        /// <returns></returns>
        public static BindingList<Medecin> returnAllMedecin()
        {
            return listeDesMedecins;
        }

        /// <summary>
        /// renvoi tout les Medecin  aprés les avoir récupéré de la BDD
        /// </summary>
        /// <returns></returns>
        public static BindingList<Medecin> getAllMedecin()
        {
            BindingList<Medecin> listeReset = new BindingList<Medecin>();
            listeDesMedecins = listeReset;
            selectAllMedecin();
            return listeDesMedecins;
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

        /// <summary>
        /// Insére le médecin donné en paramétre dans la BDD
        /// </summary>
        /// <param name="medecin"></param>
        public static void addMedecin(Medecin medecin)
        {
            connexion();
            MySqlCommand maCommande = maConnection.CreateCommand();
            maCommande.CommandText = "INSERT INTO medecin(nom, prenom, idCabinet, idUtilisateur) VALUES(@nom, @prenom, @idcabinet, @idutilisateur);";
            maCommande.Parameters.AddWithValue("@nom", medecin.getNom());
            maCommande.Parameters.AddWithValue("@prenom", medecin.getPrenom());
            maCommande.Parameters.AddWithValue("@idCabinet", medecin.getCabinet().getId());
            maCommande.Parameters.AddWithValue("@idUtilisateur", medecin.getVisiteur().getId());

            maCommande.ExecuteNonQuery();
            int lastId = (int)maCommande.LastInsertedId;
            medecin.setId(lastId);
            listeDesMedecins.Add(medecin);
        }

        public static void editMedecin(Medecin medecin)
        {
            connexion();
            MySqlCommand maCommande = maConnection.CreateCommand();
           /* MySqlCommand maCommande = maConnection.CreateCommand();
            maCommande.CommandText = "UPDATE  medecin set nom = '" + medecin.getNom() + "', prenom = '" + medecin.getPrenom() + "', idcabinet = '" + medecin.getCabinet().getId() + "', idutilisateur = '" + medecin.getVisiteur().getId() + "' where medecin.id = '" + medecin.getId() + "'"; */
            maCommande.CommandText = "UPDATE  medecin set nom = @nom, prenom = @prenom, idcabinet = @idCabinet, idutilisateur = @idUtilisateur where medecin.id = @id";
            maCommande.Parameters.AddWithValue("@id", medecin.getId());
            maCommande.Parameters.AddWithValue("@nom", medecin.getNom());
            maCommande.Parameters.AddWithValue("@prenom", medecin.getPrenom());
            maCommande.Parameters.AddWithValue("@idCabinet", medecin.getCabinet().getId());
            maCommande.Parameters.AddWithValue("@idUtilisateur", medecin.getVisiteur().getId());

            maCommande.ExecuteNonQuery();
            init();
        }
        
        /// <summary>
        /// Retourne une liste de visiteurs en fonction de leur code postal (CP)
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public static BindingList<Utilisateur> getVisiteurByRegion(String region)
        {
            BindingList<Utilisateur> liste = new BindingList<Utilisateur>();
            foreach (Metier.Utilisateur unVisiteur in listeDesVisiteurs)
            {
                if(region.Length == 5)
                {
                    region = region.Substring(0, 2);
                }
                if (unVisiteur.getCp().StartsWith(region))
                    liste.Add(unVisiteur);
            }
            return liste;
        }


        #endregion


        #region Visite


        /// <summary>
        /// Retourne la liste des Visite, aucune requéte
        /// </summary>
        /// <returns></returns>
        public static BindingList<Visite> returnAllVisite()
        {
            return listeDesVisites;
        }

        /// <summary>
        /// renvoi tout les Visites aprés les avoir récupéré de la BDD
        /// </summary>
        /// <returns></returns>
        public static BindingList<Visite> getAllVisite()
        {
            BindingList<Visite> listeReset = new BindingList<Visite>();
            listeDesVisites = listeReset;
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
        /// Retourne la liste des Cabinets, aucune requéte
        /// </summary>
        /// <returns></returns>
        public static BindingList<Cabinet> returnAllCabinets()
        {
            return listeDesCabinets;
        }

        /// <summary>
        /// renvoi tout les cabinets aprés les avoir récupéré de la BDD
        /// </summary>
        /// <returns></returns>
        public static BindingList<Cabinet> getAllCabinets()
        {
            BindingList<Cabinet> listeReset = new BindingList<Cabinet>();
            listeDesCabinets = listeReset;
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
