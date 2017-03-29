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
    public partial class FormViewVisiteVisiteur : Form
    {
        public static BindingList<Medecin> listeMedecin = new BindingList<Medecin>();
        public FormViewVisiteVisiteur(Utilisateur unVisiteur)
        {
            InitializeComponent();
            Passerelle.Passerelle.init();
            listeMedecin = Passerelle.Passerelle.returnAllMedecin();

            foreach (Metier.Medecin leMedecin in listeMedecin)
            {
                comboBoxMedecin.Items.Add(leMedecin);
            }
            //comboBoxMedecin.SelectedItem = unVisiteur.get();
        }

        private void FormViewVisiteVisiteur_Load(object sender, EventArgs e)
        {

        }
    }
}
