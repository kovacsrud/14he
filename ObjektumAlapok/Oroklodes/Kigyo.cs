using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Kigyo:Allat
    {
        private bool merges;
        private int hossz;
        private int vastagsag;

        public Kigyo()
        {
            Console.WriteLine("A kígyó konstruktora");
        }

        public void Folytas()
        {
            Console.WriteLine("A kígyó megfolytja a zsákmányt");
        }

        public override void Eszik()
        {
            Console.WriteLine("Egészben lenyeli a táplálékot");
        }

        public override void Mozog()
        {
            Console.WriteLine("Csúszik a hasán");
        }
    }
}
