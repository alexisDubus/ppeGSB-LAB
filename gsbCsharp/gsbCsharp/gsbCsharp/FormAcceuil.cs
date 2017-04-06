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
            //Passerelle.Passerelle.init();
            //Passerelle.Passerelle.setTypeUtilisateur(2);
            //typeUtilisateur = Passerelle.Passerelle.getTypeUtilisateur();
            //Passerelle.Passerelle.setIdUtilisateur("a131"); //Changer valeur par id session

            //FormConnexion connexion = new FormConnexion();
            //OUVRE_UNE_MDI_FILLE(connexion, this);
        }

        public static void disableMenu()
        {
            
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

            if (Passerelle.Passerelle.getTypeUtilisateurSession() == 2) //case visiteur
            {
                menuStrip.Items[2].Visible = false;
                menuStrip.Items[1].Visible = false;
            }
            if (Passerelle.Passerelle.getTypeUtilisateurSession() == 0)//case admin
            {
                menuStrip.Items[3].Visible = false;
                menuStrip.Items[4].Visible = false;
            }
        }
        

        private void listeVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeVisiteur voirVisiteur = new FormListeVisiteur();
            OUVRE_UNE_MDI_FILLE(voirVisiteur, this);
        }
        

        //Méthode de click généré automatiquement

            
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        

        private void ajouterMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateMedecin creerUnMedecin = new FormCreateMedecin();
            OUVRE_UNE_MDI_FILLE(creerUnMedecin, this);
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateCabinet creerUnCabinet = new FormCreateCabinet();
            OUVRE_UNE_MDI_FILLE(creerUnCabinet, this);
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeMedecin listeMedecin = new FormListeMedecin();
            OUVRE_UNE_MDI_FILLE(listeMedecin, this);
        }

        private void ajouterVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateVisite listeVisite = new FormCreateVisite();
            OUVRE_UNE_MDI_FILLE(listeVisite, this);
        }

        private void visiteVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Liste des visites du visiteur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listeVisiteStripMenuItem2_Clic(object sender, EventArgs e)
        {
            FormViewVisiteVisiteur listeVisite = new FormViewVisiteVisiteur(Passerelle.Passerelle.visiteurSession);
            OUVRE_UNE_MDI_FILLE(listeVisite, this);
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormListeCabinet listeCabinet = new FormListeCabinet();
            OUVRE_UNE_MDI_FILLE(listeCabinet, this);
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistique stat = new FormStatistique(Passerelle.Passerelle.getVisiteurSession());
            OUVRE_UNE_MDI_FILLE(stat, this);
        }
    }
}
