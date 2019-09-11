using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Összegzés, megszámlálás, min, max érték kiválasztás
            int[] szamok = new int[50];
            Random rand = new Random();

            //tömb feltöltése véletlen számokkal
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-121,1016);

            }

            //összegzés
            var osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            Console.WriteLine($"Az elemek összege:{osszeg}");

            //min,max értékek meghatározása
            var min = Int32.MaxValue;
            var max = Int32.MinValue;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<min)
                {
                    min = szamok[i];
                }
                if (szamok[i]>max)
                {
                    max = szamok[i];
                }
            }
            Console.WriteLine($"Min:{min},Max:{max}");

            //negatív számok darabszámának meghatározása
            var nDb = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<0)
                {
                    nDb++;
                }
            }

            Console.WriteLine($"Negatív szám:{nDb}");

            //Linq
            Console.WriteLine($"Összeg:{szamok.Sum()},Átlag:{szamok.Average()},Min:{szamok.Min()},Max:{szamok.Max()}");

            //Megszámlálás valamilyen feltétel alkalmazásával
            Console.WriteLine($"Elemszám:{szamok.Count(x=>x>10 && x<30)}");

            //Kétdimenziós tömb
            int[,] szamok2d = new int[10, 10];

            //feltöltés véletlen számokkal, listázás

            Console.ReadKey();
        }
    }
}
