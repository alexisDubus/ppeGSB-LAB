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
    public partial class FormListeCabinet : Form
    {
        public static BindingList<Cabinet> listeCabinet = new BindingList<Cabinet>();
        public FormListeCabinet()
        {
            InitializeComponent();
            listeCabinet = Passerelle.Passerelle.returnAllCabinets();

            foreach (Metier.Cabinet unCabinet in listeCabinet)
            {
                comboBoxCabinet.Items.Add(unCabinet);
            }
        }

        private void btnEditCabinet_Click(object sender, EventArgs e)
        {
            double lat = 36799.765480;
            double longi = 5780988.6548902;
            Cabinet unCabinet = (Cabinet)comboBoxCabinet.SelectedItem;
            unCabinet.setCP(textBoxCPCabinet.Text);
            unCabinet.setRue(textBoxRueCabinet.Text);
            unCabinet.setVille(textBoxVilleCabinet.Text);
            unCabinet.setLatitude(lat);
            unCabinet.setLongitude(longi);
        }

        private void comboBoxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cabinet unCabinet = (Cabinet)comboBoxCabinet.SelectedItem;
            textBoxCPCabinet.Text = unCabinet.getCP();
            textBoxRueCabinet.Text = unCabinet.getRue();
            textBoxVilleCabinet.Text = unCabinet.getVille();
        }
    }
}
