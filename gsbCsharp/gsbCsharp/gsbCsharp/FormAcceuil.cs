using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbCsharp
{
    public partial class FormAcceuil : Form
    {
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
    }
}
