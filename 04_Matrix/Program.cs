using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter cols:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols]; // 
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-99, 100);
                }
            }
            Console.WriteLine("2-dimension array:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            /////////
            ///
            foreach (var item in matrix)
            {
                Console.Write("{0, -5}", item);
            }
            Console.WriteLine();
            Console.WriteLine("Rank:"+  matrix.Rank);

            int[,,] array3D = new int[3, 2, 2]
            {
                { { 1, -2}, { 4, -4} },
                { { 10, -12}, { 14, -4} },
                { { 111, -20}, { 40, -4} }
            };
            Console.WriteLine("3Darray");
            for (int i = 0; i < array3D.GetLength(0); i++)
            {

                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write("{0, -5}", array3D[i, j, k]);
                        
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
