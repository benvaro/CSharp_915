using System;
using System.IO;

namespace _16_InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    var num = int.Parse("abc");
                }
                catch (Exception e)
                {
                    try
                    {
                        File.Open("DoesntExists", FileMode.Open);
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine("Catch inner");
                        throw new FileNotFoundException(ex.Message, e);
                    }
                }
            }
            catch (Exception e)
            {
                string msg = "";
                Console.WriteLine("Catch outer");
                if (e.InnerException != null)
                {
                    msg += e.InnerException.Message;
                }
                msg += Environment.NewLine + e.Message;
                Console.WriteLine($"Message with inner: {msg}");
            }

            Console.WriteLine("Work in main");
        }
    }
}
