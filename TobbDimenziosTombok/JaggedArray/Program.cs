using System;
using System.Collections.Generic;
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



            Console.ReadKey();
        }
    }
}
