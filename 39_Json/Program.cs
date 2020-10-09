using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace _39_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car()
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

            using (FileStream fs = new FileStream("car.json", FileMode.Create))
            {
                DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<Car>));
                formatter.WriteObject(fs, cars);
            }

            using (FileStream fs = new FileStream("car.json", FileMode.Open))
            {
                DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<Car>));
                cars = (List<Car>)formatter.ReadObject(fs);
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
