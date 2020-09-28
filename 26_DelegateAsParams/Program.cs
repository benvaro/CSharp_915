using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_DelegateAsParams
{
    class Program
    {
        delegate void Transformer(ref int number);
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 10, -3, 5, 7, 12 };

            Print(arr);
            Console.WriteLine("Changes via Inc:");
            WorkWithArr(ref arr, new Transformer(Inc));
            Console.WriteLine();
            Print(arr);

            Console.WriteLine("Changes via Dec:");
            WorkWithArr(ref arr, Dec);
            Console.WriteLine();
            Print(arr);


            Console.WriteLine("Changes via lambda:");
            WorkWithArr(ref arr, (ref int x) => x = x * x);
            Console.WriteLine();
            Print(arr);

            Console.WriteLine("Changes via lambda :");
            int number = 0;
            WorkWithArr(ref arr, (ref int x) => x = number++); // замикання
            Console.WriteLine();
            Print(arr);

            Console.WriteLine("Changes via lambda :");
            WorkWithArr(ref arr, (ref int x) => {
                int f = 1;
                for (int i = 1; i <= x; i++)
                {
                    f *= i;
                }
                x = f;
            });
            Console.WriteLine();
            Print(arr);
        }

        private static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine();
        }

        private static void WorkWithArr(ref int[] arr, Transformer t)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                t(ref arr[i]);
            }
        }

        private static void Inc(ref int x)
        {
            x++;
        }
        private static void Dec(ref int x)
        {
            x--;
        }
    }
}
