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
    public partial class FormListeMedecin : Form
    {

        public static BindingList<Medecin> listeMedecin = new BindingList<Medecin>();
        public static BindingList<Utilisateur> listeVisiteur = new BindingList<Utilisateur>();
        public static BindingList<Cabinet> listeCabinet = new BindingList<Cabinet>();
        public FormListeMedecin()
        {
            InitializeComponent();
            listeCabinet = Passerelle.Passerelle.returnAllCabinets();
            listeMedecin = Passerelle.Passerelle.returnAllMedecin();
            listeVisiteur = Passerelle.Passerelle.returnAllvisiteur();

            foreach (Metier.Medecin leMedecin in listeMedecin)
            {
                comboBoxMedecin.Items.Add(leMedecin);
            }

            foreach (Metier.Utilisateur visiteur in listeVisiteur)
            {
                comboBoxMedecinVisiteur.Items.Add(visiteur);
            }

        }

        private void FormListeMedecin_Load(object sender, EventArgs e)
        {

        }


        private void comboBoxMedecin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Medecin unMedecin = (Medecin)comboBoxMedecin.SelectedItem;
            textBoxCabinet.Text = unMedecin.getCabinet().ToString();
            comboBoxMedecinVisiteur.SelectedItem = unMedecin.getVisiteur();
            textBoxNomMedecin.Text = unMedecin.getNom();
            textBoxPrenomMedecin.Text = unMedecin.getPrenom();
        }

        private void btnEditMedecin_Click(object sender, EventArgs e)
        {
            Medecin leMedecin = (Medecin)comboBoxMedecin.SelectedItem;
            leMedecin.setNom(Passerelle.Passerelle.checkValueIsCorrect(textBoxNomMedecin.Text));
            leMedecin.setPrenom(Passerelle.Passerelle.checkValueIsCorrect(textBoxPrenomMedecin.Text));
            Utilisateur unVisiteur = (Utilisateur)comboBoxMedecinVisiteur.SelectedItem;
            leMedecin.setVisiteur(unVisiteur);

            if (leMedecin.getNom() != "" && leMedecin.getPrenom() != "" && textBoxPrenomMedecin.Text != "" && textBoxPrenomMedecin.Text != "")
            {
                Passerelle.Passerelle.editMedecin(leMedecin);
            } else
            {
                MessageBox.Show("Les valeurs ne sont pas valides");
            }

            textBoxNomMedecin.Text = "";
            textBoxPrenomMedecin.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
