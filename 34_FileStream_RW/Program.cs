using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_FileStream_RW
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello. Write string to file";
            using (FileStream fs = new FileStream("Fs", FileMode.Create, FileAccess.ReadWrite))
            {
                byte[] data = Encoding.UTF8.GetBytes(str.ToCharArray(), 0, str.Length);

                fs.Write(data, 0, data.Length);

                byte[] res = new byte[fs.Length];

                // fs.Seek(0, SeekOrigin.Begin);
                fs.Position = 0;
                
                fs.Read(res, 0, res.Length);

                Console.WriteLine("Read: {0}", Encoding.UTF8.GetString(res));
            }
        }
    }
}
