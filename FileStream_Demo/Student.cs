using System;
using System.Collections.Generic;
using System.Text;

namespace FileStream_Demo
{
    class Student
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public List<byte> Marks = new List<byte>() { 1, 2, 3, 4, 5, 6, 7 };
        public Student()
        {

        }
        public Student(string name,string course)
        {
            this.Name = name;
            this.Course = course;
        }
        public override string ToString()
        {
            return $"Name : {Name}\n" +
                $"Course : {Course}\n" +
                $"Marks : {String.Join("",Marks)}";

        }
        //public void WriteMarksInFile(int[] mark ,string fname)
        //{
        //    byte[] bytes = BitConverter.GetBytes(mark);

        //}
    }
}
