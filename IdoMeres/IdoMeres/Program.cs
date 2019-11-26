using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdoMeres
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = { 10, 2, 388, 219, 8, 47, 69, 1026, 411, 524, 873 };

            Stopwatch stopper = new Stopwatch();

            stopper.Start();

            //tömb rendezés
            Rendezes(szamok);
            stopper.Stop();

            Console.WriteLine(stopper.ElapsedTicks);
            stopper.Reset();

            int[] szamok2 = { 10, 2, 388, 219, 8, 47, 69, 1026, 411, 524, 873 };

            stopper.Start();
            Array.Sort(szamok2);
            stopper.Stop();
            Console.WriteLine(stopper.ElapsedTicks);


            Console.ReadKey();
        }

        private static void Rendezes(int[] szamok)
        {
            for (int i = 0; i < szamok.Length - 1; i++)
            {
                for (int j = i + 1; j < szamok.Length; j++)
                {
                    if (szamok[i] > szamok[j])
                    {
                        var temp = szamok[i];
                        szamok[i] = szamok[j];
                        szamok[j] = temp;
                    }
                }
            }
        }
    }
}
