using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Passerelle;
using Metier;

namespace gsbCsharp
{
    public partial class FormViewVisiteVisiteur : Form
    {
        public static BindingList<Medecin> listeMedecin = new BindingList<Medecin>();
        public static BindingList<Visite> listeVisite = new BindingList<Visite>();
        public FormViewVisiteVisiteur(Utilisateur unVisiteur)
        {
            InitializeComponent();
            
            listeMedecin = Passerelle.Passerelle.returnAllMedecin();

            listeVisite = Passerelle.Passerelle.returnAllVisite();

            foreach (Metier.Visite laVisite in listeVisite)
            {
                comboBoxVisite.Items.Add(laVisite);
            }

            foreach (Metier.Medecin leMedecin in listeMedecin)
            {
                comboBoxMedecin.Items.Add(leMedecin);
            }
            //comboBoxMedecin.SelectedItem = unVisiteur.get();
        }

        private void FormViewVisiteVisiteur_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVisite_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visite uneVisite = (Visite)comboBoxVisite.SelectedItem;
            comboBoxMedecin.SelectedItem = uneVisite.getmedecin();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
