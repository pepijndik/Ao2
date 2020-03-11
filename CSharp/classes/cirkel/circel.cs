using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cirkel
{
    class circel
    {
        /*
         * oppervlakte = π * straal * straal
         * omtrek = 2 * π * straal
         * waarbij π = 3,141
         */
        private double _p = 3.141;
        public double oppervlak(double straal)
        {
            return _p * (straal * straal);
        }

        public double  omtrek(double straal)
        {
            return 2 * _p * straal;
        }
    }
}
