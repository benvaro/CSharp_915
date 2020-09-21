using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_abstract
{
    abstract class AbstractPerson
    {
        abstract public string Name { get; set; } // абстрактну властивість потрібно визначати в класі нащадку за доп override
        protected int Age = 0;
        abstract public void Busy(); 
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: " + Age);
        }
    }

    class Person : AbstractPerson
    {
        public override string Name { get; set; }
        public string Gender { get; set; }

        public Person(string name = "empty", int age = 0, string gender = "not set")
        {
            Name = name ?? "empty";
            Age = age;
            Gender = gender ?? "not set";
        }
        public override string ToString() => $"Name: {Name}, Age {Age}, Gender: {Gender}";
        
        public override void Busy()
        {
            Console.WriteLine("Do something");
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Gender: {Gender}");
        }
    }

    class Student : Person
    {
        public override string Name { get; set; }
        public string Spec { get; set; }

        public Student(string name = "empty", int age = 0, string gender = "not set",
            string spec = "empty"): base(name, age, gender)
        {
            Spec = spec ?? "empty";

        }
        public override string ToString() => $"Name: {Name}, Age {Age}, Gender: {Gender}";

        public override void Busy()
        {
            Console.WriteLine("Do Study");
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Spec: {Spec}");
        }
    }
}
