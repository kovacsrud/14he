using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasarlasok
{
    public class Vasarlas
    {
        

        public int Sorszam { get; set; }
        public string Aru { get; set; }

        public Vasarlas(int sorszam, string aru)
        {
            Sorszam = sorszam;
            Aru = aru;
        }

    }
}
