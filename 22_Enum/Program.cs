using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Enum
{
    class Program
    {
        enum Days { Mon = -1, Tue, Wedn }; // base type? int
        enum Colors : uint { Red = 3, Green = 5, Blue = 15, White = 0, Yellow = 7 };
        static Colors color = Colors.Blue;
        static void Main(string[] args)
        {
            Line();

            Console.WriteLine((int)color);
            Console.WriteLine(color.GetTypeCode());

            Console.WriteLine("Enter Color: ");
            // string strColor = Console.ReadLine();
            //Colors customColor = (Colors)Enum.Parse(typeof(Colors), strColor);
            //Console.WriteLine(customColor);
            Line();
            var colorsNames = Enum.GetNames(typeof(Colors));
            foreach (var item in colorsNames)
            {
                Console.WriteLine(item);
            }
            Line();

            foreach (var item in Enum.GetValues(color.GetType()))
            {
                string col = Enum.Format(typeof(Colors), (uint)67 /*boxing*/, "g");  // white, exception?
                Console.WriteLine("Enum.Format: {0}", col);
                //Console.WriteLine((uint)item);
            }
            // Ввести колір (рядок). Вивести лінію такого кольору, як ми введемо (ForeColor)
            Console.WriteLine("Enter color: ");

            string tColor = Console.ReadLine();
            ConsoleColor customColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), tColor);
            Console.ForegroundColor = customColor;
            Line();
            Console.ForegroundColor = ConsoleColor.White;

            // 1..10  int - Colors
            for (uint i = 1; i < 10; i++)
            {
                if (Enum.IsDefined(typeof(Colors), i))
                    Console.WriteLine((Colors)i);
            }
        }

        private static void Line()
        {
            string line = new string('_', 80);
            Console.WriteLine(line);
            Console.WriteLine();
        }
    }
}
