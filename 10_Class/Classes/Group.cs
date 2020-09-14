using System;
using System.Collections.Generic;

namespace _10_Class.Classes
{
    public class Group
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public int Id { get; set; } = 23;
        public Group()
        {
            Students = new List<Student>();
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
    }
}
