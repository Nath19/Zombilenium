using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class Boutique : Attraction
    {
        //Attribut
        private string type;

        //Constructeur
        public Boutique(string typeAttraction, int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, string type) : base(typeAttraction, identifiant, nom, nbMinMonstre, besoinSpecifique, typeDeBesoin)
        {
            this.type = type;
        }

        //ToString
        public override string ToString()
        {
            return base.ToString() + "\t;;Type Boutique:  " + this.type+"\n";

        }
    }
}
