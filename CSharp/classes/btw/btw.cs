using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btw
{

    class btw
    {
        public btw(double btw)
        {
            this._btw = btw;
            
        }

        private double _btw;
        private double _prijs;

        public double bereken(double prijs)
        {
            return prijs * _btw;
        }
    }
}
