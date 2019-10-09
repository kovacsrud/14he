using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottojatekok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Szükséges változók
            Console.Write("Hány számot húzunk?:");
            var szamDb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hány számból húzunk?:");
            var osszSzam = Convert.ToInt32(Console.ReadLine());

            var tippek = new int[szamDb];
            var nyeroSzamok = new int[szamDb];
            var talalatok = 0;
            Random rand = new Random();

            //Bekérés
            for (int i = 0; i < szamDb; i++)
            {   //Beolvasunk egy tippet
                Console.Write($"{i + 1}.tipp:");
                var temp = Convert.ToInt32(Console.ReadLine());
                //Amíg a tipp nem jó, újra be kell kérni
                while (temp < 1 || temp > osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Hibás! {i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;

            }
            //sorsolás
            for (int i = 0; i < szamDb; i++)
            {
                var temp = rand.Next(1, osszSzam + 1);
                //Amíg a nyerőszám nem jó, újra be kell generálni
                while (nyeroSzamok.Contains(temp))
                {

                    temp = rand.Next(1, osszSzam + 1);
                }
                nyeroSzamok[i] = temp;
            }

            TombLista(tippek);
            TombLista(nyeroSzamok);

            //Találatok meghatározása
            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalatok++;
                }
            }

            Console.WriteLine($"Találatok száma:{talalatok}");

            Console.ReadKey();
        }

        private static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
