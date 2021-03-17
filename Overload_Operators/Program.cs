using System;

namespace Overload_Operators
{
    class Counter
    {
        public Counter() { }
        public int Count { get; set; }

        public static Counter operator -(Counter c1, Counter c2)
        {
            return new Counter { Count = c1.Count - c2.Count };
        }
        public static bool operator >(Counter c1, Counter c2)
        {
            if (c1.Count > c2.Count)
            {
                Console.WriteLine("c1 > c2");
                return true;
            }
            else if (c1.Count == c2.Count)
            {
                Console.WriteLine("c1 == c2");
                return true;
            }
            else
                return false;
        }
        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Count < c2.Count;
        }
        public static int operator *(Counter c1, int b)
        {
            return c1.Count * b;
        }
        public static Counter operator ++(Counter c1)
        {
            return new Counter { Count = c1.Count + 1 };
        }
        public static Counter operator --(Counter c2)
        {
            return new Counter { Count = c2.Count - 1 };
        }
        public static Counter operator +(Counter c1, Counter c2)
        {
            Counter c3 = new Counter();
            c3.Count = c1.Count + c2.Count;
            if (c3.Count >= 3)
            {
                Console.WriteLine("More 3... Operator -- worked!");
                c3.Count--;
            }
            return c3;
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            //Counter c1 = new Counter {Count = 15 };
            //Counter c2 = new Counter {Count = 25 };
            //Counter c3 = c1 + c2;
            //Console.WriteLine(c3.Count);
            //bool res = c1 > c2;
            //Console.WriteLine(res);
            //Console.WriteLine("***********");
            //int b = 9;
            //int res1 = c1.Count * b;
            //Console.WriteLine(res1);
            //c1++;
            //c2--;
            //Console.WriteLine(c1.Count);
            //Console.WriteLine(c2.Count);


            Counter c1 = new Counter() { Count = 2 };
            Counter c2 = new Counter() { Count = 2 };
            Counter c3 = c1 + c2;
            Console.WriteLine(c3.Count);
            if(c1 > c2)
            {
                Console.WriteLine("Opa");
            }
            else
                Console.WriteLine("Popa");

        }
    }
}
