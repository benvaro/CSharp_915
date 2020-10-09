using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _37_Serialization
{
    class Program
    {
        public static Random rnd = new Random();
        [Serializable]
        class Car
        {
            [NonSerialized]
            private int Id;
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }

            public Engine Engine { get; set; }

            public Car()
            {
                Id = rnd.Next(10);
            }

            public override string ToString()
            {
                return $"{Id}: {Brand} {Model}, {Year}, {Engine}, {Price}$";
            }
        }

        [Serializable] // даний атрибут НЕ НАСЛІДУЄТЬСЯ!
        class NewCar : Car
        {

        }
        [Serializable]
        class Engine
        {
            public double Volume { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Volume}, {Name}";
            }
        }
        static void Main()
        {
            // 1) binary writer/reader - stream
            // 2) File.WriteAllText  File.WriteAllBytes  File.WriteAllLines
            // File.WriteAllLines

            //Серіалізація - спосіб потокового збереження об'єкта в файл
            // Десеріалізація - спосіб відновлення об'єкта із файла

            Car c = new NewCar()
            {
                Brand = "VW",
                Model = "LT 35",
                Year = 2008,
                Price = 10000,
                Engine = new Engine
                {
                    Name = "Brazil",
                    Volume = 2.8
                }
            };

            List<Car> cars = new List<Car>();
            cars.AddRange(new[]
            { c,
                new Car
                { Brand = "Audi", Model = "A6", Price = 6000, Year = 2004, Engine = new Engine { Volume = 2.5, Name = "TDI" } } });
            Print(cars);

            using (FileStream fs = new FileStream("binary.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, cars);
            }
            Console.WriteLine("\n\n");
            using (FileStream fs = new FileStream("binary.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                var car = (List<Car>)formatter.Deserialize(fs);

               
            }
        }

        private static void Print(List<Car> cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }

    [Serializable]
    class CarDTO
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public EngineDTO Engine { get; set; }

    }

    [Serializable]
    class EngineDTO
    {
        public double Volume { get; set; }
        public string Name { get; set; }
    }
}
