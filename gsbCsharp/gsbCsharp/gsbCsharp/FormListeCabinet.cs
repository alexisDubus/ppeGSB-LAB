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
using GoogleMaps.LocationServices;

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
            String rue = textBoxRueCabinet.Text.ToString();
            String CP = textBoxCPCabinet.Text.ToString();
            String ville = textBoxVilleCabinet.Text.ToString();
            var address = rue + CP + " , " + ville;

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            try
            {
                var latitude = point.Latitude;
                var longitude = point.Longitude;
                Cabinet unCabinet = (Cabinet)comboBoxCabinet.SelectedItem;
                unCabinet.setCP(CP);
                unCabinet.setRue(rue);
                unCabinet.setVille(ville);
                unCabinet.setLatitude(latitude);
                unCabinet.setLongitude(longitude);
                Passerelle.Passerelle.editCabinet(unCabinet);
            }
            catch (Exception exe2) 
            {
                MessageBox.Show("L'adresse " + address + " n'existe pas");
            }

        }

        private void comboBoxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cabinet unCabinet = (Cabinet)comboBoxCabinet.SelectedItem;
            textBoxCPCabinet.Text = unCabinet.getCP();
            textBoxRueCabinet.Text = unCabinet.getRue();
            textBoxVilleCabinet.Text = unCabinet.getVille();
        }

        private void textBoxRueCabinet_TextChanged(object sender, EventArgs e)
        {
          /*  if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxRueCabinet.Text, "^[a-zA-Z]"))
            {
                //MessageBox.Show("This textbox accepts only alphabetical characters");
                textBoxRueCabinet.Text.Remove(textBoxRueCabinet.Text.Length - 1);
            } */
        }

        private void FormListeCabinet_Load(object sender, EventArgs e)
        {

        }
    }
}
