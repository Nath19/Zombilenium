using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
   abstract class Personnel : IEvoluable
    {
        // Attribut
        private string fonction;
        private int matricule;
        private string nom;
        private string prenom;
        private string type;
        private string fonctionFac;

        //Constructeur
        public Personnel(string fonction, int matricule, string nom, string prenom, string type, string fonctionFac)
        {
            this.fonction = fonction;
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
            this.fonctionFac = fonctionFac;
        }


        //Interface
        public void ChangementFonction(Personnel p, string fonction)
        {
            p.fonctionFac = fonction;
        }


        //ToString
        public override string ToString()
        {
            return "Type: " + this.fonction + "\t;;Matricule: " + this.matricule
                 + "\t;;Nom: " + this.nom + "\t;;Prenom: " + this.prenom + "\t;;TypeSexe: " + this.type
                 + "\t;;FonctionFac: " + this.fonctionFac;

        }

    }
}
