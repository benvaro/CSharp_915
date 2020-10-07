using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Drives
{
    class Program
    {
        static void Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", "Name", "FileSystem", "TotalSize", "Available");
            foreach (var item in drives)
            {
                Console.WriteLine("{0,-10}{2,-20}{1,-10}{3,-10}",
                                    item.Name, item.TotalFreeSpace/Math.Pow(2, 30), item.DriveFormat, item.AvailableFreeSpace/Math.Pow(2, 30));
            }
        }
    }
}
