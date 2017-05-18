using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Avantage
    {
        private String nom;
        private int id;
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public Avantage(String nom)
        {

            setNom(nom);
        }

        public void setNom(String nom)
        {
            this.Nom = nom;
        }

        public String getNom()
        {
            return this.Nom;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
    }
}
