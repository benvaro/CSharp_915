using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_StdDelegates
{
    class Program
    {

        public static void Test(string str)
        {
            Console.WriteLine(str);
        }

        public static bool TestBool(params int[] arr)
        {
            return arr.Length % 2 == 0 ? true : false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 10, -3, 5, 7, 12 };

            arr.Min();
            ArrayList ar = new ArrayList(arr);
            ar.Sort();


            // Action  - void NameAction (0.. 16)
            // Func<TIn... 16, TOut>    Func<int, string>   ?   string NameFunc(int)
            // Func <int> ?   int A ()
            // Func <int, double, char, string>    string B(int, double, char)
            // Predicate

            Action<string> act = Test;
            act("Hello");

            Predicate<int[]> p = TestBool;
            Console.WriteLine(p(arr));

            Func<int[], bool> func = TestBool;
            Console.WriteLine(p(arr));
        }
    }
}
