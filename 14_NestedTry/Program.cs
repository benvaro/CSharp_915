using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NestedTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            try
            {
                for (int div = -3, j = 0; div < 3; div++, j++)
                {
                    try
                    {
                        arr[j] = 100 / div;
                        Console.WriteLine("arr[{0}] = 100 / {1} = {2}", j, div, arr[j]);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Inner finally");
                    }
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\t\tOuter finaly");
            }
            Console.WriteLine("Other work in main");
        }
    }
}
