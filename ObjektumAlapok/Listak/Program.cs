using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ember> emberek = new List<Ember>();

            Ember ember = new Ember
            {
                Nev="Kiss Elek",
                Magassag=178,
                Eletkor=49
            };
            emberek.Add(ember);

            Ember ember2 = new Ember
            {
                Nev = "Muhari Géza",
                Magassag = 199,
                Eletkor = 26
            };

            emberek.Add(ember2);

            Ember ember3 = new Ember
            {
                Nev = "Nagyváradi Jenő",
                Magassag = 169,
                Eletkor = 34
            };

            emberek.Add(ember3);
            
            Console.WriteLine(emberek.Count);

            for (int i = 0; i < emberek.Count; i++)
            {
                Console.WriteLine($"{emberek[i].Nev},{emberek[i].Magassag},{emberek[i].Eletkor}");
            }

            //nem lehet benne módosítani, nem kell az elemszámmal törődni
            foreach (Ember e in emberek)
            {
                Console.WriteLine($"{e.Nev},{e.Magassag},{e.Eletkor}");
            }
            //Kiss vezetéknevűek egy külön listába?

            //Linq
            var kissek = emberek.FindAll(x=>x.Nev.StartsWith("Kiss") && x.Eletkor>30);

            foreach (var k in kissek)
            {
                Console.WriteLine($"{k.Nev},{k.Magassag},{k.Eletkor}");
            }

            emberek.Clear();

            Console.ReadKey();
        }
    }
}
