using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class LoupGarou : Monstre
    {
        //Attribut
        private double indiceCruaute;

        //Constructeur
        public LoupGarou(string fonction, int matricule, string nom, string prenom, string type, string fonctionFac, int cagnotte, string affectation, double indiceCruaute) : base(fonction, matricule, nom, prenom, type, fonctionFac, cagnotte, affectation)
        {
            this.indiceCruaute = indiceCruaute;
        }

        //ToString
        public override string ToString()
        {
            return base.ToString() + "\t;;Indice Cruauté: " + this.indiceCruaute+"\n";
        }
    }
}
