using SocieteEnumeration.ListeChainee;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumeration
{
    class ListeEnumerator : IEnumerator<Liste>
    {
        private Liste _List;
        private int _indiceCourant;

        #region pas compris l'utilité
        Liste IEnumerator<Liste>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();
        #endregion

        public ListeEnumerator(Liste list)
        {
            _List = list;
            _indiceCourant = 0;
        }

        public object Current() {
            return this._List[_indiceCourant].Objet;        
        }


        public bool MoveNext()
        {
            this._indiceCourant++;
            if (this._indiceCourant > this._List.NbElements - 1)
                return false;
            return true;
        }

        public void Reset()
        {
            this._indiceCourant = 0;
        }

        public void Dispose()
        {
            _List = null;
            _indiceCourant = 0;
        }
    }
}
