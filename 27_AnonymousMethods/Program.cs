using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AnonymousMethods
{
    class Program
    {
        public delegate int CalcDelegate(int a);
        static void Main(string[] args)
        {
            CalcDelegate calc = (x) =>  x * x ;

            calc = delegate (int x)
            {
                return x * x * x;
            };


            

        }
    }
}
