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


            //foreach (var i in kutyaFajtak)
            //{
            //    Console.WriteLine($"{i.Id},{i.Nev},{i.EredetiNev}");
            //}

            Console.ReadKey();
        }
    }
}
