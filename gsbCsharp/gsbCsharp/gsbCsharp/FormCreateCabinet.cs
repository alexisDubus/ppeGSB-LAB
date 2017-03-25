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
    public partial class FormCreateCabinet : Form
    {
        public FormCreateCabinet()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCabinet_Click(object sender, EventArgs e)
        {
            String rue = textBoxRueCabinet.Text.ToString();
            String CP = textBoxCPCabinet.Text.ToString();
            String ville = textBoxVilleCabinet.Text.ToString();
            double longitude = 57807.6790;
            double latitude = 6890.0966;

            Cabinet unCabinet = new Cabinet(rue, CP, ville, longitude, latitude);
            Passerelle.Passerelle.addCabinet(unCabinet);
        }
    }
}
