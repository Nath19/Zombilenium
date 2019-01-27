using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    class Spectacles : Attraction
    {
        //Attribut
        private List<DateTime> horaire;
        private int nombrePlace;
        private string nomSalle;


        //Constructeur
        public Spectacles(string typeAttraction, int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, string nomSalle, int nombrePlace, List<DateTime> horaire) : base(typeAttraction, identifiant, nom, nbMinMonstre, besoinSpecifique, typeDeBesoin)
        {
            this.nombrePlace = nombrePlace;
            this.nomSalle = nomSalle;
            this.horaire = horaire;



        }


        //fonction permettant d'affiche les horraires dans le to string 
        public string AffichageHoraires(List<DateTime> horaire)
        {
            string temps = "";
            foreach (DateTime time in horaire)
            {
                temps += time.ToString() + " ";

            }
            return temps;
        }
        //ToString
        public override string ToString()
        {
            return base.ToString() + " \t;;Nom salle: " + this.nomSalle + "\t;;Nombre Place: " + this.nombrePlace
                + "\t;;Horaires: " + AffichageHoraires(this.horaire)+"\n";
        }

    }
}
