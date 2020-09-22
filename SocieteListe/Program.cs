using SocieteListe.ListeChainee;
using System;

namespace SocieteListe
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

            Console.WriteLine("Insertion des éléments à la liste");

            Liste personnes = new Liste();
            personnes.InsererDebut(directeur);
            personnes.InsererDebut(chef2);
            personnes.InsererDebut(chef1);
            personnes.InsererDebut(employe5);
            personnes.InsererDebut(employe4);
            personnes.InsererDebut(employe3);
            personnes.InsererDebut(employe2);
            personnes.InsererDebut(employe1);

            Console.WriteLine("Nombre d'éléments : {0}", personnes.NbElements);
            personnes.Lister();

            Console.WriteLine("Vidage de la liste");
            personnes.Vider();

            Console.WriteLine("Nombre d'éléments : {0}", personnes.NbElements);
            personnes.Lister();

            Console.WriteLine("Avec insertion de fin");
            personnes.InsererFin(employe1);
            personnes.InsererFin(employe2);
            personnes.InsererFin(employe3);
            personnes.InsererFin(employe4);
            personnes.InsererFin(employe5);
            personnes.InsererFin(chef1);
            personnes.InsererFin(chef2);
            personnes.InsererFin(directeur);

            Console.WriteLine("Nombre d'éléments : {0}", personnes.NbElements);
            Console.WriteLine("Avec indexeur");
            for (int i = 0; i < personnes.NbElements; i++)
            {
                Console.WriteLine(personnes[i].Objet.ToString());
            }
        }
    }
}
