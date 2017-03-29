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

namespace gsbCsharp
{
    public partial class FormStatistique : Form
    {
        public FormStatistique(Utilisateur unUtilisateur)
        {
            InitializeComponent();
            lblStatUtilisateur.Text = unUtilisateur.getPrenom() + " " + unUtilisateur.getNom();
            statistiques(unUtilisateur);
        }

        public void statistiques(Utilisateur unUtilisateur)
        {

        }

        private void FormStatistique_Load(object sender, EventArgs e)
        {

        }
    }
}
