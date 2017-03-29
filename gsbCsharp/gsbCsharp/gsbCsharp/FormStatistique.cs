using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;
using Passerelle;

namespace gsbCsharp
{
    public partial class FormStatistique : Form
    {
        public FormStatistique(Utilisateur unUtilisateur)
        {
            InitializeComponent();
            lblStatUtilisateur.Text = unUtilisateur.getPrenom() + " " + unUtilisateur.getNom();
            statistiques(unUtilisateur);
        }

        public void statistiques(Utilisateur unUtilisateur)
        {
            BindingList<Visite> lesVisites = Passerelle.Passerelle.returnAllVisite();
            BindingList<Visite> lesVisitesUtilisateur = new BindingList<Visite>();
            foreach(Visite uneVisite in lesVisites)
            {
                if (uneVisite.getHeureDebut().Month == DateTime.Now.Month)
                {
                    if (uneVisite.getVisiteur().getId() == unUtilisateur.getId())
                    {
                        lesVisitesUtilisateur.Add(uneVisite);
                    }
                }
            }
            lblStat2.Text = lesVisitesUtilisateur.Count.ToString();
        }

        private void FormStatistique_Load(object sender, EventArgs e)
        {

        }
    }
}
