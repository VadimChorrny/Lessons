using System;
using System.Collections.Generic;
using System.IO;

namespace Class_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "text.txt";
            File.WriteAllText(fname,"Hello world!\nSecond line\n");
            File.AppendAllText(fname, "Third line\n");
            List<string> lines = new List<string>() { "one", "two", "three" };
            File.AppendAllLines(fname,lines);
            Console.WriteLine($"Content of file : {File.ReadAllText(fname)}");
            string[] result = File.ReadAllLines(fname);
            if(File.Exists(fname))
            {
                Console.WriteLine($"Creating date : {File.GetCreationTime(fname)}");
                Console.WriteLine($"Creating date : {File.GetLastWriteTime(fname)}");
                File.SetAttributes(fname, FileAttributes.ReadOnly);
                Console.WriteLine($"Creating date : {File.GetCreationTimeUtc(fname)}");
            }
        }
    }
}
