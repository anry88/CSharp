using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6.Samples
{
    internal class Sample01
    {

        static void PrintDir(DirectoryInfo dir, string indent, bool lastDir)
        {
            Console.Write(indent);
            if (lastDir)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "│ ";
            }

            Console.WriteLine(dir.Name);

            DirectoryInfo[] dirs = dir.GetDirectories();
            
            //TODO: Доработать программу
            //FileInfo[] files = dir.GetFiles();
            
            for (int i = 0; i < dirs.Length; i++)
            {
                PrintDir(dirs[i], indent, i == dirs.Length - 1);
            }

        }

        static void Main(string[] args)
        {
            // Directory, File, FileInfo, DirectoryInfo

            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                Console.WriteLine($"FullName: {directoryInfo.FullName}");
                Console.WriteLine($"Name: {directoryInfo.Name}");
                Console.WriteLine($"Parent: {directoryInfo.Parent}");
                Console.WriteLine($"CreationTime: {directoryInfo.CreationTime}");
                Console.WriteLine($"Root: {directoryInfo.Root}");
            }

            Console.WriteLine();

            PrintDir(new DirectoryInfo(@"C:\sources\gb\csharp\Lesson5"), "", true);

            Console.ReadKey();

        }
    }
}
