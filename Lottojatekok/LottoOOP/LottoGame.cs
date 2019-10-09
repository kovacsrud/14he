using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    public class LottoGame
    {
        private int szamDb;
        private int osszSzam;
        private int talalatok;
        private int[] tippek;
        private int[] nyeroSzamok;
        Random rand = new Random();

        public LottoGame(int szamdb,int osszszam)
        {
            szamDb = szamdb;
            osszSzam = osszszam;
            tippek = new int[szamdb];
            nyeroSzamok = new int[szamDb];
            talalatok = 0;

        }

        public void Jatek()
        {
            talalatok = 0;
            Tippeles();
            Sorsolas();
            TalalatSzam();
            TippLista();
            NyeroszamLista();
            Console.WriteLine($"Találatok száma:{GetTalalat()}");
        }

        public void HosszuJatek()
        {
            talalatok = 0;
            
            Sorsolas();
            TalalatSzam();
            
        }

        public void Tippeles()
        {
            for (int i = 0; i < szamDb; i++)
            {   //Beolvasunk egy tippet
                Console.Write($"{i + 1}.tipp:");
                var temp = Convert.ToInt32(Console.ReadLine());
                //Amíg a tipp nem jó, újra be kell kérni
                while (temp < 1 || temp > osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Hibás! {i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;

            }
        }

        public void Sorsolas()
        {
            for (int i = 0; i < szamDb; i++)
            {
                var temp = rand.Next(1, osszSzam + 1);
                //Amíg a nyerőszám nem jó, újra be kell generálni
                while (nyeroSzamok.Contains(temp))
                {

                    temp = rand.Next(1, osszSzam + 1);
                }
                nyeroSzamok[i] = temp;
            }
        }

        private void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
            }
            Console.WriteLine();
        }

        public void TippLista()
        {
            TombLista(tippek);
        }

        public void NyeroszamLista()
        {
            TombLista(nyeroSzamok);
        }

        public int GetTalalat()
        {
            return talalatok;
        }

        public void TalalatSzam()
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalatok++;
                }
            }
        }


    }
}
