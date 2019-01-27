using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class DarkRide : Attraction
    {

        //Attribut
        private TimeSpan duree;
        private bool vehicule;

        //Constructeur
        public DarkRide(string typeAttraction, int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, TimeSpan duree, bool vehicule) : base(typeAttraction, identifiant, nom, nbMinMonstre, besoinSpecifique, typeDeBesoin)
        {

            this.vehicule = vehicule;
            this.duree = duree;
        }

        //ToString
        public override string ToString()
        {

            return base.ToString() + "\t;;Durée Attraction: " + duree + "min" + "\t;;Vehicule : " + vehicule+"\n";
        }


    }


}
