using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Exceptions
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                //SomeDangerousMethod();
                try
                {
                    //   SomeDangerousMethod();
                    SomeMethod();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("This block will execute when error apears");
                    Console.WriteLine("\tMessage: {0}", ex.Message);
                    Console.WriteLine("\tStackTrace: {0}", ex.StackTrace);
                    Console.WriteLine("\tSource: {0}", ex.Source);
                    Console.WriteLine("\tHelpLink: {0}", ex.HelpLink);
                    Console.WriteLine("\tTargetSite: {0}", ex.TargetSite);
                    Console.WriteLine("\tTime: {0}", ex.Data["Time"]);
                    Console.WriteLine("\tValue: {0}", ex.Data["Value"]);
                }
                catch
                {
                    Console.WriteLine("Блок виконається, коли стане виключення з необробленими вище помилками");
                }
            }
        }
        private static void SomeMethod()
        {
            SomeDangerousMethod();
        }
        private static void SomeDangerousMethod()
        {
            Console.WriteLine("\tProbably throw exceptions before throw");
            int val = 100;
            if(rnd.Next(0, 4) == 0)
            {
                Exception ex = new Exception("This is demo message error");
                ex.HelpLink = "https://google.com";
                ex.Data["Time"] = DateTime.Now;
                ex.Data["Value"] = val;

                throw ex;
            }
            Console.WriteLine("\t After throw...");
        }
    }
}
