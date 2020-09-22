using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes
{
    class Personne
    {
        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            count++;
        }
        private static int count { get; set; }
        private string nom { get; set; }
        private string prenom { get; set; }
        private int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine($"Nom : {nom} , Prénom : {prenom}, Age : {age}");
        }

        public static int Combien()
        {
            
            return count;
        }

        ~Personne()
        {
            count--;
        }
    }
}
