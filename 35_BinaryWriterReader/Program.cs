using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_BinaryWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (BinaryWriter writer = new BinaryWriter(
            //                            new FileStream("binary", FileMode.Create)))
            //{
            //    writer.Write("We try to write string");
            //    writer.Write(123);
            //    writer.Write(5.7);
            //    writer.Write(1 == 1);
            //}

            string resStr;
            int resInt;
            double resDouble;
            bool resBool;

            using (BinaryReader reader = new BinaryReader(
                                         new FileStream("binary", FileMode.Open)))
            {
                resStr = reader.ReadString();
                resInt = reader.ReadInt32();
                resDouble = reader.ReadDouble();
                resBool = reader.ReadBoolean();
            }

            Console.WriteLine("_____Test binary reader ______");
            Console.WriteLine(resStr);
            Console.WriteLine(resInt);
            Console.WriteLine(resDouble);
            Console.WriteLine(resBool);
        }
    }
}
