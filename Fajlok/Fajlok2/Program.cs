using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlok2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sorok = File.ReadAllLines(@"d:/rud/tesztadat_20k.txt",Encoding.Default);

                //for (int i = 0; i < sorok.Length; i++)
                //{
                //    Console.WriteLine(sorok[i]);
                //}
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                
            }


            if (File.Exists(@"d:/rud/tesztadat_200k.txt"))
            {
                var sorok = File.ReadAllLines(@"d:/rud/tesztadat_20k.txt", Encoding.Default);
            }else
            {
                Console.WriteLine("A fájl nem létezik!");
            }


            Console.ReadKey();
        }
    }
}
