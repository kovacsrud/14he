using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfIdojaras
{
    public class IdojarasAdatok
    {
        private List<IdojarasAdat> idojarasadatok;
        private string filePath;

        public IdojarasAdatok(string filepath)
        {
            idojarasadatok = new List<IdojarasAdat>();
            filePath = filepath;
            fileLoad();
        }

        private void fileLoad()
        {
            try
            {
                var sorok = File.ReadAllLines(filePath, Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    idojarasadatok.Add(new IdojarasAdat(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
        }

        public int getLength()
        {
            return idojarasadatok.Count;
        }

        public List<int> Evek()
        {
            List<int> evek = new List<int>();

            var evekegyszer = idojarasadatok.ToLookup(x => x.Ev).OrderBy(x=>x.Key);
            foreach (var e in evekegyszer)
            {
                evek.Add(e.Key);
            }

            return evek;
        }
        public List<int> Honapok(int ev)
        {
            List<int> honapok = new List<int>();
            var honapokegyszer = idojarasadatok.Where(x => x.Ev == ev).ToLookup(x => x.Honap).OrderBy(x => x.Key);

            foreach (var h in honapokegyszer)
            {
                honapok.Add(h.Key);
            }
            return honapok;
        }

        public List<int> Napok(int ev,int honap)
        {
            List<int> napok = new List<int>();
            var napokegyszer = idojarasadatok.Where(x => x.Ev == ev && x.Honap == honap).ToLookup(x => x.Nap).OrderBy(x => x.Key);

            foreach (var n in napokegyszer)
            {
                napok.Add(n.Key);
            }
            return napok;
        }

        public List<IdojarasAdat> getRacsAdatok(int ev)
        {
            var result = idojarasadatok.FindAll(x => x.Ev == ev);

            return result;
        }

        public List<IdojarasAdat> getRacsAdatok(int ev,int honap)
        {
            var result = idojarasadatok.FindAll(x => x.Ev == ev && x.Honap==honap);

            return result;
        }

        public List<IdojarasAdat> getRacsAdatok(int ev, int honap,int nap)
        {
            var result = idojarasadatok.FindAll(x => x.Ev == ev && x.Honap == honap && x.Nap==nap);

            return result;
        }
    }
}
