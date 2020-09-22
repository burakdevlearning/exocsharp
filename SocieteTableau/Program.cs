using System;

namespace SocieteTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new Employe("Robert", "Jorge", 34, 2400);
            Employe employe2 = new Employe("George", "Lucas", 55, 3000);
            Employe employe3 = new Employe("Pas di caprio", "Leonardo", 39, 2900);
            Employe employe4 = new Employe("Earthwalker", "Luke", 27, 2600);
            Employe employe5 = new Employe("Multiple", "Han", 45, 3700);
            Chef chef1 = new Chef("McCain", "John", 49, 5700, "General");
            Chef chef2 = new Chef("McDonald", "David", 49, 5700, "Informatique");
            Directeur directeur = new Directeur("Philip", "Michael", 65, 75000, "General", "CsharpCorporation");

            Personne[] societeTableau = new Personne[]
            {
                employe1,
                employe2,
                employe3,
                employe4,
                employe5,
                chef1,
                chef2,
                directeur
            };

            for(int i = 0; i < societeTableau.Length; i++)
            {
                societeTableau[i].Afficher();
            }

            societeTableau[4]++;

            Employe tempEmp = (Employe)societeTableau[2];
            tempEmp.Salaire = 1200;
            societeTableau[2] = tempEmp;

            Chef tempChef = (Chef)societeTableau[5];
            tempChef.Service = "Ressources humaines";
            societeTableau[5] = tempChef;

            foreach(Personne p in societeTableau)
            {
                p.Afficher();
            }
        }
    }
}
