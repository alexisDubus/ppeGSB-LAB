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
            foreach (Metier.Cabinet unCabinet in listeCabinet)
            {
                comboBoxMedecinCabinet.Items.Add(unCabinet);
            }
        }

        private void FormListeMedecin_Load(object sender, EventArgs e)
        {

        }


        private void comboBoxMedecin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Medecin unMedecin = (Medecin)comboBoxMedecin.SelectedItem;
            comboBoxMedecinCabinet.SelectedItem = unMedecin.getCabinet();
            comboBoxMedecinVisiteur.SelectedItem = unMedecin.getVisiteur();
            textBoxNomMedecin.Text = unMedecin.getNom();
            textBoxPrenomMedecin.Text = unMedecin.getPrenom();
        }

        private void btnEditMedecin_Click(object sender, EventArgs e)
        {
            comboBoxMedecinCabinet.SelectedItem = false;
            comboBoxMedecinVisiteur.SelectedItem = false;
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
