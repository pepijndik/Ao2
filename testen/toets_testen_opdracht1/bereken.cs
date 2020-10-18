using System;
using System.Collections.Generic;
using System.Text;

namespace toets_testen_opdracht1
{
  public class bereken
    {
        /**
         * Author Pepijn dik
         * File: Calculate rental
         */

        private string _type;
        private int _dagen;
        private double _km;
        private int _huurPrijs;
        private double _berijk;
        private double _prijskm;
        //Construct
        public bereken(string type, int dagen, double km)
        {
            this._type = type;
            this._dagen = dagen;
            this._km = km;
        }

        //Getters  and setters
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int dagen
        {
            get { return _dagen; }
            set { _dagen = value; }
        }
        public double berijk
        {
            get { return _berijk; }
            set { _berijk = value; }
        }
        public double prijskm
        {
            get { return _prijskm; }
            set { _prijskm = value; }
        }
        public int hprijs
        {
            get { return _huurPrijs; }
            set { _huurPrijs = value; }
        }

        public double km
        {
            get { return _km; }
            set { _km = value; }
        }

        public string huur()
        {
            //Convert Double back to String for return
            string return_prijs = "";
    
            berijk = 100 * dagen;
            /*Overige km =*/
            double Kilometers = km - berijk;
            if(km >= berijk)
            {
                prijskm = Kilometers * 0.20;
            
            }
            else
            {
                prijskm = 0;
            }
            if (type == "a")
            {
                hprijs = 50;

                double v = (hprijs * dagen) + prijskm;
                
               return_prijs = v.ToString();


            }
            if (type == "b")
            {
                hprijs = 75;

                return_prijs = (hprijs * dagen + prijskm).ToString();
            }
            if (type == "c")
            {
                hprijs = 100;

                return_prijs = (hprijs * dagen + prijskm).ToString();
            }

            if (type == "")
            {
                return_prijs = "Er is geen  type auto gekozen";
                //Shows error
            }
            return return_prijs;
        }
    }

}
