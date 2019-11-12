using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamitogepOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Szamitogep gep1 = new Szamitogep(2048, true);
            Szamitogep gep2 = new Szamitogep();
            Console.WriteLine(gep1);
            gep2.Kapcsol();
            Console.WriteLine(gep2);

            if (gep2.programMasol(800))
            {
                Console.WriteLine("Sikeres másolás!");
                Console.WriteLine(gep2);
            } else
            {
                Console.WriteLine("Sikertelen másolás!");
                Console.WriteLine(gep2);
            }

            if (gep2.programMasol(400))
            {
                Console.WriteLine("Sikeres másolás!");
                Console.WriteLine(gep2);
            }
            else
            {
                Console.WriteLine("Sikertelen másolás!");
                Console.WriteLine(gep2);
            }


            Console.ReadKey();
        }
    }
}
