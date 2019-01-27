using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class RollerCoaster : Attraction
    {
        //Attribut
        private int ageMinimum;
        private string categorie;
        private double tailleMinimum;

        //Constructeur
        public RollerCoaster(string typeAttraction, int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, string categorie, int ageMinimum, double tailleMinimum) : base(typeAttraction, identifiant, nom, nbMinMonstre, besoinSpecifique, typeDeBesoin)
        {
            this.categorie = categorie;
            this.ageMinimum = ageMinimum;
            this.tailleMinimum = tailleMinimum;
        }

        //Accesseur
        public double TailleMinimum
        {
            get
            {
                return this.tailleMinimum;
            }
        }

        //ToString
        public override string ToString()
        {
            return base.ToString() + "\t;;Categorie: " + this.categorie
                + "\t;;Age Minimum: " + this.ageMinimum
                + "\t;;Taille minimum: " + this.tailleMinimum+"\n";
        }




    }
}
