using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentException();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //Minden kivételt elkap
                Console.WriteLine(ex.Message);

            }



            Console.ReadKey();
        }
    }
}
