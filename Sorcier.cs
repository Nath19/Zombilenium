using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class Sorcier : Personnel
    {
        //Attribut
        private List<string> pouvoirs;
        private string grade;

        //Constructeur
        public Sorcier(string fonction, int matricule, string nom, string prenom, string type, string fonctionFac, string grade, List<string> pouvoirs) : base(fonction, matricule, nom, prenom, type, fonctionFac)
        {

            this.pouvoirs = pouvoirs;
            this.grade = grade;

        }

        //fonction nous permettant d'afficher la liste des pouvoirs dans le to string 
        public string AffichagePouvoir(List<string> pouvoirs)
        {
            string pov = "";
            foreach (string p in pouvoirs)
            {
                pov += p + "-";

            }
            return pov;
        }


        //ToString
        public override string ToString()
        {
            return base.ToString() + "\t;;Garde: " + this.grade + "\t;;Pouvoir: " + AffichagePouvoir(this.pouvoirs)+"\n";
        }


    }
}
