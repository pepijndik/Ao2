using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechthoek
{
    class Rechthoek
    {

        public double omtrek(double l, double b)
        {
            // (Lengte + Breedte) x 2 = Omtrek vierkant/rechthoek
            return (l + b) * 2;
        }

        public double oppervalk(double l, double b)
        {
            //Lenge x Breedte = oppervlakte
            return l * b;
        }
    }
}
