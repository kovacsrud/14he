﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak_Reload
{
    public class Kutyak
    {
        public class Kutya
        {
            public int Id { get; set; }
            public int FajtaId { get; set; }
            public int NevId { get; set; }
            public int Eletkor { get; set; }
            public string UtolsoEllenorzes { get; set; }
        }

        List<Kutya> kutyak = new List<Kutya>();

        public Kutyak(string fajlnev)
        {
            try
            {
                var sorok = File.ReadAllLines(fajlnev, Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    kutyak.Add(new Kutya {
                        Id=Convert.ToInt32(e[0]),
                        FajtaId=Convert.ToInt32(e[1]),
                        NevId=Convert.ToInt32(e[2]),
                        Eletkor=Convert.ToInt32(e[3]),
                        UtolsoEllenorzes=e[4]
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<Kutya> GetKutyak()
        {
            return kutyak;
        }
    }
}
