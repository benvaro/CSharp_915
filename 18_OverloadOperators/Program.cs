using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // відкриті статичні методи класу
            // тип повертаємого результату має співпадати з типом класу
            // перегрузка не повинна міняти пріоритет о-й
            // ви не можете міняти к-сть аргументів операції
            // ref out - не можна використовувати в перегрузках операторів

            // Не можна перегружати: . new as  is typeof = ?: += -= *= /=  && ||

            // true false & |  - && ||
            // < >  == != true false
            // () []  -? 

            Fraction a = new Fraction(2, 3);
            Fraction b = new Fraction(5, 3);
            Console.WriteLine(a + b);
            Fraction c = new Fraction();
            c += a;
            Console.WriteLine(a + 10);
            Console.WriteLine( 10 + a);
            Console.WriteLine("Operator -: ", -c);
            a = new Fraction(5, 7);
            Console.WriteLine("a++: " + a++); //  6/8
            Console.WriteLine("++a: " + ++a);  // 
            Console.WriteLine("a--: " + a--);
            Console.WriteLine("--a: " + --a);
            a.Num = 9 ;
            if(a) // ? if (a == true)
            {
                Console.WriteLine(a + " - true");
            }
            else
            {
                Console.WriteLine(a + " - false");
            }

            double dFraction = a; // явно чи неявно? неявно
            Console.WriteLine("fraction to double: {0} ---> {1}", a, dFraction);

            int intFraction = (int)a; // виклик оператора explicit
            Console.WriteLine("fraction to int: {0} ---> {1}", a, intFraction);
            // explicit - явне приведення
            // implicit - неявне

            a = dFraction;
            Console.WriteLine("Fraction from double {0}", a);
            int test = 45;
            float test2 = test; // неявно - це без втрати // 45.00
            test2 = 78.89f;
            test = (int)test2; // 
        }
    }
}
