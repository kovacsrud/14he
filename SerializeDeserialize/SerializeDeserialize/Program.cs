using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szemely> szemelyek = new List<Szemely>();

            try
            {
                var sorok = File.ReadAllLines(@"tesztadat_20k.txt",Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    szemelyek.Add(new Szemely(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine(szemelyek.Count);

            //Szerializáció:egy adott objektum fájlba írása
            //Leggyakrabban XML, vagy JSON formátumba történik
            //a szerializálás

            var xmlFajl = "szemelyek.xml";

            var serializer = new XmlSerializer(typeof(List<Szemely>));

            using (var fs=new FileStream(xmlFajl,FileMode.Create))
            {
                serializer.Serialize(fs, szemelyek);
            }

            List<Szemely> betolt;

            using (var fs=new FileStream(xmlFajl,FileMode.Open))
            {
                betolt = (List<Szemely>)serializer.Deserialize(fs);
            }

            Console.WriteLine($"A visszatöltött adatok sorai:{betolt.Count}");
            Console.WriteLine($"Első sor:{betolt[0].Vezeteknev},{betolt[0].Keresztnev}");

            //Szerializálás JSON formátumba

            var jsonSerializer = new JsonSerializer();
            var jsonFajl = new JsonTextWriter(new StreamWriter(@"szemelyek.json"));

            jsonSerializer.Serialize(jsonFajl, szemelyek);
            jsonFajl.Close();

            JsonReader jsonBetolt = new JsonTextReader(new StreamReader(@"szemelyek.json"));

            List<Szemely> jsonVissza = jsonSerializer.Deserialize<List<Szemely>>(jsonBetolt);

            jsonBetolt.Close();

            Console.WriteLine(jsonVissza.Count);

            Console.ReadKey();
        }
    }
}
