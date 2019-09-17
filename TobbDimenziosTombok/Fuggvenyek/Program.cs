using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        //függvény overloading
        private static void Kiir()
        {
            Console.WriteLine("_default");
        }

        private static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        private static void Kiir(string s1,string s2)
        {
            Console.WriteLine(s1+" "+s2);
        }

        private static int Osszead(int a,int b)
        {
            return a + b;
        }

        private static double Osszead(double a,double b)
        {
            return a + b;
        }

        public static double Hatvany(double szam,double kitevo)
        {
            return Math.Pow(szam, kitevo);
        }

        public static int Hatvany(int szam, int kitevo)
        {
            //cast-olás más néven típuskényszerítés
            return (int)Math.Pow(szam, kitevo);
        }
       
        //írjunk függvényt, amely létrehoz egy megadott elemszámú tömböt,
        //feltölti értékekkel, és ezt visszaadja
        //írjunk függvényt, amely a paraméterként átadott tömböt elemeit kiírja
        public static int[] TombKeszit(int elemSzam,int min,int max)
        {
            Random rand = new Random();
            int[] tomb = new int[elemSzam];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rand.Next(min, max + 1);
            }
            return tomb;
        }

        public static void TombLista(int[] tomb)
        {
            for (int i = 0; i <tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
            }
        }

        public static void Negyzet(ref int a)
        {
            a = a * a;
        }

        static void Main(string[] args)
        {
            
            Kiir();
            Kiir("Szöveg átadása");
            Kiir("Szöveg", "összefűzése");
            //visszatérési értékkel rendelkező függvény hívása
            var a = Osszead(10, 45);
            Console.WriteLine(a);
            Console.WriteLine(Osszead(22,69));
            var b = Osszead(15.67, 49.445);
            Console.WriteLine(b);
            //Készítsünk függvényt, amely hatványoz, azaz a megadott számot az
            //adott hatványra emeli
            Console.WriteLine(Hatvany(2.2,10));
            Console.WriteLine(Hatvany(2, 11));
            var tomb1=TombKeszit(20, -10, 20);
            TombLista(tomb1);
            var tomb2 = TombKeszit(40, -9, 33);
            TombLista(tomb2);
            Console.WriteLine();
            var n = 3;
            Negyzet(ref n);
            //?n
            var z = 11;
            var x = 22;
            //írjunk függvényt, amelyik megcseréli z és x értékét

            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
