namespace ObjektumAlapok
{
    class Auto
    {
       

        public int GyartasEve { get; set; }
        public string Marka { get; set; }
        public string Rendszam { get; set; }
        public string Szin { get; set; }
        public string Tipus { get; set; }

        public Auto(int gyartasEve, string marka, string rendszam, string szin, string tipus)
        {
            GyartasEve = gyartasEve;
            Marka = marka;
            Rendszam = rendszam;
            Szin = szin;
            Tipus = tipus;
        }
    }
}