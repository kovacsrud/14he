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

            //Feladat: egy string karaktereit alakítsuk nagybetűsre,
            //ha kisbetűs és fordítva.

            string fordit = "Ezt A SzövegeT HaSznáJuk";
            char[] forditCh = fordit.ToCharArray();
            //Egy lépésben is lehet karaktertömbbé alakítani egy Stringet
            var fordit2 = "Szöveg".ToCharArray();

            for (int i = 0; i < forditCh.Length; i++)
            {
                if (Char.IsLower(forditCh[i]))
                {
                    forditCh[i] = Char.ToUpper(forditCh[i]);
                }
                else
                {
                    forditCh[i] = Char.ToLower(forditCh[i]);
                }
            }

            //A karaktertömböt szöveggé kell alakítani
            fordit = new string(forditCh);

            //Írjunk programot, amely megállapítja egy String-ben
            //lévő számjegyek összegét. Ha esetleg a szöveg nem
            //tartalmaz számjegyeket, akkor írja ki, hogy a szövegben 
            //nincsenek számjegyek

            String sz = "Valami 45 szöveg 1926";
            var osszeg = 0;
            char[] szCh = sz.ToCharArray();

            for (int i = 0; i < szCh.Length; i++)
            {
                if (Char.IsDigit(szCh[i]))
                {
                    //int-re kényszerítés cast-olással(típuskényszerítés)
                    osszeg = osszeg + (int)Char.GetNumericValue(szCh[i]);
                }
            }

            Console.WriteLine(osszeg);

            Console.WriteLine(fordit);

            Console.ReadKey();
        }
    }
}
