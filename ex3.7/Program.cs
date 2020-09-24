using System;
using System.Collections.Generic;

namespace ex3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articlesList = new List<Article>()
            {
                new Article("My first program","Hello World",15,1),
                new Article("What is web development","JS,HTML,CSS",9,4),
                new Article("Who created React","Facebook",10,2),
            };

            ArticleDAO dao = new ArticleDAO(articlesList);
            Console.WriteLine(dao.GetArticlesInformations());
        }
    }
}
