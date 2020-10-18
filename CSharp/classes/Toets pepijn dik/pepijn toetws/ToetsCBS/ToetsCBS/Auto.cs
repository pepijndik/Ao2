using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsCBS
{
    class Auto
    {
        /*
         * File: Class  auto 
         * vars: merk type gewicht hoofdGebruiker levensduur vandaag
  * Author: pepijn dik
  */
        /*
         *  Private vars
         */
        protected string _merk;
        protected string _type;
        protected int _gewicht;
        /*
         * Protected vars
        */
        protected String _hoofdGebruiker;
        protected int _bouwJaar;
        protected DateTime _vandaag;
        /*
         * Constructor
         */
        public Auto(string merk, string type, int bouwjaar)
        {
            this._merk = merk;
            this._type = type;
     
            this._bouwJaar = bouwjaar;
            this._vandaag = DateTime.Now;
        }
        protected string merk
        {
            get { return _merk; }
            set { _merk = value; }
        }
        protected string type
        {
            get { return _type; }
            set { _type = value; }
        }
        protected int gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }
        protected string hoofdGebruiker {
            get { return _hoofdGebruiker; }
            set { _hoofdGebruiker = value; }
        }
        protected int bouwjaar
        {
            get { return _bouwJaar; }
            set { _bouwJaar = value; }
        }
 
        public string Show()
        {
            //Show auto in 1 regel
            string bj = _bouwJaar.ToString();
            return _merk + " " + _type + "" + bj+ " " + _hoofdGebruiker;
        }
    }
}
