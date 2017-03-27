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
    public partial class FormListeMedecin : Form
    {

        public static BindingList<Medecin> listeMedecin = new BindingList<Medecin>();
        public FormListeMedecin()
        {
            InitializeComponent();
            listeMedecin = Passerelle.Passerelle.getAllMedecin();

            foreach (Metier.Medecin leMedecin in listeMedecin)
            {
                comboBoxMedecin.Items.Add(leMedecin);
            }
        }

        private void FormListeMedecin_Load(object sender, EventArgs e)
        {

        }


        private void comboBoxMedecin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            //MessageBox.Show(e.GetType().ToString());
            //var test = sender.GetType().ToString();
        }

        private void btnEditMedecin_Click(object sender, EventArgs e)
        {
            Medecin unMedecin = (Medecin)comboBoxMedecin.SelectedItem;
            //MessageBox.Show(unMedecin.getNom());
            textBoxNomMedecin.Visible = true;
            textBoxPrenomMedecin.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            buttonModifMedicin.Visible = true;
            textBoxNomMedecin.Text = unMedecin.getNom();
            textBoxPrenomMedecin.Text = unMedecin.getPrenom();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
