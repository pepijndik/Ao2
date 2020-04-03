using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechthoek
{
    class rechthoek
    {

        private double _lengte;
        private double _breedte;
        private double _omtrek;
        private double _oppervlakte;
        public rechthoek(double lengte, double breedte)
        {
            this._lengte = lengte;
            this._breedte = breedte;
    
        }
        //Getters  and setters
        public double Omtrek
        {
            get { return _omtrek; }
            set { _omtrek = value; }
        }
        public double Oppervlakte
        {
            get { return _oppervlakte; }
            set { _oppervlakte = value; }
        }

        public   double opp()
        {
            //L * B
            return Oppervlakte = _lengte * _breedte;
        }
        public  double om()
        {
            //(Lengte + Breedte) x 2 = Omtrek vierkant/rechthoek.
            return Omtrek = (_lengte + _breedte) * 2;
        }
    }
}
