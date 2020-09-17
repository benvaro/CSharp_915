using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_re_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //   A();
                //   B();
                C(null);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void A()
        {
            try
            {
                int value = 1 / int.Parse("0"); // ? 
            }
            catch
            {
                throw;   // викидається виключення такого самого типу, тобто DivideByZeroExc
            }
        }

        static void B()
        {
            try
            {
                int value = 1 / int.Parse("bbb"); // ? 
            }
            catch(FormatException ex)
            {
                throw ex; 
            }
        }

        static void C(string value)
        {
            if (value == null)
                throw new ArgumentNullException("value"); // генерую виключення типу ArgumentNullException
        }
    }
}
