using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Groups = _10_Class.Classes;

namespace _10_Class
{
    class Program
    {
        struct Dimensions
        {
         //   public const int width = 12;
         // readonly - поле для читання, ініціалізувати можна лише один раз і то в конструкторі
            public readonly int width;
            public readonly int height;

            // error
            //public Dimensions()
            //{
            //    width = 100;
            //    height = 250;
            //}

            public Dimensions(int w = 12, int h = 3)
            {
                width = w;
                height = h;
            }

            public void Print()
            {
                Console.WriteLine($"w: {width}, h: {height}");
            }

            public int S()
            {
                return width * height;
            }
        }
        static void Main(string[] args)
        {
            #region work with struct
            Dimensions dim = new Dimensions();
            dim.Print();
            //  dim.width = 5;
            //    dim.height = 3;

            dim.Print();
            Console.WriteLine(dim.S());

            //  Dimensions dim2 = new Dimensions() { width = 2, height = 12 };
            //    dim2.Print();

            Dimensions dim3 = new Dimensions(23, 1);
            dim3.Print();
            #endregion

            Console.Clear();

            Student st = new Student();
            //st.SetName("Viktor");
            //st.SetDate(new DateTime(2000, 12, 12));
            //st.SetAge(DateTime.Now.Year - st.GetDate().Year);
            st.Name = "Viktor";
            Console.WriteLine(st.Name);
          //  st.Print();
            //------
            Student st2 = new Student();
            st2.Print();

            Student st3 = new Student(age: 13, date: DateTime.Now, name: "Max");
            st3.Print();
            // st3.Age = 34; //error

            Student st4 = new Student
            {
                Name = "Ira",
                Date = new DateTime(2001, 7, 14)
            };
            st4.Group = "Pr1";
            st4.Print();
            Console.WriteLine("Group:" + st4.Group);

            Console.WriteLine("ID: {0}", Student.Id);
            Student.ShowId();

            StudentHelper.FileHelper();

            Console.WriteLine(st4);

            Groups.Group g = new Groups.Group();
            g.Students.Add(st4);
            g.Students.Add(st3);
            Console.WriteLine(g);
        }
    }
}
