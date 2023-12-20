using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FulBank.Model
{
    internal class unCompte
    {
        private int _rib;
        private decimal _taux;
        private decimal _solde;
        private decimal _plafond;
        private decimal _decouvert;



        public unCompte( int rib, decimal taux, decimal solde, decimal plafond, decimal decouvert)
        {
            _rib = rib;
            _taux = taux;
            _solde = solde;
            _plafond = plafond;
            _decouvert = decouvert;
        }

        public decimal getSolde() {  return _solde; }
    }
}
