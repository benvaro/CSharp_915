using StudentLibrary;
using System;

namespace _11_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // internal - паблік для "своїх"
            // private 
            // public
            // protected
            // protected internal 

            Student st = new Student();
            //  StudentHelper.FileHelper();
            int? a = null; // int може містити null
            
            DateTime? t = null;  // null - ref type
            DateTime? dateTime = st.Date; // DateTime?  ===> Nullable<DateTime> 
            //if (dateTime == null)
            DateTime temp = new DateTime(2002, 1, 1);

       //     st.Date= dateTime??temp; // перевірка на null

            // Перевіряємо ім'я групи на null. Якщо не null - то викликаємо далі властивість Length. Інакше - повертаэмо null
            int? count = st.Group?.Length;
            Console.Clear();
            object obj = 45;
            int res = (int)obj;

            object str = "hello";
            string res2 = str.ToString();

            object newSt = new Student { Name = "Illya" };

            Console.WriteLine(newSt as Student); // Приведення до типу
            Console.WriteLine(res);
            Console.WriteLine(res2);
            string s = "lassen";
            string s1 = "la\u00dfen";
            Console.WriteLine(
            s.CompareTo(s1) == 0 ?
             "equals" : "not equals");
            Console.WriteLine(dateTime);
        }
    }
}
