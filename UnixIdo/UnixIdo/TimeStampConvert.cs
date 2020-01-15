using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixIdo
{
    public static class TimeStampConvert
    {
        const Int32 ora = 3600;
        const Int32 nap = 86400;
        const Int32 normalEv = 365 * nap;
        const Int32 szokoEv = 366 * nap;
        const Int32 atlagEv = 31556926;
        static int[] normalHonap = {31,28,31,30,31,30,31,31,30,31,30,31 };
        static int[] szokoHonap = { 31,29,31,30,31,30,31,31,30,31,30,31 };
        static int aktHonap = 0;

        public static string Convert(int ts)
        {
            var teljesIdo = ts;
            var evek = ts / atlagEv;

            for (int i = 0; i < evek; i++)
            {
                if ((((1970 + i) % 4 == 0) || ((1970 + i) % 400 == 0)) && ((1970 + i) % 100 != 0))
                {
                    teljesIdo -= szokoEv;
                } else
                {
                    teljesIdo -= normalEv;
                }
            }

            if (1970 + evek % 4 == 0 && 1970 + evek % 100 != 0 || 1970 + evek % 400 == 0)
            {
                for (int i = 0; i < szokoHonap.Length; i++)
                {
                    if (teljesIdo>=szokoHonap[i]*nap)
                    {
                        teljesIdo -= szokoHonap[i] * nap;

                    } else
                    {
                        aktHonap = i;
                        break;
                    }
                }

            } else
            {
                for (int i = 0; i < normalHonap.Length; i++)
                {
                    if (teljesIdo >= normalHonap[i] * nap)
                    {
                        teljesIdo -= normalHonap[i] * nap;

                    }
                    else
                    {
                        aktHonap = i;
                        break;
                    }
                }
            }

            aktHonap += 1;
            Console.WriteLine(teljesIdo);
            int aktNap = teljesIdo / nap;
            int aktOra = (teljesIdo % nap) / ora;
            int aktPerc = ((teljesIdo % nap) % ora) / 60;
            int aktMasodPerc = ((teljesIdo % nap) % ora) % 60;

            return $"{1970+evek}-{aktHonap}-{aktNap} {aktOra}:{aktPerc}:{aktMasodPerc}";

        }


    }
}
