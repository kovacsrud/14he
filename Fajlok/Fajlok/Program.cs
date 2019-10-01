using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlok
{
    class Program
    {
        struct Ember
        {
            public string vezeteknev;
            public string keresztnev;
            public int szulev;
            public string szulhely;
        }

        static void Main(string[] args)
        {
            //A struktúra érték típus
            Ember ember = new Ember();
            List<Ember> emberek =new List<Ember>();

                   

            try
            {
                FileStream file = new FileStream(@"d:/rud/tesztadat_20k.txt", FileMode.Open);


                //használat után felszabadítja az erőforrást
                using (StreamReader sr = new StreamReader(file, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        //feldolgozás
                        var elemek = sr.ReadLine().Split(',');
                        ember.vezeteknev = elemek[0];
                        ember.keresztnev = elemek[1];
                        ember.szulev = Convert.ToInt32(elemek[2]);
                        ember.szulhely = elemek[3];

                        emberek.Add(ember);

                    }
                }                             
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                                
            }


            Console.WriteLine(emberek.Count);

            var hetven = emberek.FindAll(x=>x.szulev==1970);

            Console.WriteLine(hetven.Count);

            //foreach (var h in hetven)
            //{
            //    Console.WriteLine($"{h.vezeteknev},{h.keresztnev},{h.szulev},{h.szulhely}");
            //}
            //k-val kezdődő vezetéknevű emberek
            var kkezd = emberek.FindAll(x=>x.vezeteknev.ToLower().StartsWith("k"));

            //Console.WriteLine($"K-val kezdődő vezetéknevek:{kkezd}.db");

            //Készítsen összesítést, ami megadja, hogy az egyes helyiségekben
            //hányan születtek!
            var helyisegek = emberek.ToLookup(x=>x.szulhely).OrderBy(x=>x.Count());

            //foreach (var h in helyisegek)
            //{
            //    Console.WriteLine($"{h.Key},{h.Count()}");
            //}

            //születési év és hely szerinti összesítés
            var szhelyev = emberek.ToLookup(x=>new {x.szulhely,x.szulev }).OrderBy(x=>x.Key.szulhely).ThenBy(x=>x.Key.szulev);

            foreach (var s in szhelyev)
            {
                Console.WriteLine($"{s.Key.szulhely},{s.Key.szulev},{s.Count()}");
            }


            try
            {
                FileStream outFajl = new FileStream(@"d:/kkezd.txt",FileMode.Create);
                using (StreamWriter sw = new StreamWriter(outFajl, Encoding.Default))
                {
                    foreach (var k in kkezd)
                    {
                        sw.WriteLine($"{k.vezeteknev},{k.keresztnev},{k.szulev},{k.szulhely}");
                    }
                }                
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }


            Console.ReadKey();
        }
    }
}
