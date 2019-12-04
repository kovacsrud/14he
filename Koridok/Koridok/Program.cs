using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koridok
{
    class Program
    {
        public struct Korido
        {
            public string csapat;
            public string versenyzo;
            public int eletkor;
            public string palya;
            public string korido;
            public int koridomp;
            public int kor;
            public Korido(string sor)
            {
                var e = sor.Split(';');
                csapat = e[0];
                versenyzo = e[1];
                eletkor = Convert.ToInt32(e[2]);
                palya = e[3];
                korido = e[4];
                var k = e[4].Split(':');
                koridomp = (Convert.ToInt32(k[0]) * 3600) + (Convert.ToInt32(k[1]) * 60) + (Convert.ToInt32(k[2]));
                kor = Convert.ToInt32(e[5]);
            }
        }
        public static int OsszKorido(string korido)
        {
            var k = korido.Split(':');
            return ((Convert.ToInt32(k[0]) * 3600) + (Convert.ToInt32(k[1]) * 60) + (Convert.ToInt32(k[2])));
        }


        static void Main(string[] args)
        {
            List<Korido> koridok = new List<Korido>();

            try
            {
                var sorok = File.ReadAllLines(@"c:/ftproot/koridok/autoverseny.csv",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    koridok.Add(new Korido(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            Console.WriteLine($"Adatsorok száma:{koridok.Count}");

            var f4 = koridok.Find(x=>x.versenyzo.ToLower()=="Fürge Ferenc".ToLower() && x.palya=="Gran Prix Circuit" && x.kor==3);
            //Console.WriteLine($"Feladat 4: {f4}.másodperc");

            Console.WriteLine(OsszKorido(f4.korido));

            Console.Write("Kérem egy versenyző nevét:");
            var beNev = Console.ReadLine();

            var legjobbIdo = koridok.Find(x=>x.versenyzo==beNev && x.koridomp==koridok.Min(y=>y.koridomp));

            Console.WriteLine($"Feladat 5: Pálya {legjobbIdo.palya} idő:{legjobbIdo.koridomp}");



            Console.ReadKey();
        }
    }
}
