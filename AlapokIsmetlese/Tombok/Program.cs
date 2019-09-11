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
                szamok[i] = rand.Next(1,101);

            }

            //összegzés
            var osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            Console.WriteLine($"Az elemek összege:{osszeg}");
        }
    }
}
