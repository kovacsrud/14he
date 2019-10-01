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
            FileStream file = null;
            StreamReader sr = null;

            try
            {
                file = new FileStream(@"d:/rud/tesztadat_20k.txt", FileMode.Open);
                sr = new StreamReader(file,Encoding.Default);

                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                                
            }
            finally
            {
                //minden esetben végre fog hajtódni, ami itt van
                sr.Close();
            }



            Console.ReadKey();
        }
    }
}
