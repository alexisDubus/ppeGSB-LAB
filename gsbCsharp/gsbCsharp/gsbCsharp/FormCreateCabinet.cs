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
using GoogleMaps.LocationServices;

namespace gsbCsharp
{
    public partial class FormCreateCabinet : Form
    {
        public double longitude;
        public double latitude;
        public FormCreateCabinet()
        {
            InitializeComponent();
            //getGeoCodeLocation();
            //getGeoCode("155 rue de Wervicq", "59000", "Linselles");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCabinet_Click(object sender, EventArgs e)
        {
            String rue = textBoxRueCabinet.Text.ToString();
            String CP = textBoxCPCabinet.Text.ToString();
            String ville = textBoxVilleCabinet.Text.ToString();
            var address = rue + CP + " , " + ville;

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            var latitude = point.Latitude;
            var longitude = point.Longitude;

            Cabinet unCabinet = new Cabinet(rue, CP, ville, longitude, latitude);
            Passerelle.Passerelle.addCabinet(unCabinet);
        }

        private void FormCreateCabinet_Load(object sender, EventArgs e)
        {

        }

        public void getGeoCodeLocation(String rue, String CP, String ville)
        {
            
        }


        private void getGeoCode2()
        {
            var url = String.Format("https://maps.googleapis.com/maps/api/geocode/json?address=91+Rue+Nationale+Lille&key=%20AIzaSyC5EGGscQmGGxBT5hojO2ioVNZjVoJbFwE");
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                JsonTextReader reader = new JsonTextReader(new StringReader(json));
                dynamic obj = JsonConvert.DeserializeObject(json);
                var test = obj["results"];
                var test1 = test;
                var test2 = test[0];

                //var description = obj.value[0].properties.aclRules[0].properties.description;
                while (reader.Read())
                {
                    if (reader.TokenType.ToString() == "float")
                    {
                        String tempo = reader.Value.ToString();
                        MessageBox.Show(tempo);
                        //MessageBox.Show("Token: {0}, Value: {1} " + reader.TokenType.ToString()+ "  " + reader.Value.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Token: {0}", reader.TokenType);
                    }
                }
            }
        }


        private void getGeoCode3()
        {
            var url = String.Format("https://maps.googleapis.com/maps/api/geocode/xml?address=91+Rue+Nationale+Lille&key=%20AIzaSyC5EGGscQmGGxBT5hojO2ioVNZjVoJbFwE");
            using (WebClient wc = new WebClient())
            {
                var xml = wc.DownloadString(url);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                XmlNode node = doc.DocumentElement;
                foreach (XmlNode unNode in doc)
                {
                    if (unNode.Name == "geometry")
                    {
                        // get the content of the loc node 
                        string loc = unNode.InnerText;
                        
                    }
                }
                string attr = node.Attributes["status"]?.OuterXml;
                String test = node.Attributes["status"]?.InnerText;
                string test2 = node.Attributes["status"]?.InnerText;
            }
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


            JsonTextReader reader = new JsonTextReader(streamR);
            while (reader.Read())
                {
                    if (reader.Value != null)
                        {
                            MessageBox.Show("Token: {0}, Value: {1}"+ reader.TokenType.ToString());
                        }
                    else
                         {
                            Console.WriteLine("Token: {0}", reader.TokenType);
                        }
                }
            /*
            var xmlTextReader = new XmlTextReader(streamR);
            xmlTextReader.Read();

            string[] coord = xmlTextReader.Value.Split(new char[] { ',' });

            string longitudeS = coord[0];
            string latitudeS = coord[1];

            MessageBox.Show(longitudeS + " , "+ latitudeS);  */
        }
    }
}
