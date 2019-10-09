using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //A könnyű implementálhatósághoz
            //az kell, hogy innen csak 1-2
            //metódust kelljen hívni
            LottoGame lotto = new LottoGame(5, 90);
            lotto.Tippeles();


            Console.ReadKey();
        }
    }
}
