using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "\nFirst" + "\n\tSecond";
            string newStr = new string('#', 50);

            Console.WriteLine(newStr);
            Console.WriteLine(line);

            newStr = $"{newStr} ----- {line}";
            Console.WriteLine(newStr);

            string path = @"C:\Program Files\Microsoft";
            Console.WriteLine(path);

            decimal number = 121223.45M;
            Console.WriteLine(number.ToString());
            newStr = String.Format("This is decimal number {0:N4}", number);
            Console.WriteLine(newStr);

            char[] arr = new[] { 'H', 'E', 'L', 'L', 'O' };
            arr[0] = '#';

            char symbol = newStr[0];
           // newStr[0] = '*'; // error
            Console.WriteLine(symbol);

            string res = new string(arr);

            char[] reverse = res.ToCharArray();

            Array.Reverse(reverse);
            res = new string(reverse);
            Console.WriteLine(res);

            string one = "abc", two = "ABC"; // a < A === -1
                                                // 97 > 65
            Console.WriteLine(one.CompareTo(two));
            Console.WriteLine(String.CompareOrdinal(one, two));
            Console.WriteLine(String.Compare(one, two, true));

            string text = "_Доброго дня!_";
            Console.Clear();
            Console.WriteLine(text.IndexOf('о'));
            Console.WriteLine(text.LastIndexOf('о'));
            //text.IndexOfAny()
            Console.WriteLine(text.Substring(4, 3));
            Console.WriteLine(text.Trim(new[] { '_' }));
            var words = text.Split(" ".ToCharArray());
            Console.WriteLine(words.Length);

            if(text.Contains("ого"))
            {
                Console.WriteLine("yes");
            }

            Console.WriteLine(text.EndsWith("_"));
            Console.WriteLine(text.StartsWith("_"));
            text = text.Insert(2, "hello");
            Console.WriteLine(text);
        }
    }
}
