using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Equals
{
    class Program
    {
        struct SomeStruct // value type
        {
            public int value;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 }, arr2 = { 1, 2, 3 };  // масиви - типи посилань
            int[] arr3 = arr1; //? 
            Console.WriteLine("_____Test arrays (ref types) ______");

            Console.WriteLine($"ReferenceEquals(arr1, arr2) = {ReferenceEquals(arr1, arr2)}"); // false
            Console.WriteLine($"Equals(arr1, arr2) = {Equals(arr1, arr2)}"); // ??? true i want

            Console.WriteLine($"ReferenceEquals(arr1, arr3) = {ReferenceEquals(arr1, arr3)}"); // true
            Console.WriteLine($"Equals(arr1, arr3) = {Equals(arr1, arr3)}"); // ??? true i want

            Console.WriteLine("\n____Test value types ____");
            int first = 11, second = 11; // value types?
            Console.WriteLine($"ReferenceEquals(int first, int second) = {ReferenceEquals(first, second)}"); // перед порівнянням first, second пакуються в object - false
            Console.WriteLine($"Equals(int first, int second) = {Equals(first, second)}"); // 

            SomeStruct some1 = new SomeStruct() { value = 12 };
            SomeStruct some2 = new SomeStruct() { value = 12 };
            Console.WriteLine($"ReferenceEquals(struct first, struct second) = {ReferenceEquals(some1, some2)}"); //  false
            Console.WriteLine($"Equals(struct first, struct second) = {/*Equals(some1, some2)*/Object.Equals(some1, some2)}"); // true

            Console.Clear();
            Console.WriteLine("\n___Test Dog_____");
            Dog d1 = new Dog("Taxa");
            Dog d2 = new Dog("Taxa");

            Dog d3 = new Dog("Malamute");
            Dog d4 = d3;

            Dog d5 = null;
            Dog d6 = null;

            Console.WriteLine($"ReferenceEquals(null, null) = {ReferenceEquals(d5, d6)}"); // true
            Console.WriteLine($"Equals(null, null) = {Equals(d5, d6)}"); // true

            Console.WriteLine($"ReferenceEquals(d3, d4) = {ReferenceEquals(d3, d4)}"); // true
            Console.WriteLine($"Equals(d3, d4) = {Equals(d3, d4)}"); // true

            Console.WriteLine($"ReferenceEquals(d1, d2) = {ReferenceEquals(d1, d2)}"); // false
            Console.WriteLine($"Equals(d1, d2) = {Equals(d1, d2)}"); // true i want
            Console.WriteLine($"d1.Equals(d2) = {d1.Equals(d2)}"); // true i want
        }

        public class Dog
        {
            public string breed;
            public Dog(string _breed)
            {
                breed = _breed;
            }

            public override bool Equals(object obj)  //this obj
            {
                if (obj == null || !(obj is Dog))
                    return false;
                return this.breed == ((Dog)obj).breed; // (obj as Dog).breed
            }

            public override int GetHashCode()
            {
                return breed.GetHashCode(); // ^ | 
            }


        }
    }
}
