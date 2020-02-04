using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak_Reload
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutyanevek kutyanevek = new Kutyanevek(@"KutyaNevek.csv");
            var kutyaNevek = kutyanevek.GetKutyanevek();
            Kutyafajtak kutyafajtak = new Kutyafajtak(@"KutyaFajtak.csv");
            var kutyaFajtak = kutyafajtak.GetKutyafajtak();
            Kutyak Kutyak = new Kutyak(@"kutyak.csv");
            var kutyak = Kutyak.GetKutyak();

            var atlageletkor = kutyak.Average(x => x.Eletkor);
            Console.WriteLine($"A kutyák átlag életkora:{atlageletkor:0.00}");

            var nevvel = kutyak.Join(kutyaNevek,
                k => k.NevId,
                kn => kn.Id,
                (k, kn) => new {Id=k.Id,
                                FajtaId =k.FajtaId,
                                Kutyanev =kn.Kutyaneve,
                                Eletkor =k.Eletkor,
                                UtolsoEllenorzes =k.UtolsoEllenorzes }
                );

            

            var teljes = nevvel.Join(kutyaFajtak,
                n=>n.FajtaId,
                kf=>kf.Id,
                (n, kf) => new {Id=n.Id,
                                Kutyanev =n.Kutyanev,
                                Fajta =kf.Nev,
                                Eletkor =n.Eletkor,
                                UtolsoEllenorzes=n.UtolsoEllenorzes}
                );


            //foreach (var i in teljes)
            //{
            //    Console.WriteLine($"{i.Id},{i.Fajta},{i.Eletkor},{i.Kutyanev},{i.UtolsoEllenorzes}");
            //}
            var legidosebb = teljes.Where(x=>x.Eletkor==teljes.Max(y=>y.Eletkor));

            Console.WriteLine($"A legidősebb kutya: {legidosebb.First().Eletkor},{legidosebb.First().Fajta},{legidosebb.First().Kutyanev}");

            var adottnap = teljes.Where(x => x.UtolsoEllenorzes == "2018.01.10");

            
            var jan18 = adottnap.ToLookup(x=>x.Fajta);

            foreach (var i in jan18)
            {
                Console.WriteLine($"{i.Key},{i.Count()}.db");
            }

            Console.ReadKey();
        }
    }
}
