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
            

           // BindingList<Utilisateur> listVisiteur2 = new BindingList<Utilisateur>();
           // Utilisateur u1 = new Utilisateur("a11", "Dubus", "Alexis", "dalexis", "aaaaaaa", "155 rue poney", "59126", "Linselles",  new DateTime(1945, 03, 12), "2", "@@@", 1);
           // listVisiteur2.Add(u1);
            var source = new BindingSource(listeVisiteur, null);
            dataGridViewVisiteur.DataSource = source;
            

            //listBoxVisiteur.DataSource = source;

            
            foreach (Metier.Utilisateur leVisiteur in listeVisiteur)
            {
                comboBoxVisiteur.Items.Add(leVisiteur.getNom() + " " + leVisiteur.getPrenom() + " id: " + leVisiteur.getId());
            }

            BindGrid();
            



        }

        private void BindGrid()
        {
            dataGridViewVisiteur.AutoGenerateColumns = false;

            //create the column programatically
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colFileName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "nom",
                HeaderText = "nom",
                DataPropertyName = "nom" // Tell the column which property of FileName it should use
            };


            //var filelist = GetFileListOnWebServer().ToList();
            var filenamesList = new BindingList<Utilisateur>(listeVisiteur); // <-- BindingList

            //Bind BindingList directly to the DataGrid, no need of BindingSource
        }

        private void FormListeVisiteur_Load(object sender, EventArgs e)
        {

            //dataGridViewVisiteur.DataSource = source;
            //visiteBindingSource.DataSource = listeVisiteur.ToArray();
            //dataGridViewVisiteur.DataSource = source;

            //var bindingList = new BindingList<Utilisateur>(listeVisiteur);
            //var source = new BindingSource(bindingList, null);


            //listeVisiteur = Passerelle.Passerelle.getAllVisiteur();
            //var source = new BindingSource(listeVisiteur, null);
            //dataGridViewVisiteur.DataSource = source;
            //visiteBindingSource.DataSource = listeVisiteur.ToArray();

            //visiteBindingSource.DataSource = source;

            //dataGridViewVisiteur.DataSource = visiteBindingSource.DataSource;

            int nombrevisiteur = listeVisiteur.Count;
            textBoxNombreVisiteur.Text = nombrevisiteur.ToString();
        }

        private void dataGridViewVisiteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            FormListeVisiteur formListVisiteur = new FormListeVisiteur();
            // You can check senderComboBox.SelectedText or other here
            formListVisiteur.Text = senderComboBox.SelectedItem.ToString();
            formListVisiteur.ShowDialog();
        }

        private void comboBoxVisiteur_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
