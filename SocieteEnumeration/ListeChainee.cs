using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumeration.ListeChainee
{
    class Liste
    {
        private Element _Debut;
        private int _NbElements;

        //private Element[] arr = new Element[NbElements];
        private Element[] arr = new Element[100];

        public void fillArray()
        {
            Element surf = this._Debut;
            if(surf != null) {
                int i = 0;
                arr[i] = surf;
                while (surf.Suivant != null)
                {
                    surf = surf.Suivant;
                    i++;
                    arr[i] = surf;
                }
            }
        }

        public Element this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }

        public int NbElements { get => _NbElements;}

        public Liste()
        {
            _Debut = null;
            _NbElements = 0;
        }
        public void InsererDebut(object premier_objet)
        {
            Element newDebut = new Element(premier_objet);
            newDebut.Suivant = this._Debut;
            this._Debut = newDebut;
            this._NbElements++;
            fillArray();
        }

        public void InsererFin(object dernier_objet)
        {
            Element newFin = new Element(dernier_objet);
            if(this._Debut == null)
            {
                this._Debut = newFin;
                this._NbElements++;
                return;
            }
            Element dernierElement = RecupereDernierElement();
            dernierElement.Suivant = newFin;
            this._NbElements++;
            fillArray();
        }

        public Element RecupereDernierElement()
        {
            Element surf = this._Debut;
            while (surf.Suivant != null)
            {
               surf  = surf.Suivant;
            }
            return surf;
        }

        public void Lister()
        {
            Element surf = this._Debut;
            if (surf != null) {
                string cumul = surf.Objet.ToString();
                while (surf.Suivant != null)
                {
                    surf = surf.Suivant;
                    cumul += "," + surf.Objet.ToString(); 
                }
                Console.WriteLine(cumul);
            }
            else
            {
                Console.WriteLine("La liste est vide");
            }
        }

        public void Vider()
        {
            this._Debut = null;
            this._NbElements = 0;
            fillArray();
        }

    }

    class Element
    {
        private Object _Objet;
        private Element _Suivant;

        public object Objet { get => _Objet; set => _Objet = value; }
        public Element Suivant { get => _Suivant; set => _Suivant = value; }

        public Element(object objet)
        {
            _Objet = objet;
            Suivant = null;
        }
    }
}
