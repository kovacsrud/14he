using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] beagyazott = new int[3][];

            beagyazott[0] =new int[]{1,2,3 };
            beagyazott[1] = new int[]{ 4, 5, 6, 7, 8 };
            beagyazott[2] = new int[] { 9, 10 };

            for (int i = 0; i < beagyazott.Length; i++)
            {
                for (int j = 0; j < beagyazott[i].Length; j++)
                {
                    Console.Write(beagyazott[i][j]+" ");
                }
                Console.WriteLine();
            }

            //készítsen egy 20X20 elemű 2d tömböt! Töltse fel -100 és 100 közötti
            //véletlen számokkal! Írassa ki úgy ezt a tomböt, hogy a negatív számok
            //pirossal, a pozitívak zölddel, a nullák pedig egy tetszőlegesen
            //megválasztott színnek jelenjenek meg!

            int[,] tomb2d = new int[20, 20];
            Random rand = new Random();
            //feltöltés véletlen számokkal
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    tomb2d[i, j] = rand.Next(-100, 101);
                }
                
            }
            //kiíratás
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    if (tomb2d[i,j]>0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
                    if (tomb2d[i,j]<0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (tomb2d[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write(tomb2d[i,j]+" ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            //Lottó játék készítése
            Console.Write("Hány számot húzunk?:");
            int szamDb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hány számból sorsolunk?:");
            int osszesSzam = Convert.ToInt32(Console.ReadLine());

            int[] tippek = new int[szamDb];
            int[] nyeroSzamok = new int[szamDb];

            //tippek bekérése
            var temp = 0;
            for (int i = 0; i < szamDb; i++)
            {
                Console.Write($"{i+1}.tipp:");
                temp = Convert.ToInt32(Console.ReadLine());

                while (temp<1 || temp>osszesSzam || tippek.Contains(temp))
                {
                    Console.Write($"Rossz tipp, újra {i+1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                    //Debug.WriteLine(temp);
                }
                tippek[i] = temp;

            }

            //nyerőszámok generálása

            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write(tippek[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
