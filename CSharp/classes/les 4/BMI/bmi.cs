using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class bmi
    {
        /*BMI =gewicht(kg) / lengte(m)^2
         * De BMI wordt in de volgende categorieën onderverdeeld:
         * BMI (kg/m²)
         * Categorie
         * minder dan 18,5
         * ondergewicht
         * 18,5 tot 25
         * normaal gewicht
         * 25 tot 27
         * licht overgewicht
         * 27 tot 30
         * matig overgewicht
         * 30 tot 40
         * ernstig overgewicht
         * meer dan 40
         * ziekelijk overgewicht */

        //Getters  and setters
        private double _lengte;
        private double _gewicht;
        private double _bmi;
        private string _bmiText;
        //construct
        public bmi(double lengte, double gewicht)
        {
            this._lengte = lengte;
            this._gewicht = gewicht;
        
        }
        public double Bmi
        {
            get { return _bmi; }
            set { _bmi = value; }
        }
        public double lengte
        {
            get { return _lengte; }
            set { _lengte = value; }
        }
        public double Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        public double bereken()
        {
            Bmi = (Gewicht / lengte) * 2;
            return Bmi;
        }
        public string check()
        {
            if(Bmi < 18.5){
                _bmiText = "Ondergewicht";
            }else if (Bmi > 18.5 && Bmi < 25)
            {
                _bmiText = "normaal gewicht";
            }
            else if (Bmi > 25 && Bmi < 27)
            {
                _bmiText = "licht overgewicht";
            }
            else if (Bmi > 27 && Bmi < 30)
            {
                _bmiText = "matig overgewicht";
            }
            else if (Bmi > 30 && Bmi < 40)
            {
                _bmiText = "ernstig overgewicht";
            }
            else if (Bmi > 40)
            {
                _bmiText = "ziekelijk overgewicht";
            }
            return _bmiText;
        }
    }
}
