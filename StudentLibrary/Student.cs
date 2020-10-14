using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student: ICloneable
    {
        private string name;   // default? null
        private int age;   // 0
        private DateTime? date;   // 01.01.0001 00:00
        public string Group { get; set; } // auto property (автоматична властивість, використовуємо, якщо не треба валідація)
        public float AvgMark { get; private set; }
        public static int Id { get; set; }

        public Group Groups { get; set; }
        #region ctors
        static Student()
        {
            Id = 100;
        }
        public Student()
        {
            Name = "Alex";
        //    Age = 11;
         //   Date = DateTime.Now;
            Id++;
        }

        public Student(string name, int age, DateTime date)
        {
            this.name = name;
            this.age = age;
            this.date = date;
            Id++;
        }

        public Student(string name)
        {
            Id++;
            this.name = name;
        }
        #endregion
     

        public DateTime? Date
        {
            get { return date; }
            set
            {
                date = value;
                Age = 1;
            }
        }

        public static void ShowId()
        {
            Console.WriteLine("ID: " + Id);
        }

        public int Age
        {
            get { return age; }
            private set { age = DateTime.Now.Year - ((DateTime)date).Year; }
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
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

        public override string ToString()
        {
            return $"name: {Name} ==> age: {Age} ==> group: {Group}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        private void Hello() { }
    }

   public static class StudentHelper
    {
        public static void FileHelper()
        {
            File.WriteAllText("test.txt", Student.Id.ToString());
        }
    }
}

