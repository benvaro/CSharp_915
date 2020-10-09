using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _38_XML
{
   // [Serializable]
    public class Car // public classes for xml serialization
    {
        public static Random rnd = new Random();
        private int Id; // private will ignore
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        [XmlAttribute]
        public double Price { get; set; }

        public Engine Engine { get; set; }

        //public Car()
        //{
        //    Id = rnd.Next(10);
        //}

        public override string ToString()
        {
            return $"{Id}: {Brand} {Model}, {Year}, {Engine}, {Price}$";
        }
    }

  //  [Serializable]
    public class Engine
    {
        public double Volume { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Volume}, {Name}";
        }
    }
}
