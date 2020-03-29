using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Lijndikte
{
    class circel
    {
        /* *1 Lijndikte instellen
         * Schrijf voor de klasse cirkel de mogelijkheid om de lijndikte in te stellen. 
         * Maak bij voorkeur gebruik van een aparte getter en setter.*/

        private int _lijnDikte;

        public int LijnDikte
        {
            get { return _lijnDikte; }
            set { _lijnDikte = value;  }
        }
    }
}
