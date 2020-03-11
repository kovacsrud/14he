using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasarlasok
{
    class Program
    {
        public static int Ertek(int darabszam)
        {
            var kezdoFizetendo = 500;
            int fizetendo = 0;

            for (int i = 0; i < darabszam; i++)
            {
                fizetendo += kezdoFizetendo;

                if (kezdoFizetendo>400)
                {
                    kezdoFizetendo -= 50;
                }
                
              
            }

            return fizetendo;
        }

        static void Main(string[] args)
        {
            List<Vasarlas> vasarlasok = new List<Vasarlas>();
            var sorSzam = 1;
            try
            {
                var sorok = File.ReadAllLines(@"penztar.txt",Encoding.Default);
                
                for (int i = 0; i < sorok.Length; i++)
                {
                    if (sorok[i]!="F")
                    {
                        vasarlasok.Add(new Vasarlas(sorSzam, sorok[i]));
                    } else
                    {
                        sorSzam++;
                    }
                    

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }



            Console.WriteLine($"Feladat 2: {sorSzam} alkalommal vásároltak.");
            //Console.WriteLine(vasarlasok.Count);
            var elsoDb = vasarlasok.FindAll(x=>x.Sorszam==1).Count;
            Console.WriteLine($"Az első vásárló kosarában {elsoDb} termék volt.");

            Console.Write("Adja meg egy vásárlás sorszámát:");
            var vasarlasSorszam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg egy árucikk nevét:");
            var aruCikk = Console.ReadLine();

            Console.Write("Adja meg egy darabszámot:");
            var darabSzam = Convert.ToInt32(Console.ReadLine());

            var aruCikkLista = vasarlasok.FindAll(x=>x.Aru.ToLower()==aruCikk.ToLower());
            Console.WriteLine($"{aruCikk} áruból összesen {aruCikkLista.Count} alkalommal vásároltak.");
            Console.WriteLine($"Első vásárlás:{aruCikkLista.First().Sorszam}");
            Console.WriteLine($"Utolsó vásárlás:{aruCikkLista.Last().Sorszam}");

            Console.WriteLine($"A bekért darabszám értéke:{Ertek(darabSzam)}");

            var vasarlasDarabszam = vasarlasok.FindAll(x => x.Sorszam == vasarlasSorszam).ToLookup(x=>x.Aru);

            foreach (var i in vasarlasDarabszam)
            {
                Console.WriteLine($"{i.Key},{i.Count()}");
            }

            var fizetendok = vasarlasok.ToLookup(x=>new {x.Sorszam,x.Aru});

            foreach (var i in fizetendok)
            {
                Console.WriteLine($"{i.Key.Sorszam},{i.Key.Aru},{Ertek(i.Count())}");
            }

            Console.ReadKey();
        }
    }
}
