using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCar2
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoContext = new AutoContext();
            Auto auto = new Auto {Gyartmany="Opel",Tipus="Corsa",GyartasEve=2006 };
            Tulaj tulaj = new Tulaj {Nev="Huba",SzuletesEve=2001,auto=auto };

            autoContext.Autok.Add(auto);
            autoContext.Tulajok.Add(tulaj);

            autoContext.SaveChanges();

            Console.WriteLine("Kész");

            Console.ReadKey();
        }
    }
}
