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
    public partial class FormCreateMedecin : Form
    {

        private static BindingList<Cabinet> listeDesCabinets = new BindingList<Cabinet>();

        private static BindingList<Utilisateur> listeDesVisiteur = new BindingList<Utilisateur>();

        public FormCreateMedecin()
        {
            InitializeComponent();

            
            listeDesCabinets = Passerelle.Passerelle.returnAllCabinets();
            listeDesVisiteur = Passerelle.Passerelle.returnAllvisiteur();
            

            foreach (Metier.Utilisateur visiteur in listeDesVisiteur)
            {
                comboBoxMedecinVisiteur.Items.Add(visiteur);
            }
            foreach (Metier.Cabinet unCabinet in listeDesCabinets)
            {
                comboBoxMedecinCabinet.Items.Add(unCabinet);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCreateMedecin_Load(object sender, EventArgs e)
        {
            
        }

        private void listBoxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouteMedecin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateMedecin_Click(object sender, EventArgs e)
        {
            String nom = Passerelle.Passerelle.checkValueIsCorrect(textBoxNomMedecin.Text.ToString());
            String prenom = Passerelle.Passerelle.checkValueIsCorrect(textBoxPrenomMedecin.Text.ToString());
            Utilisateur unUtilisateur = (Utilisateur)comboBoxMedecinVisiteur.SelectedItem;
            Cabinet unCabinet = (Cabinet)comboBoxMedecinCabinet.SelectedItem;
            Medecin unMedecin = new Medecin(nom, prenom, unCabinet, unUtilisateur);
            if (nom != "" && prenom != "")
            {
                if(unUtilisateur != null)
                {
                    if (unCabinet != null)
                    {
                        Passerelle.Passerelle.addMedecin(unMedecin);
                        textBoxNomMedecin.Text = "";
                        textBoxPrenomMedecin.Text = "";
                        comboBoxMedecinVisiteur.SelectedItem = "";
                        comboBoxMedecinCabinet.SelectedItem = "";
                    }
                    else
                    {
                        MessageBox.Show("Il faut sélectionner un cabinet");
                    }
                }
                else
                {
                    MessageBox.Show("Il faut sélectionner un utilisateur");
                }
            } else
            {
                MessageBox.Show("Les valeurs ne sont pas valides");
            }

            
        }

        private void textBoxNomMedecin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
