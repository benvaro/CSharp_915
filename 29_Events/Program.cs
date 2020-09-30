using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Events
{
    class Program
    {
        delegate void MyDelegate();

        class MyEvent
        {
            public event MyDelegate userEvent; // захищений делегат, дозволяємо лише += та -=
            // не допускається = (заміна) = null (очищення)
             
            public void OnSomethingHapping() //викликати, ініціювати виклик події
            {
                // if(userEvemt != null)   userEvent(); 
                userEvent?.Invoke();
            }
        }

        class User
        {
            public string Name { get; set; }
            public string LastName { get; set; }

            public void UserInfoHandler() // EventHandler - обробник події
            {
                Console.WriteLine("Event was initiated");
                Console.WriteLine($"By {Name} {LastName}");
            }
        }

        static void Main(string[] args)
        {
            MyEvent ev = new MyEvent();
            
            User u1 = new User { Name = "Andriy", LastName = "Poberezhnyi" };
            User u2 = new User { Name = "Olia", LastName = "Kulyk" };

            ev.userEvent += u1.UserInfoHandler;
            ev.userEvent += u2.UserInfoHandler;

            ev.OnSomethingHapping(); // 
       //     ev.userEvent = null; // помилка, бо оголосили як event
            ev.OnSomethingHapping();
        }
    }
}
