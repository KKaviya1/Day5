using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedR.C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][,] myJArray= new int[3][,];
            myJArray[0] = new int[2, 2] { { 1, 2 }, { 2, 3 } };
            myJArray[1] = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 5, 4 } };
            myJArray[2] = new int[3, 3] { { 1, 2,6 }, { 2, 3,7 }, { 5, 4, 8 } };
            Console.WriteLine("stored values are");
            for(int i =0;i<myJArray.Length; i++)
            {
                for (int r= 0; r < myJArray[i].GetLength(0); r++)
                {
                    for (int c = 0; c < myJArray[i].GetLength(1); c++)
                    {
                        Console.Write(myJArray[i][r, c] + "\t");
                    }
                    Console.WriteLine("\n'");
                }
                Console.WriteLine("*********************");
            }
            Console.ReadKey();
        }
    }
}
