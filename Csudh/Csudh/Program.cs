using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csudh
{
    class Program
    {
        public struct Domain
        {
            public string domain;
            public string ipaddress;

            public Domain(string sor)
            {
                var e = sor.Split(';');
                domain = e[0];
                ipaddress = e[1];
            }

        }

        public static string DomainSzint(string d,int szint)
        {
            var e = d.Split('.');
            if (szint<=e.Length)
            {
                return e[szint - 1];

            } else
            {
                return "nincs";
            }

        }

        static void Main(string[] args)
        {
            List<Domain> domainek = new List<Domain>();

            try
            {
                var sorok = File.ReadAllLines(@"c:/ftproot/csudh/csudh.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    domainek.Add(new Domain(sorok[i]));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            string htmlOut = "";
            htmlOut += "<HTML>";
            htmlOut += "<HEAD>";
            htmlOut += "<TITLE>";
            htmlOut += "Domainek";
            htmlOut += "</TITLE>";
            htmlOut += "</HEAD>";
            htmlOut += "<BODY>";
            htmlOut += "<TABLE>";
            htmlOut += "<TR>";
            htmlOut += "<TD>Ssz</TD>";
            htmlOut += "<TD>Host domainneve</TD>";
            htmlOut += "<TD>Host Ip címe</TD>";
            htmlOut += "<TD>1. szint</TD>";
            htmlOut += "<TD>2. szint</TD>";
            htmlOut += "<TD>3. szint</TD>";
            htmlOut += "<TD>4. szint</TD>";
            htmlOut += "<TD>5. szint</TD>";
            htmlOut += "</TR>";

            var sorszam = 1;
            foreach (var d in domainek)
            {
                htmlOut += "<TR>";
                htmlOut += $"<TD>{sorszam++}</TD>";
                htmlOut += $"<TD>{d.domain}</TD>";
                htmlOut += $"<TD>{d.ipaddress}</TD>";
                for (int i = 0; i < 5; i++)
                {
                    htmlOut += $"<TD>{DomainSzint(d.domain,i+1)}</TD>";
                }
                htmlOut += "</TR>";
            }
            htmlOut += "</TABLE>";
            htmlOut += "</BODY>";
            htmlOut += "</HTML>";

            try
            {
                File.WriteAllText(@"table.html", htmlOut);
                Console.WriteLine("Kiírás kész");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.WriteLine($"Adatok száma:{domainek.Count}");
            Console.ReadKey();
        }
    }
}

