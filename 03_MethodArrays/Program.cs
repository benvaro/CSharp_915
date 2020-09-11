using System;
using System.Linq;

namespace _03_MethodArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 6;
            int[] a = new int[size];
            int[] b = new int[size];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
                b[i] = i * 10;
            }

            PrintArr("A: ", a);
            PrintArr("B: ", b);

            a = b; // масив а посилаэться на б
            PrintArr("After A = b: ", a);
            PrintArr("B: ", b);

            a[0] = 9999;

            Mult2Array(a);
            PrintArr("After Mult: ", b);

            Console.Clear();
            Console.WriteLine("Arrays methods:_______________________");
            a = new[] {9, -8, 19, 0 , 34, 1, 10};
            Array.Sort(a); // для впорядкування масиву використала статичний метод класу Array
            PrintArr("Sort: ", a);

            //Array.Sort(a, Cmp);
         //   Array.Sort(a, (x, y) => y - x);  //  по спаданню, використали лямбду
            PrintArr("Sort lambda func: ", a);

            Console.WriteLine($"Binary Search: {Array.BinarySearch(a, 19)}");
            PrintArr("before copy to b: ", b);
            Array.Copy(a, 2, b, 3, 3); // копіюй 3 елемента масиву а, починаючи з 2-ого в масив б, починаючи з 3-ого
            PrintArr("After copy to b: ", b);
            b = new int[10];
            a.CopyTo(b, 2);
            PrintArr("After a.CopyTo()", b);

            int el = Array.Find(b, (x) => { return x < 0; });
            Console.WriteLine("First element in array < 0: " + el);
            int [] elements = Array.FindAll(b, (x) => { return x % 2 == 0; });
            PrintArr("After find all: ", elements);

            Array.Reverse(elements);
            PrintArr("After reverse: ", elements);
            Console.WriteLine("Count: {0}", a.Count());
            Console.WriteLine("Min: {0}", a.Min());
            Console.WriteLine("Max: {0}", a.Max());
            Console.WriteLine("Suma: {0}", a.Sum());
            Console.WriteLine("Avg: {0}", a.Average());

            // TODO: Clone, Foreach
        }

        private static int Cmp(int x, int y) // 0 1 x > y -1 x < y
        {
            return x - y;
        }

        private static void Mult2Array(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= 2;
            }
        }

        private static void PrintArr(string prompt, int[] arr)
        {
            Console.WriteLine(prompt);
            foreach (var item in arr)
            {
                Console.Write($"{item, 5}");
            }
            Console.WriteLine();
        }
    }
}
