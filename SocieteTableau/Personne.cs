using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SocieteTableau
{
    class Personne
    {
        public Personne(string nom, string prenom)
        {
            _Nom = nom;
            _Prenom = prenom;
        }

        public Personne(string nom, string prenom, int age)
        {
            _Nom = nom;
            _Prenom = prenom;
            this._Age = age;
        }

        private string _Nom;
        private string _Prenom;
        private int _Age;

        public string Nom { get => _Nom; }
        public string Prenom { get => _Prenom; }
        public int Age { get => _Age; set => _Age = value; }

        override
        public string ToString()
        {
            return $"Nom : {Nom} , Prénom : {Prenom}, Age : {Age}";
        }

        public virtual void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public static Personne operator ++(Personne pers)
        {
            pers.Age++;
            return pers;
        }
    }
}
