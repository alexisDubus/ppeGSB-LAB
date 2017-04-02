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
    public partial class FormCreateVisite : Form
    {
        public static BindingList<Medecin> listeMedecin = new BindingList<Medecin>();
        public FormCreateVisite()
        {
            InitializeComponent();

            listeMedecin = Passerelle.Passerelle.returnAllMedecin();

            foreach (Metier.Medecin leMedecin in listeMedecin)
            {
                comboBoxMedecin.Items.Add(leMedecin);
            }
        }

        private void comboBoxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateMedecin_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            DateTime dateVisite = dateTimeViste.Value;
            DateTime heure = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeure.Text), Int32.Parse(txtBoxMin.Text), 0);
            DateTime heureArrivee = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeure.Text), Int32.Parse(txtBoxMin.Text), 0);
            DateTime heureDepart = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeure.Text), Int32.Parse(txtBoxMin.Text), 0);

            Medecin unMedecin = (Medecin)comboBoxMedecin.SelectedItem;
            Utilisateur unUtilisateur = (Utilisateur)comboBoxVisiteur.SelectedItem;
            Visite uneVisite = new Visite(dateVisite, true, unUtilisateur, unMedecin, heureArrivee, heureDepart, heure);

            Passerelle.Passerelle.addVisite(uneVisite);

            comboBoxMedecin.SelectedItem = "";
        }

        private void FormCreateVisite_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxHeure_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
