using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Munkagep> munkagepek = new List<Munkagep>();
            List<SzemelySzallito> szemelyszallitok = new List<SzemelySzallito>();

            Munkagep mg1 = new Munkagep
            {
                Eroforras = "diesel",
                AlkalmazasiTerulet = "markoló",
                Hossz = 10,
                Tomeg = 3000,
                KozforgalombanResztvehet = true,
                MaxSebesseg=25,
                Teljesitmeny=300

            };

            Munkagep mg2 = new Munkagep
            {
                Eroforras = "diesel",
                AlkalmazasiTerulet = "hóeke",
                Hossz = 15,
                Tomeg = 4000,
                KozforgalombanResztvehet = true,
                MaxSebesseg = 60,
                Teljesitmeny = 400

            };
            munkagepek.Add(mg1);
            munkagepek.Add(mg2);

            SzemelySzallito sz1 = new SzemelySzallito
            {
                Alvazszam="TB33556666",
                Motorszam="ZX115656",
                Eroforras="benzin",
                Hossz=4,
                Teljesitmeny=70,
                Tomeg=1100,
                MaxSebesseg=160,
                SzallithatoSzemelyek=4
            };

            SzemelySzallito sz2 = new SzemelySzallito
            {
                Alvazszam = "TC37786666",
                Motorszam = "AYS15775656",
                Eroforras = "diesel",
                Hossz = 5,
                Teljesitmeny = 85,
                Tomeg = 1200,
                MaxSebesseg = 170,
                SzallithatoSzemelyek = 6
            };

            szemelyszallitok.Add(sz1);
            szemelyszallitok.Add(sz2);

            var munkagepLekerdezes = munkagepek.FindAll(x=>x.KozforgalombanResztvehet==true && x.MaxSebesseg>40);

            var autoLekerdezes = szemelyszallitok.FindAll(x=>x.SzallithatoSzemelyek>4);

            foreach (var m in munkagepLekerdezes)
            {
                Console.WriteLine($"{m.AlkalmazasiTerulet},{m.Eroforras},{m.KozforgalombanResztvehet},{m.MaxSebesseg}");
            }

            foreach (var a in autoLekerdezes)
            {
                Console.WriteLine($"{a.Eroforras},{a.Alvazszam},{a.SzallithatoSzemelyek},{a.Teljesitmeny}");
            }

            Console.ReadKey();
        }
    }
}
