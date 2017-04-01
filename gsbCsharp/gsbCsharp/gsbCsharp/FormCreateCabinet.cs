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
using System.IO;
using System.Web;
using System.Xml;
using System.Net;
using Newtonsoft.Json;

namespace gsbCsharp
{
    public partial class FormCreateCabinet : Form
    {
        public double longitude;
        public double latitude;
        public FormCreateCabinet()
        {
            InitializeComponent();

            getGeoCode("155 rue de Wervicq", "59000", "Linselles");
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

        private void FormCreateCabinet_Load(object sender, EventArgs e)
        {

        }



        private void getGeoCode(String rue, String CP, String ville)
        {
            StreamReader streamR;
            string monUrl = "https://maps.googleapis.com/maps/api/geocode/json?address=" + rue + "+"+ville+ "+"+ CP;

            //var url = String.Format(monUrl);
            var url = String.Format("https://maps.googleapis.com/maps/api/geocode/xml?address=91+Rue+Nationale+Lille&key=%20AIzaSyC5EGGscQmGGxBT5hojO2ioVNZjVoJbFwE");


            var webClient = new WebClient();

            try
            {
                //récupére le résultat et le met dans le stream reader

                streamR = new StreamReader(webClient.OpenRead(url));
            }
            catch (Exception ex)
            {
                throw new Exception("the error was" + ex.Message);
            }
            
            var xmlTextReader = new XmlTextReader(streamR);
            xmlTextReader.Read();

            string[] coord = xmlTextReader.Value.Split(new char[] { ',' });

            string longitudeS = coord[0];
            string latitudeS = coord[1];

            MessageBox.Show(longitudeS + " , "+ latitudeS);
        }
    }
}
