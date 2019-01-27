using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class Zombie : Monstre
    {
        //Attribut
        private int degreDecomposition;
        private string teint;

        //Constructeur
        public Zombie(string fonction, int matricule, string nom, string prenom, string type, string fonctionFac, int cagnotte, string affectation, string teint, int degreDecomposition) : base(fonction, matricule, nom, prenom, type, fonctionFac, cagnotte, affectation)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
        }
        //ToString
        public override string ToString()
        {
            return base.ToString() + "\t;;Teint: " + this.teint +
                "\t;;Degre decomposition: " + this.degreDecomposition+"\n";

        }
    }

}
