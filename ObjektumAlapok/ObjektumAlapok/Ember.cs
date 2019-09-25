using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumAlapok
{
    class Ember
    {
        private string nev;
        private int szuletesiEv;
        private int suly;
        private int magassag;

        //konstruktor ->inicializálás, kezdeti értékek megadása
        public Ember()
        {
            nev = "_default";
            szuletesiEv = 1999;
            suly = 10;
            magassag = 150;
        }
        //paraméteres konstruktor
        public Ember(string nev,int szuletesiev,int suly,int magassag)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiev;
            this.suly = suly;
            this.magassag = magassag;
        }

        public void setNev(string n)
        {
            nev = n;
        }
        public string getNev()
        {
            return nev;
        }

        public void Noveszt(int novekedes)
        {
            if (novekedes>=1 && novekedes<=5 && (magassag+novekedes)<=200)
            {
                magassag = magassag + novekedes;
            }else
            {
                Console.WriteLine("Hibás növesztés!");
            }
            
        }

        public int getMagassag()
        {
            return magassag;
        }

    }
}
