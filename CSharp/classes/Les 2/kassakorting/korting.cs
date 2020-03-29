using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kassakorting
{
    /*Je kent de aanbiedingen misschien wel. Extra kassakorting bovenop de al bestaande korting. 
     * Maar vaak zit er een addertje onder het gras. 
     * Meestal gaat de extra korting niet van het totale bedrag af maar op het bedrag waar de eerste korting al vanaf is gegaan. 
     * Maak een programma die deze constructie simuleert. 
     * Je kunt het bedrag invullen en het kortingspercentage. 
     * Maak ook weer een propertie aan en een functie die het totaalbedrag / korting berekent. 
     * De uitdaging is vooral het doorberekenen van de korting op het nieuwe bedrag en niet op het ingevulde bedrag.
     */
    class korting
    {

 
        private double _prijs;

   

        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }
        public double bereken(double korting, double prijs)
        {
       
            double getal1 = prijs / 100 * korting; // eerste korting getal  2.5 
            prijs = prijs - getal1; // prijs - korting   7.5

            double getal2 = prijs / 100 * korting; // Reken 2de korting uit
            Prijs = prijs - getal2; // korting totaal  
            return Prijs;
        }
    }
}
