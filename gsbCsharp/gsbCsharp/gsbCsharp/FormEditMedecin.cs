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
    public partial class FormEditMedecin : Form
    {
        public static BindingList<Utilisateur> listeVisiteur = new BindingList<Utilisateur>();
        public static BindingList<Cabinet> listeCabinet = new BindingList<Cabinet>();
        public static Medecin leMedecin = new Medecin();
        public FormEditMedecin(Medecin unMedecin)
        {
            leMedecin = unMedecin;
            InitializeComponent();
            //Passerelle.Passerelle.init();
            listeCabinet = Passerelle.Passerelle.returnAllCabinets();
            listeVisiteur = Passerelle.Passerelle.returnAllvisiteur();
            
            foreach (Metier.Utilisateur visiteur in listeVisiteur)
            {
                comboBoxMedecinVisiteur.Items.Add(visiteur);
            }
            foreach (Metier.Cabinet unCabinet in listeCabinet)
            {
                comboBoxMedecinCabinet.Items.Add(unCabinet);
            }

            comboBoxMedecinCabinet.SelectedItem = unMedecin.getCabinet();
            comboBoxMedecinVisiteur.SelectedItem = unMedecin.getVisiteur();

            textBoxNomMedecin.Text = unMedecin.getNom();
            textBoxPrenomMedecin.Text = unMedecin.getPrenom();
        }

        private void FormEditMedecin_Load(object sender, EventArgs e)
        {

        }

        private void btnEditMedecin_Click(object sender, EventArgs e)
        {
            if(textBoxNomMedecin.Text == "" || textBoxNomMedecin.Text == " " || textBoxPrenomMedecin.Text == "" || textBoxPrenomMedecin.Text == " ")
            {
                MessageBox.Show("le nom/prénom ne doit pas étre vide! ");
            }
            else
            {
                leMedecin.setNom(textBoxNomMedecin.Text);
                leMedecin.setPrenom(textBoxPrenomMedecin.Text);
                Cabinet unCabinet = (Cabinet)comboBoxMedecinCabinet.SelectedItem;
                Utilisateur unVisiteur = (Utilisateur)comboBoxMedecinCabinet.SelectedItem;
                leMedecin.setCabinet(unCabinet);
                leMedecin.setVisiteur(unVisiteur);
                Passerelle.Passerelle.editMedecin(leMedecin);
            }
        }
    }
}
