using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class getal
    {
        private double _getal;
        private double _helft;
        private double _kwadraad;
        public double dubbel(double getal)
        {
            return _getal = getal * 2;
            
        }

        public double helft(double getal)
        {
            return _helft = getal / 2;
        }
        public double kwadraad(double getal)
        {
            return _kwadraad = getal * getal;
        }
    }
}
