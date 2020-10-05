using System;
using System.IO;
using System.Text;

namespace _33_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte[] arr = { 4, 6, 23, 6, 12, 2, 9, 56, 123 };

            //using (FileStream fs = new FileStream("bytes.txt", FileMode.Create))
            //{
            //    fs.Write(arr, 0, arr.Length);
            //}
            #region Read from file via FileStream
            //byte[] result = null;
            //using (FileStream fs = new FileStream("bytes.txt", FileMode.Open))
            //{
            //    result = new byte[fs.Length];
            //    int count = fs.Read(result, 0, result.Length);

            //    Console.WriteLine("Read: {0} bytes", count);
            //}
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write("{0, 5}", result[i]);
            //}
            //Console.WriteLine(); 
            #endregion


            //string text = Console.ReadLine();
            //using (FileStream fs = new FileStream("string.txt", FileMode.Create))
            //{
            //    fs.Write(Encoding.UTF8.GetBytes(text), 0, text.Length);
            //}
            using (FileStream fs = new FileStream("string.txt", FileMode.Open))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                Console.WriteLine("We read: " + Encoding.UTF8.GetString(buffer/*, 0, buffer.Length*/));
            }
        }
    }
}
