using System;
using System.Collections.Generic;
using System.Text;

namespace Article
{
    class Article
    {
        private string nom;
        private int prix;
        private int quantite;

        public Article(string nom, int prix, int quantite)
        {
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
        }

        protected int GetQuantite()
        {
            return quantite;
        }

        protected void SetQuantite(int value)
        {
            this.quantite = value;
        }

        protected string GetNom()
        {
            return nom;
        }

        protected void SetNom(string value)
        {
            this.nom = value;
        }

        protected int GetPrix()
        {
            return prix;
        }

        protected void SetPrix(int value)
        {
            this.prix = value;
        }

        public void acheter()
        {

        }

        public void afficher()
        {
            Console.WriteLine("Nom : "+ this.GetNom() +", Prix :" +  this.GetPrix() + ", Quantite :" + this.GetQuantite());
            //Console.WriteLine($"Nom : {this.GetNom()}, Prix : {this.GetPrix()} , Quantite : {this.GetQuantite()}");
        }

        public void ajouter(int number)
        {
            this.SetQuantite(this.GetQuantite() + number);
        }

        public void retirer(int number)
        {
            // une quantité ne peut pas être inférieur à 0
            if (this.GetQuantite() - number < 0)
            {
                this.SetQuantite(0);
            }
            else
            {
                this.SetQuantite(this.GetQuantite() - number);
            }
        }
    }
}
