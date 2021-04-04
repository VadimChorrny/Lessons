using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStream_Demo
{
    static class FS
    {
        public static void WriteInt(int number, string fname)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            using (FileStream fstream = new FileStream(fname, FileMode.Create))
            {
                fstream.Write(bytes);
            }

        }
        public static int ReedInt(string fname)
        {
            using (FileStream fstream = new FileStream(fname, FileMode.Create))
            {
                byte[] bytes = new byte[sizeof(int)];
                fstream.Read(bytes);
                return BitConverter.ToInt32(bytes);
            }

        }
        public static void WriteString(string str, string fname)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            byte len = (byte)bytes.Length; // спрощено - важаємо, що рядок має довжину <= 255
            using (FileStream fstream = new FileStream(fname, FileMode.Create))
            {
                fstream.WriteByte(len); // записали довжину байтового масиву(сконвертованого рядка)
                fstream.Write(bytes);
            }

        }
        public static string ReedString(string fname)
        {
            using (FileStream fstream = new FileStream(fname, FileMode.Open))
            {
                byte len = (byte)fstream.ReadByte();
                byte[] bytes = new byte[len];

                fstream.Read(bytes);
                return Encoding.UTF8.GetString(bytes);
            }
        }

        public static void WriteObject(Student student, string fname)
        {
            // input name
            byte[] bytes = Encoding.UTF8.GetBytes(student.Name);
            byte len = (byte)bytes.Length;
            using (FileStream fstream = new FileStream(fname, FileMode.Create))
            {
                fstream.WriteByte(len);
                fstream.Write(bytes);

                // input course
                byte[] bytes1 = Encoding.UTF8.GetBytes(student.Course);
                byte len1 = (byte)bytes1.Length;
                fstream.WriteByte(len1);
                fstream.Write(bytes1);

                // input marks

                byte[] bytes2 = new byte[student.Marks.Count];
                foreach (var item in student.Marks)
                {
                    bytes2 = BitConverter.GetBytes(item);
                    fstream.Write(bytes2, 0, sizeof(int));
                }

            }
        }

        public static Student ReedWithFile(string fname)
        {
            Student student = new Student();
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                //byte len = (byte)fs.ReadByte();
                //byte[] bytes = new byte[len];
                //fs.Read(bytes);
                //return Encoding.UTF8.GetString(bytes);
                byte[] bytes = new byte[sizeof(int)];
                fs.Read(bytes);
                student.Name = Encoding.UTF8.GetString(bytes);

                byte[] bytesName = new byte[sizeof(int)];
                fs.Read(bytesName);
                student.Course = Encoding.UTF8.GetString(bytesName);

                fs.Read(bytes);
                for (int i = 0; i < student.Marks.Count; i++)
                {
                    student.Marks[i] = bytes[i];
                }
                //List<int> marks = new List<int>();
                //while(fs.Position != fs.Length)
                //{
                //    fs.Read(bytes, 0, sizeof(int));
                //    int mark = BitConverter.ToInt32(bytes, 0);
                //    marks.Add(mark);
                //}
                //int mqty = fs.ReadByte();
                //byte[] marksint = new byte[mqty];
                //fs.Read(marksint);

                return student;
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //string fname = "demo.dat";
            ////int value = 12345;
            ////FS.WriteInt(value, fname);
            ////Console.WriteLine($"Int is : {FS.ReedInt(fname)}");
            //string text = "Hello! Привіт!";
            //FS.WriteString(text, fname);
            //Console.WriteLine($"---- {FS.ReedString(fname)}");
            Student student = new Student() { Name = "Igor", Course = "Five" };
            student.Marks.Add(12);
            student.Marks.Add(11);
            student.Marks.Add(10);
            string fname = @"test.dat";
            FS.WriteObject(new Student("Igor","Five"), fname);
            Console.WriteLine($"Output {FS.ReedWithFile(fname)}");
        }
    }
}
