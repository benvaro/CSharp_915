using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Types:
            // value-types: struct, int, double, float
            // reference types: class, string, array
            // nullable
            //Nullable<int> GroupId = null;
            /* int? a = null;
             if(a != null)
                 Console.WriteLine(a);
             else
                 Console.WriteLine("a == null");
            */

            //int array[size]; // c++
            int[] arr = null;
            int size = 7;
            arr = new int[size];  // ---> [0]

            int[] arr2 = new[] { 5, 7, 5, 34, -4 }; // початкова ініціалізація елементів

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * i;
            }

            PrintArray(" after i * i", arr);

            int[] arr3 = new int[7] { 11, 22, 33, 44, 55, 66, 77 };

            // readonly
            foreach (int item in arr3)
            {
                Console.Write($"{item,4}");
                //  item *= 2;  // error!!! foreach is readonly
            }
            Console.WriteLine();

            //rand() --> 0 65535

            Random random = new Random();
            for (int i = 0; i < arr3.Length; i++)
            {
                arr[i] = random.Next(-5, 5);  // [-5,4]
            }

            PrintArray(" rand Next(-5,5): ", arr);

            double[] dArray = new double[5];
            for (int i = 0; i < dArray.Length; i++)
            {
                dArray[i] = random.NextDouble(); // 0..1
                //Console.Write($"{dArray[i],10:N3}"); // 10 - ширина поля, :N3 - скільки знаків після коми вивести
            }

            PrintDoubleArray("double rand array", dArray);
            AppendElement(ref arr, 1000);
            PrintArray("After append element 1000", arr);
        }

        private static void AppendElement(ref int[] arr, int value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
        }

        private static void PrintArray(string prompt, int[] arr)
        {
            Console.WriteLine("Print: " + prompt);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0, -5}", arr[i]);
            }
            Console.WriteLine();
        }
        private static void PrintDoubleArray(string prompt, double[] arr)
        {
            Console.WriteLine("Print: " + prompt);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0, -10:N3}", arr[i]);
            }
            Console.WriteLine();
        }
    }
  
}
