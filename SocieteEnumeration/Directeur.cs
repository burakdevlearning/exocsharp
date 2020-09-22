using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumeration
{
    class Directeur : Chef
    {
        private string _Societe;

        public string Societe { get => _Societe; set => _Societe = value; }

        public Directeur(string nom, string prenom, int age, decimal salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            _Societe = societe;
        }

        override
        public string ToString()
        {
            return $"Nom : {Nom} , Prénom : {Prenom}, Age : {Age}, Salaire : {Salaire}, Service : {Service}, Societe : {Societe}";
        }

        override
        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
