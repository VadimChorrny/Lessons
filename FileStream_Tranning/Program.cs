using System;
using System.IO;
using System.Text;

namespace FileStream_Tranning
{

    static class FileWorker
    {
        public static void WriteString(string path,string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str); // конвертуємо стрінгу в масив з байтів
            using(FileStream fs = new FileStream(path,FileMode.Create))
            {
                fs.Write(bytes);    
            }
        }
        
        public static string ReedString(string path)
        {
            using(FileStream fs = new FileStream(path,FileMode.Open))
            {
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes);
                return Encoding.UTF8.GetString(bytes);
            }
        }

        public static void WriteInt(string path,int number)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            using(FileStream fs = new FileStream(path,FileMode.Create))
            {
                fs.Write(bytes);
            }
        }

        public static int ReedInt(string path)
        {
            using(FileStream fs = new FileStream(path,FileMode.Open))
            {
                byte[] bytes = new byte[(int)fs.Length]; // sizeof
                fs.Read(bytes);
                return BitConverter.ToInt32(bytes);
            }
        }

        public static void WriteLong(string path,long numb)
        {
            byte[] bytes = BitConverter.GetBytes(numb);
            using(FileStream fs = new FileStream(path,FileMode.Create))
            {
                fs.Write(bytes);
            }
        }

        public static long ReedLong(string path)
        {
            using(FileStream fs = new FileStream(path,FileMode.Open))
            {
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes);
                return BitConverter.ToInt64(bytes);
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string path = @"text.dat";

            string str = "Hello Vladislav!";
            long value = 100_000_000_000_000_000_0;

            FileWorker.WriteLong(path,value);
            Console.WriteLine($"File have :\n" +
                $"{FileWorker.ReedLong(path)}");

        }

    }
}
