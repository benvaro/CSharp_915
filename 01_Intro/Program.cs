using System;

// ctrl + k + c/u
// ctrl + k + e
// ctrl + k + s
// cw
// for
// if
// class
// ctor
// cr

namespace _01_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test
            //            Console.Title = "My first project";
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("Hello, world");
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.OutputEncoding = Encoding.UTF8;
            //            Console.WriteLine("Привіт, світ!");
            //            Console.Clear();

            //            // int
            //            // float, double
            //            // bool
            //            // char
            //            // string

            ////            Int32 number = 34;
            //            int number = 34;
            //            float numberF = 34.6f;
            //            // resharper 
            //            char s = 'A';
            //            //  char s2 = -1;

            //            string str = "Hello";

            //            Console.WriteLine("Str = " + str + ": type = " + str.GetType().Name);
            //            Console.WriteLine("s = {0}, type = {1}", s, s.GetType().Name);
            //            Console.WriteLine($"numberF = {numberF}, type = {numberF.GetType().Name}");

            //            string text = Console.ReadLine();
            //            Console.WriteLine($"text = {text}");

            //            var num = Double.Parse(Console.ReadLine());
            //            Console.WriteLine(num); 
            #endregion

            //double dd = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(dd);
            #region try parse

            //double dd;
            //if(double.TryParse(Console.ReadLine(), out dd))
            //    Console.WriteLine(dd); 
            #endregion

            #region switch
            //string result = Console.ReadLine();
            //switch (result)
            //{
            //    case "one":
            //        Console.WriteLine("One");
            //        break;
            //    default:
            //        Console.WriteLine("other");
            //        break;
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //do
            //{
            //    Console.ReadLine();
            //} while (Console.ReadKey().Key != ConsoleKey.Escape); 
            #endregion

            // if, switch, for, while, do while

            #region char
            char symbol = 's';
            Console.WriteLine(Char.ToUpper(symbol));
            Console.WriteLine(Char.IsDigit(symbol));
            Console.WriteLine("text".Length);

            #endregion
            // Program p = new Program();
            // p.Hello();
            Hello(Console.ReadLine());

            string text = "Hello";
            if (String.IsNullOrEmpty(text))
                Console.WriteLine();
        }

        static void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
