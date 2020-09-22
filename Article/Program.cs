using System;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciation
            Article produitAuchan = new Article("poussette", 40, 253);
            Article produitCarrefour = new Article("poussette", 25, 58);
            Article produitLeclerc = new Article("poussette", 99, 20);

            //Affichage
            Console.WriteLine("Affichage de tous les produits créés");
            produitAuchan.afficher();
            produitCarrefour.afficher();
            produitLeclerc.afficher();

            //ajout + retret qte produit auchan
            Console.WriteLine("Ajout de quantité au produit d'auchan");
            produitAuchan.ajouter(75);
            produitAuchan.afficher();
            Console.WriteLine("Retret de quantité au produit d'auchan");
            produitAuchan.retirer(400);
            produitAuchan.afficher();

            //ajout + retret qte produit carrefour
            Console.WriteLine("Ajout de quantité au produit de carrefour");
            produitCarrefour.ajouter(49);
            produitCarrefour.afficher();
            Console.WriteLine("Retret de quantité au produit de carrefour");
            produitCarrefour.retirer(56);
            produitCarrefour.afficher();

            //ajout + retret qte produit leclerc
            Console.WriteLine("Ajout de quantité au produit de leclerc");
            produitLeclerc.ajouter(30);
            produitLeclerc.afficher();
            Console.WriteLine("Retret de quantité au produit de leclerc");
            produitLeclerc.retirer(22);
            produitLeclerc.afficher();
            
            Console.WriteLine("Entrez un nom de produit :");
            string articleName = Console.ReadLine();

            Console.WriteLine("Entrez le prix du produit :");
            int articlePrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la quantité de produit :");
            int articleQuantity = int.Parse(Console.ReadLine());

            //instanciation du produit créé par l'utilisateur
            Article userArticle = new Article(articleName, articlePrice, articleQuantity);
            //affichage
            userArticle.afficher();

            Console.WriteLine("Voulez-vous ajouter une quantité ou en retirer? (A/R) :");
            string choice = Console.ReadLine();

            while(choice.ToUpper() != "A" && choice.ToUpper() != "R")
            {
                Console.WriteLine("Veuillez respecter les seules réponses disponibles : celle qui sont entre parenthèses !");
                Console.WriteLine("Voulez-vous ajouter une quantité ou en retirer? (A/R) :");
                choice = Console.ReadLine();
            }

            if (choice.ToUpper() == "A")
            {
                Console.WriteLine("Quel est la quantité que vous souhaitez ajouter ?");
                int quantityToAdd = int.Parse(Console.ReadLine());
                userArticle.ajouter(quantityToAdd);
                userArticle.afficher();
            }
            else
            {
                Console.WriteLine("Quel est la quantité que vous souhaitez retirer ?");
                int quantityToRemove = int.Parse(Console.ReadLine());
                userArticle.retirer(quantityToRemove);
                userArticle.afficher();
            }
        }
    }
}
