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
        public FormListeVisiteur()
        {
            InitializeComponent();
            listeVisiteur = Passerelle.Passerelle.getAllVisiteur();
            Passerelle.Passerelle.init();
            
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
            comboBoxListeMedecin.Items.Clear();
            foreach (Metier.Medecin medecin in  listeMedecin)
            {
                comboBoxListeMedecin.Items.Add(medecin);
            }
            comboBoxListeMedecin.SelectedItem = listeMedecin;
           
        }

        private void btnMedecin_Click(object sender, EventArgs e)
        {

        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            FormStatistique statistique = new FormStatistique((Utilisateur)comboBoxVisiteur.SelectedItem);
            statistique.Show();
        }

        private void comboBoxListeMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowMedecin_Click(object sender, EventArgs e)
        {
            Medecin unMedecin = (Medecin)comboBoxListeMedecin.SelectedItem;
            FormEditMedecin editUnMedecin = new FormEditMedecin(unMedecin);
            editUnMedecin.Show();
        }

        private void btnVoirVisites_Click(object sender, EventArgs e)
        {
            Utilisateur unVisiteur = (Utilisateur)comboBoxVisiteur.SelectedItem;
            FormViewVisiteVisiteur showVisiteVisiteur = new FormViewVisiteVisiteur(unVisiteur);
            showVisiteVisiteur.Show();
        }

        private void comboBoxListeDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
