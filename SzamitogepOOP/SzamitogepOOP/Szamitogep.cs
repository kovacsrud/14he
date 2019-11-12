using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamitogepOOP
{
    public class Szamitogep
    {
        private double szabadMemoria;
        private bool beKapcsolva;

        public Szamitogep()
        {
            this.szabadMemoria = 1024;
            this.beKapcsolva = false;
        }

        public Szamitogep(double szabadMemoria, bool beKapcsolva)
        {
            this.szabadMemoria = szabadMemoria;
            this.beKapcsolva = beKapcsolva;
        }

        public void Kapcsol()
        {
            beKapcsolva = !beKapcsolva;
        }

        public bool programMasol(double programMeret)
        {
            bool sikeresMasolas = false;

            if (szabadMemoria>programMeret && beKapcsolva)
            {
                szabadMemoria -= programMeret;
                sikeresMasolas = true;
            }


            return sikeresMasolas;
        }

        public override string ToString()
        {
            String adatok = "";
            if (beKapcsolva)
            {
                adatok = adatok + "A számítógép be van kapcsolva";
            } else
            {
                adatok = adatok + "A számítógép ki van kapcsolva";
            }

            return adatok+$" Szabad memória:{szabadMemoria}";
        }

    }
}
