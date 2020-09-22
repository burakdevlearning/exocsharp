using System;
using System.Collections.Generic;
using System.Text;

namespace ItesciaCS
{
    class Livre : Article
    {
        protected string isbn;
        protected int nbPages;

        public string GetIsbn() 
        { 
            return isbn; 
        }

        public void SetIsbn(string value)
        {
            this.isbn = value;
        }

        public int GetNbPages() 
        { 
            return nbPages;
        }

        public void SetNbPages(int value)
        {
            this.nbPages = value;
        }
    }
}
