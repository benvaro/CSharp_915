using _21_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Interfaces.Classes
{
    class Human: ICanRun, ICanWork
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name = "empty", int age = 0)
        {
            Name = name ?? "empty";
            Age = age > 0 ? age : 0;
        }

        public void Run()
        {
            Console.WriteLine("human Run");
        }

        public void DoWork()
        {
            Console.WriteLine("Do something: Human");
        }

        public override string ToString()
        {
            return $"{Name} --- {Age}";
        }
    }
}
