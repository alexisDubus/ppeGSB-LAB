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
using Metier;

namespace gsbCsharp
{
    public partial class FormStatistiques2 : Form
    {
        public FormStatistiques2(Utilisateur unUtilisateur)
        {
            InitializeComponent();
            lblStatUtilisateur.Text = unUtilisateur.getPrenom() + " " + unUtilisateur.getNom();
            statistiques(unUtilisateur);
        }

        private void FormStatistiques2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void statistiques(Utilisateur unUtilisateur)
        {
            lblStatValeur2 = unUtilisateur.get
        }
    }
}
