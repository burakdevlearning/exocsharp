using System;
using System.Collections.Generic;
using System.Text;

namespace ItesciaCS
{
    class Disque : Article
    {
        protected string label;

        public string GetLabel()
        {
            return label;
        }

        public void SetLabel(string value)
        {
            this.label = value;
        }

        public void ecouter()
        {

        }
    }
}
