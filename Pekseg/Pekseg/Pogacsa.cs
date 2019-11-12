using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    public class Pogacsa : Peksutemeny
    {
        public Pogacsa(double alapar, double mennyiseg) : base(alapar, mennyiseg)
        {
        }

        public override void megKostol()
        {
            mennyiseg = mennyiseg / 2;
        }
        public override string ToString()
        {
            return "Pogácsa:"+base.ToString();
        }
    }
}
