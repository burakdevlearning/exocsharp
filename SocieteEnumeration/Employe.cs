using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace SocieteEnumeration
{
    class Employe : Personne
    {
        private decimal _Salaire;
        public decimal Salaire { get => _Salaire; set => _Salaire = value; }

        public Employe(string nom, string prenom, int age, decimal salaire) : base(nom,prenom,age)
        {
            _Salaire = salaire;
        }

        override
        public string ToString()
        {
            return $"Nom : {Nom} , Prénom : {Prenom}, Age : {Age}, Salaire : {Salaire}";
        }

        override
        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
