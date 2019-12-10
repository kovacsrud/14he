using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf3szogek
{
    public class HaromszogHiba:Exception
    {
        public HaromszogHiba(string uzenet) : base(uzenet)
        {

        }
    }
}
