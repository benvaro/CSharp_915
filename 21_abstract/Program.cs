using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractPerson> persons = new List<AbstractPerson>()
            {
                new Person("Anton", 18, "male"),
                new Student("Alex", 18, "male")
            };

            foreach (var item in persons)
            {
                item.Busy();
                if(item is Student)
                    ((Student)item).Print();
                Console.WriteLine();
            }
        }
    }
}
