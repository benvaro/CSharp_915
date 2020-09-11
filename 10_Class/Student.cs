using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Class
{
    class Student
    {
        private string name;   // default? null
        private int age;   // 0
        private DateTime date;   // 01.01.0001 00:00
        public string Group { get; set; } // auto property (автоматична властивість, використовуємо, якщо не треба валідація)
        public float AvgMark { get; private set; }

        public Student()
        {
            Name = "Alex";
            Age = 11;
            Date = DateTime.Now;
        }

        public Student(string name, int age, DateTime date)
        {
            this.name = name;
            this.age = age;
            this.date = date;
        }

        public Student(string name)
        {
            this.name = name;
        }

        //public void SetName(string name)
        //{
        //    if (!String.IsNullOrEmpty(name))
        //    {
        //        this.name = name;
        //        return;
        //    }
        //    throw new Exception("Bad name");
        //}

        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}

        //public void SetDate(DateTime date)
        //{
        //    this.date = date;
        //}

        //public string GetName()
        //{
        //    return name;
        //}

        //public int GetAge()
        //{
        //    return age;
        //}
        //public DateTime GetDate()
        //{
        //    return date;
        //}

        public DateTime Date
        {
            get { return date; }
            set { date = value;
                Age = 1;
            }
        }


        public int Age
        {
            get { return age; }
            private set { age = DateTime.Now.Year - date.Year; }
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    name = value;
                    return;
                }
                throw new Exception("Bad name");
            }
        }

        public void Print()
        {
            Console.WriteLine($"{Name} -> {Age} -> date: {Date}");
        }
    }
}
