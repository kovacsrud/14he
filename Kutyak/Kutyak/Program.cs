using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutyanevek kutyanevek = new Kutyanevek(@"d:/rud/kutyanevek.csv");
            var nevlista = kutyanevek.GetKutyanevek();

            foreach (var i in nevlista)
            {
                Console.WriteLine($"{i.Id},{i.Kutyaneve}");
            }

            Console.ReadKey();
        }
    }
}
