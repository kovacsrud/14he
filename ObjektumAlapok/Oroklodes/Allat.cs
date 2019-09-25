using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Allat
    {
        private int suly;

        public Allat()
        {
            Console.WriteLine("Ez az állat konstruktora");
        }

        public int getSuly()
        {
            return suly;
        }

        public void setSuly(int suly)
        {
            this.suly = suly;

        }

        public virtual void Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        public void Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }

        public virtual void Mozog()
        {
            Console.WriteLine("Az állat mozog");
        }

    }
}
