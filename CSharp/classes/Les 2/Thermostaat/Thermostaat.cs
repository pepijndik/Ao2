using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermostaat
{
    /* 
     * *Schrijf een classe Thermostaat die de huidige temperatuur uitleest in een apart formulier. 
     * Deze waarde kan afzonderlijk worden ingesteld. 
     * Vervolgens maak je 4 instanties aan van een thermostaat die afzonderlijk zijn te regelen. 
     * Gebruik hiervoor een getter en een setter.
     * De huidige temperatuur is dan toevallig de temperatuur die je hebt ingevoerd. 
     * Verder kunnen de knoppen van elke thermostaat afzonderlijk worden bediend.
     * 1 thermostaat voor het woongedeelte
     * 1 thermostaat voor de douche.
     * 1 thermostaat voor de grootste slaapkamer
     * 1 thermostaat voor de zolder.

 */
    class Thermostaat
    {

        private double _waarde;

        public double Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }
    }
}
