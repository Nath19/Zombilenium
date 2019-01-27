using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class Vampire : Monstre
    {
        //Attribut
        private double indiceLuminosite;


        //Constructeur
        public Vampire(string fonction, int matricule, string nom, string prenom, string type, string fonctionFac, int cagnotte, string affectation, double indiceLuminosite) : base(fonction, matricule, nom, prenom, type, fonctionFac, cagnotte, affectation)
        {
            this.indiceLuminosite = indiceLuminosite;
        }

        //ToString
        public override string ToString()
        {
            return base.ToString() + "\t;;Indice Luminosite: " + this.indiceLuminosite+"\n";
        }
    }
}
