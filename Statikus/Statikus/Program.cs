using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statikus
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Alapmuveletek.Osszead(10, 11));
            Console.WriteLine(Alapmuveletek.Oszt(22,48));
            Console.WriteLine(Alapmuveletek.Szoroz(100,49.627));

            

            Console.ReadKey();
        }
    }
}
