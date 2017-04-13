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
        /// Appelé quand on clique sur le bouton de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            string passwd = textBoxMdp.Text.ToString();
            string username = textBoxLogin.Text.ToString();
            bool isAuth = Passerelle.Passerelle.connexionLDAP(username, passwd);
            if (isAuth) //si l'utilisateur est authentifié
            {
                FormAcceuil acceuil = new FormAcceuil();
                acceuil.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mauvais mot de passe/Identifiant");
                textBoxLogin.Text = "";
                textBoxMdp.Text = "";
            }
        }
    }
}
