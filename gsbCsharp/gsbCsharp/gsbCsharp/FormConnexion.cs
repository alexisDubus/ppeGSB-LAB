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
