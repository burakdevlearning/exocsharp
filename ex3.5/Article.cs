using System;
using System.Collections.Generic;
using System.Text;

namespace ex3._5
{
    class Article
    {
        private string name;
        private string description;
        private int quantity;
        private int price;

        public Article(string name, string description, int quantity, int price)
        {
            this.name = name;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        override
        public string ToString()
        {
            return $"Name : {Name}, Description : {Description}, Price : {Price}, Qantity : {quantity}";
        }
    }
}
