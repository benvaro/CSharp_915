using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_GC
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();

            TestDemo();
            Console.WriteLine();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Demo d = new Demo();
            }
            GC.Collect();
            
            Console.WriteLine();
            TestDemo();
        }

        private static void TestDemo()
        {
            for (int i = 0; i < 5; i++)
            {
                Demo d = new Demo();
            }
        }

        class Demo
        {
            static int id;
            int number;

            static Demo()
            {
                id = 1;
            }
            public Demo()
            {
                number = id++;
                Console.WriteLine("Number #{0}", number);
            }

            // Finalizer
            // Finalize();
            ~Demo()
            {
                Console.WriteLine("Finalizator: ~Demo() - #{0}", number);
            }
        }
    }
}
