using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Delegates
{

    class Program
    {
        public delegate void TestDelegate();  // користувацький тип

        public delegate void Operator(int a, int b);
        public delegate int CalcDelegate();
        static void Main(string[] args)
        {
            TestDelegate test = new TestDelegate(Hello);
            test();

            test = new TestDelegate(() => Console.WriteLine("Bye"));
            test.Invoke();// 
            Console.WriteLine();
            TestDelegate test2 = new TestDelegate(Goodbye);
            TestDelegate res = test + test2;
            res();
            // test();
            // Delegates - як вказівники на функції в С++

            Operator op = new Operator(Plus);
            op += Minus;
            op += Mult;
            op -= Minus;
            op += Div;
            op += Div;
            op += Div;
            op -= Minus;

            op(5, 3); // ?

            var list = op.GetInvocationList();
            foreach (Operator item in list)
            {
                item.Invoke(5, 8);
            }

            Calculator obj = new Calculator { A = 12, B = 2};
            CalcDelegate calc = obj.Add ;
            calc += obj.Div;
            calc += Calculator.Minus;

            Console.WriteLine("Target: " + calc.Target);  // ? 
            Console.WriteLine("Method: " + calc.Method);

            Console.WriteLine(calc());

        }

        private static void Hello()
        {

            Console.WriteLine("Hello");
        }

        private static void Goodbye()
        {
            Console.WriteLine("Goodbye");
        }

        private static void Plus(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        private static void Minus(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        private static void Mult(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        private static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        class Calculator
        {
            public int A { get; set; }
            public int B { get; set; }

            public int Add()
            {
                return A + B;
            }
            public int Div()
            {
                return A / B;
            }
           public static int Minus()
            {
                return 12 - 5;
            }
        }
    }
}
