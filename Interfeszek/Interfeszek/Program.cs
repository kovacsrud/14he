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

            List<ISikidom> sikidomok = new List<ISikidom>();

            Kor kor1 = new Kor(19);
            Kor kor2 = new Kor(26.78);
            Teglalap tegla1 = new Teglalap(16.8, 23);
            Teglalap tegla2 = new Teglalap(34.29, 45);

            Console.WriteLine($"Kör:{kor1.Kerulet()};{kor1.Terulet()}");
            Console.WriteLine($"Téglalap:{tegla2.Kerulet()};{tegla2.Terulet()}");
            sikidomok.Add(kor1);
            sikidomok.Add(kor2);
            sikidomok.Add(tegla1);
            sikidomok.Add(tegla2);

            //a listán szereplő síkidomok kerületének összege
            Console.WriteLine(sikidomok.Sum(x=>x.Kerulet()));

            //a listán szereplő síkidomok területének átlaga
            Console.WriteLine(sikidomok.Average(x=>x.Terulet()));

            //hogyan lehet különbséget tenni a lista elemei között?
            Console.WriteLine(sikidomok.Where(x=>x.GetType()==typeof(Kor)).Sum(x=>x.Kerulet()));
            


            Console.ReadKey();
        }
    }
}
