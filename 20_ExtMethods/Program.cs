using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ExtMethods
{
    public static class Extensions
    {
        public static int CountDigit(this string param)
        {
            return param.Count(x => Char.IsDigit(x));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "21 september, 2020, Monday";
            Console.WriteLine(text.CountDigit());
        }
    }
}
