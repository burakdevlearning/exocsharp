using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex3._5
{
    class ArticleDAO : IArticleDAO
    {
        public List<Article> articles { get;}

        public ArticleDAO()
        {
            articles = GetArticles();
        }

        public ArticleDAO(List<Article> articles)
        {
            this.articles = articles;
        }

        public List<Article> GetArticlesByPrice(int price)
        {
            return this.articles.Where(art => art.Price == price).ToList();
        }

        public Article GetArticleByName(string name)
        {
           return this.articles.Where(art => art.Name == name).FirstOrDefault();
        }

        public (int, int) GetArticleQuantityPriceByName(string name)
        {
            Article art = this.articles.Where(art => art.Name == name).FirstOrDefault();
            return (art.Quantity, art.Price);
        }

        public List<Article> GetArticles()
        {
            return new List<Article>()
            {
                new Article("Vainqueur F1","C'est hamilton",22,1),
                new Article("Vainqueur F2","C'est john",15,4),
                new Article("Vainqueur F3","C'est lucas",10,5),
                new Article("Vainqueur F4","C'est fred",11,22),
                new Article("Vainqueur F5","C'est amid",13,1),
                new Article("Vainqueur F6","C'est giovanni",9,10),
            };
        }
    }
}
