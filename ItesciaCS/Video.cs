using System;
using System.Collections.Generic;
using System.Text;

namespace ItesciaCS
{
    class Video : Article
    {
        protected int duree;

        public int GetDuree ()
        { 
            return duree; 
        }

        public void SetDuree(int value)
        {
            this.duree = value;
        }

        public void afficher()
        {

        }
    }
}
