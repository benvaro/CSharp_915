using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _38_XML
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

            using (FileStream fs = new FileStream("doc.xml", FileMode.Create))
            {
                XmlSerializer formatter = new XmlSerializer(cars.GetType()/*, new[] { typeof(Car), typeof(Engine)}*/);
                formatter.Serialize(fs, cars);
            }
            Console.WriteLine("\n\n");
            using (FileStream fs = new FileStream("doc.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Car>));
                var car = (List<Car>)formatter.Deserialize(fs);

                foreach (var item in car)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
