using _21_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Interfaces.Classes
{
    class Employee : ICanWork, IWorker
    {
        public string Position { get; set; }
        public Employee(string name, int age, string position = "none")//: base(name, age)
        {
            Position = position;
        }
        public int Salary { get ; set ; }

        public void DoWork()
        {
            Console.WriteLine("Work as {0}", Position);
        }
        
        void ICanWork.DoWork()
        {
            Console.WriteLine("Work as human");
        }
    }
}
