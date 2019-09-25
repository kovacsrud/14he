using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    class Kutya : Allat
    {
        public override void Eszik()
        {
            Console.WriteLine("A kutya eszik");
        }

        public void Eszik(string mit)
        {
            Console.WriteLine($"A kutya eszik:{mit}");
        }

        public override void Iszik()
        {
            Console.WriteLine("A kutya iszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A kutya mozog");
        }

        public void Vadaszik()
        {
            Console.WriteLine("A kutya vadászik");
        }
    }
}
