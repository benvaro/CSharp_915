using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance_01
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person("Olia"),
                new Student("Ivan", "IT"),
                new Employee("Admin", "Illya")
            };

            foreach (var item in persons)
            {
                Console.WriteLine(item);
                item.Busy();
                Console.WriteLine();
            }

            persons.AddRange(
                new[]
                {
                    new Employee("Programmer", "Bill"),
                    new Employee("Designer", "Ivanka"),
                    new Employee("Programmer", "Mark"),
                    new Employee("Economist", "Kostia")
                });

            Console.WriteLine();
            foreach (var item in persons)
            {
                if (item is Employee)
                    ((Employee)item).Test();
            }

           int countProg =  persons.Count(x=> {
               if (x is Employee)
                   return (x as Employee).Position == "Programmer";
               return false;
           });
            Console.WriteLine(countProg);

            foreach (var item in persons)
            {
                if (item is Employee)
                    if((item as Employee).Position.Equals("Programmer"))
                        Console.WriteLine(item);
            }

            persons.FindAll(x => 
            {
                if (x is Employee)
                  //  if (((Employee)x).Position.Equals("Programmer"))
                        return true;
                return false;
            });

            var students = persons.FindAll(x => x.GetType() == typeof(Student));
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
