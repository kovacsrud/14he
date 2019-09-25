using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumAlapok
{
    class JobbEmber
    {
       

        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public uint Suly { get; set; }
        private int magassag;
        public int Magassag {

            get { return magassag; }

            set {
                if (value>50 && value<200)
                {
                    magassag = value;
                }else
                {
                    magassag = 51;
                }

            }


        }

        public JobbEmber(string nev, int szuletesiEv, int suly, int magassag)
        {
            Nev = nev;
            SzuletesiEv = szuletesiEv;
            Suly = suly;
            Magassag = magassag;
        }



    }
}
