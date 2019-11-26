using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdojaras
{
    public class IdojarasAdat
    {
        public int Ev { get; set; }
        public int Honap { get; set; }
        public int Nap { get; set; }
        public int Ora { get; set; }
        public double Homerseklet { get; set; }
        public double Szelsebesseg { get; set; }
        public double Paratartalom { get; set; }

        public IdojarasAdat(string sor)
        {
            var e = sor.Split(';');
            Ev = Convert.ToInt32(e[0]);
            Honap= Convert.ToInt32(e[1]);
            Nap= Convert.ToInt32(e[2]);
            Ora = Convert.ToInt32(e[3]);
            Homerseklet = Convert.ToDouble(e[4]);
            Szelsebesseg= Convert.ToDouble(e[5]);
            Paratartalom = Convert.ToDouble(e[6]);
        }



    }
}
