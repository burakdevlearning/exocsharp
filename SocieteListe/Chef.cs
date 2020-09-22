using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteListe
{
    class Chef : Employe
    {
        private string _Service;
        public string Service { get => _Service; set => _Service = value; }

        public Chef(string nom, string prenom, int age, decimal salaire, string service) : base(nom,prenom,age,salaire)
        {
            _Service = service;
        }

        override
        public string ToString()
        {
            return $"Nom : {Nom} , Prénom : {Prenom}, Age : {Age}, Salaire : {Salaire}, Service : {Service}";
        }

        override
        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
