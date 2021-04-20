using System;
using System.IO;

namespace FileStream_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../my.txt";
            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
            {
                Console.WriteLine("Dont found! Create new!");
                File.WriteAllText(path, "Demo file!");
                fi.Refresh();

            }

            Console.WriteLine($"Length file - {fi.Length}");
            Console.WriteLine($"Full-name {fi.FullName}");
            Console.WriteLine($"Name {fi.Name}");
            Console.WriteLine($"Exception {fi.Extension}");
            Console.WriteLine($"Directory name {fi.DirectoryName}");
            Console.WriteLine($"");

            if(File.Exists(path))
            {
                new FileInfo(path).Delete();
                Console.WriteLine("Delete file!");
            }
        }
    }
}
