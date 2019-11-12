using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    public abstract class Peksutemeny:IArlap
    {
        private double alapar;
        protected double mennyiseg;

        public Peksutemeny(double alapar, double mennyiseg)
        {
            this.alapar = alapar;
            this.mennyiseg = mennyiseg;
        }

        public void setAlapar(double alapar)
        {
            this.alapar = alapar;
        }

        public double getAlapar()
        {
            return this.alapar;
        }
        
        public void setMennyiseg(double mennyiseg)
        {
            this.mennyiseg = mennyiseg;
        }
        public double getMennyiseg()
        {
            return this.mennyiseg;
        }

        public double mennyibeKerul()
        {
            return alapar * mennyiseg;
        }

        public abstract void megKostol();

        public override string ToString()
        {
            return $"Mennyiség:{mennyiseg}, Alapár:{alapar}";
        }
    }
}
