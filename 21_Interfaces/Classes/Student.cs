using _21_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Interfaces.Classes
{
    class Student : Human, ICanWork
    {
        public string Spec { get; set; }
        public Student(string name, int age, string spec = "undefined"): base(name, age)
        {
            Spec = spec ?? "empty";
        }
        public void DoWork()
        {
            Console.WriteLine("Do Study");
        }
    }
}
