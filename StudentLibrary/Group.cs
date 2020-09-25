using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Group: IEnumerable
    {
        List<Student> Students { get; set; } = new List<Student>();
        public int Id { get; set; } = 23;
        public Group()
        {
            Students = new List<Student>();
        }

        public void Add(Student st)
        {
            Students.Add(st);
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in Students)
            {
                result += item.ToString() + Environment.NewLine;  // "\n"
            }
            return result;
        }

        public Student this [int index]
        {
            get
            {
                if (index < 0 || index > Students.Count)
                    throw new IndexOutOfRangeException();
                return Students[index];
            }
            set
            {
                if (index < 0 || index > Students.Count)
                    throw new IndexOutOfRangeException();
                Students[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Students)
            {
                yield return item; // повертаэ управління викликаючому методу, але зберігає стан даного метода
                // це гарантує продовження виконання даного метода
            }

           // return Students.GetEnumerator();
        }
    }
}
