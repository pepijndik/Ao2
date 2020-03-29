using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_en_cijfer_bepalen
{
    class prop
    {
        private double _cijfer;

        public double Cijfer
        {
            get { return _cijfer; }
            set { _cijfer = value;  }
        }

        public double bereken(double score)
        {
            //cijfer = score/100*9+1
            Cijfer = (score / 100) * (9 + 1);
            return Cijfer;
        }
    }
}
