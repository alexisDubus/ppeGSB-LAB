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
    public partial class FormAcceuil : Form
    {
        List<Utilisateur> listeVisiteur = new List<Utilisateur>();

        public FormAcceuil()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ferme la feuille ouverte précdemment et ouvre la nouvelle feuille
        /// </summary>
        /// <param name="uneForm">la feuille à ouvrir</param>
        /// <param name="laFeuilleMDI">la feuille mdi dans laquelle doit être ouverte la feuille</param>
        public static void OUVRE_UNE_MDI_FILLE(Form uneForm, Form laFeuilleMDI)
        {
            foreach (Form uneFeuille in laFeuilleMDI.MdiChildren)
                uneFeuille.Close();


            uneForm.MdiParent = laFeuilleMDI;
            uneForm.WindowState = FormWindowState.Maximized;
            uneForm.Show();
        }
        private void FormAcceuil_Load(object sender, EventArgs e)
        {
            listeVisiteur = Passerelle.Passerelle.getAllVisiteur();
            var source = new BindingSource(listeVisiteur, null);
            dataGridViewVisiteur.DataSource = source;
            visiteBindingSource.DataSource = listeVisiteur.ToArray();







            //BindingSource bds = new BindingSource();

            //bds.DataSource = listeVisiteur;
            //dataGridViewVisiteur.DataSource = bds;
            int nombrevisiteur = listeVisiteur.Count;
            textBoxNombreVisiteur.Text = nombrevisiteur.ToString();
        }

        private void classiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saisonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voirLesForfaitsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creationVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateVisiteur creerUnVisiteur = new FormCreateVisiteur();
            OUVRE_UNE_MDI_FILLE(creerUnVisiteur, this);
        }


        //Méthode de click généré automatiquement


        private void dataGridViewVisiteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVisiteur_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVisiteur_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void visiteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
