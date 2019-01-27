using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class Demon : Monstre, IComparable<Demon>
    {
        //Attribut
        private int force;

        //Constructeur
        public Demon(string fonction, int matricule, string nom, string prenom, string type, string fonctionFac, int cagnotte, string affectation, int force) : base(fonction, matricule, nom, prenom, type, fonctionFac, cagnotte, affectation)
        {
            this.force = force;
        }
        //Interface, fonction permettant de comparer les demons par la force
        public int CompareTo(Demon demon)
        {
            return (this.force.CompareTo(demon.force));
        }


        //ToString
        public override string ToString()
        {
            return base.ToString()
                + "\t;;Force: " + this.force+"\n";
        }
    }
}
