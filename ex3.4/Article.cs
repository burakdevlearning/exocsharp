using System;
using System.Collections.Generic;
using System.Text;

namespace ex3._4
{
    class Article
    {
        private string name;
        private string description;
        private int price;

        public Article(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }

        override
        public string ToString()
        {
            return $"Name : {Name}, Description : {Description}, Price : {Price}";
        }
    }
}
