using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak_Reload
{
    public class Kutyafajtak
    {
        public class Kutyafajta
        {
            public int Id { get; set; }
            public string Nev { get; set; }
            public string EredetiNev { get; set; }
        }

        List<Kutyafajta> kutyafajtak = new List<Kutyafajta>();

        public Kutyafajtak(string fajlnev)
        {
            try
            {
                var sorok = File.ReadAllLines(fajlnev, Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    kutyafajtak.Add(new Kutyafajta {
                        Id = Convert.ToInt32(e[0]),
                        Nev = e[1],
                        EredetiNev=e[2]
                    });

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public List<Kutyafajta> GetKutyafajtak()
        {
            return kutyafajtak;
        }
    }
}
