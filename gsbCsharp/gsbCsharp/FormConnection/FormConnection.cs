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
using gsbCsharp;

namespace FormConnection
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();
        }

        private void FormConnection_Load(object sender, EventArgs e)
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

        

        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            string passwd = textBoxMdp.Text.ToString();
            string username = textBoxLogin.Text.ToString();
            bool isAuth = Passerelle.Passerelle.connexionLDAP(username, passwd);
            if (isAuth)
            {
                FormAcceuil acceuil = new FormAcceuil();
                Passerelle.Passerelle.setTypeUtilisateurSession(0); //connexion admin
                acceuil.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mauvais mot de passe/Identifiant");
            }
        }
    }
}
