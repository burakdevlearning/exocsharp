using System;
using System.Collections.Generic;
using System.Text;

namespace ItesciaCS
{
    class Article
    {
        protected string designation;
        protected int prix;

        public string GetDesignation()
        {
            return designation;
        }

        public void SetDesignation(string value)
        {
            this.designation = value;
        }

        public int GetPrix()
        {
            return prix;
        }

        public void SetPrix(int value)
        {
            this.prix = value;
        }

        public void acheter()
        {

        }
    }
}
