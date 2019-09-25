using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Az Allat osztály most absztrakt, nem példányosítható
            //Allat allat = new Allat();
            Kutya kutya = new Kutya();
            kutya.Eszik();
            kutya.Iszik();
            kutya.Vadaszik();
            kutya.Eszik("hús");


            Console.ReadKey();
        }
    }
}
