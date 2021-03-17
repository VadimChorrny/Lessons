using System;

namespace Corteg
{
    class Program
    {
        static Tuple<string,int> Corteg(string name,int age)
        {
            int sqr = age * age;
            int sqrt = (int)(Math.Sqrt(age));
            string sname = "Hi, " + name;

            return Tuple.Create<string, int>(sname,sqrt);
        }
        static void Main(string[] args)
        {

            Console.WriteLine($"{Corteg("Her", 19)}");
        }
    }
}
