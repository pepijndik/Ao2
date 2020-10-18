using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsCBS
{
    /*
   * File: Class personen auto 
   * vars: merk type gewicht aantalzitplaatsen levensduur
   * Author: pepijn dik
   */

    class Personenauto : Auto
    {
        private int _aantalZitPlaatsen, _levensduur;
        public Personenauto(string merk, string type, int bouwjaar, int aantalZitPlaatsen) : base(merk, type, bouwjaar)
        {
            this._aantalZitPlaatsen = aantalZitPlaatsen;
            this._levensduur = 18;
        }
        private int aantal_zitplaatsen
        {
            get { return _aantalZitPlaatsen; }
            set { _aantalZitPlaatsen = value; }
        }
        private int levensduur
        {
            get { return _levensduur; }
            set { _levensduur = value; }
        }

        public string Show()
        {

            //Show auto in 1 regel
            string bj = bouwjaar.ToString();
            return merk + " " + type + " " + aantal_zitplaatsen + " Zitplaatsen " + " bouwjaar "+bj;
        }

        public string ControleLevensDuur()
        {
            if (_bouwJaar <= levensduur)
            {
                return "Auto in orde";
            }
            else
            {
                return "Auto is af geschreven";
            }
        }
    }
}
