using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCarMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoContext = new AutoContext();

            Auto auto = new Auto {Gyartmany="Opel",Tipus="Fiat",GyartasiEv=1999 };
            autoContext.autok.Add(auto);
            autoContext.SaveChanges();

            Console.WriteLine("Kész!");

            Console.ReadKey();
        }
    }
}
