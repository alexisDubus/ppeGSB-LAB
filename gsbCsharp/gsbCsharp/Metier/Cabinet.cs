using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Cabinet
    {
        #region proprietes
        private int id; //mettre en statique?
        private String rue;
        private String CP;
        private String ville;
        private double longitude;
        private double latitude;
        #endregion

        #region get
        public int getId()
        {
            return this.id;
        }

        public String getRue()
        {
            return this.rue;
        }

        public String getCP()
        {
            return this.CP;
        }

        public String getVille()
        {
            return this.ville;
        }

        public double getLongitude()
        {
            return this.longitude;
        }

        public double getLatitude()
        {
            return this.latitude;
        }



        #endregion

        #region set
        public void setId(int id)
        {
            this.id = id;
        }

        public void setRue(String rue)
        {
            this.rue = rue;
        }

        public void setCP(String cp)
        {
            this.CP = cp;
        }

        public void setVille(String ville)
        {
            this.ville = ville;
        }

        public void setLongitude(double longitude)
        {
            this.longitude = longitude;
        }

        public void setLatitude(double latitude)
        {
            this.latitude = latitude;
        }

        #endregion

        #region constructeur
        /// <summary>
        /// créé un cabinet vide
        /// </summary>
        public Cabinet ()
        {

        }

        /// <summary>
        /// constructeur de Cabinet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rue"></param>
        /// <param name="CP"></param>
        /// <param name="ville"></param>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        public Cabinet (int id, String rue, String CP, String ville, double longitude, double latitude)
        {
            setId(id);
            setRue(rue);
            setCP(CP);
            setVille(ville);
            setLongitude(longitude);
            setLatitude(latitude);
        }

        #endregion
    }
}
