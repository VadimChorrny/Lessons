using System;

namespace Events
{
    public delegate bool MyPredicate(int number);
    static class Array_Extension
    {
        public static int CountElements(this int[] arr, MyPredicate predicate)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                if (predicate(item))
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("false number");
                }
            }
            return counter;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, -7 };
            Console.WriteLine(arr.CountElements(x => x % 2 == 0));
        }
    }
}
