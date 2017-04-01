﻿using System;
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

        private void btnMedecin_Click(object sender, EventArgs e)
        {

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

        private void comboBoxListeMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            String uneRegion = (String)textBoxDepartements.Text;
            listeVisiteur = Passerelle.Passerelle.getVisiteurByRegion(uneRegion);

            comboBoxVisiteur.Items.Clear();
            foreach (Metier.Utilisateur visiteur in listeVisiteur)
            {
                comboBoxVisiteur.Items.Add(visiteur);
            }

        }
    }
}
