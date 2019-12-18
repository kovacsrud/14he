using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonErtelmezes
{
    class Program
    {
        static void Main(string[] args)
        {

            String jsonFajl="";
            try
            {
                jsonFajl = File.ReadAllText(@"colors.json", Encoding.Default);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }

            Console.WriteLine(jsonFajl);

            JsonTextReader reader = new JsonTextReader(new StringReader(jsonFajl));

            while (reader.Read())
            {
                //Console.WriteLine($"{reader.TokenType},{reader.ValueType},{reader.Value}");
            }


            JObject colors = JObject.Parse(jsonFajl);

            var jsColors = colors.SelectToken("colors");

            Console.WriteLine(colors["colors"][0]["color"]);
            Console.WriteLine(colors["colors"][1]["code"]);


            Console.WriteLine(jsColors[0]["color"]);
            Console.WriteLine(jsColors[0]["code"]["rgba"][3]);
            Console.WriteLine(jsColors[5]["color"]);

            //rekurzív bejárás
            var codes = colors.SelectTokens("$..code");
            
            Console.WriteLine(codes.Count());

            

            Console.ReadKey();
        }
    }
}
