using _21_Interfaces.Interfaces;
using System;

namespace _21_Interfaces.Classes
{
    class Bee : ICanFly, ICanWork, ICanRun
    {
        public void DoWork()
        {
            Console.WriteLine("I geather honey");
        }

        public void Fly()
        {
            Console.WriteLine("Fly as bee");
        }

        public void Run()
        {
            Console.WriteLine("run as bee");
        }
    }
}
