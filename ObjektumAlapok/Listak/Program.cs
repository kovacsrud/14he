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


            Console.ReadKey();
        }
    }
}
