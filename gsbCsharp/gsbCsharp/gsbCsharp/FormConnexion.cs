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

namespace gsbCsharp
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
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


        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string passwd = textBoxMdp.Text.ToString();
            string username = textBoxLogin.Text.ToString();
            bool isAuth = Passerelle.Passerelle.connexionLDAP(username, passwd);
            if(isAuth)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Mauvais mot de passe/Identifiant");
            }
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
