using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance_01
{
    class Person
    {
        private int Id = 1;
        protected int ID { set => Id =  value; }

        public string Name  { get; set; }
        public Person(string name = "Noname") // null?
        {
            Name = name ?? "Noname";
        }

        public virtual void Busy()
        {
            Console.WriteLine("Do something...");
        }
        public override string ToString() => $"Name: {Name}, Id = {Id}";


    }

    class Employee : Person
    {
        public string Position { get; set; }

        public Employee(string position = "unknown", string name = "noname"): base(name)
        {
            Position = position ?? "unknown";
            ID = 2;
            
        }

        public void Test()
        {
            Console.WriteLine("Test");
        }

        public override string ToString() => base.ToString() + $" position: {Position}";
        
        public override /*new*/ void Busy() // new - уникаэмо приховування
        {
            Console.WriteLine("Do work");
        }
    }

    sealed class Student: Person // sealed - не можна успадковувати
    {
        public string Spec { get; set; }

        public Student(string name="noname", string spec = "unknown spec"): base(name)
        {
            Spec = spec ?? "unknown spec";
            ID = 3;
           
        }
        public override string ToString() => base.ToString() + $" spec: {Spec}";

        public override /*new*/ void Busy() // new - уникаэмо приховування
        {
            Console.WriteLine("Do study");
        }
    }
    //class Test: Student
    //{

    //}
}
