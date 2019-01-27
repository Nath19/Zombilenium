using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POOI_GRA_AMAR_AMAR
{
    class Administration
    {
        //Attribut
        private List<Attraction> attractions = new List<Attraction>();
        private List<Personnel> toutLePersonnel = new List<Personnel>();
        List<DateTime> dateExacte = new List<DateTime>();
        List<String> pouvoirs = new List<string>();
        List<Monstre> mesMonstres = new List<Monstre>();


        public Administration()
        {

        }


        public void listerLePersonnel()
        {
            foreach (Personnel personnel in toutLePersonnel)
            {
                Console.WriteLine(personnel.ToString());
                Console.Write("\n\n");

            }
        }


        public void listerLesAttractions()
        {
            Console.WriteLine("\n\nListe des attractions :");
            Console.Write("\n\n");
            foreach (Attraction attraction in attractions)
            {

                Console.WriteLine(attraction.ToString());
                Console.Write("\n\n");
            }
        }


        //fonction nous permettant d'ajouter de nouvelles attractions et  membredu personnel
        public void peuplement()
        {

            Monstre m1 = new Monstre("Monstre", 329, "Leeroy", "Jenkins", "male", "neant", 850, "428");
            Monstre m2 = new Monstre("Monstre", 943, "Baliev", "Jean", "male", "neant", 900, "");
            Monstre m3 = new Monstre("Monstre", 222, "Amar", "Nathan", "male", "neant", 20, "");
            Zombie z1 = new Zombie("Zombie", 573, "Alain", "Buouy", "male", "neant", 200, "", "bleuatre", 7);
            Zombie z2 = new Zombie("Zombie", 126, "Jones", "Daryna", "femelle", "neant", 150, "440", "grisatre", 3);
            Zombie z3 = new Zombie("Zombie", 129, "Zoubi", "Betty", "femelle", "neant", 290, "422", "bleuatre", 3);
            LoupGarou l1 = new LoupGarou("LoupGarou", 121, "Tyler", "Jake", "male", "neant", 280, "460", 1);
            LoupGarou l2 = new LoupGarou("LoupGarou", 122, "Bizman", "Oliver", "male", "neant", 350, "465", 3);
            LoupGarou l3 = new LoupGarou("LoupGarou", 111, "Turkina", "Alexis", "male", "neant", 310, "460", 3);
            Vampire v1 = new Vampire("Vampire", 343, "Salvatore", "Stephen", "male", "neant", 400, "490", 2);
            Vampire v2 = new Vampire("Vampire", 359, "Blake", "Katerina", "femelle", "neant", 990, "402", 1);
            Vampire v3 = new Vampire("Vampire", 303, "Buffry", "Elen", "femelle", "neant", 901, "412", 2);
            Fantome f1 = new Fantome("Fantome", 398, "Pizu", "Casper", "autre", "neant", 800, "");
            Fantome f2 = new Fantome("Fantome", 321, "Tom", "Jeduzor", "male", "Parc", 320, "9");
            Fantome f3 = new Fantome("Fantome", 397, "Screem", "Bulbuzar", "autre", "neant", 402, "10");
            Demon d1 = new Demon("Demon", 12, "hatem", "Ben arfa", "male", "", 10, "", 9);
            Demon d2 = new Demon("Demon", 13, "BRyant", "Kobe", "male", "", 11, "", 5);
            Demon d3 = new Demon("Demon", 14, "Noah", "Joakim", "male", "", 150, "", 1);
            pouvoirs.Add("Disparaitre");
            pouvoirs.Add("telekinesie-transformation d'objets");
            pouvoirs.Add("guerison-morphing-persuasion");
            Sorcier s1 = new Sorcier("Sorcier", 765, "Bou", "Jaja", "male", "neant", "novice", pouvoirs);
            Sorcier s2 = new Sorcier("Sorcier", 830, "Wisley", "Ron", "male", "neant", "mega", pouvoirs);






            DateTime h1 = new DateTime(2018, 05, 12, 20, 00, 00);
            DateTime h2 = new DateTime(2018, 05, 12, 16, 00, 00);



            dateExacte.Add(h1);
            dateExacte.Add(h2);

            Spectacles sp1 = new Spectacles("Spectacle", 423, "Magie", 25, false, "aucun", "Poudlard", 269, dateExacte);
            Spectacles sp2 = new Spectacles("Spectacle", 424, "Le Lac des Cygnes", 12, false, "aucun", "Opera", 350, dateExacte);
            Spectacles sp3 = new Spectacles("Spectacle", 428, "Alibaba et les 40 voleurs", 41, false, "aucun", "Aladin", 128, dateExacte);
            RollerCoaster r1 = new RollerCoaster("RollerCoaster", 112, "Montagnes russes", 9, true, "Vampire", "bobsleigh", 12, 1.4);
            RollerCoaster r2 = new RollerCoaster("RollerCoaster", 836, "Montagnes italienne", 2, true, "Sorcier", "bobsleigh", 10, 1.2);
            RollerCoaster r3 = new RollerCoaster("RollerCoaster", 553, "Montagnes espagnoles", 10, true, "Zombie", "bobsleigh", 8, 1.0);
            DarkRide dr1 = new DarkRide("DarkRide", 534, "SpaceMountain", 4, false, "aucun", new TimeSpan(0, 00, 07, 30), true);
            DarkRide dr2 = new DarkRide("DarkRide", 535, "BigThunderMountains", 4, false, "aucun", new TimeSpan(0, 00, 04, 30), true);
            DarkRide dr3 = new DarkRide("DarkRide", 535, "StarTour", 4, false, "aucun", new TimeSpan(0, 00, 10, 30), true);
            Boutique b1 = new Boutique("Boutique", 25, "Barbe blanche", 33, true, "non", "souvenir");
            Boutique b2 = new Boutique("Boutique", 25, "Barbe blanche", 2, true, "vampires", "BarbeAPapa");


            toutLePersonnel.Add(m1);
            toutLePersonnel.Add(m2);
            toutLePersonnel.Add(m3);
            toutLePersonnel.Add(z1);
            toutLePersonnel.Add(z2);
            toutLePersonnel.Add(z3);
            toutLePersonnel.Add(v1);
            toutLePersonnel.Add(v2);
            toutLePersonnel.Add(v3);
            toutLePersonnel.Add(l1);
            toutLePersonnel.Add(l2);
            toutLePersonnel.Add(l3);
            toutLePersonnel.Add(d1);
            toutLePersonnel.Add(d2);
            toutLePersonnel.Add(d3);
            toutLePersonnel.Add(s1);
            toutLePersonnel.Add(s2);
            toutLePersonnel.Add(f1);
            toutLePersonnel.Add(f2);
            toutLePersonnel.Add(f3);

            attractions.Add(sp1);
            attractions.Add(sp2);
            attractions.Add(sp3);
            attractions.Add(r1);
            attractions.Add(r2);
            attractions.Add(r3);
            attractions.Add(dr1);
            attractions.Add(dr2);
            attractions.Add(dr3);
            attractions.Add(b1);
            attractions.Add(b2);



        }


        //fonction nous permettant de lire le fichier csv 
        public void Test_Lecture()
        {

            string ligne;
            Char c = ';';
            //Pour ouvrir le fichier en mode lecture
            StreamReader fichier = new StreamReader("Listing.csv");

            Console.WriteLine("Voici la listes  contenant les membres du personnel et des attractions du fichier que vous nous avez fourni\n");
            Console.WriteLine("\n\n");
            while ((ligne = fichier.ReadLine()) != null)
            {
                String[] substrings = ligne.Split(c);

                foreach (var substring in substrings)
                {
                    Console.WriteLine(substring);
                }


            }

            fichier.Close();
        }


        /* fonction nous permettant d'ajouter les attractions dans le logiciel ainsi que les membres du personnel
         * avec notre liste de personnel et d'attraction supplementaire */
        public void ajouterPersonnelEtAttraction()
        {

            Console.WriteLine("\n\n");

            List<Monstre> monster = new List<Monstre>();
            List<String> pouvoirs = new List<string>();

            string line;
            Char c = ';';

            StreamReader file = new StreamReader("Listing.csv");
            while ((line = file.ReadLine()) != null)
            {
                String[] substrings = line.Split(c);
                if (substrings[0] == "Monstre")
                {
                    Monstre m = new Monstre(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], substrings[3], substrings[4], substrings[5], Convert.ToInt32(substrings[6]), substrings[7]);
                    toutLePersonnel.Add(m);
                }
                else if (substrings[0] == "Sorcier")
                {
                    List<string> pouv = new List<string>();
                    string[] monTableau = substrings[7].Split('-');
                    foreach (string pv in monTableau)
                    {
                        pouv.Add(pv);
                    }


                    Sorcier s = new Sorcier(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], substrings[3], substrings[4], substrings[5], substrings[6], pouv);
                    toutLePersonnel.Add(s);
                }
                else if (substrings[0] == "Demon")
                {
                    Demon d = new Demon(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], substrings[3], substrings[4], substrings[5], Convert.ToInt32(substrings[6]), substrings[7], Convert.ToInt32(substrings[8]));
                    toutLePersonnel.Add(d);
                }
                else if (substrings[0] == "Vampire")
                {
                    Vampire d = new Vampire(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], substrings[3], substrings[4], substrings[5], Convert.ToInt32(substrings[6]), substrings[7], Convert.ToDouble(substrings[8]));
                    toutLePersonnel.Add(d);
                }
                else if (substrings[0] == "LoupGarou")
                {
                    LoupGarou l = new LoupGarou(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], substrings[3], substrings[4], substrings[5], Convert.ToInt32(substrings[6]), substrings[7], Convert.ToDouble(substrings[8]));
                    toutLePersonnel.Add(l);
                }
                else if (substrings[0] == "Zombie")
                {
                    Zombie z = new Zombie(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], substrings[3], substrings[4], substrings[5], Convert.ToInt32(substrings[6]), substrings[7], substrings[8], Convert.ToInt32(substrings[9])); ;
                    toutLePersonnel.Add(z);
                }
                else if (substrings[0] == "Fantome")
                {
                    Fantome f = new Fantome(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], substrings[3], substrings[4], substrings[5], Convert.ToInt32(substrings[6]), substrings[7]);
                    toutLePersonnel.Add(f);
                }
                else if (substrings[0] == "Boutique")
                {
                    Boutique btq = new Boutique(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], Convert.ToInt32(substrings[3]), Convert.ToBoolean(substrings[4]), substrings[5], substrings[6]);
                    attractions.Add(btq);
                }
                else if (substrings[0] == "RollerCoaster")
                {
                    RollerCoaster rc = new RollerCoaster(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], Convert.ToInt32(substrings[3]), Convert.ToBoolean(substrings[4]), substrings[5], substrings[6], Convert.ToInt32(substrings[7]), Convert.ToDouble(substrings[8]));
                    attractions.Add(rc);
                }

                else if (substrings[0] == "DarkRide")
                {
                    DarkRide dr = new DarkRide(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], Convert.ToInt32(substrings[3]), Convert.ToBoolean(substrings[4]), substrings[5], TimeSpan.Parse(substrings[6]), Convert.ToBoolean(substrings[7]));
                    attractions.Add(dr);
                }
                else if (substrings[0] == "Spectacle")
                {
                    List<DateTime> horaires = new List<DateTime>();

                    string[] monTab = substrings[8].Split(' ');
                    foreach (string temps in monTab)
                    {

                        string[] tab1 = temps.Split(':');
                        int heuresExacte = Convert.ToInt32(tab1[0]);

                        int m = Convert.ToInt32(tab1[1]);

                        DateTime date1 = new DateTime(2018, 05, 12, heuresExacte, m, 00);
                        horaires.Add(date1);
                    }
                    Spectacles sp = new Spectacles(substrings[0], Convert.ToInt32(substrings[1]), substrings[2], Convert.ToInt32(substrings[3]), Convert.ToBoolean(substrings[4]), substrings[5], substrings[6], Convert.ToInt32(substrings[7]), horaires);
                    attractions.Add(sp);
                }
            }

            Console.WriteLine("\n\nListe du personnel avec le nouvel personnel que l'on a ajouté : \n\n");

            foreach (Personnel p in toutLePersonnel)
            {
                Console.WriteLine(p.ToString()+"\n");

            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Liste des Attractions au total: avec les nouvels attractions ajouté \n\n");
            foreach (Attraction att in attractions)
            {
                Console.WriteLine(att.ToString()+"\n");
            }


            Console.WriteLine("\n\nCe personnel supplementaires a été ajoutés avec succes à votre liste de personel\n");
            Console.WriteLine("\nCes attractions supplementaires ont été ajoutés avec succes à votre liste d'attractions");



        }



        //fonction nous permettant de changer la fonction d'un membre du personnel
        public void Changement_Fonction()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Voici la liste de quelques membres du personnel : \n\n");

            List<Personnel> listTemp = new List<Personnel>();
            Monstre m1 = new Monstre("Monstre", 329, "Leeroy", "Jenkins", "male", "neant", 850, "428");
            Monstre m2 = new Monstre("Monstre", 943, "Baliev", "Jean", "male", "neant", 900, "");
            Monstre m3 = new Monstre("Monstre", 222, "Amar", "Nathan", "male", "neant", 20, "");
            Zombie z1 = new Zombie("Zombie", 573, "Alain", "Buouy", "male", "neant", 200, "", "bleuatre", 7);
            Vampire v3 = new Vampire("Vampire", 303, "Buffry", "Elen", "femelle", "neant", 901, "412", 2);


            listTemp.Add(m1);
            listTemp.Add(m2);
            listTemp.Add(m3);
            listTemp.Add(z1);
            listTemp.Add(v3);



            foreach (Personnel m in listTemp)
            {
                Console.WriteLine(m);
            }



            //on vérifie  que c'est bien un monstre 
            //on utilise l'interface qu'on a crée pour verifier que le monstre est IEvoluable
            //on apelle ensuite notre fonction changement de fonction

            Console.WriteLine("\n\n");
            Console.WriteLine("Changement de fonction");
            Console.WriteLine("Désormais le monstre Leeroy Jenkins , le zombie Alain Buouy et le vampire Buffry Elen ont pour fonction fac : Stagiaire ");
            Console.WriteLine("\n\n");
            foreach (Personnel m in listTemp)
            {
                if (m is IEvoluable)
                {
                    (m as IEvoluable).ChangementFonction(m1, "stagiaire");
                    (m as IEvoluable).ChangementFonction(z1, "stagiaire");
                    (m as IEvoluable).ChangementFonction(v3, "stagiaire");
                }


            }

            foreach (Personnel m in listTemp)
            {
                Console.WriteLine(m);
            }



        }



        //fonction nous permettant de changer d'affectation d'un membre du personnel
        public void Changement_Affectation()
        {
            //on vérifie  que c'est bien un monstre 
            //on utilise l'interface qu'on a crée pour verifier que le monstre est IModifiable
            //on apelle ensuite notre fonction changement d'affectation
            Console.WriteLine("\n\nNous allons changer l'affectation de hatem ben arfa et de Tyler Jake: \n\n");

            Demon d1 = new Demon("Demon", 12, "hatem", "Ben arfa", "male", "", 10, "", 9);
            Demon d2 = new Demon("Demon", 13, "BRyant", "Kobe", "male", "", 11, "", 5);
            Demon d3 = new Demon("Demon", 14, "Noah", "Joakim", "male", "", 150, "", 1);
            LoupGarou l1 = new LoupGarou("LoupGarou", 121, "Tyler", "Jake", "male", "neant", 280, "460", 1);
            List<Personnel> listTemp = new List<Personnel>();

            listTemp.Add(d1);
            listTemp.Add(d2);
            listTemp.Add(d3);
            listTemp.Add(l1);

            foreach (Personnel m in listTemp)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Changement d'affectation du demon Hatem ben arfa et du loupgarou Tyler Jake qui seront désormais affecter au PARC");
            Console.WriteLine("\n\n");

            foreach (Personnel m in listTemp)
            {
                if (m is IModifiable)
                {
                    (m as IModifiable).ChangementAffectation(d1, "PARC");
                    (m as IModifiable).ChangementAffectation(l1, "PARC");
                }

            }

            foreach (Personnel m in listTemp)
            {
                Console.WriteLine(m);
            }


        }



        //fonction nous permettant de mettre en maintenance une attraction
        public void Mise_En_Maintenance()
        {

            List<Attraction> attractionTemp = new List<Attraction>();
            TimeSpan interval1 = new TimeSpan(0, 15, 30);

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Voici la liste des attractions que nous allons mettre en maintenance \n\n");

            Boutique b1 = new Boutique("Boutique", 25, "Barbe blanche", 33, true, "non", "souvenir");
            RollerCoaster r1 = new RollerCoaster("RollerCoaster", 112, "Montagnes russes", 9, true, "Vampire", "bobsleigh", 12, 1.4);
            DarkRide dr1 = new DarkRide("DarkRide", 73, "Train Zombie", 12, true, "Zombie", interval1, true);

            attractionTemp.Add(b1);
            attractionTemp.Add(r1);
            attractionTemp.Add(dr1);


            foreach (Attraction att in attractionTemp)
            {
                Console.WriteLine(att);
            }

            //on vérifie  bien que l'attraction est IMaintenancable
            //on apelle ensuite notre fonction MiseEnMaintenance() 
            foreach (Attraction att in attractionTemp)
            {

                if (att is IMaintenancable)
                {
                    (att as IMaintenancable).MiseEnMaintenance(b1, false, "travaux", new TimeSpan(15, 0, 0));
                    (att as IMaintenancable).MiseEnMaintenance(r1, false, "panne", new TimeSpan(10, 0, 0));
                    (att as IMaintenancable).MiseEnMaintenance(dr1, false, "travaux", new TimeSpan(20, 0, 0));

                }
            }
            Console.WriteLine("\n\nElle sont désormais en maintenance \n\n");
            foreach (Attraction att in attractionTemp)
            {
                if (att.Maintenance == true)
                {
                    Console.WriteLine(att);
                }
            }



        }

        //fonction nous permettant de trier les demon par la force , le nombre minimal de monstre dans une attraction etc..
        public void Trier_En_Fonction()
        {

            Console.WriteLine("Nous allons  trier le personnel et les attractions supplémentaires");

            //faire une liste par type desirer
            Console.WriteLine("\nTrions les demons par la force ");
            List<Demon> mesDemons = new List<Demon>();
            foreach (Personnel p in toutLePersonnel)
                if (p is Demon) mesDemons.Add(p as Demon);
            Console.WriteLine("\n\n");

            Console.WriteLine("Tri par FORCE éffectues\n");
            //  tri par Force
            mesDemons.Sort();
            Console.WriteLine("\n\n");
            foreach (Demon m in mesDemons)
            {
                Console.WriteLine(m);
                Console.WriteLine("\n\n");
            }



            Console.WriteLine("\n\n");
            Console.WriteLine("Tri par nombre minimum de  MONSTRE dans toute les attractions\n");
            attractions.Sort(delegate (Attraction att1, Attraction att2)
            {
                return (att1.NbminMonstre.CompareTo(att2.NbminMonstre));
            });

            Console.WriteLine("\n\n");
            foreach (Attraction m in attractions)
            {
                Console.WriteLine(m);
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("\n\n");


        }

        //fonction nous permettant de trier les monstre par cagnotte
        public void Trier_Par_Cagnotte()
        {


            Console.WriteLine("\n\nNous allons triés les monstres par cagnotte\n");

            //Création d'une liste de monstre 
            // on cast le p de personnel en Monstre , puis on l'ajoute a la liste de monstre
            List<Monstre> mesMonstres = new List<Monstre>();
            foreach (Personnel p in toutLePersonnel)
                if (p is Monstre) mesMonstres.Add(p as Monstre);
            Console.WriteLine("\n\n");

            Console.WriteLine("Tri éffectué\n");
            //tri par ganootte
            mesMonstres.Sort();
            Console.WriteLine("\n\n");
            foreach (Monstre m in mesMonstres)
            {
                Console.WriteLine(m);
                Console.WriteLine("\n\n");
            }


        }





        //fonction nous permettant de trier le personnel en fonction de chaque type
        public void Trier_Par_Type_Personnel()
        {



            Console.WriteLine("\n\nVoici une liste uniquement de demon\n");
            //Pour pouvoir créé un fichier csv
            //On cast pareillement le p de Personnel en Demon et on l'ajoute a la liste de démon
            StreamWriter demn = new StreamWriter("Demon.csv");
            List<Demon> dem = new List<Demon>();
            foreach (Personnel p in toutLePersonnel)
                if (p is Demon) dem.Add(p as Demon);
            Console.WriteLine("\n\n");
            foreach (Personnel p in dem)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                demn.WriteLine((Demon)p);
            }
            demn.Close();
            Console.WriteLine("Un fichier csv appelé Demon.csv a été créé dans le Debug");




            Console.WriteLine("\n\nVoici une liste uniquement de LoupGarou\n");
            StreamWriter lg = new StreamWriter("LoupGarou.csv");
            List<LoupGarou> lp = new List<LoupGarou>();
            foreach (Personnel p in toutLePersonnel)
                if (p is LoupGarou) lp.Add(p as LoupGarou);
            Console.WriteLine("\n\n");
            foreach (Personnel p in lp)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                lg.WriteLine((LoupGarou)p);
            }
            lg.Close();
            Console.WriteLine("Un fichier csv appelé LoupGarou.csv a été créé dans le debug");


            Console.WriteLine("\n\nVoici une liste uniquement de vampires\n");
            StreamWriter vmp = new StreamWriter("Vampire.csv");
            List<Vampire> vp = new List<Vampire>();
            foreach (Personnel p in toutLePersonnel)
                if (p is Vampire) vp.Add(p as Vampire);
            Console.WriteLine("\n\n");
            foreach (Personnel p in vp)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                vmp.WriteLine((Vampire)p);
            }
            vmp.Close();
            Console.WriteLine("Un fichier csv appelé Vampire.csv a été créé dans le debug");


            Console.WriteLine("\n\nVoici une liste uniquement de Zombie\n");
            StreamWriter zmb = new StreamWriter("Zombie.csv");
            List<Zombie> zb = new List<Zombie>();
            foreach (Personnel p in toutLePersonnel)
                if (p is Zombie) zb.Add(p as Zombie);
            Console.WriteLine("\n\n");
            foreach (Personnel p in zb)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                zmb.WriteLine((Zombie)p);
            }
            zmb.Close();
            Console.WriteLine("Un fichier csv appelé Zombie.csv a été créé dans le debug");


            Console.WriteLine("\n\nVoici une liste uniquement de Fantome\n");
            StreamWriter ftm = new StreamWriter("Fantome.csv");
            List<Fantome> ft = new List<Fantome>();
            foreach (Personnel p in toutLePersonnel)
                if (p is Fantome) ft.Add(p as Fantome);
            Console.WriteLine("\n\n");
            foreach (Personnel p in ft)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                ftm.WriteLine((Fantome)p);
            }
            ftm.Close();
            Console.WriteLine("Un fichier csv appelé Fantome.csv a été créé dans le debug");


            Console.WriteLine("\n\nVoici une liste uniquement de Sorcier\n");
            StreamWriter scr = new StreamWriter("Sorcier.csv");
            List<Sorcier> sc = new List<Sorcier>();
            foreach (Personnel p in toutLePersonnel)
                if (p is Sorcier) sc.Add(p as Sorcier);
            Console.WriteLine("\n\n");
            foreach (Personnel p in sc)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                scr.WriteLine((Sorcier)p);
            }
            scr.Close();
            Console.WriteLine("Un fichier csv appelé Sorcier.csv a été créé dans le debug");
        }



        //fonction nous permettant de trier les attractions
        public void Trier_Par_Type_Attraction()
        {

            Console.WriteLine("\n\nVoici une liste uniquement de RollerCoaster\n");
            StreamWriter rc = new StreamWriter("RollerCoaster.csv");
            List<RollerCoaster> rollerC = new List<RollerCoaster>();
            foreach (Attraction p in attractions)
                if (p is RollerCoaster) rollerC.Add(p as RollerCoaster);
            Console.WriteLine("\n\n");
            foreach (Attraction p in rollerC)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                rc.WriteLine((RollerCoaster)p);
            }
            rc.Close();
            Console.WriteLine("Un fichier csv appelé RollerCoaster.csv a été créé dans le debug");


            Console.WriteLine("\n\nVoici une liste uniquement de DarkRide\n");
            StreamWriter dr = new StreamWriter("DarkRide.csv");
            List<DarkRide> darkr = new List<DarkRide>();
            foreach (Attraction p in attractions)
                if (p is DarkRide) darkr.Add(p as DarkRide);
            Console.WriteLine("\n\n");
            foreach (Attraction p in darkr)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                dr.WriteLine((DarkRide)p);
            }
            dr.Close();
            Console.WriteLine("Un fichier csv appelé DarkRide.csv a été créé dans le debug");


            Console.WriteLine("\n\nVoici une liste uniquement de Boutiques\n");
            StreamWriter bt = new StreamWriter("Boutique.csv");
            List<Boutique> bout = new List<Boutique>();
            foreach (Attraction p in attractions)
                if (p is Boutique) bout.Add(p as Boutique);
            Console.WriteLine("\n\n");
            foreach (Attraction p in bout)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                bt.WriteLine((Boutique)p);
            }
            bt.Close();
            Console.WriteLine("Un fichier csv appelé Boutique.csv a été créé dans le debug");


            Console.WriteLine("\n\nVoici une liste uniquement de Spectacles\n");
            StreamWriter sp = new StreamWriter("Spectacle.csv");
            List<Spectacles> spec = new List<Spectacles>();
            foreach (Attraction p in attractions)
                if (p is Spectacles) spec.Add(p as Spectacles);
            Console.WriteLine("\n\n");
            foreach (Attraction p in spec)
            {
                Console.WriteLine(p);
                Console.WriteLine("\n\n");
                sp.WriteLine((Spectacles)p);
            }
            sp.Close();
            Console.WriteLine("Un fichier csv appelé Spectacle.csv a été créé dans le debug");


        }




        //fonction nous permettant d'augmenter ou de diminuer la cagnotte
        public void Augmenter_Diminuer_Cagnotte()
        {
            Monstre m1 = new Monstre("Monstre", 329, "Leeroy", "Jenkins", "male", "neant", 50, "428");
            Monstre m2 = new Monstre("Monstre", 943, "Henry", "Thierry", "male", "neant", 900, "");
            Demon d1 = new Demon("Demon", 12, "Hatem", "Ben arfa", "male", "directeur", 400, "rien", 5);
            Demon d2 = new Demon("Demon", 13, "BRyant", "Kobe", "male", "neant", 11, "", 9);
            Demon d3 = new Demon("Demon", 14, "Noah", "Joakim", "male", "neant", 150, "999", 1);
            Zombie z1 = new Zombie("Zombie", 573, "Alain", "Buouy", "male", "neant", 480, "700", "bleuatre", 7);
            Zombie z2 = new Zombie("Zombie", 844, "Buzz", "Yola", "femelle", "", 400, "480", "grisatre", 9);


            List<Monstre> listTemp = new List<Monstre>();
            listTemp.Add(m1);
            listTemp.Add(m2);
            listTemp.Add(d1);
            listTemp.Add(d2);
            listTemp.Add(d3);
            listTemp.Add(z1);

            Console.WriteLine("Liste des monstre avant augmentation de la cagnotte\n\n");
            foreach (Monstre m in listTemp)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("\nCombien voulez vous rajoutez a la cagnotte du monstre Henry thierry?\n");

            string saisie1 = Console.ReadLine();


            //Utilisation d'un délégate , on a accés a la cagnotte grace a l'accesseur dans la classe Monstre
            double resultatb = m2.ModifieCagnotte(delegate (int cagnottes)
            {

                cagnottes = Convert.ToInt32(saisie1);
                return m2.Cagnotte += cagnottes;
            });

            foreach (Monstre m in listTemp)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("\n\n");


            Console.WriteLine("\nCombien voulez vous enlevez a la cagnotte du monstre Leeroy Jenkins?");
            Console.WriteLine("Si cagnotte inferieur a 50 alors il sera affecter au stand barbe a papa\n");
            string saisie2 = Console.ReadLine();

            // Utilisons pour cela expression LAMBDA
            Console.WriteLine("\n\n");

            double resultatc = m1.ModifieCagnotte((int cagnottes) =>
            {
                cagnottes = Convert.ToInt32(saisie2);
                return m1.Cagnotte -= cagnottes;
            });

            foreach (Monstre m in listTemp)
            {
                Console.WriteLine(m);
            }


            // si la cagnotte d'un monstre tombe en dessous de 10 alors => AFFECTATION  barbe a papa 


            Console.WriteLine("\n\n");
            if (m1.Cagnotte < 50)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\nCHANGEMENT DE AFFECTATION De Leeroy Jenkins car cagnotte inferieur a 50\n");
                foreach (Monstre m in listTemp)
                {
                    if (m is IModifiable)
                        (m as IModifiable).ChangementAffectation(m1, "barbe a papa");
                }

            }

            foreach (Monstre m in listTemp)
            {
                Console.WriteLine(m);
            }


            Console.WriteLine("\nCombien voulez vous rajoutez a la cagnotte du zombie Alain Buouy?\n");
            Console.WriteLine("Si cagnotte supérieur a 500 alors il pouura disparaitre et sera affecte au parc\n");



            string saisie3 = Console.ReadLine();
            // utilisons pour cela expression lambda
            Console.WriteLine("\n\n");


            double resultatd = z1.ModifieCagnotte((int cagnottes) =>
            {
                cagnottes = Convert.ToInt32(saisie3);
                return z1.Cagnotte += cagnottes;
            });

            foreach (Monstre m in listTemp)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("\n\n");
            if (z1.Cagnotte > 500)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\nObtien de facon provisoir pouvoir de disparaitre car cagnotte supérieur à 500");
                Console.WriteLine("Il sera désormais affecté au PARC et pourra faire peur au visiteur \n");
                foreach (Monstre m in listTemp)
                {

                    if (m is IModifiable)

                        (m as IModifiable).ChangementAffectation(z1, "PARC");
                }
                Console.WriteLine(z1.ToString());

            }


            Console.WriteLine("\nCombien voulez vous rajoutez a la cagnotte du demon Hatem BenArfa?\n");
            Console.WriteLine("Si cagnotte supérieur a 500 alors il pouura disparaitre et sera affecte au parc\n");


            string saisie4 = Console.ReadLine();
            // utilisons pour cela expression lambda
            Console.WriteLine("\n\n");
            double resultate = d1.ModifieCagnotte((int cagnottes) =>
            {
                cagnottes = Convert.ToInt32(saisie4);
                return d1.Cagnotte += cagnottes;
            });

            foreach (Monstre m in listTemp)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("\n\n");

            if (d1.Cagnotte > 500)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\nObtien de facon provisoir pouvoir de disparaitre car cagnotte supérieur à 500");
                Console.WriteLine("Il sera désormais affecté au PARC et pouura faire peur au visiteur\n ");
                foreach (Monstre m in listTemp)
                {

                    if (m is IModifiable)
                        (m as IModifiable).ChangementAffectation(d1, "PARC");
                }
                Console.WriteLine(d1.ToString());

            }

        }

        public void menu()
        {

            int choix = 0;
            while (choix != 9)
            {
                try
                {

                    Console.WriteLine("\n\n-------------------------------------------------------------------");
                    Console.WriteLine("----------------------------ZOMBILENIUM----------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("---------------------AMAR Nathan--&--AMAR Ruben--------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-----------------------Bienvenue dans la demo----------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("\nChoisir une opération\n");
                    Console.WriteLine("1: Pour lire le fichier que vous nous avez fourni \n");
                    Console.WriteLine("2: Pour ajouter dans le logiciel les attractions ,le personel ainsi qu'en ajouter de nouveau \n");
                    Console.WriteLine("3: Pour un changement de fonction,d'affection,mise en maintenance\n");
                    Console.WriteLine("4: Pour un tri en fonction de plusieurs critéres(force,etc..)\n");
                    Console.WriteLine("5: Pour un tri en fonction de la cagnotte\n");
                    Console.WriteLine("6: Pour un tri en fonction des differents type  de personnel\n");
                    Console.WriteLine("7: Pour un tri en fonction des differents type d'attractions \n");
                    Console.WriteLine("8: Pour augmenter ou diminuer la cagnotte\n");
                    Console.WriteLine("9: Pour quitter\n\n");
                    Console.Write("Quel est votre choix > ");
                    choix = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Clear();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Veuillez rentrer un chiffre", ex.Message);

                }

                switch (choix)
                {
                    case 1:

                        Test_Lecture();

                        break;

                    case 2:
                        Console.WriteLine("Ajoutons les attractions et le personnel à notre logiciel");
                        ajouterPersonnelEtAttraction();
                        break;

                    case 3:
                        Console.WriteLine("Changement de fonction,d'affection,mise en maintenance\n");
                        Changement_Fonction();
                        Changement_Affectation();
                        Mise_En_Maintenance();
                        break;

                    case 4:
                        Console.WriteLine("Tri en fonction de plusieurs critéres\n");
                        Trier_En_Fonction();
                        break;
                    case 5:
                        Console.WriteLine("Tri en fonction de la cagnotte\n");
                        Trier_Par_Cagnotte();
                        break;


                    case 6:
                        Console.WriteLine("Nous allons triés par type differents du monstre\n");
                        Trier_Par_Type_Personnel();
                        break;

                    case 7:
                        Console.WriteLine("Nous allons triés les attractions\n");
                        Trier_Par_Type_Attraction();
                        break;
                    case 8:
                        Console.WriteLine("Augmentation ou diminution de la cagnotte \n");
                        Augmenter_Diminuer_Cagnotte();
                        break;
                    case 9:

                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("---- Nous ésperons que notre démo a repondu à tous vos besoins-----\n");
                        Console.WriteLine("-------------------- Au revoir et à bientot !----------------------\n");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("-------------------------------------------------------------------");
                        break;

                }
            }
        }

    }
}
