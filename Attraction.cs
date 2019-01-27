using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_GRA_AMAR_AMAR
{
    abstract class Attraction : IMaintenancable
    {
        //Attribut
        private bool besoinSpecifique;
        private TimeSpan dureeMaintenance;
        private List<Monstre> equipe = new List<Monstre>();
        private int identifiant;
        private bool maintenance;
        private string natureMaintenance;
        protected int nbMinMonstre;
        private string nom;
        private bool ouvert;
        private string typeDeBesoin;
        protected string typeAttraction;

        //Constructeur
        public Attraction(string typeAttraction, int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin)
        {
            this.typeAttraction = typeAttraction;
            this.besoinSpecifique = besoinSpecifique;
            this.equipe = new List<Monstre>();
            this.identifiant = identifiant;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.typeDeBesoin = typeDeBesoin;
            this.maintenance = false;
            this.natureMaintenance = "";
            this.ouvert = true;
            this.dureeMaintenance = new TimeSpan(0, 0, 0);



        }

        //Accesseur
        public string TypeAttraction
        {
            get
            {
                return this.typeAttraction;
            }
        }

        public int NbminMonstre
        {
            get
            {
                return this.nbMinMonstre;
            }
        }

        public bool Maintenance
        {
            get

            {
                return this.maintenance;
            }
        }

        //Interface permettant de mettre en maintenance une attraction
        public void MiseEnMaintenance(Attraction a, bool ouvert, string natureMaintenance, TimeSpan dureeMaintenance)
        {
            a.maintenance = true;
            a.natureMaintenance = natureMaintenance;
            a.dureeMaintenance = dureeMaintenance;
            a.ouvert = false;

        }



        public int CompareTo(Attraction att)
        {
            return (this.nbMinMonstre.CompareTo(att.nbMinMonstre));
        }

        public int triParType(Attraction a1, Attraction a2)
        {
            return a1.typeAttraction.CompareTo(a2.typeAttraction);
        }

        //ToString
        public override string ToString()
        {

            string retour = "";
            if (maintenance && ouvert == false)
            {
                retour += "Type Attraction: " + this.typeAttraction +
                "\t;;Identifiant: " + this.identifiant
                + "\t;;Nom: " + this.nom
                + "\t;;NbMinMonstre: " + this.nbMinMonstre
                + "\t;;BesoinSpecifique:" + this.besoinSpecifique
                + "\t;;Type besoin: " + typeDeBesoin + "\t;;Attraction est fermé " +
                "\t;;Attraction est fermé pour  " + this.natureMaintenance
                + " pour une duréé de : " + this.dureeMaintenance + " heures";

            }
            else
            {
                retour += "Type Attraction: " + this.typeAttraction +
                "\t;;Identifiant: " + this.identifiant
                + "\t;;Nom: " + this.nom
                + "\t;;NbMinMonstre: " + this.nbMinMonstre
                + "\t;;BesoinSpecifique:" + this.besoinSpecifique
                + "\t;;Type besoin: " + typeDeBesoin
                + "\t;;Attraction est ouvert ";
            }

            return retour;

        }

    }
}