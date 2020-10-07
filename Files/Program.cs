using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        // File, Directory - статичні
        // FileInfo, DirectoryInfo
        static void Main(string[] args)
        {
            #region Test Directory and Files
            //string name = @"C:\Windows";
            //DirectoryInfo info = new DirectoryInfo(name);
            //foreach (var item in info.GetFiles("*.exe"))
            //{
            //    Console.WriteLine("{0,20}{1,20}{2,30}{3,40}", 
            //        item.Name, item.Length, item.Attributes, item.LastAccessTime);
            //}

            //Console.ReadLine();
            //foreach (var item in info.GetDirectories())
            //{
            //    Console.WriteLine("{0,20}{1,20}{2,30}{3,40}",
            //        item.Name, item.FullName, item.Attributes, item.LastAccessTime);
            //} 
            #endregion
            #region Base work with Files 

            //DirectoryInfo newFolder = new DirectoryInfo("NewFolder");
            //newFolder.Create();
            //string source = "NewFolder\\info.txt";

            //File.WriteAllText(source, "Ivan Pylypei\nmanager");
            ////       File.ReadAllText("NewFolder\\info.txt");

            //if(!File.Exists("D:\\testFiles.txt"))
            // File.Copy(source, "D:\\testFiles.txt");

            //File.AppendAllText(source, DateTime.Now.ToLongTimeString());

            //File.Move(source, "D:\\test.info"); 
            #endregion

            string test = "C:\\test";
            string path = "subdir\\file.jpg";

            var result = Path.Combine(test, path);
            Console.WriteLine(result);

            Console.WriteLine(Path.GetFileName(result));

            Console.WriteLine(Path.GetExtension(result));

            Console.WriteLine("CurrentDirectory: {0}", Directory.GetCurrentDirectory());
            Directory.SetCurrentDirectory(@"D:\");
            Console.WriteLine(Directory.GetCurrentDirectory() + "> ");
            Console.WriteLine();

            DirectoryInfo info2 = new DirectoryInfo(Directory.GetCurrentDirectory());
            foreach (var item in info2.GetDirectories())
            {
                Console.WriteLine(item.Name);
            }
            string name = "lesson";
            DirectoryInfo info = new DirectoryInfo(name);
            info.Create();
        }
    }
}
