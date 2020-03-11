using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btw
{

    class btw
    {
        private double _btw = 1.19;
        private double _prijs;

        public double bereken(double prijs)
        {
            return prijs * _btw;
        }
    }
}
