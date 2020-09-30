using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_EventHandler
{
    class Program
    {
        delegate void MyDelegate();

        class Eventer
        {
            public event MyDelegate SomethingHappen;

            public void DoSmth(int number)
            {
                Console.WriteLine("Number: {0}", number);
                if (number > 5 && number < 15)
                    OnSomethingHappen();
            }

            private void OnSomethingHappen()
            {
                SomethingHappen?.Invoke();
            }
        }

        class One
        {
            public static void Handler()
            {
                Console.WriteLine("It is a static Handler from class One");
            }
        }

        class Two
        {
            public  void Handler()
            {
                Console.WriteLine("It is a  Handler from class Two");
            }
        }

        static void Main(string[] args)
        {
            Eventer ev = new Eventer();
            Two two = new Two();

            ev.SomethingHappen += One.Handler;
            ev.SomethingHappen += two.Handler;
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                ev.DoSmth(rand.Next(-10, 25));
            }

            ev.SomethingHappen -= One.Handler;
            ev.SomethingHappen += () => Console.WriteLine("Anonymous handler");
            ev.SomethingHappen += delegate
            {
                Console.WriteLine("delegate handler");
            };
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                ev.DoSmth(rand.Next(-10, 25));
            }
        }
    }
}
