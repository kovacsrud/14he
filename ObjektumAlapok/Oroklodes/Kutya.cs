using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Kutya:Allat
    {
        private string fajta;
        private bool hosszuszoru;

        public Kutya()
        {
            Console.WriteLine("A kutya konstruktora");
        }

        public void Ugat()
        {
            Console.WriteLine("A kutya ugat");
        }

        public override void Eszik()
        {
            Console.WriteLine("Habzsolja a kutyatápot");
        }
        public override void Mozog()
        {
            Console.WriteLine("Négy lábon mozog");
        }

    }
}
