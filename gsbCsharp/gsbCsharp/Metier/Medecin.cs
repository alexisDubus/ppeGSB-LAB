using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Medecin
    {
        #region proprietes
        private Utilisateur utilisateur = new Utilisateur(); //l'utilisateur sera vide
        private Cabinet cabinet = new Cabinet(); //le cabinet sera vide
        private int id; //mettre en static?
        private String nom;
        private String prenom;



        #endregion

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        /// <summary>
        /// créé un Médecin avec tout les paramétre disponible
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="cabinet"></param>
        /// <param name="utilisateur"></param>
        public Medecin(String nom, String prenom, Cabinet cabinet, Utilisateur utilisateur)
        {
            setNom(nom);
            setPrenom(prenom);
            setCabinet(cabinet);
            setVisiteur(utilisateur);
        }

        /// <summary>
        /// créé un Médecin avec tout les paramétre disponible
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="cabinet"></param>
        /// <param name="utilisateur"></param>
        public Medecin(int id, String nom, String prenom, Cabinet cabinet, Utilisateur utilisateur)
        {
            setId(id);
            setNom(nom);
            setPrenom(prenom);
            setCabinet(cabinet);
            setVisiteur(utilisateur);
        }


        /// <summary>
        /// créé un Médecin sans utilisateur attaché
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="cabinet"></param>
        public Medecin(int id, String nom, String prenom, Cabinet cabinet)
        {
            setId(id);
            setNom(nom);
            setPrenom(prenom);
            setCabinet(cabinet);
        }

        /// <summary>
        /// créé un Médecin sans utilisateur attaché
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="cabinet"></param>
        public Medecin(String nom, String prenom, Cabinet cabinet)
        {
            setNom(nom);
            setPrenom(prenom);
            setCabinet(cabinet);
        }


        #region constructeur
        /// <summary>
        /// créé un medecin vide
        /// </summary>
        public Medecin()
        {

        }

        #endregion

        #region get
        public int getId()
        {
            return this.id;
        }

        public String getNom()
        {
            return this.Nom;
        }

        public String getPrenom()
        {
            return this.Prenom;
        }

        public Cabinet getCabinet()
        {
            return this.cabinet;
        }

        public Utilisateur getVisiteur()
        {
            return this.utilisateur;
        }

        #endregion

        #region set
        public void setId(int id)
        {
            this.id = id;
        }

        public void setNom(String nom)
        {
            this.Nom = nom; 
        }

        public void setPrenom(String prenom)
        {
            this.Prenom = prenom;
        }

        
        public void setVisiteur(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
        }
       

        public void setCabinet(Cabinet cabinet)
        {
            this.cabinet = cabinet;
        }


        #endregion

        #region fonction
        public override String ToString()
        {
            String leString = this.getNom() + " " + this.getPrenom();
            return leString;
        }

        #endregion

    }
}
