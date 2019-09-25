using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat allat = new Allat();
            allat.setSuly(16);
            allat.Eszik();
            allat.Iszik();
            allat.Mozog();

            Kigyo kigyo = new Kigyo();
            kigyo.setSuly(8);
            Console.WriteLine(kigyo.getSuly());
            kigyo.Iszik();
            kigyo.Eszik();
            kigyo.Mozog();
            kigyo.Folytas();

            Kutya kutya = new Kutya();

            kutya.Iszik();
            kutya.Mozog();
            kutya.Eszik();
            kutya.Ugat();
           



            Console.ReadKey();
        }
    }
}
