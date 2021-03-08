using System;
using System.Linq;

namespace Params
{
    class Program
    { 
        static double AvgArray( params int[] arr) // learn
        {
            return arr.Average();
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Avg : {AvgArray(a)}");
            Console.WriteLine($"Avg : {AvgArray(10, 20, 30, 40, 50, 60, 777)}") ;
        }
    }
}
