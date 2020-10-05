using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        class User<T> : IComparable<User<T>> where T : class, IComparable // struct, new(), BaseClass
        {
            public string Login { get; set; }  // null
            //int - 0
            public T Password { get; set; } = default;


            public int CompareTo(User<T> other)
            {
                return Login.CompareTo(other.Login);
            }
            public override string ToString()
            {
                return $"{Login} -- {Password}";
            }
        }
        class UserInfo
        {

        }
        static void Main(string[] args)
        {
            var users = new List<User<string>>();
            users.AddRange(new[]
            {
                new User<string>{Login = "admin", Password="1234"},
                new User<string>{Login = "user", Password="user"},
                new User<string>{Login = "manager", Password="manager"}
            });

            Sort(users.ToArray());
            Print(users.ToArray());
        }

        private static void Sort<T>(T[] list) where T : IComparable<T>
        {
            Array.Sort(list);
        }

        private static void Print<T>(T[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
