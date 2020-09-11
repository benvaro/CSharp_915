using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.WriteLine(Sumator(out count, 2,5,6));
            Console.WriteLine(Sumator(out int count2, 1,2,3,2,5,6));
            Console.WriteLine(count);
            Console.WriteLine(count2);

            Inc(ref count2); // 7
            Console.WriteLine(count2);
        }

        static void Inc(ref int a)
        {
            a++;
        }

        static int Sumator(out int count, params int[] args) // out - вихідний параметр
        {
            int suma = 0;
            count = args.Length;
            foreach (var item in args)
            {
                suma += item;
            }
            return suma;
        }

    }
}
