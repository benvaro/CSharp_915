using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_juggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jugged = new int[rows][]; // масив масивів = рваний масив
            Random rand = new Random();

            for (int i = 0; i < jugged.Length; i++)
            {
                jugged[i] = new int[rand.Next(2, 10)];
                for (int j = 0; j < jugged[i].Length; j++)
                {
                    jugged[i][j] = rand.Next(-10, 10);
                }
            }

            JuggedPrint(jugged);

        }

        static void Print(int [] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0, 5}", item);
            }
            Console.WriteLine();
        }

        static void JuggedPrint(int [][] jugged)
        {
            for (int i = 0; i < jugged.Length; i++)
            {
                Print(jugged[i]);
            }
            Console.WriteLine();
        }
    }
}
