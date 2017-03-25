using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    /// <summary>
    /// Classe utilisateur
    /// </summary>
    class Utilisateur
    {
        #region proprietes

        private String id;
        private String nom;
        private String prenom;
        private String login;
        private String mdp;
        private String adresse;
        private String cp;
        private String ville;
        private DateTime dateEmbauche;
        private String idRole;
        private String email;
        private int version;
        #endregion

        #region get
        public String getId()
        {
            return this.id;
        }

        public String getNom()
        {
            return this.nom;
        }

        public String getPrenom()
        {
            return this.prenom;
        }

        public String getMdp()
        {
            return this.mdp;
        }

        public String getAdresse()
        {
            return this.adresse;
        }

        public String getCp()
        {
            return this.cp;
        }

        public String getVille()
        {
            return this.ville;
        }

        public DateTime getDateEmbauche()
        {
            return this.dateEmbauche;
        }

        public String getIdRole()
        {
            return this.idRole;
        }

        public String getEmail()
        {
            return this.email;
        }

        public int getVersion()
        {
            return this.version;
        }


        #endregion

        #region set
        public void setId(String id)
        {
            this.id = id;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }

        public void setLogin(String login)
        {
            this.login = login;
        }

        public void setMdp(String mdp)
        {
            this.mdp = mdp;
        }

        public void setAdresse(String adresse)
        {
            this.adresse = adresse;
        }

        public void setCP(String cp)
        {
            this.cp = cp;
        }

        public void setVille(String ville)
        {
            this.ville = ville;
        }

        public void setDateEmbauche(DateTime dateEmbauche)
        {
            this.dateEmbauche = dateEmbauche;
        }

        public void setIdRole (String idRole )
        {
            this.idRole = idRole;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setVersion(int version)
        {
            this.version = version;
        }

        #endregion


        #region constructeur

        
        /// <summary>
        /// constructeur de l'utilisateur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <param name="adresse"></param>
        /// <param name="cp"></param>
        /// <param name="ville"></param>
        /// <param name="dateEmbauche"></param>
        /// <param name="idRole"></param>
        /// <param name="email"></param>
        /// <param name="version"></param>
        public Utilisateur(String id, String nom, String prenom, String login, String mdp, String adresse, String cp, String ville, DateTime dateEmbauche, String idRole, String email, int version)
        {
            setId(id);
            setNom(nom);
            setPrenom(prenom);
            setLogin(login);
            setMdp(mdp);
            setAdresse(adresse);
            setCP(cp);
            setVille(ville);
            setDateEmbauche(dateEmbauche);
            setIdRole(idRole);
            setEmail(email);
            setVersion(version);
        }

        /// <summary>
        /// créé un utilisateu vide
        /// </summary>
        public Utilisateur()
        {

        }

        #endregion

        #region fonction

        /// <summary>
        /// pour incrementer la version de cette utilisateur
        /// </summary>
        /// <returns></returns>
        public int incrementeVersion()
        {
            this.version++;
            return this.version;
            //faire liaison BBD
        }

        /// <summary>
        /// retourne vrai si l'utilisateur est un admin
        /// </summary>
        /// <returns></returns>
        public Boolean estUnAdmin()
        {
            if (this.getIdRole() == "0")
            {
                return true;
            }
            else
                return false;
        }



        #endregion

    }
}
