using System;

namespace Indexator
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user[0] = 4; // it is indexator
            Person person = new Person();
            person[0] = "John";
            Matrix matrix = new Matrix();
            matrix[1, 5] = 4;
        }
    }
    public class User
    {
        private int[] array = new int[5];
        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }

    public class Person
    {
        private String[] array = new string[5];
        public string this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
    public class Matrix
    {
        private int[,] array = new int[5, 5];
        public int this[int i,int j]
        {
            get => array[i,j];
            set => array[i,j] = value;
        }
    }
   

}
