using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringekEsKarakterek
{
    class Program
    {
        static void Main(string[] args)
        {
            String szoveg = "Szöveges adat";

            Console.WriteLine(szoveg[0]);

            //stringekkel végzett műveletek
            Console.WriteLine(szoveg.Length);
            //kisbetűsre alakítás
            Console.WriteLine(szoveg.ToLower());
            //nagybetűsre
            Console.WriteLine(szoveg.ToUpper());
            //kezdődik valami szöveggel?
            Console.WriteLine(szoveg.StartsWith("Szö"));
            //betűk, szöveg felülírása
            Console.WriteLine(szoveg.Replace('e','ö'));
            Console.WriteLine(szoveg.Replace("adat", "érték"));

            //Szövegrész kiemelése
            Console.WriteLine(szoveg.Substring(2,3));
            var datum = "2019-09-11";
            //hozzunk létre 3 változót, ev,honap,nap néven, mindegyik
            //csak a megfelelő értéket tartalmazza
            var ev = datum.Substring(0,4);
            var honap = datum.Substring(5, 2);
            var nap = datum.Substring(8,2);
            Console.WriteLine($"Év:{ev},Hónap:{honap},Nap:{nap}");

            //karakteres típus
            Char karakter = 'q';

            if (Char.IsLetter(karakter))
            {
                Console.WriteLine("Ez betű");
            }

            Console.ReadKey();
        }
    }
}
