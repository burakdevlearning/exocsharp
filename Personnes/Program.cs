using System;

namespace Personnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nb personnes : {0} ", Personne.Combien());
            Personne personne = new Personne("test", "test", 10);
            Personne personne1 = new Personne("test", "test", 10);
            Personne personne2 = new Personne("test", "test", 10);
            Personne personne3 = new Personne("test", "test", 10);
            Personne personne4 = new Personne("test", "test", 10);
            Personne personne5 = new Personne("test", "test", 10);
            Personne personne6 = new Personne("test", "test", 10);
            Personne personne7 = new Personne("test", "test", 10);
            TestPersonne tp = new TestPersonne("testpers", "testp",12);
            Console.WriteLine("Nb personnes : {0} ", Personne.Combien());


            // réponse à la question : je sais pas
        }
    }
}
