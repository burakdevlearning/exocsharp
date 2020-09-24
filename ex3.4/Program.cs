using System;
using System.Collections.Generic;

namespace ex3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articlesList = new List<Article>()
            {
                new Article("My first program","Hello World",1),
                new Article("What is web development","JS,HTML,CSS",4),
                new Article("Who created React","Facebook",1),
            };

            ArticleDAO dao = new ArticleDAO(articlesList);

           
            Console.WriteLine(dao.GetArticleByName("My first program").ToString());

            List<Article> cheapest = dao.GetArticlesByPrice(1);
            Console.WriteLine("Cheapest articles :");
            foreach (Article cheapArticle in cheapest)
                Console.WriteLine(cheapArticle.ToString());
        }
    }
}
