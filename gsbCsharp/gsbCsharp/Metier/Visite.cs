using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
   public class Visite
    {
        #region proprietes
        private Utilisateur utilisateur = new Utilisateur(); //l'utilisateur sera vide
        private Medecin medecin = new Medecin(); //le medecin sera vide
        private int id; 
        private DateTime dateVisite;
        private Boolean rdv;
        private DateTime heureArrivee;
        private DateTime heureDepart;
        private DateTime heureDebut;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        #endregion



        /// <summary>
        /// créateur de Visite
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dateVisite"></param>
        /// <param name="rdv"></param>
        /// <param name="visiteur"></param>
        /// <param name="medecin"></param>
        /// <param name="heureArrivee"></param>
        /// <param name="heureDepart"></param>
        /// <param name="heureDebut"></param>
        public Visite(int id, DateTime dateVisite, Boolean rdv, Utilisateur visiteur, Medecin medecin, DateTime heureArrivee, DateTime heureDepart, DateTime heureDebut)
        {
            setId(id);
            setDateVisite(dateVisite);
            setRdv(rdv);
            setUtilisateur(visiteur);
            setMedecin(medecin);
            setHeureArrivee(heureArrivee);
            setHeureDepart(heureDepart);
            setHeureDebut(heureDebut);
        }

        /// <summary>
        /// créateur de Visite
        /// </summary>
        /// <param name="dateVisite"></param>
        /// <param name="rdv"></param>
        /// <param name="visiteur"></param>
        /// <param name="medecin"></param>
        /// <param name="heureArrivee"></param>
        /// <param name="heureDepart"></param>
        /// <param name="heureDebut"></param>
        public Visite(DateTime dateVisite, Boolean rdv, Utilisateur visiteur, Medecin medecin, DateTime heureArrivee, DateTime heureDepart, DateTime heureDebut)
        {
            setDateVisite(dateVisite);
            setRdv(rdv);
            setUtilisateur(visiteur);
            setMedecin(medecin);
            setHeureArrivee(heureArrivee);
            setHeureDepart(heureDepart);
            setHeureDebut(heureDebut);
        }

        #region constructeur
        /// <summary>
        /// Créé une visite vide
        /// </summary>
        public Visite()
        {

        }

        #endregion

        #region get
        public int getId()
        {
            return this.Id;
        }

        public DateTime getDateVisite()
        {
            return this.dateVisite;
        }

        public Boolean getRdv()
        {
            return this.rdv;
        }

        public Utilisateur getVisiteur()
        {
            return this.utilisateur;
        }

        public Medecin getmedecin()
        {
            return this.medecin;
        }

        public DateTime getHeureArrivee()
        {
            return this.heureArrivee;
        }

        public DateTime getHeureDepart()
        {
            return this.heureDepart;
        }

        public DateTime getHeureDebut()
        {
            return this.heureDebut;
        }

        #endregion

        #region set

        public void setUtilisateur(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
        }

        public void setMedecin(Medecin medecin)
        {
            this.medecin = medecin;
        }

        public void setId(int id)
        {
            this.Id = id;
        }

        public void setRdv(Boolean rdv)
        {
            this.rdv = rdv;
        }

        public void setDateVisite(DateTime dateVisite)
        {
            this.dateVisite = dateVisite;
        }

        public void setHeureArrivee( DateTime heureArrivee)
        {
            this.heureArrivee = heureArrivee;
        }

        public void setHeureDepart(DateTime heureDepart)
        {
            this.heureDepart = heureDepart;
        }

        public void setHeureDebut(DateTime heureDebut)
        {
            this.heureDebut = heureDebut;
        }

        #endregion

        #region fonction 
        public override String ToString()
        {
            String leString = this.getDateVisite() + ", " + this.getmedecin().ToString() + ", " + this.getVisiteur().ToString();
            return leString;
        }

        #endregion

    }
}
