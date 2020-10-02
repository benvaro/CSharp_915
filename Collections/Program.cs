using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        // Узагальнені - List
        // Неузагальнені ?
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // boxing  -> object
            // unboxing
            list.Add("hello");
            list.Add(123);
            list.Add('f');

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            List<string> list2 = new List<string>();

            #region SortedList
            // SortedList sorted = new SortedList();
            // sorted.Add(5, "C#");
            // sorted.Add(3, "C++");
            // sorted.Add(1, "Java");
            // sorted.Add(7, "Python");
            // sorted.Add(19, "JavaScript");
            // sorted.Add(11, "Ruby");

            // Console.WriteLine(sorted[112]);
            // sorted[5] = "C++";
            //// sorted["112er"] = 123456; // error
            // Console.WriteLine();
            // Print(sorted);

            // if(sorted.ContainsKey(1))
            //     Console.WriteLine("Key 1 is in dictionary");

            // var res = sorted.GetByIndex(1);
            // Console.WriteLine(res);

            // res = sorted.GetKey(0);
            // Console.WriteLine(res); 
            #endregion

            var sorted = GenerateValues();
            // Print(sorted);

            var products = new SortedList<Product, int>();
            products.Add(new Product { Name = "Milk" }, 20);
            products.Add(new Product { Name = "Candy" }, 120);
            products.Add(new Product { Name = "Bread" }, 15);

            foreach (KeyValuePair<Product, int> item in products)
            {
                Console.WriteLine($"{item.Key.Name}------{item.Value}");
            }

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary[12] = "Ania";
            dictionary[12] = "Olia";
            dictionary[10] = "Ivan";
            dictionary[1] = "Oleg";

            //ICollection keys = dictionary.Keys;
            //ICollection values = dictionary.Values;

            PrintTemplate(dictionary);

            Queue q = new Queue(); // FIFO
            q.Enqueue(12);
            q.Enqueue(125);
            q.Enqueue(120);
            q.Dequeue();

            int a = (int)q.Peek();

            Stack<int> st = new Stack<int>(new[] { 1,3,4,5,6,78}); // FILO

            LinkedList<int> linked = new LinkedList<int>(new[] { 45, 23, 1, 76, -4 }); // double linked
            PrintTemplate(linked);
            Console.WriteLine();
            linked.Remove(1);
            linked.AddAfter(linked.Find(76), 1000);
            PrintTemplate(linked);

        }

        private static void Print(ICollection keys, ICollection values)
        {
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintTemplate<T, Y>(Dictionary<T, Y> dict)
        {
            foreach (KeyValuePair<T, Y> item in dict)
            {
                Console.WriteLine(item.Key + "_________" + item.Value);
            }
        }
        private static void PrintTemplate<T>(ICollection<T> dict)
        {
            foreach (var item in dict)
            {
                Console.Write($"{item, 5}");
            }
            Console.WriteLine();
        }
        private static IDictionary<string, string> GenerateValues()
        {
            var collection = new SortedList<string, string>();
            collection.Add("Rivne", "33000");
            collection.Add("Lviv", "35789");
            collection.Add("Dnipro", "64534");
            collection.Add("Kharkiv", "32111");

            return collection;
        }

        private static void Print(IDictionary sorted)
        {
            foreach (DictionaryEntry item in sorted)
            {
                Console.WriteLine($"{item.Key}------{item.Value}");
            }
        }
        private static void Print(IDictionary<string, string> sorted)
        {
            foreach (KeyValuePair<string, string> item in sorted)
            {
                Console.WriteLine($"{item.Key}------{item.Value}");
            }
        }

        class Product : IComparer<Product>, IComparable<Product>
        {
            public string Name { get; set; }

            public int Compare(Product x, Product y)
            {
                return x.Name.CompareTo(y.Name);
            }

            public int CompareTo(Product other)
            {
                return this.Name.CompareTo(other.Name);
            }
        }
    }
}
