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
    public partial class FormListeVisiteur : Form
    {
        public static BindingList<Utilisateur> listeVisiteur = new BindingList<Utilisateur>();
        public static BindingList<String> listeDepartements = new BindingList<String>();
        public FormListeVisiteur()
        {
            InitializeComponent();
            listeVisiteur = Passerelle.Passerelle.returnAllvisiteur();

            foreach (Metier.Utilisateur visiteur in listeVisiteur)
            {
                comboBoxVisiteur.Items.Add(visiteur);
            }

        }
        

        private void FormListeVisiteur_Load(object sender, EventArgs e)
        {

        }
        

        private void comboBoxVisiteur_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            Utilisateur unVisiteur = (Utilisateur)comboBoxVisiteur.SelectedItem;
            BindingList<Medecin> listeMedecin = Passerelle.Passerelle.getListeMedecinVisiteur2(unVisiteur);

            dataGridViewMedecin.DataSource = listeMedecin;

           
        }
        

        private void btnStat_Click(object sender, EventArgs e)
        {
            if (comboBoxVisiteur.SelectedItem != null)
            {
                FormStatistique statistique = new FormStatistique((Utilisateur)comboBoxVisiteur.SelectedItem);
                statistique.Show();
            } else
            {
                MessageBox.Show("Aucun visiteur séléctionné");
            }
            
        }
        

        private void btnShowMedecin_Click(object sender, EventArgs e)
        {
           /* Medecin unMedecin = (Medecin)dataGridViewMedecin.SelectedCells.
            FormEditMedecin editUnMedecin = new FormEditMedecin(unMedecin);
            editUnMedecin.Show(); */
        }
        

        private void comboBoxListeDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxDepartements.Text == "" || textBoxDepartements.Text == " " || textBoxDepartements.Text == "  " || textBoxDepartements.Text == "   " || textBoxDepartements.Text == "   ")
            {
                MessageBox.Show("le département ne peut pas étre nul!");
            }
            else
            {
                String uneRegion = (String)textBoxDepartements.Text;
                listeVisiteur = Passerelle.Passerelle.getVisiteurByRegion(uneRegion);

                comboBoxVisiteur.Items.Clear();
                foreach (Metier.Utilisateur visiteur in listeVisiteur)
                {
                    comboBoxVisiteur.Items.Add(visiteur);
                }
            }

        }
        

        private void btnSearchByNom_Click(object sender, EventArgs e)
        {
            if(textBoxNom.Text == "" || textBoxNom.Text == " " || textBoxNom.Text == "  " || textBoxNom.Text == "   " || textBoxNom.Text == "   ")
            {
                MessageBox.Show("le nom ne peut pas étre nul!");
            }
            else
            {
                String nom = (String)textBoxNom.Text;
                listeVisiteur = Passerelle.Passerelle.getVisiteurByNom(nom);

                comboBoxVisiteur.Items.Clear();
                foreach (Metier.Utilisateur visiteur in listeVisiteur)
                {
                    comboBoxVisiteur.Items.Add(visiteur);
                }
            }
        }

        private void textBoxDepartements_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
