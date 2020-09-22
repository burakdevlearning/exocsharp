using System;
using System.Runtime.Intrinsics.X86;

namespace ArticleTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciation
            Article produitAuchan = new Article("t-shirt nike", 49, 253, ArticleType.habillement);
            Article produitCarrefour = new Article("Playstation 5", 499, 58, ArticleType.loisir);
            Article produitLidl = new Article("Croissant", 1, 30, ArticleType.alimentaire);

            Article[] articles = new Article[]
            {
                produitAuchan,
                produitCarrefour,
                produitLidl
            };

            //Affichage
            Console.WriteLine("Affichage de tous les produits créés seuls");
            produitAuchan.afficher();
            produitCarrefour.afficher();
            produitLidl.afficher();

            //Affichage du tableau
            Console.WriteLine("Affichage de tous les produits à partir du tableau avec foreach");
            foreach(Article art in articles)
            {
                art.afficher();
                art.ajouter(40);
                art.afficher();
            }

            // autre maniere
            Console.WriteLine("Affichage de tous les produits à partir du tableau avec for et une modification différente de chaque élément");
            for(int i = 0; i < articles.Length; i++)
            {
                if(i == 0)
                {
                    articles[i].ajouter(140);
                }
                if(i == 1)
                {
                    articles[i].retirer(20);
                }
                if(i == 2)
                {
                    articles[i].retirer(999);
                }
                articles[i].afficher();
            }


        }
    }
}
