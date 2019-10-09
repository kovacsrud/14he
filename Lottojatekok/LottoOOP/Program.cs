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
            lotto.Jatek();
            var menet = 0;
            while (lotto.GetTalalat()!=5)
            {
                lotto.HosszuJatek();
                if (lotto.GetTalalat()>0)
                {
                    Console.WriteLine($"Találat:{lotto.GetTalalat()}");
                }
                Console.WriteLine(menet);
                menet++;
            }

            Console.WriteLine($"Ennyi évbe telt:{menet/52}");

            Console.ReadKey();
        }
    }
}
