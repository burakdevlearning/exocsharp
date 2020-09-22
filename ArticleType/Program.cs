using System;
using System.Runtime.Intrinsics.X86;

namespace ArticleType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciation
            Article produitAuchan = new Article("t-shirt nike", 49, 253, ArticleType.habillement);
            Article produitCarrefour = new Article("Playstation 5", 499, 58, ArticleType.loisir);

            //Affichage
            Console.WriteLine("Affichage de tous les produits créés");
            produitAuchan.afficher();
            produitCarrefour.afficher();


            Console.WriteLine("Entrez un nom de produit :");
            string articleName = Console.ReadLine();

            Console.WriteLine("Entrez le prix du produit :");
            int articlePrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la quantité de produit :");
            int articleQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le type de produit parmis les choix disponibles : Alimentaire, Droguerie, Habillement, Loisir ou autre;");
            string articleType = Console.ReadLine();
            ArticleType enumArticleType = ArticleType.autre;

            switch (articleType.ToLower())
            {
                case "alimentaire":
                    enumArticleType = ArticleType.alimentaire;
                    break;
                case "droguerie":
                    enumArticleType = ArticleType.droguerie;
                    break;
                case "habillement":
                    enumArticleType = ArticleType.habillement;
                    break;
                case "loisir":
                    enumArticleType = ArticleType.loisir;
                    break;
                // le type d'article autre est déjà assigné lors de l'instanciation inutile de répété, tout autre texte entré sera considéré comme type autre
                default:
                    break;
            }

            //instanciation du produit créé par l'utilisateur
            Article userArticle = new Article(articleName, articlePrice, articleQuantity, enumArticleType);
            //affichage
            userArticle.afficher();

            Console.WriteLine("Voulez-vous ajouter une quantité ou en retirer? (A/R) :");
            string choice = Console.ReadLine();

            while (choice.ToUpper() != "A" && choice.ToUpper() != "R")
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
