using System;

namespace Null_
{
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine(myArray?.Length);
            
        }
    }
}
