using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // try - 
            // catch - ?
            // throw - ?  throw "Some error"; throw 7; new Exception
            // finally ? - в будь-якому випадку виконуэмо даний блок - незалежно чи була помилка в try, чи ні

            Random rnd = new Random();

            int size = rnd.Next(6, 15);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(-30, 30);
            }
            ShowArr(arr);

            int val = rnd.Next(-30, 30);
            int indexFound = 0;
            int indexStart = 0;

            bool isProblem = false;
            do
            {
                Console.WriteLine("Enter start index of searching 0.. {0}:", arr.Length - 1);
                try
                {
                    indexStart = byte.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Невірно введені дані");
                    isProblem = true;
                    if(ex.GetType().Name == "FormatException")
                        Console.WriteLine("Невірний формат числа");
                    else if (ex.GetType().Name == "OverflowException")
                        Console.WriteLine("Число завелике або замале");
                    else if (ex.GetType().Name == "ArgumentNullException")
                        Console.WriteLine("Введений рядок не є числом");
                    //    Console.WriteLine(ex.Message);
                    continue;
                }
                finally
                {
                    Console.WriteLine("Some actions in finally");
                }
                Console.WriteLine("Try again");

                ///////// 
                ///
                try
                {
                    indexFound = Array.IndexOf(arr, val, indexStart);
                    isProblem = false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Ви ввели правильне число, але воно не в діапазоні");
                    isProblem = true;
                }
                finally
                {
                    Console.WriteLine("Finally for #2 try");
                }
            } while (isProblem);

            Console.WriteLine("Found: {0} in position {1}", val, indexFound);
        }

        private static void ShowArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{ item, 4}");
            }
            Console.WriteLine();
        }
    }
}
