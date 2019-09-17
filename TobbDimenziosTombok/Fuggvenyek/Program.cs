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


            Console.ReadKey();
        }
    }
}
