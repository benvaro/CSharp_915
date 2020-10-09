using System;
using System.Runtime.Serialization;

namespace _39_Json
{
    [DataContract]
    class Car
    {
        public static Random rnd = new Random();
        private int Id;
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public Engine Engine { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Brand} {Model}, {Year}, {Engine}, {Price}$";
        }
    }

    [DataContract]
    public class Engine
    {
        [DataMember]
        public double Volume { get; set; }
        [DataMember]
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Volume}, {Name}";
        }
    }
}
