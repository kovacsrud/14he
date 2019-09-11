using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            //egész számok 16,32,64 bitesek
            //előjeles
            int a = 1;
            //előjel nélküli
            int b = 126;

            Int16 c = 445;
            short d = 442;
            long e = 224354656;

            //előjel nélküli
            UInt64 f = 55355666;

            byte g = 129;

            //Lehetséges értékek
            Console.WriteLine($"Min:{Int16.MinValue},Max:{Int16.MaxValue}");
            Console.WriteLine($"Min:{UInt16.MinValue},Max:{UInt16.MaxValue}");
            Console.WriteLine($"Min:{Int32.MinValue},Max:{Int32.MaxValue}");
            Console.WriteLine($"Min:{UInt32.MinValue},Max:{UInt32.MaxValue}");

            //deklarálás másképp
            var szam = 516;
            var szoveg = "Szöveges adat";

            //lebegőpontos (nem egész) számok
            //egyszeres pontosságú 32 bites
            float l1 = 16.196366366632663344926492f;
            //kétszeres pontosságú 64 bites
            double l2 = 16.196366366632663344926492;
            //decimális, 128 bites
            decimal l3 = 16.196366366632663344926492m;

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);

            String szov = "Szöveges adat";

            //Karakter
            Char karakter = 'q';

            //logikai
            bool logikai = true;

            //Minden más, ami nem érték típus, az referencia típus

            a = 10;
            b = a;
            a = 20;
            Console.WriteLine($"A:{a},B:{b}");

            //tömb
            int[] szamok = { 1, 2, 3, 4, 5 };
            int[] szamok2 = { 6, 7, 8, 9, 10 };

            szamok2[0] = 111;

            //Mennyi most a szamok tomb 0-ik elemének értéke?
            Console.WriteLine($"Szamok tömb első eleme:{szamok[0]}");



            Console.ReadKey();
        }
    }
}
