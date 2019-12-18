using System;

namespace SerializeDeserialize
{
    public class Szemely
    {
        

        public string Keresztnev { get; set; }
        public int SzuletesEve { get; set; }
        public string SzuletesiHely { get; set; }
        public string Vezeteknev { get; set; }

        public Szemely()
        { }

        public Szemely(string sor)
        {
            var e=sor.Split(',');
            Vezeteknev = e[0];
            Keresztnev = e[1];
            SzuletesEve = Convert.ToInt32(e[2]);
            SzuletesiHely = e[3];
            
        }

    }
}