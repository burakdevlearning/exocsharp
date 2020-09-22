using System;
using System.Collections.Generic;
using System.Text;

namespace ItesciaCS
{
    class Poche : Livre
    {
        protected string categorie;

        public string GetCategorie()
        {
            return categorie;
        }

        public void SetCategorie(String value)
        {
            this.categorie = value;
        }
    }
}
