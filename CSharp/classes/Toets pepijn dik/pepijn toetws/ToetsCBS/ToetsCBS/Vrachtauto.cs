using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsCBS
{
    class Vrachtauto:Auto
    {   /*
   * File: Class vrachtauto auto 
   * vars: merk type gewicht _totale_belasting levensduur
   * Author: pepijn dik
   */
        private int _totale_belasting, _levensduur;
        public Vrachtauto(string merk, string type, int gewicht, int totale_belasting) : base(merk, type, gewicht)
        {
            this._totale_belasting = totale_belasting;
            this._levensduur = 13;
        }

        private int totale_belasting
        {
            get { return _totale_belasting; }
            set { _totale_belasting = value; }
        }
        private int levensduur
        {
            get { return _levensduur; }
            set { _levensduur = value; }
        }

        public string Show()
        {

            //Show auto in 1 regel
            string bj = _bouwJaar.ToString();
            return merk + " " + type + " Bouwjaar " + bj+ " Belasting" + totale_belasting;
        }

        public string ControleLevensDuur()
        {
            if (_bouwJaar <= levensduur)
            {
                return "Auto in orde";
            }
            else
            {
                return "Afgeschreven";
            }
        }
    }
}
