using StudentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DLR_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test dynamic
            //var res = "string";

            //dynamic value = 234;

            //value = "string";
            //value = new Student { Name = "Bill" };
            //value.Print();
            //Console.WriteLine(value.GetType()); 
            #endregion

            // Reflection

            Assembly asm = Assembly.Load("StudentLibrary");
            var types = asm.GetTypes();
            foreach (Type item in types)
            {
                Console.WriteLine(item.FullName);

                foreach (MemberInfo member in item.GetMembers())
                {
                    Console.WriteLine($"\t{member.MemberType} {member.Name}");

                    if(member is MethodInfo)
                    {
                       var parameters = (member as MethodInfo).GetParameters();
                        foreach (var param in parameters)
                        {
                            Console.WriteLine("\t\t{0} --- {1}", param.ParameterType, param.Name);
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }

            Console.Clear();

            Type type = asm.GetType("StudentLibrary.Student");
            Console.WriteLine(type.FullName);

            var obj = Activator.CreateInstance(type, new[] { "Bill"});
            Console.WriteLine(obj);
           var m = type.GetMethods(BindingFlags.NonPublic |  BindingFlags.DeclaredOnly | BindingFlags.Instance);

            var print = type.GetMethod("Print");
            print.Invoke(obj, null);

            var show = type.GetMethod("ShowId");
            show.Invoke(null, null);
        }

    }
}
