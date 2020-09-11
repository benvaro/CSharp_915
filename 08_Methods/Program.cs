using System;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sumator(34, 6, 34, 2, 5, 1, 2, 8));
            Console.WriteLine(Sumator(new[] { 3, 1, 2 }));
            int[] arr = new int[] { 1, 4, 5, 7, 8, 9 };

            Console.WriteLine(Sumator(arr));
        }

        static int Sumator(params int[] args) // params - довільна кількість аргументів
        {
            int suma = 0;
            Console.WriteLine("Count of args: {0}", args.Length);
            foreach (var item in args)
            {
                suma += item;
            }
            return suma;
        }
    }
}