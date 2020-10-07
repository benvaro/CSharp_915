using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_StreamWR
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hello, wednesday!";
            //using (StreamWriter writer = new StreamWriter("stream.txt"))
            //{
            //    writer.WriteLine(str);
            //    writer.Write(str.Replace("e", "E"));
            //}

            using (StreamReader reader = new StreamReader("stream.txt"))
            {
                string str = "";
                int i = 0;
                while (!reader.EndOfStream)
                {
                    i++;
                    str += reader.ReadLine();
                }
                Console.WriteLine(i);
            }
        }
    }
}
