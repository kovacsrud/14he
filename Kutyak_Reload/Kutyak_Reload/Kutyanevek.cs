using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak_Reload
{
    public class Kutyanevek
    {
        public class Kutyanev
        {
            public int Id { get; set; }
            public string Kutyaneve { get; set; }
        }

        private List<Kutyanev> kutyanevek = new List<Kutyanev>();

        

        public Kutyanevek(string fajlnev)
        {
            try
            {
                var sorok = File.ReadAllLines(fajlnev, Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    kutyanevek.Add(new Kutyanev { Id = Convert.ToInt32(e[0]), Kutyaneve = e[1] });
                    Debug.WriteLine(kutyanevek.Count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }

        public List<Kutyanev> GetKutyanevek()
        {
            return kutyanevek;
        }

    }
}
