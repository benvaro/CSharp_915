using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;
namespace _23_StdInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Group gr = new Group();
            gr.Add(new Student { Name = "Ivan" });
            gr.Add(new Student { Name = "Ivanka" });
            gr.Add(new Student { Name = "Olia" });
            gr.Add(new Student { Name = "Katia" });

            //foreach (var item in gr)
            //{
            //    Console.WriteLine(gr);
            //}

            //gr[0] -- > Student[0]
            gr[0] = new Student { Name = "Ivan", Date = new DateTime(2000, 12, 12) } ;
            Console.WriteLine(gr[0]);
        }
    }
}
