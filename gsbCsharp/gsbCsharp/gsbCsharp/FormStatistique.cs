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
            BindingList<TimeSpan> lesTempsAttente = new BindingList<TimeSpan>();
            BindingList<TimeSpan> tempsTotal = new BindingList<TimeSpan>();
            foreach (Visite uneVisite in lesVisites)
            {
                if (uneVisite.getHeureDebut().Month == DateTime.Now.Month)
                {
                    if (uneVisite.getVisiteur().getId() == unUtilisateur.getId())
                    {
                        lesVisitesUtilisateur.Add(uneVisite);
                        lesTempsAttente.Add(uneVisite.getHeureDepart() - uneVisite.getHeureDebut());
                        tempsTotal.Add(uneVisite.getHeureDepart() - uneVisite.getHeureArrivee());
                    }
                }
            }
            lblStat2.Text = lesVisitesUtilisateur.Count.ToString();
            TimeSpan tempsAttenteMoyen = TimeSpan.FromMilliseconds(lesTempsAttente.Average(i => i.TotalMilliseconds));
            TimeSpan tempsPasseMoyen = TimeSpan.FromMilliseconds(tempsTotal.Average(i => i.TotalMilliseconds));
            lblStat3.Text = tempsPasseMoyen.Hours + " h " + tempsPasseMoyen.Minutes + " min " + tempsPasseMoyen.Seconds + " sec"; ;
            lblStat4.Text = tempsAttenteMoyen.Hours + " h " + tempsAttenteMoyen.Minutes + " min " + tempsAttenteMoyen.Seconds + " sec";
        }

        private void FormStatistique_Load(object sender, EventArgs e)
        {

        }
    }
}
