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
        static void Main(string[] args)
        {
        

            try
            {
                FileStream file = new FileStream(@"d:/rud/tesztadat_20k.txt", FileMode.Open);


                //használat után felszabadítja az erőforrást
                using (StreamReader sr = new StreamReader(file, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
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
