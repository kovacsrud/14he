using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Kor : ISikidom
    {
        private double sugar;

        public Kor(double s)
        {
            sugar = s;
        }

        public double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }

        public double Terulet()
        {
            return sugar * sugar * Math.PI;
        }
    }
}
