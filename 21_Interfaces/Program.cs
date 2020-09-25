using _21_Interfaces.Classes;
using _21_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _21_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region demo interfaces
            Human h1 = new Human("Igor", 19);
            Human h2 = new Student("Alex", 22, "Programmer");
            Bee b1 = new Bee();
            Student s1 = new Student("Ira", 20, "Designer");
            Employee e1 = new Employee("Stepan", 34, "Builder");

            List<ICanWork> workers = new List<ICanWork>();
            workers.AddRange(new[] { (ICanWork)h1, h2, b1, s1, e1 });

            foreach (var item in workers)
            {
                item.DoWork();

            }
            h1.Run();
            Console.WriteLine();
            e1.DoWork();
            //(e1 as IWorker).DoWork();
            ((ICanWork)e1).DoWork();

            ICanFly bee2 = new Bee();
            ICanRun rr = new Student("Kostia", 15, "Blablabla");
            ((Student)rr).DoWork();

            var humans = workers.FindAll(x => x is Human);
            humans.ForEach(x => Console.WriteLine(x));
            int maxAge = humans.Max(x => (x as Human).Age);
            Console.WriteLine("Max age " + maxAge);
            #endregion

            Console.Clear();

            LinqDemo();
        }

        public static void LinqDemo()
        {
            // LINQ - language integrated query
            string[] games = new[] { "CS:GO", "Far Cry", "FIFA", "NFS", "Far Cry", "GTA 5", "Assasins", "World of Tanks" };

            //var game = from g in games
            //           where g.StartsWith("F")
            //           select g;
            var game = games.Where(x => x.StartsWith("F"));
            Print(game);

            //game = (from g in games
            //        orderby g descending
            //       select g).Distinct(); // унікальні значення

            game = games.Distinct();

            Print(game);

            //game = from g in games
            //       where g.StartsWith("F") || g.EndsWith("s")
            //       select g;

            game = games.Where(x => x.ToUpper().StartsWith("F") || x.ToUpper().EndsWith("S")).OrderByDescending(x => x);

            Print(game);
        }

        private static void Print(IEnumerable<string> game)
        {
            foreach (var item in game)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
