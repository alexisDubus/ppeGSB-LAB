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
    public partial class FormCreateAvantage : Form
    {
        public FormCreateAvantage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = Passerelle.Passerelle.checkValueIsCorrect(txtCreateAvantage.Text.ToString());
            Avantage unAvantage= new Avantage(nom);
            Passerelle.Passerelle.addAvantage(unAvantage);
            txtCreateAvantage.Text = "";
            
        }

        private void FormCreateAvantage_Load(object sender, EventArgs e)
        {

        }
    }
}
