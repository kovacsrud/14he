using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Program
    {
        static void Main(string[] args)
        {
            Kor kor1 = new Kor(19);
            Kor kor2 = new Kor(26.78);
            Teglalap tegla1 = new Teglalap(16.8, 23);
            Teglalap tegla2 = new Teglalap(34.29, 45);

            Console.WriteLine($"Kör:{kor1.Kerulet()},{kor1.Terulet()}");
            Console.WriteLine($"Téglalap:{tegla2.Kerulet()},{tegla2.Terulet()}");



            Console.ReadKey();
        }
    }
}
