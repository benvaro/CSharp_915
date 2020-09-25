using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Comparer
{
    class Program
    {
        struct Product : IComparable, IComparable<Product>
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public Product(string name, int price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Name} ==== {Price}";
            }

            public int CompareTo(object obj)
            {
                return obj is Product ? this.Price.CompareTo(((Product)obj).Price) 
                    : throw new InvalidCastException();
            }

            public int CompareTo(Product other)
            {
                return this.Price.CompareTo(other.Price);
            }
        }
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(new Product("Milk", 19));
            array.Add(new Product("Bread", 80));
            array.Add(new Product("Candy", 123));
            array.Add(new Product("Water", 16));
            array.Add(new Product("Apple", 14));

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
