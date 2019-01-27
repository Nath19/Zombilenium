using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class Monstre : Personnel, IComparable<Monstre>, IModifiable
    {
        //Attribut

        private string affectation;
        protected int cagnotte;

        //Constructeur
        public Monstre(string fonction, int matricule, string nom, string prenom, string type, string fonctionFac, int cagnotte, string affectation) : base(fonction, matricule, nom, prenom, type, fonctionFac)
        {
            this.cagnotte = cagnotte;
            this.affectation = affectation;
        }

        //Interface , fonction nous permettant de comparer les cagnottes
        public int CompareTo(Monstre monstre)
        {
            return (this.cagnotte.CompareTo(monstre.cagnotte));
        }


        //Interface
        public void ChangementAffectation(Monstre m, string affectation)
        {
            m.affectation = affectation;
        }


        //Accesseur
        public int Cagnotte
        {
            get
            {
                return this.cagnotte;
            }
            set
            {
                this.cagnotte = value;
            }
        }


        //Fonction anonyme avec un delegate 
        public delegate double MethodeCagnotte(int cagnottes);

        public double ModifieCagnotte(MethodeCagnotte maMethode)
        {
            return maMethode(this.cagnotte);
        }


        //ToString
        public override string ToString()
        {
            return base.ToString()
                + "\t;;Cagnotte: " + this.cagnotte
                + "\t;;Affectation: " + this.affectation;

        }

    }
}
