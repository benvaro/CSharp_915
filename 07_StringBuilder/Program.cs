using System;
using System.Text;

namespace _07_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // динамічний рядок
            StringBuilder builder = new StringBuilder(200);
            builder.Append(new string('_', 210));
            Console.WriteLine($"Length: {builder.Length}, capacity: {builder.Capacity}");
            Console.WriteLine(builder);

            builder.Remove(50, 150);
            builder.Replace('_', '*');
            Console.WriteLine(builder);
        }
    }
}
// Відсортувати елементи в підмасивах рваного масиву.
//Розмірність рандомна, к-сть елементів в підмасивах - рандом, елементи - рандом