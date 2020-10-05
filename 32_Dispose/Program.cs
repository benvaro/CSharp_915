using System;

namespace _32_Dispose
{
    class Program
    {
        class MyDbConnection : IDisposable
        {
            string nameDB;
            bool isOpen = false;

            public MyDbConnection()
            {
                Console.WriteLine("MyDbCOnnection is created; ");
            }
            public void Open(string nameDb)
            {
                this.nameDB = nameDb;
                isOpen = true;
                Console.WriteLine("DB {0} is opened", nameDB);
            }

            //призначений для звільнення некерованих ресурсів (з'єднання до бд,
            // дескриптори файлів, мережеві ресурси....
            public void Dispose()
            {
                Console.WriteLine("Dispose(). DB closed");
                isOpen = false;
                nameDB = null;
                GC.SuppressFinalize(this); // подавили виклик фіналізатора
            }

            ~MyDbConnection()
            {
                Console.WriteLine("Dtor(finalizer) Done.");
            }

            public bool IsOpen
            {
                get => isOpen;
            }
        }
        static void Main(string[] args)
        {
            MyDbConnection connection = new MyDbConnection();
            connection.Open("student.mdf");

            if (connection is IDisposable)
                connection.Dispose();
            Console.WriteLine();
            using (connection = new MyDbConnection()) // можемо використовувати ресурси, які реалізують IDisposable
            {
                connection.Open("student.mdf");
            }
        }
    }
}
