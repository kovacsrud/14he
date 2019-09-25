using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Az osztályt példányosítani kell
            Ember ubul = new Ember("Ubul",1999,79,178);
            Ember zeno = new Ember("Zénó", 1997, 56, 169);

            Console.WriteLine(ubul.getMagassag());
            ubul.Noveszt(150);
         

            Console.WriteLine(ubul.getNev());
            Console.WriteLine(ubul.getMagassag());

            //property-t tartalmazó osztály
            //példányosítása a kezdeti értékek megadásával

            JobbEmber eva = new JobbEmber("Éva",169,56,1998);

            JobbEmber judit = new JobbEmber("Judit", 1969, 76, 122);
            
            
            Console.WriteLine(eva.Nev);
            Console.WriteLine(eva.Magassag);
            Console.WriteLine(judit.Nev);
            Console.WriteLine(judit.Magassag);
            judit.Magassag = 212;
            Console.WriteLine(judit.Magassag);

            //Auto auto = new Auto{
            //    Rendszam="abc-001",
            //    Marka="Skoda",
            //    Tipus="Fabia",
            //    Szin="zöld",
            //    GyartasEve=2006

            //};
            Auto auto = new Auto(2006, "Skoda", "abc-001", "kék", "Fabia");


            Console.ReadKey();

        }
    }
}
