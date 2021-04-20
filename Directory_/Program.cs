using System;
using System.IO;

namespace Directory_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../..";
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"Path {path} " +
                    $"not fount!");
                return;
            }
            Directory.SetCurrentDirectory(path);
            Directory.CreateDirectory("Demo");
            Directory.CreateDirectory("Demo/Text");

            File.WriteAllText("Demo/Text/test.txt", "Demo line/Text/test.txt");

            //Directory.Delete("Demo",true);
            Console.WriteLine($"Parent dit : {Directory.GetParent(".")}"); // поточна папка
            Console.WriteLine("\n_________Directories");
            string[] dirs = Directory.GetDirectories(".");
            foreach (var item in dirs)
            {

                Console.WriteLine($"{Directory.GetCreationTime(item)}\t {Path.GetFileName(item),-10}{item} ");
            }


            Console.WriteLine("________FILES");
            string[] files = Directory.GetFiles(".");
            foreach (var item in files)
            {
                FileInfo fi = new FileInfo(item);
                Console.WriteLine($"{Path.GetFileName(item),-10},{File.GetCreationTime(item),-10},{fi.Length,-10}");

            }
            Console.WriteLine("\n_______DIRS AND FILES");

            string[] entries = Directory.GetFileSystemEntries(".");
            foreach (var item in entries)
            {
                string info;
                if (File.GetAttributes(item) != FileAttributes.Directory)
                {
                    FileInfo fi = new FileInfo(item);
                    info = $"{fi.Length}";
                    Console.WriteLine($"{Path.GetFileName(item),-10},{File.GetCreationTime(item),-10},{fi.Length,-10}");


                }
                else
                {
                    info = "<DIR>";
                }
            }


            DirectoryInfo di = new DirectoryInfo("d:/");
            Console.WriteLine("____________DIRECTORIES : ");
            foreach(var d in di.GetDirectories())
            {
                Console.WriteLine(d.Name);
            }
            Console.WriteLine("_____________FILES : ");
            foreach(var d in di.GetFiles())
            {
                Console.WriteLine(d.Name);
            }
        }
    }
}