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
    public partial class FormListeVisiteur : Form
    {

        List<Utilisateur> listeVisiteur = new List<Utilisateur>();
        public FormListeVisiteur()
        {
            InitializeComponent();
        }

        private void FormListeVisiteur_Load(object sender, EventArgs e)
        {
            listeVisiteur = Passerelle.Passerelle.getAllVisiteur();
            //var source = new BindingSource(listeVisiteur, null);
            //dataGridViewVisiteur.DataSource = source;
            //visiteBindingSource.DataSource = listeVisiteur.ToArray();


            var bindingList = new BindingList<Utilisateur>(listeVisiteur);
            var source = new BindingSource(bindingList, null);


            dataGridViewVisiteur.DataSource = source;


            //visiteBindingSource.DataSource = source;

            //dataGridViewVisiteur.DataSource = visiteBindingSource.DataSource;
            

            int nombrevisiteur = listeVisiteur.Count;
            textBoxNombreVisiteur.Text = nombrevisiteur.ToString();
        }
    }
}
