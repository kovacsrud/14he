using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IArlap> pekseg=new List<IArlap>();
            try
            {
                var sorok = File.ReadAllLines(@"peksegadatok.txt");
                for (int i = 0; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(' ');
                    if (e[0].ToLower()=="pogacsa".ToLower())
                    {
                        Pogacsa pogacsa = new Pogacsa(Convert.ToDouble(e[1]), Convert.ToDouble(e[2]));
                        pekseg.Add(pogacsa);
                    } else
                    {
                        if (e[1].ToLower()=="habos".ToLower())
                        {
                            Kave kave = new Kave(true);
                            pekseg.Add(kave);
                        } else
                        {
                            Kave kave = new Kave(false);
                            pekseg.Add(kave);
                        }
                    }
                }

                Console.WriteLine("Betöltés vége");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }

            Console.WriteLine(pekseg.Count);

            foreach (var i in pekseg)
            {
                if (i.GetType()==typeof(Pogacsa))
                {
                    Pogacsa p = (Pogacsa)i;
                    Console.WriteLine($"{p.getMennyiseg()},{p.getAlapar()}");
                }
                if (i.GetType()==typeof(Kave))
                {
                    Kave k = (Kave)i;
                    Console.WriteLine($"{k.mennyibeKerul()}");
                }
                
                
            }
     


            Console.ReadKey();
        }
    }
}
