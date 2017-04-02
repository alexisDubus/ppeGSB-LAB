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
            Utilisateur leVisiteur = Passerelle.Passerelle.getVisiteurUnique(Passerelle.Passerelle.getIdUtilisateur());
            listeMedecin = Passerelle.Passerelle.getListeMedecinVisiteur2(leVisiteur);


            listeVisite = Passerelle.Passerelle.getListeVisiteVisiteur(leVisiteur);

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
            txtBoxHeure.Text = uneVisite.getHeureDebut().Hour.ToString();
            txtBoxHeureArrivee.Text = uneVisite.getHeureArrivee().Hour.ToString();
            txtBoxHeureDepart.Text = uneVisite.getHeureDepart().Hour.ToString();
            txtBoxMin.Text = uneVisite.getHeureDebut().Minute.ToString();
            txtBoxMinArrivee.Text = uneVisite.getHeureArrivee().Minute.ToString();
            txtBoxMinDepart.Text = uneVisite.getHeureDepart().Minute.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Passerelle.Passerelle.supprimeVisite((Visite)comboBoxVisite.SelectedItem);
        }

        private void btnEditVisite_Click(object sender, EventArgs e)
        {
            Visite laVisite = (Visite)comboBoxVisite.SelectedItem;
            if (txtBoxHeure.Text == "" || txtBoxMin.Text == " " || txtBoxHeureArrivee.Text == "" || txtBoxMinArrivee.Text == " " || txtBoxHeureDepart.Text == "" || txtBoxMinDepart.Text == " ")
            {
                MessageBox.Show("les heures ne doivent pas étre vide! ");
            }
            else
            {
                DateTime date = new DateTime();
                DateTime heure = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeure.Text), Int32.Parse(txtBoxMin.Text), 0);
                DateTime heureArrivee = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeureArrivee.Text), Int32.Parse(txtBoxMinArrivee.Text), 0);
                DateTime heureDepart = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeureDepart.Text), Int32.Parse(txtBoxMinDepart.Text), 0);
                laVisite.setDateVisite(dateTimeViste.Value);
                laVisite.setHeureDebut(heure);
                laVisite.setHeureArrivee(heureArrivee);
                laVisite.setHeureDepart(heureDepart);
                Medecin unMedecin = (Medecin)comboBoxMedecin.SelectedItem;
                laVisite.setMedecin(unMedecin);
                Passerelle.Passerelle.editVisite(laVisite);
            }

            txtBoxHeure.Text = "";
            txtBoxHeureArrivee.Text = "";
            txtBoxHeureDepart.Text = "";
            txtBoxMin.Text = "";
            txtBoxMinArrivee.Text = "";
            txtBoxMinDepart.Text = "";
        }

        private void btnEditViste_Click_1(object sender, EventArgs e)
        {
            Visite laVisite = (Visite)comboBoxVisite.SelectedItem;
            if (txtBoxHeure.Text == "" || txtBoxMin.Text == " " || txtBoxHeureArrivee.Text == "" || txtBoxMinArrivee.Text == " " || txtBoxHeureDepart.Text == "" || txtBoxMinDepart.Text == " ")
            {
                MessageBox.Show("les heures ne doivent pas étre vide! ");
            }
            else
            {
                DateTime date = new DateTime();
                DateTime heure = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeure.Text), Int32.Parse(txtBoxMin.Text), 0);
                DateTime heureArrivee = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeureArrivee.Text), Int32.Parse(txtBoxMinArrivee.Text), 0);
                DateTime heureDepart = new DateTime(date.Year, date.Month, date.Day, Int32.Parse(txtBoxHeureDepart.Text), Int32.Parse(txtBoxMinDepart.Text), 0);
                laVisite.setDateVisite(dateTimeViste.Value);
                laVisite.setHeureDebut(heure);
                laVisite.setHeureArrivee(heureArrivee);
                laVisite.setHeureDepart(heureDepart);
                Medecin unMedecin = (Medecin)comboBoxMedecin.SelectedItem;
                laVisite.setMedecin(unMedecin);
                Passerelle.Passerelle.editVisite(laVisite);
            }

            txtBoxHeure.Text = "";
            txtBoxHeureArrivee.Text = "";
            txtBoxHeureDepart.Text = "";
            txtBoxMin.Text = "";
            txtBoxMinArrivee.Text = "";
            txtBoxMinDepart.Text = "";
        }
    }
}
