using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Teglalap : ISikidom
    {
        private double aoldal;
        private double boldal;

        public Teglalap(double aoldal, double boldal)
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
        }

        public double Kerulet()
        {
            return (aoldal + boldal) * 2;
        }

        public double Terulet()
        {
            return aoldal * boldal;
        }
    }
}
