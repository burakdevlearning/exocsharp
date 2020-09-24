using System;
using System.Collections.Generic;

namespace ex3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articlesList = new List<Article>()
            {
                new Article("My first program","Hello World",15,1),
                new Article("What is web development","JS,HTML,CSS",9,4),
                new Article("Who created React","Facebook",10,1),
            };

            ArticleDAO dao = new ArticleDAO(articlesList);
            string articleName = "My first program";
            int quantity = dao.GetArticleQuantityPriceByName(articleName).Item1;
            int price = dao.GetArticleQuantityPriceByName(articleName).Item2;

            Console.WriteLine($"There are {quantity} articles by the name of {articleName} and their price is {price}");
        }
    }
}
